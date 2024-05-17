using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet;
using System.IO;
using System.Net;
using VkNet.Enums.SafetyEnums;
using MaterialSkin.Controls;
using MaterialSkin;

namespace VKTargetingProject
{
    public partial class Form1 : MaterialForm
    {
        public List<Account> Accounts = new List<Account>();
        public List<string> FilePaths = new List<string>();

        public int LoadedCount = 0;
        public int ActiveCount = 0;
        public int InactiveCount = 0;
        public int MaleCount = 0;
        public int FemaleCount = 0;
        public int TwoFACount = 0;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            labelExportValidationError.ForeColor = Color.Red;
            labelValidationWarnings.ForeColor = Color.Red;
            buttonValidationCheck.Enabled = false;
            buttonExportSave.Enabled = false;
            buttonExportSave.Enabled = false;
            comboBoxCountry.Items.Add("Любая страна");
        }

        /// <summary>
        /// Загрузка аккаунтов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidationLoad_Click(object sender, EventArgs e)
        {
            try
            {

                buttonValidationCheck.Enabled = false;
                buttonExportSave.Enabled = false;

                comboBoxCountry.Items.Clear();
                comboBoxCountry.Items.Add("Любая страна");


                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    LoadedCount = 0;
                    // Позволяет выбрать несколько файлов.
                    openFileDialog.Multiselect = true;

                    // Фильтр файлов.
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string fileName in openFileDialog.FileNames)
                        {
                            // Добавляем полный путь к файлу в список.
                            FilePaths.Add(fileName);
                            LoadedCount++;
                        }
                    }

