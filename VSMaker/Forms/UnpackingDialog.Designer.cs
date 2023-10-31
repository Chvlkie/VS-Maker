namespace VSMaker.Forms
{
    partial class UnpackingDialog
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
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 76);
            panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(47, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(350, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            progressBar1.Value = 100;
            // 
            // UnpackingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 76);
            ControlBox = false;
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnpackingDialog";
            Text = "Unpacking Essential NARS";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar progressBar1;
    }
}