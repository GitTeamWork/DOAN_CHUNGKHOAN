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
            this.cHUNGKHOANDataSet = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSet();
            this.lenhDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lenhDatTableAdapter = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.LenhDatTableAdapter();
            this.tableAdapterManager = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lenhDatBindingSource
            // 
            this.lenhDatBindingSource.DataMember = "LenhDat";
            this.lenhDatBindingSource.DataSource = this.cHUNGKHOANDataSet;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1402, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BẢNG GIÁ TRỰC TUYẾN";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1396, 183);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lenhDatGridControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 374);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SỔ LỆNH";
            // 
            // lenhDatGridControl
            // 
            this.lenhDatGridControl.DataSource = this.lenhDatBindingSource;
            this.lenhDatGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lenhDatGridControl.Location = new System.Drawing.Point(3, 18);
            this.lenhDatGridControl.MainView = this.gridView1;
            this.lenhDatGridControl.Name = "lenhDatGridControl";
            this.lenhDatGridControl.Size = new System.Drawing.Size(858, 353);
            this.lenhDatGridControl.TabIndex = 3;
            this.lenhDatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(864, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 374);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐẶT LỆNH MỚI";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Enabled = false;
            this.dtpNgay.Location = new System.Drawing.Point(235, 178);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpNgay.TabIndex = 13;
            // 
            // numGiaDat
            // 
            this.numGiaDat.Location = new System.Drawing.Point(235, 270);
            this.numGiaDat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numGiaDat.Name = "numGiaDat";
            this.numGiaDat.Size = new System.Drawing.Size(130, 22);
            this.numGiaDat.TabIndex = 12;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(235, 223);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(130, 22);
            this.numSoLuong.TabIndex = 11;
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDatLenh.Location = new System.Drawing.Point(265, 318);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(75, 23);
            this.btnDatLenh.TabIndex = 10;
            this.btnDatLenh.Text = "ĐẶT LỆNH";
            this.btnDatLenh.UseVisualStyleBackColor = true;
            this.btnDatLenh.Click += new System.EventHandler(this.btnDatLenh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "GIÁ ĐẶT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "NGÀY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "MÃ CP";
            // 
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(235, 132);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(130, 22);
            this.txtMaCP.TabIndex = 2;
            // 
            // radioBan
            // 
            this.radioBan.AutoSize = true;
            this.radioBan.Location = new System.Drawing.Point(284, 48);
            this.radioBan.Name = "radioBan";
            this.radioBan.Size = new System.Drawing.Size(57, 21);
            this.radioBan.TabIndex = 1;
            this.radioBan.Text = "BÁN";
            this.radioBan.UseVisualStyleBackColor = true;
            // 
            // radioMua
            // 
            this.radioMua.AutoSize = true;
            this.radioMua.Location = new System.Drawing.Point(117, 48);
            this.radioMua.Name = "radioMua";
            this.radioMua.Size = new System.Drawing.Size(59, 21);
            this.radioMua.TabIndex = 0;
            this.radioMua.Text = "MUA";
            this.radioMua.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 183);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1402, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

