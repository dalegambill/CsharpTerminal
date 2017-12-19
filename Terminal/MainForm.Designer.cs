namespace Terminal
{
  partial class Main
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
      this.laCOM_Port = new System.Windows.Forms.Label();
      this.tbComPort = new System.Windows.Forms.TextBox();
      this.laBaud_Rate = new System.Windows.Forms.Label();
      this.tbBaudRate = new System.Windows.Forms.TextBox();
      this.bOpenComPort = new System.Windows.Forms.Button();
      this.bClearRxData = new System.Windows.Forms.Button();
      this.bReplayLog = new System.Windows.Forms.Button();
      this.bSendMessage = new System.Windows.Forms.Button();
      this.BAbout = new System.Windows.Forms.Button();
      this.bTutorials = new System.Windows.Forms.Button();
      this.tbMessageToSend = new System.Windows.Forms.TextBox();
      this.tbDataWindow = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // laCOM_Port
      // 
      this.laCOM_Port.AutoSize = true;
      this.laCOM_Port.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.laCOM_Port.Location = new System.Drawing.Point(24, 30);
      this.laCOM_Port.Name = "laCOM_Port";
      this.laCOM_Port.Size = new System.Drawing.Size(71, 20);
      this.laCOM_Port.TabIndex = 0;
      this.laCOM_Port.Text = "COM Port:";
      // 
      // tbComPort
      // 
      this.tbComPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbComPort.Location = new System.Drawing.Point(101, 24);
      this.tbComPort.Name = "tbComPort";
      this.tbComPort.Size = new System.Drawing.Size(100, 26);
      this.tbComPort.TabIndex = 1;
      this.tbComPort.Text = "COM1";
      // 
      // laBaud_Rate
      // 
      this.laBaud_Rate.AutoSize = true;
      this.laBaud_Rate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.laBaud_Rate.Location = new System.Drawing.Point(24, 70);
      this.laBaud_Rate.Name = "laBaud_Rate";
      this.laBaud_Rate.Size = new System.Drawing.Size(75, 20);
      this.laBaud_Rate.TabIndex = 2;
      this.laBaud_Rate.Text = "Baud Rate:";
      // 
      // tbBaudRate
      // 
      this.tbBaudRate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbBaudRate.Location = new System.Drawing.Point(101, 64);
      this.tbBaudRate.Name = "tbBaudRate";
      this.tbBaudRate.Size = new System.Drawing.Size(100, 26);
      this.tbBaudRate.TabIndex = 3;
      this.tbBaudRate.Text = "38400";
      // 
      // bOpenComPort
      // 
      this.bOpenComPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bOpenComPort.Location = new System.Drawing.Point(242, 21);
      this.bOpenComPort.Name = "bOpenComPort";
      this.bOpenComPort.Size = new System.Drawing.Size(148, 32);
      this.bOpenComPort.TabIndex = 4;
      this.bOpenComPort.Text = "Open COM Port";
      this.bOpenComPort.UseVisualStyleBackColor = true;
      this.bOpenComPort.Click += new System.EventHandler(this.bOpenComPort_Click);
      // 
      // bClearRxData
      // 
      this.bClearRxData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bClearRxData.Location = new System.Drawing.Point(242, 61);
      this.bClearRxData.Name = "bClearRxData";
      this.bClearRxData.Size = new System.Drawing.Size(148, 32);
      this.bClearRxData.TabIndex = 5;
      this.bClearRxData.Text = "Clear Rx Data";
      this.bClearRxData.UseVisualStyleBackColor = true;
      this.bClearRxData.Click += new System.EventHandler(this.bClearRxData_Click);
      // 
      // bReplayLog
      // 
      this.bReplayLog.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bReplayLog.Location = new System.Drawing.Point(417, 21);
      this.bReplayLog.Name = "bReplayLog";
      this.bReplayLog.Size = new System.Drawing.Size(148, 32);
      this.bReplayLog.TabIndex = 6;
      this.bReplayLog.Text = "Replay Log";
      this.bReplayLog.UseVisualStyleBackColor = true;
      this.bReplayLog.Click += new System.EventHandler(this.bReplayLog_Click);
      // 
      // bSendMessage
      // 
      this.bSendMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bSendMessage.Location = new System.Drawing.Point(417, 64);
      this.bSendMessage.Name = "bSendMessage";
      this.bSendMessage.Size = new System.Drawing.Size(148, 32);
      this.bSendMessage.TabIndex = 7;
      this.bSendMessage.Text = "Send Message";
      this.bSendMessage.UseVisualStyleBackColor = true;
      this.bSendMessage.Click += new System.EventHandler(this.bSendMessage_Click);
      // 
      // BAbout
      // 
      this.BAbout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BAbout.Location = new System.Drawing.Point(585, 21);
      this.BAbout.Name = "BAbout";
      this.BAbout.Size = new System.Drawing.Size(148, 32);
      this.BAbout.TabIndex = 8;
      this.BAbout.Text = "About";
      this.BAbout.UseVisualStyleBackColor = true;
      this.BAbout.Click += new System.EventHandler(this.BAbout_Click);
      // 
      // bTutorials
      // 
      this.bTutorials.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bTutorials.Location = new System.Drawing.Point(759, 24);
      this.bTutorials.Name = "bTutorials";
      this.bTutorials.Size = new System.Drawing.Size(148, 32);
      this.bTutorials.TabIndex = 9;
      this.bTutorials.Text = "Tutorials";
      this.bTutorials.UseVisualStyleBackColor = true;
      this.bTutorials.Click += new System.EventHandler(this.bTutorials_Click);
      // 
      // tbMessageToSend
      // 
      this.tbMessageToSend.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbMessageToSend.Location = new System.Drawing.Point(585, 70);
      this.tbMessageToSend.Name = "tbMessageToSend";
      this.tbMessageToSend.Size = new System.Drawing.Size(322, 26);
      this.tbMessageToSend.TabIndex = 10;
      // 
      // tbDataWindow
      // 
      this.tbDataWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbDataWindow.Location = new System.Drawing.Point(12, 118);
      this.tbDataWindow.Multiline = true;
      this.tbDataWindow.Name = "tbDataWindow";
      this.tbDataWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbDataWindow.Size = new System.Drawing.Size(895, 480);
      this.tbDataWindow.TabIndex = 11;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(919, 610);
      this.Controls.Add(this.tbDataWindow);
      this.Controls.Add(this.tbMessageToSend);
      this.Controls.Add(this.bTutorials);
      this.Controls.Add(this.BAbout);
      this.Controls.Add(this.bSendMessage);
      this.Controls.Add(this.bReplayLog);
      this.Controls.Add(this.bClearRxData);
      this.Controls.Add(this.bOpenComPort);
      this.Controls.Add(this.tbBaudRate);
      this.Controls.Add(this.laBaud_Rate);
      this.Controls.Add(this.tbComPort);
      this.Controls.Add(this.laCOM_Port);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "TERMINAL - Serial Data Terminal v1.00";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label laCOM_Port;
    private System.Windows.Forms.TextBox tbComPort;
    private System.Windows.Forms.Label laBaud_Rate;
    private System.Windows.Forms.TextBox tbBaudRate;
    private System.Windows.Forms.Button bOpenComPort;
    private System.Windows.Forms.Button bClearRxData;
    private System.Windows.Forms.Button bReplayLog;
    private System.Windows.Forms.Button bSendMessage;
    private System.Windows.Forms.Button BAbout;
    private System.Windows.Forms.Button bTutorials;
    private System.Windows.Forms.TextBox tbMessageToSend;
    private System.Windows.Forms.TextBox tbDataWindow;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Timer timer2;
  }
}

