﻿namespace Main
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            main_toolstrip = new MenuStrip();
            mainToolStrip_file = new ToolStripMenuItem();
            openRom_toolstrip = new ToolStripMenuItem();
            openFolder_toolstrip = new ToolStripMenuItem();
            save_toolstrip = new ToolStripMenuItem();
            export_toolstrip = new ToolStripMenuItem();
            mainToolStrip_help = new ToolStripMenuItem();
            about_toolstrip = new ToolStripMenuItem();
            quick_toolstrip = new ToolStrip();
            openRom_btn = new ToolStripButton();
            openFolder_btn = new ToolStripButton();
            save_btn = new ToolStripButton();
            exportNarc_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            languageLabel = new ToolStripLabel();
            versionLabel = new ToolStripLabel();
            romNameLabel = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            mainContent = new TabControl();
            mainContent_trainerClass = new TabPage();
            trainerClass_Used_panel = new Panel();
            trainerClass_Uses_list = new ListBox();
            trainerClassUse_label = new Label();
            trainerClass_Music_panel = new Panel();
            trainerClass_EyeContactMusic_Alt_label = new Label();
            trainerClass_EyeContactMusic_Main_label = new Label();
            saveEyeContact_btn = new Button();
            eyeContactAlt_num = new NumericUpDown();
            eyeContactMain_num = new NumericUpDown();
            trainerClass_EyeContactMusic_label = new Label();
            trainerClass_UsedBy_panel = new Panel();
            trainerClass_Info_panel = new Panel();
            trainerClassIdDisplay = new TextBox();
            saveClassName_btn = new Button();
            trainerClassId_Label = new Label();
            trainerClassName = new TextBox();
            trainerClassName_Label = new Label();
            trainerClass_Spite_Panel = new Panel();
            trainerClassPicBox = new PictureBox();
            trainerClassPic_label = new Label();
            trainerClass_List_panel = new Panel();
            trainerClassListBox = new ListBox();
            trainerClass_label = new Label();
            player_trainer_class = new ListBox();
            playerClass_help_btn = new Button();
            playerClass_Label = new Label();
            mainContent_trainer = new TabPage();
            mainContent_trainerText = new TabPage();
            main_toolstrip.SuspendLayout();
            quick_toolstrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainContent.SuspendLayout();
            mainContent_trainerClass.SuspendLayout();
            trainerClass_Used_panel.SuspendLayout();
            trainerClass_Music_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeContactAlt_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeContactMain_num).BeginInit();
            trainerClass_Info_panel.SuspendLayout();
            trainerClass_Spite_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClassPicBox).BeginInit();
            trainerClass_List_panel.SuspendLayout();
            SuspendLayout();
            // 
            // main_toolstrip
            // 
            main_toolstrip.Items.AddRange(new ToolStripItem[] { mainToolStrip_file, mainToolStrip_help });
            main_toolstrip.Location = new Point(0, 0);
            main_toolstrip.Name = "main_toolstrip";
            main_toolstrip.Size = new Size(784, 24);
            main_toolstrip.TabIndex = 0;
            main_toolstrip.Text = "menuStrip1";
            // 
            // mainToolStrip_file
            // 
            mainToolStrip_file.DropDownItems.AddRange(new ToolStripItem[] { openRom_toolstrip, openFolder_toolstrip, save_toolstrip, export_toolstrip });
            mainToolStrip_file.Name = "mainToolStrip_file";
            mainToolStrip_file.Size = new Size(37, 20);
            mainToolStrip_file.Text = "File";
            // 
            // openRom_toolstrip
            // 
            openRom_toolstrip.Image = Properties.Resources.openRomIcon;
            openRom_toolstrip.Name = "openRom_toolstrip";
            openRom_toolstrip.Size = new Size(191, 22);
            openRom_toolstrip.Text = "Open ROM";
            openRom_toolstrip.Click += openRom_toolstrip_Click;
            // 
            // openFolder_toolstrip
            // 
            openFolder_toolstrip.Image = Properties.Resources.openFolderIcon;
            openFolder_toolstrip.Name = "openFolder_toolstrip";
            openFolder_toolstrip.Size = new Size(191, 22);
            openFolder_toolstrip.Text = "Open Extracted Folder";
            openFolder_toolstrip.Click += openFolder_toolstrip_Click;
            // 
            // save_toolstrip
            // 
            save_toolstrip.Enabled = false;
            save_toolstrip.Image = Properties.Resources.saveIcon;
            save_toolstrip.Name = "save_toolstrip";
            save_toolstrip.Size = new Size(191, 22);
            save_toolstrip.Text = "Save";
            // 
            // export_toolstrip
            // 
            export_toolstrip.Enabled = false;
            export_toolstrip.Image = Properties.Resources.exportNarcIcon;
            export_toolstrip.Name = "export_toolstrip";
            export_toolstrip.Size = new Size(191, 22);
            export_toolstrip.Text = "Export .NARCS";
            // 
            // mainToolStrip_help
            // 
            mainToolStrip_help.DropDownItems.AddRange(new ToolStripItem[] { about_toolstrip });
            mainToolStrip_help.Name = "mainToolStrip_help";
            mainToolStrip_help.Size = new Size(44, 20);
            mainToolStrip_help.Text = "Help";
            // 
            // about_toolstrip
            // 
            about_toolstrip.Name = "about_toolstrip";
            about_toolstrip.Size = new Size(107, 22);
            about_toolstrip.Text = "About";
            // 
            // quick_toolstrip
            // 
            quick_toolstrip.Items.AddRange(new ToolStripItem[] { openRom_btn, openFolder_btn, save_btn, exportNarc_btn, toolStripSeparator1, toolStripSeparator3, languageLabel, versionLabel, romNameLabel, toolStripSeparator2 });
            quick_toolstrip.Location = new Point(0, 24);
            quick_toolstrip.Name = "quick_toolstrip";
            quick_toolstrip.Size = new Size(784, 25);
            quick_toolstrip.TabIndex = 1;
            quick_toolstrip.Text = "toolStrip1";
            // 
            // openRom_btn
            // 
            openRom_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openRom_btn.Image = Properties.Resources.openRomIcon;
            openRom_btn.ImageTransparentColor = Color.Magenta;
            openRom_btn.Name = "openRom_btn";
            openRom_btn.Size = new Size(23, 22);
            openRom_btn.Text = "Open ROM";
            openRom_btn.Click += openRom_btn_Click;
            // 
            // openFolder_btn
            // 
            openFolder_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openFolder_btn.Image = Properties.Resources.openFolderIcon;
            openFolder_btn.ImageTransparentColor = Color.Magenta;
            openFolder_btn.Name = "openFolder_btn";
            openFolder_btn.Size = new Size(23, 22);
            openFolder_btn.Text = "Open Extracted Folder";
            openFolder_btn.Click += openFolder_btn_Click;
            // 
            // save_btn
            // 
            save_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            save_btn.Enabled = false;
            save_btn.Image = Properties.Resources.saveIcon;
            save_btn.ImageTransparentColor = Color.Magenta;
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(23, 22);
            save_btn.Text = "Save";
            // 
            // exportNarc_btn
            // 
            exportNarc_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            exportNarc_btn.Enabled = false;
            exportNarc_btn.Image = Properties.Resources.exportNarcIcon;
            exportNarc_btn.ImageTransparentColor = Color.Magenta;
            exportNarc_btn.Name = "exportNarc_btn";
            exportNarc_btn.Size = new Size(23, 22);
            exportNarc_btn.Text = "Export .NARCS";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Margin = new Padding(0, 0, 5, 0);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // languageLabel
            // 
            languageLabel.Alignment = ToolStripItemAlignment.Right;
            languageLabel.Margin = new Padding(0, 1, 2, 2);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(22, 22);
            languageLabel.Text = "     ";
            // 
            // versionLabel
            // 
            versionLabel.Alignment = ToolStripItemAlignment.Right;
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(22, 22);
            versionLabel.Text = "     ";
            // 
            // romNameLabel
            // 
            romNameLabel.Alignment = ToolStripItemAlignment.Right;
            romNameLabel.Name = "romNameLabel";
            romNameLabel.RightToLeft = RightToLeft.No;
            romNameLabel.Size = new Size(61, 22);
            romNameLabel.Text = "ROM Info:";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 17);
            statusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Padding = new Padding(15, 0, 0, 0);
            toolStripProgressBar.Size = new Size(115, 16);
            // 
            // mainContent
            // 
            mainContent.Controls.Add(mainContent_trainerClass);
            mainContent.Controls.Add(mainContent_trainer);
            mainContent.Controls.Add(mainContent_trainerText);
            mainContent.Dock = DockStyle.Fill;
            mainContent.Enabled = false;
            mainContent.Location = new Point(0, 49);
            mainContent.Margin = new Padding(10);
            mainContent.Name = "mainContent";
            mainContent.SelectedIndex = 0;
            mainContent.Size = new Size(784, 490);
            mainContent.TabIndex = 3;
            mainContent.Visible = false;
            mainContent.SelectedIndexChanged += mainContent_SelectedIndexChanged;
            // 
            // mainContent_trainerClass
            // 
            mainContent_trainerClass.AccessibleRole = AccessibleRole.None;
            mainContent_trainerClass.Controls.Add(trainerClass_Used_panel);
            mainContent_trainerClass.Controls.Add(trainerClass_Music_panel);
            mainContent_trainerClass.Controls.Add(trainerClass_Info_panel);
            mainContent_trainerClass.Controls.Add(trainerClass_Spite_Panel);
            mainContent_trainerClass.Controls.Add(trainerClass_List_panel);
            mainContent_trainerClass.Location = new Point(4, 24);
            mainContent_trainerClass.Name = "mainContent_trainerClass";
            mainContent_trainerClass.Padding = new Padding(3);
            mainContent_trainerClass.Size = new Size(776, 462);
            mainContent_trainerClass.TabIndex = 3;
            mainContent_trainerClass.Text = "Trainer Class";
            mainContent_trainerClass.UseVisualStyleBackColor = true;
            // 
            // trainerClass_Used_panel
            // 
            trainerClass_Used_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainerClass_Used_panel.Controls.Add(trainerClass_Uses_list);
            trainerClass_Used_panel.Controls.Add(trainerClassUse_label);
            trainerClass_Used_panel.Location = new Point(209, 209);
            trainerClass_Used_panel.Name = "trainerClass_Used_panel";
            trainerClass_Used_panel.Size = new Size(564, 253);
            trainerClass_Used_panel.TabIndex = 4;
            // 
            // trainerClass_Uses_list
            // 
            trainerClass_Uses_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainerClass_Uses_list.FormattingEnabled = true;
            trainerClass_Uses_list.ItemHeight = 15;
            trainerClass_Uses_list.Location = new Point(6, 34);
            trainerClass_Uses_list.Name = "trainerClass_Uses_list";
            trainerClass_Uses_list.Size = new Size(553, 214);
            trainerClass_Uses_list.TabIndex = 27;
            // 
            // trainerClassUse_label
            // 
            trainerClassUse_label.AutoSize = true;
            trainerClassUse_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassUse_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassUse_label.Location = new Point(3, 14);
            trainerClassUse_label.Name = "trainerClassUse_label";
            trainerClassUse_label.Size = new Size(117, 15);
            trainerClassUse_label.TabIndex = 28;
            trainerClassUse_label.Text = "Trainers Using Class:";
            trainerClassUse_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Music_panel
            // 
            trainerClass_Music_panel.Controls.Add(trainerClass_EyeContactMusic_Alt_label);
            trainerClass_Music_panel.Controls.Add(trainerClass_EyeContactMusic_Main_label);
            trainerClass_Music_panel.Controls.Add(saveEyeContact_btn);
            trainerClass_Music_panel.Controls.Add(eyeContactAlt_num);
            trainerClass_Music_panel.Controls.Add(eyeContactMain_num);
            trainerClass_Music_panel.Controls.Add(trainerClass_EyeContactMusic_label);
            trainerClass_Music_panel.Controls.Add(trainerClass_UsedBy_panel);
            trainerClass_Music_panel.Location = new Point(209, 93);
            trainerClass_Music_panel.Name = "trainerClass_Music_panel";
            trainerClass_Music_panel.Size = new Size(358, 110);
            trainerClass_Music_panel.TabIndex = 3;
            // 
            // trainerClass_EyeContactMusic_Alt_label
            // 
            trainerClass_EyeContactMusic_Alt_label.AutoSize = true;
            trainerClass_EyeContactMusic_Alt_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainerClass_EyeContactMusic_Alt_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_EyeContactMusic_Alt_label.Location = new Point(6, 63);
            trainerClass_EyeContactMusic_Alt_label.Name = "trainerClass_EyeContactMusic_Alt_label";
            trainerClass_EyeContactMusic_Alt_label.Size = new Size(33, 15);
            trainerClass_EyeContactMusic_Alt_label.TabIndex = 26;
            trainerClass_EyeContactMusic_Alt_label.Text = "[Alt.]";
            trainerClass_EyeContactMusic_Alt_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_EyeContactMusic_Main_label
            // 
            trainerClass_EyeContactMusic_Main_label.AutoSize = true;
            trainerClass_EyeContactMusic_Main_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainerClass_EyeContactMusic_Main_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_EyeContactMusic_Main_label.Location = new Point(4, 30);
            trainerClass_EyeContactMusic_Main_label.Name = "trainerClass_EyeContactMusic_Main_label";
            trainerClass_EyeContactMusic_Main_label.Size = new Size(42, 15);
            trainerClass_EyeContactMusic_Main_label.TabIndex = 25;
            trainerClass_EyeContactMusic_Main_label.Text = "[Main]";
            trainerClass_EyeContactMusic_Main_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveEyeContact_btn
            // 
            saveEyeContact_btn.Location = new Point(52, 84);
            saveEyeContact_btn.Name = "saveEyeContact_btn";
            saveEyeContact_btn.Size = new Size(59, 23);
            saveEyeContact_btn.TabIndex = 21;
            saveEyeContact_btn.Text = "Save";
            saveEyeContact_btn.UseVisualStyleBackColor = true;
            // 
            // eyeContactAlt_num
            // 
            eyeContactAlt_num.Location = new Point(52, 57);
            eyeContactAlt_num.Name = "eyeContactAlt_num";
            eyeContactAlt_num.Size = new Size(59, 23);
            eyeContactAlt_num.TabIndex = 24;
            // 
            // eyeContactMain_num
            // 
            eyeContactMain_num.Location = new Point(52, 28);
            eyeContactMain_num.Name = "eyeContactMain_num";
            eyeContactMain_num.Size = new Size(59, 23);
            eyeContactMain_num.TabIndex = 22;
            // 
            // trainerClass_EyeContactMusic_label
            // 
            trainerClass_EyeContactMusic_label.AutoSize = true;
            trainerClass_EyeContactMusic_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_EyeContactMusic_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_EyeContactMusic_label.Location = new Point(6, 8);
            trainerClass_EyeContactMusic_label.Name = "trainerClass_EyeContactMusic_label";
            trainerClass_EyeContactMusic_label.Size = new Size(110, 15);
            trainerClass_EyeContactMusic_label.TabIndex = 23;
            trainerClass_EyeContactMusic_label.Text = "Eye Contact Music:";
            trainerClass_EyeContactMusic_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_UsedBy_panel
            // 
            trainerClass_UsedBy_panel.Location = new Point(0, 122);
            trainerClass_UsedBy_panel.Name = "trainerClass_UsedBy_panel";
            trainerClass_UsedBy_panel.Size = new Size(564, 237);
            trainerClass_UsedBy_panel.TabIndex = 4;
            // 
            // trainerClass_Info_panel
            // 
            trainerClass_Info_panel.Controls.Add(trainerClassIdDisplay);
            trainerClass_Info_panel.Controls.Add(saveClassName_btn);
            trainerClass_Info_panel.Controls.Add(trainerClassId_Label);
            trainerClass_Info_panel.Controls.Add(trainerClassName);
            trainerClass_Info_panel.Controls.Add(trainerClassName_Label);
            trainerClass_Info_panel.Location = new Point(209, 3);
            trainerClass_Info_panel.Name = "trainerClass_Info_panel";
            trainerClass_Info_panel.Size = new Size(358, 84);
            trainerClass_Info_panel.TabIndex = 2;
            // 
            // trainerClassIdDisplay
            // 
            trainerClassIdDisplay.Location = new Point(6, 36);
            trainerClassIdDisplay.Name = "trainerClassIdDisplay";
            trainerClassIdDisplay.ReadOnly = true;
            trainerClassIdDisplay.Size = new Size(105, 23);
            trainerClassIdDisplay.TabIndex = 14;
            // 
            // saveClassName_btn
            // 
            saveClassName_btn.Location = new Point(296, 36);
            saveClassName_btn.Name = "saveClassName_btn";
            saveClassName_btn.Size = new Size(53, 23);
            saveClassName_btn.TabIndex = 12;
            saveClassName_btn.Text = "Save";
            saveClassName_btn.UseVisualStyleBackColor = true;
            saveClassName_btn.Click += saveClassName_btn_Click;
            // 
            // trainerClassId_Label
            // 
            trainerClassId_Label.AutoSize = true;
            trainerClassId_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassId_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassId_Label.Location = new Point(6, 12);
            trainerClassId_Label.Name = "trainerClassId_Label";
            trainerClassId_Label.Size = new Size(94, 15);
            trainerClassId_Label.TabIndex = 13;
            trainerClassId_Label.Text = "Trainer Class ID:";
            trainerClassId_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClassName
            // 
            trainerClassName.AllowDrop = true;
            trainerClassName.Location = new Point(128, 36);
            trainerClassName.Name = "trainerClassName";
            trainerClassName.Size = new Size(162, 23);
            trainerClassName.TabIndex = 11;
            // 
            // trainerClassName_Label
            // 
            trainerClassName_Label.AutoSize = true;
            trainerClassName_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassName_Label.Location = new Point(128, 12);
            trainerClassName_Label.Name = "trainerClassName_Label";
            trainerClassName_Label.Size = new Size(114, 15);
            trainerClassName_Label.TabIndex = 10;
            trainerClassName_Label.Text = "Trainer Class Name:";
            trainerClassName_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Spite_Panel
            // 
            trainerClass_Spite_Panel.Controls.Add(trainerClassPicBox);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPic_label);
            trainerClass_Spite_Panel.Location = new Point(573, 3);
            trainerClass_Spite_Panel.Name = "trainerClass_Spite_Panel";
            trainerClass_Spite_Panel.Size = new Size(200, 200);
            trainerClass_Spite_Panel.TabIndex = 1;
            // 
            // trainerClassPicBox
            // 
            trainerClassPicBox.BorderStyle = BorderStyle.Fixed3D;
            trainerClassPicBox.Location = new Point(5, 35);
            trainerClassPicBox.Name = "trainerClassPicBox";
            trainerClassPicBox.Size = new Size(128, 128);
            trainerClassPicBox.TabIndex = 26;
            trainerClassPicBox.TabStop = false;
            // 
            // trainerClassPic_label
            // 
            trainerClassPic_label.AutoSize = true;
            trainerClassPic_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassPic_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassPic_label.Location = new Point(3, 12);
            trainerClassPic_label.Name = "trainerClassPic_label";
            trainerClassPic_label.Size = new Size(115, 15);
            trainerClassPic_label.TabIndex = 27;
            trainerClassPic_label.Text = "Trainer Class Sprite:";
            trainerClassPic_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_List_panel
            // 
            trainerClass_List_panel.Controls.Add(trainerClassListBox);
            trainerClass_List_panel.Controls.Add(trainerClass_label);
            trainerClass_List_panel.Controls.Add(player_trainer_class);
            trainerClass_List_panel.Controls.Add(playerClass_help_btn);
            trainerClass_List_panel.Controls.Add(playerClass_Label);
            trainerClass_List_panel.Dock = DockStyle.Left;
            trainerClass_List_panel.Location = new Point(3, 3);
            trainerClass_List_panel.Name = "trainerClass_List_panel";
            trainerClass_List_panel.Size = new Size(200, 456);
            trainerClass_List_panel.TabIndex = 0;
            // 
            // trainerClassListBox
            // 
            trainerClassListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainerClassListBox.FormattingEnabled = true;
            trainerClassListBox.ItemHeight = 15;
            trainerClassListBox.Location = new Point(5, 120);
            trainerClassListBox.Name = "trainerClassListBox";
            trainerClassListBox.Size = new Size(190, 334);
            trainerClassListBox.TabIndex = 1;
            trainerClassListBox.SelectedIndexChanged += trainerClassListBox_SelectedIndexChanged;
            // 
            // trainerClass_label
            // 
            trainerClass_label.AutoSize = true;
            trainerClass_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_label.Location = new Point(5, 98);
            trainerClass_label.Name = "trainerClass_label";
            trainerClass_label.Size = new Size(90, 15);
            trainerClass_label.TabIndex = 4;
            trainerClass_label.Text = "Trainer Classes:";
            trainerClass_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player_trainer_class
            // 
            player_trainer_class.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            player_trainer_class.Enabled = false;
            player_trainer_class.FormattingEnabled = true;
            player_trainer_class.ItemHeight = 15;
            player_trainer_class.Location = new Point(5, 35);
            player_trainer_class.Name = "player_trainer_class";
            player_trainer_class.Size = new Size(190, 49);
            player_trainer_class.TabIndex = 3;
            // 
            // playerClass_help_btn
            // 
            playerClass_help_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            playerClass_help_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playerClass_help_btn.Location = new Point(173, 7);
            playerClass_help_btn.Name = "playerClass_help_btn";
            playerClass_help_btn.Size = new Size(24, 24);
            playerClass_help_btn.TabIndex = 2;
            playerClass_help_btn.Text = "?";
            playerClass_help_btn.UseVisualStyleBackColor = true;
            playerClass_help_btn.Click += playerClass_help_btn_Click;
            // 
            // playerClass_Label
            // 
            playerClass_Label.AutoSize = true;
            playerClass_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playerClass_Label.ImageAlign = ContentAlignment.MiddleLeft;
            playerClass_Label.Location = new Point(5, 12);
            playerClass_Label.Name = "playerClass_Label";
            playerClass_Label.Size = new Size(85, 15);
            playerClass_Label.TabIndex = 1;
            playerClass_Label.Text = "Player Classes:";
            playerClass_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainContent_trainer
            // 
            mainContent_trainer.Location = new Point(4, 24);
            mainContent_trainer.Name = "mainContent_trainer";
            mainContent_trainer.Padding = new Padding(3);
            mainContent_trainer.Size = new Size(776, 462);
            mainContent_trainer.TabIndex = 1;
            mainContent_trainer.Text = "Trainers";
            mainContent_trainer.UseVisualStyleBackColor = true;
            // 
            // mainContent_trainerText
            // 
            mainContent_trainerText.Location = new Point(4, 24);
            mainContent_trainerText.Name = "mainContent_trainerText";
            mainContent_trainerText.Size = new Size(776, 462);
            mainContent_trainerText.TabIndex = 2;
            mainContent_trainerText.Text = "Trainer Text";
            mainContent_trainerText.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(mainContent);
            Controls.Add(statusStrip1);
            Controls.Add(quick_toolstrip);
            Controls.Add(main_toolstrip);
            MainMenuStrip = main_toolstrip;
            Name = "Mainform";
            Text = "VS-Maker";
            main_toolstrip.ResumeLayout(false);
            main_toolstrip.PerformLayout();
            quick_toolstrip.ResumeLayout(false);
            quick_toolstrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainContent.ResumeLayout(false);
            mainContent_trainerClass.ResumeLayout(false);
            trainerClass_Used_panel.ResumeLayout(false);
            trainerClass_Used_panel.PerformLayout();
            trainerClass_Music_panel.ResumeLayout(false);
            trainerClass_Music_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyeContactAlt_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeContactMain_num).EndInit();
            trainerClass_Info_panel.ResumeLayout(false);
            trainerClass_Info_panel.PerformLayout();
            trainerClass_Spite_Panel.ResumeLayout(false);
            trainerClass_Spite_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClassPicBox).EndInit();
            trainerClass_List_panel.ResumeLayout(false);
            trainerClass_List_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip main_toolstrip;
        private ToolStripMenuItem mainToolStrip_file;
        private ToolStripMenuItem openRom_toolstrip;
        private ToolStripMenuItem openFolder_toolstrip;
        private ToolStripMenuItem save_toolstrip;
        private ToolStripMenuItem export_toolstrip;
        private ToolStrip quick_toolstrip;
        private ToolStripButton openRom_btn;
        private ToolStripButton openFolder_btn;
        private ToolStripButton save_btn;
        private ToolStripButton exportNarc_btn;
        private ToolStripMenuItem mainToolStrip_help;
        private ToolStripMenuItem about_toolstrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel versionLabel;
        private ToolStripLabel languageLabel;
        private ToolStripSeparator toolStripSeparator2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripLabel romNameLabel;
        private TabControl mainContent;
        private TabPage mainContent_trainer;
        private TabPage mainContent_trainerText;
        private ToolStripSeparator toolStripSeparator3;
        private Label eyeContactMusic_Label;
        private TabPage mainContent_trainerClass;
        private Panel trainerClass_Music_panel;
        private Panel trainerClass_UsedBy_panel;
        private Panel trainerClass_Info_panel;
        private Panel trainerClass_Spite_Panel;
        private Panel trainerClass_List_panel;
        private ListBox trainerClassListBox;
        private Label trainerClass_label;
        private ListBox player_trainer_class;
        private Button playerClass_help_btn;
        private Label playerClass_Label;
        private Panel trainerClass_Used_panel;
        private ListBox trainerClass_Uses_list;
        private Label trainerClassUse_label;
        private Label trainerClass_EyeContactMusic_Alt_label;
        private Label trainerClass_EyeContactMusic_Main_label;
        private Button saveEyeContact_btn;
        private NumericUpDown eyeContactAlt_num;
        private NumericUpDown eyeContactMain_num;
        private Label trainerClass_EyeContactMusic_label;
        private TextBox trainerClassIdDisplay;
        private Button saveClassName_btn;
        private Label trainerClassId_Label;
        private TextBox trainerClassName;
        private Label trainerClassName_Label;
        private PictureBox trainerClassPicBox;
        private Label trainerClassPic_label;
    }
}