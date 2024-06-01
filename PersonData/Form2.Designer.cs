namespace PersonData
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tDate = new DateTimePicker();
            label6 = new Label();
            tPhone = new TextBox();
            label5 = new Label();
            pImage = new PictureBox();
            SaveAmendment = new Button();
            Amendment = new Button();
            tName = new TextBox();
            tAddress = new TextBox();
            tID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Search = new Button();
            tNID = new TextBox();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            NewImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pImage).BeginInit();
            SuspendLayout();
            // 
            // tDate
            // 
            tDate.Anchor = AnchorStyles.None;
            tDate.Enabled = false;
            tDate.Format = DateTimePickerFormat.Short;
            tDate.Location = new Point(234, 594);
            tDate.Name = "tDate";
            tDate.Size = new Size(220, 32);
            tDate.TabIndex = 31;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(465, 594);
            label6.Name = "label6";
            label6.Size = new Size(149, 37);
            label6.TabIndex = 30;
            label6.Text = "تاريخ الميلاد";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // tPhone
            // 
            tPhone.Anchor = AnchorStyles.None;
            tPhone.Enabled = false;
            tPhone.Location = new Point(233, 529);
            tPhone.Name = "tPhone";
            tPhone.Size = new Size(220, 32);
            tPhone.TabIndex = 29;
            tPhone.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(478, 529);
            label5.Name = "label5";
            label5.Size = new Size(136, 37);
            label5.TabIndex = 28;
            label5.Text = "رقم الهاتف";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // pImage
            // 
            pImage.Anchor = AnchorStyles.None;
            pImage.BorderStyle = BorderStyle.FixedSingle;
            pImage.Location = new Point(706, 332);
            pImage.Name = "pImage";
            pImage.Size = new Size(165, 169);
            pImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pImage.TabIndex = 26;
            pImage.TabStop = false;
            // 
            // SaveAmendment
            // 
            SaveAmendment.Anchor = AnchorStyles.None;
            SaveAmendment.Location = new Point(503, 745);
            SaveAmendment.Name = "SaveAmendment";
            SaveAmendment.Size = new Size(136, 40);
            SaveAmendment.TabIndex = 25;
            SaveAmendment.Text = "حغظ التعديل";
            SaveAmendment.UseVisualStyleBackColor = true;
            SaveAmendment.Click += SaveAmendment_Click;
            // 
            // Amendment
            // 
            Amendment.Anchor = AnchorStyles.None;
            Amendment.Location = new Point(314, 745);
            Amendment.Name = "Amendment";
            Amendment.Size = new Size(91, 40);
            Amendment.TabIndex = 24;
            Amendment.Text = "تعديل";
            Amendment.UseVisualStyleBackColor = true;
            Amendment.Click += Amendment_Click;
            // 
            // tName
            // 
            tName.Anchor = AnchorStyles.None;
            tName.Enabled = false;
            tName.Location = new Point(234, 400);
            tName.Name = "tName";
            tName.Size = new Size(220, 32);
            tName.TabIndex = 23;
            tName.TextAlign = HorizontalAlignment.Right;
            // 
            // tAddress
            // 
            tAddress.Anchor = AnchorStyles.None;
            tAddress.Enabled = false;
            tAddress.Location = new Point(233, 465);
            tAddress.Name = "tAddress";
            tAddress.Size = new Size(220, 32);
            tAddress.TabIndex = 22;
            tAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // tID
            // 
            tID.Anchor = AnchorStyles.None;
            tID.Location = new Point(233, 285);
            tID.Name = "tID";
            tID.Size = new Size(220, 32);
            tID.TabIndex = 21;
            tID.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(533, 464);
            label4.Name = "label4";
            label4.Size = new Size(81, 37);
            label4.TabIndex = 20;
            label4.Text = "عنوان";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(543, 393);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 19;
            label3.Text = "اسم";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(460, 285);
            label2.Name = "label2";
            label2.Size = new Size(222, 37);
            label2.TabIndex = 18;
            label2.Text = "رقم القومي القديم";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(128, 145);
            label1.Name = "label1";
            label1.Size = new Size(454, 65);
            label1.TabIndex = 17;
            label1.Text = "شاشة البحث والتعديل";
            // 
            // Search
            // 
            Search.Anchor = AnchorStyles.None;
            Search.Location = new Point(82, 745);
            Search.Name = "Search";
            Search.Size = new Size(136, 40);
            Search.TabIndex = 33;
            Search.Text = "بحث";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // tNID
            // 
            tNID.Anchor = AnchorStyles.None;
            tNID.Location = new Point(233, 343);
            tNID.Name = "tNID";
            tNID.Size = new Size(220, 32);
            tNID.TabIndex = 35;
            tNID.TextAlign = HorizontalAlignment.Right;
            tNID.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(460, 343);
            label7.Name = "label7";
            label7.Size = new Size(222, 37);
            label7.TabIndex = 34;
            label7.Text = "رقم القومي الجديد";
            label7.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.HelpRequest += Amendment_Click;
            // 
            // NewImage
            // 
            NewImage.Anchor = AnchorStyles.None;
            NewImage.Enabled = false;
            NewImage.Location = new Point(720, 524);
            NewImage.Name = "NewImage";
            NewImage.Size = new Size(136, 40);
            NewImage.TabIndex = 32;
            NewImage.Text = "تغيير صورة";
            NewImage.UseVisualStyleBackColor = true;
            NewImage.Click += NewImage_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(984, 961);
            Controls.Add(tNID);
            Controls.Add(label7);
            Controls.Add(Search);
            Controls.Add(NewImage);
            Controls.Add(tDate);
            Controls.Add(label6);
            Controls.Add(tPhone);
            Controls.Add(label5);
            Controls.Add(pImage);
            Controls.Add(SaveAmendment);
            Controls.Add(Amendment);
            Controls.Add(tName);
            Controls.Add(tAddress);
            Controls.Add(tID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Margin = new Padding(0, 8, 0, 8);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة البحث والتعديل";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker tDate;
        private Label label6;
        private TextBox tPhone;
        private Label label5;
        private PictureBox pImage;
        private Button SaveAmendment;
        private Button Amendment;
        private TextBox tName;
        private TextBox tAddress;
        private TextBox tID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Search;
        private TextBox tNID;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Button NewImage;
    }
}