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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
        }
        private int changeCount = 0;
        private const string tableName = "LenhDat";
        private const string statusMessage = "Đã có {0} thay đổi.";

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet dataToWatch = null;

        private bool CanRequestNotifications()
        {
            // In order to use the callback feature of the
            // SqlDependency, the application must have
            // the SqlClientPermission permission.
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);

                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrive it from a configuration file.
            // Return "Data Source=THU-PC\TINTIN;Initial Catalog=QLVT;Persist Security Info=True;User ID=sa;Password=kc;Pooling = false"
            return @"Data Source=MSI;Initial Catalog=CHUNGKHOAN;Integrated Security=SSPI";
        }

        private string GetSQL()
        {
            return "select id as [ID],maCP as [MA CP],ngaydat as [NGAY DAT],loaiGD as [LOAI GD],loailenh as [LOAI LENH],soluong as [SO LUONG], giadat as [GIA DAT], trangthailenh as [TRANGTHAILENH] from dbo.LenhDat";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.LenhDat' table. You can move, or remove it, as needed.
            //this.lenhDatTableAdapter.Fill(this.cHUNGKHOANDataSet.LenhDat);
            if (CanRequestNotifications() == true)
                BatDau();
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker");
        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {

            // This event will occur on a thread pool thread.
            // It is illegal to update the UI from a worker thread
            // The following code checks to see if it is safe update the UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // If InvokeRequired returns True, the code is executing on a worker thread.
            if (i.InvokeRequired)
            {
                // Create a delegate to perform the thread switch
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = new[] { sender, e };

                // Marshal the data from the worker thread
                // to the UI thread.
                i.BeginInvoke(tempDelegate, args);

                return;
            }

            // Remove the handler since it's only good
            // for a single notification
            SqlDependency dependency = (SqlDependency)sender;

            dependency.OnChange -= dependency_OnChange;

            // At this point, the code is executing on the
            // UI thread, so it is safe to update the UI.
            changeCount += 1;
            this.label1.Text = string.Format(statusMessage, changeCount);

            // Add information from the event arguments to the list box
            // for debugging purposes only.
            {
                var withBlock = this.listBox1.Items;
                withBlock.Clear();
                withBlock.Add("Info:   " + e.Info.ToString());
                withBlock.Add("Source: " + e.Source.ToString());
                withBlock.Add("Type:   " + e.Type.ToString());
            }

            // Reload the dataset that's bound to the grid.
            GetData();
        }

        private void GetData()
        {
            // Empty the dataset so that there is only
            // one batch worth of data displayed.
            dataToWatch.Clear();

            // Make sure the command object does not already have
            // a notification object associated with it.

            command.Notification = null;

            // Create and bind the SqlDependency object
            // to the command object.

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
            // Remove any existing dependency connection, then create a new one.
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation);
                return;
            }
            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionString());
                connection.Open();
            }
            if (command == null)
                // GetSQL is a local procedure that returns
                // a paramaterized SQL string. You might want
                // to use a stored procedure in your application.
                command = new SqlCommand(GetSQL(), connection);

            if (dataToWatch == null)
                dataToWatch = new DataSet();
            GetData();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
