﻿namespace CarReservationSystem
{
    partial class Home
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
            this.CarsCon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showCars = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsCon
            // 
            this.CarsCon.AccessibleName = "CarsCon";
            this.CarsCon.Location = new System.Drawing.Point(94, 20);
            this.CarsCon.Margin = new System.Windows.Forms.Padding(0);
            this.CarsCon.Name = "CarsCon";
            this.CarsCon.Size = new System.Drawing.Size(819, 510);
            this.CarsCon.TabIndex = 3;
            this.CarsCon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 0, 350, 0);
            this.label1.Size = new System.Drawing.Size(913, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Reservation System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // showCars
            // 
            this.showCars.AccessibleName = "";
            this.showCars.BackColor = System.Drawing.Color.Lime;
            this.showCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCars.Location = new System.Drawing.Point(3, 6);
            this.showCars.Name = "showCars";
            this.showCars.Size = new System.Drawing.Size(88, 32);
            this.showCars.TabIndex = 0;
            this.showCars.Text = "Cars";
            this.showCars.UseVisualStyleBackColor = false;
            this.showCars.Click += new System.EventHandler(this.showCars_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AccessibleName = "";
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(3, 44);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(87, 29);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.AccessibleName = "";
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Location = new System.Drawing.Point(3, 483);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(57, 24);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.showCars);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 517);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(926, 532);
            this.Controls.Add(this.CarsCon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CarsCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showCars;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Panel panel1;
    }
}