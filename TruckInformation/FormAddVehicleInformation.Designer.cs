namespace DataManager.TruckInformation
{
    partial class FormAddVehicleInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddVehicleInformation));
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.TxtVehicleNo = new System.Windows.Forms.TextBox();
            this.lblVehicleYear = new System.Windows.Forms.Label();
            this.LblVehicleClassType = new System.Windows.Forms.Label();
            this.LblVehicleCapacity = new System.Windows.Forms.Label();
            this.LblVehicleMake = new System.Windows.Forms.Label();
            this.LblVehicleMileage = new System.Windows.Forms.Label();
            this.LblVehicleDescription = new System.Windows.Forms.Label();
            this.TxtVehicleYear = new System.Windows.Forms.TextBox();
            this.TxtVehicleCapacity = new System.Windows.Forms.TextBox();
            this.TxtVehicleMake = new System.Windows.Forms.TextBox();
            this.TxtVehicleMileage = new System.Windows.Forms.TextBox();
            this.TxtVehicleDescription = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.LblChassisNo = new System.Windows.Forms.Label();
            this.TxtChassisNo = new System.Windows.Forms.TextBox();
            this.TxtVehicleClassType = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.Location = new System.Drawing.Point(891, 22);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(69, 72);
            this.BtnLogout.TabIndex = 12;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(806, 22);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(69, 72);
            this.BtnHome.TabIndex = 11;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(721, 22);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(69, 72);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.Location = new System.Drawing.Point(33, 211);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(142, 23);
            this.lblVehicleNo.TabIndex = 0;
            this.lblVehicleNo.Text = "Vehicle Number : ";
            // 
            // TxtVehicleNo
            // 
            this.TxtVehicleNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNo.Location = new System.Drawing.Point(197, 205);
            this.TxtVehicleNo.Name = "TxtVehicleNo";
            this.TxtVehicleNo.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleNo.TabIndex = 263;
            // 
            // lblVehicleYear
            // 
            this.lblVehicleYear.AutoSize = true;
            this.lblVehicleYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleYear.Location = new System.Drawing.Point(33, 250);
            this.lblVehicleYear.Name = "lblVehicleYear";
            this.lblVehicleYear.Size = new System.Drawing.Size(116, 23);
            this.lblVehicleYear.TabIndex = 0;
            this.lblVehicleYear.Text = "Vehicle Year : ";
            // 
            // LblVehicleClassType
            // 
            this.LblVehicleClassType.AutoSize = true;
            this.LblVehicleClassType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleClassType.Location = new System.Drawing.Point(33, 289);
            this.LblVehicleClassType.Name = "LblVehicleClassType";
            this.LblVehicleClassType.Size = new System.Drawing.Size(166, 23);
            this.LblVehicleClassType.TabIndex = 0;
            this.LblVehicleClassType.Text = "Vehicle Class Type : ";
            // 
            // LblVehicleCapacity
            // 
            this.LblVehicleCapacity.AutoSize = true;
            this.LblVehicleCapacity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleCapacity.Location = new System.Drawing.Point(33, 332);
            this.LblVehicleCapacity.Name = "LblVehicleCapacity";
            this.LblVehicleCapacity.Size = new System.Drawing.Size(148, 23);
            this.LblVehicleCapacity.TabIndex = 0;
            this.LblVehicleCapacity.Text = "Vehicle Capacity : ";
            // 
            // LblVehicleMake
            // 
            this.LblVehicleMake.AutoSize = true;
            this.LblVehicleMake.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleMake.Location = new System.Drawing.Point(33, 378);
            this.LblVehicleMake.Name = "LblVehicleMake";
            this.LblVehicleMake.Size = new System.Drawing.Size(122, 23);
            this.LblVehicleMake.TabIndex = 0;
            this.LblVehicleMake.Text = "Vehicle Make : ";
            // 
            // LblVehicleMileage
            // 
            this.LblVehicleMileage.AutoSize = true;
            this.LblVehicleMileage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleMileage.Location = new System.Drawing.Point(33, 416);
            this.LblVehicleMileage.Name = "LblVehicleMileage";
            this.LblVehicleMileage.Size = new System.Drawing.Size(140, 23);
            this.LblVehicleMileage.TabIndex = 0;
            this.LblVehicleMileage.Text = "Vehicle Mileage : ";
            // 
            // LblVehicleDescription
            // 
            this.LblVehicleDescription.AutoSize = true;
            this.LblVehicleDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleDescription.Location = new System.Drawing.Point(33, 458);
            this.LblVehicleDescription.Name = "LblVehicleDescription";
            this.LblVehicleDescription.Size = new System.Drawing.Size(169, 23);
            this.LblVehicleDescription.TabIndex = 0;
            this.LblVehicleDescription.Text = "Vehicle Description : ";
            // 
            // TxtVehicleYear
            // 
            this.TxtVehicleYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleYear.Location = new System.Drawing.Point(197, 244);
            this.TxtVehicleYear.Name = "TxtVehicleYear";
            this.TxtVehicleYear.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleYear.TabIndex = 3;
            // 
            // TxtVehicleCapacity
            // 
            this.TxtVehicleCapacity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleCapacity.Location = new System.Drawing.Point(197, 326);
            this.TxtVehicleCapacity.Name = "TxtVehicleCapacity";
            this.TxtVehicleCapacity.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleCapacity.TabIndex = 5;
            // 
            // TxtVehicleMake
            // 
            this.TxtVehicleMake.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleMake.Location = new System.Drawing.Point(197, 372);
            this.TxtVehicleMake.Name = "TxtVehicleMake";
            this.TxtVehicleMake.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleMake.TabIndex = 6;
            // 
            // TxtVehicleMileage
            // 
            this.TxtVehicleMileage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleMileage.Location = new System.Drawing.Point(197, 413);
            this.TxtVehicleMileage.Name = "TxtVehicleMileage";
            this.TxtVehicleMileage.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleMileage.TabIndex = 7;
            // 
            // TxtVehicleDescription
            // 
            this.TxtVehicleDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleDescription.Location = new System.Drawing.Point(197, 452);
            this.TxtVehicleDescription.Multiline = true;
            this.TxtVehicleDescription.Name = "TxtVehicleDescription";
            this.TxtVehicleDescription.Size = new System.Drawing.Size(407, 123);
            this.TxtVehicleDescription.TabIndex = 8;
            // 
            // Login
            // 
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.Location = new System.Drawing.Point(246, 613);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(151, 44);
            this.Login.TabIndex = 9;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LblChassisNo
            // 
            this.LblChassisNo.AutoSize = true;
            this.LblChassisNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChassisNo.Location = new System.Drawing.Point(411, 211);
            this.LblChassisNo.Name = "LblChassisNo";
            this.LblChassisNo.Size = new System.Drawing.Size(203, 23);
            this.LblChassisNo.TabIndex = 0;
            this.LblChassisNo.Text = "Vehicle Chassis Number :";
            // 
            // TxtChassisNo
            // 
            this.TxtChassisNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChassisNo.Location = new System.Drawing.Point(622, 205);
            this.TxtChassisNo.Name = "TxtChassisNo";
            this.TxtChassisNo.Size = new System.Drawing.Size(168, 29);
            this.TxtChassisNo.TabIndex = 2;
            // 
            // TxtVehicleClassType
            // 
            this.TxtVehicleClassType.FormattingEnabled = true;
            this.TxtVehicleClassType.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.TxtVehicleClassType.Location = new System.Drawing.Point(197, 289);
            this.TxtVehicleClassType.Name = "TxtVehicleClassType";
            this.TxtVehicleClassType.Size = new System.Drawing.Size(168, 21);
            this.TxtVehicleClassType.TabIndex = 4;
            // 
            // BtnClear
            // 
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(789, 613);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(125, 127);
            this.BtnClear.TabIndex = 264;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FormAddVehicleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 812);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtVehicleClassType);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TxtVehicleDescription);
            this.Controls.Add(this.TxtVehicleMileage);
            this.Controls.Add(this.TxtVehicleMake);
            this.Controls.Add(this.TxtVehicleCapacity);
            this.Controls.Add(this.TxtVehicleYear);
            this.Controls.Add(this.TxtChassisNo);
            this.Controls.Add(this.TxtVehicleNo);
            this.Controls.Add(this.LblVehicleDescription);
            this.Controls.Add(this.LblVehicleMileage);
            this.Controls.Add(this.LblVehicleMake);
            this.Controls.Add(this.LblVehicleCapacity);
            this.Controls.Add(this.LblVehicleClassType);
            this.Controls.Add(this.LblChassisNo);
            this.Controls.Add(this.lblVehicleYear);
            this.Controls.Add(this.lblVehicleNo);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnBack);
            this.Name = "FormAddVehicleInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Truck Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddVehicleInformation_FormClosed_1);
            this.Load += new System.EventHandler(this.FormAddVehicleInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnLogout;
        protected System.Windows.Forms.Button BtnHome;
        protected System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.TextBox TxtVehicleNo;
        private System.Windows.Forms.Label lblVehicleYear;
        private System.Windows.Forms.Label LblVehicleClassType;
        private System.Windows.Forms.Label LblVehicleCapacity;
        private System.Windows.Forms.Label LblVehicleMake;
        private System.Windows.Forms.Label LblVehicleMileage;
        private System.Windows.Forms.Label LblVehicleDescription;
        private System.Windows.Forms.TextBox TxtVehicleYear;
        private System.Windows.Forms.TextBox TxtVehicleCapacity;
        private System.Windows.Forms.TextBox TxtVehicleMake;
        private System.Windows.Forms.TextBox TxtVehicleMileage;
        private System.Windows.Forms.TextBox TxtVehicleDescription;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label LblChassisNo;
        private System.Windows.Forms.TextBox TxtChassisNo;
        private System.Windows.Forms.ComboBox TxtVehicleClassType;
        private System.Windows.Forms.Button BtnClear;
    }
}