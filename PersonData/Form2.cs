namespace PersonData
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Amendment_Click(object sender, EventArgs e)
        {
            tAddress.Enabled = tName.Enabled = NewImage.Enabled = tPhone.Enabled = tDate.Enabled = label7.Visible = tNID.Visible = true;
        }

        private void SaveAmendment_Click(object sender, EventArgs e)
        {
            DataSystem.ReplaceData(tID.Text, tNID.Text, tAddress.Text, tName.Text, pImage, tPhone.Text, tDate.Text);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataSystem.GetPerson(tID, tAddress, tName, pImage, tPhone, tDate);
        }

        private void NewImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pImage.Image = Image.FromFile(openFileDialog1.FileName);
                Program.isNewImage = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Icon = Application.OpenForms[0].Icon;
        }
    }
}