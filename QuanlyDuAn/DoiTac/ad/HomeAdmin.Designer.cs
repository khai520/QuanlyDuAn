
using System.Drawing;
using System.Windows.Forms;

namespace admin
{
    partial class HomeAdmin
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
            this.list_Danhsach = new System.Windows.Forms.ListView();
            this.clsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsTenDuAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsDiachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsMota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsDientich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsIDChungCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_TcDa = new System.Windows.Forms.Button();
            this.btn_DaCt = new System.Windows.Forms.Button();
            this.btn_CtDa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Danhsach
            // 
            this.list_Danhsach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.list_Danhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clsID,
            this.clsTenDuAn,
            this.clsDiachi,
            this.clsMota,
            this.clsGia,
            this.clsDientich,
            this.clsIDChungCu});
            this.list_Danhsach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.list_Danhsach.HideSelection = false;
            this.list_Danhsach.Location = new System.Drawing.Point(12, 12);
            this.list_Danhsach.Name = "list_Danhsach";
            this.list_Danhsach.Size = new System.Drawing.Size(1072, 324);
            this.list_Danhsach.TabIndex = 0;
            this.list_Danhsach.TileSize = new System.Drawing.Size(1, 1);
            this.list_Danhsach.UseCompatibleStateImageBehavior = false;
            this.list_Danhsach.View = System.Windows.Forms.View.Details;
            // 
            // clsID
            // 
            this.clsID.Tag = "";
            this.clsID.Text = "ID";
            this.clsID.Width = 150;
            // 
            // clsTenDuAn
            // 
            this.clsTenDuAn.Text = "Tên dự án";
            this.clsTenDuAn.Width = 184;
            // 
            // clsDiachi
            // 
            this.clsDiachi.Text = "Địa chỉ";
            this.clsDiachi.Width = 150;
            // 
            // clsMota
            // 
            this.clsMota.Text = "Mô tả";
            this.clsMota.Width = 200;
            // 
            // clsGia
            // 
            this.clsGia.Text = "Giá";
            this.clsGia.Width = 100;
            // 
            // clsDientich
            // 
            this.clsDientich.Text = "Diện tích";
            this.clsDientich.Width = 100;
            // 
            // clsIDChungCu
            // 
            this.clsIDChungCu.Text = "ID Chung cư";
            this.clsIDChungCu.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(45, 363);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm dự án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(45, 417);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(54, 0, 54, 0);
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(45, 467);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(25, 0, 24, 0);
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên dự án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(45, 512);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 465);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 512);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(292, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(344, 467);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(49, 0, 49, 0);
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(489, 514);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(39, 0, 40, 0);
            this.label6.Size = new System.Drawing.Size(143, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mô tả";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(632, 512);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(489, 465);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(346, 417);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diện tích";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(489, 417);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(635, 417);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label8.Size = new System.Drawing.Size(147, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID Chung cư";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(778, 417);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(139, 22);
            this.textBox7.TabIndex = 15;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_TimKiem.Location = new System.Drawing.Point(234, 357);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(109, 33);
            this.btn_TimKiem.TabIndex = 16;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_TcDa
            // 
            this.btn_TcDa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_TcDa.Location = new System.Drawing.Point(946, 363);
            this.btn_TcDa.Name = "btn_TcDa";
            this.btn_TcDa.Size = new System.Drawing.Size(137, 33);
            this.btn_TcDa.TabIndex = 17;
            this.btn_TcDa.Text = "Tất cả dự án";
            this.btn_TcDa.UseVisualStyleBackColor = true;
            // 
            // btn_DaCt
            // 
            this.btn_DaCt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_DaCt.Location = new System.Drawing.Point(946, 462);
            this.btn_DaCt.Name = "btn_DaCt";
            this.btn_DaCt.Size = new System.Drawing.Size(137, 33);
            this.btn_DaCt.TabIndex = 18;
            this.btn_DaCt.Text = "Dự án của tôi";
            this.btn_DaCt.UseVisualStyleBackColor = true;
            // 
            // btn_CtDa
            // 
            this.btn_CtDa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_CtDa.Location = new System.Drawing.Point(946, 412);
            this.btn_CtDa.Name = "btn_CtDa";
            this.btn_CtDa.Size = new System.Drawing.Size(137, 33);
            this.btn_CtDa.TabIndex = 19;
            this.btn_CtDa.Text = "Chi tiết dự án";
            this.btn_CtDa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 574);
            this.Controls.Add(this.btn_CtDa);
            this.Controls.Add(this.btn_DaCt);
            this.Controls.Add(this.btn_TcDa);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Danhsach);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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

    }

      
    
}

