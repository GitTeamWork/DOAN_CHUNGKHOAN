namespace DOAN_CHUNGKHOAN
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lenhDatGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.numGiaDat = new System.Windows.Forms.NumericUpDown();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnDatLenh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCP = new System.Windows.Forms.TextBox();
            this.radioBan = new System.Windows.Forms.RadioButton();
            this.radioMua = new System.Windows.Forms.RadioButton();
            this.lenhDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUNGKHOANDataSet = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSet();
            this.lenhDatTableAdapter = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.LenhDatTableAdapter();
            this.tableAdapterManager = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.cHUNGKHOANDataSet1 = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSet1();
            this.lENHDATBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lENHDATTableAdapter1 = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSet1TableAdapters.LENHDATTableAdapter();
            this.tableAdapterManager1 = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSet1TableAdapters.TableAdapterManager();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAILENH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIADAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAILENH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1028, 252);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BẢNG GIÁ TRỰC TUYẾN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(920, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(96, 121);
            this.listBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1024, 235);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lenhDatGridControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(648, 218);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SỔ LỆNH";
            // 
            // lenhDatGridControl
            // 
            this.lenhDatGridControl.DataSource = this.lENHDATBindingSource1;
            this.lenhDatGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.lenhDatGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.lenhDatGridControl.Location = new System.Drawing.Point(2, 15);
            this.lenhDatGridControl.MainView = this.gridView1;
            this.lenhDatGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.lenhDatGridControl.Name = "lenhDatGridControl";
            this.lenhDatGridControl.Size = new System.Drawing.Size(644, 201);
            this.lenhDatGridControl.TabIndex = 3;
            this.lenhDatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMACP,
            this.colNGAYDAT,
            this.colLOAIGD,
            this.colLOAILENH,
            this.colSOLUONG,
            this.colGIADAT,
            this.colTRANGTHAILENH});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.lenhDatGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.numGiaDat);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.btnDatLenh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaCP);
            this.groupBox1.Controls.Add(this.radioBan);
            this.groupBox1.Controls.Add(this.radioMua);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(648, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(380, 218);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐẶT LỆNH MỚI";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Enabled = false;
            this.dtpNgay.Location = new System.Drawing.Point(176, 145);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(151, 20);
            this.dtpNgay.TabIndex = 13;
            // 
            // numGiaDat
            // 
            this.numGiaDat.Location = new System.Drawing.Point(176, 219);
            this.numGiaDat.Margin = new System.Windows.Forms.Padding(2);
            this.numGiaDat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numGiaDat.Name = "numGiaDat";
            this.numGiaDat.Size = new System.Drawing.Size(98, 20);
            this.numGiaDat.TabIndex = 12;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(176, 181);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(98, 20);
            this.numSoLuong.TabIndex = 11;
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDatLenh.Location = new System.Drawing.Point(199, 258);
            this.btnDatLenh.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(56, 19);
            this.btnDatLenh.TabIndex = 10;
            this.btnDatLenh.Text = "ĐẶT LỆNH";
            this.btnDatLenh.UseVisualStyleBackColor = true;
            this.btnDatLenh.Click += new System.EventHandler(this.btnDatLenh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "GIÁ ĐẶT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NGÀY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MÃ CP";
            // 
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(176, 107);
            this.txtMaCP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(98, 20);
            this.txtMaCP.TabIndex = 2;
            // 
            // radioBan
            // 
            this.radioBan.AutoSize = true;
            this.radioBan.Location = new System.Drawing.Point(213, 39);
            this.radioBan.Margin = new System.Windows.Forms.Padding(2);
            this.radioBan.Name = "radioBan";
            this.radioBan.Size = new System.Drawing.Size(47, 17);
            this.radioBan.TabIndex = 1;
            this.radioBan.Text = "BÁN";
            this.radioBan.UseVisualStyleBackColor = true;
            // 
            // radioMua
            // 
            this.radioMua.AutoSize = true;
            this.radioMua.Location = new System.Drawing.Point(88, 39);
            this.radioMua.Margin = new System.Windows.Forms.Padding(2);
            this.radioMua.Name = "radioMua";
            this.radioMua.Size = new System.Drawing.Size(49, 17);
            this.radioMua.TabIndex = 0;
            this.radioMua.Text = "MUA";
            this.radioMua.UseVisualStyleBackColor = true;
            // 
            // lenhDatBindingSource
            // 
            this.lenhDatBindingSource.DataMember = "LenhDat";
            this.lenhDatBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lenhDatTableAdapter
            // 
            this.lenhDatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LenhDatTableAdapter = this.lenhDatTableAdapter;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cHUNGKHOANDataSet1
            // 
            this.cHUNGKHOANDataSet1.DataSetName = "CHUNGKHOANDataSet1";
            this.cHUNGKHOANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lENHDATBindingSource1
            // 
            this.lENHDATBindingSource1.DataMember = "LENHDAT";
            this.lENHDATBindingSource1.DataSource = this.cHUNGKHOANDataSet1;
            // 
            // lENHDATTableAdapter1
            // 
            this.lENHDATTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LENHDATTableAdapter = this.lENHDATTableAdapter1;
            this.tableAdapterManager1.LENHKHOPTableAdapter = null;
            this.tableAdapterManager1.TRUCTUYENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DOAN_CHUNGKHOAN.CHUNGKHOANDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colMACP
            // 
            this.colMACP.FieldName = "MACP";
            this.colMACP.Name = "colMACP";
            this.colMACP.Visible = true;
            this.colMACP.VisibleIndex = 1;
            // 
            // colNGAYDAT
            // 
            this.colNGAYDAT.FieldName = "NGAYDAT";
            this.colNGAYDAT.Name = "colNGAYDAT";
            this.colNGAYDAT.Visible = true;
            this.colNGAYDAT.VisibleIndex = 2;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 3;
            // 
            // colLOAILENH
            // 
            this.colLOAILENH.FieldName = "LOAILENH";
            this.colLOAILENH.Name = "colLOAILENH";
            this.colLOAILENH.Visible = true;
            this.colLOAILENH.VisibleIndex = 4;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 5;
            // 
            // colGIADAT
            // 
            this.colGIADAT.FieldName = "GIADAT";
            this.colGIADAT.Name = "colGIADAT";
            this.colGIADAT.Visible = true;
            this.colGIADAT.VisibleIndex = 6;
            // 
            // colTRANGTHAILENH
            // 
            this.colTRANGTHAILENH.FieldName = "TRANGTHAILENH";
            this.colTRANGTHAILENH.Name = "colTRANGTHAILENH";
            this.colTRANGTHAILENH.Visible = true;
            this.colTRANGTHAILENH.VisibleIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1028, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource lenhDatBindingSource;
        private CHUNGKHOANDataSetTableAdapters.LenhDatTableAdapter lenhDatTableAdapter;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl lenhDatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.RadioButton radioBan;
        private System.Windows.Forms.RadioButton radioMua;
        private System.Windows.Forms.Button btnDatLenh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.NumericUpDown numGiaDat;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private CHUNGKHOANDataSet1 cHUNGKHOANDataSet1;
        private System.Windows.Forms.BindingSource lENHDATBindingSource1;
        private CHUNGKHOANDataSet1TableAdapters.LENHDATTableAdapter lENHDATTableAdapter1;
        private CHUNGKHOANDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMACP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDAT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAILENH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colGIADAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAILENH;
    }
}

