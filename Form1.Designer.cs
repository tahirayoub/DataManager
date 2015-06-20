namespace DataManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TruckImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtPassword.Location = new System.Drawing.Point(433, 313);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(251, 22);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.White;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtUserName.Location = new System.Drawing.Point(433, 253);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(251, 22);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Tag = "";
            this.TxtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(293, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(293, 259);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 16);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "User Name";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.Location = new System.Drawing.Point(344, 465);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(151, 44);
            this.Login.TabIndex = 23;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(546, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TruckImage
            // 
            this.TruckImage.Image = ((System.Drawing.Image)(resources.GetObject("TruckImage.Image")));
            this.TruckImage.Location = new System.Drawing.Point(584, 12);
            this.TruckImage.Name = "TruckImage";
            this.TruckImage.Size = new System.Drawing.Size(208, 135);
            this.TruckImage.TabIndex = 25;
            this.TruckImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 778);
            this.Controls.Add(this.TruckImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TruckImage;
    }
}

