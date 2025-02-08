namespace WeChatMonitor
{
    partial class UserConfigForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "UserConfigForm";

            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();

            // 控件属性设置和布局代码...

            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.txtAppSecret);
            this.Controls.Add(this.txtToken);
        }
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.TextBox txtToken;

        #endregion
    }
}