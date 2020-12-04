namespace USBHIDControl
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
            this.tb_information = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.list_UsbHID = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_information
            // 
            this.tb_information.AllowDrop = true;
            this.tb_information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_information.Location = new System.Drawing.Point(19, 140);
            this.tb_information.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_information.Multiline = true;
            this.tb_information.Name = "tb_information";
            this.tb_information.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_information.Size = new System.Drawing.Size(545, 243);
            this.tb_information.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "SendInformation:";
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(159, 391);
            this.tb_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(404, 25);
            this.tb_send.TabIndex = 8;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(19, 429);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 29);
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(464, 429);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 29);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(356, 429);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 29);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // list_UsbHID
            // 
            this.list_UsbHID.FormattingEnabled = true;
            this.list_UsbHID.ItemHeight = 15;
            this.list_UsbHID.Location = new System.Drawing.Point(19, 38);
            this.list_UsbHID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_UsbHID.Name = "list_UsbHID";
            this.list_UsbHID.Size = new System.Drawing.Size(914, 79);
            this.list_UsbHID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "USBHIDList：:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_UsbHID);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_information);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_information;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox list_UsbHID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

