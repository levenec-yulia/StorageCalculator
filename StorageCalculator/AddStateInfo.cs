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
    /// <summary>
    /// Обработчик формы добавления груза
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddStateInfo : Form
    {
        public AddStateInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик кнопки сохранения
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //пытаемся преобразовать данные из текстбокса
                ContainersCount = int.Parse(textBoxContainersCount.Text);

                //сохраняем дару отгрузки/загрузки
                ArrivingTime = dateTimePickerArriving.Value;

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorConstants.WRONG_DATA, ErrorConstants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Время загрузки/отгрузки
        /// </summary>
        /// <value>
        /// The arriving time.
        /// </value>
        public DateTime ArrivingTime { get; set; }

        /// <summary>
        /// Кол-во отгружаемых контейнеров
        /// </summary>
        /// <value>
        /// The containers count.
        /// </value>
        public int ContainersCount { get; set; }

        private void AddStateInfo_Load(object sender, EventArgs e)
        {
            ArrivingTime = DateTime.Now;

            //поумолчанию колличество контейнеров -1 это даст возможность отследить действия пользователя
            ContainersCount = -1;
        }
    }
}
