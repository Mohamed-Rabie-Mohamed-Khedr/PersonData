using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;

internal class DataSystem
{
    internal static void NewPerson(TextBox tID, TextBox tAddress, TextBox tName)
    {
        if (string.IsNullOrEmpty(tID.Text) || string.IsNullOrEmpty(tAddress.Text) || string.IsNullOrEmpty(tName.Text))
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
                MessageBox.Show("تم الحفظ");
                tID.Text = "";
                tAddress.Text = "";
                tName.Text = "";
                tID.Focus();
            }
        }
    }

    internal static void GetPerson(TextBox tID, TextBox tAddress, TextBox tName)
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
            }
        }
    }

    internal static void ShowAll(Form f)
    {
        Form formData = new Form();
        TextBox textData = new TextBox();
        formData.Text = "ALL DATA";
        formData.Site = f.Site;
        formData.Font = f.Font;
        formData.StartPosition = FormStartPosition.CenterScreen;
        textData.Multiline = true;
        textData.Dock = DockStyle.Fill;
        textData.ReadOnly = true;

        using StreamReader reader = new StreamReader("Save.txt");
        textData.Text = reader.ReadToEnd();
        reader.Close();

        formData.Controls.Add(textData);
        formData.ShowDialog();
    }
}