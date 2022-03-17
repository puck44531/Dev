namespace LuxFitness
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.StrenthProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnEyeopen = new System.Windows.Forms.Button();
            this.btnEyeclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(81, 307);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(368, 40);
            this.txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(81, 681);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 40);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(81, 427);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(368, 40);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnSignup
            // 
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Image = global::LuxFitness.Properties.Resources.Sign_up_perfect;
            this.btnSignup.Location = new System.Drawing.Point(71, 760);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(430, 52);
            this.btnSignup.TabIndex = 4;
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            this.btnSignup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSignup_KeyDown);
            this.btnSignup.MouseHover += new System.EventHandler(this.btnSignup_MouseHover);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LuxFitness.Properties.Resources.close_real;
            this.button2.Location = new System.Drawing.Point(1415, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 18);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LuxFitness.Properties.Resources.minus_real;
            this.button1.Location = new System.Drawing.Point(1378, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 18);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::LuxFitness.Properties.Resources.back_arrow1;
            this.button3.Location = new System.Drawing.Point(7, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 18);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(81, 558);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(368, 40);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // StrenthProgressBar
            // 
            this.StrenthProgressBar.ForeColor = System.Drawing.Color.Yellow;
            this.StrenthProgressBar.Location = new System.Drawing.Point(311, 615);
            this.StrenthProgressBar.Name = "StrenthProgressBar";
            this.StrenthProgressBar.Size = new System.Drawing.Size(172, 23);
            this.StrenthProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StrenthProgressBar.TabIndex = 9;
            this.StrenthProgressBar.Click += new System.EventHandler(this.StrenthProgressBar_Click);
            // 
            // btnEyeopen
            // 
            this.btnEyeopen.BackgroundImage = global::LuxFitness.Properties.Resources.eye_open;
            this.btnEyeopen.FlatAppearance.BorderSize = 0;
            this.btnEyeopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEyeopen.Location = new System.Drawing.Point(446, 565);
            this.btnEyeopen.Name = "btnEyeopen";
            this.btnEyeopen.Size = new System.Drawing.Size(42, 33);
            this.btnEyeopen.TabIndex = 10;
            this.btnEyeopen.UseVisualStyleBackColor = true;
            this.btnEyeopen.Click += new System.EventHandler(this.btnEyeopen_Click);
            // 
            // btnEyeclose
            // 
            this.btnEyeclose.BackgroundImage = global::LuxFitness.Properties.Resources.eye_close;
            this.btnEyeclose.FlatAppearance.BorderSize = 0;
            this.btnEyeclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEyeclose.Location = new System.Drawing.Point(446, 565);
            this.btnEyeclose.Name = "btnEyeclose";
            this.btnEyeclose.Size = new System.Drawing.Size(42, 33);
            this.btnEyeclose.TabIndex = 31;
            this.btnEyeclose.UseVisualStyleBackColor = true;
            this.btnEyeclose.Click += new System.EventHandler(this.btnEyeclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LuxFitness.Properties.Resources.aleady_have_a_account_;
            this.pictureBox1.Location = new System.Drawing.Point(162, 827);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 27);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::LuxFitness.Properties.Resources.Here;
            this.button4.Location = new System.Drawing.Point(337, 831);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LuxFitness.Properties.Resources.Desktop___16;
            this.ClientSize = new System.Drawing.Size(1440, 890);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEyeopen);
            this.Controls.Add(this.StrenthProgressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEyeclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ProgressBar StrenthProgressBar;
        private System.Windows.Forms.Button btnEyeopen;
        private System.Windows.Forms.Button btnEyeclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
    }
}