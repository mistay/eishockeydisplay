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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 115);
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
            this.Text = "Beacon Connection Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label lblMainClock;
    private System.Windows.Forms.Label lblScoreHome;
    private System.Windows.Forms.Label lblScoreAway;
    private System.Windows.Forms.Label lblPeriod;
    private System.Windows.Forms.TextBox txtPort;
  }
}

