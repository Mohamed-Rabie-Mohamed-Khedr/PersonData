namespace PersonData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName + ".exe");
            if (!File.Exists("Save.txt")) File.WriteAllText("Save.txt", "");
            Directory.CreateDirectory("images");
        }

        private void NewPerson_Click(object sender, EventArgs e)
        {
            DataSystem.SaveData(tID, tAddress, tName, pImage, tPhone, tDate);
        }

        private void ShowPerson_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            DataSystem.ShowAll(this);
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pImage.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}