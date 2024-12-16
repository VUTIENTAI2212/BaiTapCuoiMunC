namespace QuanLyBanHang
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
            dateHD = new DateTimePicker();
            label2 = new Label();
            maHD = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            hoaDonBanHangTable = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            maHoaDonText = new TextBox();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonBanHangTable).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateHD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maHD);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(8, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1138, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm hóa đơn";
            // 
            // button1
            // 
            button1.Location = new Point(907, 38);
            button1.Name = "button1";
            button1.Size = new Size(136, 41);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateHD
            // 
            dateHD.Format = DateTimePickerFormat.Short;
            dateHD.Location = new Point(576, 45);
            dateHD.Name = "dateHD";
            dateHD.Size = new Size(180, 27);
            dateHD.TabIndex = 3;
            dateHD.Value = new DateTime(2024, 12, 13, 15, 55, 32, 0);
            dateHD.ValueChanged += dateHD_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 48);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày mua:";
            // 
            // maHD
            // 
            maHD.Location = new Point(151, 45);
            maHD.Name = "maHD";
            maHD.Size = new Size(153, 27);
            maHD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hoaDonBanHangTable);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(8, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1138, 441);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn bán hàng";
            // 
            // hoaDonBanHangTable
            // 
            hoaDonBanHangTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonBanHangTable.Location = new Point(9, 26);
            hoaDonBanHangTable.Name = "hoaDonBanHangTable";
            hoaDonBanHangTable.ReadOnly = true;
            hoaDonBanHangTable.RowHeadersWidth = 51;
            hoaDonBanHangTable.Size = new Size(1121, 404);
            hoaDonBanHangTable.TabIndex = 0;
            hoaDonBanHangTable.CellContentClick += hoaDonBanHangTable_CellContentClick_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button3);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(8, 555);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1138, 136);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(maHoaDonText);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button4);
            groupBox4.Location = new Point(222, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(464, 112);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // maHoaDonText
            // 
            maHoaDonText.Location = new Point(127, 31);
            maHoaDonText.Name = "maHoaDonText";
            maHoaDonText.Size = new Size(153, 27);
            maHoaDonText.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 34);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã hóa đơn:";
            // 
            // button5
            // 
            button5.Location = new Point(314, 65);
            button5.Name = "button5";
            button5.Size = new Size(136, 41);
            button5.TabIndex = 8;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(314, 17);
            button4.Name = "button4";
            button4.Size = new Size(136, 41);
            button4.TabIndex = 7;
            button4.Text = "Chỉnh sửa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Location = new Point(949, 52);
            button7.Name = "button7";
            button7.Size = new Size(136, 41);
            button7.TabIndex = 10;
            button7.Text = "Thoát";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(763, 52);
            button6.Name = "button6";
            button6.Size = new Size(136, 41);
            button6.TabIndex = 9;
            button6.Text = "Tải lại";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 52);
            button3.Name = "button3";
            button3.Size = new Size(136, 41);
            button3.TabIndex = 6;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 695);
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
            ((System.ComponentModel.ISupportInitialize)hoaDonBanHangTable).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private DateTimePicker dateHD;
        private Label label2;
        private TextBox maHD;
        private Label label1;
        private DataGridView hoaDonBanHangTable;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private GroupBox groupBox4;
        private TextBox maHoaDonText;
        private Label label3;
    }
}
