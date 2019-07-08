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
using StorageCalculator.Interfaces;

namespace StorageCalculator
{
    public partial class EditBox : Form, IBoxable
    {
        private string _name;
        private bool _isTimePickerVisible;

        public EditBox(string name, IBoxable box, bool isTimePickerVisible)
        {
            InitializeComponent();

            _name = name;
            _isTimePickerVisible = isTimePickerVisible;
            Y = box.Y;
            X = box.X;
            Z = box.Z;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Y = int.Parse(textBoxHeigth.Text);
                X = int.Parse(textBoxWidth.Text);
                Z = int.Parse(textBoxDeep.Text);
                ChangeTime = dateTimePickerChange.Value;

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorConstants.WRONG_DATA, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int Y { get; set; }
        public int X { get; set; }
        public int Z { get; set; }
        public DateTime ChangeTime { get; set; }

        private void EditBox_Load(object sender, EventArgs e)
        {
            this.Text = _name;

            dateTimePickerChange.Visible = _isTimePickerVisible;

            textBoxHeigth.Text = Y.ToString();
            textBoxWidth.Text = X.ToString();
            textBoxDeep.Text = Z.ToString();
        }
    }
}
