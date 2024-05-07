namespace LosoweDefinicje
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            CloseButton = new Button();
            SettingsButton = new Button();
            descriptionLabel = new Label();
            exampleLabel = new Label();
            headerLabel = new Label();
            ExampleFlowLayoutPanel = new FlowLayoutPanel();
            DescriptionFlowLayoutPanel = new FlowLayoutPanel();
            MainFlowLayoutPanel = new FlowLayoutPanel();
            TitleFlowLayoutPanel = new FlowLayoutPanel();
            button1 = new Button();
            ExampleFlowLayoutPanel.SuspendLayout();
            DescriptionFlowLayoutPanel.SuspendLayout();
            MainFlowLayoutPanel.SuspendLayout();
            TitleFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(350, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 25);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "✕";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += button1_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.Transparent;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 16, 16);
            SettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.ForeColor = Color.Transparent;
            SettingsButton.Image = Properties.Resources.settings;
            SettingsButton.Location = new Point(300, 0);
            SettingsButton.Margin = new Padding(0);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(50, 25);
            SettingsButton.TabIndex = 4;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += button2_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Segoe UI", 9F);
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.ImeMode = ImeMode.NoControl;
            descriptionLabel.Location = new Point(3, 3);
            descriptionLabel.Margin = new Padding(3);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(0, 15);
            descriptionLabel.TabIndex = 2;
            // 
            // exampleLabel
            // 
            exampleLabel.AutoSize = true;
            exampleLabel.BackColor = Color.Transparent;
            exampleLabel.Font = new Font("Segoe UI", 9F);
            exampleLabel.ForeColor = Color.White;
            exampleLabel.Location = new Point(3, 5);
            exampleLabel.Name = "exampleLabel";
            exampleLabel.Size = new Size(0, 15);
            exampleLabel.TabIndex = 1;
            exampleLabel.Visible = false;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(13, 3);
            headerLabel.Margin = new Padding(3);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(0, 25);
            headerLabel.TabIndex = 0;
            headerLabel.MouseDown += MouseDownMover;
            headerLabel.MouseMove += MouseMoveMover;
            headerLabel.MouseUp += MouseUpMover;
            // 
            // ExampleFlowLayoutPanel
            // 
            ExampleFlowLayoutPanel.AutoSize = true;
            ExampleFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExampleFlowLayoutPanel.BackColor = Color.FromArgb(32, 32, 32);
            ExampleFlowLayoutPanel.Controls.Add(exampleLabel);
            ExampleFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ExampleFlowLayoutPanel.Location = new Point(10, 66);
            ExampleFlowLayoutPanel.Margin = new Padding(10, 3, 10, 3);
            ExampleFlowLayoutPanel.MaximumSize = new Size(380, 0);
            ExampleFlowLayoutPanel.MinimumSize = new Size(380, 21);
            ExampleFlowLayoutPanel.Name = "ExampleFlowLayoutPanel";
            ExampleFlowLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            ExampleFlowLayoutPanel.Size = new Size(380, 25);
            ExampleFlowLayoutPanel.TabIndex = 6;
            ExampleFlowLayoutPanel.Visible = false;
            // 
            // DescriptionFlowLayoutPanel
            // 
            DescriptionFlowLayoutPanel.AutoSize = true;
            DescriptionFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DescriptionFlowLayoutPanel.BackColor = Color.Transparent;
            DescriptionFlowLayoutPanel.Controls.Add(descriptionLabel);
            DescriptionFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            DescriptionFlowLayoutPanel.Location = new Point(10, 39);
            DescriptionFlowLayoutPanel.Margin = new Padding(10, 3, 10, 3);
            DescriptionFlowLayoutPanel.MaximumSize = new Size(380, 0);
            DescriptionFlowLayoutPanel.MinimumSize = new Size(380, 21);
            DescriptionFlowLayoutPanel.Name = "DescriptionFlowLayoutPanel";
            DescriptionFlowLayoutPanel.Size = new Size(380, 21);
            DescriptionFlowLayoutPanel.TabIndex = 7;
            // 
            // MainFlowLayoutPanel
            // 
            MainFlowLayoutPanel.AutoSize = true;
            MainFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainFlowLayoutPanel.Controls.Add(TitleFlowLayoutPanel);
            MainFlowLayoutPanel.Controls.Add(DescriptionFlowLayoutPanel);
            MainFlowLayoutPanel.Controls.Add(ExampleFlowLayoutPanel);
            MainFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            MainFlowLayoutPanel.Location = new Point(0, 0);
            MainFlowLayoutPanel.Margin = new Padding(0);
            MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
            MainFlowLayoutPanel.Padding = new Padding(0, 0, 0, 10);
            MainFlowLayoutPanel.Size = new Size(400, 104);
            MainFlowLayoutPanel.TabIndex = 8;
            // 
            // TitleFlowLayoutPanel
            // 
            TitleFlowLayoutPanel.Controls.Add(headerLabel);
            TitleFlowLayoutPanel.Location = new Point(0, 0);
            TitleFlowLayoutPanel.Margin = new Padding(0, 0, 0, 3);
            TitleFlowLayoutPanel.MaximumSize = new Size(250, 88);
            TitleFlowLayoutPanel.MinimumSize = new Size(250, 33);
            TitleFlowLayoutPanel.Name = "TitleFlowLayoutPanel";
            TitleFlowLayoutPanel.Padding = new Padding(10, 0, 0, 0);
            TitleFlowLayoutPanel.Size = new Size(250, 33);
            TitleFlowLayoutPanel.TabIndex = 9;
            TitleFlowLayoutPanel.MouseDown += MouseDownMover;
            TitleFlowLayoutPanel.MouseMove += MouseMoveMover;
            TitleFlowLayoutPanel.MouseUp += MouseUpMover;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 16, 16);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(250, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 25);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(400, 103);
            Controls.Add(button1);
            Controls.Add(CloseButton);
            Controls.Add(SettingsButton);
            Controls.Add(MainFlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(400, 0);
            Name = "Main";
            Opacity = 0.9D;
            ShowIcon = false;
            Text = "Miejski";
            Load += Main_Load;
            ExampleFlowLayoutPanel.ResumeLayout(false);
            ExampleFlowLayoutPanel.PerformLayout();
            DescriptionFlowLayoutPanel.ResumeLayout(false);
            DescriptionFlowLayoutPanel.PerformLayout();
            MainFlowLayoutPanel.ResumeLayout(false);
            MainFlowLayoutPanel.PerformLayout();
            TitleFlowLayoutPanel.ResumeLayout(false);
            TitleFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CloseButton;
        private Button SettingsButton;
        private Label descriptionLabel;
        private Label exampleLabel;
        private Label headerLabel;
        private FlowLayoutPanel ExampleFlowLayoutPanel;
        private FlowLayoutPanel DescriptionFlowLayoutPanel;
        private FlowLayoutPanel MainFlowLayoutPanel;
        private FlowLayoutPanel TitleFlowLayoutPanel;
        private Button button1;
    }
}
