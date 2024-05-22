internal class DataSystem
{
    internal static void NewPerson(TextBox tID, TextBox tAddress, TextBox tName, PictureBox picture)
    {
        if (picture.Image == null || string.IsNullOrEmpty(tID.Text) || string.IsNullOrEmpty(tAddress.Text) || string.IsNullOrEmpty(tName.Text))
            MessageBox.Show("هل نسيت تكتب بيانات ؟");
        else
        {
            using StreamReader reader = new StreamReader("Save.txt");
            string tAll = reader.ReadToEnd();
            reader.Close();

            if (tAll.Contains(tID.Text + ";"))
            {
                MessageBox.Show("انت عايز ادخال رقم القومي موجود فعلا ؟ انت بهزر");
                tID.Focus();
                tID.SelectAll();
            }

            else
            {
                using StreamWriter write = new StreamWriter("Save.txt", true);
                write.WriteLine(tID.Text + ";" + tName.Text + ";" + tAddress.Text);
                write.Close();
                picture.Image.Save("images/" + tID.Text + ".jpg");
                MessageBox.Show("تم الحفظ");
                tID.Text = tAddress.Text = tName.Text = "";
                picture.Image = null;
                tID.Focus();
            }
        }
    }

    internal static void GetPerson(TextBox tID, TextBox tAddress, TextBox tName, PictureBox picture)
    {
        if (string.IsNullOrEmpty(tID.Text))
            MessageBox.Show("هل نسيت تكتب رقم القومي؟");
        else
        {
            using StreamReader reader = new StreamReader("Save.txt");
            string tAll = reader.ReadToEnd();
            reader.Close();

            int index = tAll.IndexOf(tID.Text + ';');
            if (index == -1) MessageBox.Show("مش موجود شخص دة");

            else
            {
                string[] data = tAll.Substring(index, tAll.IndexOf(Environment.NewLine, index) - index).Split(';');
                tName.Text = data[1];
                tAddress.Text = data[2];
                picture.Image = Image.FromFile("images/" + tID.Text + ".jpg");
            }
        }
    }

    internal static void ShowAll(Form f)
    {
        Form formData = new Form();
        formData.Text = "ALL DATA";
        formData.Size = new Size(1000, 1000);
        formData.Font = f.Font;
        formData.StartPosition = FormStartPosition.CenterScreen;
        formData.AutoScroll = true;

        using StreamReader reader = new StreamReader("Save.txt");
        string line;
        int yPos = 15;
        while ((line = reader.ReadLine()) is not null)
        {
            Label t = new Label();
            t.Location = new Point(300, yPos);
            t.Width = 150;
            t.Text = line;

            PictureBox picture = new PictureBox();
            picture.Location = new Point(590, yPos);
            picture.Size = new Size(200, 200);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile("images/" + line.Split(';')[0] + ".jpg");
         
            formData.Controls.Add(t);
            formData.Controls.Add(picture);
            yPos += 212;
        }
        reader.Close();

        formData.ShowDialog();
    }
}