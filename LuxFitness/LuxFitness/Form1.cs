using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LuxFitness
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public Form1()
        {
            InitializeComponent();
      
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 35, 35));
            btnSignup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignup.Width, btnSignup.Height, 35, 35));
            

            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the applcation", "ThankYou!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLoginHover_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnSignup_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnSignupHover_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnLoginHover_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            Login.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignupHover_Click(object sender, EventArgs e)
        {
            Form3 Register = new Form3();
            Register.Show();
            this.Hide();
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            Form3 Register = new Form3();
            Register.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            Login.Show();
            this.Hide();
        }
    }
}
