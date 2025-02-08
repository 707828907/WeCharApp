using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WeChatDataAccess;

namespace WeChatMonitor
{
    public partial class UserConfigForm : Form
    {
        private readonly string _userId;

        public UserConfigForm(string userId)
        {
            InitializeComponent(); // 确保这一行存在
            _userId = userId;
            LoadUserConfigurationAsync(_userId).Wait();
        }

        private async Task LoadUserConfigurationAsync(string userId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://your-api-gateway-url/api/userconfig/{userId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var config = JsonConvert.DeserializeObject<UserConfiguration>(content);

                        txtUserId.Text = config.UserId;
                        txtAppId.Text = config.AppId;
                        txtAppSecret.Text = config.AppSecret;
                        txtToken.Text = config.Token;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载配置失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var userConfig = new UserConfiguration
            {
                UserId = txtUserId.Text.Trim(),
                AppId = txtAppId.Text.Trim(),
                AppSecret = txtAppSecret.Text.Trim(),
                Token = txtToken.Text.Trim()
            };

            try
            {
                using (var client = new HttpClient())
                {
                    var jsonContent = new StringContent(JsonConvert.SerializeObject(userConfig), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://your-api-gateway-url/api/userconfig", jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"保存失败: {response.ReasonPhrase}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}