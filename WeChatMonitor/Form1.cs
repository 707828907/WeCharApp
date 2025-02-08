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
                // ʹ�� InvokeRequired ������Ƿ���Ҫ���� Invoke
                if (lblStatus != null)
                {
                    lblStatus.Text = isValid ? "��֤�ɹ�" : "��֤ʧ��";
                }
                else
                {
                    MessageBox.Show("״̬��ǩ�ؼ�δ��ʼ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = isValid ? "��֤�ɹ�" : "��֤ʧ��";
                    }));
                }
                else
                {
                    lblStatus.Text = isValid ? "��֤�ɹ�" : "��֤ʧ��";
                }
            }
            catch (Exception ex)
            {
                // ��¼�������쳣��Ϣ��������ջ����
                MessageBox.Show($"��������: {ex.Message}\n\n��ջ����:\n{ex.StackTrace}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // �������־ϵͳ���ã�Ӧ���������¼����
                // logger.LogError(ex, "��֤�ļ�ʱ��������");
            }
        }

        private bool ValidateFile(string filePath)
        {
            return !string.IsNullOrWhiteSpace(filePath); // ���طǿ��ַ�����Ϊ��Ч
        }
    }
}