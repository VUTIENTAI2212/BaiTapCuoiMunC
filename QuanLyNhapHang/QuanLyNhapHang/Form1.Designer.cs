namespace QuanLyNhapHang
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            maHDKT = new TextBox();
            label1 = new Label();
            dateFrom = new DateTimePicker();
            label2 = new Label();
            groupBox2 = new GroupBox();
            hoaDonNhapKho = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            maHoaDon = new TextBox();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            dateEnd = new DateTimePicker();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonNhapKho).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateEnd);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maHDKT);
            groupBox1.Controls.Add(dateFrom);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1125, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.Location = new Point(352, 31);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maHDKT
            // 
            maHDKT.Location = new Point(139, 37);
            maHDKT.Name = "maHDKT";
            maHDKT.Size = new Size(169, 27);
            maHDKT.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // dateFrom
            // 
            dateFrom.Format = DateTimePickerFormat.Short;
            dateFrom.Location = new Point(714, 24);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(157, 27);
            dateFrom.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(653, 29);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 2;
            label2.Text = "Từ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hoaDonNhapKho);
            groupBox2.Location = new Point(12, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1125, 485);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // hoaDonNhapKho
            // 
            hoaDonNhapKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonNhapKho.Location = new Point(13, 27);
            hoaDonNhapKho.Name = "hoaDonNhapKho";
            hoaDonNhapKho.RowHeadersWidth = 51;
            hoaDonNhapKho.Size = new Size(1102, 446);
            hoaDonNhapKho.TabIndex = 0;
            hoaDonNhapKho.CellContentClick += hoaDonNhapKho_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(10, 604);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1126, 152);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(maHoaDon);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button4);
            groupBox4.Location = new Point(298, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(366, 119);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            // 
            // maHoaDon
            // 
            maHoaDon.Location = new Point(111, 56);
            maHoaDon.Name = "maHoaDon";
            maHoaDon.Size = new Size(119, 27);
            maHoaDon.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "Mã hóa đơn";
            // 
            // button5
            // 
            button5.Location = new Point(236, 74);
            button5.Name = "button5";
            button5.Size = new Size(114, 39);
            button5.TabIndex = 8;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(236, 20);
            button4.Name = "button4";
            button4.Size = new Size(114, 39);
            button4.TabIndex = 7;
            button4.Text = "Chỉnh sửa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Location = new Point(923, 70);
            button7.Name = "button7";
            button7.Size = new Size(114, 39);
            button7.TabIndex = 10;
            button7.Text = "Thoát";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(773, 70);
            button6.Name = "button6";
            button6.Size = new Size(114, 39);
            button6.TabIndex = 9;
            button6.Text = "Tải lại";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 42);
            button3.Name = "button3";
            button3.Size = new Size(114, 39);
            button3.TabIndex = 6;
            button3.Text = "Tạo hóa đơn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(941, 33);
            button2.Name = "button2";
            button2.Size = new Size(114, 39);
            button2.TabIndex = 5;
            button2.Text = "Lọc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(714, 72);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(157, 27);
            dateEnd.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(653, 76);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 12;
            label4.Text = "Đến:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 763);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hoaDonNhapKho).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView hoaDonNhapKho;
        private Button button1;
        private Label label2;
        private TextBox maHDKT;
        private Label label1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox4;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button6;
        private TextBox maHoaDon;
        private Label label3;
        private DateTimePicker dateFrom;
        private DateTimePicker dateEnd;
        private Label label4;
    }
}
