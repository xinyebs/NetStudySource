namespace socketChart
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.listClient = new System.Windows.Forms.ListBox();
            this.txtResive = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(316, 4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "开始监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(41, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(199, 9);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(100, 21);
            this.txtPoint.TabIndex = 4;
            this.txtPoint.Text = "5001";
            // 
            // listClient
            // 
            this.listClient.FormattingEnabled = true;
            this.listClient.ItemHeight = 12;
            this.listClient.Location = new System.Drawing.Point(410, 46);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(183, 208);
            this.listClient.TabIndex = 5;
            // 
            // txtResive
            // 
            this.txtResive.Location = new System.Drawing.Point(14, 46);
            this.txtResive.Multiline = true;
            this.txtResive.Name = "txtResive";
            this.txtResive.Size = new System.Drawing.Size(370, 200);
            this.txtResive.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(309, 264);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(25, 254);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(264, 38);
            this.txtmsg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 319);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtResive);
            this.Controls.Add(this.listClient);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.ListBox listClient;
        private System.Windows.Forms.TextBox txtResive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtmsg;
    }
}

