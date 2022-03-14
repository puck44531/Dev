using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LuxFitness
{
    public partial class Form2 : Form
    {
        public int attempts;

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

        public Form2()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 35, 35));

            AcceptButton = btnLogin;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLoginHover_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Intro = new Form1();
            Intro.Show();
            this.Hide();
        }

        private void btnLoginHover_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Register = new Form3();
            Register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Form5 Admin = new Form5();
                Admin.Show();
                this.Hide();
            }
            else
            {
                con.Open();
                string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    UserData.Username = txtUsername.Text;
                    UserData.Email = dr.GetValue(2).ToString();

                    //Form29 Homepage = new Form29();
                    //Homepage.Show();
                    //this.Hide();

                    Form4 Homepage = new Form4();
                    Homepage.Show();
                    this.Hide();
                }
                else if (dr.Read() == false)
                {
                    attempts++;
                    MessageBox.Show("You have had " + attempts + " attempt(s). " + (3 - attempts) + " Attempt(s) remaning.", "Login Faied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (attempts >= 3)
                    {
                        MessageBox.Show("You have run out of attempts and your access has been termianed", "Login Compromised", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        attempts = 0;

                        Application.Exit();

                    }

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                    con.Close();


                }
            }

           
        }

        private void btnEyeclose_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';           
            btnEyeopen.Show();
            btnEyeclose.Hide();
        }

        private void btnEyeopen_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';           
            btnEyeopen.Hide();
            btnEyeclose.Show();
        }
    }
}
