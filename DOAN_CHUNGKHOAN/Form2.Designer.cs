namespace DOAN_CHUNGKHOAN
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableAdapterManager = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.lenhDatTableAdapter = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.LenhDatTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 297);
            this.dataGridView1.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(832, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 374);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐẶT LỆNH MỚI";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Enabled = false;
            this.dtpNgay.Location = new System.Drawing.Point(318, 169);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpNgay.TabIndex = 13;
            // 
            // numGiaDat
            // 
            this.numGiaDat.Location = new System.Drawing.Point(318, 261);
            this.numGiaDat.Name = "numGiaDat";
            this.numGiaDat.Size = new System.Drawing.Size(130, 22);
            this.numGiaDat.TabIndex = 12;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(318, 214);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(130, 22);
            this.numSoLuong.TabIndex = 11;
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.Location = new System.Drawing.Point(274, 318);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(75, 23);
            this.btnDatLenh.TabIndex = 10;
            this.btnDatLenh.Text = "ĐẶT LỆNH";
            this.btnDatLenh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "GIÁ ĐẶT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "NGÀY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "MÃ CP";
            // 
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(318, 123);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(130, 22);
            this.txtMaCP.TabIndex = 2;
            // 
            // radioBan
            // 
            this.radioBan.AutoSize = true;
            this.radioBan.Location = new System.Drawing.Point(367, 39);
            this.radioBan.Name = "radioBan";
            this.radioBan.Size = new System.Drawing.Size(57, 21);
            this.radioBan.TabIndex = 1;
            this.radioBan.Text = "BÁN";
            this.radioBan.UseVisualStyleBackColor = true;
            // 
            // radioMua
            // 
            this.radioMua.AutoSize = true;
            this.radioMua.Location = new System.Drawing.Point(200, 39);
            this.radioMua.Name = "radioMua";
            this.radioMua.Size = new System.Drawing.Size(59, 21);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 318);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SỔ LỆNH";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LenhDatTableAdapter = this.lenhDatTableAdapter;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lenhDatTableAdapter
            // 
            this.lenhDatTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1138, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BẢNG GIÁ TRỰC TUYẾN";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(514, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 318);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ĐẶT LỆNH MỚI";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 252);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(128, 205);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(130, 22);
            this.numericUpDown2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ĐẶT LỆNH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "GIÁ ĐẶT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "SỐ LƯỢNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "NGÀY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "MÃ CP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(177, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "BÁN";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "MUA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 522);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.NumericUpDown numGiaDat;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnDatLenh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.RadioButton radioBan;
        private System.Windows.Forms.RadioButton radioMua;
        private System.Windows.Forms.BindingSource lenhDatBindingSource;
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CHUNGKHOANDataSetTableAdapters.LenhDatTableAdapter lenhDatTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}