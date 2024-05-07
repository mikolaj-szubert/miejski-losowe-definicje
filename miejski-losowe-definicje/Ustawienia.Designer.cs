namespace LosoweDefinicje
{
    partial class Ustawienia
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(203, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 25);
            button1.TabIndex = 4;
            button1.Text = "✕";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 4);
            label1.Margin = new Padding(70, 10, 70, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 5;
            label1.Text = "Ustawienia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 30);
            label2.Margin = new Padding(5);
            label2.MaximumSize = new Size(250, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 30);
            label2.TabIndex = 6;
            label2.Text = "Częstotliwość zmiany definicji na nową w minutach (0 - wyłącz)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.Black;
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(14, 68);
            numericUpDown1.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(225, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 16, 16);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 105);
            button2.Margin = new Padding(3, 0, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(225, 26);
            button2.TabIndex = 8;
            button2.Text = "Zapisz";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += numericUpDown1_ValueChanged;
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(253, 147);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(253, 147);
            MinimizeBox = false;
            MinimumSize = new Size(253, 147);
            Name = "Ustawienia";
            Opacity = 0.9D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += Ustawienia_FormClosing;
            Load += Ustawienia_Load;
            MouseDown += Ustawienia_MouseDown;
            MouseMove += Ustawienia_MouseMove;
            MouseUp += Ustawienia_MouseUp;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button2;
    }
}
