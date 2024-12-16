namespace QuanLyNhanVien
{
    partial class ChinhSuaNhanVien
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
            gtnNV = new RadioButton();
            groupBox1 = new GroupBox();
            gtnuNV = new RadioButton();
            datevlNV = new DateTimePicker();
            dateNV = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label11 = new Label();
            mkNV = new TextBox();
            label10 = new Label();
            gmailNV = new TextBox();
            label9 = new Label();
            sdtNV = new TextBox();
            label8 = new Label();
            dcNV = new TextBox();
            label7 = new Label();
            cvNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tenNV = new TextBox();
            label3 = new Label();
            maNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(gtnuNV);
            groupBox1.Controls.Add(gtnNV);
            groupBox1.Location = new Point(117, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 63);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
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
            // datevlNV
            // 
            datevlNV.Format = DateTimePickerFormat.Short;
            datevlNV.Location = new Point(524, 368);
            datevlNV.Name = "datevlNV";
            datevlNV.Size = new Size(182, 27);
            datevlNV.TabIndex = 48;
            datevlNV.Value = new DateTime(2024, 12, 2, 21, 41, 53, 0);
            // 
            // dateNV
            // 
            dateNV.Format = DateTimePickerFormat.Short;
            dateNV.Location = new Point(117, 298);
            dateNV.Name = "dateNV";
            dateNV.Size = new Size(187, 27);
            dateNV.TabIndex = 47;
            dateNV.Value = new DateTime(2024, 12, 2, 21, 41, 43, 0);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(156, 444);
            button1.Name = "button1";
            button1.Size = new Size(162, 43);
            button1.TabIndex = 46;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(443, 444);
            button2.Name = "button2";
            button2.Size = new Size(162, 43);
            button2.TabIndex = 45;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 373);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 44;
            label11.Text = "Ngày vào làm:";
            // 
            // mkNV
            // 
            mkNV.Location = new Point(524, 295);
            mkNV.Multiline = true;
            mkNV.Name = "mkNV";
            mkNV.Size = new Size(182, 34);
            mkNV.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 298);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 42;
            label10.Text = "Password:";
            // 
            // gmailNV
            // 
            gmailNV.Location = new Point(524, 224);
            gmailNV.Multiline = true;
            gmailNV.Name = "gmailNV";
            gmailNV.Size = new Size(247, 34);
            gmailNV.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 227);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 40;
            label9.Text = "Gmail:";
            // 
            // sdtNV
            // 
            sdtNV.Location = new Point(524, 153);
            sdtNV.Multiline = true;
            sdtNV.Name = "sdtNV";
            sdtNV.Size = new Size(182, 34);
            sdtNV.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 156);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 38;
            label8.Text = "Số điện thoại:";
            // 
            // dcNV
            // 
            dcNV.Location = new Point(524, 77);
            dcNV.Multiline = true;
            dcNV.Name = "dcNV";
            dcNV.Size = new Size(247, 34);
            dcNV.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 80);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 36;
            label7.Text = "Địa chỉ:";
            // 
            // cvNV
            // 
            cvNV.Location = new Point(117, 370);
            cvNV.Multiline = true;
            cvNV.Name = "cvNV";
            cvNV.Size = new Size(182, 34);
            cvNV.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 373);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 34;
            label6.Text = "Chức vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 298);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 33;
            label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 227);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 32;
            label4.Text = "Giới tính:";
            // 
            // tenNV
            // 
            tenNV.Location = new Point(117, 153);
            tenNV.Multiline = true;
            tenNV.Name = "tenNV";
            tenNV.Size = new Size(182, 34);
            tenNV.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 156);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 30;
            label3.Text = "Họ tên:";
            // 
            // maNV
            // 
            maNV.Location = new Point(117, 77);
            maNV.Multiline = true;
            maNV.Name = "maNV";
            maNV.Size = new Size(182, 34);
            maNV.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 28;
            label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 16);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 27;
            label1.Text = "Chỉnh Sửa Thông Tin";
            // 
            // ChinhSuaNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
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
            Name = "ChinhSuaNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChinhSuaNhanVien";
            Load += ChinhSuaNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton gtnNV;
        private GroupBox groupBox1;
        private RadioButton gtnuNV;
        private DateTimePicker datevlNV;
        private DateTimePicker dateNV;
        private Button button1;
        private Button button2;
        private Label label11;
        private TextBox mkNV;
        private Label label10;
        private TextBox gmailNV;
        private Label label9;
        private TextBox sdtNV;
        private Label label8;
        private TextBox dcNV;
        private Label label7;
        private TextBox cvNV;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tenNV;
        private Label label3;
        private TextBox maNV;
        private Label label2;
        private Label label1;
    }
}