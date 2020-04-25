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

        private int changeCount = 0;
        private const string tableName = "Tructuyen";
        private const string statusMessage = "Đã có {0} thay đổi.";

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet dataToWatch = null;

        private bool CanRequestNotifications()
        {
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);

                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
                return false;
            }
        }

        private string GetConnectionString()
        {
            return "Data Source=LQUYNH;Initial Catalog=CHUNGKHOAN;User ID=sa;Password=1";
        }

        private string GetSQL()
        {
            return "SELECT MACP AS [MACP], GIA2_DM AS [Giá 2 Mua], KL2_DM AS [Khối Lượng 2 Mua], GIA1_DM AS [Giá 1 Mua], KL1_DM AS [Khối Lượng 1 Mua], GIAKHOP AS [Giá Khớp], KL_KHOP AS [Khối Lượng Khớp], GIA1_DB AS [Giá 1 DB], KL1_DB AS [Khối Lượng 1 Bán], GIA2_DB AS [Giá 2 Bán], KL2_DB AS [Khối Lượng 2 Bán] FROM dbo.TRUCTUYEN";
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);
                object[] args = new[] { sender, e };
                i.BeginInvoke(tempDelegate, args);
                return;
            }
            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= dependency_OnChange;
            changeCount += 1;
            this.label5.Text = string.Format(statusMessage, changeCount);
            {
                var withBlock = this.listBox2.Items;
                withBlock.Clear();
                withBlock.Add("Info:   " + e.Info.ToString());
                withBlock.Add("Source: " + e.Source.ToString());
                withBlock.Add("Type:   " + e.Type.ToString());
            }
            GetData();
        }

        private void GetData()
        {
            dataToWatch.Clear();
            command.Notification = null;
            SqlDependency dependency = new SqlDependency(command);
            dependency.OnChange += dependency_OnChange;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataToWatch, tableName);
                this.dataGridView1.DataSource = dataToWatch;
                this.dataGridView1.DataMember = tableName;
            }
        }

        private void BatDau()
        {
            changeCount = 0;
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
                return;
            }

            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionString());
                connection.Open();
            }
            if (command == null)
                command = new SqlCommand(GetSQL(), connection);

            if (dataToWatch == null)
                dataToWatch = new DataSet();
            GetData();
        }

        public Form1()
        {
            InitializeComponent();
            if (CanRequestNotifications() == true)
                BatDau();
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "Notification", MessageBoxButtons.OK);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDependency.Stop(GetConnectionString());
            if (connection != null)
                connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet1.LENHDAT' table. You can move, or remove it, as needed.
            this.lENHDATTableAdapter1.Fill(this.cHUNGKHOANDataSet1.LENHDAT);
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.LenhDat' table. You can move, or remove it, as needed.
            //this.lenhDatTableAdapter.Fill(this.cHUNGKHOANDataSet.LenhDat);
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
