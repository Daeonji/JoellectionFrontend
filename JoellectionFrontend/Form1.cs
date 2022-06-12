namespace JoellectionFrontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HttpHandler.UploadJoe(joeName.Text, joeDesc.Text, joeLink.Text);
        }

    }
}