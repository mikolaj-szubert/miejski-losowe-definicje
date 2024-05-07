using HtmlAgilityPack;
namespace LosoweDefinicje
{
    public partial class Main : Form
    {
        static System.Windows.Forms.Timer myTimer = new();
        private Point mouseOffset;
        private bool isMouseDown = false;
        public Main()
        {
            InitializeComponent();
            Icon = Properties.Resources.dice;
            Properties.Ustawienia.Default.Reload();
            ChangeQuote();
        }

        async private void ChangeQuote(object? myObject = null, EventArgs? myEventArgs = null)
        {
            HttpClient client = new();
            HttpResponseMessage result = await client.GetAsync("https://miejski.pl/losuj");
            if (result.IsSuccessStatusCode)
            {
                string s = await result.Content.ReadAsStringAsync();
                s = s.Replace("oacute;", "ó").Replace("quot;", "\"").Replace("mdash;", "-").Replace("nbsp;", " ");
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(s);
                try
                {
                    HtmlNode? header = doc.DocumentNode.SelectSingleNode("//article/header");
                    if (header != null)
                        headerLabel.Text = header.InnerText.Trim();
                    else
                        headerLabel.Text = "-Brak tytu³u-";
                }
                catch (Exception)
                {
                    headerLabel.Text = "-Brak tytu³u-";
                }
                try
                {
                    HtmlNode? description = doc.DocumentNode.SelectSingleNode("//article/p");
                    if (description != null)
                    {
                        descriptionLabel.Visible = true;
                        descriptionLabel.Text = description.InnerText.Trim();
                    }
                    else
                    {
                        descriptionLabel.Visible = false;
                        descriptionLabel.Text = string.Empty;
                    }
                }
                catch (Exception)
                {
                    descriptionLabel.Visible = false;
                    descriptionLabel.Text = string.Empty;
                }
                try
                {
                    HtmlNode? example = doc.DocumentNode.SelectSingleNode("//article/blockquote");
                    if (example != null)
                    {
                        ExampleFlowLayoutPanel.Visible = true;
                        exampleLabel.Visible = true;
                        exampleLabel.Text = example.InnerText.Trim();
                    }
                    else
                    {
                        exampleLabel.Visible = false;
                        ExampleFlowLayoutPanel.Visible = false;
                        exampleLabel.Text = string.Empty;
                    }

                }
                catch (Exception)
                {
                    exampleLabel.Visible = false;
                    exampleLabel.Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            Ustawienia u = new();
            u.ShowDialog();
            Properties.Ustawienia.Default.Reload();
            if ((int)Properties.Ustawienia.Default.Interval > 0)
            {
                myTimer.Interval = (int)Properties.Ustawienia.Default.Interval * 1000;
                myTimer.Start();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(ChangeQuote);
            if ((int)Properties.Ustawienia.Default.Interval > 0)
            {
                myTimer.Interval = (int)Properties.Ustawienia.Default.Interval * 1000;
                myTimer.Start();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeQuote();
        }

        private void MouseDownMover(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void MouseUpMover(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;
        }

        private void MouseMoveMover(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
    }
}
