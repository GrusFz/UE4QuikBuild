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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickBuild));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_EngineDir = new System.Windows.Forms.TextBox();
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
            this.checkBox_OpenEditor = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_BuildCook = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ArchivedDir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ProjectDir = new System.Windows.Forms.TextBox();
            this.tabPage_P4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ChangeFileList = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList_Tab = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage_BuildCook.SuspendLayout();
            this.tabPage_P4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IterateBuild_Click);
            // 
            // textBox_EngineDir
            // 
            this.textBox_EngineDir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_EngineDir.Location = new System.Drawing.Point(79, 10);
            this.textBox_EngineDir.Name = "textBox_EngineDir";
            this.textBox_EngineDir.Size = new System.Drawing.Size(291, 20);
            this.textBox_EngineDir.TabIndex = 1;
            this.textBox_EngineDir.Text = "E:\\Project\\Coda\\Engine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EngineDir:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 319);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 238);
            this.listBox1.TabIndex = 3;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Configure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 97);
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
            this.comboBox_Config.Location = new System.Drawing.Point(80, 123);
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
            this.comboBox_Platform.Location = new System.Drawing.Point(79, 94);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.Size = new System.Drawing.Size(192, 21);
            this.comboBox_Platform.TabIndex = 9;
            this.comboBox_Platform.Text = "Win64";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "AddParam:";
            // 
            // textBox_addparam
            // 
            this.textBox_addparam.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_addparam.Location = new System.Drawing.Point(79, 151);
            this.textBox_addparam.Name = "textBox_addparam";
            this.textBox_addparam.Size = new System.Drawing.Size(192, 20);
            this.textBox_addparam.TabIndex = 10;
            this.textBox_addparam.Text = "-iterate";
            // 
            // checkBox_BuildEditor
            // 
            this.checkBox_BuildEditor.AutoSize = true;
            this.checkBox_BuildEditor.Location = new System.Drawing.Point(388, 7);
            this.checkBox_BuildEditor.Name = "checkBox_BuildEditor";
            this.checkBox_BuildEditor.Size = new System.Drawing.Size(130, 17);
            this.checkBox_BuildEditor.TabIndex = 12;
            this.checkBox_BuildEditor.Text = "NeedBuildEditor(build)";
            this.checkBox_BuildEditor.UseVisualStyleBackColor = true;
            // 
            // checkBox_BuildCookRun
            // 
            this.checkBox_BuildCookRun.AutoSize = true;
            this.checkBox_BuildCookRun.Location = new System.Drawing.Point(388, 30);
            this.checkBox_BuildCookRun.Name = "checkBox_BuildCookRun";
            this.checkBox_BuildCookRun.Size = new System.Drawing.Size(120, 17);
            this.checkBox_BuildCookRun.TabIndex = 13;
            this.checkBox_BuildCookRun.Text = "NeedBuildCookRun";
            this.checkBox_BuildCookRun.UseVisualStyleBackColor = true;
            // 
            // checkBox_Backup
            // 
            this.checkBox_Backup.AutoSize = true;
            this.checkBox_Backup.Location = new System.Drawing.Point(388, 76);
            this.checkBox_Backup.Name = "checkBox_Backup";
            this.checkBox_Backup.Size = new System.Drawing.Size(89, 17);
            this.checkBox_Backup.TabIndex = 14;
            this.checkBox_Backup.Text = "NeedBackup";
            this.checkBox_Backup.UseVisualStyleBackColor = true;
            // 
            // textBox_ShareFolderName
            // 
            this.textBox_ShareFolderName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_ShareFolderName.Location = new System.Drawing.Point(388, 99);
            this.textBox_ShareFolderName.Name = "textBox_ShareFolderName";
            this.textBox_ShareFolderName.Size = new System.Drawing.Size(192, 20);
            this.textBox_ShareFolderName.TabIndex = 15;
            this.textBox_ShareFolderName.Text = "ShareFolderName";
            // 
            // checkBox_OpenEditor
            // 
            this.checkBox_OpenEditor.AutoSize = true;
            this.checkBox_OpenEditor.Location = new System.Drawing.Point(388, 53);
            this.checkBox_OpenEditor.Name = "checkBox_OpenEditor";
            this.checkBox_OpenEditor.Size = new System.Drawing.Size(79, 17);
            this.checkBox_OpenEditor.TabIndex = 16;
            this.checkBox_OpenEditor.Text = "OpenEditor";
            this.checkBox_OpenEditor.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_BuildCook);
            this.tabControl1.Controls.Add(this.tabPage_P4);
            this.tabControl1.ImageList = this.imageList_Tab;
            this.tabControl1.ItemSize = new System.Drawing.Size(94, 19);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 310);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage_BuildCook
            // 
            this.tabPage_BuildCook.Controls.Add(this.label10);
            this.tabPage_BuildCook.Controls.Add(this.textBox_ArchivedDir);
            this.tabPage_BuildCook.Controls.Add(this.label9);
            this.tabPage_BuildCook.Controls.Add(this.textBox_ProjectDir);
            this.tabPage_BuildCook.Controls.Add(this.label1);
            this.tabPage_BuildCook.Controls.Add(this.checkBox_OpenEditor);
            this.tabPage_BuildCook.Controls.Add(this.button1);
            this.tabPage_BuildCook.Controls.Add(this.textBox_ShareFolderName);
            this.tabPage_BuildCook.Controls.Add(this.textBox_EngineDir);
            this.tabPage_BuildCook.Controls.Add(this.checkBox_Backup);
            this.tabPage_BuildCook.Controls.Add(this.label2);
            this.tabPage_BuildCook.Controls.Add(this.checkBox_BuildCookRun);
            this.tabPage_BuildCook.Controls.Add(this.label3);
            this.tabPage_BuildCook.Controls.Add(this.checkBox_BuildEditor);
            this.tabPage_BuildCook.Controls.Add(this.comboBox_Config);
            this.tabPage_BuildCook.Controls.Add(this.label4);
            this.tabPage_BuildCook.Controls.Add(this.comboBox_Platform);
            this.tabPage_BuildCook.Controls.Add(this.textBox_addparam);
            this.tabPage_BuildCook.ImageKey = "icon_发布.png";
            this.tabPage_BuildCook.Location = new System.Drawing.Point(4, 23);
            this.tabPage_BuildCook.Name = "tabPage_BuildCook";
            this.tabPage_BuildCook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BuildCook.Size = new System.Drawing.Size(657, 283);
            this.tabPage_BuildCook.TabIndex = 0;
            this.tabPage_BuildCook.Text = "Build Cook   ";
            this.tabPage_BuildCook.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "ArchivedDir:";
            // 
            // textBox_ArchivedDir
            // 
            this.textBox_ArchivedDir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_ArchivedDir.Location = new System.Drawing.Point(79, 65);
            this.textBox_ArchivedDir.Name = "textBox_ArchivedDir";
            this.textBox_ArchivedDir.Size = new System.Drawing.Size(291, 20);
            this.textBox_ArchivedDir.TabIndex = 19;
            this.textBox_ArchivedDir.Text = "E:\\Temp\\PlayGround\\Package";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ProjectDir:";
            // 
            // textBox_ProjectDir
            // 
            this.textBox_ProjectDir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_ProjectDir.Location = new System.Drawing.Point(79, 37);
            this.textBox_ProjectDir.Name = "textBox_ProjectDir";
            this.textBox_ProjectDir.Size = new System.Drawing.Size(291, 20);
            this.textBox_ProjectDir.TabIndex = 17;
            this.textBox_ProjectDir.Text = "E:\\Temp\\PlayGround\\PlayGround1\\PlayGround1.uproject";
            // 
            // tabPage_P4
            // 
            this.tabPage_P4.Controls.Add(this.label8);
            this.tabPage_P4.Controls.Add(this.textBox_ChangeFileList);
            this.tabPage_P4.Controls.Add(this.button3);
            this.tabPage_P4.Controls.Add(this.button2);
            this.tabPage_P4.Controls.Add(this.textBox3);
            this.tabPage_P4.Controls.Add(this.textBox2);
            this.tabPage_P4.Controls.Add(this.label5);
            this.tabPage_P4.Controls.Add(this.textBox1);
            this.tabPage_P4.Controls.Add(this.label6);
            this.tabPage_P4.Controls.Add(this.label7);
            this.tabPage_P4.ImageKey = "基础管理.png";
            this.tabPage_P4.Location = new System.Drawing.Point(4, 23);
            this.tabPage_P4.Name = "tabPage_P4";
            this.tabPage_P4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_P4.Size = new System.Drawing.Size(657, 283);
            this.tabPage_P4.TabIndex = 1;
            this.tabPage_P4.Text = "P4            ";
            this.tabPage_P4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "File List:";
            // 
            // textBox_ChangeFileList
            // 
            this.textBox_ChangeFileList.Location = new System.Drawing.Point(11, 111);
            this.textBox_ChangeFileList.Multiline = true;
            this.textBox_ChangeFileList.Name = "textBox_ChangeFileList";
            this.textBox_ChangeFileList.Size = new System.Drawing.Size(475, 148);
            this.textBox_ChangeFileList.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Simple Copy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Pull and Copy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox3.Location = new System.Drawing.Point(103, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "D:\\Jenkins\\Virtuos_UE4_26_COPY";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox2.Location = new System.Drawing.Point(103, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "D:\\Jenkins\\Virtuos_UE4_26";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "P4 ChangeList:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.Location = new System.Drawing.Point(103, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "P4 Workspace:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Copy WorkSpcae:";
            // 
            // imageList_Tab
            // 
            this.imageList_Tab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Tab.ImageStream")));
            this.imageList_Tab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Tab.Images.SetKeyName(0, "icon_发布.png");
            this.imageList_Tab.Images.SetKeyName(1, "基础管理.png");
            // 
            // QuickBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 570);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuickBuild";
            this.Text = "QuickBuild";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_BuildCook.ResumeLayout(false);
            this.tabPage_BuildCook.PerformLayout();
            this.tabPage_P4.ResumeLayout(false);
            this.tabPage_P4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_EngineDir;
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
        private System.Windows.Forms.CheckBox checkBox_OpenEditor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_BuildCook;
        private System.Windows.Forms.TabPage tabPage_P4;
        private System.Windows.Forms.ImageList imageList_Tab;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ChangeFileList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ProjectDir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ArchivedDir;
    }
}

