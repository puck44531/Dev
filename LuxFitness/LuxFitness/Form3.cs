using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LuxFitness
{
    public partial class Form3 : Form
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

        public Form3()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btnSignup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignup.Width, btnSignup.Height, 35, 35));
            

           

            AcceptButton = btnSignup;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnSignup_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnSignupHover_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Intro = new Form1();
            Intro.Show();
            this.Hide();
        }

        

        private void RegisterSystem()
        {
            

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$$^&*()_+=\[{\]};:<>|./?,-]+");


            if (!hasNumber.IsMatch(txtPassword.Text + txtConfirmPassword.Text))
            {
                MessageBox.Show("The password needs to include the following: (Atleast one number) (Atleast one uppercase letter) (Atleast one lowercase letter) (Atleast one symbol) Please try again", "Registration denied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (!hasUpperChar.IsMatch(txtPassword.Text + txtConfirmPassword.Text))
            {
                MessageBox.Show("The password needs to include the following: (Atleast one number) (Atleast one uppercase letter) (Atleast one lowercase letter) (Atleast one symbol) Please try again", "Registration denied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (!hasLowerChar.IsMatch(txtPassword.Text + txtConfirmPassword.Text))
            {
                MessageBox.Show("The password needs to include the following: (Atleast one number) (Atleast one uppercase letter) (Atleast one lowercase letter) (Atleast one symbol) Please try again", "Registration denied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (!hasSymbols.IsMatch(txtPassword.Text + txtConfirmPassword.Text))
            {
                MessageBox.Show("The password needs to include the following: (Atleast one number) (Atleast one uppercase letter) (Atleast one lowercase letter) (Atleast one symbol) Please try again", "Registration denied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (txtPassword.Text == txtConfirmPassword.Text && (Regex.IsMatch(txtEmail.Text, pattern)))
            {

                if (StrenthProgressBar.Value >= 75)
                {
                    try
                    {
                        con.Open();
                        string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "', '" + txtEmail.Text + "');";
                        cmd = new OleDbCommand(register, con);
                        cmd.ExecuteNonQuery();
                        con.Close();



                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        txtEmail.Text = "";

                        MessageBox.Show("You have successfully created a account.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 Login = new Form1();
                        Login.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("This account already exists, Would you like to login?", "Registration Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            Form1 Login = new Form1();
                            Login.Show();
                            this.Hide();
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("This account already exists", "Account Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtConfirmPassword.Text = "";
                            txtEmail.Text = "";
                            con.Close();
                            RegisterSystem();
                        }



                    }

                }
                else
                {
                    MessageBox.Show("The password that you have entered is to weak. Please enter a stronger password", "Password to weak", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }




            }
            else
            {
                MessageBox.Show("Please check that your passwords match and your email is correct", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPassword.Focus();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                StrenthProgressBar.Value = 0;

                

            }
            else if (txtPassword.Text.Length >= 1 && txtPassword.Text.Length <= 6)
            {
                StrenthProgressBar.Value = 25; 
                this.StrenthProgressBar.ForeColor = Color.Red;

                
            }
            else if (txtPassword.Text.Length >= 6 && txtPassword.Text.Length <= 8)
            {
                StrenthProgressBar.Value = 50;
                this.StrenthProgressBar.ForeColor = Color.Orange;

                
            }
            else if (txtPassword.Text.Length >= 8 && txtPassword.Text.Length <= 10)
            {
                StrenthProgressBar.Value = 75;
                this.StrenthProgressBar.ForeColor = Color.Yellow;

                
            }
            else if (txtPassword.Text.Length > 10)
            {
                StrenthProgressBar.Value = 100;
                this.StrenthProgressBar.ForeColor = Color.Green;

                
            }
        }

        private void StrenthProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //RegisterSystem();

            Form4 Login = new Form4();
            Login.Show();
            this.Hide();
        }

        private void btnEyeclose_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            btnEyeopen.Show();
            btnEyeclose.Hide();
        }

        private void btnEyeopen_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtConfirmPassword.PasswordChar = '\0';
            btnEyeopen.Hide();
            btnEyeclose.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            Login.Show();
            this.Hide();
        }
    }
}
