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
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            pokeStat_BallSeal_comboBox = new ComboBox();
            pokeStat_Dv_slider = new TrackBar();
            pokeStat_Form_comboBox = new ComboBox();
            label7 = new Label();
            pokeStat_Ability_comboBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            pokeStat_Dv_num = new NumericUpDown();
            pokeStat_Nature_comboBox = new ComboBox();
            pokeStat_Gender_comboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            pokeSprite = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_slider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokeSprite).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(492, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pokeStat_BallSeal_comboBox);
            panel1.Controls.Add(pokeStat_Dv_slider);
            panel1.Controls.Add(pokeStat_Form_comboBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pokeStat_Ability_comboBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pokeStat_Dv_num);
            panel1.Controls.Add(pokeStat_Nature_comboBox);
            panel1.Controls.Add(pokeStat_Gender_comboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pokeSprite);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 240);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(156, 216);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 48;
            label11.Text = "Hard";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.LimeGreen;
            label10.Location = new Point(12, 216);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 47;
            label10.Text = "Easy";
            // 
            // pokeStat_BallSeal_comboBox
            // 
            pokeStat_BallSeal_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pokeStat_BallSeal_comboBox.FormattingEnabled = true;
            pokeStat_BallSeal_comboBox.Location = new Point(219, 141);
            pokeStat_BallSeal_comboBox.Name = "pokeStat_BallSeal_comboBox";
            pokeStat_BallSeal_comboBox.Size = new Size(117, 23);
            pokeStat_BallSeal_comboBox.TabIndex = 46;
            // 
            // pokeStat_Dv_slider
            // 
            pokeStat_Dv_slider.Location = new Point(12, 175);
            pokeStat_Dv_slider.Margin = new Padding(15);
            pokeStat_Dv_slider.Maximum = 255;
            pokeStat_Dv_slider.Name = "pokeStat_Dv_slider";
            pokeStat_Dv_slider.Size = new Size(188, 45);
            pokeStat_Dv_slider.TabIndex = 45;
            pokeStat_Dv_slider.Value = 1;
            pokeStat_Dv_slider.Scroll += pokeStat_Dv_slider_Scroll;
            // 
            // pokeStat_Form_comboBox
            // 
            pokeStat_Form_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pokeStat_Form_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            pokeStat_Form_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pokeStat_Form_comboBox.FormattingEnabled = true;
            pokeStat_Form_comboBox.Location = new Point(363, 25);
            pokeStat_Form_comboBox.Name = "pokeStat_Form_comboBox";
            pokeStat_Form_comboBox.Size = new Size(117, 23);
            pokeStat_Form_comboBox.TabIndex = 44;
            pokeStat_Form_comboBox.SelectedIndexChanged += pokeStat_Form_comboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(219, 60);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 39;
            label7.Text = "Nature";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pokeStat_Ability_comboBox
            // 
            pokeStat_Ability_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pokeStat_Ability_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            pokeStat_Ability_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pokeStat_Ability_comboBox.Enabled = false;
            pokeStat_Ability_comboBox.FormattingEnabled = true;
            pokeStat_Ability_comboBox.Location = new Point(363, 78);
            pokeStat_Ability_comboBox.Name = "pokeStat_Ability_comboBox";
            pokeStat_Ability_comboBox.Size = new Size(117, 23);
            pokeStat_Ability_comboBox.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(363, 60);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 37;
            label6.Text = "Ability";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(219, 121);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 35;
            label5.Text = "Ball Seal";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pokeStat_Dv_num
            // 
            pokeStat_Dv_num.Location = new Point(140, 142);
            pokeStat_Dv_num.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            pokeStat_Dv_num.Name = "pokeStat_Dv_num";
            pokeStat_Dv_num.Size = new Size(50, 23);
            pokeStat_Dv_num.TabIndex = 34;
            pokeStat_Dv_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            pokeStat_Dv_num.ValueChanged += pokeStat_Dv_num_ValueChanged;
            // 
            // pokeStat_Nature_comboBox
            // 
            pokeStat_Nature_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pokeStat_Nature_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            pokeStat_Nature_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pokeStat_Nature_comboBox.FormattingEnabled = true;
            pokeStat_Nature_comboBox.Location = new Point(219, 78);
            pokeStat_Nature_comboBox.Name = "pokeStat_Nature_comboBox";
            pokeStat_Nature_comboBox.Size = new Size(117, 23);
            pokeStat_Nature_comboBox.TabIndex = 33;
            // 
            // pokeStat_Gender_comboBox
            // 
            pokeStat_Gender_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pokeStat_Gender_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            pokeStat_Gender_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pokeStat_Gender_comboBox.FormattingEnabled = true;
            pokeStat_Gender_comboBox.Location = new Point(219, 25);
            pokeStat_Gender_comboBox.Name = "pokeStat_Gender_comboBox";
            pokeStat_Gender_comboBox.Size = new Size(117, 23);
            pokeStat_Gender_comboBox.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(219, 7);
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
            label2.Location = new Point(363, 7);
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
            label1.Location = new Point(12, 145);
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
            label4.Location = new Point(12, 7);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 28;
            label4.Text = "Pokemon Sprite";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pokeSprite
            // 
            pokeSprite.BackColor = Color.White;
            pokeSprite.BorderStyle = BorderStyle.Fixed3D;
            pokeSprite.Location = new Point(12, 25);
            pokeSprite.Name = "pokeSprite";
            pokeSprite.Size = new Size(188, 111);
            pokeSprite.TabIndex = 0;
            pokeSprite.TabStop = false;
            // 
            // PokemonEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 265);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "PokemonEditor";
            Text = "Pokemon Stats";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_slider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokeSprite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private PictureBox pokeSprite;
        private Label label4;
        private Label label5;
        private NumericUpDown pokeStat_Dv_num;
        private ComboBox pokeStat_Nature_comboBox;
        private ComboBox pokeStat_Gender_comboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox pokeStat_Form_comboBox;
        private Label label7;
        private ComboBox pokeStat_Ability_comboBox;
        private Label label6;
        private TrackBar pokeStat_Dv_slider;
        private Label label11;
        private Label label10;
        private ComboBox pokeStat_BallSeal_comboBox;
    }
}