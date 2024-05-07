namespace LosoweDefinicje
{
    public partial class Ustawienia : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void Ustawienia_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void Ustawienia_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void Ustawienia_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Ustawienia.Default.Interval = numericUpDown1.Value;
        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {
            Properties.Ustawienia.Default.Reload();
            numericUpDown1.Value = Properties.Ustawienia.Default.Interval;
        }

        private void Ustawienia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Ustawienia.Default.Save();
        }
    }
}
