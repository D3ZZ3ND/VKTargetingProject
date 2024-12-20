namespace VKTargetingProject
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelValidationAccountsTwoFA = new System.Windows.Forms.Label();
            this.labelValidationAccountsFemale = new System.Windows.Forms.Label();
            this.labelValidationAccountsMale = new System.Windows.Forms.Label();
            this.labelValidationAccountsTwoFAText = new System.Windows.Forms.Label();
            this.labelValidationAccountsFemaleText = new System.Windows.Forms.Label();
            this.labelValidationAccountsMaleText = new System.Windows.Forms.Label();
            this.buttonValidationCheck = new MaterialSkin.Controls.MaterialButton();
            this.buttonValidationLoad = new MaterialSkin.Controls.MaterialButton();
            this.labelValidationWarnings = new System.Windows.Forms.Label();
            this.labelAccountsInactive = new System.Windows.Forms.Label();
            this.labelValidationAccountsInactiveText = new System.Windows.Forms.Label();
            this.labelAccountsActive = new System.Windows.Forms.Label();
            this.labelValidationAccountsActiveText = new System.Windows.Forms.Label();
            this.labelValidationFilesLoaded = new System.Windows.Forms.Label();
            this.labelValidationFilesLoadedText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.checkBoxExportPhone = new System.Windows.Forms.CheckBox();
            this.buttonExportSave = new MaterialSkin.Controls.MaterialButton();
            this.checkBoxExportIsFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxExportIsMale = new System.Windows.Forms.CheckBox();
            this.labelExportGenderText = new System.Windows.Forms.Label();
            this.labelExportValidationError = new System.Windows.Forms.Label();
            this.labelExportFileNameSaveText = new System.Windows.Forms.Label();
            this.textBoxExportFileName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCheckId = new System.Windows.Forms.Label();
            this.labelCheckIdText = new System.Windows.Forms.Label();
            this.pictureBoxCheckPhoto = new System.Windows.Forms.PictureBox();
            this.labelCheckHasPhone = new System.Windows.Forms.Label();
            this.labelCheckHasPhoneText = new System.Windows.Forms.Label();
            this.labelCheckCountry = new System.Windows.Forms.Label();
            this.labelCheckBirthDate = new System.Windows.Forms.Label();
            this.labelCheckGender = new System.Windows.Forms.Label();
            this.labelCheckName = new System.Windows.Forms.Label();
            this.labelCheckCountryText = new System.Windows.Forms.Label();
            this.labelCheckBirthDateText = new System.Windows.Forms.Label();
            this.labelCheckGenderText = new System.Windows.Forms.Label();
            this.labelCheckNameText = new System.Windows.Forms.Label();
            this.labelCheckInfoText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonMessagesView = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValidationAccountsTwoFA);
            this.groupBox1.Controls.Add(this.labelValidationAccountsFemale);
            this.groupBox1.Controls.Add(this.labelValidationAccountsMale);
            this.groupBox1.Controls.Add(this.labelValidationAccountsTwoFAText);
            this.groupBox1.Controls.Add(this.labelValidationAccountsFemaleText);
            this.groupBox1.Controls.Add(this.labelValidationAccountsMaleText);
            this.groupBox1.Controls.Add(this.buttonValidationCheck);
            this.groupBox1.Controls.Add(this.buttonValidationLoad);
            this.groupBox1.Controls.Add(this.labelValidationWarnings);
            this.groupBox1.Controls.Add(this.labelAccountsInactive);
            this.groupBox1.Controls.Add(this.labelValidationAccountsInactiveText);
            this.groupBox1.Controls.Add(this.labelAccountsActive);
            this.groupBox1.Controls.Add(this.labelValidationAccountsActiveText);
            this.groupBox1.Controls.Add(this.labelValidationFilesLoaded);
            this.groupBox1.Controls.Add(this.labelValidationFilesLoadedText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Валидация аккаунтов";
            // 
            // labelValidationAccountsTwoFA
            // 
            this.labelValidationAccountsTwoFA.AutoSize = true;
            this.labelValidationAccountsTwoFA.Location = new System.Drawing.Point(188, 216);
            this.labelValidationAccountsTwoFA.Name = "labelValidationAccountsTwoFA";
            this.labelValidationAccountsTwoFA.Size = new System.Drawing.Size(13, 13);
            this.labelValidationAccountsTwoFA.TabIndex = 15;
            this.labelValidationAccountsTwoFA.Text = "0";
            // 
            // labelValidationAccountsFemale
            // 
            this.labelValidationAccountsFemale.AutoSize = true;
            this.labelValidationAccountsFemale.Location = new System.Drawing.Point(188, 201);
            this.labelValidationAccountsFemale.Name = "labelValidationAccountsFemale";
            this.labelValidationAccountsFemale.Size = new System.Drawing.Size(13, 13);
            this.labelValidationAccountsFemale.TabIndex = 14;
            this.labelValidationAccountsFemale.Text = "0";
            // 
            // labelValidationAccountsMale
            // 
            this.labelValidationAccountsMale.AutoSize = true;
            this.labelValidationAccountsMale.Location = new System.Drawing.Point(188, 185);
            this.labelValidationAccountsMale.Name = "labelValidationAccountsMale";
            this.labelValidationAccountsMale.Size = new System.Drawing.Size(13, 13);
            this.labelValidationAccountsMale.TabIndex = 13;
            this.labelValidationAccountsMale.Text = "0";
            // 
            // labelValidationAccountsTwoFAText
            // 
            this.labelValidationAccountsTwoFAText.AutoSize = true;
            this.labelValidationAccountsTwoFAText.Location = new System.Drawing.Point(6, 216);
            this.labelValidationAccountsTwoFAText.Name = "labelValidationAccountsTwoFAText";
            this.labelValidationAccountsTwoFAText.Size = new System.Drawing.Size(134, 13);
            this.labelValidationAccountsTwoFAText.TabIndex = 12;
            this.labelValidationAccountsTwoFAText.Text = "С привязкой к телефону:";
            // 
            // labelValidationAccountsFemaleText
            // 
            this.labelValidationAccountsFemaleText.AutoSize = true;
            this.labelValidationAccountsFemaleText.Location = new System.Drawing.Point(6, 201);
            this.labelValidationAccountsFemaleText.Name = "labelValidationAccountsFemaleText";
            this.labelValidationAccountsFemaleText.Size = new System.Drawing.Size(56, 13);
            this.labelValidationAccountsFemaleText.TabIndex = 11;
            this.labelValidationAccountsFemaleText.Text = "Женских:";
            // 
            // labelValidationAccountsMaleText
            // 
            this.labelValidationAccountsMaleText.AutoSize = true;
            this.labelValidationAccountsMaleText.Location = new System.Drawing.Point(6, 185);
            this.labelValidationAccountsMaleText.Name = "labelValidationAccountsMaleText";
            this.labelValidationAccountsMaleText.Size = new System.Drawing.Size(55, 13);
            this.labelValidationAccountsMaleText.TabIndex = 10;
            this.labelValidationAccountsMaleText.Text = "Мужских:";
            // 
            // buttonValidationCheck
            // 
            this.buttonValidationCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonValidationCheck.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonValidationCheck.Depth = 0;
            this.buttonValidationCheck.HighEmphasis = true;
            this.buttonValidationCheck.Icon = null;
            this.buttonValidationCheck.Location = new System.Drawing.Point(79, 90);
            this.buttonValidationCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonValidationCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonValidationCheck.Name = "buttonValidationCheck";
            this.buttonValidationCheck.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonValidationCheck.Size = new System.Drawing.Size(98, 36);
            this.buttonValidationCheck.TabIndex = 9;
            this.buttonValidationCheck.Text = "Проверка";
            this.buttonValidationCheck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonValidationCheck.UseAccentColor = false;
            this.buttonValidationCheck.UseVisualStyleBackColor = true;
            this.buttonValidationCheck.Click += new System.EventHandler(this.buttonValidationCheck_Click);
            // 
            // buttonValidationLoad
            // 
            this.buttonValidationLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonValidationLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonValidationLoad.Depth = 0;
            this.buttonValidationLoad.HighEmphasis = true;
            this.buttonValidationLoad.Icon = null;
            this.buttonValidationLoad.Location = new System.Drawing.Point(77, 21);
            this.buttonValidationLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonValidationLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonValidationLoad.Name = "buttonValidationLoad";
            this.buttonValidationLoad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonValidationLoad.Size = new System.Drawing.Size(104, 36);
            this.buttonValidationLoad.TabIndex = 8;
            this.buttonValidationLoad.Text = "Загрузить";
            this.buttonValidationLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonValidationLoad.UseAccentColor = false;
            this.buttonValidationLoad.UseVisualStyleBackColor = true;
            this.buttonValidationLoad.Click += new System.EventHandler(this.buttonValidationLoad_Click);
            // 
            // labelValidationWarnings
            // 
            this.labelValidationWarnings.AutoSize = true;
            this.labelValidationWarnings.ForeColor = System.Drawing.Color.Red;
            this.labelValidationWarnings.Location = new System.Drawing.Point(6, 244);
            this.labelValidationWarnings.Name = "labelValidationWarnings";
            this.labelValidationWarnings.Size = new System.Drawing.Size(0, 13);
            this.labelValidationWarnings.TabIndex = 7;
            // 
            // labelAccountsInactive
            // 
            this.labelAccountsInactive.AutoSize = true;
            this.labelAccountsInactive.Location = new System.Drawing.Point(188, 157);
            this.labelAccountsInactive.Name = "labelAccountsInactive";
            this.labelAccountsInactive.Size = new System.Drawing.Size(13, 13);
            this.labelAccountsInactive.TabIndex = 7;
            this.labelAccountsInactive.Text = "0";
            // 
            // labelValidationAccountsInactiveText
            // 
            this.labelValidationAccountsInactiveText.AutoSize = true;
            this.labelValidationAccountsInactiveText.Location = new System.Drawing.Point(6, 157);
            this.labelValidationAccountsInactiveText.Name = "labelValidationAccountsInactiveText";
            this.labelValidationAccountsInactiveText.Size = new System.Drawing.Size(122, 13);
            this.labelValidationAccountsInactiveText.TabIndex = 6;
            this.labelValidationAccountsInactiveText.Text = "Не рабочих аккаунтов:";
            // 
            // labelAccountsActive
            // 
            this.labelAccountsActive.AutoSize = true;
            this.labelAccountsActive.Location = new System.Drawing.Point(188, 141);
            this.labelAccountsActive.Name = "labelAccountsActive";
            this.labelAccountsActive.Size = new System.Drawing.Size(13, 13);
            this.labelAccountsActive.TabIndex = 5;
            this.labelAccountsActive.Text = "0";
            // 
            // labelValidationAccountsActiveText
            // 
            this.labelValidationAccountsActiveText.AutoSize = true;
            this.labelValidationAccountsActiveText.Location = new System.Drawing.Point(6, 141);
            this.labelValidationAccountsActiveText.Name = "labelValidationAccountsActiveText";
            this.labelValidationAccountsActiveText.Size = new System.Drawing.Size(117, 13);
            this.labelValidationAccountsActiveText.TabIndex = 4;
            this.labelValidationAccountsActiveText.Text = "Активных  аккаунтов:";
            // 
            // labelValidationFilesLoaded
            // 
            this.labelValidationFilesLoaded.AutoSize = true;
            this.labelValidationFilesLoaded.Location = new System.Drawing.Point(188, 67);
            this.labelValidationFilesLoaded.Name = "labelValidationFilesLoaded";
            this.labelValidationFilesLoaded.Size = new System.Drawing.Size(13, 13);
            this.labelValidationFilesLoaded.TabIndex = 3;
            this.labelValidationFilesLoaded.Text = "0";
            // 
            // labelValidationFilesLoadedText
            // 
            this.labelValidationFilesLoadedText.AutoSize = true;
            this.labelValidationFilesLoadedText.Location = new System.Drawing.Point(6, 67);
            this.labelValidationFilesLoadedText.Name = "labelValidationFilesLoadedText";
            this.labelValidationFilesLoadedText.Size = new System.Drawing.Size(106, 13);
            this.labelValidationFilesLoadedText.TabIndex = 2;
            this.labelValidationFilesLoadedText.Text = "Загружено файлов:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCountry);
            this.groupBox2.Controls.Add(this.checkBoxExportPhone);
            this.groupBox2.Controls.Add(this.buttonExportSave);
            this.groupBox2.Controls.Add(this.checkBoxExportIsFemale);
            this.groupBox2.Controls.Add(this.checkBoxExportIsMale);
            this.groupBox2.Controls.Add(this.labelExportGenderText);
            this.groupBox2.Controls.Add(this.labelExportValidationError);
            this.groupBox2.Controls.Add(this.labelExportFileNameSaveText);
            this.groupBox2.Controls.Add(this.textBoxExportFileName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(276, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 265);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Экспорт";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(69, 149);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 17;
            // 
            // checkBoxExportPhone
            // 
            this.checkBoxExportPhone.AutoSize = true;
            this.checkBoxExportPhone.Location = new System.Drawing.Point(52, 116);
            this.checkBoxExportPhone.Name = "checkBoxExportPhone";
            this.checkBoxExportPhone.Size = new System.Drawing.Size(150, 17);
            this.checkBoxExportPhone.TabIndex = 16;
            this.checkBoxExportPhone.Text = "С привязкой к телефону";
            this.checkBoxExportPhone.UseVisualStyleBackColor = true;
            // 
            // buttonExportSave
            // 
            this.buttonExportSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExportSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonExportSave.Depth = 0;
            this.buttonExportSave.HighEmphasis = true;
            this.buttonExportSave.Icon = null;
            this.buttonExportSave.Location = new System.Drawing.Point(81, 188);
            this.buttonExportSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonExportSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonExportSave.Name = "buttonExportSave";
            this.buttonExportSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonExportSave.Size = new System.Drawing.Size(89, 36);
            this.buttonExportSave.TabIndex = 7;
            this.buttonExportSave.Text = "Экспорт";
            this.buttonExportSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonExportSave.UseAccentColor = false;
            this.buttonExportSave.UseVisualStyleBackColor = true;
            this.buttonExportSave.Click += new System.EventHandler(this.buttonExportSave_Click);
            // 
            // checkBoxExportIsFemale
            // 
            this.checkBoxExportIsFemale.AutoSize = true;
            this.checkBoxExportIsFemale.Location = new System.Drawing.Point(137, 90);
            this.checkBoxExportIsFemale.Name = "checkBoxExportIsFemale";
            this.checkBoxExportIsFemale.Size = new System.Drawing.Size(49, 17);
            this.checkBoxExportIsFemale.TabIndex = 6;
            this.checkBoxExportIsFemale.Text = "жен.";
            this.checkBoxExportIsFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxExportIsMale
            // 
            this.checkBoxExportIsMale.AutoSize = true;
            this.checkBoxExportIsMale.Location = new System.Drawing.Point(81, 90);
            this.checkBoxExportIsMale.Name = "checkBoxExportIsMale";
            this.checkBoxExportIsMale.Size = new System.Drawing.Size(50, 17);
            this.checkBoxExportIsMale.TabIndex = 1;
            this.checkBoxExportIsMale.Text = "муж.";
            this.checkBoxExportIsMale.UseVisualStyleBackColor = true;
            // 
            // labelExportGenderText
            // 
            this.labelExportGenderText.AutoSize = true;
            this.labelExportGenderText.Location = new System.Drawing.Point(119, 74);
            this.labelExportGenderText.Name = "labelExportGenderText";
            this.labelExportGenderText.Size = new System.Drawing.Size(30, 13);
            this.labelExportGenderText.TabIndex = 5;
            this.labelExportGenderText.Text = "Пол:";
            // 
            // labelExportValidationError
            // 
            this.labelExportValidationError.AutoSize = true;
            this.labelExportValidationError.ForeColor = System.Drawing.Color.Red;
            this.labelExportValidationError.Location = new System.Drawing.Point(6, 244);
            this.labelExportValidationError.Name = "labelExportValidationError";
            this.labelExportValidationError.Size = new System.Drawing.Size(0, 13);
            this.labelExportValidationError.TabIndex = 4;
            // 
            // labelExportFileNameSaveText
            // 
            this.labelExportFileNameSaveText.AutoSize = true;
            this.labelExportFileNameSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExportFileNameSaveText.Location = new System.Drawing.Point(83, 20);
            this.labelExportFileNameSaveText.Name = "labelExportFileNameSaveText";
            this.labelExportFileNameSaveText.Size = new System.Drawing.Size(95, 13);
            this.labelExportFileNameSaveText.TabIndex = 3;
            this.labelExportFileNameSaveText.Text = "Название файла:";
            // 
            // textBoxExportFileName
            // 
            this.textBoxExportFileName.Location = new System.Drawing.Point(52, 38);
            this.textBoxExportFileName.Name = "textBoxExportFileName";
            this.textBoxExportFileName.Size = new System.Drawing.Size(174, 20);
            this.textBoxExportFileName.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMessagesView);
            this.groupBox3.Controls.Add(this.labelCheckId);
            this.groupBox3.Controls.Add(this.labelCheckIdText);
            this.groupBox3.Controls.Add(this.pictureBoxCheckPhoto);
            this.groupBox3.Controls.Add(this.labelCheckHasPhone);
            this.groupBox3.Controls.Add(this.labelCheckHasPhoneText);
            this.groupBox3.Controls.Add(this.labelCheckCountry);
            this.groupBox3.Controls.Add(this.labelCheckBirthDate);
            this.groupBox3.Controls.Add(this.labelCheckGender);
            this.groupBox3.Controls.Add(this.labelCheckName);
            this.groupBox3.Controls.Add(this.labelCheckCountryText);
            this.groupBox3.Controls.Add(this.labelCheckBirthDateText);
            this.groupBox3.Controls.Add(this.labelCheckGenderText);
            this.groupBox3.Controls.Add(this.labelCheckNameText);
            this.groupBox3.Controls.Add(this.labelCheckInfoText);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 238);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка аккаунтов";
            // 
            // labelCheckId
            // 
            this.labelCheckId.AutoSize = true;
            this.labelCheckId.Location = new System.Drawing.Point(395, 136);
            this.labelCheckId.Name = "labelCheckId";
            this.labelCheckId.Size = new System.Drawing.Size(10, 13);
            this.labelCheckId.TabIndex = 13;
            this.labelCheckId.Text = "-";
            // 
            // labelCheckIdText
            // 
            this.labelCheckIdText.AutoSize = true;
            this.labelCheckIdText.Location = new System.Drawing.Point(269, 136);
            this.labelCheckIdText.Name = "labelCheckIdText";
            this.labelCheckIdText.Size = new System.Drawing.Size(19, 13);
            this.labelCheckIdText.TabIndex = 12;
            this.labelCheckIdText.Text = "Id:";
            // 
            // pictureBoxCheckPhoto
            // 
            this.pictureBoxCheckPhoto.Location = new System.Drawing.Point(272, 165);
            this.pictureBoxCheckPhoto.Name = "pictureBoxCheckPhoto";
            this.pictureBoxCheckPhoto.Size = new System.Drawing.Size(67, 67);
            this.pictureBoxCheckPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCheckPhoto.TabIndex = 4;
            this.pictureBoxCheckPhoto.TabStop = false;
            // 
            // labelCheckHasPhone
            // 
            this.labelCheckHasPhone.AutoSize = true;
            this.labelCheckHasPhone.Location = new System.Drawing.Point(395, 116);
            this.labelCheckHasPhone.Name = "labelCheckHasPhone";
            this.labelCheckHasPhone.Size = new System.Drawing.Size(10, 13);
            this.labelCheckHasPhone.TabIndex = 11;
            this.labelCheckHasPhone.Text = "-";
            // 
            // labelCheckHasPhoneText
            // 
            this.labelCheckHasPhoneText.AutoSize = true;
            this.labelCheckHasPhoneText.Location = new System.Drawing.Point(269, 116);
            this.labelCheckHasPhoneText.Name = "labelCheckHasPhoneText";
            this.labelCheckHasPhoneText.Size = new System.Drawing.Size(55, 13);
            this.labelCheckHasPhoneText.TabIndex = 10;
            this.labelCheckHasPhoneText.Text = "Телефон:";
            // 
            // labelCheckCountry
            // 
            this.labelCheckCountry.AutoSize = true;
            this.labelCheckCountry.Location = new System.Drawing.Point(395, 96);
            this.labelCheckCountry.Name = "labelCheckCountry";
            this.labelCheckCountry.Size = new System.Drawing.Size(10, 13);
            this.labelCheckCountry.TabIndex = 9;
            this.labelCheckCountry.Text = "-";
            // 
            // labelCheckBirthDate
            // 
            this.labelCheckBirthDate.AutoSize = true;
            this.labelCheckBirthDate.Location = new System.Drawing.Point(395, 76);
            this.labelCheckBirthDate.Name = "labelCheckBirthDate";
            this.labelCheckBirthDate.Size = new System.Drawing.Size(10, 13);
            this.labelCheckBirthDate.TabIndex = 8;
            this.labelCheckBirthDate.Text = "-";
            // 
            // labelCheckGender
            // 
            this.labelCheckGender.AutoSize = true;
            this.labelCheckGender.Location = new System.Drawing.Point(395, 57);
            this.labelCheckGender.Name = "labelCheckGender";
            this.labelCheckGender.Size = new System.Drawing.Size(10, 13);
            this.labelCheckGender.TabIndex = 7;
            this.labelCheckGender.Text = "-";
            // 
            // labelCheckName
            // 
            this.labelCheckName.AutoSize = true;
            this.labelCheckName.Location = new System.Drawing.Point(395, 39);
            this.labelCheckName.Name = "labelCheckName";
            this.labelCheckName.Size = new System.Drawing.Size(10, 13);
            this.labelCheckName.TabIndex = 6;
            this.labelCheckName.Text = "-";
            // 
            // labelCheckCountryText
            // 
            this.labelCheckCountryText.AutoSize = true;
            this.labelCheckCountryText.Location = new System.Drawing.Point(269, 96);
            this.labelCheckCountryText.Name = "labelCheckCountryText";
            this.labelCheckCountryText.Size = new System.Drawing.Size(46, 13);
            this.labelCheckCountryText.TabIndex = 5;
            this.labelCheckCountryText.Text = "Страна:";
            // 
            // labelCheckBirthDateText
            // 
            this.labelCheckBirthDateText.AutoSize = true;
            this.labelCheckBirthDateText.Location = new System.Drawing.Point(269, 76);
            this.labelCheckBirthDateText.Name = "labelCheckBirthDateText";
            this.labelCheckBirthDateText.Size = new System.Drawing.Size(89, 13);
            this.labelCheckBirthDateText.TabIndex = 4;
            this.labelCheckBirthDateText.Text = "Дата рождения:";
            // 
            // labelCheckGenderText
            // 
            this.labelCheckGenderText.AutoSize = true;
            this.labelCheckGenderText.Location = new System.Drawing.Point(269, 57);
            this.labelCheckGenderText.Name = "labelCheckGenderText";
            this.labelCheckGenderText.Size = new System.Drawing.Size(30, 13);
            this.labelCheckGenderText.TabIndex = 3;
            this.labelCheckGenderText.Text = "Пол:";
            // 
            // labelCheckNameText
            // 
            this.labelCheckNameText.AutoSize = true;
            this.labelCheckNameText.Location = new System.Drawing.Point(269, 39);
            this.labelCheckNameText.Name = "labelCheckNameText";
            this.labelCheckNameText.Size = new System.Drawing.Size(32, 13);
            this.labelCheckNameText.TabIndex = 2;
            this.labelCheckNameText.Text = "Имя:";
            // 
            // labelCheckInfoText
            // 
            this.labelCheckInfoText.AutoSize = true;
            this.labelCheckInfoText.Location = new System.Drawing.Point(357, 14);
            this.labelCheckInfoText.Name = "labelCheckInfoText";
            this.labelCheckInfoText.Size = new System.Drawing.Size(76, 13);
            this.labelCheckInfoText.TabIndex = 1;
            this.labelCheckInfoText.Text = "Информация:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Token});
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(261, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonMessagesView
            // 
            this.buttonMessagesView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMessagesView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMessagesView.Depth = 0;
            this.buttonMessagesView.HighEmphasis = true;
            this.buttonMessagesView.Icon = null;
            this.buttonMessagesView.Location = new System.Drawing.Point(437, 196);
            this.buttonMessagesView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMessagesView.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMessagesView.Name = "buttonMessagesView";
            this.buttonMessagesView.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMessagesView.Size = new System.Drawing.Size(92, 36);
            this.buttonMessagesView.TabIndex = 18;
            this.buttonMessagesView.Text = "Диалоги";
            this.buttonMessagesView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMessagesView.UseAccentColor = false;
            this.buttonMessagesView.UseVisualStyleBackColor = true;
            this.buttonMessagesView.Visible = false;
            this.buttonMessagesView.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 591);
            this.MinimumSize = new System.Drawing.Size(548, 591);
            this.Name = "Form1";
            this.Text = "VKTargetingProject";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValidationFilesLoadedText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelValidationFilesLoaded;
        private System.Windows.Forms.Label labelAccountsInactive;
        private System.Windows.Forms.Label labelValidationAccountsInactiveText;
        private System.Windows.Forms.Label labelAccountsActive;
        private System.Windows.Forms.Label labelValidationAccountsActiveText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Label labelExportFileNameSaveText;
        private System.Windows.Forms.TextBox textBoxExportFileName;
        private System.Windows.Forms.Label labelExportValidationError;
        private System.Windows.Forms.CheckBox checkBoxExportIsFemale;
        private System.Windows.Forms.CheckBox checkBoxExportIsMale;
        private System.Windows.Forms.Label labelExportGenderText;
        private System.Windows.Forms.Label labelCheckInfoText;
        private System.Windows.Forms.Label labelCheckCountry;
        private System.Windows.Forms.Label labelCheckBirthDate;
        private System.Windows.Forms.Label labelCheckGender;
        private System.Windows.Forms.Label labelCheckName;
        private System.Windows.Forms.Label labelCheckCountryText;
        private System.Windows.Forms.Label labelCheckBirthDateText;
        private System.Windows.Forms.Label labelCheckGenderText;
        private System.Windows.Forms.Label labelCheckNameText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelCheckHasPhone;
        private System.Windows.Forms.Label labelCheckHasPhoneText;
        private System.Windows.Forms.PictureBox pictureBoxCheckPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.Label labelValidationWarnings;
        private MaterialSkin.Controls.MaterialButton buttonExportSave;
        private MaterialSkin.Controls.MaterialButton buttonValidationLoad;
        private MaterialSkin.Controls.MaterialButton buttonValidationCheck;
        private System.Windows.Forms.Label labelValidationAccountsTwoFAText;
        private System.Windows.Forms.Label labelValidationAccountsFemaleText;
        private System.Windows.Forms.Label labelValidationAccountsMaleText;
        private System.Windows.Forms.Label labelValidationAccountsTwoFA;
        private System.Windows.Forms.Label labelValidationAccountsFemale;
        private System.Windows.Forms.Label labelValidationAccountsMale;
        private System.Windows.Forms.CheckBox checkBoxExportPhone;
        private System.Windows.Forms.Label labelCheckId;
        private System.Windows.Forms.Label labelCheckIdText;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private MaterialSkin.Controls.MaterialButton buttonMessagesView;
    }
}

