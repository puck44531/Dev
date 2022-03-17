using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxFitness
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.OleDb;

    //public partial class Form29 : Form
    //{

    //    public Form29()
    //    {
    //        InitializeComponent();
    //        displaydata();
    //    }

    //    OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=db_users.mdb");
    //    OleDbCommand cmd = new OleDbCommand();
    //    OleDbDataAdapter da = new OleDbDataAdapter();
    //    DataTable dt;
    //    public string users;

    //    public void displaydata()
    //    {
    //        con.Open();
    //        da = new OleDbDataAdapter("select * from tbl_users", con);
    //        dt = new DataTable();
    //        da.Fill(dt);
    //        dataGridView1.DataSource = dt;
    //        dataGridView1.Columns["id"].Visible = false;
    //        con.Close();

    //    }

    //    private void btnClear_Click(object sender, EventArgs e)
    //    {
    //        txtPassword.Text = "";
    //        txtUsername.Text = "";
    //        txtEmail.Text = "";
    //    }

    //    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    //    {
    //        UserData.Users = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
    //        txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
    //        txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
    //        txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
    //    }

    //    private void btnUpdate_Click(object sender, EventArgs e)
    //    {

    //        con.Open();
    //        cmd = new OleDbCommand("update tbl_users set [username]='" + txtUsername.Text + "',[password]='" + txtPassword.Text + "',[email]='" + txtEmail.Text + "' where [ID]=@ID", con);
    //        cmd.Parameters.Add("ID", OleDbType.Integer).Value = UserData.Users;
    //        cmd.ExecuteNonQuery();
    //        MessageBox.Show("Data has been updated");
    //        con.Close();
    //        displaydata();

    //    }

    //    private void btnDelete_Click(object sender, EventArgs e)
    //    {
    //        con.Open();
    //        cmd = new OleDbCommand("delete from tbl_users where ID=?", con);
    //        cmd.Parameters.Add("parameter1", OleDbType.Integer).Value = UserData.Users;
    //        cmd.ExecuteNonQuery();
    //        MessageBox.Show("Data has been Deleted");
    //        con.Close();
    //        displaydata();
    //    }

        
//    }
//}
