namespace ADOdemo
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
            lbmanv = new Label();
            lbhoten = new Label();
            lbngaysinh = new Label();
            lbgioitinh = new Label();
            lbphongban = new Label();
            label1 = new Label();
            dgvdanhsach = new DataGridView();
            grbdanhsachnhanvien = new GroupBox();
            txtmanhanvien = new TextBox();
            txthoten = new TextBox();
            dtpngaysinh = new DateTimePicker();
            rdbnam = new RadioButton();
            rdbbnu = new RadioButton();
            cbxphongban = new ComboBox();
            btnThem = new Button();
            btnUpdate = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsach).BeginInit();
            grbdanhsachnhanvien.SuspendLayout();
            SuspendLayout();
            // 
            // lbmanv
            // 
            lbmanv.AutoSize = true;
            lbmanv.Location = new Point(107, 50);
            lbmanv.Name = "lbmanv";
            lbmanv.Size = new Size(102, 20);
            lbmanv.TabIndex = 0;
            lbmanv.Text = "Ma Nhan Vien";
            // 
            // lbhoten
            // 
            lbhoten.AutoSize = true;
            lbhoten.Location = new Point(107, 97);
            lbhoten.Name = "lbhoten";
            lbhoten.Size = new Size(56, 20);
            lbhoten.TabIndex = 1;
            lbhoten.Text = "Ho Ten";
            // 
            // lbngaysinh
            // 
            lbngaysinh.AutoSize = true;
            lbngaysinh.Location = new Point(107, 150);
            lbngaysinh.Name = "lbngaysinh";
            lbngaysinh.Size = new Size(76, 20);
            lbngaysinh.TabIndex = 2;
            lbngaysinh.Text = "Ngay Sinh";
            // 
            // lbgioitinh
            // 
            lbgioitinh.AutoSize = true;
            lbgioitinh.Location = new Point(107, 202);
            lbgioitinh.Name = "lbgioitinh";
            lbgioitinh.Size = new Size(68, 20);
            lbgioitinh.TabIndex = 3;
            lbgioitinh.Text = "Gioi Tinh";
            // 
            // lbphongban
            // 
            lbphongban.AutoSize = true;
            lbphongban.Location = new Point(107, 242);
            lbphongban.Name = "lbphongban";
            lbphongban.Size = new Size(80, 20);
            lbphongban.TabIndex = 4;
            lbphongban.Text = "Phong Ban";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 23);
            label1.TabIndex = 5;
            label1.Text = "QUAN LY THONG TIN NHANN VIEN";
            // 
            // dgvdanhsach
            // 
            dgvdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsach.Location = new Point(22, 35);
            dgvdanhsach.Name = "dgvdanhsach";
            dgvdanhsach.RowHeadersWidth = 51;
            dgvdanhsach.RowTemplate.Height = 29;
            dgvdanhsach.Size = new Size(781, 182);
            dgvdanhsach.TabIndex = 6;

            // 
            // grbdanhsachnhanvien
            // 
            grbdanhsachnhanvien.Controls.Add(dgvdanhsach);
            grbdanhsachnhanvien.Location = new Point(85, 273);
            grbdanhsachnhanvien.Name = "grbdanhsachnhanvien";
            grbdanhsachnhanvien.Size = new Size(849, 249);
            grbdanhsachnhanvien.TabIndex = 7;
            grbdanhsachnhanvien.TabStop = false;
            grbdanhsachnhanvien.Text = "Danh Sach Nhan Vien";

            // 
            // txtmanhanvien
            // 
            txtmanhanvien.Location = new Point(313, 50);
            txtmanhanvien.Name = "txtmanhanvien";
            txtmanhanvien.Size = new Size(307, 27);
            txtmanhanvien.TabIndex = 8;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(313, 97);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(307, 27);
            txthoten.TabIndex = 9;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.CustomFormat = "dd-MM-yyyy";
            dtpngaysinh.Format = DateTimePickerFormat.Custom;
            dtpngaysinh.Location = new Point(313, 150);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(307, 27);
            dtpngaysinh.TabIndex = 11;
            dtpngaysinh.Value = new DateTime(2023, 11, 14, 17, 23, 20, 0);
            // 
            // rdbnam
            // 
            rdbnam.AutoSize = true;
            rdbnam.Location = new Point(313, 198);
            rdbnam.Name = "rdbnam";
            rdbnam.Size = new Size(62, 24);
            rdbnam.TabIndex = 12;
            rdbnam.TabStop = true;
            rdbnam.Text = "Nam";
            rdbnam.UseVisualStyleBackColor = true;
            // 
            // rdbbnu
            // 
            rdbbnu.AutoSize = true;
            rdbbnu.Location = new Point(420, 198);
            rdbbnu.Name = "rdbbnu";
            rdbbnu.Size = new Size(49, 24);
            rdbbnu.TabIndex = 13;
            rdbbnu.TabStop = true;
            rdbbnu.Text = "Nu";
            rdbbnu.UseVisualStyleBackColor = true;
            // 
            // cbxphongban
            // 
            cbxphongban.FormattingEnabled = true;
            cbxphongban.Location = new Point(313, 239);
            cbxphongban.Name = "cbxphongban";
            cbxphongban.Size = new Size(307, 28);
            cbxphongban.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(121, 532);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;

            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(303, 528);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;

            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(474, 528);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;

            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(639, 523);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 564);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnUpdate);
            Controls.Add(btnThem);
            Controls.Add(cbxphongban);
            Controls.Add(rdbbnu);
            Controls.Add(rdbnam);
            Controls.Add(dtpngaysinh);
            Controls.Add(txthoten);
            Controls.Add(txtmanhanvien);
            Controls.Add(grbdanhsachnhanvien);
            Controls.Add(label1);
            Controls.Add(lbphongban);
            Controls.Add(lbgioitinh);
            Controls.Add(lbngaysinh);
            Controls.Add(lbhoten);
            Controls.Add(lbmanv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvdanhsach).EndInit();
            grbdanhsachnhanvien.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbmanv;
        private Label lbhoten;
        private Label lbngaysinh;
        private Label lbgioitinh;
        private Label lbphongban;
        private Label label1;
        private DataGridView dgvdanhsach;
        private GroupBox grbdanhsachnhanvien;
        private TextBox txtmanhanvien;
        private TextBox txthoten;
        private DateTimePicker dtpngaysinh;
        private RadioButton rdbnam;
        private RadioButton rdbbnu;
        private ComboBox cbxphongban;
        private Button btnThem;
        private Button btnUpdate;
        private Button btnXoa;
        private Button btnThoat;
    }
}