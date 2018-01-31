namespace GUI
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SignalList = new System.Windows.Forms.ListBox();
            this.SpectrList = new System.Windows.Forms.ListBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.dtLabel = new System.Windows.Forms.Label();
            this.dfLabel = new System.Windows.Forms.Label();
            this.Signai_GroupBox = new System.Windows.Forms.GroupBox();
            this.MainMenu.SuspendLayout();
            this.Signai_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(755, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuSave,
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(103, 22);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(103, 22);
            this.MenuSave.Text = "Save";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(103, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // SignalList
            // 
            this.SignalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignalList.FormattingEnabled = true;
            this.SignalList.Location = new System.Drawing.Point(2, 15);
            this.SignalList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignalList.Name = "SignalList";
            this.SignalList.Size = new System.Drawing.Size(302, 476);
            this.SignalList.TabIndex = 1;
            // 
            // SpectrList
            // 
            this.SpectrList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpectrList.FormattingEnabled = true;
            this.SpectrList.Location = new System.Drawing.Point(469, 25);
            this.SpectrList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpectrList.Name = "SpectrList";
            this.SpectrList.Size = new System.Drawing.Size(278, 472);
            this.SpectrList.TabIndex = 1;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(322, 25);
            this.ComputeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(117, 48);
            this.ComputeButton.TabIndex = 2;
            this.ComputeButton.Text = "Compute Spectr";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // dtLabel
            // 
            this.dtLabel.AutoSize = true;
            this.dtLabel.Location = new System.Drawing.Point(320, 84);
            this.dtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtLabel.Name = "dtLabel";
            this.dtLabel.Size = new System.Drawing.Size(16, 13);
            this.dtLabel.TabIndex = 3;
            this.dtLabel.Text = "dt";
            // 
            // dfLabel
            // 
            this.dfLabel.AutoSize = true;
            this.dfLabel.Location = new System.Drawing.Point(320, 119);
            this.dfLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dfLabel.Name = "dfLabel";
            this.dfLabel.Size = new System.Drawing.Size(16, 13);
            this.dfLabel.TabIndex = 4;
            this.dfLabel.Text = "df";
            // 
            // Signai_GroupBox
            // 
            this.Signai_GroupBox.Controls.Add(this.SignalList);
            this.Signai_GroupBox.Location = new System.Drawing.Point(9, 25);
            this.Signai_GroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Signai_GroupBox.Name = "Signai_GroupBox";
            this.Signai_GroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Signai_GroupBox.Size = new System.Drawing.Size(306, 493);
            this.Signai_GroupBox.TabIndex = 5;
            this.Signai_GroupBox.TabStop = false;
            this.Signai_GroupBox.Text = "Сигнал";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 528);
            this.Controls.Add(this.Signai_GroupBox);
            this.Controls.Add(this.dfLabel);
            this.Controls.Add(this.dtLabel);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.SpectrList);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Главное окно приложения";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Signai_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ListBox SignalList;
        private System.Windows.Forms.ListBox SpectrList;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Label dtLabel;
        private System.Windows.Forms.Label dfLabel;
        private System.Windows.Forms.GroupBox Signai_GroupBox;
    }
}

