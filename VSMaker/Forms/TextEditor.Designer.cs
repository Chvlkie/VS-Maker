namespace VSMaker.Forms
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            panel1 = new Panel();
            button1 = new Button();
            addLine_btn = new Button();
            panel21 = new Panel();
            trainer_Message = new Label();
            trainer_Message_Back_btn = new Button();
            trainer_Message_Next_btn = new Button();
            label1 = new Label();
            textEditor_Save_btn = new Button();
            textEditor_Message = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            textEditor_editText = new RichTextBox();
            label2 = new Label();
            current_Page = new NumericUpDown();
            label3 = new Label();
            pages_Max = new Label();
            panel1.SuspendLayout();
            panel21.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)current_Page).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pages_Max);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(current_Page);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textEditor_editText);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(addLine_btn);
            panel1.Controls.Add(panel21);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textEditor_Save_btn);
            panel1.Controls.Add(textEditor_Message);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 261);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(466, 101);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 55;
            button1.Text = "Remove Page";
            button1.UseVisualStyleBackColor = true;
            // 
            // addLine_btn
            // 
            addLine_btn.Location = new Point(466, 72);
            addLine_btn.Name = "addLine_btn";
            addLine_btn.Size = new Size(106, 23);
            addLine_btn.TabIndex = 51;
            addLine_btn.Text = "Insert Page";
            addLine_btn.UseVisualStyleBackColor = true;
            addLine_btn.Click += addLine_btn_Click;
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel21.BackgroundImage = Properties.Resources.MessageBox;
            panel21.BackgroundImageLayout = ImageLayout.Stretch;
            panel21.Controls.Add(trainer_Message);
            panel21.Controls.Add(trainer_Message_Back_btn);
            panel21.Controls.Add(trainer_Message_Next_btn);
            panel21.Location = new Point(12, 165);
            panel21.Name = "panel21";
            panel21.Size = new Size(448, 84);
            panel21.TabIndex = 50;
            // 
            // trainer_Message
            // 
            trainer_Message.AutoSize = true;
            trainer_Message.BackColor = Color.White;
            trainer_Message.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            trainer_Message.ImageAlign = ContentAlignment.MiddleLeft;
            trainer_Message.Location = new Point(24, 18);
            trainer_Message.Name = "trainer_Message";
            trainer_Message.Size = new Size(203, 34);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Message Text";
            // 
            // textEditor_Save_btn
            // 
            textEditor_Save_btn.Image = Properties.Resources.saveIconSm;
            textEditor_Save_btn.Location = new Point(516, 226);
            textEditor_Save_btn.Name = "textEditor_Save_btn";
            textEditor_Save_btn.Size = new Size(56, 23);
            textEditor_Save_btn.TabIndex = 2;
            textEditor_Save_btn.Text = "Save";
            textEditor_Save_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            textEditor_Save_btn.UseVisualStyleBackColor = true;
            // 
            // textEditor_Message
            // 
            textEditor_Message.Location = new Point(466, 193);
            textEditor_Message.Name = "textEditor_Message";
            textEditor_Message.Size = new Size(100, 27);
            textEditor_Message.TabIndex = 1;
            textEditor_Message.Text = "";
            textEditor_Message.Visible = false;
            textEditor_Message.TextChanged += textEditor_Message_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton4, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(584, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.undoIconSm;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(56, 22);
            toolStripButton3.Text = "Undo";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(54, 22);
            toolStripButton4.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // textEditor_editText
            // 
            textEditor_editText.Location = new Point(12, 57);
            textEditor_editText.Name = "textEditor_editText";
            textEditor_editText.Size = new Size(448, 97);
            textEditor_editText.TabIndex = 56;
            textEditor_editText.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(423, 34);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 57;
            label2.Text = "Page:";
            // 
            // current_Page
            // 
            current_Page.Location = new Point(466, 32);
            current_Page.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            current_Page.Name = "current_Page";
            current_Page.Size = new Size(53, 23);
            current_Page.TabIndex = 58;
            current_Page.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(525, 34);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 59;
            label3.Text = "/";
            // 
            // pages_Max
            // 
            pages_Max.AutoSize = true;
            pages_Max.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pages_Max.Location = new Point(543, 35);
            pages_Max.Name = "pages_Max";
            pages_Max.Size = new Size(14, 15);
            pages_Max.TabIndex = 60;
            pages_Max.Text = "0";
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TextEditor";
            Text = "TextEditor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)current_Page).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button textEditor_Save_btn;
        private RichTextBox textEditor_Message;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator2;
        private Label label1;
        private Panel panel21;
        private Label trainer_Message;
        private Button trainer_Message_Back_btn;
        private Button trainer_Message_Next_btn;
        private Button addLine_btn;
        private Button button1;
        private Label pages_Max;
        private Label label3;
        private NumericUpDown current_Page;
        private Label label2;
        private RichTextBox textEditor_editText;
    }
}