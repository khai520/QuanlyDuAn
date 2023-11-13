
namespace Application
{
    partial class HomeDT
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
            list_Danhsach = new ListView();
            clsThutu = new ColumnHeader();
            clsID = new ColumnHeader();
            clsTenDuAn = new ColumnHeader();
            clsDiachi = new ColumnHeader();
            clsMota = new ColumnHeader();
            clsGia = new ColumnHeader();
            clsDientich = new ColumnHeader();
            clsIDChungCu = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            btn_TimKiem = new Button();
            btn_TcDa = new Button();
            btn_DaCt = new Button();
            btn_CtDa = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // list_Danhsach
            // 
            list_Danhsach.AllowColumnReorder = true;
            list_Danhsach.CheckBoxes = true;
            list_Danhsach.Columns.AddRange(new ColumnHeader[] { clsThutu, clsID, clsTenDuAn, clsDiachi, clsMota, clsGia, clsDientich, clsIDChungCu });
            list_Danhsach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            list_Danhsach.FullRowSelect = true;
            list_Danhsach.ImeMode = ImeMode.NoControl;
            list_Danhsach.Location = new Point(12, 12);
            list_Danhsach.MultiSelect = false;
            list_Danhsach.Name = "list_Danhsach";
            list_Danhsach.Size = new Size(938, 304);
            list_Danhsach.TabIndex = 0;
            list_Danhsach.TileSize = new Size(1, 1);
            list_Danhsach.UseCompatibleStateImageBehavior = false;
            list_Danhsach.View = View.Details;
            list_Danhsach.ColumnClick += ColumnClick;
            list_Danhsach.SelectedIndexChanged += list_Danhsach_SelectedIndexChanged;
            // 
            // clsThutu
            // 
            clsThutu.Text = "Thứ tự";
            // 
            // clsID
            // 
            clsID.Tag = "";
            clsID.Text = "ID";
            clsID.Width = 100;
            // 
            // clsTenDuAn
            // 
            clsTenDuAn.Text = "Tên dự án";
            clsTenDuAn.Width = 184;
            // 
            // clsDiachi
            // 
            clsDiachi.Text = "Địa chỉ";
            clsDiachi.Width = 150;
            // 
            // clsMota
            // 
            clsMota.Text = "Mô tả";
            clsMota.Width = 200;
            // 
            // clsGia
            // 
            clsGia.Text = "Giá";
            clsGia.Width = 100;
            // 
            // clsDientich
            // 
            clsDientich.Text = "Diện tích";
            clsDientich.Width = 100;
            // 
            // clsIDChungCu
            // 
            clsIDChungCu.Text = "ID Chung cư";
            clsIDChungCu.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 340);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 15, 0);
            label1.Size = new Size(147, 21);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm dự án";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 391);
            label2.Name = "label2";
            label2.Padding = new Padding(47, 0, 47, 0);
            label2.Size = new Size(119, 21);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 438);
            label3.Name = "label3";
            label3.Padding = new Padding(22, 0, 21, 0);
            label3.Size = new Size(119, 21);
            label3.TabIndex = 4;
            label3.Text = "Tên dự án";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 480);
            label4.Name = "label4";
            label4.Padding = new Padding(31, 0, 31, 0);
            label4.Size = new Size(119, 21);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 436);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 480);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(301, 438);
            label5.Name = "label5";
            label5.Padding = new Padding(43, 0, 43, 0);
            label5.Size = new Size(119, 21);
            label5.TabIndex = 8;
            label5.Text = "Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(428, 482);
            label6.Name = "label6";
            label6.Padding = new Padding(34, 0, 35, 0);
            label6.Size = new Size(119, 21);
            label6.TabIndex = 9;
            label6.Text = "Mô tả";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(553, 480);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(428, 436);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(303, 391);
            label7.Name = "label7";
            label7.Padding = new Padding(24, 0, 24, 0);
            label7.Size = new Size(119, 21);
            label7.TabIndex = 12;
            label7.Text = "Diện tích";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(428, 391);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 23);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(556, 391);
            label8.Name = "label8";
            label8.Padding = new Padding(12, 0, 12, 0);
            label8.Size = new Size(119, 21);
            label8.TabIndex = 14;
            label8.Text = "ID Chung cư";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(681, 391);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(122, 23);
            textBox7.TabIndex = 15;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TimKiem.Location = new Point(205, 335);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(95, 31);
            btn_TimKiem.TabIndex = 16;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_TcDa
            // 
            btn_TcDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TcDa.Location = new Point(828, 340);
            btn_TcDa.Name = "btn_TcDa";
            btn_TcDa.Size = new Size(120, 31);
            btn_TcDa.TabIndex = 17;
            btn_TcDa.Text = "Tất cả dự án";
            btn_TcDa.UseVisualStyleBackColor = true;
            btn_TcDa.Click += btn_TcDa_Click;
            // 
            // btn_DaCt
            // 
            btn_DaCt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DaCt.Location = new Point(828, 429);
            btn_DaCt.Name = "btn_DaCt";
            btn_DaCt.Size = new Size(120, 31);
            btn_DaCt.TabIndex = 18;
            btn_DaCt.Text = "Dự án của tôi";
            btn_DaCt.UseVisualStyleBackColor = true;
            // 
            // btn_CtDa
            // 
            btn_CtDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CtDa.Location = new Point(828, 386);
            btn_CtDa.Name = "btn_CtDa";
            btn_CtDa.Size = new Size(120, 31);
            btn_CtDa.TabIndex = 19;
            btn_CtDa.Text = "Chi tiết dự án";
            btn_CtDa.UseVisualStyleBackColor = true;
            btn_CtDa.Click += btn_CtDa_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(828, 468);
            button1.Name = "button1";
            button1.Size = new Size(120, 58);
            button1.TabIndex = 20;
            button1.Text = "Đăng thêm dự án mơi";
            button1.UseVisualStyleBackColor = true;
            // 
            // HomeDT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 538);
            Controls.Add(button1);
            Controls.Add(btn_CtDa);
            Controls.Add(btn_DaCt);
            Controls.Add(btn_TcDa);
            Controls.Add(btn_TimKiem);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(list_Danhsach);
            MaximizeBox = false;
            Name = "HomeDT";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void List_Danhsach_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListView list_Danhsach;
        private ColumnHeader clsID;
        private ColumnHeader clsTenDuAn;
        private ColumnHeader clsDiachi;
        private ColumnHeader clsMota;
        private ColumnHeader clsGia;
        private ColumnHeader clsDientich;
        private ColumnHeader clsIDChungCu;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Button btn_TimKiem;
        private Button btn_TcDa;
        private Button btn_DaCt;
        private Button btn_CtDa;
        private ColumnHeader clsThutu;
        private Button button1;
    }
}