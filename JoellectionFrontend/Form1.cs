using System.Diagnostics;

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
            var uploadTask = HttpHandler.UploadJoe(joeName.Text, joeDesc.Text, joeLink.Text);
            processJoe(uploadTask);
        }

        private async Task processJoe(Task uploadTask)
        {
            progressBar1.Value = 50;
            await uploadTask;
            progressBar1.Value = 100;
            await Task.Delay(1000);
            progressBar1.Value = 0;
            refreshJoesManual();
        }

        private async void refreshJoesManual()
        {
            var collection = await HttpHandler.GetJoeEntries();
            listBox1.DataSource = collection;
            listBox1.DisplayMember = "Name";
        }

        private async void refreshJoes_Click(object sender, EventArgs e)
        {
            var collection = await HttpHandler.GetJoeEntries();
            listBox1.DataSource = collection;
            listBox1.DisplayMember = "Name";
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entry = (JoeEntry)listBox1.SelectedItem;
            nametag.Text = entry.Name;
            description.Text = entry.Description;
            Image imageRaw;
            try
            {
                imageRaw = await HttpHandler.GetImage(entry.ImageLink);
                joeSelectedPic.Image = imageRaw;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                
            }
            
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var entry = (JoeEntry)listBox1.SelectedItem;
            var response = await HttpHandler.DeleteJoe(entry);
            refreshJoesManual();
        }
    }
}