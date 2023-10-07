using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace VSMaker
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            main_toolstrip = new MenuStrip();
            mainToolStrip_file = new ToolStripMenuItem();
            openRom_toolstrip = new ToolStripMenuItem();
            openFolder_toolstrip = new ToolStripMenuItem();
            save_toolstrip = new ToolStripMenuItem();
            mainToolStrip_help = new ToolStripMenuItem();
            about_toolstrip = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            mainContent = new TabControl();
            mainContent_trainerClass = new TabPage();
            panel4 = new Panel();
            label21 = new Label();
            label20 = new Label();
            saveClassProperties_btn = new Button();
            trainerClass_Gender_label = new Label();
            trainerClass_EyeContactMain_comboBox = new ComboBox();
            trainerClass_EyeContactAlt_comboBox = new ComboBox();
            trainerClass_PrizeMoney_btn = new Button();
            trainerClass_Gender_comboBox = new ComboBox();
            trainerClass_PrizeMoney_num = new NumericUpDown();
            trainerClass_EyeContactMusic_Main_label = new Label();
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
            undoTrainerClass_btn = new Button();
            saveTrainerClassAll_btn = new Button();
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
            mainContent_trainer = new TabPage();
            panel9 = new Panel();
            trainer_MessageTrigger_list = new ComboBox();
            panel21 = new Panel();
            trainer_Message = new Label();
            trainer_Message_Back_btn = new Button();
            trainer_Message_Next_btn = new Button();
            trainer_EditMessage_btn = new Button();
            label6 = new Label();
            panel8 = new Panel();
            trainerEditor_tab = new TabControl();
            trainerEditor_Pokemon = new TabPage();
            panel10 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            pictureBox5 = new PictureBox();
            trainer_Poke6_Item = new ComboBox();
            trainer_Poke6_Moves_btn = new Button();
            label11 = new Label();
            trainer_Poke6_Level = new NumericUpDown();
            trainer_Poke6_comboBox = new ComboBox();
            trainer_Poke6_Stats_btn = new Button();
            pictureBox6 = new PictureBox();
            trainer_Poke5_Item = new ComboBox();
            trainer_Poke5_Moves_btn = new Button();
            label12 = new Label();
            trainer_Poke5_Level = new NumericUpDown();
            trainer_Poke5_comboBox = new ComboBox();
            trainer_Poke5_Stats_btn = new Button();
            pictureBox7 = new PictureBox();
            trainer_Poke4_Item = new ComboBox();
            trainer_Poke4_Moves_btn = new Button();
            label13 = new Label();
            trainer_Poke4_Level = new NumericUpDown();
            trainer_Poke4_comboBox = new ComboBox();
            trainer_Poke4_Stats_btn = new Button();
            pictureBox4 = new PictureBox();
            trainer_Poke3_Item = new ComboBox();
            trainer_Poke3_Moves_btn = new Button();
            label10 = new Label();
            trainer_Poke3_Level = new NumericUpDown();
            trainer_Poke3_comboBox = new ComboBox();
            trainer_Poke3_Stats_btn = new Button();
            pictureBox3 = new PictureBox();
            trainer_Poke2_Item = new ComboBox();
            trainer_Poke2_Moves_btn = new Button();
            label9 = new Label();
            trainer_Poke2_Level = new NumericUpDown();
            trainer_Poke2_comboBox = new ComboBox();
            trainer_Poke2_Stats_btn = new Button();
            pictureBox2 = new PictureBox();
            trainer_Poke1_Item = new ComboBox();
            trainer_Poke1_Moves_btn = new Button();
            label8 = new Label();
            trainer_Poke1_Level = new NumericUpDown();
            trainer_Poke1_comboBox = new ComboBox();
            trainer_Poke1_Stats_btn = new Button();
            panel11 = new Panel();
            trainer_Poke_Num_pic = new PictureBox();
            trainer_Poke_Moves_checkBox = new CheckBox();
            trainer_Poke_HeldItem_checkBox = new CheckBox();
            trainer_Double_checkBox = new CheckBox();
            saveTrainerPoke_btn = new Button();
            label7 = new Label();
            trainer_NumPoke_num = new NumericUpDown();
            trainerEditor_trnProperties = new TabPage();
            panel12 = new Panel();
            panel18 = new Panel();
            saveTrainerProperties_btn = new Button();
            panel7 = new Panel();
            undoTrainer_btn = new Button();
            saveTrainerAll_btn = new Button();
            save_TrainerName_btn = new Button();
            trainer_Name = new TextBox();
            trainer_Name_Label = new Label();
            panel6 = new Panel();
            trainer_GoToClass_btn = new Button();
            save_TrainerClass_btn = new Button();
            label5 = new Label();
            trainer_Class_comboBox = new ComboBox();
            trainer_frames_num = new NumericUpDown();
            label3 = new Label();
            trainerPicBox = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            trainer_Player_help_btn = new Button();
            label2 = new Label();
            trainers_list = new ListBox();
            label1 = new Label();
            trainers_Player_list = new ListBox();
            mainContent_trainerText = new TabPage();
            panel17 = new Panel();
            panel16 = new Panel();
            panel15 = new Panel();
            trainerTextTable_help_label = new Label();
            trainerTextTable_dataGrid = new DataGridView();
            MessageId = new DataGridViewTextBoxColumn();
            TrainerId = new DataGridViewComboBoxColumn();
            MessageTriggerId = new DataGridViewComboBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            trainerText_toolstrip = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            trainreText_Import_btn = new ToolStripButton();
            trainerText_Export_btn = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            trainerTextTable_addRow_btn = new ToolStripButton();
            trainerTextTable_delRow_btn = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            trainerText_sort = new ToolStripButton();
            mainContent_trainerTheme = new TabPage();
            panel14 = new Panel();
            button10 = new Button();
            comboBox8 = new ComboBox();
            label17 = new Label();
            comboBox7 = new ComboBox();
            label18 = new Label();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            panel13 = new Panel();
            label15 = new Label();
            listBox1 = new ListBox();
            trainerMessageBindingSource2 = new BindingSource(components);
            trainerMessageBindingSource = new BindingSource(components);
            quick_toolstrip = new ToolStrip();
            openRom_btn = new ToolStripButton();
            openFolder_btn = new ToolStripButton();
            save_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            languageLabel = new ToolStripLabel();
            versionLabel = new ToolStripLabel();
            romNameLabel = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            panel1 = new Panel();
            panel2 = new Panel();
            saveFileDialog1 = new SaveFileDialog();
            trainerMessageBindingSource1 = new BindingSource(components);
            trainerMessageBindingSource3 = new BindingSource(components);
            label14 = new Label();
            trainer_ai_Basic_checkbox = new CheckBox();
            trainer_ai_evaluate_checkBox = new CheckBox();
            trainer_ai_expert_checkBox = new CheckBox();
            trainer_ai_status_checkBox = new CheckBox();
            trainer_ai_misc_checkBox = new CheckBox();
            trainer_ai_baton_checkBox = new CheckBox();
            trainer_ai_dmg_checkBox = new CheckBox();
            trainer_ai_risk_checkBox = new CheckBox();
            trainer_ai_tag_checkBox = new CheckBox();
            trainer_ai_weather_checkBox = new CheckBox();
            trainer_ai_checkHp_checkBox = new CheckBox();
            label19 = new Label();
            trainer_Item1_comboBox = new ComboBox();
            trainer_Item2_comboBox = new ComboBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            trainer_Item4_comboBox = new ComboBox();
            trainer_Item3_comboBox = new ComboBox();
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
            panel9.SuspendLayout();
            panel21.SuspendLayout();
            panel8.SuspendLayout();
            trainerEditor_tab.SuspendLayout();
            trainerEditor_Pokemon.SuspendLayout();
            panel10.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke6_Level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke5_Level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke4_Level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke3_Level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke2_Level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke1_Level).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke_Num_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_NumPoke_num).BeginInit();
            trainerEditor_trnProperties.SuspendLayout();
            panel12.SuspendLayout();
            panel18.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainer_frames_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerPicBox).BeginInit();
            panel5.SuspendLayout();
            mainContent_trainerText.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerTextTable_dataGrid).BeginInit();
            trainerText_toolstrip.SuspendLayout();
            mainContent_trainerTheme.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource).BeginInit();
            quick_toolstrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // main_toolstrip
            // 
            main_toolstrip.ImageScalingSize = new Size(24, 24);
            main_toolstrip.Items.AddRange(new ToolStripItem[] { mainToolStrip_file, mainToolStrip_help });
            main_toolstrip.Location = new Point(0, 0);
            main_toolstrip.Name = "main_toolstrip";
            main_toolstrip.Size = new Size(899, 24);
            main_toolstrip.TabIndex = 0;
            main_toolstrip.Text = "menuStrip1";
            // 
            // mainToolStrip_file
            // 
            mainToolStrip_file.DropDownItems.AddRange(new ToolStripItem[] { openRom_toolstrip, openFolder_toolstrip, save_toolstrip });
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
            save_toolstrip.Click += save_toolstrip_Click;
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
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 566);
            statusStrip1.Margin = new Padding(15, 0, 0, 2);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(899, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
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
            mainContent.Controls.Add(mainContent_trainerTheme);
            mainContent.Dock = DockStyle.Fill;
            mainContent.Enabled = false;
            mainContent.Location = new Point(0, 0);
            mainContent.Margin = new Padding(10);
            mainContent.Name = "mainContent";
            mainContent.SelectedIndex = 0;
            mainContent.Size = new Size(899, 517);
            mainContent.TabIndex = 3;
            mainContent.Visible = false;
            mainContent.SelectedIndexChanged += mainContent_SelectedIndexChanged;
            mainContent.Selecting += mainContent_Selecting;
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
            mainContent_trainerClass.Size = new Size(891, 489);
            mainContent_trainerClass.TabIndex = 3;
            mainContent_trainerClass.Text = "Trainer Class";
            mainContent_trainerClass.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(saveClassProperties_btn);
            panel4.Controls.Add(trainerClass_Gender_label);
            panel4.Controls.Add(trainerClass_EyeContactMain_comboBox);
            panel4.Controls.Add(trainerClass_EyeContactAlt_comboBox);
            panel4.Controls.Add(trainerClass_PrizeMoney_btn);
            panel4.Controls.Add(trainerClass_Gender_comboBox);
            panel4.Controls.Add(trainerClass_PrizeMoney_num);
            panel4.Controls.Add(trainerClass_EyeContactMusic_Main_label);
            panel4.Controls.Add(trainerClass_PrizeMoney_label);
            panel4.Location = new Point(209, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 109);
            panel4.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ImageAlign = ContentAlignment.MiddleLeft;
            label21.Location = new Point(7, 75);
            label21.Name = "label21";
            label21.Size = new Size(104, 15);
            label21.TabIndex = 41;
            label21.Text = "Eye-Contact [Alt]:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ImageAlign = ContentAlignment.MiddleLeft;
            label20.Location = new Point(7, 43);
            label20.Name = "label20";
            label20.Size = new Size(112, 15);
            label20.TabIndex = 40;
            label20.Text = "Eye-Contact [Main]";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveClassProperties_btn
            // 
            saveClassProperties_btn.Image = Properties.Resources.saveIconSm;
            saveClassProperties_btn.Location = new Point(412, 8);
            saveClassProperties_btn.Name = "saveClassProperties_btn";
            saveClassProperties_btn.Size = new Size(56, 23);
            saveClassProperties_btn.TabIndex = 39;
            saveClassProperties_btn.Text = "Save";
            saveClassProperties_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveClassProperties_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_Gender_label
            // 
            trainerClass_Gender_label.AutoSize = true;
            trainerClass_Gender_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_Gender_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_Gender_label.Location = new Point(286, 75);
            trainerClass_Gender_label.Name = "trainerClass_Gender_label";
            trainerClass_Gender_label.Size = new Size(52, 15);
            trainerClass_Gender_label.TabIndex = 38;
            trainerClass_Gender_label.Text = "Gender:";
            trainerClass_Gender_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_EyeContactMain_comboBox
            // 
            trainerClass_EyeContactMain_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainerClass_EyeContactMain_comboBox.Enabled = false;
            trainerClass_EyeContactMain_comboBox.FlatStyle = FlatStyle.Popup;
            trainerClass_EyeContactMain_comboBox.FormattingEnabled = true;
            trainerClass_EyeContactMain_comboBox.Location = new Point(154, 40);
            trainerClass_EyeContactMain_comboBox.Name = "trainerClass_EyeContactMain_comboBox";
            trainerClass_EyeContactMain_comboBox.Size = new Size(99, 23);
            trainerClass_EyeContactMain_comboBox.TabIndex = 32;
            // 
            // trainerClass_EyeContactAlt_comboBox
            // 
            trainerClass_EyeContactAlt_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainerClass_EyeContactAlt_comboBox.Enabled = false;
            trainerClass_EyeContactAlt_comboBox.FlatStyle = FlatStyle.Popup;
            trainerClass_EyeContactAlt_comboBox.FormattingEnabled = true;
            trainerClass_EyeContactAlt_comboBox.Location = new Point(154, 72);
            trainerClass_EyeContactAlt_comboBox.Name = "trainerClass_EyeContactAlt_comboBox";
            trainerClass_EyeContactAlt_comboBox.Size = new Size(99, 23);
            trainerClass_EyeContactAlt_comboBox.TabIndex = 30;
            // 
            // trainerClass_PrizeMoney_btn
            // 
            trainerClass_PrizeMoney_btn.BackColor = SystemColors.Info;
            trainerClass_PrizeMoney_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_PrizeMoney_btn.Location = new Point(441, 40);
            trainerClass_PrizeMoney_btn.Name = "trainerClass_PrizeMoney_btn";
            trainerClass_PrizeMoney_btn.Size = new Size(23, 23);
            trainerClass_PrizeMoney_btn.TabIndex = 5;
            trainerClass_PrizeMoney_btn.Text = "?";
            trainerClass_PrizeMoney_btn.UseVisualStyleBackColor = false;
            trainerClass_PrizeMoney_btn.Click += trainerClass_PrizeMoney_btn_Click;
            // 
            // trainerClass_Gender_comboBox
            // 
            trainerClass_Gender_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainerClass_Gender_comboBox.Enabled = false;
            trainerClass_Gender_comboBox.FlatStyle = FlatStyle.Popup;
            trainerClass_Gender_comboBox.FormattingEnabled = true;
            trainerClass_Gender_comboBox.Location = new Point(384, 72);
            trainerClass_Gender_comboBox.Name = "trainerClass_Gender_comboBox";
            trainerClass_Gender_comboBox.Size = new Size(80, 23);
            trainerClass_Gender_comboBox.TabIndex = 33;
            // 
            // trainerClass_PrizeMoney_num
            // 
            trainerClass_PrizeMoney_num.Enabled = false;
            trainerClass_PrizeMoney_num.Location = new Point(384, 41);
            trainerClass_PrizeMoney_num.Name = "trainerClass_PrizeMoney_num";
            trainerClass_PrizeMoney_num.Size = new Size(51, 23);
            trainerClass_PrizeMoney_num.TabIndex = 37;
            // 
            // trainerClass_EyeContactMusic_Main_label
            // 
            trainerClass_EyeContactMusic_Main_label.AutoSize = true;
            trainerClass_EyeContactMusic_Main_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_EyeContactMusic_Main_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_EyeContactMusic_Main_label.Location = new Point(5, 12);
            trainerClass_EyeContactMusic_Main_label.Name = "trainerClass_EyeContactMusic_Main_label";
            trainerClass_EyeContactMusic_Main_label.Size = new Size(139, 15);
            trainerClass_EyeContactMusic_Main_label.TabIndex = 25;
            trainerClass_EyeContactMusic_Main_label.Text = "Trainer Class Properties:";
            trainerClass_EyeContactMusic_Main_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_PrizeMoney_label
            // 
            trainerClass_PrizeMoney_label.AutoSize = true;
            trainerClass_PrizeMoney_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_PrizeMoney_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_PrizeMoney_label.Location = new Point(286, 43);
            trainerClass_PrizeMoney_label.Name = "trainerClass_PrizeMoney_label";
            trainerClass_PrizeMoney_label.Size = new Size(79, 15);
            trainerClass_PrizeMoney_label.TabIndex = 36;
            trainerClass_PrizeMoney_label.Text = "Prize Money:";
            trainerClass_PrizeMoney_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(trainerClass_Theme_label);
            panel3.Controls.Add(trainerClass_BattleMusic_label);
            panel3.Controls.Add(trainerClass_battleMusic);
            panel3.Controls.Add(saveClassTheme_btn);
            panel3.Controls.Add(trainerClass_vsGfx_box);
            panel3.Controls.Add(trainerClass_Theme_comboBox);
            panel3.Controls.Add(trainerClass_introGfx_label);
            panel3.Location = new Point(415, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 303);
            panel3.TabIndex = 6;
            // 
            // trainerClass_Theme_label
            // 
            trainerClass_Theme_label.AutoSize = true;
            trainerClass_Theme_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_Theme_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_Theme_label.Location = new Point(131, 238);
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
            trainerClass_BattleMusic_label.Location = new Point(5, 238);
            trainerClass_BattleMusic_label.Name = "trainerClass_BattleMusic_label";
            trainerClass_BattleMusic_label.Size = new Size(79, 15);
            trainerClass_BattleMusic_label.TabIndex = 35;
            trainerClass_BattleMusic_label.Text = "Battle Music:";
            trainerClass_BattleMusic_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_battleMusic
            // 
            trainerClass_battleMusic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            trainerClass_battleMusic.Location = new Point(6, 257);
            trainerClass_battleMusic.Name = "trainerClass_battleMusic";
            trainerClass_battleMusic.ReadOnly = true;
            trainerClass_battleMusic.Size = new Size(97, 23);
            trainerClass_battleMusic.TabIndex = 15;
            // 
            // saveClassTheme_btn
            // 
            saveClassTheme_btn.Image = Properties.Resources.saveIconSm;
            saveClassTheme_btn.Location = new Point(289, 257);
            saveClassTheme_btn.Name = "saveClassTheme_btn";
            saveClassTheme_btn.Size = new Size(56, 23);
            saveClassTheme_btn.TabIndex = 33;
            saveClassTheme_btn.Text = "Save";
            saveClassTheme_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveClassTheme_btn.UseVisualStyleBackColor = true;
            // 
            // trainerClass_vsGfx_box
            // 
            trainerClass_vsGfx_box.BackColor = Color.White;
            trainerClass_vsGfx_box.BorderStyle = BorderStyle.Fixed3D;
            trainerClass_vsGfx_box.Location = new Point(6, 39);
            trainerClass_vsGfx_box.Name = "trainerClass_vsGfx_box";
            trainerClass_vsGfx_box.Size = new Size(339, 192);
            trainerClass_vsGfx_box.TabIndex = 34;
            trainerClass_vsGfx_box.TabStop = false;
            // 
            // trainerClass_Theme_comboBox
            // 
            trainerClass_Theme_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainerClass_Theme_comboBox.Enabled = false;
            trainerClass_Theme_comboBox.FlatStyle = FlatStyle.Popup;
            trainerClass_Theme_comboBox.FormattingEnabled = true;
            trainerClass_Theme_comboBox.Location = new Point(131, 257);
            trainerClass_Theme_comboBox.Name = "trainerClass_Theme_comboBox";
            trainerClass_Theme_comboBox.Size = new Size(152, 23);
            trainerClass_Theme_comboBox.TabIndex = 33;
            // 
            // trainerClass_introGfx_label
            // 
            trainerClass_introGfx_label.AutoSize = true;
            trainerClass_introGfx_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_introGfx_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_introGfx_label.Location = new Point(6, 12);
            trainerClass_introGfx_label.Name = "trainerClass_introGfx_label";
            trainerClass_introGfx_label.Size = new Size(82, 15);
            trainerClass_introGfx_label.TabIndex = 33;
            trainerClass_introGfx_label.Text = "VS Intro GFX:";
            trainerClass_introGfx_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Used_panel
            // 
            trainerClass_Used_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            trainerClass_Used_panel.Controls.Add(trainerClass_GoToTrainer_btn);
            trainerClass_Used_panel.Controls.Add(trainerClass_Uses_list);
            trainerClass_Used_panel.Controls.Add(trainerClassUse_label);
            trainerClass_Used_panel.Location = new Point(209, 188);
            trainerClass_Used_panel.Name = "trainerClass_Used_panel";
            trainerClass_Used_panel.Size = new Size(200, 295);
            trainerClass_Used_panel.TabIndex = 4;
            // 
            // trainerClass_GoToTrainer_btn
            // 
            trainerClass_GoToTrainer_btn.Enabled = false;
            trainerClass_GoToTrainer_btn.Location = new Point(110, 8);
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
            trainerClass_Uses_list.Enabled = false;
            trainerClass_Uses_list.FormattingEnabled = true;
            trainerClass_Uses_list.ItemHeight = 15;
            trainerClass_Uses_list.Location = new Point(7, 39);
            trainerClass_Uses_list.Name = "trainerClass_Uses_list";
            trainerClass_Uses_list.Size = new Size(190, 244);
            trainerClass_Uses_list.TabIndex = 27;
            trainerClass_Uses_list.SelectedIndexChanged += trainerClass_Uses_list_SelectedIndexChanged;
            trainerClass_Uses_list.DoubleClick += trainerClass_Uses_list_DoubleClick;
            // 
            // trainerClassUse_label
            // 
            trainerClassUse_label.AutoSize = true;
            trainerClassUse_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassUse_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassUse_label.Location = new Point(5, 12);
            trainerClassUse_label.Name = "trainerClassUse_label";
            trainerClassUse_label.Size = new Size(54, 15);
            trainerClassUse_label.TabIndex = 28;
            trainerClassUse_label.Text = "Trainers:";
            trainerClassUse_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Info_panel
            // 
            trainerClass_Info_panel.Controls.Add(undoTrainerClass_btn);
            trainerClass_Info_panel.Controls.Add(saveTrainerClassAll_btn);
            trainerClass_Info_panel.Controls.Add(saveClassName_btn);
            trainerClass_Info_panel.Controls.Add(trainerClassName);
            trainerClass_Info_panel.Controls.Add(trainerClassName_Label);
            trainerClass_Info_panel.Location = new Point(209, 3);
            trainerClass_Info_panel.Name = "trainerClass_Info_panel";
            trainerClass_Info_panel.Size = new Size(473, 69);
            trainerClass_Info_panel.TabIndex = 2;
            // 
            // undoTrainerClass_btn
            // 
            undoTrainerClass_btn.Enabled = false;
            undoTrainerClass_btn.Image = Properties.Resources.undoIconSm;
            undoTrainerClass_btn.Location = new Point(337, 28);
            undoTrainerClass_btn.Name = "undoTrainerClass_btn";
            undoTrainerClass_btn.Size = new Size(131, 23);
            undoTrainerClass_btn.TabIndex = 14;
            undoTrainerClass_btn.Text = "Undo All Changes";
            undoTrainerClass_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            undoTrainerClass_btn.UseVisualStyleBackColor = true;
            undoTrainerClass_btn.Click += undoTrainerClass_btn_Click;
            // 
            // saveTrainerClassAll_btn
            // 
            saveTrainerClassAll_btn.Image = Properties.Resources.saveIconSm;
            saveTrainerClassAll_btn.Location = new Point(337, 3);
            saveTrainerClassAll_btn.Name = "saveTrainerClassAll_btn";
            saveTrainerClassAll_btn.Size = new Size(131, 23);
            saveTrainerClassAll_btn.TabIndex = 13;
            saveTrainerClassAll_btn.Text = "Save All Changes";
            saveTrainerClassAll_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveTrainerClassAll_btn.UseVisualStyleBackColor = true;
            saveTrainerClassAll_btn.Click += saveTrainerClassAll_btn_Click;
            // 
            // saveClassName_btn
            // 
            saveClassName_btn.BackgroundImageLayout = ImageLayout.Stretch;
            saveClassName_btn.Image = Properties.Resources.saveIconSm;
            saveClassName_btn.Location = new Point(144, 28);
            saveClassName_btn.Name = "saveClassName_btn";
            saveClassName_btn.Size = new Size(56, 23);
            saveClassName_btn.TabIndex = 12;
            saveClassName_btn.Text = "Save";
            saveClassName_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveClassName_btn.UseVisualStyleBackColor = true;
            saveClassName_btn.Click += saveClassName_btn_Click;
            // 
            // trainerClassName
            // 
            trainerClassName.AllowDrop = true;
            trainerClassName.Location = new Point(5, 28);
            trainerClassName.Name = "trainerClassName";
            trainerClassName.Size = new Size(133, 23);
            trainerClassName.TabIndex = 11;
            trainerClassName.TextChanged += trainerClassName_TextChanged;
            // 
            // trainerClassName_Label
            // 
            trainerClassName_Label.AutoSize = true;
            trainerClassName_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClassName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClassName_Label.Location = new Point(5, 6);
            trainerClassName_Label.Name = "trainerClassName_Label";
            trainerClassName_Label.Size = new Size(114, 15);
            trainerClassName_Label.TabIndex = 10;
            trainerClassName_Label.Text = "Trainer Class Name:";
            trainerClassName_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainerClass_Spite_Panel
            // 
            trainerClass_Spite_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainerClass_Spite_Panel.Controls.Add(trainerClass_frames_num);
            trainerClass_Spite_Panel.Controls.Add(trainerClass_frames_label);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPicBox);
            trainerClass_Spite_Panel.Controls.Add(trainerClassPic_label);
            trainerClass_Spite_Panel.Location = new Point(688, 3);
            trainerClass_Spite_Panel.Name = "trainerClass_Spite_Panel";
            trainerClass_Spite_Panel.Size = new Size(200, 179);
            trainerClass_Spite_Panel.TabIndex = 1;
            // 
            // trainerClass_frames_num
            // 
            trainerClass_frames_num.Enabled = false;
            trainerClass_frames_num.Location = new Point(140, 142);
            trainerClass_frames_num.Name = "trainerClass_frames_num";
            trainerClass_frames_num.Size = new Size(53, 23);
            trainerClass_frames_num.TabIndex = 38;
            trainerClass_frames_num.ValueChanged += trainerClass_frames_num_ValueChanged;
            // 
            // trainerClass_frames_label
            // 
            trainerClass_frames_label.AutoSize = true;
            trainerClass_frames_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_frames_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_frames_label.Location = new Point(84, 145);
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
            trainerClassPicBox.Location = new Point(5, 28);
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
            trainerClassPic_label.Location = new Point(5, 6);
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
            trainerClass_List_panel.Dock = DockStyle.Left;
            trainerClass_List_panel.Location = new Point(3, 3);
            trainerClass_List_panel.Name = "trainerClass_List_panel";
            trainerClass_List_panel.Size = new Size(200, 483);
            trainerClass_List_panel.TabIndex = 0;
            // 
            // trainerClassListBox
            // 
            trainerClassListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trainerClassListBox.FormattingEnabled = true;
            trainerClassListBox.ItemHeight = 15;
            trainerClassListBox.Location = new Point(5, 29);
            trainerClassListBox.Name = "trainerClassListBox";
            trainerClassListBox.Size = new Size(190, 439);
            trainerClassListBox.TabIndex = 1;
            trainerClassListBox.SelectedIndexChanged += trainerClassListBox_SelectedIndexChanged;
            // 
            // trainerClass_label
            // 
            trainerClass_label.AutoSize = true;
            trainerClass_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainerClass_label.ImageAlign = ContentAlignment.MiddleLeft;
            trainerClass_label.Location = new Point(5, 7);
            trainerClass_label.Name = "trainerClass_label";
            trainerClass_label.Size = new Size(90, 15);
            trainerClass_label.TabIndex = 4;
            trainerClass_label.Text = "Trainer Classes:";
            trainerClass_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainContent_trainer
            // 
            mainContent_trainer.Controls.Add(panel9);
            mainContent_trainer.Controls.Add(panel8);
            mainContent_trainer.Controls.Add(panel7);
            mainContent_trainer.Controls.Add(panel6);
            mainContent_trainer.Controls.Add(panel5);
            mainContent_trainer.Location = new Point(4, 24);
            mainContent_trainer.Name = "mainContent_trainer";
            mainContent_trainer.Padding = new Padding(3);
            mainContent_trainer.Size = new Size(891, 489);
            mainContent_trainer.TabIndex = 1;
            mainContent_trainer.Text = "Trainers";
            mainContent_trainer.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(trainer_MessageTrigger_list);
            panel9.Controls.Add(panel21);
            panel9.Controls.Add(trainer_EditMessage_btn);
            panel9.Controls.Add(label6);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(203, 365);
            panel9.Name = "panel9";
            panel9.Size = new Size(685, 121);
            panel9.TabIndex = 5;
            // 
            // trainer_MessageTrigger_list
            // 
            trainer_MessageTrigger_list.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_MessageTrigger_list.FlatStyle = FlatStyle.Popup;
            trainer_MessageTrigger_list.FormattingEnabled = true;
            trainer_MessageTrigger_list.Location = new Point(130, 5);
            trainer_MessageTrigger_list.Name = "trainer_MessageTrigger_list";
            trainer_MessageTrigger_list.Size = new Size(239, 23);
            trainer_MessageTrigger_list.TabIndex = 50;
            trainer_MessageTrigger_list.SelectedIndexChanged += trainer_MessageTrigger_list_SelectedIndexChanged;
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel21.BackgroundImage = Properties.Resources.MessageBox;
            panel21.BackgroundImageLayout = ImageLayout.Stretch;
            panel21.Controls.Add(trainer_Message);
            panel21.Controls.Add(trainer_Message_Back_btn);
            panel21.Controls.Add(trainer_Message_Next_btn);
            panel21.Location = new Point(13, 35);
            panel21.Name = "panel21";
            panel21.Size = new Size(448, 84);
            panel21.TabIndex = 49;
            // 
            // trainer_Message
            // 
            trainer_Message.AutoSize = true;
            trainer_Message.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Message.ImageAlign = ContentAlignment.MiddleLeft;
            trainer_Message.Location = new Point(24, 18);
            trainer_Message.Name = "trainer_Message";
            trainer_Message.Size = new Size(246, 34);
            trainer_Message.TabIndex = 46;
            trainer_Message.Text = "TRAINER MESSAGE";
            trainer_Message.UseCompatibleTextRendering = true;
            // 
            // trainer_Message_Back_btn
            // 
            trainer_Message_Back_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trainer_Message_Back_btn.BackColor = Color.White;
            trainer_Message_Back_btn.Enabled = false;
            trainer_Message_Back_btn.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            trainer_Message_Back_btn.ForeColor = SystemColors.ControlText;
            trainer_Message_Back_btn.Location = new Point(379, 14);
            trainer_Message_Back_btn.Name = "trainer_Message_Back_btn";
            trainer_Message_Back_btn.Size = new Size(23, 23);
            trainer_Message_Back_btn.TabIndex = 47;
            trainer_Message_Back_btn.Text = "▲";
            trainer_Message_Back_btn.UseVisualStyleBackColor = false;
            trainer_Message_Back_btn.Click += trainer_Message_Back_btn_Click;
            // 
            // trainer_Message_Next_btn
            // 
            trainer_Message_Next_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trainer_Message_Next_btn.BackColor = Color.White;
            trainer_Message_Next_btn.Enabled = false;
            trainer_Message_Next_btn.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            trainer_Message_Next_btn.ForeColor = Color.IndianRed;
            trainer_Message_Next_btn.Location = new Point(379, 43);
            trainer_Message_Next_btn.Name = "trainer_Message_Next_btn";
            trainer_Message_Next_btn.Size = new Size(23, 23);
            trainer_Message_Next_btn.TabIndex = 48;
            trainer_Message_Next_btn.Text = "▼";
            trainer_Message_Next_btn.UseVisualStyleBackColor = false;
            trainer_Message_Next_btn.Click += trainer_Message_Next_btn_Click;
            // 
            // trainer_EditMessage_btn
            // 
            trainer_EditMessage_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trainer_EditMessage_btn.Enabled = false;
            trainer_EditMessage_btn.Location = new Point(392, 7);
            trainer_EditMessage_btn.Name = "trainer_EditMessage_btn";
            trainer_EditMessage_btn.Size = new Size(69, 23);
            trainer_EditMessage_btn.TabIndex = 46;
            trainer_EditMessage_btn.Text = "Edit Text";
            trainer_EditMessage_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            trainer_EditMessage_btn.UseVisualStyleBackColor = true;
            trainer_EditMessage_btn.Click += trainer_EditMessage_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(13, 9);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 11;
            label6.Text = "Message Trigger:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel8.Controls.Add(trainerEditor_tab);
            panel8.Location = new Point(209, 77);
            panel8.Name = "panel8";
            panel8.Size = new Size(478, 276);
            panel8.TabIndex = 4;
            // 
            // trainerEditor_tab
            // 
            trainerEditor_tab.Controls.Add(trainerEditor_Pokemon);
            trainerEditor_tab.Controls.Add(trainerEditor_trnProperties);
            trainerEditor_tab.Dock = DockStyle.Fill;
            trainerEditor_tab.Location = new Point(0, 0);
            trainerEditor_tab.Name = "trainerEditor_tab";
            trainerEditor_tab.SelectedIndex = 0;
            trainerEditor_tab.Size = new Size(478, 276);
            trainerEditor_tab.TabIndex = 0;
            trainerEditor_tab.SelectedIndexChanged += trainerEditor_tab_SelectedIndexChanged;
            // 
            // trainerEditor_Pokemon
            // 
            trainerEditor_Pokemon.Controls.Add(panel10);
            trainerEditor_Pokemon.Location = new Point(4, 24);
            trainerEditor_Pokemon.Name = "trainerEditor_Pokemon";
            trainerEditor_Pokemon.Size = new Size(470, 248);
            trainerEditor_Pokemon.TabIndex = 3;
            trainerEditor_Pokemon.Text = "Pokemon";
            trainerEditor_Pokemon.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel19);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(470, 248);
            panel10.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.Controls.Add(panel20);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(0, 62);
            panel19.Name = "panel19";
            panel19.Size = new Size(470, 186);
            panel19.TabIndex = 48;
            // 
            // panel20
            // 
            panel20.Controls.Add(pictureBox5);
            panel20.Controls.Add(trainer_Poke6_Item);
            panel20.Controls.Add(trainer_Poke6_Moves_btn);
            panel20.Controls.Add(label11);
            panel20.Controls.Add(trainer_Poke6_Level);
            panel20.Controls.Add(trainer_Poke6_comboBox);
            panel20.Controls.Add(trainer_Poke6_Stats_btn);
            panel20.Controls.Add(pictureBox6);
            panel20.Controls.Add(trainer_Poke5_Item);
            panel20.Controls.Add(trainer_Poke5_Moves_btn);
            panel20.Controls.Add(label12);
            panel20.Controls.Add(trainer_Poke5_Level);
            panel20.Controls.Add(trainer_Poke5_comboBox);
            panel20.Controls.Add(trainer_Poke5_Stats_btn);
            panel20.Controls.Add(pictureBox7);
            panel20.Controls.Add(trainer_Poke4_Item);
            panel20.Controls.Add(trainer_Poke4_Moves_btn);
            panel20.Controls.Add(label13);
            panel20.Controls.Add(trainer_Poke4_Level);
            panel20.Controls.Add(trainer_Poke4_comboBox);
            panel20.Controls.Add(trainer_Poke4_Stats_btn);
            panel20.Controls.Add(pictureBox4);
            panel20.Controls.Add(trainer_Poke3_Item);
            panel20.Controls.Add(trainer_Poke3_Moves_btn);
            panel20.Controls.Add(label10);
            panel20.Controls.Add(trainer_Poke3_Level);
            panel20.Controls.Add(trainer_Poke3_comboBox);
            panel20.Controls.Add(trainer_Poke3_Stats_btn);
            panel20.Controls.Add(pictureBox3);
            panel20.Controls.Add(trainer_Poke2_Item);
            panel20.Controls.Add(trainer_Poke2_Moves_btn);
            panel20.Controls.Add(label9);
            panel20.Controls.Add(trainer_Poke2_Level);
            panel20.Controls.Add(trainer_Poke2_comboBox);
            panel20.Controls.Add(trainer_Poke2_Stats_btn);
            panel20.Controls.Add(pictureBox2);
            panel20.Controls.Add(trainer_Poke1_Item);
            panel20.Controls.Add(trainer_Poke1_Moves_btn);
            panel20.Controls.Add(label8);
            panel20.Controls.Add(trainer_Poke1_Level);
            panel20.Controls.Add(trainer_Poke1_comboBox);
            panel20.Controls.Add(trainer_Poke1_Stats_btn);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(470, 186);
            panel20.TabIndex = 60;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.pokeItemIcon;
            pictureBox5.Location = new Point(232, 152);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.TabIndex = 131;
            pictureBox5.TabStop = false;
            // 
            // trainer_Poke6_Item
            // 
            trainer_Poke6_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke6_Item.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke6_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke6_Item.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke6_Item.Enabled = false;
            trainer_Poke6_Item.FlatStyle = FlatStyle.Popup;
            trainer_Poke6_Item.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke6_Item.FormattingEnabled = true;
            trainer_Poke6_Item.ImeMode = ImeMode.Off;
            trainer_Poke6_Item.Location = new Point(256, 152);
            trainer_Poke6_Item.Name = "trainer_Poke6_Item";
            trainer_Poke6_Item.Size = new Size(104, 23);
            trainer_Poke6_Item.TabIndex = 130;
            // 
            // trainer_Poke6_Moves_btn
            // 
            trainer_Poke6_Moves_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke6_Moves_btn.Enabled = false;
            trainer_Poke6_Moves_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke6_Moves_btn.Location = new Point(365, 152);
            trainer_Poke6_Moves_btn.Name = "trainer_Poke6_Moves_btn";
            trainer_Poke6_Moves_btn.Size = new Size(48, 23);
            trainer_Poke6_Moves_btn.TabIndex = 129;
            trainer_Poke6_Moves_btn.Text = "Moves";
            trainer_Poke6_Moves_btn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(158, 154);
            label11.Name = "label11";
            label11.Size = new Size(22, 15);
            label11.TabIndex = 128;
            label11.Text = "Lv:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Poke6_Level
            // 
            trainer_Poke6_Level.Enabled = false;
            trainer_Poke6_Level.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke6_Level.Location = new Point(186, 152);
            trainer_Poke6_Level.Name = "trainer_Poke6_Level";
            trainer_Poke6_Level.Size = new Size(41, 23);
            trainer_Poke6_Level.TabIndex = 127;
            // 
            // trainer_Poke6_comboBox
            // 
            trainer_Poke6_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke6_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke6_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke6_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke6_comboBox.Enabled = false;
            trainer_Poke6_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Poke6_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke6_comboBox.FormattingEnabled = true;
            trainer_Poke6_comboBox.ImeMode = ImeMode.Off;
            trainer_Poke6_comboBox.Location = new Point(15, 152);
            trainer_Poke6_comboBox.Name = "trainer_Poke6_comboBox";
            trainer_Poke6_comboBox.Size = new Size(138, 23);
            trainer_Poke6_comboBox.TabIndex = 126;
            trainer_Poke6_comboBox.SelectedIndexChanged += trainer_Poke6_comboBox_SelectedIndexChanged;
            // 
            // trainer_Poke6_Stats_btn
            // 
            trainer_Poke6_Stats_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke6_Stats_btn.Enabled = false;
            trainer_Poke6_Stats_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke6_Stats_btn.Location = new Point(417, 152);
            trainer_Poke6_Stats_btn.Name = "trainer_Poke6_Stats_btn";
            trainer_Poke6_Stats_btn.Size = new Size(48, 23);
            trainer_Poke6_Stats_btn.TabIndex = 125;
            trainer_Poke6_Stats_btn.Text = "Stats";
            trainer_Poke6_Stats_btn.UseVisualStyleBackColor = true;
            trainer_Poke6_Stats_btn.Click += trainer_Poke6_btn_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pokeItemIcon;
            pictureBox6.Location = new Point(232, 123);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.TabIndex = 124;
            pictureBox6.TabStop = false;
            // 
            // trainer_Poke5_Item
            // 
            trainer_Poke5_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke5_Item.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke5_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke5_Item.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke5_Item.Enabled = false;
            trainer_Poke5_Item.FlatStyle = FlatStyle.Popup;
            trainer_Poke5_Item.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke5_Item.FormattingEnabled = true;
            trainer_Poke5_Item.ImeMode = ImeMode.Off;
            trainer_Poke5_Item.Location = new Point(256, 123);
            trainer_Poke5_Item.Name = "trainer_Poke5_Item";
            trainer_Poke5_Item.Size = new Size(104, 23);
            trainer_Poke5_Item.TabIndex = 123;
            // 
            // trainer_Poke5_Moves_btn
            // 
            trainer_Poke5_Moves_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke5_Moves_btn.Enabled = false;
            trainer_Poke5_Moves_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke5_Moves_btn.Location = new Point(365, 123);
            trainer_Poke5_Moves_btn.Name = "trainer_Poke5_Moves_btn";
            trainer_Poke5_Moves_btn.Size = new Size(48, 23);
            trainer_Poke5_Moves_btn.TabIndex = 122;
            trainer_Poke5_Moves_btn.Text = "Moves";
            trainer_Poke5_Moves_btn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.Location = new Point(158, 125);
            label12.Name = "label12";
            label12.Size = new Size(22, 15);
            label12.TabIndex = 121;
            label12.Text = "Lv:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Poke5_Level
            // 
            trainer_Poke5_Level.Enabled = false;
            trainer_Poke5_Level.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke5_Level.Location = new Point(186, 123);
            trainer_Poke5_Level.Name = "trainer_Poke5_Level";
            trainer_Poke5_Level.Size = new Size(41, 23);
            trainer_Poke5_Level.TabIndex = 120;
            // 
            // trainer_Poke5_comboBox
            // 
            trainer_Poke5_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke5_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke5_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke5_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke5_comboBox.Enabled = false;
            trainer_Poke5_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Poke5_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke5_comboBox.FormattingEnabled = true;
            trainer_Poke5_comboBox.ImeMode = ImeMode.Off;
            trainer_Poke5_comboBox.Location = new Point(15, 123);
            trainer_Poke5_comboBox.Name = "trainer_Poke5_comboBox";
            trainer_Poke5_comboBox.Size = new Size(138, 23);
            trainer_Poke5_comboBox.TabIndex = 119;
            trainer_Poke5_comboBox.SelectedIndexChanged += trainer_Poke5_comboBox_SelectedIndexChanged;
            // 
            // trainer_Poke5_Stats_btn
            // 
            trainer_Poke5_Stats_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke5_Stats_btn.Enabled = false;
            trainer_Poke5_Stats_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke5_Stats_btn.Location = new Point(417, 123);
            trainer_Poke5_Stats_btn.Name = "trainer_Poke5_Stats_btn";
            trainer_Poke5_Stats_btn.Size = new Size(48, 23);
            trainer_Poke5_Stats_btn.TabIndex = 118;
            trainer_Poke5_Stats_btn.Text = "Stats";
            trainer_Poke5_Stats_btn.UseVisualStyleBackColor = true;
            trainer_Poke5_Stats_btn.Click += trainer_Poke5_btn_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pokeItemIcon;
            pictureBox7.Location = new Point(232, 94);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.TabIndex = 117;
            pictureBox7.TabStop = false;
            // 
            // trainer_Poke4_Item
            // 
            trainer_Poke4_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke4_Item.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke4_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke4_Item.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke4_Item.Enabled = false;
            trainer_Poke4_Item.FlatStyle = FlatStyle.Popup;
            trainer_Poke4_Item.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke4_Item.FormattingEnabled = true;
            trainer_Poke4_Item.ImeMode = ImeMode.Off;
            trainer_Poke4_Item.Location = new Point(256, 94);
            trainer_Poke4_Item.Name = "trainer_Poke4_Item";
            trainer_Poke4_Item.Size = new Size(104, 23);
            trainer_Poke4_Item.TabIndex = 116;
            // 
            // trainer_Poke4_Moves_btn
            // 
            trainer_Poke4_Moves_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke4_Moves_btn.Enabled = false;
            trainer_Poke4_Moves_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke4_Moves_btn.Location = new Point(365, 94);
            trainer_Poke4_Moves_btn.Name = "trainer_Poke4_Moves_btn";
            trainer_Poke4_Moves_btn.Size = new Size(48, 23);
            trainer_Poke4_Moves_btn.TabIndex = 115;
            trainer_Poke4_Moves_btn.Text = "Moves";
            trainer_Poke4_Moves_btn.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(158, 96);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 114;
            label13.Text = "Lv:";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Poke4_Level
            // 
            trainer_Poke4_Level.Enabled = false;
            trainer_Poke4_Level.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke4_Level.Location = new Point(186, 94);
            trainer_Poke4_Level.Name = "trainer_Poke4_Level";
            trainer_Poke4_Level.Size = new Size(41, 23);
            trainer_Poke4_Level.TabIndex = 113;
            // 
            // trainer_Poke4_comboBox
            // 
            trainer_Poke4_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke4_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke4_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke4_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke4_comboBox.Enabled = false;
            trainer_Poke4_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Poke4_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke4_comboBox.FormattingEnabled = true;
            trainer_Poke4_comboBox.ImeMode = ImeMode.Off;
            trainer_Poke4_comboBox.Location = new Point(15, 94);
            trainer_Poke4_comboBox.Name = "trainer_Poke4_comboBox";
            trainer_Poke4_comboBox.Size = new Size(138, 23);
            trainer_Poke4_comboBox.TabIndex = 112;
            trainer_Poke4_comboBox.SelectedIndexChanged += trainer_Poke4_comboBox_SelectedIndexChanged;
            // 
            // trainer_Poke4_Stats_btn
            // 
            trainer_Poke4_Stats_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke4_Stats_btn.Enabled = false;
            trainer_Poke4_Stats_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke4_Stats_btn.Location = new Point(417, 94);
            trainer_Poke4_Stats_btn.Name = "trainer_Poke4_Stats_btn";
            trainer_Poke4_Stats_btn.Size = new Size(48, 23);
            trainer_Poke4_Stats_btn.TabIndex = 111;
            trainer_Poke4_Stats_btn.Text = "Stats";
            trainer_Poke4_Stats_btn.UseVisualStyleBackColor = true;
            trainer_Poke4_Stats_btn.Click += trainer_Poke4_btn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pokeItemIcon;
            pictureBox4.Location = new Point(231, 65);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.TabIndex = 110;
            pictureBox4.TabStop = false;
            // 
            // trainer_Poke3_Item
            // 
            trainer_Poke3_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke3_Item.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke3_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke3_Item.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke3_Item.Enabled = false;
            trainer_Poke3_Item.FlatStyle = FlatStyle.Popup;
            trainer_Poke3_Item.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke3_Item.FormattingEnabled = true;
            trainer_Poke3_Item.ImeMode = ImeMode.Off;
            trainer_Poke3_Item.Location = new Point(256, 65);
            trainer_Poke3_Item.Name = "trainer_Poke3_Item";
            trainer_Poke3_Item.Size = new Size(104, 23);
            trainer_Poke3_Item.TabIndex = 109;
            // 
            // trainer_Poke3_Moves_btn
            // 
            trainer_Poke3_Moves_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke3_Moves_btn.Enabled = false;
            trainer_Poke3_Moves_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke3_Moves_btn.Location = new Point(365, 65);
            trainer_Poke3_Moves_btn.Name = "trainer_Poke3_Moves_btn";
            trainer_Poke3_Moves_btn.Size = new Size(48, 23);
            trainer_Poke3_Moves_btn.TabIndex = 108;
            trainer_Poke3_Moves_btn.Text = "Moves";
            trainer_Poke3_Moves_btn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(158, 67);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 107;
            label10.Text = "Lv:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Poke3_Level
            // 
            trainer_Poke3_Level.Enabled = false;
            trainer_Poke3_Level.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke3_Level.Location = new Point(186, 65);
            trainer_Poke3_Level.Name = "trainer_Poke3_Level";
            trainer_Poke3_Level.Size = new Size(41, 23);
            trainer_Poke3_Level.TabIndex = 106;
            // 
            // trainer_Poke3_comboBox
            // 
            trainer_Poke3_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke3_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke3_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke3_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke3_comboBox.Enabled = false;
            trainer_Poke3_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Poke3_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke3_comboBox.FormattingEnabled = true;
            trainer_Poke3_comboBox.ImeMode = ImeMode.Off;
            trainer_Poke3_comboBox.Location = new Point(15, 65);
            trainer_Poke3_comboBox.Name = "trainer_Poke3_comboBox";
            trainer_Poke3_comboBox.Size = new Size(138, 23);
            trainer_Poke3_comboBox.TabIndex = 105;
            trainer_Poke3_comboBox.SelectedIndexChanged += trainer_Poke3_comboBox_SelectedIndexChanged;
            // 
            // trainer_Poke3_Stats_btn
            // 
            trainer_Poke3_Stats_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke3_Stats_btn.Enabled = false;
            trainer_Poke3_Stats_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke3_Stats_btn.Location = new Point(417, 65);
            trainer_Poke3_Stats_btn.Name = "trainer_Poke3_Stats_btn";
            trainer_Poke3_Stats_btn.Size = new Size(48, 23);
            trainer_Poke3_Stats_btn.TabIndex = 104;
            trainer_Poke3_Stats_btn.Text = "Stats";
            trainer_Poke3_Stats_btn.UseVisualStyleBackColor = true;
            trainer_Poke3_Stats_btn.Click += trainer_Poke3_btn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pokeItemIcon;
            pictureBox3.Location = new Point(231, 37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.TabIndex = 103;
            pictureBox3.TabStop = false;
            // 
            // trainer_Poke2_Item
            // 
            trainer_Poke2_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke2_Item.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke2_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke2_Item.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke2_Item.Enabled = false;
            trainer_Poke2_Item.FlatStyle = FlatStyle.Popup;
            trainer_Poke2_Item.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke2_Item.FormattingEnabled = true;
            trainer_Poke2_Item.ImeMode = ImeMode.Off;
            trainer_Poke2_Item.Location = new Point(256, 36);
            trainer_Poke2_Item.Name = "trainer_Poke2_Item";
            trainer_Poke2_Item.Size = new Size(104, 23);
            trainer_Poke2_Item.TabIndex = 102;
            // 
            // trainer_Poke2_Moves_btn
            // 
            trainer_Poke2_Moves_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke2_Moves_btn.Enabled = false;
            trainer_Poke2_Moves_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke2_Moves_btn.Location = new Point(365, 36);
            trainer_Poke2_Moves_btn.Name = "trainer_Poke2_Moves_btn";
            trainer_Poke2_Moves_btn.Size = new Size(48, 23);
            trainer_Poke2_Moves_btn.TabIndex = 101;
            trainer_Poke2_Moves_btn.Text = "Moves";
            trainer_Poke2_Moves_btn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(158, 38);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 100;
            label9.Text = "Lv:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Poke2_Level
            // 
            trainer_Poke2_Level.Enabled = false;
            trainer_Poke2_Level.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke2_Level.Location = new Point(186, 36);
            trainer_Poke2_Level.Name = "trainer_Poke2_Level";
            trainer_Poke2_Level.Size = new Size(41, 23);
            trainer_Poke2_Level.TabIndex = 99;
            // 
            // trainer_Poke2_comboBox
            // 
            trainer_Poke2_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke2_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke2_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke2_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke2_comboBox.Enabled = false;
            trainer_Poke2_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Poke2_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke2_comboBox.FormattingEnabled = true;
            trainer_Poke2_comboBox.ImeMode = ImeMode.Off;
            trainer_Poke2_comboBox.Location = new Point(15, 36);
            trainer_Poke2_comboBox.Name = "trainer_Poke2_comboBox";
            trainer_Poke2_comboBox.Size = new Size(138, 23);
            trainer_Poke2_comboBox.TabIndex = 98;
            trainer_Poke2_comboBox.SelectedIndexChanged += trainer_Poke2_comboBox_SelectedIndexChanged;
            // 
            // trainer_Poke2_Stats_btn
            // 
            trainer_Poke2_Stats_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke2_Stats_btn.Enabled = false;
            trainer_Poke2_Stats_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke2_Stats_btn.Location = new Point(417, 36);
            trainer_Poke2_Stats_btn.Name = "trainer_Poke2_Stats_btn";
            trainer_Poke2_Stats_btn.Size = new Size(48, 23);
            trainer_Poke2_Stats_btn.TabIndex = 97;
            trainer_Poke2_Stats_btn.Text = "Stats";
            trainer_Poke2_Stats_btn.UseVisualStyleBackColor = true;
            trainer_Poke2_Stats_btn.Click += trainer_Poke2_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pokeItemIcon;
            pictureBox2.Location = new Point(231, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 96;
            pictureBox2.TabStop = false;
            // 
            // trainer_Poke1_Item
            // 
            trainer_Poke1_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke1_Item.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke1_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke1_Item.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke1_Item.Enabled = false;
            trainer_Poke1_Item.FlatStyle = FlatStyle.Popup;
            trainer_Poke1_Item.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke1_Item.FormattingEnabled = true;
            trainer_Poke1_Item.ImeMode = ImeMode.Off;
            trainer_Poke1_Item.Location = new Point(256, 7);
            trainer_Poke1_Item.Name = "trainer_Poke1_Item";
            trainer_Poke1_Item.Size = new Size(104, 23);
            trainer_Poke1_Item.TabIndex = 95;
            // 
            // trainer_Poke1_Moves_btn
            // 
            trainer_Poke1_Moves_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke1_Moves_btn.Enabled = false;
            trainer_Poke1_Moves_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke1_Moves_btn.Location = new Point(365, 7);
            trainer_Poke1_Moves_btn.Name = "trainer_Poke1_Moves_btn";
            trainer_Poke1_Moves_btn.Size = new Size(48, 23);
            trainer_Poke1_Moves_btn.TabIndex = 79;
            trainer_Poke1_Moves_btn.Text = "Moves";
            trainer_Poke1_Moves_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(158, 9);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 67;
            label8.Text = "Lv:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Poke1_Level
            // 
            trainer_Poke1_Level.Enabled = false;
            trainer_Poke1_Level.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke1_Level.Location = new Point(186, 7);
            trainer_Poke1_Level.Name = "trainer_Poke1_Level";
            trainer_Poke1_Level.Size = new Size(41, 23);
            trainer_Poke1_Level.TabIndex = 66;
            trainer_Poke1_Level.ValueChanged += trainer_Poke1_Level_ValueChanged;
            // 
            // trainer_Poke1_comboBox
            // 
            trainer_Poke1_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Poke1_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Poke1_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Poke1_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Poke1_comboBox.Enabled = false;
            trainer_Poke1_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Poke1_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke1_comboBox.FormattingEnabled = true;
            trainer_Poke1_comboBox.ImeMode = ImeMode.Off;
            trainer_Poke1_comboBox.Location = new Point(15, 7);
            trainer_Poke1_comboBox.Name = "trainer_Poke1_comboBox";
            trainer_Poke1_comboBox.Size = new Size(138, 23);
            trainer_Poke1_comboBox.TabIndex = 52;
            trainer_Poke1_comboBox.SelectedIndexChanged += trainer_Poke1_comboBox_SelectedIndexChanged;
            // 
            // trainer_Poke1_Stats_btn
            // 
            trainer_Poke1_Stats_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Poke1_Stats_btn.Enabled = false;
            trainer_Poke1_Stats_btn.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke1_Stats_btn.Location = new Point(417, 7);
            trainer_Poke1_Stats_btn.Name = "trainer_Poke1_Stats_btn";
            trainer_Poke1_Stats_btn.Size = new Size(48, 23);
            trainer_Poke1_Stats_btn.TabIndex = 47;
            trainer_Poke1_Stats_btn.Text = "Stats";
            trainer_Poke1_Stats_btn.UseVisualStyleBackColor = true;
            trainer_Poke1_Stats_btn.Click += trainer_Poke1_btn_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(trainer_Poke_Num_pic);
            panel11.Controls.Add(trainer_Poke_Moves_checkBox);
            panel11.Controls.Add(trainer_Poke_HeldItem_checkBox);
            panel11.Controls.Add(trainer_Double_checkBox);
            panel11.Controls.Add(saveTrainerPoke_btn);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(trainer_NumPoke_num);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(470, 62);
            panel11.TabIndex = 47;
            // 
            // trainer_Poke_Num_pic
            // 
            trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs0;
            trainer_Poke_Num_pic.Location = new Point(132, 6);
            trainer_Poke_Num_pic.Name = "trainer_Poke_Num_pic";
            trainer_Poke_Num_pic.Size = new Size(111, 23);
            trainer_Poke_Num_pic.SizeMode = PictureBoxSizeMode.Zoom;
            trainer_Poke_Num_pic.TabIndex = 54;
            trainer_Poke_Num_pic.TabStop = false;
            // 
            // trainer_Poke_Moves_checkBox
            // 
            trainer_Poke_Moves_checkBox.AutoSize = true;
            trainer_Poke_Moves_checkBox.Enabled = false;
            trainer_Poke_Moves_checkBox.FlatAppearance.BorderSize = 2;
            trainer_Poke_Moves_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke_Moves_checkBox.Location = new Point(207, 37);
            trainer_Poke_Moves_checkBox.Name = "trainer_Poke_Moves_checkBox";
            trainer_Poke_Moves_checkBox.Size = new Size(104, 19);
            trainer_Poke_Moves_checkBox.TabIndex = 53;
            trainer_Poke_Moves_checkBox.Text = "Choose Moves";
            trainer_Poke_Moves_checkBox.UseVisualStyleBackColor = true;
            trainer_Poke_Moves_checkBox.CheckedChanged += trainer_Poke_Moves_checkBox_CheckedChanged;
            // 
            // trainer_Poke_HeldItem_checkBox
            // 
            trainer_Poke_HeldItem_checkBox.AutoSize = true;
            trainer_Poke_HeldItem_checkBox.Enabled = false;
            trainer_Poke_HeldItem_checkBox.FlatAppearance.BorderSize = 2;
            trainer_Poke_HeldItem_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Poke_HeldItem_checkBox.Location = new Point(118, 37);
            trainer_Poke_HeldItem_checkBox.Name = "trainer_Poke_HeldItem_checkBox";
            trainer_Poke_HeldItem_checkBox.Size = new Size(83, 19);
            trainer_Poke_HeldItem_checkBox.TabIndex = 52;
            trainer_Poke_HeldItem_checkBox.Text = "Held Items";
            trainer_Poke_HeldItem_checkBox.UseVisualStyleBackColor = true;
            trainer_Poke_HeldItem_checkBox.CheckedChanged += trainer_Poke_HeldItem_checkBox_CheckedChanged;
            // 
            // trainer_Double_checkBox
            // 
            trainer_Double_checkBox.AutoSize = true;
            trainer_Double_checkBox.Enabled = false;
            trainer_Double_checkBox.FlatAppearance.BorderSize = 2;
            trainer_Double_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Double_checkBox.Location = new Point(15, 37);
            trainer_Double_checkBox.Name = "trainer_Double_checkBox";
            trainer_Double_checkBox.Size = new Size(97, 19);
            trainer_Double_checkBox.TabIndex = 51;
            trainer_Double_checkBox.Text = "Double Battle";
            trainer_Double_checkBox.UseVisualStyleBackColor = true;
            trainer_Double_checkBox.CheckedChanged += trainer_Double_checkBox_CheckedChanged;
            // 
            // saveTrainerPoke_btn
            // 
            saveTrainerPoke_btn.Image = Properties.Resources.saveIconSm;
            saveTrainerPoke_btn.Location = new Point(408, 6);
            saveTrainerPoke_btn.Name = "saveTrainerPoke_btn";
            saveTrainerPoke_btn.Size = new Size(56, 23);
            saveTrainerPoke_btn.TabIndex = 47;
            saveTrainerPoke_btn.Text = "Save";
            saveTrainerPoke_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveTrainerPoke_btn.UseVisualStyleBackColor = true;
            saveTrainerPoke_btn.Click += saveTrainerPoke_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(15, 9);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 8;
            label7.Text = "Team Size";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_NumPoke_num
            // 
            trainer_NumPoke_num.Enabled = false;
            trainer_NumPoke_num.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_NumPoke_num.Location = new Point(87, 5);
            trainer_NumPoke_num.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            trainer_NumPoke_num.Name = "trainer_NumPoke_num";
            trainer_NumPoke_num.Size = new Size(39, 23);
            trainer_NumPoke_num.TabIndex = 47;
            trainer_NumPoke_num.ValueChanged += trainer_NumPoke_num_ValueChanged;
            // 
            // trainerEditor_trnProperties
            // 
            trainerEditor_trnProperties.Controls.Add(panel12);
            trainerEditor_trnProperties.Location = new Point(4, 24);
            trainerEditor_trnProperties.Name = "trainerEditor_trnProperties";
            trainerEditor_trnProperties.Padding = new Padding(3);
            trainerEditor_trnProperties.Size = new Size(470, 248);
            trainerEditor_trnProperties.TabIndex = 2;
            trainerEditor_trnProperties.Text = "Trainer Properties";
            trainerEditor_trnProperties.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel18);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(464, 242);
            panel12.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(label24);
            panel18.Controls.Add(label25);
            panel18.Controls.Add(trainer_Item4_comboBox);
            panel18.Controls.Add(trainer_Item3_comboBox);
            panel18.Controls.Add(label23);
            panel18.Controls.Add(label22);
            panel18.Controls.Add(trainer_Item2_comboBox);
            panel18.Controls.Add(trainer_Item1_comboBox);
            panel18.Controls.Add(label19);
            panel18.Controls.Add(trainer_ai_tag_checkBox);
            panel18.Controls.Add(trainer_ai_weather_checkBox);
            panel18.Controls.Add(trainer_ai_checkHp_checkBox);
            panel18.Controls.Add(trainer_ai_misc_checkBox);
            panel18.Controls.Add(trainer_ai_baton_checkBox);
            panel18.Controls.Add(trainer_ai_dmg_checkBox);
            panel18.Controls.Add(trainer_ai_risk_checkBox);
            panel18.Controls.Add(trainer_ai_status_checkBox);
            panel18.Controls.Add(trainer_ai_expert_checkBox);
            panel18.Controls.Add(trainer_ai_evaluate_checkBox);
            panel18.Controls.Add(trainer_ai_Basic_checkbox);
            panel18.Controls.Add(label14);
            panel18.Controls.Add(saveTrainerProperties_btn);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(0, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(464, 242);
            panel18.TabIndex = 0;
            // 
            // saveTrainerProperties_btn
            // 
            saveTrainerProperties_btn.Enabled = false;
            saveTrainerProperties_btn.Image = Properties.Resources.saveIconSm;
            saveTrainerProperties_btn.Location = new Point(392, 3);
            saveTrainerProperties_btn.Name = "saveTrainerProperties_btn";
            saveTrainerProperties_btn.Size = new Size(56, 23);
            saveTrainerProperties_btn.TabIndex = 48;
            saveTrainerProperties_btn.Text = "Save";
            saveTrainerProperties_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveTrainerProperties_btn.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(undoTrainer_btn);
            panel7.Controls.Add(saveTrainerAll_btn);
            panel7.Controls.Add(save_TrainerName_btn);
            panel7.Controls.Add(trainer_Name);
            panel7.Controls.Add(trainer_Name_Label);
            panel7.Location = new Point(209, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(478, 68);
            panel7.TabIndex = 3;
            // 
            // undoTrainer_btn
            // 
            undoTrainer_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            undoTrainer_btn.Enabled = false;
            undoTrainer_btn.Image = Properties.Resources.undoIconSm;
            undoTrainer_btn.Location = new Point(337, 27);
            undoTrainer_btn.Name = "undoTrainer_btn";
            undoTrainer_btn.Size = new Size(131, 23);
            undoTrainer_btn.TabIndex = 16;
            undoTrainer_btn.Text = "Undo All Changes";
            undoTrainer_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            undoTrainer_btn.UseVisualStyleBackColor = true;
            undoTrainer_btn.Click += undoTrainer_btn_Click;
            // 
            // saveTrainerAll_btn
            // 
            saveTrainerAll_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveTrainerAll_btn.Image = Properties.Resources.saveIconSm;
            saveTrainerAll_btn.Location = new Point(337, 3);
            saveTrainerAll_btn.Name = "saveTrainerAll_btn";
            saveTrainerAll_btn.Size = new Size(131, 23);
            saveTrainerAll_btn.TabIndex = 15;
            saveTrainerAll_btn.Text = "Save All Changes";
            saveTrainerAll_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveTrainerAll_btn.UseVisualStyleBackColor = true;
            saveTrainerAll_btn.Click += saveTrainerAll_btn_Click;
            // 
            // save_TrainerName_btn
            // 
            save_TrainerName_btn.Image = Properties.Resources.saveIconSm;
            save_TrainerName_btn.Location = new Point(144, 28);
            save_TrainerName_btn.Name = "save_TrainerName_btn";
            save_TrainerName_btn.Size = new Size(56, 23);
            save_TrainerName_btn.TabIndex = 12;
            save_TrainerName_btn.Text = "Save";
            save_TrainerName_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            save_TrainerName_btn.UseVisualStyleBackColor = true;
            save_TrainerName_btn.Click += save_TrainerName_btn_Click;
            // 
            // trainer_Name
            // 
            trainer_Name.AllowDrop = true;
            trainer_Name.Location = new Point(5, 28);
            trainer_Name.Name = "trainer_Name";
            trainer_Name.Size = new Size(133, 23);
            trainer_Name.TabIndex = 11;
            trainer_Name.TextChanged += trainer_Name_TextChanged;
            // 
            // trainer_Name_Label
            // 
            trainer_Name_Label.AutoSize = true;
            trainer_Name_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainer_Name_Label.ImageAlign = ContentAlignment.MiddleLeft;
            trainer_Name_Label.Location = new Point(5, 6);
            trainer_Name_Label.Name = "trainer_Name_Label";
            trainer_Name_Label.Size = new Size(85, 15);
            trainer_Name_Label.TabIndex = 10;
            trainer_Name_Label.Text = "Trainer Name:";
            trainer_Name_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.Controls.Add(trainer_GoToClass_btn);
            panel6.Controls.Add(save_TrainerClass_btn);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(trainer_Class_comboBox);
            panel6.Controls.Add(trainer_frames_num);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(trainerPicBox);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(688, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 258);
            panel6.TabIndex = 2;
            // 
            // trainer_GoToClass_btn
            // 
            trainer_GoToClass_btn.Enabled = false;
            trainer_GoToClass_btn.Location = new Point(5, 222);
            trainer_GoToClass_btn.Name = "trainer_GoToClass_btn";
            trainer_GoToClass_btn.Size = new Size(188, 23);
            trainer_GoToClass_btn.TabIndex = 42;
            trainer_GoToClass_btn.Text = "Go To Trainer Class";
            trainer_GoToClass_btn.UseVisualStyleBackColor = true;
            trainer_GoToClass_btn.Click += trainer_GoToClass_btn_Click;
            // 
            // save_TrainerClass_btn
            // 
            save_TrainerClass_btn.Image = Properties.Resources.saveIconSm;
            save_TrainerClass_btn.Location = new Point(137, 193);
            save_TrainerClass_btn.Name = "save_TrainerClass_btn";
            save_TrainerClass_btn.Size = new Size(56, 23);
            save_TrainerClass_btn.TabIndex = 41;
            save_TrainerClass_btn.Text = "Save";
            save_TrainerClass_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            trainer_Class_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Class_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Class_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Class_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Class_comboBox.FormattingEnabled = true;
            trainer_Class_comboBox.Location = new Point(5, 193);
            trainer_Class_comboBox.Name = "trainer_Class_comboBox";
            trainer_Class_comboBox.Size = new Size(126, 23);
            trainer_Class_comboBox.TabIndex = 39;
            trainer_Class_comboBox.SelectedIndexChanged += trainer_Class_comboBox_SelectedIndexChanged;
            // 
            // trainer_frames_num
            // 
            trainer_frames_num.Enabled = false;
            trainer_frames_num.Location = new Point(140, 142);
            trainer_frames_num.Name = "trainer_frames_num";
            trainer_frames_num.Size = new Size(53, 23);
            trainer_frames_num.TabIndex = 38;
            trainer_frames_num.ValueChanged += trainer_frames_num_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(84, 145);
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
            trainerPicBox.Location = new Point(5, 28);
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
            label4.Location = new Point(5, 6);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 27;
            label4.Text = "Trainer Class Sprite:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(trainer_Player_help_btn);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(trainers_list);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(trainers_Player_list);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 483);
            panel5.TabIndex = 0;
            // 
            // trainer_Player_help_btn
            // 
            trainer_Player_help_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trainer_Player_help_btn.BackColor = SystemColors.Info;
            trainer_Player_help_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trainer_Player_help_btn.Location = new Point(173, 1);
            trainer_Player_help_btn.Name = "trainer_Player_help_btn";
            trainer_Player_help_btn.Size = new Size(23, 23);
            trainer_Player_help_btn.TabIndex = 8;
            trainer_Player_help_btn.TabStop = false;
            trainer_Player_help_btn.Text = "?";
            trainer_Player_help_btn.UseVisualStyleBackColor = false;
            trainer_Player_help_btn.Click += trainer_Player_help_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(5, 82);
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
            trainers_list.Location = new Point(5, 104);
            trainers_list.Name = "trainers_list";
            trainers_list.Size = new Size(190, 364);
            trainers_list.TabIndex = 6;
            trainers_list.SelectedIndexChanged += trainers_list_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(5, 6);
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
            trainers_Player_list.Location = new Point(5, 28);
            trainers_Player_list.Name = "trainers_Player_list";
            trainers_Player_list.Size = new Size(190, 49);
            trainers_Player_list.TabIndex = 4;
            // 
            // mainContent_trainerText
            // 
            mainContent_trainerText.Controls.Add(panel17);
            mainContent_trainerText.Location = new Point(4, 24);
            mainContent_trainerText.Name = "mainContent_trainerText";
            mainContent_trainerText.Size = new Size(891, 489);
            mainContent_trainerText.TabIndex = 2;
            mainContent_trainerText.Text = "Trainer Text Table";
            mainContent_trainerText.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            panel17.Controls.Add(panel16);
            panel17.Controls.Add(trainerText_toolstrip);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(891, 489);
            panel17.TabIndex = 2;
            // 
            // panel16
            // 
            panel16.Controls.Add(panel15);
            panel16.Controls.Add(trainerTextTable_dataGrid);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(0, 31);
            panel16.Name = "panel16";
            panel16.Size = new Size(891, 458);
            panel16.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.Controls.Add(trainerTextTable_help_label);
            panel15.Dock = DockStyle.Bottom;
            panel15.Location = new Point(0, 433);
            panel15.Name = "panel15";
            panel15.Size = new Size(891, 25);
            panel15.TabIndex = 1;
            // 
            // trainerTextTable_help_label
            // 
            trainerTextTable_help_label.AutoSize = true;
            trainerTextTable_help_label.Location = new Point(3, 5);
            trainerTextTable_help_label.Name = "trainerTextTable_help_label";
            trainerTextTable_help_label.Size = new Size(135, 15);
            trainerTextTable_help_label.TabIndex = 0;
            trainerTextTable_help_label.Text = "Double click to edjt text.";
            // 
            // trainerTextTable_dataGrid
            // 
            trainerTextTable_dataGrid.AllowUserToAddRows = false;
            trainerTextTable_dataGrid.AllowUserToDeleteRows = false;
            trainerTextTable_dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            trainerTextTable_dataGrid.CausesValidation = false;
            trainerTextTable_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainerTextTable_dataGrid.Columns.AddRange(new DataGridViewColumn[] { MessageId, TrainerId, MessageTriggerId, Message });
            trainerTextTable_dataGrid.Dock = DockStyle.Fill;
            trainerTextTable_dataGrid.Location = new Point(0, 0);
            trainerTextTable_dataGrid.MultiSelect = false;
            trainerTextTable_dataGrid.Name = "trainerTextTable_dataGrid";
            trainerTextTable_dataGrid.RowHeadersWidth = 62;
            trainerTextTable_dataGrid.RowTemplate.Height = 25;
            trainerTextTable_dataGrid.Size = new Size(891, 458);
            trainerTextTable_dataGrid.TabIndex = 0;
            trainerTextTable_dataGrid.CellClick += trainerTextTable_dataGrid_CellClick;
            trainerTextTable_dataGrid.CellContentDoubleClick += trainerTextTable_dataGrid_TextDblClick;
            // 
            // MessageId
            // 
            MessageId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MessageId.FillWeight = 30F;
            MessageId.Frozen = true;
            MessageId.HeaderText = "Message #";
            MessageId.MinimumWidth = 8;
            MessageId.Name = "MessageId";
            MessageId.ReadOnly = true;
            MessageId.Width = 86;
            // 
            // TrainerId
            // 
            TrainerId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TrainerId.FillWeight = 50F;
            TrainerId.Frozen = true;
            TrainerId.HeaderText = "Trainer";
            TrainerId.MinimumWidth = 8;
            TrainerId.Name = "TrainerId";
            TrainerId.Resizable = DataGridViewTriState.True;
            TrainerId.SortMode = DataGridViewColumnSortMode.Automatic;
            TrainerId.Width = 144;
            // 
            // MessageTriggerId
            // 
            MessageTriggerId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MessageTriggerId.FillWeight = 60F;
            MessageTriggerId.Frozen = true;
            MessageTriggerId.HeaderText = "Message Trigger";
            MessageTriggerId.MinimumWidth = 8;
            MessageTriggerId.Name = "MessageTriggerId";
            MessageTriggerId.Resizable = DataGridViewTriState.True;
            MessageTriggerId.SortMode = DataGridViewColumnSortMode.Automatic;
            MessageTriggerId.Width = 216;
            // 
            // Message
            // 
            Message.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Message.DefaultCellStyle = dataGridViewCellStyle2;
            Message.HeaderText = "Text";
            Message.MinimumWidth = 8;
            Message.Name = "Message";
            Message.Width = 287;
            // 
            // trainerText_toolstrip
            // 
            trainerText_toolstrip.ImageScalingSize = new Size(24, 24);
            trainerText_toolstrip.Items.AddRange(new ToolStripItem[] { toolStripButton3, trainreText_Import_btn, trainerText_Export_btn, toolStripSeparator3, trainerTextTable_addRow_btn, trainerTextTable_delRow_btn, toolStripSeparator4, trainerText_sort });
            trainerText_toolstrip.Location = new Point(0, 0);
            trainerText_toolstrip.Name = "trainerText_toolstrip";
            trainerText_toolstrip.Padding = new Padding(0, 0, 2, 0);
            trainerText_toolstrip.Size = new Size(891, 31);
            trainerText_toolstrip.TabIndex = 13;
            trainerText_toolstrip.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.Image = Properties.Resources.saveIcon;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(108, 28);
            toolStripButton3.Text = "Save Changes";
            toolStripButton3.Click += trainerTextTable_SaveChanges_btn;
            // 
            // trainreText_Import_btn
            // 
            trainreText_Import_btn.Image = Properties.Resources.importIcon;
            trainreText_Import_btn.ImageTransparentColor = Color.Magenta;
            trainreText_Import_btn.Name = "trainreText_Import_btn";
            trainreText_Import_btn.Padding = new Padding(0, 0, 2, 0);
            trainreText_Import_btn.Size = new Size(140, 28);
            trainreText_Import_btn.Text = "Import Spreadsheet";
            // 
            // trainerText_Export_btn
            // 
            trainerText_Export_btn.Image = Properties.Resources.exportIcon;
            trainerText_Export_btn.ImageTransparentColor = Color.Magenta;
            trainerText_Export_btn.Name = "trainerText_Export_btn";
            trainerText_Export_btn.Size = new Size(136, 28);
            trainerText_Export_btn.Text = "Export Spreadsheet";
            trainerText_Export_btn.Click += trainerText_Export_btn_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 31);
            // 
            // trainerTextTable_addRow_btn
            // 
            trainerTextTable_addRow_btn.Image = Properties.Resources.plusIconSm;
            trainerTextTable_addRow_btn.ImageTransparentColor = Color.Magenta;
            trainerTextTable_addRow_btn.Name = "trainerTextTable_addRow_btn";
            trainerTextTable_addRow_btn.Size = new Size(94, 28);
            trainerTextTable_addRow_btn.Text = "Insert Entry";
            trainerTextTable_addRow_btn.Click += trainerTextTable_addRow_btn_Click;
            // 
            // trainerTextTable_delRow_btn
            // 
            trainerTextTable_delRow_btn.Image = Properties.Resources.minusIconSm;
            trainerTextTable_delRow_btn.ImageTransparentColor = Color.Magenta;
            trainerTextTable_delRow_btn.Name = "trainerTextTable_delRow_btn";
            trainerTextTable_delRow_btn.Size = new Size(98, 28);
            trainerTextTable_delRow_btn.Text = "Delete Entry";
            trainerTextTable_delRow_btn.Click += trainerTextTable_delRow_btn_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 31);
            // 
            // trainerText_sort
            // 
            trainerText_sort.Image = Properties.Resources.sortIconSm;
            trainerText_sort.ImageTransparentColor = Color.Magenta;
            trainerText_sort.Name = "trainerText_sort";
            trainerText_sort.Size = new Size(111, 28);
            trainerText_sort.Text = "Sort + Repoint";
            trainerText_sort.ToolTipText = "Arrange messages and repoint lookups";
            trainerText_sort.Click += trainerText_sort_Click;
            // 
            // mainContent_trainerTheme
            // 
            mainContent_trainerTheme.Controls.Add(panel14);
            mainContent_trainerTheme.Controls.Add(panel13);
            mainContent_trainerTheme.Location = new Point(4, 24);
            mainContent_trainerTheme.Name = "mainContent_trainerTheme";
            mainContent_trainerTheme.Padding = new Padding(3);
            mainContent_trainerTheme.Size = new Size(891, 489);
            mainContent_trainerTheme.TabIndex = 4;
            mainContent_trainerTheme.Text = "Trainer Themes";
            mainContent_trainerTheme.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(button10);
            panel14.Controls.Add(comboBox8);
            panel14.Controls.Add(label17);
            panel14.Controls.Add(comboBox7);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(label16);
            panel14.Controls.Add(pictureBox1);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(203, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(685, 483);
            panel14.TabIndex = 7;
            // 
            // button10
            // 
            button10.Image = Properties.Resources.saveIconSm;
            button10.Location = new Point(288, 259);
            button10.Name = "button10";
            button10.Size = new Size(56, 23);
            button10.TabIndex = 44;
            button10.Text = "Save";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.Enabled = false;
            comboBox8.FlatStyle = FlatStyle.Popup;
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(154, 260);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(128, 23);
            comboBox8.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ImageAlign = ContentAlignment.MiddleLeft;
            label17.Location = new Point(154, 238);
            label17.Name = "label17";
            label17.Size = new Size(79, 15);
            label17.TabIndex = 42;
            label17.Text = "Battle Music:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox7
            // 
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.Enabled = false;
            comboBox7.FlatStyle = FlatStyle.Popup;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(5, 260);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(131, 23);
            comboBox7.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ImageAlign = ContentAlignment.MiddleLeft;
            label18.Location = new Point(5, 238);
            label18.Name = "label18";
            label18.Size = new Size(82, 15);
            label18.TabIndex = 41;
            label18.Text = "VS Intro GFX:";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ImageAlign = ContentAlignment.MiddleLeft;
            label16.Location = new Point(5, 6);
            label16.Name = "label16";
            label16.Size = new Size(131, 15);
            label16.TabIndex = 37;
            label16.Text = "VS Intro GFX Preview:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(5, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 192);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // panel13
            // 
            panel13.Controls.Add(label15);
            panel13.Controls.Add(listBox1);
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 483);
            panel13.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ImageAlign = ContentAlignment.MiddleLeft;
            label15.Location = new Point(5, 6);
            label15.Name = "label15";
            label15.Size = new Size(96, 15);
            label15.TabIndex = 5;
            label15.Text = "Trainer Themes:";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(5, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 439);
            listBox1.TabIndex = 4;
            // 
            // quick_toolstrip
            // 
            quick_toolstrip.GripStyle = ToolStripGripStyle.Hidden;
            quick_toolstrip.ImageScalingSize = new Size(24, 24);
            quick_toolstrip.Items.AddRange(new ToolStripItem[] { openRom_btn, openFolder_btn, save_btn, toolStripSeparator1, languageLabel, versionLabel, romNameLabel, toolStripSeparator2 });
            quick_toolstrip.Location = new Point(0, 0);
            quick_toolstrip.Name = "quick_toolstrip";
            quick_toolstrip.Padding = new Padding(0, 0, 2, 0);
            quick_toolstrip.Size = new Size(899, 31);
            quick_toolstrip.TabIndex = 4;
            quick_toolstrip.Text = "toolStrip1";
            // 
            // openRom_btn
            // 
            openRom_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openRom_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            openRom_btn.Image = Properties.Resources.openRomIcon;
            openRom_btn.ImageTransparentColor = Color.Magenta;
            openRom_btn.Margin = new Padding(5, 1, 0, 2);
            openRom_btn.Name = "openRom_btn";
            openRom_btn.Size = new Size(28, 28);
            openRom_btn.Text = "Open ROM";
            openRom_btn.Click += openRom_btn_Click;
            // 
            // openFolder_btn
            // 
            openFolder_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openFolder_btn.Image = Properties.Resources.openFolderIcon;
            openFolder_btn.ImageTransparentColor = Color.Magenta;
            openFolder_btn.Margin = new Padding(0, 1, 2, 2);
            openFolder_btn.Name = "openFolder_btn";
            openFolder_btn.Size = new Size(28, 28);
            openFolder_btn.Text = "Open Extracted Folder";
            openFolder_btn.Click += openFolder_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Enabled = false;
            save_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Image = Properties.Resources.saveIcon;
            save_btn.ImageTransparentColor = Color.Magenta;
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(87, 28);
            save_btn.Text = "Save ROM";
            save_btn.Click += save_btn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // languageLabel
            // 
            languageLabel.Alignment = ToolStripItemAlignment.Right;
            languageLabel.Margin = new Padding(0, 1, 2, 2);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(22, 28);
            languageLabel.Text = "     ";
            // 
            // versionLabel
            // 
            versionLabel.Alignment = ToolStripItemAlignment.Right;
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(22, 28);
            versionLabel.Text = "     ";
            // 
            // romNameLabel
            // 
            romNameLabel.Alignment = ToolStripItemAlignment.Right;
            romNameLabel.Name = "romNameLabel";
            romNameLabel.RightToLeft = RightToLeft.No;
            romNameLabel.Size = new Size(61, 28);
            romNameLabel.Text = "ROM Info:";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // panel1
            // 
            panel1.Controls.Add(quick_toolstrip);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 25);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(mainContent);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 517);
            panel2.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ImageAlign = ContentAlignment.MiddleLeft;
            label14.Location = new Point(15, 9);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 49;
            label14.Text = "Trainer AI";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_ai_Basic_checkbox
            // 
            trainer_ai_Basic_checkbox.AutoSize = true;
            trainer_ai_Basic_checkbox.Enabled = false;
            trainer_ai_Basic_checkbox.FlatAppearance.BorderSize = 2;
            trainer_ai_Basic_checkbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_Basic_checkbox.Location = new Point(15, 40);
            trainer_ai_Basic_checkbox.Name = "trainer_ai_Basic_checkbox";
            trainer_ai_Basic_checkbox.Size = new Size(53, 19);
            trainer_ai_Basic_checkbox.TabIndex = 52;
            trainer_ai_Basic_checkbox.Text = "Basic";
            trainer_ai_Basic_checkbox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_evaluate_checkBox
            // 
            trainer_ai_evaluate_checkBox.AutoSize = true;
            trainer_ai_evaluate_checkBox.Enabled = false;
            trainer_ai_evaluate_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_evaluate_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_evaluate_checkBox.Location = new Point(15, 65);
            trainer_ai_evaluate_checkBox.Name = "trainer_ai_evaluate_checkBox";
            trainer_ai_evaluate_checkBox.Size = new Size(94, 19);
            trainer_ai_evaluate_checkBox.TabIndex = 53;
            trainer_ai_evaluate_checkBox.Text = "Evaluate Atk.";
            trainer_ai_evaluate_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_expert_checkBox
            // 
            trainer_ai_expert_checkBox.AutoSize = true;
            trainer_ai_expert_checkBox.Enabled = false;
            trainer_ai_expert_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_expert_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_expert_checkBox.Location = new Point(117, 40);
            trainer_ai_expert_checkBox.Name = "trainer_ai_expert_checkBox";
            trainer_ai_expert_checkBox.Size = new Size(59, 19);
            trainer_ai_expert_checkBox.TabIndex = 54;
            trainer_ai_expert_checkBox.Text = "Expert";
            trainer_ai_expert_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_status_checkBox
            // 
            trainer_ai_status_checkBox.AutoSize = true;
            trainer_ai_status_checkBox.Enabled = false;
            trainer_ai_status_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_status_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_status_checkBox.Location = new Point(15, 90);
            trainer_ai_status_checkBox.Name = "trainer_ai_status_checkBox";
            trainer_ai_status_checkBox.Size = new Size(58, 19);
            trainer_ai_status_checkBox.TabIndex = 55;
            trainer_ai_status_checkBox.Text = "Status";
            trainer_ai_status_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_misc_checkBox
            // 
            trainer_ai_misc_checkBox.AutoSize = true;
            trainer_ai_misc_checkBox.Enabled = false;
            trainer_ai_misc_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_misc_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_misc_checkBox.Location = new Point(15, 165);
            trainer_ai_misc_checkBox.Name = "trainer_ai_misc_checkBox";
            trainer_ai_misc_checkBox.Size = new Size(41, 19);
            trainer_ai_misc_checkBox.TabIndex = 59;
            trainer_ai_misc_checkBox.Text = "???";
            trainer_ai_misc_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_baton_checkBox
            // 
            trainer_ai_baton_checkBox.AutoSize = true;
            trainer_ai_baton_checkBox.Enabled = false;
            trainer_ai_baton_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_baton_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_baton_checkBox.Location = new Point(15, 140);
            trainer_ai_baton_checkBox.Name = "trainer_ai_baton_checkBox";
            trainer_ai_baton_checkBox.Size = new Size(83, 19);
            trainer_ai_baton_checkBox.TabIndex = 58;
            trainer_ai_baton_checkBox.Text = "Baton Pass";
            trainer_ai_baton_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_dmg_checkBox
            // 
            trainer_ai_dmg_checkBox.AutoSize = true;
            trainer_ai_dmg_checkBox.Enabled = false;
            trainer_ai_dmg_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_dmg_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_dmg_checkBox.Location = new Point(117, 65);
            trainer_ai_dmg_checkBox.Name = "trainer_ai_dmg_checkBox";
            trainer_ai_dmg_checkBox.Size = new Size(111, 19);
            trainer_ai_dmg_checkBox.TabIndex = 57;
            trainer_ai_dmg_checkBox.Text = "Damage Priority";
            trainer_ai_dmg_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_risk_checkBox
            // 
            trainer_ai_risk_checkBox.AutoSize = true;
            trainer_ai_risk_checkBox.Enabled = false;
            trainer_ai_risk_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_risk_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_risk_checkBox.Location = new Point(15, 115);
            trainer_ai_risk_checkBox.Name = "trainer_ai_risk_checkBox";
            trainer_ai_risk_checkBox.Size = new Size(47, 19);
            trainer_ai_risk_checkBox.TabIndex = 56;
            trainer_ai_risk_checkBox.Text = "Risk";
            trainer_ai_risk_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_tag_checkBox
            // 
            trainer_ai_tag_checkBox.AutoSize = true;
            trainer_ai_tag_checkBox.Enabled = false;
            trainer_ai_tag_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_tag_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_tag_checkBox.Location = new Point(117, 140);
            trainer_ai_tag_checkBox.Name = "trainer_ai_tag_checkBox";
            trainer_ai_tag_checkBox.Size = new Size(75, 19);
            trainer_ai_tag_checkBox.TabIndex = 62;
            trainer_ai_tag_checkBox.Text = "Tag Team";
            trainer_ai_tag_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_weather_checkBox
            // 
            trainer_ai_weather_checkBox.AutoSize = true;
            trainer_ai_weather_checkBox.Enabled = false;
            trainer_ai_weather_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_weather_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_weather_checkBox.Location = new Point(117, 90);
            trainer_ai_weather_checkBox.Name = "trainer_ai_weather_checkBox";
            trainer_ai_weather_checkBox.Size = new Size(108, 19);
            trainer_ai_weather_checkBox.TabIndex = 61;
            trainer_ai_weather_checkBox.Text = "Weather Effects";
            trainer_ai_weather_checkBox.UseVisualStyleBackColor = true;
            // 
            // trainer_ai_checkHp_checkBox
            // 
            trainer_ai_checkHp_checkBox.AutoSize = true;
            trainer_ai_checkHp_checkBox.Enabled = false;
            trainer_ai_checkHp_checkBox.FlatAppearance.BorderSize = 2;
            trainer_ai_checkHp_checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_ai_checkHp_checkBox.Location = new Point(117, 115);
            trainer_ai_checkHp_checkBox.Name = "trainer_ai_checkHp_checkBox";
            trainer_ai_checkHp_checkBox.Size = new Size(78, 19);
            trainer_ai_checkHp_checkBox.TabIndex = 60;
            trainer_ai_checkHp_checkBox.Text = "Check HP";
            trainer_ai_checkHp_checkBox.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ImageAlign = ContentAlignment.MiddleLeft;
            label19.Location = new Point(252, 9);
            label19.Name = "label19";
            label19.Size = new Size(89, 15);
            label19.TabIndex = 63;
            label19.Text = "Trainer's Items";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Item1_comboBox
            // 
            trainer_Item1_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Item1_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Item1_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Item1_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Item1_comboBox.Enabled = false;
            trainer_Item1_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Item1_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Item1_comboBox.FormattingEnabled = true;
            trainer_Item1_comboBox.ImeMode = ImeMode.Off;
            trainer_Item1_comboBox.Location = new Point(274, 36);
            trainer_Item1_comboBox.Name = "trainer_Item1_comboBox";
            trainer_Item1_comboBox.Size = new Size(113, 23);
            trainer_Item1_comboBox.TabIndex = 96;
            // 
            // trainer_Item2_comboBox
            // 
            trainer_Item2_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Item2_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Item2_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Item2_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Item2_comboBox.Enabled = false;
            trainer_Item2_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Item2_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Item2_comboBox.FormattingEnabled = true;
            trainer_Item2_comboBox.ImeMode = ImeMode.Off;
            trainer_Item2_comboBox.Location = new Point(274, 65);
            trainer_Item2_comboBox.Name = "trainer_Item2_comboBox";
            trainer_Item2_comboBox.Size = new Size(113, 23);
            trainer_Item2_comboBox.TabIndex = 98;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ImageAlign = ContentAlignment.MiddleLeft;
            label22.Location = new Point(254, 39);
            label22.Name = "label22";
            label22.Size = new Size(14, 15);
            label22.TabIndex = 99;
            label22.Text = "1";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ImageAlign = ContentAlignment.MiddleLeft;
            label23.Location = new Point(254, 68);
            label23.Name = "label23";
            label23.Size = new Size(14, 15);
            label23.TabIndex = 100;
            label23.Text = "2";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ImageAlign = ContentAlignment.MiddleLeft;
            label24.Location = new Point(254, 126);
            label24.Name = "label24";
            label24.Size = new Size(14, 15);
            label24.TabIndex = 104;
            label24.Text = "4";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ImageAlign = ContentAlignment.MiddleLeft;
            label25.Location = new Point(254, 97);
            label25.Name = "label25";
            label25.Size = new Size(14, 15);
            label25.TabIndex = 103;
            label25.Text = "3";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainer_Item4_comboBox
            // 
            trainer_Item4_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Item4_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Item4_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Item4_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Item4_comboBox.Enabled = false;
            trainer_Item4_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Item4_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Item4_comboBox.FormattingEnabled = true;
            trainer_Item4_comboBox.ImeMode = ImeMode.Off;
            trainer_Item4_comboBox.Location = new Point(274, 123);
            trainer_Item4_comboBox.Name = "trainer_Item4_comboBox";
            trainer_Item4_comboBox.Size = new Size(113, 23);
            trainer_Item4_comboBox.TabIndex = 102;
            trainer_Item4_comboBox.SelectedIndexChanged += trainer_Item4_comboBox_SelectedIndexChanged;
            // 
            // trainer_Item3_comboBox
            // 
            trainer_Item3_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trainer_Item3_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            trainer_Item3_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            trainer_Item3_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trainer_Item3_comboBox.Enabled = false;
            trainer_Item3_comboBox.FlatStyle = FlatStyle.Popup;
            trainer_Item3_comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Item3_comboBox.FormattingEnabled = true;
            trainer_Item3_comboBox.ImeMode = ImeMode.Off;
            trainer_Item3_comboBox.Location = new Point(274, 94);
            trainer_Item3_comboBox.Name = "trainer_Item3_comboBox";
            trainer_Item3_comboBox.Size = new Size(113, 23);
            trainer_Item3_comboBox.TabIndex = 101;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(899, 588);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(main_toolstrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel8.ResumeLayout(false);
            trainerEditor_tab.ResumeLayout(false);
            trainerEditor_Pokemon.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke6_Level).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke5_Level).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke4_Level).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke3_Level).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke2_Level).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke1_Level).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainer_Poke_Num_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_NumPoke_num).EndInit();
            trainerEditor_trnProperties.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainer_frames_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerPicBox).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            mainContent_trainerText.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel16.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerTextTable_dataGrid).EndInit();
            trainerText_toolstrip.ResumeLayout(false);
            trainerText_toolstrip.PerformLayout();
            mainContent_trainerTheme.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource).EndInit();
            quick_toolstrip.ResumeLayout(false);
            quick_toolstrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerMessageBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip main_toolstrip;
        private ToolStripMenuItem mainToolStrip_file;
        private ToolStripMenuItem openRom_toolstrip;
        private ToolStripMenuItem openFolder_toolstrip;
        private ToolStripMenuItem save_toolstrip;
        private ToolStripMenuItem mainToolStrip_help;
        private ToolStripMenuItem about_toolstrip;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
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
        private NumericUpDown trainerClass_PrizeMoney_num;
        private Label trainerClass_PrizeMoney_label;
        private Button trainerClass_PrizeMoney_btn;
        private ComboBox trainerClass_Gender_comboBox;
        private Label trainerClass_Gender_label;
        private ComboBox trainerClass_EyeContactMain_comboBox;
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
        private NumericUpDown trainer_frames_num;
        private Label label3;
        private PictureBox trainerPicBox;
        private Label label4;
        private Button save_TrainerName_btn;
        private TextBox trainer_Name;
        private Label trainer_Name_Label;
        private Panel panel8;
        private Panel panel9;
        private TabControl trainerEditor_tab;
        private Label label6;
        private TabPage trainerEditor_trnProperties;
        private SaveFileDialog saveFileDialog1;
        private Panel panel12;
        private Panel panel7;
        private TabPage mainContent_trainerTheme;
        private Panel panel13;
        private Label label15;
        private ListBox listBox1;
        private Panel panel14;
        private Label label16;
        private PictureBox pictureBox1;
        private Button button10;
        private ComboBox comboBox8;
        private Label label17;
        private ComboBox comboBox7;
        private Label label18;
        private BindingSource trainerMessageBindingSource;
        private Button saveTrainerClassAll_btn;
        private Label label21;
        private Label label20;
        private Button saveClassProperties_btn;
        private Button undoTrainerClass_btn;
        private Button undoTrainer_btn;
        private Button saveTrainerAll_btn;
        private Button trainer_EditMessage_btn;
        private BindingSource trainerMessageBindingSource1;
        private BindingSource trainerMessageBindingSource2;
        private BindingSource trainerMessageBindingSource3;
        private Panel panel17;
        private ToolStrip trainerText_toolstrip;
        private ToolStripButton toolStripButton3;
        private ToolStripButton trainreText_Import_btn;
        private ToolStripButton trainerText_Export_btn;
        private DataGridView trainerTextTable_dataGrid;
        private Panel panel16;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton trainerTextTable_addRow_btn;
        private ToolStripButton trainerTextTable_delRow_btn;
        private ToolStripSeparator toolStripSeparator4;
        private Panel panel15;
        private Panel panel18;
        private TabPage trainerEditor_Pokemon;
        private Panel panel10;
        private Panel panel11;
        private Label label7;
        private NumericUpDown trainer_NumPoke_num;
        private Panel panel19;
        private Button trainer_Poke1_Stats_btn;
        private ComboBox trainer_Poke1_comboBox;
        private Panel panel20;
        private Button saveTrainerPoke_btn;
        private Button trainer_Message_Next_btn;
        private Button trainer_Message_Back_btn;
        private Panel panel21;
        private Label trainer_Message;
        private ComboBox trainer_MessageTrigger_list;
        private Label trainerTextTable_help_label;
        private ToolStripButton trainerText_sort;
        private Button trainer_Player_help_btn;
        private DataGridViewTextBoxColumn MessageId;
        private DataGridViewComboBoxColumn TrainerId;
        private DataGridViewComboBoxColumn MessageTriggerId;
        private DataGridViewTextBoxColumn Message;
        private Label label8;
        private NumericUpDown trainer_Poke1_Level;
        private Button saveTrainerProperties_btn;
        private CheckBox trainer_Double_checkBox;
        private CheckBox trainer_Poke_Moves_checkBox;
        private CheckBox trainer_Poke_HeldItem_checkBox;
        private Button trainer_Poke1_Moves_btn;
        private ComboBox trainer_Poke1_Item;
        private PictureBox trainer_Poke_Num_pic;
        private PictureBox pictureBox5;
        private ComboBox trainer_Poke6_Item;
        private Button trainer_Poke6_Moves_btn;
        private Label label11;
        private NumericUpDown trainer_Poke6_Level;
        private ComboBox trainer_Poke6_comboBox;
        private Button trainer_Poke6_Stats_btn;
        private PictureBox pictureBox6;
        private ComboBox trainer_Poke5_Item;
        private Button trainer_Poke5_Moves_btn;
        private Label label12;
        private NumericUpDown trainer_Poke5_Level;
        private ComboBox trainer_Poke5_comboBox;
        private Button trainer_Poke5_Stats_btn;
        private PictureBox pictureBox7;
        private ComboBox trainer_Poke4_Item;
        private Button trainer_Poke4_Moves_btn;
        private Label label13;
        private NumericUpDown trainer_Poke4_Level;
        private ComboBox trainer_Poke4_comboBox;
        private Button trainer_Poke4_Stats_btn;
        private PictureBox pictureBox4;
        private ComboBox trainer_Poke3_Item;
        private Button trainer_Poke3_Moves_btn;
        private Label label10;
        private NumericUpDown trainer_Poke3_Level;
        private ComboBox trainer_Poke3_comboBox;
        private Button trainer_Poke3_Stats_btn;
        private PictureBox pictureBox3;
        private ComboBox trainer_Poke2_Item;
        private Button trainer_Poke2_Moves_btn;
        private Label label9;
        private NumericUpDown trainer_Poke2_Level;
        private ComboBox trainer_Poke2_comboBox;
        private Button trainer_Poke2_Stats_btn;
        private PictureBox pictureBox2;
        private Label label24;
        private Label label25;
        private ComboBox trainer_Item4_comboBox;
        private ComboBox trainer_Item3_comboBox;
        private Label label23;
        private Label label22;
        private ComboBox trainer_Item2_comboBox;
        private ComboBox trainer_Item1_comboBox;
        private Label label19;
        private CheckBox trainer_ai_tag_checkBox;
        private CheckBox trainer_ai_weather_checkBox;
        private CheckBox trainer_ai_checkHp_checkBox;
        private CheckBox trainer_ai_misc_checkBox;
        private CheckBox trainer_ai_baton_checkBox;
        private CheckBox trainer_ai_dmg_checkBox;
        private CheckBox trainer_ai_risk_checkBox;
        private CheckBox trainer_ai_status_checkBox;
        private CheckBox trainer_ai_expert_checkBox;
        private CheckBox trainer_ai_evaluate_checkBox;
        private CheckBox trainer_ai_Basic_checkbox;
        private Label label14;
    }
}