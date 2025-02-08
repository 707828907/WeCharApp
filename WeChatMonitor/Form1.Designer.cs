namespace WeChatMonitor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.lblAppSecret = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtToken
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(20, 20);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(44, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Token";

            this.txtToken.Location = new System.Drawing.Point(80, 17);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(200, 20);
            this.txtToken.TabIndex = 1;

            // lblFilePath
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(20, 50);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(56, 13);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "文件路径";

            // txtFilePath
            this.txtFilePath.Location = new System.Drawing.Point(80, 47);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtFilePath.TabIndex = 3;

            // btnBrowse
            this.btnBrowse.Location = new System.Drawing.Point(290, 45);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click); // 确保此行存在且正确

            // btnValidate
            this.btnValidate.Location = new System.Drawing.Point(80, 80);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "验证";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // lblAppId
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(20, 120);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(53, 13);
            this.lblAppId.TabIndex = 6;
            this.lblAppId.Text = "App ID";

            // txtAppId
            this.txtAppId.Location = new System.Drawing.Point(80, 117);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(200, 20);
            this.txtAppId.TabIndex = 7;

            // lblAppSecret
            this.lblAppSecret.AutoSize = true;
            this.lblAppSecret.Location = new System.Drawing.Point(20, 150);
            this.lblAppSecret.Name = "lblAppSecret";
            this.lblAppSecret.Size = new System.Drawing.Size(61, 13);
            this.lblAppSecret.TabIndex = 8;
            this.lblAppSecret.Text = "App Secret";

            // txtAppSecret
            this.txtAppSecret.Location = new System.Drawing.Point(80, 147);
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.Size = new System.Drawing.Size(200, 20);
            this.txtAppSecret.TabIndex = 9;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblAppSecret);
            this.Controls.Add(this.txtAppSecret);
            this.Controls.Add(this.lblAppId);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.Name = "Form1";
            this.Text = "微信公众号验证";
            this.ResumeLayout(false);
            this.PerformLayout();

            // lblStatus
            this.lblStatus = new System.Windows.Forms.Label(); // 初始化状态标签
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 180); // 设置位置以适应您的布局
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 13);
            this.lblStatus.TabIndex = 10; // 根据实际情况调整 TabIndex
            this.lblStatus.Text = "状态信息"; // 初始文本

            // 确保 lblStatus 添加到窗体的控件集合中
            this.Controls.Add(this.lblStatus);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220); // 调整窗体高度以容纳新控件
            this.Controls.Add(this.lblAppSecret);
            this.Controls.Add(this.txtAppSecret);
            this.Controls.Add(this.lblAppId);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.Name = "Form1";
            this.Text = "微信公众号验证";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.Label lblAppSecret;
        private System.Windows.Forms.Label lblStatus; // 声明状态标签变量
    }
}