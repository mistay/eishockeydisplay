namespace BeaconConnectionExample
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMainClock = new System.Windows.Forms.Label();
            this.lblScoreHome = new System.Windows.Forms.Label();
            this.lblScoreAway = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(142, 26);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(93, 23);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "localhost";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblMainClock
            // 
            this.lblMainClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainClock.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainClock.Location = new System.Drawing.Point(409, 16);
            this.lblMainClock.Name = "lblMainClock";
            this.lblMainClock.Size = new System.Drawing.Size(116, 42);
            this.lblMainClock.TabIndex = 2;
            this.lblMainClock.Text = "----";
            this.lblMainClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreHome
            // 
            this.lblScoreHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScoreHome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreHome.Location = new System.Drawing.Point(360, 16);
            this.lblScoreHome.Name = "lblScoreHome";
            this.lblScoreHome.Size = new System.Drawing.Size(43, 42);
            this.lblScoreHome.TabIndex = 3;
            this.lblScoreHome.Text = "-";
            this.lblScoreHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreAway
            // 
            this.lblScoreAway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScoreAway.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAway.Location = new System.Drawing.Point(531, 16);
            this.lblScoreAway.Name = "lblScoreAway";
            this.lblScoreAway.Size = new System.Drawing.Size(43, 42);
            this.lblScoreAway.TabIndex = 4;
            this.lblScoreAway.Text = "-";
            this.lblScoreAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriod
            // 
            this.lblPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeriod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(446, 64);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(43, 42);
            this.lblPeriod.TabIndex = 5;
            this.lblPeriod.Text = "-";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(241, 26);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 23);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "25035";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(13, 113);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(43, 16);
            this.lblURL.TabIndex = 8;
            this.lblURL.Text = "lblURL";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(16, 164);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(853, 152);
            this.txtData.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data";
            // 
            // lblLogPath
            // 
            this.lblLogPath.AutoSize = true;
            this.lblLogPath.Location = new System.Drawing.Point(13, 129);
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.Size = new System.Drawing.Size(66, 16);
            this.lblLogPath.TabIndex = 13;
            this.lblLogPath.Text = "lblLogPath";
            this.lblLogPath.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 326);
            this.Controls.Add(this.lblLogPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblScoreAway);
            this.Controls.Add(this.lblScoreHome);
            this.Controls.Add(this.lblMainClock);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "hockeydata2web gateway";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            txtAddress.Text = Properties.Settings.Default.îpaddress;
            txtPort.Text = Properties.Settings.Default.port;

            start();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMainClock;
        private System.Windows.Forms.Label lblScoreHome;
        private System.Windows.Forms.Label lblScoreAway;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogPath;
    }
}

