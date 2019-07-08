namespace StorageCalculator
{
    partial class AddStateInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelContainersCount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxContainersCount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerArriving = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 136);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelContainersCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxContainersCount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerArriving, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 102);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelContainersCount
            // 
            this.labelContainersCount.AutoSize = true;
            this.labelContainersCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelContainersCount.Location = new System.Drawing.Point(3, 12);
            this.labelContainersCount.Name = "labelContainersCount";
            this.labelContainersCount.Size = new System.Drawing.Size(213, 13);
            this.labelContainersCount.TabIndex = 0;
            this.labelContainersCount.Text = "Containers count";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTime.Location = new System.Drawing.Point(3, 62);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(213, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Arriving time";
            // 
            // textBoxContainersCount
            // 
            this.textBoxContainersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContainersCount.Location = new System.Drawing.Point(3, 28);
            this.textBoxContainersCount.Name = "textBoxContainersCount";
            this.textBoxContainersCount.Size = new System.Drawing.Size(213, 20);
            this.textBoxContainersCount.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(3, 111);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(219, 22);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerArriving
            // 
            this.dateTimePickerArriving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerArriving.Location = new System.Drawing.Point(3, 78);
            this.dateTimePickerArriving.Name = "dateTimePickerArriving";
            this.dateTimePickerArriving.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerArriving.TabIndex = 4;
            // 
            // AddStateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 136);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddStateInfo";
            this.Text = "Add storage state info";
            this.Load += new System.EventHandler(this.AddStateInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelContainersCount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxContainersCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerArriving;
        private System.Windows.Forms.Button buttonSave;
    }
}