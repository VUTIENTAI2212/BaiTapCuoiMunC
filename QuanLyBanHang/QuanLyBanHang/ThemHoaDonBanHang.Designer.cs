namespace QuanLyBanHang
{
    partial class ThemHoaDonBanHang
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
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            label3 = new Label();
            maKhachHangText = new TextBox();
            button2 = new Button();
            groupBox5 = new GroupBox();
            khachHangTable = new DataGridView();
            groupBox4 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            sdtKH = new TextBox();
            label1 = new Label();
            nameKH = new TextBox();
            groupBox2 = new GroupBox();
            groupBox9 = new GroupBox();
            label12 = new Label();
            soLuongHang = new TextBox();
            label6 = new Label();
            maSanPhamText = new TextBox();
            button4 = new Button();
            groupBox8 = new GroupBox();
            sanPhamTable = new DataGridView();
            groupBox7 = new GroupBox();
            button3 = new Button();
            label4 = new Label();
            nameSP = new TextBox();
            label5 = new Label();
            idSP = new TextBox();
            groupBox3 = new GroupBox();
            maHoaDonHD = new TextBox();
            button11 = new Button();
            groupBox10 = new GroupBox();
            groupBox11 = new GroupBox();
            button9 = new Button();
            label8 = new Label();
            soLuongMuaText = new TextBox();
            label13 = new Label();
            maSanPhamMuaText = new TextBox();
            button6 = new Button();
            groupBox12 = new GroupBox();
            sanPhamMuaTable = new DataGridView();
            label15 = new Label();
            button10 = new Button();
            tongTienSPText = new TextBox();
            label14 = new Label();
            label7 = new Label();
            maKHHD = new TextBox();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khachHangTable).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sanPhamTable).BeginInit();
            groupBox7.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sanPhamMuaTable).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 423);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(maKhachHangText);
            groupBox6.Controls.Add(button2);
            groupBox6.Location = new Point(13, 338);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(557, 62);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chức năng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 24);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 7;
            label3.Text = "Mã khách hàng:";
            // 
            // maKhachHangText
            // 
            maKhachHangText.Location = new Point(205, 21);
            maKhachHangText.Name = "maKhachHangText";
            maKhachHangText.Size = new Size(105, 27);
            maKhachHangText.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(417, 20);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Chọn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(khachHangTable);
            groupBox5.Location = new Point(16, 93);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(554, 239);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách khách hàng";
            // 
            // khachHangTable
            // 
            khachHangTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khachHangTable.Location = new Point(11, 25);
            khachHangTable.Name = "khachHangTable";
            khachHangTable.ReadOnly = true;
            khachHangTable.RowHeadersWidth = 51;
            khachHangTable.Size = new Size(537, 208);
            khachHangTable.TabIndex = 0;
            khachHangTable.CellContentClick += khachHangTable_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(sdtKH);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(nameKH);
            groupBox4.Location = new Point(12, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(558, 62);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.Location = new Point(458, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 29);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại";
            // 
            // sdtKH
            // 
            sdtKH.Location = new Point(331, 26);
            sdtKH.Name = "sdtKH";
            sdtKH.Size = new Size(105, 27);
            sdtKH.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên:";
            // 
            // nameKH
            // 
            nameKH.Location = new Point(103, 26);
            nameKH.Name = "nameKH";
            nameKH.Size = new Size(105, 27);
            nameKH.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox9);
            groupBox2.Controls.Add(groupBox8);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Location = new Point(8, 438);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 498);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(label12);
            groupBox9.Controls.Add(soLuongHang);
            groupBox9.Controls.Add(label6);
            groupBox9.Controls.Add(maSanPhamText);
            groupBox9.Controls.Add(button4);
            groupBox9.Location = new Point(30, 392);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(557, 99);
            groupBox9.TabIndex = 3;
            groupBox9.TabStop = false;
            groupBox9.Text = "Chức năng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 63);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 9;
            label12.Text = "Số lượng:";
            // 
            // soLuongHang
            // 
            soLuongHang.Location = new Point(128, 60);
            soLuongHang.Name = "soLuongHang";
            soLuongHang.Size = new Size(105, 27);
            soLuongHang.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 7;
            label6.Text = "Mã sản phẩm:";
            // 
            // maSanPhamText
            // 
            maSanPhamText.Location = new Point(128, 17);
            maSanPhamText.Name = "maSanPhamText";
            maSanPhamText.Size = new Size(105, 27);
            maSanPhamText.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(403, 44);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Chọn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(sanPhamTable);
            groupBox8.Location = new Point(23, 147);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(554, 239);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Danh sách sản phẩm";
            // 
            // sanPhamTable
            // 
            sanPhamTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sanPhamTable.Location = new Point(11, 25);
            sanPhamTable.Name = "sanPhamTable";
            sanPhamTable.ReadOnly = true;
            sanPhamTable.RowHeadersWidth = 51;
            sanPhamTable.Size = new Size(533, 208);
            sanPhamTable.TabIndex = 0;
            sanPhamTable.CellContentClick += sanPhamTable_CellContentClick;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button3);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(nameSP);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(idSP);
            groupBox7.Location = new Point(19, 26);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(558, 99);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tìm kiếm";
            // 
            // button3
            // 
            button3.Location = new Point(414, 49);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 69);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên sản phẩm:";
            // 
            // nameSP
            // 
            nameSP.Location = new Point(139, 66);
            nameSP.Name = "nameSP";
            nameSP.Size = new Size(105, 27);
            nameSP.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 26);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 1;
            label5.Text = "Mã sản phẩm:";
            // 
            // idSP
            // 
            idSP.Location = new Point(139, 26);
            idSP.Name = "idSP";
            idSP.Size = new Size(105, 27);
            idSP.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(maHoaDonHD);
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(groupBox10);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(tongTienSPText);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(maKHHD);
            groupBox3.Location = new Point(615, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 907);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn bán hàng";
            // 
            // maHoaDonHD
            // 
            maHoaDonHD.Location = new Point(417, 32);
            maHoaDonHD.Name = "maHoaDonHD";
            maHoaDonHD.Size = new Size(142, 27);
            maHoaDonHD.TabIndex = 18;
            // 
            // button11
            // 
            button11.Location = new Point(84, 852);
            button11.Name = "button11";
            button11.Size = new Size(126, 43);
            button11.TabIndex = 12;
            button11.Text = "Hủy";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(groupBox11);
            groupBox10.Controls.Add(groupBox12);
            groupBox10.Location = new Point(6, 76);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(577, 720);
            groupBox10.TabIndex = 3;
            groupBox10.TabStop = false;
            groupBox10.Text = "Sản phẩm";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(button9);
            groupBox11.Controls.Add(label8);
            groupBox11.Controls.Add(soLuongMuaText);
            groupBox11.Controls.Add(label13);
            groupBox11.Controls.Add(maSanPhamMuaText);
            groupBox11.Controls.Add(button6);
            groupBox11.Location = new Point(19, 595);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(557, 108);
            groupBox11.TabIndex = 4;
            groupBox11.TabStop = false;
            groupBox11.Text = "Chức năng";
            // 
            // button9
            // 
            button9.Location = new Point(424, 18);
            button9.Name = "button9";
            button9.Size = new Size(94, 34);
            button9.TabIndex = 10;
            button9.Text = "Chỉnh sửa";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 71);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 9;
            label8.Text = "Số lượng:";
            // 
            // soLuongMuaText
            // 
            soLuongMuaText.Location = new Point(128, 68);
            soLuongMuaText.Name = "soLuongMuaText";
            soLuongMuaText.Size = new Size(105, 27);
            soLuongMuaText.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 29);
            label13.Name = "label13";
            label13.Size = new Size(101, 20);
            label13.TabIndex = 7;
            label13.Text = "Mã sản phẩm:";
            // 
            // maSanPhamMuaText
            // 
            maSanPhamMuaText.Location = new Point(128, 22);
            maSanPhamMuaText.Name = "maSanPhamMuaText";
            maSanPhamMuaText.Size = new Size(105, 27);
            maSanPhamMuaText.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(424, 62);
            button6.Name = "button6";
            button6.Size = new Size(94, 33);
            button6.TabIndex = 5;
            button6.Text = "Xóa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(sanPhamMuaTable);
            groupBox12.Location = new Point(19, 26);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(554, 553);
            groupBox12.TabIndex = 2;
            groupBox12.TabStop = false;
            groupBox12.Text = "Danh sách sản phẩm";
            // 
            // sanPhamMuaTable
            // 
            sanPhamMuaTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sanPhamMuaTable.Location = new Point(11, 25);
            sanPhamMuaTable.Name = "sanPhamMuaTable";
            sanPhamMuaTable.RowHeadersWidth = 51;
            sanPhamMuaTable.Size = new Size(537, 522);
            sanPhamMuaTable.TabIndex = 0;
            sanPhamMuaTable.CellContentClick += sanPhamMuaTable_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(290, 38);
            label15.Name = "label15";
            label15.Size = new Size(92, 20);
            label15.TabIndex = 17;
            label15.Text = "Mã hóa đơn:";
            // 
            // button10
            // 
            button10.Location = new Point(408, 852);
            button10.Name = "button10";
            button10.Size = new Size(126, 41);
            button10.TabIndex = 11;
            button10.Text = "Thanh toán";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // tongTienSPText
            // 
            tongTienSPText.Location = new Point(290, 808);
            tongTienSPText.Name = "tongTienSPText";
            tongTienSPText.Size = new Size(142, 27);
            tongTienSPText.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(121, 811);
            label14.Name = "label14";
            label14.Size = new Size(143, 20);
            label14.TabIndex = 6;
            label14.Text = "Tổng tiền sản phẩm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 38);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 3;
            label7.Text = "Mã khách hàng:";
            // 
            // maKHHD
            // 
            maKHHD.Location = new Point(153, 34);
            maKHHD.Name = "maKHHD";
            maKHHD.Size = new Size(105, 27);
            maKHHD.TabIndex = 2;
            // 
            // ThemHoaDonBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 933);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ThemHoaDonBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietBanHang";
            Load += ThemHoaDonBanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)khachHangTable).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sanPhamTable).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sanPhamMuaTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private DataGridView khachHangTable;
        private GroupBox groupBox4;
        private Button button1;
        private Label label2;
        private TextBox sdtKH;
        private Label label1;
        private TextBox nameKH;
        private Label label3;
        private TextBox maKhachHangText;
        private Button button2;
        private GroupBox groupBox9;
        private Label label6;
        private TextBox maSanPhamText;
        private Button button4;
        private GroupBox groupBox8;
        private DataGridView sanPhamTable;
        private GroupBox groupBox7;
        private Button button3;
        private Label label4;
        private TextBox nameSP;
        private Label label5;
        private TextBox idSP;
        private Label label7;
        private TextBox maKHHD;
        private GroupBox groupBox10;
        private GroupBox groupBox12;
        private DataGridView sanPhamMuaTable;
        private Label label12;
        private TextBox soLuongHang;
        private GroupBox groupBox11;
        private Label label8;
        private TextBox soLuongMuaText;
        private Label label13;
        private TextBox maSanPhamMuaText;
        private Button button6;
        private Button button10;
        private TextBox tongTienSPText;
        private Label label14;
        private Button button9;
        private Button button11;
        private TextBox maHoaDonHD;
        private Label label15;
    }
}