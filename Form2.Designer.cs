namespace VKTargetingProject
{
    partial class Form2
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
            this.buttonSearch = new MaterialSkin.Controls.MaterialButton();
            this.queryTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loadTwentyNextMessages = new System.Windows.Forms.Label();
            this.loadTwentyPreviousMessages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSearch.Depth = 0;
            this.buttonSearch.HighEmphasis = true;
            this.buttonSearch.Icon = null;
            this.buttonSearch.Location = new System.Drawing.Point(463, 75);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSearch.Size = new System.Drawing.Size(72, 36);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "поиск";
            this.buttonSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSearch.UseAccentColor = false;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.AnimateReadOnly = false;
            this.queryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryTextBox.Depth = 0;
            this.queryTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.queryTextBox.LeadingIcon = null;
            this.queryTextBox.Location = new System.Drawing.Point(6, 70);
            this.queryTextBox.MaxLength = 50;
            this.queryTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.queryTextBox.Multiline = false;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(327, 50);
            this.queryTextBox.TabIndex = 1;
            this.queryTextBox.Text = "";
            this.queryTextBox.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Message,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(6, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(536, 428);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.HeaderText = "Сообщение";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 330;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(356, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Без бесед";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loadTwentyNextMessages
            // 
            this.loadTwentyNextMessages.AutoSize = true;
            this.loadTwentyNextMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.loadTwentyNextMessages.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadTwentyNextMessages.Location = new System.Drawing.Point(422, 557);
            this.loadTwentyNextMessages.Name = "loadTwentyNextMessages";
            this.loadTwentyNextMessages.Size = new System.Drawing.Size(147, 18);
            this.loadTwentyNextMessages.TabIndex = 4;
            this.loadTwentyNextMessages.Text = "Следующие 20 >>";
            this.loadTwentyNextMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.loadTwentyNextMessages.Click += new System.EventHandler(this.loadTwentyNextMessages_Click);
            // 
            // loadTwentyPreviousMessages
            // 
            this.loadTwentyPreviousMessages.AutoSize = true;
            this.loadTwentyPreviousMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadTwentyPreviousMessages.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadTwentyPreviousMessages.Location = new System.Drawing.Point(6, 557);
            this.loadTwentyPreviousMessages.Name = "loadTwentyPreviousMessages";
            this.loadTwentyPreviousMessages.Size = new System.Drawing.Size(156, 18);
            this.loadTwentyPreviousMessages.TabIndex = 5;
            this.loadTwentyPreviousMessages.Text = "<< Предыдущие 20";
            this.loadTwentyPreviousMessages.Click += new System.EventHandler(this.loadTwentyPreviousMessages_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 591);
            this.Controls.Add(this.loadTwentyPreviousMessages);
            this.Controls.Add(this.loadTwentyNextMessages);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.buttonSearch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 591);
            this.MinimumSize = new System.Drawing.Size(548, 591);
            this.Name.Name = "Form2";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonSearch;
        private MaterialSkin.Controls.MaterialTextBox queryTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label loadTwentyNextMessages;
        private System.Windows.Forms.Label loadTwentyPreviousMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}