namespace StorageCalculator
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStorageInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelMaxCapacity = new System.Windows.Forms.Label();
            this.labelOccupancy = new System.Windows.Forms.Label();
            this.labelFreeSpace = new System.Windows.Forms.Label();
            this.buttonAddCargoState = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCargoHeigh = new System.Windows.Forms.Label();
            this.labelCargoWidth = new System.Windows.Forms.Label();
            this.labelCargoDeep = new System.Windows.Forms.Label();
            this.buttonEditCargo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStorageHeight = new System.Windows.Forms.Label();
            this.labelStorageWight = new System.Windows.Forms.Label();
            this.labelStorageDeep = new System.Windows.Forms.Label();
            this.buttonEditStorage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.chartLoadDensity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStorageCapacity = new System.Windows.Forms.DataGridView();
            this.dataGridViewLodDensity = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculateLoadDensity = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageStorageInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageChart.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadDensity)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLodDensity)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(797, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStorageInfo);
            this.tabControl.Controls.Add(this.tabPageChart);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(797, 337);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageStorageInfo
            // 
            this.tabPageStorageInfo.Controls.Add(this.tableLayoutPanel1);
            this.tabPageStorageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageStorageInfo.Name = "tabPageStorageInfo";
            this.tabPageStorageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStorageInfo.Size = new System.Drawing.Size(789, 311);
            this.tabPageStorageInfo.TabIndex = 0;
            this.tabPageStorageInfo.Text = "Storage Info";
            this.tabPageStorageInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(777, 97);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label16, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelMaxCapacity, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelOccupancy, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelFreeSpace, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonAddCargoState, 3, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(771, 55);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Location = new System.Drawing.Point(3, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Max capacity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label16.Location = new System.Drawing.Point(195, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Occupancy";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label17.Location = new System.Drawing.Point(387, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Free space";
            // 
            // labelMaxCapacity
            // 
            this.labelMaxCapacity.AutoSize = true;
            this.labelMaxCapacity.Location = new System.Drawing.Point(3, 27);
            this.labelMaxCapacity.Name = "labelMaxCapacity";
            this.labelMaxCapacity.Size = new System.Drawing.Size(31, 13);
            this.labelMaxCapacity.TabIndex = 3;
            this.labelMaxCapacity.Text = "none";
            // 
            // labelOccupancy
            // 
            this.labelOccupancy.AutoSize = true;
            this.labelOccupancy.Location = new System.Drawing.Point(195, 27);
            this.labelOccupancy.Name = "labelOccupancy";
            this.labelOccupancy.Size = new System.Drawing.Size(31, 13);
            this.labelOccupancy.TabIndex = 4;
            this.labelOccupancy.Text = "none";
            // 
            // labelFreeSpace
            // 
            this.labelFreeSpace.AutoSize = true;
            this.labelFreeSpace.Location = new System.Drawing.Point(387, 27);
            this.labelFreeSpace.Name = "labelFreeSpace";
            this.labelFreeSpace.Size = new System.Drawing.Size(31, 13);
            this.labelFreeSpace.TabIndex = 5;
            this.labelFreeSpace.Text = "none";
            // 
            // buttonAddCargoState
            // 
            this.buttonAddCargoState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddCargoState.Location = new System.Drawing.Point(579, 30);
            this.buttonAddCargoState.Name = "buttonAddCargoState";
            this.buttonAddCargoState.Size = new System.Drawing.Size(189, 22);
            this.buttonAddCargoState.TabIndex = 6;
            this.buttonAddCargoState.Text = "Add cargo state";
            this.buttonAddCargoState.UseVisualStyleBackColor = true;
            this.buttonAddCargoState.Click += new System.EventHandler(this.buttonAddCargoState_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(193, 31);
            this.label21.TabIndex = 1;
            this.label21.Text = "Storage State";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(777, 95);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelCargoHeigh, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelCargoWidth, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelCargoDeep, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonEditCargo, 3, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(771, 54);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(195, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(387, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Deep";
            // 
            // labelCargoHeigh
            // 
            this.labelCargoHeigh.AutoSize = true;
            this.labelCargoHeigh.Location = new System.Drawing.Point(3, 27);
            this.labelCargoHeigh.Name = "labelCargoHeigh";
            this.labelCargoHeigh.Size = new System.Drawing.Size(31, 13);
            this.labelCargoHeigh.TabIndex = 3;
            this.labelCargoHeigh.Text = "none";
            // 
            // labelCargoWidth
            // 
            this.labelCargoWidth.AutoSize = true;
            this.labelCargoWidth.Location = new System.Drawing.Point(195, 27);
            this.labelCargoWidth.Name = "labelCargoWidth";
            this.labelCargoWidth.Size = new System.Drawing.Size(31, 13);
            this.labelCargoWidth.TabIndex = 4;
            this.labelCargoWidth.Text = "none";
            // 
            // labelCargoDeep
            // 
            this.labelCargoDeep.AutoSize = true;
            this.labelCargoDeep.Location = new System.Drawing.Point(387, 27);
            this.labelCargoDeep.Name = "labelCargoDeep";
            this.labelCargoDeep.Size = new System.Drawing.Size(31, 13);
            this.labelCargoDeep.TabIndex = 5;
            this.labelCargoDeep.Text = "none";
            // 
            // buttonEditCargo
            // 
            this.buttonEditCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditCargo.Location = new System.Drawing.Point(579, 30);
            this.buttonEditCargo.Name = "buttonEditCargo";
            this.buttonEditCargo.Size = new System.Drawing.Size(189, 21);
            this.buttonEditCargo.TabIndex = 6;
            this.buttonEditCargo.Text = "Edit cargo";
            this.buttonEditCargo.UseVisualStyleBackColor = true;
            this.buttonEditCargo.Click += new System.EventHandler(this.buttonEditCargo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 31);
            this.label14.TabIndex = 1;
            this.label14.Text = "Cargo Info";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 95);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelStorageHeight, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelStorageWight, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelStorageDeep, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.buttonEditStorage, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(771, 54);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(195, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(387, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Deep";
            // 
            // labelStorageHeight
            // 
            this.labelStorageHeight.AutoSize = true;
            this.labelStorageHeight.Location = new System.Drawing.Point(3, 27);
            this.labelStorageHeight.Name = "labelStorageHeight";
            this.labelStorageHeight.Size = new System.Drawing.Size(31, 13);
            this.labelStorageHeight.TabIndex = 3;
            this.labelStorageHeight.Text = "none";
            // 
            // labelStorageWight
            // 
            this.labelStorageWight.AutoSize = true;
            this.labelStorageWight.Location = new System.Drawing.Point(195, 27);
            this.labelStorageWight.Name = "labelStorageWight";
            this.labelStorageWight.Size = new System.Drawing.Size(31, 13);
            this.labelStorageWight.TabIndex = 4;
            this.labelStorageWight.Text = "none";
            // 
            // labelStorageDeep
            // 
            this.labelStorageDeep.AutoSize = true;
            this.labelStorageDeep.Location = new System.Drawing.Point(387, 27);
            this.labelStorageDeep.Name = "labelStorageDeep";
            this.labelStorageDeep.Size = new System.Drawing.Size(31, 13);
            this.labelStorageDeep.TabIndex = 5;
            this.labelStorageDeep.Text = "none";
            // 
            // buttonEditStorage
            // 
            this.buttonEditStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditStorage.Location = new System.Drawing.Point(579, 30);
            this.buttonEditStorage.Name = "buttonEditStorage";
            this.buttonEditStorage.Size = new System.Drawing.Size(189, 21);
            this.buttonEditStorage.TabIndex = 6;
            this.buttonEditStorage.Text = "Edit storage";
            this.buttonEditStorage.UseVisualStyleBackColor = true;
            this.buttonEditStorage.Click += new System.EventHandler(this.buttonEditStorage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Storage Info";
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.tableLayoutPanel8);
            this.tabPageChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(789, 311);
            this.tabPageChart.TabIndex = 1;
            this.tabPageChart.Text = "Load density";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(783, 305);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.chartLoadDensity, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel13, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(777, 238);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // chartLoadDensity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLoadDensity.ChartAreas.Add(chartArea1);
            this.chartLoadDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartLoadDensity.Legends.Add(legend1);
            this.chartLoadDensity.Location = new System.Drawing.Point(3, 3);
            this.chartLoadDensity.Name = "chartLoadDensity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Load density";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Capacity";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chartLoadDensity.Series.Add(series1);
            this.chartLoadDensity.Series.Add(series2);
            this.chartLoadDensity.Size = new System.Drawing.Size(382, 232);
            this.chartLoadDensity.TabIndex = 0;
            this.chartLoadDensity.Text = "Load density chart";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.dataGridViewStorageCapacity, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.dataGridViewLodDensity, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(391, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(383, 232);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // dataGridViewStorageCapacity
            // 
            this.dataGridViewStorageCapacity.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridViewStorageCapacity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorageCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStorageCapacity.Location = new System.Drawing.Point(194, 3);
            this.dataGridViewStorageCapacity.Name = "dataGridViewStorageCapacity";
            this.dataGridViewStorageCapacity.Size = new System.Drawing.Size(186, 226);
            this.dataGridViewStorageCapacity.TabIndex = 3;
            // 
            // dataGridViewLodDensity
            // 
            this.dataGridViewLodDensity.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLodDensity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLodDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLodDensity.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLodDensity.Name = "dataGridViewLodDensity";
            this.dataGridViewLodDensity.Size = new System.Drawing.Size(185, 226);
            this.dataGridViewLodDensity.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.buttonCalculateLoadDensity, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 247);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(777, 55);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.dateTimePickerTo, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(262, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(253, 49);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(3, 27);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.dateTimePickerFrom, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(253, 49);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(3, 27);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // buttonCalculateLoadDensity
            // 
            this.buttonCalculateLoadDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculateLoadDensity.Location = new System.Drawing.Point(521, 3);
            this.buttonCalculateLoadDensity.Name = "buttonCalculateLoadDensity";
            this.buttonCalculateLoadDensity.Size = new System.Drawing.Size(253, 49);
            this.buttonCalculateLoadDensity.TabIndex = 2;
            this.buttonCalculateLoadDensity.Text = "Calculate load density";
            this.buttonCalculateLoadDensity.UseVisualStyleBackColor = true;
            this.buttonCalculateLoadDensity.Click += new System.EventHandler(this.buttonCalculateLoadDensity_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 361);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Storage Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageStorageInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPageChart.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadDensity)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLodDensity)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStorageInfo;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelMaxCapacity;
        private System.Windows.Forms.Label labelOccupancy;
        private System.Windows.Forms.Label labelFreeSpace;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCargoHeigh;
        private System.Windows.Forms.Label labelCargoWidth;
        private System.Windows.Forms.Label labelCargoDeep;
        private System.Windows.Forms.Button buttonEditCargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStorageHeight;
        private System.Windows.Forms.Label labelStorageWight;
        private System.Windows.Forms.Label labelStorageDeep;
        private System.Windows.Forms.Button buttonEditStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoadDensity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonCalculateLoadDensity;
        private System.Windows.Forms.Button buttonAddCargoState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.DataGridView dataGridViewStorageCapacity;
        private System.Windows.Forms.DataGridView dataGridViewLodDensity;
    }
}

