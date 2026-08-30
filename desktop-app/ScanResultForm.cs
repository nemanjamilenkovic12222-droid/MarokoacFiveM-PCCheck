using System;
using System.Windows.Forms;
using System.Drawing;

namespace MarokoacPCCheck
{
    public class ScanResultForm : Form
    {
        public ScanResultForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Scan Results - Maroko AC";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(20, 20, 40);
            this.ForeColor = Color.White;

            // PIN Display
            Label pinLabel = new Label
            {
                Text = "PIN: 123456",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 255, 150),
                Location = new Point(20, 20),
                Size = new Size(400, 40)
            };
            this.Controls.Add(pinLabel);

            // Results TextBox
            TextBox resultsBox = new TextBox
            {
                Location = new Point(20, 80),
                Size = new Size(750, 450),
                BackColor = Color.FromArgb(30, 30, 50),
                ForeColor = Color.FromArgb(0, 255, 150),
                Multiline = true,
                ScrollBars = ScrollBars.Both,
                Font = new Font("Courier New", 10),
                ReadOnly = true,
                Text = "CPU: Intel Core i7\nRAM: 16 GB\nGPU: RTX 3070\nStatus: ✓ Clean"
            };
            this.Controls.Add(resultsBox);

            // Upload Button
            Button uploadButton = new Button
            {
                Text = "📤 Upload to Web",
                Font = new Font("Arial", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 150, 200),
                ForeColor = Color.White,
                Location = new Point(650, 540),
                Size = new Size(120, 35),
                FlatStyle = FlatStyle.Flat
            };
            this.Controls.Add(uploadButton);
        }
    }
}
