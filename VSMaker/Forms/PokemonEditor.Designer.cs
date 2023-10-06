namespace VSMaker.Forms
{
    partial class PokemonEditor
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
            toolStrip1 = new ToolStrip();
            pokeStat_Save_tooltip = new ToolStripButton();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            pokeSprite = new PictureBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox5 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            comboBox6 = new ComboBox();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokeSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { pokeStat_Save_tooltip });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(432, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // pokeStat_Save_tooltip
            // 
            pokeStat_Save_tooltip.Image = Properties.Resources.saveIconSm;
            pokeStat_Save_tooltip.ImageTransparentColor = Color.Magenta;
            pokeStat_Save_tooltip.Name = "pokeStat_Save_tooltip";
            pokeStat_Save_tooltip.Size = new Size(51, 22);
            pokeStat_Save_tooltip.Text = "Save";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox6);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pokeSprite);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 462);
            panel1.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(208, 122);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(71, 23);
            comboBox3.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(208, 104);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 35;
            label5.Text = "Ball Seal";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(315, 24);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 23);
            numericUpDown1.TabIndex = 34;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(315, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(70, 23);
            comboBox2.TabIndex = 33;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 23);
            comboBox1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(42, 186);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 31;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(143, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 30;
            label2.Text = "Form";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(310, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 29;
            label1.Text = "Difficulty (DV)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(14, 6);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 28;
            label4.Text = "Pokemon Sprite";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pokeSprite
            // 
            pokeSprite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pokeSprite.BackColor = Color.White;
            pokeSprite.BorderStyle = BorderStyle.Fixed3D;
            pokeSprite.Location = new Point(14, 24);
            pokeSprite.Name = "pokeSprite";
            pokeSprite.Size = new Size(188, 107);
            pokeSprite.TabIndex = 0;
            pokeSprite.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(315, 50);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 37;
            label6.Text = "Ability";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(208, 68);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(71, 23);
            comboBox4.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(208, 50);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 39;
            label7.Text = "Nature";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(208, 6);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 40;
            label8.Text = "Level:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(14, 134);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 41;
            label9.Text = "Pokemon";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(14, 152);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(188, 23);
            comboBox5.TabIndex = 42;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(208, 24);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(71, 23);
            numericUpDown2.TabIndex = 43;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(144, 204);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(80, 23);
            comboBox6.TabIndex = 44;
            // 
            // PokemonEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 487);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "PokemonEditor";
            Text = "Pokemon Stats";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokeSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton pokeStat_Save_tooltip;
        private Panel panel1;
        private PictureBox pokeSprite;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox6;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox5;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox comboBox4;
        private Label label6;
    }
}