using PersonData;
internal class DataSystem
{
    static FileStream file;
    internal static void SaveData(TextBox tID, TextBox tAddress, TextBox tName, PictureBox picture, TextBox tPhone, DateTimePicker timePicker)
    {
        if (picture.Image == null || string.IsNullOrEmpty(tID.Text) || string.IsNullOrEmpty(tAddress.Text) || string.IsNullOrEmpty(tName.Text) || string.IsNullOrEmpty(tPhone.Text))
            MessageBox.Show("هل نسيت تكتب بيانات ؟", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        else
        {
            string tAll = File.ReadAllText("Save.txt");

            if (tAll.Contains(tID.Text + ";"))
            {
                MessageBox.Show("رقم القومي موجود فعلا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                tID.Focus();
                tID.SelectAll();
            }

            else
            {
                using StreamWriter write = new StreamWriter("Save.txt", true);
                write.WriteLine(tID.Text + ";" + tName.Text + ";" + tAddress.Text + ";" + tPhone.Text + ";" + timePicker.Text);
                write.Close();
                picture.Image.Save("images/" + tID.Text + ".jpg");
                MessageBox.Show("تم الحفظ", "تمت المهمة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                tID.Text = tAddress.Text = tName.Text = tPhone.Text = "";
                picture.Image = null;
                tID.Focus();
            }
        }
    }

    internal static void GetPerson(TextBox tID, TextBox tAddress, TextBox tName, PictureBox picture, TextBox tPhone, DateTimePicker timePicker)
    {
        if (string.IsNullOrEmpty(tID.Text))
            MessageBox.Show("هل نسيت تكتب رقم القومي؟", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        else
        {
            string[]? data = GetData(tID.Text);

            if (data != null)
            {
                tName.Text = data[1];
                tAddress.Text = data[2];
                tPhone.Text = data[3];
                timePicker.Text = data[4];

                if (file != null)
                    file.Close();
                file = File.Open($"images/{tID.Text}.jpg", FileMode.Open);
                picture.Image = new Bitmap(file);
            }
        }
    }

    internal static void ReplaceData(string tOID, string tNID, string tAddress, string tName, PictureBox picture, string tPhone, string timePicker)
    {
        if (string.IsNullOrEmpty(tOID) || string.IsNullOrEmpty(tAddress) || string.IsNullOrEmpty(tName) || string.IsNullOrEmpty(tPhone))
            MessageBox.Show("هل نسيت تكتب بيانات ؟", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        else
        {
            string[]? data = GetData(tOID);

            if (data != null)
            {
                string tAll = File.ReadAllText("Save.txt");
                string id = string.IsNullOrEmpty(tNID) ? tOID : tNID;
                File.WriteAllText("Save.txt", tAll.Replace(string.Join(';', data), id + ";" + tName + ";" + tAddress + ";" + tPhone + ";" + timePicker));

                if (!string.IsNullOrEmpty(tNID) || Program.isNewImage)
                {
                    Program.isNewImage = false;
                    file.Close();
                    File.Delete($"images/{tOID}.jpg");
                    picture.Image.Save($"images/{id}.jpg");
                }
                MessageBox.Show("تم الحفظ", "تمت المهمة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                Application.OpenForms[1].Close();
            }
        }
    }

    static string[]? GetData(string ID)
    {
        string tAll = File.ReadAllText("Save.txt");

        int index = tAll.IndexOf(ID + ';');
        if (index == -1)
        {
            MessageBox.Show("مش موجود شخص دة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            return null;
        }
        else return tAll.Substring(index, tAll.IndexOf(Environment.NewLine, index) - index).Split(';');
    }

    internal static void ShowAll(Form f)
    {
        Form formData = new Form();
        formData.Text = "عرض الكل";
        formData.Size = new Size(1000, 1000);
        formData.Font = f.Font;
        formData.BackColor = f.BackColor;
        formData.Icon = f.Icon;
        formData.StartPosition = FormStartPosition.CenterScreen;
        formData.AutoScroll = true;
        
        using StreamReader reader = new StreamReader("Save.txt");
        string line;
        int yPos = 15;
        while ((line = reader.ReadLine()) != null)
        {
            Label t = new Label();
            t.Location = new Point(400, yPos);
            t.AutoSize = true;
            t.ForeColor = Color.White;
            t.Text = line;

            yPos += 10;
            PictureBox picture = new PictureBox();
            picture.Location = new Point(400, yPos);
            picture.Size = new Size(200, 200);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile("images/" + line.Split(';')[0] + ".jpg");
         
            formData.Controls.Add(t);
            formData.Controls.Add(picture);
            yPos += 220;
        }
        reader.Close();

        formData.ShowDialog();
    }
}