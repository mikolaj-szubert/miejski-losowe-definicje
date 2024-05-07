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
            resources.ApplyResources(CloseButton, "CloseButton");
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            CloseButton.ForeColor = Color.White;
            CloseButton.Name = "CloseButton";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += button1_Click;
            // 
            // SettingsButton
            // 
            resources.ApplyResources(SettingsButton, "SettingsButton");
            SettingsButton.BackColor = Color.Transparent;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 16, 16);
            SettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            SettingsButton.ForeColor = Color.Transparent;
            SettingsButton.Image = Properties.Resources.settings;
            SettingsButton.Name = "SettingsButton";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += button2_Click;
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Name = "descriptionLabel";
            // 
            // exampleLabel
            // 
            resources.ApplyResources(exampleLabel, "exampleLabel");
            exampleLabel.BackColor = Color.Transparent;
            exampleLabel.ForeColor = Color.White;
            exampleLabel.Name = "exampleLabel";
            // 
            // headerLabel
            // 
            resources.ApplyResources(headerLabel, "headerLabel");
            headerLabel.ForeColor = Color.White;
            headerLabel.Name = "headerLabel";
            headerLabel.MouseDown += MouseDownMover;
            headerLabel.MouseMove += MouseMoveMover;
            headerLabel.MouseUp += MouseUpMover;
            // 
            // ExampleFlowLayoutPanel
            // 
            resources.ApplyResources(ExampleFlowLayoutPanel, "ExampleFlowLayoutPanel");
            ExampleFlowLayoutPanel.BackColor = Color.FromArgb(32, 32, 32);
            ExampleFlowLayoutPanel.Controls.Add(exampleLabel);
            ExampleFlowLayoutPanel.Name = "ExampleFlowLayoutPanel";
            // 
            // DescriptionFlowLayoutPanel
            // 
            resources.ApplyResources(DescriptionFlowLayoutPanel, "DescriptionFlowLayoutPanel");
            DescriptionFlowLayoutPanel.BackColor = Color.Transparent;
            DescriptionFlowLayoutPanel.Controls.Add(descriptionLabel);
            DescriptionFlowLayoutPanel.Name = "DescriptionFlowLayoutPanel";
            // 
            // MainFlowLayoutPanel
            // 
            resources.ApplyResources(MainFlowLayoutPanel, "MainFlowLayoutPanel");
            MainFlowLayoutPanel.Controls.Add(TitleFlowLayoutPanel);
            MainFlowLayoutPanel.Controls.Add(DescriptionFlowLayoutPanel);
            MainFlowLayoutPanel.Controls.Add(ExampleFlowLayoutPanel);
            MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
            // 
            // TitleFlowLayoutPanel
            // 
            resources.ApplyResources(TitleFlowLayoutPanel, "TitleFlowLayoutPanel");
            TitleFlowLayoutPanel.Controls.Add(headerLabel);
            TitleFlowLayoutPanel.Name = "TitleFlowLayoutPanel";
            TitleFlowLayoutPanel.MouseDown += MouseDownMover;
            TitleFlowLayoutPanel.MouseMove += MouseMoveMover;
            TitleFlowLayoutPanel.MouseUp += MouseUpMover;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 16, 16);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            button1.ForeColor = Color.Transparent;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(button1);
            Controls.Add(CloseButton);
            Controls.Add(SettingsButton);
            Controls.Add(MainFlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Opacity = 0.9D;
            ShowIcon = false;
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
