namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbGetPort = new System.Windows.Forms.TextBox();
            this.lbEnter = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.lbGetPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("新細明體", 16F);
            this.buttonEnter.Location = new System.Drawing.Point(716, 363);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(100, 41);
            this.buttonEnter.TabIndex = 23;
            this.buttonEnter.Text = "傳送";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Font = new System.Drawing.Font("新細明體", 16F);
            this.buttonGet.Location = new System.Drawing.Point(687, 95);
            this.buttonGet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(155, 42);
            this.buttonGet.TabIndex = 22;
            this.buttonGet.Text = "啟動接收";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // tbEnter
            // 
            this.tbEnter.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbEnter.Location = new System.Drawing.Point(165, 363);
            this.tbEnter.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(512, 39);
            this.tbEnter.TabIndex = 21;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbPort.Location = new System.Drawing.Point(165, 315);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(132, 39);
            this.tbPort.TabIndex = 20;
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbIP.Location = new System.Drawing.Point(165, 253);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(132, 39);
            this.tbIP.TabIndex = 19;
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbText.Location = new System.Drawing.Point(165, 96);
            this.tbText.Margin = new System.Windows.Forms.Padding(4);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(512, 39);
            this.tbText.TabIndex = 18;
            // 
            // tbGetPort
            // 
            this.tbGetPort.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbGetPort.Location = new System.Drawing.Point(165, 47);
            this.tbGetPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbGetPort.Name = "tbGetPort";
            this.tbGetPort.Size = new System.Drawing.Size(132, 39);
            this.tbGetPort.TabIndex = 17;
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbEnter.Location = new System.Drawing.Point(41, 367);
            this.lbEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(120, 27);
            this.lbEnter.TabIndex = 16;
            this.lbEnter.Text = "傳送文字";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbPort.Location = new System.Drawing.Point(41, 319);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(108, 27);
            this.lbPort.TabIndex = 15;
            this.lbPort.Text = "目標Port";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbIP.Location = new System.Drawing.Point(41, 257);
            this.lbIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(88, 27);
            this.lbIP.TabIndex = 14;
            this.lbIP.Text = "目標IP";
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbText.Location = new System.Drawing.Point(41, 100);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(120, 27);
            this.lbText.TabIndex = 13;
            this.lbText.Text = "接收文字";
            // 
            // lbGetPort
            // 
            this.lbGetPort.AutoSize = true;
            this.lbGetPort.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbGetPort.Location = new System.Drawing.Point(41, 51);
            this.lbGetPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGetPort.Name = "lbGetPort";
            this.lbGetPort.Size = new System.Drawing.Size(108, 27);
            this.lbGetPort.TabIndex = 12;
            this.lbGetPort.Text = "接聽Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbGetPort);
            this.Controls.Add(this.lbEnter);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbGetPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbGetPort;
        private System.Windows.Forms.Label lbEnter;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbGetPort;
    }
}

