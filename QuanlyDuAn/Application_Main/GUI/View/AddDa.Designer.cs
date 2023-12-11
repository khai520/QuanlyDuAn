namespace QuanLyDuAnBDS.GUI.View
{
    partial class AddDa
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
            txt_Ten = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Gia = new TextBox();
            txt_Dientich = new TextBox();
            btn_Thoat = new Button();
            btn_Dang = new Button();
            pb_anh = new PictureBox();
            txt_Mota = new RichTextBox();
            btn_Chuyen = new Button();
            cbx_1 = new ComboBox();
            cbx_2 = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_anh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 68);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên dự án :";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(216, 68);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(281, 23);
            txt_Ten.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 361);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 3;
            label3.Text = "Mô tả :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 242);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 4;
            label4.Text = "Giá :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(96, 303);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 5;
            label5.Text = "Diện tích";
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(205, 240);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(292, 23);
            txt_Gia.TabIndex = 8;
            // 
            // txt_Dientich
            // 
            txt_Dientich.Location = new Point(205, 301);
            txt_Dientich.Name = "txt_Dientich";
            txt_Dientich.Size = new Size(292, 23);
            txt_Dientich.TabIndex = 9;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Thoat.Location = new Point(579, 405);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(96, 41);
            btn_Thoat.TabIndex = 10;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Dang
            // 
            btn_Dang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Dang.Location = new Point(798, 405);
            btn_Dang.Name = "btn_Dang";
            btn_Dang.Size = new Size(96, 41);
            btn_Dang.TabIndex = 11;
            btn_Dang.Text = "Đăng";
            btn_Dang.UseVisualStyleBackColor = true;
            btn_Dang.Click += Dang_Click;
            // 
            // pb_anh
            // 
            pb_anh.BackgroundImage = Properties.Resources._1;
            pb_anh.BackgroundImageLayout = ImageLayout.Stretch;
            pb_anh.Location = new Point(527, 68);
            pb_anh.Name = "pb_anh";
            pb_anh.Size = new Size(423, 259);
            pb_anh.TabIndex = 12;
            pb_anh.TabStop = false;
            // 
            // txt_Mota
            // 
            txt_Mota.BorderStyle = BorderStyle.FixedSingle;
            txt_Mota.Location = new Point(205, 361);
            txt_Mota.Name = "txt_Mota";
            txt_Mota.Size = new Size(292, 85);
            txt_Mota.TabIndex = 13;
            txt_Mota.Text = "";
            // 
            // btn_Chuyen
            // 
            btn_Chuyen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Chuyen.Location = new Point(686, 333);
            btn_Chuyen.Name = "btn_Chuyen";
            btn_Chuyen.Size = new Size(96, 41);
            btn_Chuyen.TabIndex = 15;
            btn_Chuyen.Text = "Chuyển";
            btn_Chuyen.UseVisualStyleBackColor = true;
            btn_Chuyen.Click += Chuyen_Click;
            // 
            // cbx_1
            // 
            cbx_1.FormattingEnabled = true;
            cbx_1.Items.AddRange(new object[] { "Hà Nội", "Hồ Chí Minh", "Đà Nẵng", "Cần Thơ", "Hải Phòng", "An Giang", "Bà Rịa-Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cbx_1.Location = new Point(216, 128);
            cbx_1.Name = "cbx_1";
            cbx_1.Size = new Size(281, 23);
            cbx_1.TabIndex = 16;
            cbx_1.SelectedIndexChanged += cbx_1_SelectedIndexChanged;
            // 
            // cbx_2
            // 
            cbx_2.FormattingEnabled = true;
            cbx_2.Location = new Point(216, 184);
            cbx_2.Name = "cbx_2";
            cbx_2.Size = new Size(281, 23);
            cbx_2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 130);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 18;
            label6.Text = "Thành phố :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 186);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 19;
            label2.Text = "Quận / Huyện :";
            // 
            // AddDa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 538);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(cbx_2);
            Controls.Add(cbx_1);
            Controls.Add(btn_Chuyen);
            Controls.Add(txt_Mota);
            Controls.Add(pb_anh);
            Controls.Add(btn_Dang);
            Controls.Add(btn_Thoat);
            Controls.Add(txt_Dientich);
            Controls.Add(txt_Gia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Ten);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddDa";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDa";
            FormClosed += AddDa_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pb_anh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Ten;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Gia;
        private TextBox txt_Dientich;
        private Button btn_Thoat;
        private Button btn_Dang;
        private PictureBox pb_anh;
        private RichTextBox txt_Mota;
        private Button btn_Chuyen;
        private ComboBox cbx_1;
        private ComboBox cbx_2;
        private Label label6;
        private Label label2;
    }
}