using StorageCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageCalculator.Common;

namespace StorageCalculator
{
    public partial class FormMain : Form
    {
        private StorageInfo _storage;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _storage = StorageInfoLoader.Load();
                ReloadInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.CRITICAL_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// перезагрузка данных на форме
        /// </summary>
        private void ReloadInfo()
        {
            try
            {
                if (_storage == null)
                {
                    throw new Exception("storage settings is missing!");
                }

                labelStorageHeight.Text = _storage.Y.ToString();
                labelStorageWight.Text = _storage.X.ToString();
                labelStorageDeep.Text = _storage.Z.ToString();

                labelCargoHeigh.Text = _storage.CargoType.Y.ToString();
                labelCargoWidth.Text = _storage.CargoType.X.ToString();
                labelCargoDeep.Text = _storage.CargoType.Z.ToString();

                labelMaxCapacity.Text = _storage.CalculateMaxCapacity().ToString();
                labelOccupancy.Text = _storage.CalculateOccupancy().ToString();
                labelFreeSpace.Text = _storage.CalculateFreeSpace().ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_storage != null)
                {
                    StorageInfoLoader.Save(_storage);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.CRITICAL_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditStorage_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;

                EditBox editStorage = new EditBox(button?.Text, _storage);

                editStorage.ShowDialog();

                if (editStorage.X < 0 || editStorage.Y < 0 || editStorage.Z < 0)
                {
                    throw new Exception(ErrorConstants.WRONG_STORAGE_SIZE);
                }

                if (editStorage.X < _storage.CargoType.X || editStorage.Y < _storage.CargoType.Y || editStorage.Z < _storage.CargoType.Z)
                {
                    throw new Exception(ErrorConstants.WRONG_STORAGE_SIZE);
                }

                _storage.Y = editStorage.Y;
                _storage.X = editStorage.X;
                _storage.Z = editStorage.Z;

                StorageInfoLoader.Save(_storage);

                ReloadInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditCargo_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;

                EditBox editCargo = new EditBox(button?.Text, _storage.CargoType);

                editCargo.ShowDialog();

                if (editCargo.X < 0 || editCargo.Y < 0 || editCargo.Z < 0)
                {
                    throw new Exception(ErrorConstants.WRONG_CARGO_SIZE);
                }

                if (editCargo.X > _storage.X || editCargo.Y > _storage.Y || editCargo.Z > _storage.Z)
                {
                    throw new Exception(ErrorConstants.WRONG_CARGO_SIZE);
                }

                _storage.CargoType.Y = editCargo.Y;
                _storage.CargoType.X = editCargo.X;
                _storage.CargoType.Z = editCargo.Z;

                StorageInfoLoader.Save(_storage);

                ReloadInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddCargoState_Click(object sender, EventArgs e)
        {
            try
            {
                AddStateInfo addState = new AddStateInfo();

                addState.ShowDialog();

                if (addState.ContainersCount < 0 || addState.ContainersCount > _storage.CalculateMaxCapacity())
                {
                    throw new Exception(ErrorConstants.WRONG_STORAGE_STATE);
                }

                StorageStateInfo info = new StorageStateInfo();

                info.TimeChange = addState.ArrivingTime;

                info.StorageFullness = addState.ContainersCount;

                info.StorageCapacity = _storage.CalculateMaxCapacity();

                _storage.AddChangeInfo(info);

                StorageInfoLoader.Save(_storage);

                ReloadInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculateLoadDensity_Click(object sender, EventArgs e)
        {
            try
            {
                List<StorageStateInfo> changes = _storage.CloneChangeInfos;

                if (changes.Count == 0)
                {
                    return;
                }

                DateTime from = dateTimePickerFrom.Value.Date;

                DateTime to = dateTimePickerTo.Value.Date;

                if (to.Ticks < from.Ticks)
                {
                    throw new Exception(ErrorConstants.WRONG_TIME_SELECT);
                }

                List<int> fullness = new List<int>();
                List<int> capacities = new List<int>();
                List<DateTime> dates = new List<DateTime>();

                List<StorageStateInfo> selected = new List<StorageStateInfo>();

                foreach (StorageStateInfo info in changes)
                {
                    if (info.TimeChange.Date >= from && info.TimeChange.Date <= to)
                    {
                        fullness.Add(info.StorageFullness);
                        capacities.Add(info.StorageCapacity);
                        dates.Add(info.TimeChange);
                        selected.Add(info);
                    }
                }

                if (selected.Count == 0)
                {
                    return;
                }

                dataGridViewLodDensity.DataSource = selected;
                
                chartLoadDensity.Series[0].Points.DataBindXY(dates, fullness);
                chartLoadDensity.Series[1].Points.DataBindXY(dates, capacities);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
