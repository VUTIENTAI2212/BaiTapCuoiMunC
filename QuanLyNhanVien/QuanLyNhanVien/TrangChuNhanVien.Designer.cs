namespace QuanLyNhanVien
{
    partial class TrangChuNhanVien
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
            tkSdt_NV = new TextBox();
            label2 = new Label();
            tkName_NV = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            nhanVienTable = new DataGridView();
            groupBox3 = new GroupBox();
            maNV = new TextBox();
            button5 = new Button();
            button4 = new Button();
            XoaNhanVien = new Button();
            ChinhSuaNhanVien = new Button();
            ThemNhanVien = new Button();
            groupBox4 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nhanVienTable).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tkSdt_NV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tkName_NV);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(976, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(758, 32);
            button1.Name = "button1";
            button1.Size = new Size(162, 37);
            button1.TabIndex = 5;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // tkSdt_NV
            // 
            tkSdt_NV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tkSdt_NV.Location = new Point(495, 35);
            tkSdt_NV.Name = "tkSdt_NV";
            tkSdt_NV.Size = new Size(188, 30);
            tkSdt_NV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(375, 40);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại:";
            // 
            // tkName_NV
            // 
            tkName_NV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tkName_NV.Location = new Point(122, 35);
            tkName_NV.Name = "tkName_NV";
            tkName_NV.Size = new Size(188, 30);
            tkName_NV.TabIndex = 1;
            tkName_NV.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nhanVienTable);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(972, 432);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // nhanVienTable
            // 
            nhanVienTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nhanVienTable.Location = new Point(10, 29);
            nhanVienTable.Name = "nhanVienTable";
            nhanVienTable.ReadOnly = true;
            nhanVienTable.RowHeadersWidth = 51;
            nhanVienTable.Size = new Size(954, 399);
            nhanVienTable.TabIndex = 0;
            nhanVienTable.CellContentClick += nhanVienTable_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(ThemNhanVien);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 545);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(966, 154);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // maNV
            // 
            maNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maNV.Location = new Point(138, 58);
            maNV.Multiline = true;
            maNV.Name = "maNV";
            maNV.Size = new Size(98, 38);
            maNV.TabIndex = 6;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(796, 57);
            button5.Name = "button5";
            button5.Size = new Size(162, 52);
            button5.TabIndex = 4;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(617, 57);
            button4.Name = "button4";
            button4.Size = new Size(162, 52);
            button4.TabIndex = 3;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // XoaNhanVien
            // 
            XoaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XoaNhanVien.Location = new Point(242, 78);
            XoaNhanVien.Name = "XoaNhanVien";
            XoaNhanVien.Size = new Size(162, 52);
            XoaNhanVien.TabIndex = 2;
            XoaNhanVien.Text = "Xóa";
            XoaNhanVien.UseVisualStyleBackColor = true;
            XoaNhanVien.Click += button3_Click;
            // 
            // ChinhSuaNhanVien
            // 
            ChinhSuaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChinhSuaNhanVien.Location = new Point(242, 20);
            ChinhSuaNhanVien.Name = "ChinhSuaNhanVien";
            ChinhSuaNhanVien.Size = new Size(162, 52);
            ChinhSuaNhanVien.TabIndex = 1;
            ChinhSuaNhanVien.Text = "Chỉnh sửa";
            ChinhSuaNhanVien.UseVisualStyleBackColor = true;
            ChinhSuaNhanVien.Click += ChinhSuaNhanVien_Click;
            // 
            // ThemNhanVien
            // 
            ThemNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemNhanVien.Location = new Point(4, 56);
            ThemNhanVien.Name = "ThemNhanVien";
            ThemNhanVien.Size = new Size(162, 52);
            ThemNhanVien.TabIndex = 0;
            ThemNhanVien.Text = "Thêm";
            ThemNhanVien.UseVisualStyleBackColor = true;
            ThemNhanVien.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(maNV);
            groupBox4.Controls.Add(XoaNhanVien);
            groupBox4.Controls.Add(ChinhSuaNhanVien);
            groupBox4.Location = new Point(181, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(430, 136);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 7;
            label3.Text = "Mã nhân viên:";
            // 
            // TrangChuNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 701);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TrangChuNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += NhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nhanVienTable).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private Button XoaNhanVien;
        private Button ChinhSuaNhanVien;
        private Button ThemNhanVien;
        private DataGridView nhanVienTable;
        private TextBox tkName_NV;
        private Label label1;
        private Button button1;
        private TextBox tkSdt_NV;
        private Label label2;
        private TextBox maNV;
        private GroupBox groupBox4;
        private Label label3;
    }
}
