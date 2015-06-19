namespace DataManager.DriverInformation
{
    partial class FormUpdateDriverInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateDriverInformation));
            this.BtnClear = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.DTPDriverExperiance = new System.Windows.Forms.DateTimePicker();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtMobileNumber = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtDriverAccountNumber = new System.Windows.Forms.TextBox();
            this.TxtDriverLicense = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.LblVehicleDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblVehicleMileage = new System.Windows.Forms.Label();
            this.LblVehicleMake = new System.Windows.Forms.Label();
            this.LblVehicleCapacity = new System.Windows.Forms.Label();
            this.LblVehicleClassType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblExperiance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblChassisNo = new System.Windows.Forms.Label();
            this.lblVehicleYear = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblDriverLicenseInvisible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(845, 708);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(71, 63);
            this.BtnClear.TabIndex = 289;
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time"});
            this.CBType.Location = new System.Drawing.Point(255, 299);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 21);
            this.CBType.TabIndex = 281;
            // 
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CBGender.Location = new System.Drawing.Point(255, 254);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(121, 21);
            this.CBGender.TabIndex = 280;
            // 
            // DTPDriverExperiance
            // 
            this.DTPDriverExperiance.Location = new System.Drawing.Point(255, 338);
            this.DTPDriverExperiance.Name = "DTPDriverExperiance";
            this.DTPDriverExperiance.Size = new System.Drawing.Size(200, 20);
            this.DTPDriverExperiance.TabIndex = 282;
            this.DTPDriverExperiance.ValueChanged += new System.EventHandler(this.DTPDriverExperiance_ValueChanged);
            // 
            // DTPDOB
            // 
            this.DTPDOB.Location = new System.Drawing.Point(255, 214);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(200, 20);
            this.DTPDOB.TabIndex = 279;
            this.DTPDOB.ValueChanged += new System.EventHandler(this.DTPDOB_ValueChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(256, 698);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 73);
            this.BtnUpdate.TabIndex = 288;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(256, 542);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(407, 123);
            this.TxtDescription.TabIndex = 286;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(256, 476);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(407, 51);
            this.TxtAddress.TabIndex = 285;
            // 
            // TxtMobileNumber
            // 
            this.TxtMobileNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMobileNumber.Location = new System.Drawing.Point(255, 427);
            this.TxtMobileNumber.Name = "TxtMobileNumber";
            this.TxtMobileNumber.Size = new System.Drawing.Size(168, 29);
            this.TxtMobileNumber.TabIndex = 284;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNumber.Location = new System.Drawing.Point(255, 375);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(168, 29);
            this.TxtPhoneNumber.TabIndex = 283;
            // 
            // TxtDriverAccountNumber
            // 
            this.TxtDriverAccountNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDriverAccountNumber.Location = new System.Drawing.Point(680, 247);
            this.TxtDriverAccountNumber.Name = "TxtDriverAccountNumber";
            this.TxtDriverAccountNumber.Size = new System.Drawing.Size(168, 29);
            this.TxtDriverAccountNumber.TabIndex = 287;
            // 
            // TxtDriverLicense
            // 
            this.TxtDriverLicense.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDriverLicense.Location = new System.Drawing.Point(680, 167);
            this.TxtDriverLicense.Name = "TxtDriverLicense";
            this.TxtDriverLicense.Size = new System.Drawing.Size(168, 29);
            this.TxtDriverLicense.TabIndex = 278;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullName.Location = new System.Drawing.Point(255, 167);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(168, 29);
            this.TxtFullName.TabIndex = 277;
            // 
            // LblVehicleDescription
            // 
            this.LblVehicleDescription.AutoSize = true;
            this.LblVehicleDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleDescription.Location = new System.Drawing.Point(43, 554);
            this.LblVehicleDescription.Name = "LblVehicleDescription";
            this.LblVehicleDescription.Size = new System.Drawing.Size(159, 23);
            this.LblVehicleDescription.TabIndex = 306;
            this.LblVehicleDescription.Text = "Driver Description : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 303;
            this.label2.Text = "Driver Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 305;
            this.label1.Text = "Driver Mobile Number :";
            // 
            // LblVehicleMileage
            // 
            this.LblVehicleMileage.AutoSize = true;
            this.LblVehicleMileage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleMileage.Location = new System.Drawing.Point(43, 378);
            this.LblVehicleMileage.Name = "LblVehicleMileage";
            this.LblVehicleMileage.Size = new System.Drawing.Size(181, 23);
            this.LblVehicleMileage.TabIndex = 304;
            this.LblVehicleMileage.Text = "Driver Phone Number :";
            // 
            // LblVehicleMake
            // 
            this.LblVehicleMake.AutoSize = true;
            this.LblVehicleMake.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleMake.Location = new System.Drawing.Point(44, 298);
            this.LblVehicleMake.Name = "LblVehicleMake";
            this.LblVehicleMake.Size = new System.Drawing.Size(106, 23);
            this.LblVehicleMake.TabIndex = 302;
            this.LblVehicleMake.Text = "Driver Type :";
            // 
            // LblVehicleCapacity
            // 
            this.LblVehicleCapacity.AutoSize = true;
            this.LblVehicleCapacity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleCapacity.Location = new System.Drawing.Point(43, 253);
            this.LblVehicleCapacity.Name = "LblVehicleCapacity";
            this.LblVehicleCapacity.Size = new System.Drawing.Size(124, 23);
            this.LblVehicleCapacity.TabIndex = 301;
            this.LblVehicleCapacity.Text = "Driver Gender :";
            // 
            // LblVehicleClassType
            // 
            this.LblVehicleClassType.AutoSize = true;
            this.LblVehicleClassType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleClassType.Location = new System.Drawing.Point(41, 338);
            this.LblVehicleClassType.Name = "LblVehicleClassType";
            this.LblVehicleClassType.Size = new System.Drawing.Size(201, 23);
            this.LblVehicleClassType.TabIndex = 300;
            this.LblVehicleClassType.Text = "Truck Driver Experiance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 295;
            this.label5.Text = "Experiance :";
            // 
            // LblExperiance
            // 
            this.LblExperiance.AutoSize = true;
            this.LblExperiance.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExperiance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblExperiance.Location = new System.Drawing.Point(588, 335);
            this.LblExperiance.Name = "LblExperiance";
            this.LblExperiance.Size = new System.Drawing.Size(39, 23);
            this.LblExperiance.TabIndex = 296;
            this.LblExperiance.Text = "Exp";
            this.LblExperiance.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 294;
            this.label3.Text = "Age : ";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblAge.Location = new System.Drawing.Point(531, 212);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(40, 23);
            this.LblAge.TabIndex = 297;
            this.LblAge.Text = "Age";
            this.LblAge.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 298;
            this.label4.Text = "Bank Account Number :";
            // 
            // LblChassisNo
            // 
            this.LblChassisNo.AutoSize = true;
            this.LblChassisNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChassisNo.Location = new System.Drawing.Point(469, 173);
            this.LblChassisNo.Name = "LblChassisNo";
            this.LblChassisNo.Size = new System.Drawing.Size(192, 23);
            this.LblChassisNo.TabIndex = 299;
            this.LblChassisNo.Text = "Driver License Number :";
            // 
            // lblVehicleYear
            // 
            this.lblVehicleYear.AutoSize = true;
            this.lblVehicleYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleYear.Location = new System.Drawing.Point(43, 212);
            this.lblVehicleYear.Name = "lblVehicleYear";
            this.lblVehicleYear.Size = new System.Drawing.Size(167, 23);
            this.lblVehicleYear.TabIndex = 307;
            this.lblVehicleYear.Text = "Driver Date Of Birth : ";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.Location = new System.Drawing.Point(43, 173);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(143, 23);
            this.lblVehicleNo.TabIndex = 293;
            this.lblVehicleNo.Text = "Driver Full Name :";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.Location = new System.Drawing.Point(874, 17);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(69, 72);
            this.BtnLogout.TabIndex = 292;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(789, 17);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(69, 72);
            this.BtnHome.TabIndex = 291;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(704, 17);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(69, 72);
            this.BtnBack.TabIndex = 290;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblDriverLicenseInvisible
            // 
            this.LblDriverLicenseInvisible.AutoSize = true;
            this.LblDriverLicenseInvisible.Location = new System.Drawing.Point(107, 75);
            this.LblDriverLicenseInvisible.Name = "LblDriverLicenseInvisible";
            this.LblDriverLicenseInvisible.Size = new System.Drawing.Size(35, 13);
            this.LblDriverLicenseInvisible.TabIndex = 308;
            this.LblDriverLicenseInvisible.Text = "label6";
            this.LblDriverLicenseInvisible.Visible = false;
            // 
            // FormUpdateDriverInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 812);
            this.Controls.Add(this.LblDriverLicenseInvisible);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.DTPDriverExperiance);
            this.Controls.Add(this.DTPDOB);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtMobileNumber);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtDriverAccountNumber);
            this.Controls.Add(this.TxtDriverLicense);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.LblVehicleDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVehicleMileage);
            this.Controls.Add(this.LblVehicleMake);
            this.Controls.Add(this.LblVehicleCapacity);
            this.Controls.Add(this.LblVehicleClassType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblExperiance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblChassisNo);
            this.Controls.Add(this.lblVehicleYear);
            this.Controls.Add(this.lblVehicleNo);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnBack);
            this.Name = "FormUpdateDriverInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectUpdateDriverInformation";
            this.Load += new System.EventHandler(this.FormUpdateDriverInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.DateTimePicker DTPDriverExperiance;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtMobileNumber;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtDriverAccountNumber;
        private System.Windows.Forms.TextBox TxtDriverLicense;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label LblVehicleDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblVehicleMileage;
        private System.Windows.Forms.Label LblVehicleMake;
        private System.Windows.Forms.Label LblVehicleCapacity;
        private System.Windows.Forms.Label LblVehicleClassType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblExperiance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblChassisNo;
        private System.Windows.Forms.Label lblVehicleYear;
        private System.Windows.Forms.Label lblVehicleNo;
        protected System.Windows.Forms.Button BtnLogout;
        protected System.Windows.Forms.Button BtnHome;
        protected System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblDriverLicenseInvisible;
    }
}