                    labelValidationFilesLoaded.Text = LoadedCount.ToString();
                }
                buttonValidationCheck.Enabled = true;
            }
            catch (Exception ex)
            {
                buttonValidationCheck.Enabled = false;
                buttonExportSave.Enabled = false;
                comboBoxCountry.Items.Clear();
                comboBoxCountry.Items.Add("Любая страна");

                labelValidationWarnings.Text = ex.Message;
            }
        }

        /// <summary>
        /// Проверка аккаунтов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidationCheck_Click(object sender, EventArgs e)
        {
            try
            {
                buttonExportSave.Enabled = false;
                comboBoxCountry.Items.Clear();
                comboBoxCountry.Items.Add("Любая страна");

                labelValidationWarnings.ForeColor = Color.Red;
                labelValidationWarnings.Text = "Подождите, идет обработка....";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                ActiveCount = 0;
                InactiveCount = 0;
                MaleCount = 0;
                FemaleCount = 0;
                TwoFACount = 0;
                foreach (string filePath in this.FilePaths)
                {
                    ProcessFile(filePath);
                }

                labelAccountsActive.Text = ActiveCount.ToString();
                labelAccountsInactive.Text = (InactiveCount - ActiveCount).ToString();
                labelValidationAccountsMale.Text = MaleCount.ToString();
                labelValidationAccountsFemale.Text = FemaleCount.ToString();
                labelValidationAccountsTwoFA.Text = TwoFACount.ToString();

                dataGridView1.Rows.Clear();

                foreach (var account in Accounts)
                {
                    dataGridView1.Rows.Add(account.Id, account.FullName, account.Token);
                }

                labelValidationWarnings.ForeColor = Color.Green;

                buttonExportSave.Enabled = true;

                labelValidationWarnings.Text = "Успешно обработано!";
            }
            catch (Exception ex)
            {
                comboBoxCountry.Items.Clear();
                comboBoxCountry.Items.Add("Любая страна");
                buttonExportSave.Enabled = false;
                labelValidationWarnings.Text = $"{ex.Message}";
            }
            ////foreach (Account account in this.Accounts)
            ////{
            ////    txtResults.Text += $"ID: {account.Id}, Имя: {account.FullName}, Пол: {account.Gender}, Дата рождения: {account.BirthDate}, Страна: {account.Country}, Токен: {account.Token}{Environment.NewLine}";
            ////}
        }

        /// <summary>
        /// Экспорт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExportSave_Click(object sender, EventArgs e)
        {
            try
            {
                labelExportValidationError.ForeColor = Color.Red;
                labelExportValidationError.Text = "";


                if (Accounts.Count == 0)
                {
                    labelExportValidationError.Text = "Список аккаунтов пуст!";
                    return;
                }

                // Получаем имя файла из текстового поля
                string fileName = $"{textBoxExportFileName.Text.Trim()}.txt";

                if (string.IsNullOrEmpty(fileName))
                {
                    labelExportValidationError.Text = "Введите имя файла!";
                    return;
                }

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var filteredAccounts = Accounts;

                    // Фильтрация по полу.
                    if (checkBoxExportIsMale.Checked && checkBoxExportIsFemale.Checked)
                    {
                        filteredAccounts = Accounts;
                    }
                    else if (checkBoxExportIsMale.Checked)
                    {
                        filteredAccounts = Accounts.Where(a => a.Gender == "Male").ToList();
                        if (filteredAccounts.Count == 0)
                        {
                            labelExportValidationError.Text = "Не найдено подходящих аккаунтов!";
                            return;
                        }

                    }
                    else if (checkBoxExportIsFemale.Checked)
                    {
                        filteredAccounts = Accounts.Where(a => a.Gender == "Female").ToList();
                        if (filteredAccounts.Count == 0)
                        {
                            labelExportValidationError.Text = "Не найдено подходящих аккаунтов!";
                            return;
                        }
                    }
                    else
                    {
                        filteredAccounts = Accounts;
                    }

                    // Фильтрация по привязке к телефону.
                    if (checkBoxExportPhone.Checked)
                    {
                        filteredAccounts = filteredAccounts.Where(a => a.HasMobile.Value).ToList();
                    }

                    // Фильтрация по стране.
                    if (comboBoxCountry.SelectedItem != null && (string)comboBoxCountry.SelectedItem != "Любая страна")
                    {
                        filteredAccounts = filteredAccounts.Where(a => a.Country == (string)comboBoxCountry.SelectedItem).ToList();
                    }

                    foreach (var account in filteredAccounts)
                    {
                        writer.WriteLine($"{account.Id}|{account.FullName}|{account.Gender}|{account.BirthDate}|{account.Country}|{account.Token}");
                    }
                }
                labelExportValidationError.ForeColor = Color.Green;
                labelExportValidationError.Text = "Список аккаунтов сохранен!";
            }
            catch (Exception ex)
            {
                labelExportValidationError.Text = $"Ошибка при сохранении: {ex.Message}";
            }
        }

        /// <summary>
        /// Выбор ячейки с аккаунтом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var rowIndex = dataGridView1.CurrentCell.RowIndex;
                var columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                if (dataGridView1.CurrentCell != null)
                {
                    var selectedCell = dataGridView1.Rows[rowIndex].Cells[0].Value;

                    var selectedAccount = Accounts.FirstOrDefault(a => a.Id == (long)selectedCell);

                    labelCheckName.Text = $"{selectedAccount.FullName}";
                    labelCheckGender.Text = $"{selectedAccount.Gender}";
                    labelCheckBirthDate.Text = $"{selectedAccount.BirthDate}";
                    labelCheckCountry.Text = $"{selectedAccount.Country}";
                    if (selectedAccount.HasMobile.HasValue && selectedAccount.HasMobile.Value)
                    {
                        labelCheckHasPhone.Text = $"True";
                    }
                    else
                    {
                        labelCheckHasPhone.Text = $"False";
                    }
                    labelCheckId.Text = $"{selectedAccount.Id}";
                    if (selectedAccount.Photo != null)
                    {
                        using (WebClient wc = new WebClient())
                        {
                            pictureBoxCheckPhoto.Image = System.Drawing.Image.FromStream(wc.OpenRead(selectedAccount.Photo));
                        }
                    }
                    else
                    {
                        Bitmap bitmap = new Bitmap(pictureBoxCheckPhoto.Width, pictureBoxCheckPhoto.Height);
                        pictureBoxCheckPhoto.Image = bitmap;
                    }
                }
            }
            catch (Exception ex)
            {
                labelExportValidationError.Text = $"{ex.Message}";
            }
        }

        /// <summary>
        /// Обработка файла, т.е. импорт строк.
        /// </summary>
        /// <param name="filePath"></param>
        private void ProcessFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string token = ExtractToken(line);

                if (!string.IsNullOrEmpty(token))
                {
                    AuthorizeAccount(token);
                }
            }
        }

        /// <summary>
        /// Извлечение токена.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private string ExtractToken(string line)
        {
            string[] parts = line.Split(':', '|');
            InactiveCount++;

            // Токен - последний элемент.
            return parts.LastOrDefault();
        }

        /// <summary>
        /// Авторизация в аккаунт и добавление его в List с аккаунтами.
        /// </summary>
        /// <param name="token"></param>
        private void AuthorizeAccount(string token)
        {
            var api = new VkApi();

            try
            {
                api.Authorize(new ApiAuthParams { AccessToken = token });


                var user = api.Account.GetProfileInfo();
                var currentUserFullInfo = api.Users.Get(new List<long> { }).FirstOrDefault();

                if (user.Country != null)
                {
                    if (!Accounts.Any(a => a.Country == user.Country.Title))
                    {
                        comboBoxCountry.Items.Add($"{user.Country.Title}");
                    }
                }

                var hasPhone = false;

                if (user.Phone != null && user.Phone != "")
                {
                    hasPhone = true;
                }
                if (api.Photo.Get(new PhotoGetParams { AlbumId = PhotoAlbumType.Profile }).Count > 0)
                {
                    var userPhoto = api.Photo.Get(new PhotoGetParams { AlbumId = PhotoAlbumType.Profile })
                        .Last().Sizes
                        .First().Url.AbsoluteUri;
                    Accounts.Add(new Account
                    {
                        Id = currentUserFullInfo.Id,
                        FullName = user.FirstName + " " + user.LastName,
                        Gender = user.Sex.ToString(),
                        BirthDate = user.BirthDate,
                        Country = user.Country?.Title,
                        Token = token,
                        HasMobile = hasPhone,
                        Photo = new Uri(userPhoto)
                    });
                }
                else
                {
                    Accounts.Add(new Account
                    {
                        Id = currentUserFullInfo.Id,
                        FullName = user.FirstName + " " + user.LastName,
                        Gender = user.Sex.ToString(),
                        BirthDate = user.BirthDate,
                        Country = user.Country?.Title,
                        Token = token,
                        HasMobile = hasPhone,
                    });
                }
                if (user.Sex == VkNet.Enums.Sex.Male)
                {
                    MaleCount++;
                }
                else if (user.Sex == VkNet.Enums.Sex.Female)
                {
                    FemaleCount++;
                }
                if (hasPhone)
                {
                    TwoFACount++;
                }

                ActiveCount++;
            }
            catch (Exception ex)
            {
                // Обработка ошибок авторизации
                Console.WriteLine($"Ошибка авторизации: {ex.Message}");
            }
        }
    }
}
