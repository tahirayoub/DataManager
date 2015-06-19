namespace DataManager.TruckInformation
{
    partial class FormViewVehicleInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewVehicleInformation));
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtVehicleClassType = new System.Windows.Forms.ComboBox();
            this.TxtVehicleDescription = new System.Windows.Forms.TextBox();
            this.TxtVehicleMileage = new System.Windows.Forms.TextBox();
            this.TxtVehicleMake = new System.Windows.Forms.TextBox();
            this.TxtVehicleCapacity = new System.Windows.Forms.TextBox();
            this.TxtVehicleYear = new System.Windows.Forms.TextBox();
            this.TxtChassisNo = new System.Windows.Forms.TextBox();
            this.TxtVehicleNo = new System.Windows.Forms.TextBox();
            this.LblVehicleDescription = new System.Windows.Forms.Label();
            this.LblVehicleMileage = new System.Windows.Forms.Label();
            this.LblVehicleMake = new System.Windows.Forms.Label();
            this.LblVehicleCapacity = new System.Windows.Forms.Label();
            this.LblVehicleClassType = new System.Windows.Forms.Label();
            this.LblChassisNo = new System.Windows.Forms.Label();
            this.lblVehicleYear = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblChassisNumberInvisible = new System.Windows.Forms.Label();
            this.LblVehicleNumberInvisible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.Location = new System.Drawing.Point(674, 34);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(69, 72);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(589, 34);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(69, 72);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(504, 34);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(69, 72);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtVehicleClassType
            // 
            this.TxtVehicleClassType.Enabled = false;
            this.TxtVehicleClassType.FormattingEnabled = true;
            this.TxtVehicleClassType.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.TxtVehicleClassType.Location = new System.Drawing.Point(198, 273);
            this.TxtVehicleClassType.Name = "TxtVehicleClassType";
            this.TxtVehicleClassType.Size = new System.Drawing.Size(168, 21);
            this.TxtVehicleClassType.TabIndex = 281;
            // 
            // TxtVehicleDescription
            // 
            this.TxtVehicleDescription.Enabled = false;
            this.TxtVehicleDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleDescription.Location = new System.Drawing.Point(198, 436);
            this.TxtVehicleDescription.Multiline = true;
            this.TxtVehicleDescription.Name = "TxtVehicleDescription";
            this.TxtVehicleDescription.Size = new System.Drawing.Size(407, 123);
            this.TxtVehicleDescription.TabIndex = 274;
            // 
            // TxtVehicleMileage
            // 
            this.TxtVehicleMileage.Enabled = false;
            this.TxtVehicleMileage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleMileage.Location = new System.Drawing.Point(198, 397);
            this.TxtVehicleMileage.Name = "TxtVehicleMileage";
            this.TxtVehicleMileage.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleMileage.TabIndex = 275;
            // 
            // TxtVehicleMake
            // 
            this.TxtVehicleMake.Enabled = false;
            this.TxtVehicleMake.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleMake.Location = new System.Drawing.Point(198, 356);
            this.TxtVehicleMake.Name = "TxtVehicleMake";
            this.TxtVehicleMake.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleMake.TabIndex = 276;
            // 
            // TxtVehicleCapacity
            // 
            this.TxtVehicleCapacity.Enabled = false;
            this.TxtVehicleCapacity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleCapacity.Location = new System.Drawing.Point(198, 310);
            this.TxtVehicleCapacity.Name = "TxtVehicleCapacity";
            this.TxtVehicleCapacity.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleCapacity.TabIndex = 277;
            // 
            // TxtVehicleYear
            // 
            this.TxtVehicleYear.Enabled = false;
            this.TxtVehicleYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleYear.Location = new System.Drawing.Point(198, 228);
            this.TxtVehicleYear.Name = "TxtVehicleYear";
            this.TxtVehicleYear.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleYear.TabIndex = 278;
            // 
            // TxtChassisNo
            // 
            this.TxtChassisNo.Enabled = false;
            this.TxtChassisNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChassisNo.Location = new System.Drawing.Point(623, 189);
            this.TxtChassisNo.Name = "TxtChassisNo";
            this.TxtChassisNo.Size = new System.Drawing.Size(168, 29);
            this.TxtChassisNo.TabIndex = 279;
            // 
            // TxtVehicleNo
            // 
            this.TxtVehicleNo.Enabled = false;
            this.TxtVehicleNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNo.Location = new System.Drawing.Point(198, 189);
            this.TxtVehicleNo.Name = "TxtVehicleNo";
            this.TxtVehicleNo.Size = new System.Drawing.Size(168, 29);
            this.TxtVehicleNo.TabIndex = 280;
            // 
            // LblVehicleDescription
            // 
            this.LblVehicleDescription.AutoSize = true;
            this.LblVehicleDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleDescription.Location = new System.Drawing.Point(34, 442);
            this.LblVehicleDescription.Name = "LblVehicleDescription";
            this.LblVehicleDescription.Size = new System.Drawing.Size(169, 23);
            this.LblVehicleDescription.TabIndex = 266;
            this.LblVehicleDescription.Text = "Vehicle Description : ";
            // 
            // LblVehicleMileage
            // 
            this.LblVehicleMileage.AutoSize = true;
            this.LblVehicleMileage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleMileage.Location = new System.Drawing.Point(34, 400);
            this.LblVehicleMileage.Name = "LblVehicleMileage";
            this.LblVehicleMileage.Size = new System.Drawing.Size(140, 23);
            this.LblVehicleMileage.TabIndex = 267;
            this.LblVehicleMileage.Text = "Vehicle Mileage : ";
            // 
            // LblVehicleMake
            // 
            this.LblVehicleMake.AutoSize = true;
            this.LblVehicleMake.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleMake.Location = new System.Drawing.Point(34, 362);
            this.LblVehicleMake.Name = "LblVehicleMake";
            this.LblVehicleMake.Size = new System.Drawing.Size(122, 23);
            this.LblVehicleMake.TabIndex = 268;
            this.LblVehicleMake.Text = "Vehicle Make : ";
            // 
            // LblVehicleCapacity
            // 
            this.LblVehicleCapacity.AutoSize = true;
            this.LblVehicleCapacity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleCapacity.Location = new System.Drawing.Point(34, 316);
            this.LblVehicleCapacity.Name = "LblVehicleCapacity";
            this.LblVehicleCapacity.Size = new System.Drawing.Size(148, 23);
            this.LblVehicleCapacity.TabIndex = 269;
            this.LblVehicleCapacity.Text = "Vehicle Capacity : ";
            // 
            // LblVehicleClassType
            // 
            this.LblVehicleClassType.AutoSize = true;
            this.LblVehicleClassType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleClassType.Location = new System.Drawing.Point(34, 273);
            this.LblVehicleClassType.Name = "LblVehicleClassType";
            this.LblVehicleClassType.Size = new System.Drawing.Size(166, 23);
            this.LblVehicleClassType.TabIndex = 270;
            this.LblVehicleClassType.Text = "Vehicle Class Type : ";
            // 
            // LblChassisNo
            // 
            this.LblChassisNo.AutoSize = true;
            this.LblChassisNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChassisNo.Location = new System.Drawing.Point(412, 195);
            this.LblChassisNo.Name = "LblChassisNo";
            this.LblChassisNo.Size = new System.Drawing.Size(203, 23);
            this.LblChassisNo.TabIndex = 271;
            this.LblChassisNo.Text = "Vehicle Chassis Number :";
            // 
            // lblVehicleYear
            // 
            this.lblVehicleYear.AutoSize = true;
            this.lblVehicleYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleYear.Location = new System.Drawing.Point(34, 234);
            this.lblVehicleYear.Name = "lblVehicleYear";
            this.lblVehicleYear.Size = new System.Drawing.Size(116, 23);
            this.lblVehicleYear.TabIndex = 272;
            this.lblVehicleYear.Text = "Vehicle Year : ";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.Location = new System.Drawing.Point(34, 195);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(142, 23);
            this.lblVehicleNo.TabIndex = 273;
            this.lblVehicleNo.Text = "Vehicle Number : ";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(276, 34);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(81, 73);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblChassisNumberInvisible
            // 
            this.LblChassisNumberInvisible.AutoSize = true;
            this.LblChassisNumberInvisible.Location = new System.Drawing.Point(50, 68);
            this.LblChassisNumberInvisible.Name = "LblChassisNumberInvisible";
            this.LblChassisNumberInvisible.Size = new System.Drawing.Size(35, 13);
            this.LblChassisNumberInvisible.TabIndex = 301;
            this.LblChassisNumberInvisible.Text = "label1";
            this.LblChassisNumberInvisible.Visible = false;
            // 
            // LblVehicleNumberInvisible
            // 
            this.LblVehicleNumberInvisible.AutoSize = true;
            this.LblVehicleNumberInvisible.Location = new System.Drawing.Point(50, 34);
            this.LblVehicleNumberInvisible.Name = "LblVehicleNumberInvisible";
            this.LblVehicleNumberInvisible.Size = new System.Drawing.Size(35, 13);
            this.LblVehicleNumberInvisible.TabIndex = 302;
            this.LblVehicleNumberInvisible.Text = "label1";
            this.LblVehicleNumberInvisible.Visible = false;
            // 
            // FormViewVehicleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 812);
            this.Controls.Add(this.LblChassisNumberInvisible);
            this.Controls.Add(this.LblVehicleNumberInvisible);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtVehicleClassType);
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
            this.Name = "FormViewVehicleInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewVehicleInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewVehicleInformation_FormClosed);
            this.Load += new System.EventHandler(this.FormViewVehicleInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnLogout;
        protected System.Windows.Forms.Button BtnHome;
        protected System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox TxtVehicleClassType;
        private System.Windows.Forms.TextBox TxtVehicleDescription;
        private System.Windows.Forms.TextBox TxtVehicleMileage;
        private System.Windows.Forms.TextBox TxtVehicleMake;
        private System.Windows.Forms.TextBox TxtVehicleCapacity;
        private System.Windows.Forms.TextBox TxtVehicleYear;
        private System.Windows.Forms.TextBox TxtChassisNo;
        private System.Windows.Forms.TextBox TxtVehicleNo;
        private System.Windows.Forms.Label LblVehicleDescription;
        private System.Windows.Forms.Label LblVehicleMileage;
        private System.Windows.Forms.Label LblVehicleMake;
        private System.Windows.Forms.Label LblVehicleCapacity;
        private System.Windows.Forms.Label LblVehicleClassType;
        private System.Windows.Forms.Label LblChassisNo;
        private System.Windows.Forms.Label lblVehicleYear;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblChassisNumberInvisible;
        private System.Windows.Forms.Label LblVehicleNumberInvisible;
    }
}