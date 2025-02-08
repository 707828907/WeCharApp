using System;
using System.Windows.Forms;

namespace WeChatMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wechatConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentUserId = GetCurrentUserId();
            using (var userConfigForm = new UserConfigForm(currentUserId))
            {
                userConfigForm.ShowDialog();
            }
        }

        private string GetCurrentUserId()
        {
            return "example_user_id";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool isValid = ValidateFile(txtFilePath.Text);
                // 使用 InvokeRequired 来检查是否需要调用 Invoke
                if (lblStatus != null)
                {
                    lblStatus.Text = isValid ? "验证成功" : "验证失败";
                }
                else
                {
                    MessageBox.Show("状态标签控件未初始化。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = isValid ? "验证成功" : "验证失败";
                    }));
                }
                else
                {
                    lblStatus.Text = isValid ? "验证成功" : "验证失败";
                }
            }
            catch (Exception ex)
            {
                // 记录完整的异常信息，包括堆栈跟踪
                MessageBox.Show($"发生错误: {ex.Message}\n\n堆栈跟踪:\n{ex.StackTrace}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 如果有日志系统可用，应该在这里记录错误
                // logger.LogError(ex, "验证文件时发生错误");
            }
        }

        private bool ValidateFile(string filePath)
        {
            return !string.IsNullOrWhiteSpace(filePath); // 返回非空字符串视为有效
        }
    }
}