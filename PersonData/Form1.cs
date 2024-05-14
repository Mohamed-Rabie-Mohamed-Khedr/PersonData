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
            //this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName + ".exe");
            if (!File.Exists("Save.txt")) File.WriteAllText("Save.txt", "");
        }

        private void NewPerson_Click(object sender, EventArgs e)
        {
            DataSystem.NewPerson(tID, tAddress, tName);
        }

        private void GetPerson_Click(object sender, EventArgs e)
        {
            DataSystem.GetPerson(tID, tAddress, tName);
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            DataSystem.ShowAll(this);
        }
    }
}