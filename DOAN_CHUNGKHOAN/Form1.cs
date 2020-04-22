using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_CHUNGKHOAN
{
    public partial class Form1 : Form
    {
        private char loaiGD;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.LenhDat' table. You can move, or remove it, as needed.
            this.lenhDatTableAdapter.Fill(this.cHUNGKHOANDataSet.LenhDat);
        }
        

        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            if (radioMua.Checked == false && radioBan.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn hình thức Mua hoặc Bán", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMaCP.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin bạn điền thiếu!", "", MessageBoxButtons.OK);
                return;
            }
            if (radioMua.Checked == true) loaiGD = 'M';
            else loaiGD = 'B';

            if (Program.KetNoi() == 0) return;
            string strLenh = "EXEC SP_KHOPLENH_LO '" + txtMaCP.Text + "','" + dtpNgay.Value.ToString("dd-MM-yyyy")+ "','" + loaiGD + "'," + numSoLuong.Text + "," + numGiaDat.Text;
            //MessageBox.Show(strLenh);
            Console.Write(strLenh);

            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                MessageBox.Show("Đặt lệnh thành công ", "", MessageBoxButtons.OK);
                this.lenhDatTableAdapter.Fill(this.cHUNGKHOANDataSet.LenhDat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            if (Program.myReader == null) return;
            Program.myReader.Read(); // neu sp co nhieu dong bor vao wile(....true)


            //Program.username = Program.myReader.GetString(0);     // Lay user name
            //if (Convert.IsDBNull(Program.username))
            //{
            //    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
            //    return;
            //}
            //Program.mHoten = Program.myReader.GetString(1);
            //Program.mGroup = Program.myReader.GetString(2);
            //Program.myReader.Close();
            Program.conn.Close();
            //MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
        }
    }
}
