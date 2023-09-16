namespace Main
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
            statusStrip1 = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            statusLabel = new ToolStripStatusLabel();
            mainContent = new TabControl();
            mainContent_trainerClass = new TabPage();
            trainerClass_EyeContactMain_comboBox = new ComboBox();
            saveEyeContact_btn = new Button();
            trainerClass_EyeContactAlt_comboBox = new ComboBox();
            trainerClass_EyeContactMusic_Main_label = new Label();
            panel4 = new Panel();
            trainerClass_PrizeMoney_btn = new Button();
            saveGender_btn = new Button();
            trainerClass_Gender_comboBox = new ComboBox();
            trainerClass_Gender_label = new Label();
            savePrizeMoney_btn = new Button();
            trainerClass_PrizeMoney_num = new NumericUpDown();
            trainerClass_PrizeMoney_label = new Label();
            panel3 = new Panel();
            trainerClass_Theme_label = new Label();
            trainerClass_BattleMusic_label = new Label();
            trainerClass_battleMusic = new TextBox();
            saveClassTheme_btn = new Button();
            trainerClass_vsGfx_box = new PictureBox();
            trainerClass_Theme_comboBox = new ComboBox();
            trainerClass_introGfx_label = new Label();
            trainerClass_Used_panel = new Panel();
            trainerClass_GoToTrainer_btn = new Button();
            trainerClass_Uses_list = new ListBox();
            trainerClassUse_label = new Label();
            trainerClass_Info_panel = new Panel();
            saveClassName_btn = new Button();
            trainerClassName = new TextBox();
            trainerClassName_Label = new Label();
            trainerClass_Spite_Panel = new Panel();
            trainerClass_frames_num = new NumericUpDown();
            trainerClass_frames_label = new Label();
            trainerClassPicBox = new PictureBox();
            trainerClassPic_label = new Label();
            trainerClass_List_panel = new Panel();
            trainerClassListBox = new ListBox();
            trainerClass_label = new Label();
            player_trainer_class = new ListBox();
            playerClass_help_btn = new Button();
            playerClass_Label = new Label();
            mainContent_trainer = new TabPage();
            panel6 = new Panel();
            trainer_GoToClass_btn = new Button();
            save_TrainerClass_btn = new Button();
            label5 = new Label();
            trainer_Class_comboBox = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            trainerPicBox = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            trainers_list = new ListBox();
            label1 = new Label();
            trainers_Player_list = new ListBox();
            mainContent_trainerText = new TabPage();
            quick_toolstrip = new ToolStrip();
            openRom_btn = new ToolStripButton();
            openFolder_btn = new ToolStripButton();
            save_btn = new ToolStripButton();
            exportNarc_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            languageLabel = new ToolStripLabel();
            versionLabel = new ToolStripLabel();
            romNameLabel = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            panel1 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            save_TrainerName_btn = new Button();
            trainer_Name = new TextBox();
            trainer_Name_Label = new Label();
            main_toolstrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainContent.SuspendLayout();
            mainContent_trainerClass.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_PrizeMoney_num).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_vsGfx_box).BeginInit();
            trainerClass_Used_panel.SuspendLayout();
            trainerClass_Info_panel.SuspendLayout();
            trainerClass_Spite_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_frames_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerClassPicBox).BeginInit();
            trainerClass_List_panel.SuspendLayout();
            mainContent_trainer.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerPicBox).BeginInit();
            panel5.SuspendLayout();
            quick_toolstrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar, statusLabel });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Margin = new Padding(15, 0, 0, 2);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Padding = new Padding(15, 0, 0, 0);
            toolStripProgressBar.Size = new Size(115, 16);
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 17);
            statusLabel.Text = "Ready";
            // 
            // mainContent
            // 
            mainContent.Controls.Add(mainContent_trainerClass);
            mainContent.Controls.Add(mainContent_trainer);
            mainContent.Controls.Add(mainContent_trainerText);
            mainContent.Dock = DockStyle.Fill;
            mainContent.Enabled = false;
            mainContent.Location = new Point(0, 0);
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
            mainContent_trainerClass.Controls.Add(panel4);
            mainContent_trainerClass.Controls.Add(panel3);
            mainContent_trainerClass.Controls.Add(trainerClass_Used_panel);
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
            // trainerClass_EyeContactMain_comboBox
            // 
            trainerClass_EyeContactMain_comboBox.FormattingEnabled = true;
            trainerClass_EyeContactMain_comboBox.Location = new Point(5, 49);
            trainerClass_EyeContactMain_comboBox.Name = "trainerClass_EyeContactMain_comboBox";
            trainerClass_EyeContactMain_comboBox.Size = new Size(61, 23);
            trainerClass_EyeContactMain_comboBox.TabIndex = 32;
            // 
            // saveEyeContact_btn
            // 
            saveEyeContact_btn.Location = new Point(139, 49);
            saveEyeContact_btn.Name = "saveEyeContact_btn";
            saveEyeContact_btn.Size = new Size(53, 23);
            saveEyeContact_btn.TabIndex = 31;
            saveEyeContact_btn.Text = "Save";
            saveEyeContact_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_EyeContactAlt_comboBox
            // 
            trainerClass_EyeContactAlt_comboBox.FormattingEnabled = true;
            trainerClass_EyeContactAlt_comboBox.Location = new Point(72, 49);
            trainerClass_EyeContactAlt_comboBox.Name = "trainerClass_EyeContactAlt_comboBox";
            trainerClass_EyeContactAlt_comboBox.Size = new Size(61, 23);
            trainerClass_EyeContactAlt_comboBox.TabIndex = 30;
            // 
            // trainerClass_EyeContactMusic_Main_label
            // 
            trainerClass_EyeContactMusic_Main_label.AutoSize = true;
            trainerClass_EyeContactMusic_Main_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_EyeContactMusic_Main_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_EyeContactMusic_Main_label.Location = new Point(5, 28);
            trainerClass_EyeContactMusic_Main_label.Name = "trainerClass_EyeContactMusic_Main_label";
            trainerClass_EyeContactMusic_Main_label.Size = new Size(115, 15);
            trainerClass_EyeContactMusic_Main_label.TabIndex = 25;
            trainerClass_EyeContactMusic_Main_label.Text = "Eye-Contact  Music:";
            trainerClass_EyeContactMusic_Main_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(saveEyeContact_btn);
            panel4.Controls.Add(trainerClass_EyeContactMain_comboBox);
            panel4.Controls.Add(trainerClass_EyeContactAlt_comboBox);
            panel4.Controls.Add(trainerClass_PrizeMoney_btn);
            panel4.Controls.Add(savePrizeMoney_btn);
            panel4.Controls.Add(trainerClass_PrizeMoney_num);
            panel4.Controls.Add(trainerClass_EyeContactMusic_Main_label);
            panel4.Controls.Add(trainerClass_PrizeMoney_label);
            panel4.Location = new Point(209, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 98);
            panel4.TabIndex = 7;
            // 
            // trainerClass_PrizeMoney_btn
            // 
            trainerClass_PrizeMoney_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainerClass_PrizeMoney_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_PrizeMoney_btn.Location = new Point(325, 19);
            trainerClass_PrizeMoney_btn.Name = "trainerClass_PrizeMoney_btn";
            trainerClass_PrizeMoney_btn.Size = new Size(24, 24);
            trainerClass_PrizeMoney_btn.TabIndex = 5;
            trainerClass_PrizeMoney_btn.Text = "?";
            trainerClass_PrizeMoney_btn.UseVisualStyleBackColor = true;
            trainerClass_PrizeMoney_btn.Click += trainerClass_PrizeMoney_btn_Click;
            // 
            // saveGender_btn
            // 
            saveGender_btn.Location = new Point(296, 34);
            saveGender_btn.Name = "saveGender_btn";
            saveGender_btn.Size = new Size(53, 23);
            saveGender_btn.TabIndex = 39;
            saveGender_btn.Text = "Save";
            saveGender_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_Gender_comboBox
            // 
            trainerClass_Gender_comboBox.FormattingEnabled = true;
            trainerClass_Gender_comboBox.Location = new Point(213, 34);
            trainerClass_Gender_comboBox.Name = "trainerClass_Gender_comboBox";
            trainerClass_Gender_comboBox.Size = new Size(77, 23);
            trainerClass_Gender_comboBox.TabIndex = 33;
            // 
            // trainerClass_Gender_label
            // 
            trainerClass_Gender_label.AutoSize = true;
            trainerClass_Gender_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_Gender_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_Gender_label.Location = new Point(213, 12);
            trainerClass_Gender_label.Name = "trainerClass_Gender_label";
            trainerClass_Gender_label.Size = new Size(52, 15);
            trainerClass_Gender_label.TabIndex = 38;
            trainerClass_Gender_label.Text = "Gender:";
            trainerClass_Gender_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // savePrizeMoney_btn
            // 
            savePrizeMoney_btn.Location = new Point(296, 49);
            savePrizeMoney_btn.Name = "savePrizeMoney_btn";
            savePrizeMoney_btn.Size = new Size(53, 23);
            savePrizeMoney_btn.TabIndex = 33;
            savePrizeMoney_btn.Text = "Save";
            savePrizeMoney_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_PrizeMoney_num
            // 
            trainerClass_PrizeMoney_num.Location = new Point(213, 49);
            trainerClass_PrizeMoney_num.Name = "trainerClass_PrizeMoney_num";
            trainerClass_PrizeMoney_num.Size = new Size(69, 23);
            trainerClass_PrizeMoney_num.TabIndex = 37;
            // 
            // trainerClass_PrizeMoney_label
            // 
            trainerClass_PrizeMoney_label.AutoSize = true;
            trainerClass_PrizeMoney_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_PrizeMoney_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_PrizeMoney_label.Location = new Point(213, 28);
            trainerClass_PrizeMoney_label.Name = "trainerClass_PrizeMoney_label";
            trainerClass_PrizeMoney_label.Size = new Size(79, 15);
            trainerClass_PrizeMoney_label.TabIndex = 36;
            trainerClass_PrizeMoney_label.Text = "Prize Money:";
            trainerClass_PrizeMoney_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(trainerClass_Theme_label);
            panel3.Controls.Add(trainerClass_BattleMusic_label);
            panel3.Controls.Add(trainerClass_battleMusic);
            panel3.Controls.Add(saveClassTheme_btn);
            panel3.Controls.Add(trainerClass_vsGfx_box);
            panel3.Controls.Add(trainerClass_Theme_comboBox);
            panel3.Controls.Add(trainerClass_introGfx_label);
            panel3.Location = new Point(505, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 285);
            panel3.TabIndex = 6;
            // 
            // trainerClass_Theme_label
            // 
            trainerClass_Theme_label.AutoSize = true;
            trainerClass_Theme_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_Theme_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_Theme_label.Location = new Point(106, 235);
            trainerClass_Theme_label.Name = "trainerClass_Theme_label";
            trainerClass_Theme_label.Size = new Size(120, 15);
            trainerClass_Theme_label.TabIndex = 36;
            trainerClass_Theme_label.Text = "Trainer Class Theme:";
            trainerClass_Theme_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_BattleMusic_label
            // 
            trainerClass_BattleMusic_label.AutoSize = true;
            trainerClass_BattleMusic_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_BattleMusic_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_BattleMusic_label.Location = new Point(5, 235);
            trainerClass_BattleMusic_label.Name = "trainerClass_BattleMusic_label";
            trainerClass_BattleMusic_label.Size = new Size(79, 15);
            trainerClass_BattleMusic_label.TabIndex = 35;
            trainerClass_BattleMusic_label.Text = "Battle Music:";
            trainerClass_BattleMusic_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_battleMusic
            // 
            trainerClass_battleMusic.Location = new Point(5, 255);
            trainerClass_battleMusic.Name = "trainerClass_battleMusic";
            trainerClass_battleMusic.ReadOnly = true;
            trainerClass_battleMusic.Size = new Size(82, 23);
            trainerClass_battleMusic.TabIndex = 15;
            // 
            // saveClassTheme_btn
            // 
            saveClassTheme_btn.Location = new Point(208, 255);
            saveClassTheme_btn.Name = "saveClassTheme_btn";
            saveClassTheme_btn.Size = new Size(53, 23);
            saveClassTheme_btn.TabIndex = 33;
            saveClassTheme_btn.Text = "Save";
            saveClassTheme_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_vsGfx_box
            // 
            trainerClass_vsGfx_box.BackColor = Color.White;
            trainerClass_vsGfx_box.BorderStyle = BorderStyle.Fixed3D;
            trainerClass_vsGfx_box.Location = new Point(5, 33);
            trainerClass_vsGfx_box.Name = "trainerClass_vsGfx_box";
            trainerClass_vsGfx_box.Size = new Size(256, 192);
            trainerClass_vsGfx_box.TabIndex = 34;
            trainerClass_vsGfx_box.TabStop = false;
            // 
            // trainerClass_Theme_comboBox
            // 
            trainerClass_Theme_comboBox.FormattingEnabled = true;
            trainerClass_Theme_comboBox.Location = new Point(107, 255);
            trainerClass_Theme_comboBox.Name = "trainerClass_Theme_comboBox";
            trainerClass_Theme_comboBox.Size = new Size(95, 23);
            trainerClass_Theme_comboBox.TabIndex = 33;
            // 
            // trainerClass_introGfx_label
            // 
            trainerClass_introGfx_label.AutoSize = true;
            trainerClass_introGfx_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_introGfx_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_introGfx_label.Location = new Point(5, 12);
            trainerClass_introGfx_label.Name = "trainerClass_introGfx_label";
            trainerClass_introGfx_label.Size = new Size(82, 15);
            trainerClass_introGfx_label.TabIndex = 33;
            trainerClass_introGfx_label.Text = "VS Intro GFX:";
            trainerClass_introGfx_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Used_panel
            // 
            trainerClass_Used_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainerClass_Used_panel.Controls.Add(trainerClass_GoToTrainer_btn);
            trainerClass_Used_panel.Controls.Add(trainerClass_Uses_list);
            trainerClass_Used_panel.Controls.Add(trainerClassUse_label);
            trainerClass_Used_panel.Location = new Point(209, 174);
            trainerClass_Used_panel.Name = "trainerClass_Used_panel";
            trainerClass_Used_panel.Size = new Size(289, 285);
            trainerClass_Used_panel.TabIndex = 4;
            // 
            // trainerClass_GoToTrainer_btn
            // 
            trainerClass_GoToTrainer_btn.Location = new Point(139, 8);
            trainerClass_GoToTrainer_btn.Name = "trainerClass_GoToTrainer_btn";
            trainerClass_GoToTrainer_btn.Size = new Size(85, 23);
            trainerClass_GoToTrainer_btn.TabIndex = 35;
            trainerClass_GoToTrainer_btn.Text = "Go To Trainer";
            trainerClass_GoToTrainer_btn.UseVisualStyleBackColor = true;
            trainerClass_GoToTrainer_btn.Click += trainerClass_GoToTrainer_btn_Click;
            // 
            // trainerClass_Uses_list
            // 
            trainerClass_Uses_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            trainerClass_Uses_list.FormattingEnabled = true;
            trainerClass_Uses_list.ItemHeight = 15;
            trainerClass_Uses_list.Location = new Point(5, 38);
            trainerClass_Uses_list.Name = "trainerClass_Uses_list";
            trainerClass_Uses_list.Size = new Size(219, 244);
            trainerClass_Uses_list.TabIndex = 27;
            trainerClass_Uses_list.SelectedIndexChanged += trainerClass_Uses_list_SelectedIndexChanged;
            // 
            // trainerClassUse_label
            // 
            trainerClassUse_label.AutoSize = true;
            trainerClassUse_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassUse_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassUse_label.Location = new Point(5, 12);
            trainerClassUse_label.Name = "trainerClassUse_label";
            trainerClassUse_label.Size = new Size(117, 15);
            trainerClassUse_label.TabIndex = 28;
            trainerClassUse_label.Text = "Trainers Using Class:";
            trainerClassUse_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Info_panel
            // 
            trainerClass_Info_panel.Controls.Add(saveClassName_btn);
            trainerClass_Info_panel.Controls.Add(trainerClass_Gender_label);
            trainerClass_Info_panel.Controls.Add(saveGender_btn);
            trainerClass_Info_panel.Controls.Add(trainerClassName);
            trainerClass_Info_panel.Controls.Add(trainerClass_Gender_comboBox);
            trainerClass_Info_panel.Controls.Add(trainerClassName_Label);
            trainerClass_Info_panel.Location = new Point(209, 3);
            trainerClass_Info_panel.Name = "trainerClass_Info_panel";
            trainerClass_Info_panel.Size = new Size(358, 69);
            trainerClass_Info_panel.TabIndex = 2;
            // 
            // saveClassName_btn
            // 
            saveClassName_btn.Location = new Point(139, 34);
            saveClassName_btn.Name = "saveClassName_btn";
            saveClassName_btn.Size = new Size(53, 23);
            saveClassName_btn.TabIndex = 12;
            saveClassName_btn.Text = "Save";
            saveClassName_btn.UseVisualStyleBackColor = true;
            saveClassName_btn.Click += saveClassName_btn_Click;
            // 
            // trainerClassName
            // 
            trainerClassName.AllowDrop = true;
            trainerClassName.Location = new Point(5, 34);
            trainerClassName.Name = "trainerClassName";
            trainerClassName.Size = new Size(128, 23);
            trainerClassName.TabIndex = 11;
            // 
            // trainerClassName_Label
            // 
            trainerClassName_Label.AutoSize = true;
            trainerClassName_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassName_Label.Location = new Point(5, 12);
            trainerClassName_Label.Name = "trainerClassName_Label";
            trainerClassName_Label.Size = new Size(114, 15);
            trainerClassName_Label.TabIndex = 10;
            trainerClassName_Label.Text = "Trainer Class Name:";
            trainerClassName_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Spite_Panel
            // 
            trainerClass_Spite_Panel.Controls.Add(trainerClass_frames_num);
            trainerClass_Spite_Panel.Controls.Add(trainerClass_frames_label);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPicBox);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPic_label);
            trainerClass_Spite_Panel.Location = new Point(573, 3);
            trainerClass_Spite_Panel.Name = "trainerClass_Spite_Panel";
            trainerClass_Spite_Panel.Size = new Size(200, 179);
            trainerClass_Spite_Panel.TabIndex = 1;
            // 
            // trainerClass_frames_num
            // 
            trainerClass_frames_num.Location = new Point(140, 145);
            trainerClass_frames_num.Name = "trainerClass_frames_num";
            trainerClass_frames_num.Size = new Size(53, 23);
            trainerClass_frames_num.TabIndex = 38;
            // 
            // trainerClass_frames_label
            // 
            trainerClass_frames_label.AutoSize = true;
            trainerClass_frames_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_frames_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_frames_label.Location = new Point(84, 147);
            trainerClass_frames_label.Name = "trainerClass_frames_label";
            trainerClass_frames_label.Size = new Size(50, 15);
            trainerClass_frames_label.TabIndex = 28;
            trainerClass_frames_label.Text = "Frames:";
            trainerClass_frames_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClassPicBox
            // 
            trainerClassPicBox.BackColor = Color.White;
            trainerClassPicBox.BorderStyle = BorderStyle.Fixed3D;
            trainerClassPicBox.Location = new Point(5, 34);
            trainerClassPicBox.Name = "trainerClassPicBox";
            trainerClassPicBox.Size = new Size(188, 107);
            trainerClassPicBox.TabIndex = 26;
            trainerClassPicBox.TabStop = false;
            // 
            // trainerClassPic_label
            // 
            trainerClassPic_label.AutoSize = true;
            trainerClassPic_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassPic_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassPic_label.Location = new Point(5, 12);
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
            trainerClassListBox.Location = new Point(5, 119);
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
            player_trainer_class.Location = new Point(5, 34);
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
            mainContent_trainer.Controls.Add(panel7);
            mainContent_trainer.Controls.Add(panel6);
            mainContent_trainer.Controls.Add(panel5);
            mainContent_trainer.Location = new Point(4, 24);
            mainContent_trainer.Name = "mainContent_trainer";
            mainContent_trainer.Padding = new Padding(3);
            mainContent_trainer.Size = new Size(776, 462);
            mainContent_trainer.TabIndex = 1;
            mainContent_trainer.Text = "Trainers";
            mainContent_trainer.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(trainer_GoToClass_btn);
            panel6.Controls.Add(save_TrainerClass_btn);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(trainer_Class_comboBox);
            panel6.Controls.Add(numericUpDown1);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(trainerPicBox);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(573, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 258);
            panel6.TabIndex = 2;
            // 
            // trainer_GoToClass_btn
            // 
            trainer_GoToClass_btn.Location = new Point(5, 222);
            trainer_GoToClass_btn.Name = "trainer_GoToClass_btn";
            trainer_GoToClass_btn.Size = new Size(188, 23);
            trainer_GoToClass_btn.TabIndex = 42;
            trainer_GoToClass_btn.Text = "Go To Trainer Class";
            trainer_GoToClass_btn.UseVisualStyleBackColor = true;
            // 
            // save_TrainerClass_btn
            // 
            save_TrainerClass_btn.Location = new Point(140, 192);
            save_TrainerClass_btn.Name = "save_TrainerClass_btn";
            save_TrainerClass_btn.Size = new Size(53, 23);
            save_TrainerClass_btn.TabIndex = 41;
            save_TrainerClass_btn.Text = "Save";
            save_TrainerClass_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(5, 175);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 40;
            label5.Text = "Trainer Class:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Class_comboBox
            // 
            trainer_Class_comboBox.FormattingEnabled = true;
            trainer_Class_comboBox.Location = new Point(5, 193);
            trainer_Class_comboBox.Name = "trainer_Class_comboBox";
            trainer_Class_comboBox.Size = new Size(129, 23);
            trainer_Class_comboBox.TabIndex = 39;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(140, 145);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(84, 147);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 28;
            label3.Text = "Frames:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerPicBox
            // 
            trainerPicBox.BackColor = Color.White;
            trainerPicBox.BorderStyle = BorderStyle.Fixed3D;
            trainerPicBox.Location = new Point(5, 35);
            trainerPicBox.Name = "trainerPicBox";
            trainerPicBox.Size = new Size(188, 107);
            trainerPicBox.TabIndex = 26;
            trainerPicBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(5, 12);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 27;
            label4.Text = "Trainer Class Sprite:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(trainers_list);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(trainers_Player_list);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 456);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(5, 98);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Trainers:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainers_list
            // 
            trainers_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainers_list.FormattingEnabled = true;
            trainers_list.ItemHeight = 15;
            trainers_list.Location = new Point(5, 119);
            trainers_list.Name = "trainers_list";
            trainers_list.Size = new Size(190, 334);
            trainers_list.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Player:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainers_Player_list
            // 
            trainers_Player_list.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainers_Player_list.Enabled = false;
            trainers_Player_list.FormattingEnabled = true;
            trainers_Player_list.ItemHeight = 15;
            trainers_Player_list.Location = new Point(5, 34);
            trainers_Player_list.Name = "trainers_Player_list";
            trainers_Player_list.Size = new Size(190, 49);
            trainers_Player_list.TabIndex = 4;
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
            // quick_toolstrip
            // 
            quick_toolstrip.Dock = DockStyle.Fill;
            quick_toolstrip.GripStyle = ToolStripGripStyle.Hidden;
            quick_toolstrip.Items.AddRange(new ToolStripItem[] { openRom_btn, openFolder_btn, save_btn, exportNarc_btn, toolStripSeparator1, languageLabel, versionLabel, romNameLabel, toolStripSeparator2 });
            quick_toolstrip.Location = new Point(0, 0);
            quick_toolstrip.Name = "quick_toolstrip";
            quick_toolstrip.Size = new Size(784, 25);
            quick_toolstrip.TabIndex = 4;
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
            // panel1
            // 
            panel1.Controls.Add(quick_toolstrip);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 25);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(mainContent);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 490);
            panel2.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(save_TrainerName_btn);
            panel7.Controls.Add(trainer_Name);
            panel7.Controls.Add(trainer_Name_Label);
            panel7.Location = new Point(209, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(358, 69);
            panel7.TabIndex = 3;
            // 
            // save_TrainerName_btn
            // 
            save_TrainerName_btn.Location = new Point(139, 34);
            save_TrainerName_btn.Name = "save_TrainerName_btn";
            save_TrainerName_btn.Size = new Size(53, 23);
            save_TrainerName_btn.TabIndex = 12;
            save_TrainerName_btn.Text = "Save";
            save_TrainerName_btn.UseVisualStyleBackColor = true;
            // 
            // trainer_Name
            // 
            trainer_Name.AllowDrop = true;
            trainer_Name.Location = new Point(5, 34);
            trainer_Name.Name = "trainer_Name";
            trainer_Name.Size = new Size(128, 23);
            trainer_Name.TabIndex = 11;
            // 
            // trainer_Name_Label
            // 
            trainer_Name_Label.AutoSize = true;
            trainer_Name_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainer_Name_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainer_Name_Label.Location = new Point(5, 12);
            trainer_Name_Label.Name = "trainer_Name_Label";
            trainer_Name_Label.Size = new Size(85, 15);
            trainer_Name_Label.TabIndex = 10;
            trainer_Name_Label.Text = "Trainer Name:";
            trainer_Name_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(main_toolstrip);
            MainMenuStrip = main_toolstrip;
            Name = "Mainform";
            Text = "VS-Maker";
            main_toolstrip.ResumeLayout(false);
            main_toolstrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainContent.ResumeLayout(false);
            mainContent_trainerClass.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_PrizeMoney_num).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_vsGfx_box).EndInit();
            trainerClass_Used_panel.ResumeLayout(false);
            trainerClass_Used_panel.PerformLayout();
            trainerClass_Info_panel.ResumeLayout(false);
            trainerClass_Info_panel.PerformLayout();
            trainerClass_Spite_Panel.ResumeLayout(false);
            trainerClass_Spite_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_frames_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerClassPicBox).EndInit();
            trainerClass_List_panel.ResumeLayout(false);
            trainerClass_List_panel.PerformLayout();
            mainContent_trainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerPicBox).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            quick_toolstrip.ResumeLayout(false);
            quick_toolstrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private ToolStripMenuItem mainToolStrip_help;
        private ToolStripMenuItem about_toolstrip;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private TabControl mainContent;
        private TabPage mainContent_trainer;
        private TabPage mainContent_trainerText;
        private Label eyeContactMusic_Label;
        private TabPage mainContent_trainerClass;
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
        private NumericUpDown eyeContactAlt_num;
        private NumericUpDown eyeContactMain_num;
        private Button saveClassName_btn;
        private TextBox trainerClassName;
        private Label trainerClassName_Label;
        private PictureBox trainerClassPicBox;
        private Label trainerClassPic_label;
        private ToolStrip quick_toolstrip;
        private ToolStripButton openRom_btn;
        private ToolStripButton openFolder_btn;
        private ToolStripButton save_btn;
        private ToolStripButton exportNarc_btn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel languageLabel;
        private ToolStripLabel versionLabel;
        private ToolStripLabel romNameLabel;
        private ToolStripSeparator toolStripSeparator2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox trainerClass_vsGfx_box;
        private ComboBox trainerClass_Theme_comboBox;
        private Label trainerClass_introGfx_label;
        private Button saveClassTheme_btn;
        private Button trainerClass_GoToTrainer_btn;
        private Panel panel4;
        private Label trainerClass_frames_label;
        private Button savePrizeMoney_btn;
        private NumericUpDown trainerClass_PrizeMoney_num;
        private Label trainerClass_PrizeMoney_label;
        private Button trainerClass_PrizeMoney_btn;
        private Button saveGender_btn;
        private ComboBox trainerClass_Gender_comboBox;
        private Label trainerClass_Gender_label;
        private ComboBox trainerClass_EyeContactMain_comboBox;
        private Button saveEyeContact_btn;
        private ComboBox trainerClass_EyeContactAlt_comboBox;
        private Label trainerClass_EyeContactMusic_Main_label;
        private Label trainerClass_Theme_label;
        private Label trainerClass_BattleMusic_label;
        private TextBox trainerClass_battleMusic;
        private NumericUpDown trainerClass_frames_num;
        private Panel panel5;
        private Label label2;
        private ListBox trainers_list;
        private Label label1;
        private ListBox trainers_Player_list;
        private Panel panel6;
        private Button trainer_GoToClass_btn;
        private Button save_TrainerClass_btn;
        private Label label5;
        private ComboBox trainer_Class_comboBox;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private PictureBox trainerPicBox;
        private Label label4;
        private Panel panel7;
        private Button save_TrainerName_btn;
        private TextBox trainer_Name;
        private Label trainer_Name_Label;
    }
}