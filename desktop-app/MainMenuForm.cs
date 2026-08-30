using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MarokoacPCCheck
{
    public class MainMenuForm : Form
    {
        private Label titleLabel;
        private Button scanButton;
        private Button resultsButton;
        private Button settingsButton;
        private Label statusLabel;
        private ProgressBar scanProgress;

        public MainMenuForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void InitializeComponent()
        {
            this.Text = "Maroko AC - FiveM PC Check";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(15, 15, 35);
            this.ForeColor = Color.White;
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = SystemIcons.Application;
        }

        private void SetupUI()
        {
            // Title
            titleLabel = new Label
            {
                Text = "🎮 MAROKO AC",
                Font = new Font("Arial", 48, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 255, 150),
                Location = new Point(150, 40),
                Size = new Size(600, 80),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(titleLabel);

            // Subtitle
            Label subtitleLabel = new Label
            {
                Text = "Professional FiveM PC Security Scan",
                Font = new Font("Arial", 14),
                ForeColor = Color.FromArgb(200, 200, 200),
                Location = new Point(150, 120),
                Size = new Size(600, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(subtitleLabel);

            // Status Label
            statusLabel = new Label
            {
                Text = "Ready to scan",
                Font = new Font("Arial", 12),
                ForeColor = Color.FromArgb(100, 255, 150),
                Location = new Point(150, 180),
                Size = new Size(600, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(statusLabel);

            // Scan Button
            scanButton = new Button
            {
                Text = "▶ START SCAN",
                Font = new Font("Arial", 14, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 200, 100),
                ForeColor = Color.White,
                Location = new Point(200, 250),
                Size = new Size(500, 60),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            scanButton.FlatAppearance.BorderSize = 0;
            scanButton.Click += ScanButton_Click;
            this.Controls.Add(scanButton);

            // Progress Bar
            scanProgress = new ProgressBar
            {
                Location = new Point(200, 330),
                Size = new Size(500, 20),
                Value = 0,
                Maximum = 100,
                ForeColor = Color.FromArgb(0, 255, 150)
            };
            this.Controls.Add(scanProgress);

            // Results Button
            resultsButton = new Button
            {
                Text = "📊 VIEW RESULTS",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(100, 100, 150),
                ForeColor = Color.White,
                Location = new Point(150, 380),
                Size = new Size(250, 50),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            resultsButton.FlatAppearance.BorderSize = 0;
            resultsButton.Click += ResultsButton_Click;
            this.Controls.Add(resultsButton);

            // Settings Button
            settingsButton = new Button
            {
                Text = "⚙️ SETTINGS",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(100, 100, 150),
                ForeColor = Color.White,
                Location = new Point(500, 380),
                Size = new Size(250, 50),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.Click += SettingsButton_Click;
            this.Controls.Add(settingsButton);

            // Version Label
            Label versionLabel = new Label
            {
                Text = "v1.0.0 | Maroko AC © 2024",
                Font = new Font("Arial", 10),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(200, 580),
                Size = new Size(500, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(versionLabel);
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            PCScanner scanner = new PCScanner();
            ScanResultForm resultForm = new ScanResultForm();
            resultForm.Show();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unesite PIN za prikaz rezultata", "Rezultati");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podešavanja", "Opcije");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Gradient background
            var gradient = new LinearGradient(new Point(0, 0), new Point(this.Width, this.Height), 
                Color.FromArgb(15, 15, 35), Color.FromArgb(25, 25, 50));
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }
    }
}
