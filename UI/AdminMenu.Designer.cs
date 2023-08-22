
namespace TMS.UI
{
    partial class AdminMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UnRegisterTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewRegisteredBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ManageDriverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.HeadLbl);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1741, 91);
            this.panel1.TabIndex = 0;
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLbl.ForeColor = System.Drawing.Color.White;
            this.HeadLbl.Location = new System.Drawing.Point(741, 29);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(165, 32);
            this.HeadLbl.TabIndex = 3;
            this.HeadLbl.Text = "Welcome , ";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Animated = true;
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.BorderColor = System.Drawing.Color.Red;
            this.logOutBtn.CustomBorderColor = System.Drawing.Color.Red;
            this.logOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutBtn.FillColor = System.Drawing.Color.Red;
            this.logOutBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(1540, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(123, 36);
            this.logOutBtn.TabIndex = 14;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseTransparentBackground = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(197, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train Managment System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMS.Properties.Resources.train;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.RegisterTrainBtn);
            this.panel2.Controls.Add(this.UnRegisterTrainBtn);
            this.panel2.Controls.Add(this.viewRegisteredBtn);
            this.panel2.Controls.Add(this.ManageDriverBtn);
            this.panel2.Controls.Add(this.manageTrainBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1741, 65);
            this.panel2.TabIndex = 1;
            // 
            // RegisterTrainBtn
            // 
            this.RegisterTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTrainBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterTrainBtn.Location = new System.Drawing.Point(661, -3);
            this.RegisterTrainBtn.Name = "RegisterTrainBtn";
            this.RegisterTrainBtn.Size = new System.Drawing.Size(263, 65);
            this.RegisterTrainBtn.TabIndex = 5;
            this.RegisterTrainBtn.Text = "Register Trains";
            this.RegisterTrainBtn.Click += new System.EventHandler(this.RegisterTrainBtn_Click);
            // 
            // UnRegisterTrainBtn
            // 
            this.UnRegisterTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UnRegisterTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UnRegisterTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UnRegisterTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UnRegisterTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnRegisterTrainBtn.ForeColor = System.Drawing.Color.White;
            this.UnRegisterTrainBtn.Location = new System.Drawing.Point(1024, 3);
            this.UnRegisterTrainBtn.Name = "UnRegisterTrainBtn";
            this.UnRegisterTrainBtn.Size = new System.Drawing.Size(222, 65);
            this.UnRegisterTrainBtn.TabIndex = 4;
            this.UnRegisterTrainBtn.Text = "UnRegister Trains";
            this.UnRegisterTrainBtn.Click += new System.EventHandler(this.UnRegisterTrainBtn_Click);
            // 
            // viewRegisteredBtn
            // 
            this.viewRegisteredBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewRegisteredBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewRegisteredBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewRegisteredBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewRegisteredBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRegisteredBtn.ForeColor = System.Drawing.Color.White;
            this.viewRegisteredBtn.Location = new System.Drawing.Point(1373, 0);
            this.viewRegisteredBtn.Name = "viewRegisteredBtn";
            this.viewRegisteredBtn.Size = new System.Drawing.Size(222, 65);
            this.viewRegisteredBtn.TabIndex = 3;
            this.viewRegisteredBtn.Text = "View Registered";
            this.viewRegisteredBtn.Click += new System.EventHandler(this.viewRegisteredBtn_Click);
            // 
            // ManageDriverBtn
            // 
            this.ManageDriverBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageDriverBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageDriverBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageDriverBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageDriverBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageDriverBtn.ForeColor = System.Drawing.Color.White;
            this.ManageDriverBtn.Location = new System.Drawing.Point(354, -3);
            this.ManageDriverBtn.Name = "ManageDriverBtn";
            this.ManageDriverBtn.Size = new System.Drawing.Size(222, 65);
            this.ManageDriverBtn.TabIndex = 2;
            this.ManageDriverBtn.Text = "Manage Drivers";
            this.ManageDriverBtn.Click += new System.EventHandler(this.ManageDriverBtn_Click);
            // 
            // manageTrainBtn
            // 
            this.manageTrainBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manageTrainBtn.BorderColor = System.Drawing.Color.Red;
            this.manageTrainBtn.CustomBorderColor = System.Drawing.Color.Red;
            this.manageTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTrainBtn.ForeColor = System.Drawing.Color.White;
            this.manageTrainBtn.Location = new System.Drawing.Point(3, 0);
            this.manageTrainBtn.Name = "manageTrainBtn";
            this.manageTrainBtn.Size = new System.Drawing.Size(222, 65);
            this.manageTrainBtn.TabIndex = 0;
            this.manageTrainBtn.Text = "Manage Trains ";
            this.manageTrainBtn.Click += new System.EventHandler(this.manageTrainBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label14);
            this.panelContainer.Controls.Add(this.label13);
            this.panelContainer.Controls.Add(this.label9);
            this.panelContainer.Controls.Add(this.label12);
            this.panelContainer.Controls.Add(this.label11);
            this.panelContainer.Controls.Add(this.label10);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 156);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1741, 579);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(213, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manage Trains:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(200, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Manage Drivers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(220, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Register Trains:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Features:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GreenYellow;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(184, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Un Register Trains:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(220, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "View Register:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(430, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(710, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "You can Add, Delete, or Update Trains Data and after process it is saved into fil" +
    "e";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(430, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(571, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "You are asked to enter Train name and Driver name. If they Exist";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(430, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(763, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "and not already registered to any train then these are registered data is saved i" +
    "nto file";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(430, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(774, 22);
            this.label12.TabIndex = 10;
            this.label12.Text = "You can Add, Delete, or Update Trains Drivers Data and after process it is saved " +
    "into file";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(430, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(601, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "You are required to enter a Registered Train Name, and if data exist";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(443, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(472, 22);
            this.label13.TabIndex = 12;
            this.label13.Text = "then that Train is Un registered and  Deleted from file ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(441, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(763, 22);
            this.label14.TabIndex = 13;
            this.label14.Text = "To see all Registed Trains . Also here you can see all customers who used your se" +
    "rvice";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 735);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button RegisterTrainBtn;
        private Guna.UI2.WinForms.Guna2Button UnRegisterTrainBtn;
        private Guna.UI2.WinForms.Guna2Button viewRegisteredBtn;
        private Guna.UI2.WinForms.Guna2Button ManageDriverBtn;
        private Guna.UI2.WinForms.Guna2Button manageTrainBtn;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}