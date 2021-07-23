namespace QuickBuild
{
    partial class QuickBuild
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_workspace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Config = new System.Windows.Forms.ComboBox();
            this.comboBox_Platform = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_addparam = new System.Windows.Forms.TextBox();
            this.checkBox_BuildEditor = new System.Windows.Forms.CheckBox();
            this.checkBox_BuildCookRun = new System.Windows.Forms.CheckBox();
            this.checkBox_Backup = new System.Windows.Forms.CheckBox();
            this.textBox_ShareFolderName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox_OpenEditor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IterateBuild_Click);
            // 
            // textBox_workspace
            // 
            this.textBox_workspace.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_workspace.Location = new System.Drawing.Point(80, 15);
            this.textBox_workspace.Name = "textBox_workspace";
            this.textBox_workspace.Size = new System.Drawing.Size(192, 20);
            this.textBox_workspace.TabIndex = 1;
            this.textBox_workspace.Text = "D:\\Jenkins\\Virtuos_UE4_26";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Workspace:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(578, 199);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Configure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Platform:";
            // 
            // comboBox_Config
            // 
            this.comboBox_Config.FormattingEnabled = true;
            this.comboBox_Config.Items.AddRange(new object[] {
            "Development",
            "Test",
            "Shipping"});
            this.comboBox_Config.Location = new System.Drawing.Point(80, 44);
            this.comboBox_Config.Name = "comboBox_Config";
            this.comboBox_Config.Size = new System.Drawing.Size(192, 21);
            this.comboBox_Config.TabIndex = 8;
            this.comboBox_Config.Text = "Development";
            // 
            // comboBox_Platform
            // 
            this.comboBox_Platform.FormattingEnabled = true;
            this.comboBox_Platform.Items.AddRange(new object[] {
            "Win64",
            "PS4",
            "PS5",
            "Switch",
            "XBoxOneGDK",
            "XSX"});
            this.comboBox_Platform.Location = new System.Drawing.Point(80, 72);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.Size = new System.Drawing.Size(192, 21);
            this.comboBox_Platform.TabIndex = 9;
            this.comboBox_Platform.Text = "Win64";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "AddParam:";
            // 
            // textBox_addparam
            // 
            this.textBox_addparam.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_addparam.Location = new System.Drawing.Point(80, 99);
            this.textBox_addparam.Name = "textBox_addparam";
            this.textBox_addparam.Size = new System.Drawing.Size(192, 20);
            this.textBox_addparam.TabIndex = 10;
            this.textBox_addparam.Text = "-iterate";
            // 
            // checkBox_BuildEditor
            // 
            this.checkBox_BuildEditor.AutoSize = true;
            this.checkBox_BuildEditor.Location = new System.Drawing.Point(389, 12);
            this.checkBox_BuildEditor.Name = "checkBox_BuildEditor";
            this.checkBox_BuildEditor.Size = new System.Drawing.Size(130, 17);
            this.checkBox_BuildEditor.TabIndex = 12;
            this.checkBox_BuildEditor.Text = "NeedBuildEditor(build)";
            this.checkBox_BuildEditor.UseVisualStyleBackColor = true;
            // 
            // checkBox_BuildCookRun
            // 
            this.checkBox_BuildCookRun.AutoSize = true;
            this.checkBox_BuildCookRun.Location = new System.Drawing.Point(389, 35);
            this.checkBox_BuildCookRun.Name = "checkBox_BuildCookRun";
            this.checkBox_BuildCookRun.Size = new System.Drawing.Size(120, 17);
            this.checkBox_BuildCookRun.TabIndex = 13;
            this.checkBox_BuildCookRun.Text = "NeedBuildCookRun";
            this.checkBox_BuildCookRun.UseVisualStyleBackColor = true;
            // 
            // checkBox_Backup
            // 
            this.checkBox_Backup.AutoSize = true;
            this.checkBox_Backup.Location = new System.Drawing.Point(389, 81);
            this.checkBox_Backup.Name = "checkBox_Backup";
            this.checkBox_Backup.Size = new System.Drawing.Size(89, 17);
            this.checkBox_Backup.TabIndex = 14;
            this.checkBox_Backup.Text = "NeedBackup";
            this.checkBox_Backup.UseVisualStyleBackColor = true;
            // 
            // textBox_ShareFolderName
            // 
            this.textBox_ShareFolderName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_ShareFolderName.Location = new System.Drawing.Point(389, 104);
            this.textBox_ShareFolderName.Name = "textBox_ShareFolderName";
            this.textBox_ShareFolderName.Size = new System.Drawing.Size(192, 20);
            this.textBox_ShareFolderName.TabIndex = 15;
            this.textBox_ShareFolderName.Text = "ShareFolderName";
            // 
            // checkBox_OpenEditor
            // 
            this.checkBox_OpenEditor.AutoSize = true;
            this.checkBox_OpenEditor.Location = new System.Drawing.Point(389, 58);
            this.checkBox_OpenEditor.Name = "checkBox_OpenEditor";
            this.checkBox_OpenEditor.Size = new System.Drawing.Size(79, 17);
            this.checkBox_OpenEditor.TabIndex = 16;
            this.checkBox_OpenEditor.Text = "OpenEditor";
            this.checkBox_OpenEditor.UseVisualStyleBackColor = true;
            // 
            // QuickBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 447);
            this.Controls.Add(this.checkBox_OpenEditor);
            this.Controls.Add(this.textBox_ShareFolderName);
            this.Controls.Add(this.checkBox_Backup);
            this.Controls.Add(this.checkBox_BuildCookRun);
            this.Controls.Add(this.checkBox_BuildEditor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_addparam);
            this.Controls.Add(this.comboBox_Platform);
            this.Controls.Add(this.comboBox_Config);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_workspace);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuickBuild";
            this.Text = "QuickBuild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_workspace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Config;
        private System.Windows.Forms.ComboBox comboBox_Platform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_addparam;
        private System.Windows.Forms.CheckBox checkBox_BuildEditor;
        private System.Windows.Forms.CheckBox checkBox_BuildCookRun;
        private System.Windows.Forms.CheckBox checkBox_Backup;
        private System.Windows.Forms.TextBox textBox_ShareFolderName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox_OpenEditor;
    }
}

