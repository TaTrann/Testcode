using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDemoC_Sharp
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();

        }

        DataTable dt;
        void LoadAccountList()
        {

            string connString = @"Data Source=NONAME;Initial Catalog=Newcsharp;Persist Security Info=True;User ID=sa;Password=123";
            SqlConnection connection = new SqlConnection(connString);

            string query = "Select * From dbo.Registration";
            SqlCommand command = new SqlCommand(query, connection);

            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();

            datagridview.DataSource = dt;


        }
        void LoadAccountList1()
        {
            //1 khởi tạo conn truyền cấu trúc
            string conn = @"Data Source=NONAME;Initial Catalog=Newcsharp;Persist Security Info=True;User ID=sa;Password=123";
            //2 tạo kết nối

            SqlConnection connection = new SqlConnection(conn);

            //3, thực thi
            string query = "Select * from dbo.Registration";
            //4. thực thi query 
            SqlCommand cmd = new SqlCommand(query, connection);
            //tạo data
            dt = new DataTable();
            //5. truyền data vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            //7 đóng kết nối
            connection.Close();
            //8. truyền  vào view - datagridview
            datagridview.DataSource = dt;
        }
        private void btManager_Click(object sender, EventArgs e)
        {
            frmChinh frmchinh = new frmChinh();
            this.Hide();
            frmchinh.ShowDialog();
            
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           // DataTable dt = new DataTable();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Username LIKE '%{0}%'", txtsearch.Text);
            datagridview.DataSource = DV;

        }
    }
}
