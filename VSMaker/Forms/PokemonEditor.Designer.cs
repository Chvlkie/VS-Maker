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
            pokeSprite_back = new PictureBox();
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
            pokeSprite_front = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pokeSprite_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_slider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokeSprite_front).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(412, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(pokeSprite_back);
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
            panel1.Controls.Add(pokeSprite_front);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 240);
            panel1.TabIndex = 1;
            // 
            // pokeSprite_back
            // 
            pokeSprite_back.BackColor = Color.White;
            pokeSprite_back.BorderStyle = BorderStyle.Fixed3D;
            pokeSprite_back.Image = Properties.Resources.pokeSprite;
            pokeSprite_back.Location = new Point(12, 131);
            pokeSprite_back.Name = "pokeSprite_back";
            pokeSprite_back.Padding = new Padding(8, 8, 0, 0);
            pokeSprite_back.Size = new Size(100, 100);
            pokeSprite_back.TabIndex = 49;
            pokeSprite_back.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(364, 216);
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
            label10.Location = new Point(142, 216);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 47;
            label10.Text = "Easy";
            // 
            // pokeStat_BallSeal_comboBox
            // 
            pokeStat_BallSeal_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pokeStat_BallSeal_comboBox.FormattingEnabled = true;
            pokeStat_BallSeal_comboBox.Location = new Point(281, 131);
            pokeStat_BallSeal_comboBox.Name = "pokeStat_BallSeal_comboBox";
            pokeStat_BallSeal_comboBox.Size = new Size(117, 23);
            pokeStat_BallSeal_comboBox.TabIndex = 46;
            pokeStat_BallSeal_comboBox.SelectedIndexChanged += pokeStat_BallSeal_comboBox_SelectedIndexChanged;
            // 
            // pokeStat_Dv_slider
            // 
            pokeStat_Dv_slider.Location = new Point(135, 171);
            pokeStat_Dv_slider.Margin = new Padding(15);
            pokeStat_Dv_slider.Maximum = 255;
            pokeStat_Dv_slider.Name = "pokeStat_Dv_slider";
            pokeStat_Dv_slider.Size = new Size(263, 45);
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
            pokeStat_Form_comboBox.Location = new Point(140, 78);
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
            label7.Location = new Point(281, 7);
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
            pokeStat_Ability_comboBox.Location = new Point(281, 78);
            pokeStat_Ability_comboBox.Name = "pokeStat_Ability_comboBox";
            pokeStat_Ability_comboBox.Size = new Size(117, 23);
            pokeStat_Ability_comboBox.TabIndex = 38;
            pokeStat_Ability_comboBox.SelectedIndexChanged += pokeStat_Ability_comboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(281, 60);
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
            label5.Location = new Point(281, 113);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 35;
            label5.Text = "Ball Seal";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pokeStat_Dv_num
            // 
            pokeStat_Dv_num.Location = new Point(142, 131);
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
            pokeStat_Nature_comboBox.Location = new Point(281, 25);
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
            pokeStat_Gender_comboBox.Location = new Point(140, 25);
            pokeStat_Gender_comboBox.Name = "pokeStat_Gender_comboBox";
            pokeStat_Gender_comboBox.Size = new Size(117, 23);
            pokeStat_Gender_comboBox.TabIndex = 32;
            pokeStat_Gender_comboBox.SelectedIndexChanged += pokeStat_Gender_comboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(140, 7);
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
            label2.Location = new Point(140, 60);
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
            label1.Location = new Point(140, 113);
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
            // pokeSprite_front
            // 
            pokeSprite_front.BackColor = Color.White;
            pokeSprite_front.BorderStyle = BorderStyle.Fixed3D;
            pokeSprite_front.Image = Properties.Resources.pokeSprite;
            pokeSprite_front.Location = new Point(12, 25);
            pokeSprite_front.Name = "pokeSprite_front";
            pokeSprite_front.Padding = new Padding(8, 8, 0, 0);
            pokeSprite_front.Size = new Size(100, 100);
            pokeSprite_front.TabIndex = 0;
            pokeSprite_front.TabStop = false;
            // 
            // PokemonEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 265);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "PokemonEditor";
            Text = "Pokemon Stats";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pokeSprite_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_slider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokeStat_Dv_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokeSprite_front).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
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
        private PictureBox pokeSprite_front;
        private PictureBox pokeSprite_back;
    }
}