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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(512, 82);
            label1.Name = "label1";
            label1.Size = new Size(381, 65);
            label1.TabIndex = 0;
            label1.Text = "معلومات الشخص";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(739, 192);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 1;
            label2.Text = "رقم القومي";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(814, 264);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 2;
            label3.Text = "اسم";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(805, 334);
            label4.Name = "label4";
            label4.Size = new Size(81, 37);
            label4.TabIndex = 3;
            label4.Text = "عنوان";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // tID
            // 
            tID.Location = new Point(512, 202);
            tID.Name = "tID";
            tID.Size = new Size(220, 32);
            tID.TabIndex = 4;
            tID.TextAlign = HorizontalAlignment.Right;
            // 
            // tAddress
            // 
            tAddress.Location = new Point(512, 335);
            tAddress.Name = "tAddress";
            tAddress.Size = new Size(220, 32);
            tAddress.TabIndex = 5;
            tAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // tName
            // 
            tName.Location = new Point(513, 270);
            tName.Name = "tName";
            tName.Size = new Size(220, 32);
            tName.TabIndex = 6;
            tName.TextAlign = HorizontalAlignment.Right;
            // 
            // Exet
            // 
            Exet.BackColor = Color.Red;
            Exet.ForeColor = Color.White;
            Exet.Location = new Point(317, 507);
            Exet.Name = "Exet";
            Exet.Size = new Size(91, 40);
            Exet.TabIndex = 7;
            Exet.Text = "خروج";
            Exet.UseVisualStyleBackColor = false;
            Exet.Click += Exit_Click;
            // 
            // ShowAll
            // 
            ShowAll.Location = new Point(455, 506);
            ShowAll.Name = "ShowAll";
            ShowAll.Size = new Size(136, 40);
            ShowAll.TabIndex = 8;
            ShowAll.Text = "اظهار الكل";
            ShowAll.UseVisualStyleBackColor = true;
            ShowAll.Click += ShowAll_Click;
            // 
            // GetPerson
            // 
            GetPerson.Location = new Point(642, 507);
            GetPerson.Name = "GetPerson";
            GetPerson.Size = new Size(91, 40);
            GetPerson.TabIndex = 9;
            GetPerson.Text = "بحث";
            GetPerson.UseVisualStyleBackColor = true;
            GetPerson.Click += GetPerson_Click;
            // 
            // NewP
            // 
            NewP.Location = new Point(781, 507);
            NewP.Name = "NewP";
            NewP.Size = new Size(136, 40);
            NewP.TabIndex = 10;
            NewP.Text = "شخص جديد";
            NewP.UseVisualStyleBackColor = true;
            NewP.Click += NewPerson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 750);
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
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "person data";
            Load += Form1_Load;
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
    }
}
