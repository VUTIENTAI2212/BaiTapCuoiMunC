namespace QuanLyNhanVien
{
    partial class ThemNhanVien
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
            label1 = new Label();
            label2 = new Label();
            maNV = new TextBox();
            tenNV = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cvNV = new TextBox();
            label6 = new Label();
            dcNV = new TextBox();
            label7 = new Label();
            sdtNV = new TextBox();
            label8 = new Label();
            gmailNV = new TextBox();
            label9 = new Label();
            mkNV = new TextBox();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            dateNV = new DateTimePicker();
            datevlNV = new DateTimePicker();
            groupBox1 = new GroupBox();
            gtnuNV = new RadioButton();
            gtnNV = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 20);
            label1.Name = "label1";
            label1.Size = new Size(214, 28);
            label1.TabIndex = 0;
            label1.Text = "Thêm Nhân Viên Mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            label2.Click += label2_Click;
            // 
            // maNV
            // 
            maNV.Location = new Point(132, 81);
            maNV.Multiline = true;
            maNV.Name = "maNV";
            maNV.Size = new Size(182, 34);
            maNV.TabIndex = 2;
            // 
            // tenNV
            // 
            tenNV.Location = new Point(132, 157);
            tenNV.Multiline = true;
            tenNV.Name = "tenNV";
            tenNV.Size = new Size(182, 34);
            tenNV.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 160);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 231);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 5;
            label4.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 302);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 7;
            label5.Text = "Ngày sinh:";
            // 
            // cvNV
            // 
            cvNV.Location = new Point(132, 374);
            cvNV.Multiline = true;
            cvNV.Name = "cvNV";
            cvNV.Size = new Size(182, 34);
            cvNV.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 377);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 9;
            label6.Text = "Chức vụ:";
            // 
            // dcNV
            // 
            dcNV.Location = new Point(539, 81);
            dcNV.Multiline = true;
            dcNV.Name = "dcNV";
            dcNV.Size = new Size(247, 34);
            dcNV.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 84);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 11;
            label7.Text = "Địa chỉ:";
            // 
            // sdtNV
            // 
            sdtNV.Location = new Point(539, 157);
            sdtNV.Multiline = true;
            sdtNV.Name = "sdtNV";
            sdtNV.Size = new Size(182, 34);
            sdtNV.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(429, 160);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 13;
            label8.Text = "Số điện thoại:";
            label8.Click += label8_Click;
            // 
            // gmailNV
            // 
            gmailNV.Location = new Point(539, 228);
            gmailNV.Multiline = true;
            gmailNV.Name = "gmailNV";
            gmailNV.Size = new Size(247, 34);
            gmailNV.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(429, 231);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 15;
            label9.Text = "Gmail:";
            // 
            // mkNV
            // 
            mkNV.Location = new Point(539, 299);
            mkNV.Multiline = true;
            mkNV.Name = "mkNV";
            mkNV.Size = new Size(182, 34);
            mkNV.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(429, 302);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 17;
            label10.Text = "Password:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(429, 377);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 19;
            label11.Text = "Ngày vào làm:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(458, 448);
            button2.Name = "button2";
            button2.Size = new Size(162, 43);
            button2.TabIndex = 22;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(171, 448);
            button1.Name = "button1";
            button1.Size = new Size(162, 43);
            button1.TabIndex = 23;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dateNV
            // 
            dateNV.Format = DateTimePickerFormat.Short;
            dateNV.Location = new Point(132, 302);
            dateNV.Name = "dateNV";
            dateNV.Size = new Size(187, 27);
            dateNV.TabIndex = 24;
            dateNV.Value = new DateTime(2024, 12, 2, 21, 41, 43, 0);
            dateNV.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // datevlNV
            // 
            datevlNV.Format = DateTimePickerFormat.Short;
            datevlNV.Location = new Point(539, 372);
            datevlNV.Name = "datevlNV";
            datevlNV.Size = new Size(182, 27);
            datevlNV.TabIndex = 25;
            datevlNV.Value = new DateTime(2024, 12, 2, 21, 41, 53, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gtnuNV);
            groupBox1.Controls.Add(gtnNV);
            groupBox1.Location = new Point(132, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 63);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gtnuNV
            // 
            gtnuNV.AutoSize = true;
            gtnuNV.Location = new Point(110, 19);
            gtnuNV.Name = "gtnuNV";
            gtnuNV.Size = new Size(50, 24);
            gtnuNV.TabIndex = 1;
            gtnuNV.TabStop = true;
            gtnuNV.Text = "Nữ";
            gtnuNV.UseVisualStyleBackColor = true;
            // 
            // gtnNV
            // 
            gtnNV.AutoSize = true;
            gtnNV.Location = new Point(6, 19);
            gtnNV.Name = "gtnNV";
            gtnNV.Size = new Size(62, 24);
            gtnNV.TabIndex = 0;
            gtnNV.TabStop = true;
            gtnNV.Text = "Nam";
            gtnNV.UseVisualStyleBackColor = true;
            // 
            // ThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(groupBox1);
            Controls.Add(datevlNV);
            Controls.Add(dateNV);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(mkNV);
            Controls.Add(label10);
            Controls.Add(gmailNV);
            Controls.Add(label9);
            Controls.Add(sdtNV);
            Controls.Add(label8);
            Controls.Add(dcNV);
            Controls.Add(label7);
            Controls.Add(cvNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tenNV);
            Controls.Add(label3);
            Controls.Add(maNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemNhanVien";
            Load += ThemNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox maNV;
        private TextBox tenNV;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cvNV;
        private Label label6;
        private TextBox dcNV;
        private Label label7;
        private TextBox sdtNV;
        private Label label8;
        private TextBox gmailNV;
        private Label label9;
        private TextBox mkNV;
        private Label label10;
        private Label label11;
        private Button button2;
        private Button button1;
        private DateTimePicker dateNV;
        private DateTimePicker datevlNV;
        private GroupBox groupBox1;
        private RadioButton gtnuNV;
        private RadioButton gtnNV;
    }
}