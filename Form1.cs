namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {

        }

        private void lvwLeftDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvwLeftDir_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";
                //현재 텍스트박스에 있는 경로를 초기 선택 폴더로 설정
            }
        }
    }
}
