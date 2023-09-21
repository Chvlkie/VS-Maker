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
            label1 = new Label();
            textEditor_Save_btn = new Button();
            textEditor_Message = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            panel21 = new Panel();
            trainer_Message = new Label();
            trainer_Message_Back_btn = new Button();
            trainer_Message_Next_btn = new Button();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel21.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
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
            textEditor_Message.Location = new Point(12, 60);
            textEditor_Message.Name = "textEditor_Message";
            textEditor_Message.Size = new Size(560, 84);
            textEditor_Message.TabIndex = 1;
            textEditor_Message.Text = "";
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
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
    }
}