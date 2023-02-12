using LogsForUsr;

namespace Singlgl
{
    public partial class Form1 : Form
    {
        Singleton _Log=Singleton.Instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Log.write_in_file("Button1 - Click");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Log.write_in_file("Button2 - Click");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Log.End();
        }
    }
}