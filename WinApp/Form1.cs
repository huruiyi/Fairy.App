using WinApp.Utils;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbStartupPath.Text = Application.StartupPath;
            tbExecutablePath.Text = Application.ExecutablePath;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            HttpHelper.DownFile(tbUrl.Text, "qq.exe", pbDownload);
        }
    }
}