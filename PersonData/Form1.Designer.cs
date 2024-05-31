namespace PersonData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tID = new TextBox();
            tAddress = new TextBox();
            tName = new TextBox();
            Exet = new Button();
            ShowAll = new Button();
            GetPerson = new Button();
            NewP = new Button();
            pImage = new PictureBox();
            AddImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            tPhone = new TextBox();
            label6 = new Label();
            tDate = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(367, 51);
            label1.Name = "label1";
            label1.Size = new Size(591, 65);
            label1.TabIndex = 0;
            label1.Text = "شاشة ادخال بيانات الاشخاص";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(739, 192);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 1;
            label2.Text = "رقم القومي";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(822, 263);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 2;
            label3.Text = "اسم";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(812, 334);
            label4.Name = "label4";
            label4.Size = new Size(81, 37);
            label4.TabIndex = 3;
            label4.Text = "عنوان";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // tID
            // 
            tID.Anchor = AnchorStyles.None;
            tID.Location = new Point(511, 202);
            tID.Name = "tID";
            tID.RightToLeft = RightToLeft.No;
            tID.Size = new Size(220, 32);
            tID.TabIndex = 4;
            tID.TextAlign = HorizontalAlignment.Right;
            // 
            // tAddress
            // 
            tAddress.Anchor = AnchorStyles.None;
            tAddress.Location = new Point(511, 335);
            tAddress.Name = "tAddress";
            tAddress.RightToLeft = RightToLeft.No;
            tAddress.Size = new Size(220, 32);
            tAddress.TabIndex = 5;
            tAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // tName
            // 
            tName.Anchor = AnchorStyles.None;
            tName.Location = new Point(512, 270);
            tName.Name = "tName";
            tName.RightToLeft = RightToLeft.No;
            tName.Size = new Size(220, 32);
            tName.TabIndex = 6;
            tName.TextAlign = HorizontalAlignment.Right;
            // 
            // Exet
            // 
            Exet.Anchor = AnchorStyles.None;
            Exet.BackColor = Color.Red;
            Exet.ForeColor = Color.White;
            Exet.Location = new Point(318, 615);
            Exet.Name = "Exet";
            Exet.Size = new Size(91, 40);
            Exet.TabIndex = 7;
            Exet.Text = "خروج";
            Exet.UseVisualStyleBackColor = false;
            Exet.Click += Exit_Click;
            // 
            // ShowAll
            // 
            ShowAll.Anchor = AnchorStyles.None;
            ShowAll.Location = new Point(456, 614);
            ShowAll.Name = "ShowAll";
            ShowAll.Size = new Size(136, 40);
            ShowAll.TabIndex = 8;
            ShowAll.Text = "اظهار الكل";
            ShowAll.UseVisualStyleBackColor = true;
            ShowAll.Click += ShowAll_Click;
            // 
            // GetPerson
            // 
            GetPerson.Anchor = AnchorStyles.None;
            GetPerson.Location = new Point(637, 615);
            GetPerson.Name = "GetPerson";
            GetPerson.Size = new Size(139, 40);
            GetPerson.TabIndex = 9;
            GetPerson.Text = "البحث والتعديل";
            GetPerson.UseVisualStyleBackColor = true;
            GetPerson.Click += ShowPerson_Click;
            // 
            // NewP
            // 
            NewP.Anchor = AnchorStyles.None;
            NewP.Location = new Point(822, 615);
            NewP.Name = "NewP";
            NewP.Size = new Size(136, 40);
            NewP.TabIndex = 10;
            NewP.Text = "حغظ";
            NewP.UseVisualStyleBackColor = true;
            NewP.Click += NewPerson_Click;
            // 
            // pImage
            // 
            pImage.Anchor = AnchorStyles.None;
            pImage.BorderStyle = BorderStyle.FixedSingle;
            pImage.Location = new Point(985, 202);
            pImage.Name = "pImage";
            pImage.Size = new Size(165, 169);
            pImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pImage.TabIndex = 11;
            pImage.TabStop = false;
            // 
            // AddImage
            // 
            AddImage.Anchor = AnchorStyles.None;
            AddImage.Location = new Point(998, 399);
            AddImage.Name = "AddImage";
            AddImage.Size = new Size(136, 40);
            AddImage.TabIndex = 12;
            AddImage.Text = "اضافة صورة";
            AddImage.UseVisualStyleBackColor = true;
            AddImage.Click += AddImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tPhone
            // 
            tPhone.Anchor = AnchorStyles.None;
            tPhone.Location = new Point(511, 399);
            tPhone.Name = "tPhone";
            tPhone.RightToLeft = RightToLeft.No;
            tPhone.Size = new Size(220, 32);
            tPhone.TabIndex = 14;
            tPhone.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(744, 464);
            label6.Name = "label6";
            label6.Size = new Size(149, 37);
            label6.TabIndex = 15;
            label6.Text = "تاريخ الميلاد";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // tDate
            // 
            tDate.Format = DateTimePickerFormat.Short;
            tDate.Location = new Point(512, 464);
            tDate.Name = "tDate";
            tDate.RightToLeft = RightToLeft.No;
            tDate.Size = new Size(220, 32);
            tDate.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(757, 397);
            label5.Name = "label5";
            label5.Size = new Size(136, 37);
            label5.TabIndex = 13;
            label5.Text = "رقم الهاتف";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1258, 750);
            Controls.Add(tDate);
            Controls.Add(label6);
            Controls.Add(tPhone);
            Controls.Add(label5);
            Controls.Add(AddImage);
            Controls.Add(pImage);
            Controls.Add(NewP);
            Controls.Add(GetPerson);
            Controls.Add(ShowAll);
            Controls.Add(Exet);
            Controls.Add(tName);
            Controls.Add(tAddress);
            Controls.Add(tID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة ادخال بيانات الاشخاص";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tID;
        private TextBox tAddress;
        private TextBox tName;
        private Button Exet;
        private Button ShowAll;
        private Button GetPerson;
        private Button NewP;
        private PictureBox pImage;
        private Button AddImage;
        private OpenFileDialog openFileDialog1;
        private TextBox tPhone;
        private Label label6;
        private DateTimePicker tDate;
        private Label label5;
    }
}
