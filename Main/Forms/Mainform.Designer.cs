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
            statusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            mainContent = new TabControl();
            mainContent_trainerClass = new TabPage();
            panel4 = new Panel();
            trainerClass_PrizeMoney_btn = new Button();
            button5 = new Button();
            comboBox6 = new ComboBox();
            trainerClass_Gender_label = new Label();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            trainerClass_PrizeMoney_label = new Label();
            panel3 = new Panel();
            button3 = new Button();
            trainerClass_vsGfx_box = new PictureBox();
            button2 = new Button();
            comboBox4 = new ComboBox();
            trainerClass_introGfx_label = new Label();
            trainerClass_Used_panel = new Panel();
            trainerClass_GoToTrainer_btn = new Button();
            trainerClass_Uses_list = new ListBox();
            trainerClassUse_label = new Label();
            trainerClass_Music_panel = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            trainerClass_EyeContactMusic_Main_label = new Label();
            trainerClass_Info_panel = new Panel();
            trainerClassIdDisplay = new TextBox();
            saveClassName_btn = new Button();
            trainerClassId_Label = new Label();
            trainerClassName = new TextBox();
            trainerClassName_Label = new Label();
            trainerClass_Spite_Panel = new Panel();
            comboBox5 = new ComboBox();
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
            main_toolstrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainContent.SuspendLayout();
            mainContent_trainerClass.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_vsGfx_box).BeginInit();
            trainerClass_Used_panel.SuspendLayout();
            trainerClass_Music_panel.SuspendLayout();
            trainerClass_Info_panel.SuspendLayout();
            trainerClass_Spite_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClassPicBox).BeginInit();
            trainerClass_List_panel.SuspendLayout();
            quick_toolstrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Margin = new Padding(15, 0, 0, 2);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
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
            // panel4
            // 
            panel4.Controls.Add(trainerClass_PrizeMoney_btn);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(comboBox6);
            panel4.Controls.Add(trainerClass_Gender_label);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(trainerClass_PrizeMoney_label);
            panel4.Location = new Point(209, 147);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 71);
            panel4.TabIndex = 7;
            // 
            // trainerClass_PrizeMoney_btn
            // 
            trainerClass_PrizeMoney_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainerClass_PrizeMoney_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_PrizeMoney_btn.Location = new Point(109, 7);
            trainerClass_PrizeMoney_btn.Name = "trainerClass_PrizeMoney_btn";
            trainerClass_PrizeMoney_btn.Size = new Size(24, 24);
            trainerClass_PrizeMoney_btn.TabIndex = 5;
            trainerClass_PrizeMoney_btn.Text = "?";
            trainerClass_PrizeMoney_btn.UseVisualStyleBackColor = true;
            trainerClass_PrizeMoney_btn.Click += trainerClass_PrizeMoney_btn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(296, 36);
            button5.Name = "button5";
            button5.Size = new Size(53, 23);
            button5.TabIndex = 39;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(147, 36);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(142, 23);
            comboBox6.TabIndex = 33;
            // 
            // trainerClass_Gender_label
            // 
            trainerClass_Gender_label.AutoSize = true;
            trainerClass_Gender_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_Gender_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_Gender_label.Location = new Point(147, 12);
            trainerClass_Gender_label.Name = "trainerClass_Gender_label";
            trainerClass_Gender_label.Size = new Size(52, 15);
            trainerClass_Gender_label.TabIndex = 38;
            trainerClass_Gender_label.Text = "Gender:";
            trainerClass_Gender_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            button4.Location = new Point(80, 36);
            button4.Name = "button4";
            button4.Size = new Size(53, 23);
            button4.TabIndex = 33;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(5, 36);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 37;
            // 
            // trainerClass_PrizeMoney_label
            // 
            trainerClass_PrizeMoney_label.AutoSize = true;
            trainerClass_PrizeMoney_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_PrizeMoney_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_PrizeMoney_label.Location = new Point(5, 12);
            trainerClass_PrizeMoney_label.Name = "trainerClass_PrizeMoney_label";
            trainerClass_PrizeMoney_label.Size = new Size(79, 15);
            trainerClass_PrizeMoney_label.TabIndex = 36;
            trainerClass_PrizeMoney_label.Text = "Prize Money:";
            trainerClass_PrizeMoney_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(trainerClass_vsGfx_box);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(trainerClass_introGfx_label);
            panel3.Location = new Point(505, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 235);
            panel3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(210, 9);
            button3.Name = "button3";
            button3.Size = new Size(53, 23);
            button3.TabIndex = 33;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // trainerClass_vsGfx_box
            // 
            trainerClass_vsGfx_box.BackColor = Color.White;
            trainerClass_vsGfx_box.BorderStyle = BorderStyle.Fixed3D;
            trainerClass_vsGfx_box.Location = new Point(5, 40);
            trainerClass_vsGfx_box.Name = "trainerClass_vsGfx_box";
            trainerClass_vsGfx_box.Size = new Size(256, 192);
            trainerClass_vsGfx_box.TabIndex = 34;
            trainerClass_vsGfx_box.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(296, 22);
            button2.Name = "button2";
            button2.Size = new Size(53, 23);
            button2.TabIndex = 33;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(87, 9);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(108, 23);
            comboBox4.TabIndex = 33;
            // 
            // trainerClass_introGfx_label
            // 
            trainerClass_introGfx_label.AutoSize = true;
            trainerClass_introGfx_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_introGfx_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_introGfx_label.Location = new Point(5, 15);
            trainerClass_introGfx_label.Name = "trainerClass_introGfx_label";
            trainerClass_introGfx_label.Size = new Size(76, 15);
            trainerClass_introGfx_label.TabIndex = 33;
            trainerClass_introGfx_label.Text = "VS Graphics:";
            trainerClass_introGfx_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Used_panel
            // 
            trainerClass_Used_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainerClass_Used_panel.Controls.Add(trainerClass_GoToTrainer_btn);
            trainerClass_Used_panel.Controls.Add(trainerClass_Uses_list);
            trainerClass_Used_panel.Controls.Add(trainerClassUse_label);
            trainerClass_Used_panel.Location = new Point(209, 224);
            trainerClass_Used_panel.Name = "trainerClass_Used_panel";
            trainerClass_Used_panel.Size = new Size(290, 235);
            trainerClass_Used_panel.TabIndex = 4;
            // 
            // trainerClass_GoToTrainer_btn
            // 
            trainerClass_GoToTrainer_btn.Location = new Point(202, 33);
            trainerClass_GoToTrainer_btn.Name = "trainerClass_GoToTrainer_btn";
            trainerClass_GoToTrainer_btn.Size = new Size(85, 23);
            trainerClass_GoToTrainer_btn.TabIndex = 35;
            trainerClass_GoToTrainer_btn.Text = "Go To Trainer";
            trainerClass_GoToTrainer_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_Uses_list
            // 
            trainerClass_Uses_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            trainerClass_Uses_list.FormattingEnabled = true;
            trainerClass_Uses_list.ItemHeight = 15;
            trainerClass_Uses_list.Location = new Point(5, 33);
            trainerClass_Uses_list.Name = "trainerClass_Uses_list";
            trainerClass_Uses_list.Size = new Size(190, 199);
            trainerClass_Uses_list.TabIndex = 27;
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
            // trainerClass_Music_panel
            // 
            trainerClass_Music_panel.Controls.Add(comboBox1);
            trainerClass_Music_panel.Controls.Add(button1);
            trainerClass_Music_panel.Controls.Add(comboBox3);
            trainerClass_Music_panel.Controls.Add(comboBox2);
            trainerClass_Music_panel.Controls.Add(label1);
            trainerClass_Music_panel.Controls.Add(trainerClass_EyeContactMusic_Main_label);
            trainerClass_Music_panel.Location = new Point(209, 78);
            trainerClass_Music_panel.Name = "trainerClass_Music_panel";
            trainerClass_Music_panel.Size = new Size(358, 63);
            trainerClass_Music_panel.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 23);
            comboBox1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(296, 36);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 31;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(72, 36);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(61, 23);
            comboBox3.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(147, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(147, 12);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 27;
            label1.Text = "In-Battle Theme:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_EyeContactMusic_Main_label
            // 
            trainerClass_EyeContactMusic_Main_label.AutoSize = true;
            trainerClass_EyeContactMusic_Main_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_EyeContactMusic_Main_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_EyeContactMusic_Main_label.Location = new Point(5, 12);
            trainerClass_EyeContactMusic_Main_label.Name = "trainerClass_EyeContactMusic_Main_label";
            trainerClass_EyeContactMusic_Main_label.Size = new Size(115, 15);
            trainerClass_EyeContactMusic_Main_label.TabIndex = 25;
            trainerClass_EyeContactMusic_Main_label.Text = "Eye-Contact  Music:";
            trainerClass_EyeContactMusic_Main_label.TextAlign = ContentAlignment.MiddleLeft;
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
            trainerClass_Info_panel.Size = new Size(358, 69);
            trainerClass_Info_panel.TabIndex = 2;
            // 
            // trainerClassIdDisplay
            // 
            trainerClassIdDisplay.Location = new Point(5, 36);
            trainerClassIdDisplay.Name = "trainerClassIdDisplay";
            trainerClassIdDisplay.ReadOnly = true;
            trainerClassIdDisplay.Size = new Size(96, 23);
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
            trainerClassId_Label.Location = new Point(5, 12);
            trainerClassId_Label.Name = "trainerClassId_Label";
            trainerClassId_Label.Size = new Size(94, 15);
            trainerClassId_Label.TabIndex = 13;
            trainerClassId_Label.Text = "Trainer Class ID:";
            trainerClassId_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClassName
            // 
            trainerClassName.AllowDrop = true;
            trainerClassName.Location = new Point(147, 36);
            trainerClassName.Name = "trainerClassName";
            trainerClassName.Size = new Size(142, 23);
            trainerClassName.TabIndex = 11;
            // 
            // trainerClassName_Label
            // 
            trainerClassName_Label.AutoSize = true;
            trainerClassName_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassName_Label.Location = new Point(147, 12);
            trainerClassName_Label.Name = "trainerClassName_Label";
            trainerClassName_Label.Size = new Size(114, 15);
            trainerClassName_Label.TabIndex = 10;
            trainerClassName_Label.Text = "Trainer Class Name:";
            trainerClassName_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Spite_Panel
            // 
            trainerClass_Spite_Panel.Controls.Add(comboBox5);
            trainerClass_Spite_Panel.Controls.Add(trainerClass_frames_label);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPicBox);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPic_label);
            trainerClass_Spite_Panel.Location = new Point(573, 3);
            trainerClass_Spite_Panel.Name = "trainerClass_Spite_Panel";
            trainerClass_Spite_Panel.Size = new Size(200, 200);
            trainerClass_Spite_Panel.TabIndex = 1;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(142, 167);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(50, 23);
            comboBox5.TabIndex = 35;
            // 
            // trainerClass_frames_label
            // 
            trainerClass_frames_label.AutoSize = true;
            trainerClass_frames_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_frames_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_frames_label.Location = new Point(142, 149);
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
            trainerClassPicBox.Location = new Point(5, 35);
            trainerClassPicBox.Name = "trainerClassPicBox";
            trainerClassPicBox.Size = new Size(190, 109);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClass_vsGfx_box).EndInit();
            trainerClass_Used_panel.ResumeLayout(false);
            trainerClass_Used_panel.PerformLayout();
            trainerClass_Music_panel.ResumeLayout(false);
            trainerClass_Music_panel.PerformLayout();
            trainerClass_Info_panel.ResumeLayout(false);
            trainerClass_Info_panel.PerformLayout();
            trainerClass_Spite_Panel.ResumeLayout(false);
            trainerClass_Spite_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerClassPicBox).EndInit();
            trainerClass_List_panel.ResumeLayout(false);
            trainerClass_List_panel.PerformLayout();
            quick_toolstrip.ResumeLayout(false);
            quick_toolstrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private TextBox trainerClassIdDisplay;
        private Button saveClassName_btn;
        private Label trainerClassId_Label;
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
        private Panel trainerClass_Music_panel;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label1;
        private Label trainerClass_EyeContactMusic_Main_label;
        private ComboBox comboBox1;
        private Panel panel3;
        private PictureBox trainerClass_vsGfx_box;
        private Button button2;
        private ComboBox comboBox4;
        private Label trainerClass_introGfx_label;
        private Button button3;
        private Button button1;
        private Button trainerClass_GoToTrainer_btn;
        private Panel panel4;
        private Label trainerClass_frames_label;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Label trainerClass_PrizeMoney_label;
        private ComboBox comboBox5;
        private Button trainerClass_PrizeMoney_btn;
        private Button button5;
        private ComboBox comboBox6;
        private Label trainerClass_Gender_label;
    }
}