namespace MacrosCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListOfMacroses = new System.Windows.Forms.CheckedListBox();
            this.CreateMacrosButton = new System.Windows.Forms.Button();
            this.StartRecordingButton = new System.Windows.Forms.Button();
            this.StopRecordingButton = new System.Windows.Forms.Button();
            this.RepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.RepeatTimeTextBox = new System.Windows.Forms.TextBox();
            this.RunMacrosesButton = new System.Windows.Forms.Button();
            this.StopMacrosesButton = new System.Windows.Forms.Button();
            this.MacrosNameLabel = new System.Windows.Forms.Label();
            this.MacrosNameTextBox = new System.Windows.Forms.TextBox();
            this.SetActivationKeyButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfMacroses
            // 
            this.ListOfMacroses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListOfMacroses.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListOfMacroses.FormattingEnabled = true;
            this.ListOfMacroses.Location = new System.Drawing.Point(13, 13);
            this.ListOfMacroses.Name = "ListOfMacroses";
            this.ListOfMacroses.Size = new System.Drawing.Size(120, 229);
            this.ListOfMacroses.TabIndex = 0;
            // 
            // CreateMacrosButton
            // 
            this.CreateMacrosButton.BackColor = System.Drawing.SystemColors.Info;
            this.CreateMacrosButton.Location = new System.Drawing.Point(140, 167);
            this.CreateMacrosButton.Name = "CreateMacrosButton";
            this.CreateMacrosButton.Size = new System.Drawing.Size(150, 23);
            this.CreateMacrosButton.TabIndex = 1;
            this.CreateMacrosButton.Text = "Создать макрос";
            this.CreateMacrosButton.UseVisualStyleBackColor = false;
            this.CreateMacrosButton.Click += new System.EventHandler(this.CreateMacrosButton_Click);
            // 
            // StartRecordingButton
            // 
            this.StartRecordingButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartRecordingButton.Location = new System.Drawing.Point(140, 75);
            this.StartRecordingButton.Name = "StartRecordingButton";
            this.StartRecordingButton.Size = new System.Drawing.Size(75, 36);
            this.StartRecordingButton.TabIndex = 2;
            this.StartRecordingButton.Text = "Начать запись";
            this.StartRecordingButton.UseVisualStyleBackColor = false;
            this.StartRecordingButton.Click += new System.EventHandler(this.StartRecordingButton_Click);
            // 
            // StopRecordingButton
            // 
            this.StopRecordingButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StopRecordingButton.Location = new System.Drawing.Point(215, 75);
            this.StopRecordingButton.Name = "StopRecordingButton";
            this.StopRecordingButton.Size = new System.Drawing.Size(75, 36);
            this.StopRecordingButton.TabIndex = 3;
            this.StopRecordingButton.Text = "Остановить запись";
            this.StopRecordingButton.UseVisualStyleBackColor = false;
            this.StopRecordingButton.Click += new System.EventHandler(this.StopRecordingButton_Click);
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.Location = new System.Drawing.Point(139, 116);
            this.RepeatCheckBox.Name = "RepeatCheckBox";
            this.RepeatCheckBox.Size = new System.Drawing.Size(116, 17);
            this.RepeatCheckBox.TabIndex = 4;
            this.RepeatCheckBox.Text = "Повтор раз в(мс):";
            this.RepeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // RepeatTimeTextBox
            // 
            this.RepeatTimeTextBox.Location = new System.Drawing.Point(246, 114);
            this.RepeatTimeTextBox.Name = "RepeatTimeTextBox";
            this.RepeatTimeTextBox.Size = new System.Drawing.Size(43, 20);
            this.RepeatTimeTextBox.TabIndex = 5;
            // 
            // RunMacrosesButton
            // 
            this.RunMacrosesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.RunMacrosesButton.Location = new System.Drawing.Point(139, 196);
            this.RunMacrosesButton.Name = "RunMacrosesButton";
            this.RunMacrosesButton.Size = new System.Drawing.Size(151, 23);
            this.RunMacrosesButton.TabIndex = 6;
            this.RunMacrosesButton.Text = "Запустить макросы";
            this.RunMacrosesButton.UseVisualStyleBackColor = false;
            this.RunMacrosesButton.Click += new System.EventHandler(this.RunMacrosesButton_Click);
            // 
            // StopMacrosesButton
            // 
            this.StopMacrosesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.StopMacrosesButton.Location = new System.Drawing.Point(139, 219);
            this.StopMacrosesButton.Name = "StopMacrosesButton";
            this.StopMacrosesButton.Size = new System.Drawing.Size(151, 23);
            this.StopMacrosesButton.TabIndex = 7;
            this.StopMacrosesButton.Text = "Остановить макросы";
            this.StopMacrosesButton.UseVisualStyleBackColor = false;
            this.StopMacrosesButton.Click += new System.EventHandler(this.StopMacrosesButton_Click);
            // 
            // MacrosNameLabel
            // 
            this.MacrosNameLabel.AutoSize = true;
            this.MacrosNameLabel.Location = new System.Drawing.Point(183, 39);
            this.MacrosNameLabel.Name = "MacrosNameLabel";
            this.MacrosNameLabel.Size = new System.Drawing.Size(60, 13);
            this.MacrosNameLabel.TabIndex = 8;
            this.MacrosNameLabel.Text = "Название:";
            // 
            // MacrosNameTextBox
            // 
            this.MacrosNameTextBox.BackColor = System.Drawing.Color.White;
            this.MacrosNameTextBox.Location = new System.Drawing.Point(140, 53);
            this.MacrosNameTextBox.Name = "MacrosNameTextBox";
            this.MacrosNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.MacrosNameTextBox.TabIndex = 9;
            // 
            // SetActivationKeyButton
            // 
            this.SetActivationKeyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetActivationKeyButton.Location = new System.Drawing.Point(140, 131);
            this.SetActivationKeyButton.Name = "SetActivationKeyButton";
            this.SetActivationKeyButton.Size = new System.Drawing.Size(150, 35);
            this.SetActivationKeyButton.TabIndex = 10;
            this.SetActivationKeyButton.Text = "Задать клавишу активации";
            this.SetActivationKeyButton.UseVisualStyleBackColor = false;
            this.SetActivationKeyButton.Click += new System.EventHandler(this.SetActivationKeyButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Макросы";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.BackColor = System.Drawing.Color.Coral;
            this.DeleteSelected.Location = new System.Drawing.Point(139, 10);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(150, 26);
            this.DeleteSelected.TabIndex = 11;
            this.DeleteSelected.Text = "Удалить выделенный";
            this.DeleteSelected.UseVisualStyleBackColor = false;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoButton.Location = new System.Drawing.Point(110, 13);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(22, 23);
            this.InfoButton.TabIndex = 12;
            this.InfoButton.Text = "I";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(294, 252);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.SetActivationKeyButton);
            this.Controls.Add(this.MacrosNameTextBox);
            this.Controls.Add(this.MacrosNameLabel);
            this.Controls.Add(this.StopMacrosesButton);
            this.Controls.Add(this.RunMacrosesButton);
            this.Controls.Add(this.RepeatTimeTextBox);
            this.Controls.Add(this.RepeatCheckBox);
            this.Controls.Add(this.StopRecordingButton);
            this.Controls.Add(this.StartRecordingButton);
            this.Controls.Add(this.CreateMacrosButton);
            this.Controls.Add(this.ListOfMacroses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(310, 290);
            this.MinimumSize = new System.Drawing.Size(310, 290);
            this.Name = "MainForm";
            this.Text = "Макросы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListOfMacroses;
        private System.Windows.Forms.Button CreateMacrosButton;
        private System.Windows.Forms.Button StartRecordingButton;
        private System.Windows.Forms.Button StopRecordingButton;
        private System.Windows.Forms.CheckBox RepeatCheckBox;
        private System.Windows.Forms.TextBox RepeatTimeTextBox;
        private System.Windows.Forms.Button RunMacrosesButton;
        private System.Windows.Forms.Button StopMacrosesButton;
        private System.Windows.Forms.Label MacrosNameLabel;
        private System.Windows.Forms.TextBox MacrosNameTextBox;
        private System.Windows.Forms.Button SetActivationKeyButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button InfoButton;
    }
}

