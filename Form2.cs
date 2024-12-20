using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet;
using System.Security.Cryptography;
using System.Security.Principal;

namespace VKTargetingProject
{
    public partial class Form2 : MaterialForm
    {
        public string Token { get; set; }
        public uint Offset = 0;

        public Form2(string token)
        {
            InitializeComponent();

            // Импорт библиотеки Material Design.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            Token = token;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Offset = 0;

            SearchMessages();
        }

        public void SearchMessages()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                var api = new VkApi();

                // Авторизация.
                api.Authorize(new ApiAuthParams { AccessToken = this.Token });

                var paramsForSearch = new MessagesSearchParams()
                {
                    Query = queryTextBox.Text,
                    PreviewLength = 20,
                    Offset = this.Offset,
                    Count = 20,
                };

                var messages = api.Messages.Search(paramsForSearch);

                // ID "хоста"
                var hostId = api.Users.Get(new List<long> { }).FirstOrDefault().Id;

                foreach (var message in messages.Items)
                {
                    var checkName = new List<long>();
                    checkName.Add(message.PeerId.Value);

                    // Пробуем взять имя из ID беседы. Так мы, как раз, узнаем, личная это переписка или беседа. Если count = 0 => беседа.
                    var userFromMessage = api.Users.Get(checkName);

                    if (userFromMessage.Count() == 0)
                    {
                        if (!checkBox1.Checked)
                        {
                            var checkGroupMesssageFromName = new List<long>();
                            checkGroupMesssageFromName.Add(message.FromId.Value);
                            var userFromMessageInGroup = api.Users.Get(checkGroupMesssageFromName);

                            dataGridView1.Rows.Add($"(БЕСЕДА) {userFromMessageInGroup.First().FirstName} {userFromMessageInGroup.First().LastName}", message.Text, message.Date.ToString());
                        }
                    }  
                    else
                    {
                        dataGridView1.Rows.Add($"{userFromMessage.First().FirstName} {userFromMessage.First().LastName}", message.Text, message.Date.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок авторизации
                Console.WriteLine($"Ошибка авторизации: {ex.Message}");
            }
        }

        private void loadTwentyNextMessages_Click(object sender, EventArgs e)
        {
            this.Offset += 20;

            SearchMessages();
        }

        private void loadTwentyPreviousMessages_Click(object sender, EventArgs e)
        {
            if (this.Offset > 0)
            {
                this.Offset -= 20;
            }

            SearchMessages();
        }
    }
}
