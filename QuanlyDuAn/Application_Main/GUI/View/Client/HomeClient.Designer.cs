namespace WinFormsApp2
{
    partial class HomeClient
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
            dgv_listdanhsach = new DataGridView();
            btn_CtDa = new Button();
            btn_TcDa = new Button();
            btn_TimKiem = new Button();
            txt_IdChungCu = new TextBox();
            label8 = new Label();
            txt_Dientich = new TextBox();
            label7 = new Label();
            txt_Gia = new TextBox();
            txt_Mota = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_Diachi = new TextBox();
            txt_Ten = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_Id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_listdanhsach).BeginInit();
            SuspendLayout();
            // 
            // dgv_listdanhsach
            // 
            dgv_listdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listdanhsach.Location = new Point(12, 12);
            dgv_listdanhsach.Name = "dgv_listdanhsach";
            dgv_listdanhsach.RowTemplate.Height = 25;
            dgv_listdanhsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listdanhsach.Size = new Size(938, 317);
            dgv_listdanhsach.TabIndex = 42;
            dgv_listdanhsach.CellClick += dgv_listdanhsach_CellClick;
            dgv_listdanhsach.ColumnHeaderMouseClick += dgv_listdanhsach_ColumnHeaderMouseClick;
            // 
            // btn_CtDa
            // 
            btn_CtDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CtDa.Location = new Point(828, 386);
            btn_CtDa.Name = "btn_CtDa";
            btn_CtDa.Size = new Size(120, 31);
            btn_CtDa.TabIndex = 40;
            btn_CtDa.Text = "Chi tiết dự án";
            btn_CtDa.UseVisualStyleBackColor = true;
            // 
            // btn_TcDa
            // 
            btn_TcDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TcDa.Location = new Point(828, 340);
            btn_TcDa.Name = "btn_TcDa";
            btn_TcDa.Size = new Size(120, 31);
            btn_TcDa.TabIndex = 38;
            btn_TcDa.Text = "Tất cả dự án";
            btn_TcDa.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TimKiem.Location = new Point(205, 335);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(95, 31);
            btn_TimKiem.TabIndex = 37;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // txt_IdChungCu
            // 
            txt_IdChungCu.Location = new Point(681, 391);
            txt_IdChungCu.Name = "txt_IdChungCu";
            txt_IdChungCu.Size = new Size(122, 23);
            txt_IdChungCu.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(556, 391);
            label8.Name = "label8";
            label8.Padding = new Padding(12, 0, 12, 0);
            label8.Size = new Size(119, 21);
            label8.TabIndex = 35;
            label8.Text = "ID Chung cư";
            // 
            // txt_Dientich
            // 
            txt_Dientich.Location = new Point(428, 391);
            txt_Dientich.Name = "txt_Dientich";
            txt_Dientich.Size = new Size(122, 23);
            txt_Dientich.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(303, 391);
            label7.Name = "label7";
            label7.Padding = new Padding(24, 0, 24, 0);
            label7.Size = new Size(119, 21);
            label7.TabIndex = 33;
            label7.Text = "Diện tích";
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(428, 436);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(122, 23);
            txt_Gia.TabIndex = 32;
            // 
            // txt_Mota
            // 
            txt_Mota.Location = new Point(553, 480);
            txt_Mota.Name = "txt_Mota";
            txt_Mota.Size = new Size(250, 23);
            txt_Mota.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(428, 482);
            label6.Name = "label6";
            label6.Padding = new Padding(34, 0, 35, 0);
            label6.Size = new Size(119, 21);
            label6.TabIndex = 30;
            label6.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(301, 438);
            label5.Name = "label5";
            label5.Padding = new Padding(43, 0, 43, 0);
            label5.Size = new Size(119, 21);
            label5.TabIndex = 29;
            label5.Text = "Giá";
            // 
            // txt_Diachi
            // 
            txt_Diachi.Location = new Point(164, 480);
            txt_Diachi.Name = "txt_Diachi";
            txt_Diachi.Size = new Size(256, 23);
            txt_Diachi.TabIndex = 28;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(164, 436);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(122, 23);
            txt_Ten.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 480);
            label4.Name = "label4";
            label4.Padding = new Padding(31, 0, 31, 0);
            label4.Size = new Size(119, 21);
            label4.TabIndex = 26;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 438);
            label3.Name = "label3";
            label3.Padding = new Padding(22, 0, 21, 0);
            label3.Size = new Size(119, 21);
            label3.TabIndex = 25;
            label3.Text = "Tên dự án";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(164, 391);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(122, 23);
            txt_Id.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 391);
            label2.Name = "label2";
            label2.Padding = new Padding(47, 0, 47, 0);
            label2.Size = new Size(119, 21);
            label2.TabIndex = 23;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 340);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 15, 0);
            label1.Size = new Size(147, 21);
            label1.TabIndex = 22;
            label1.Text = "Tìm kiếm dự án";
            // 
            // HomeClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 538);
            Controls.Add(dgv_listdanhsach);
            Controls.Add(btn_CtDa);
            Controls.Add(btn_TcDa);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_IdChungCu);
            Controls.Add(label8);
            Controls.Add(txt_Dientich);
            Controls.Add(label7);
            Controls.Add(txt_Gia);
            Controls.Add(txt_Mota);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_Diachi);
            Controls.Add(txt_Ten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "duan";
            FormClosed += HomeClient_FormClosed;
            Load += HomeClient_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listdanhsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listdanhsach;
        private Button btn_CtDa;
        private Button btn_TcDa;
        private Button btn_TimKiem;
        private TextBox txt_IdChungCu;
        private Label label8;
        private TextBox txt_Dientich;
        private Label label7;
        private TextBox txt_Gia;
        private TextBox txt_Mota;
        private Label label6;
        private Label label5;
        private TextBox txt_Diachi;
        private TextBox txt_Ten;
        private Label label4;
        private Label label3;
        private TextBox txt_Id;
        private Label label2;
        private Label label1;
    }
}