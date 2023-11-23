namespace Kt1
{
    partial class Form2
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
            lb_1 = new Label();
            lb_2 = new Label();
            lb_3 = new Label();
            txt_Msv = new TextBox();
            txt_Hvt = new TextBox();
            txt_dt = new TextBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            dgv_danhsach = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).BeginInit();
            SuspendLayout();
            // 
            // lb_1
            // 
            lb_1.AutoSize = true;
            lb_1.Location = new Point(98, 62);
            lb_1.Margin = new Padding(4, 0, 4, 0);
            lb_1.Name = "lb_1";
            lb_1.Size = new Size(98, 21);
            lb_1.TabIndex = 0;
            lb_1.Text = "Mã sinh viên";
            // 
            // lb_2
            // 
            lb_2.AutoSize = true;
            lb_2.Location = new Point(98, 134);
            lb_2.Margin = new Padding(4, 0, 4, 0);
            lb_2.Name = "lb_2";
            lb_2.Size = new Size(142, 21);
            lb_2.TabIndex = 1;
            lb_2.Text = "Họ và tên sinh viên";
            // 
            // lb_3
            // 
            lb_3.AutoSize = true;
            lb_3.Location = new Point(98, 209);
            lb_3.Margin = new Padding(4, 0, 4, 0);
            lb_3.Name = "lb_3";
            lb_3.Size = new Size(81, 21);
            lb_3.TabIndex = 2;
            lb_3.Text = "Điện thoại";
            // 
            // txt_Msv
            // 
            txt_Msv.Location = new Point(256, 54);
            txt_Msv.Name = "txt_Msv";
            txt_Msv.Size = new Size(256, 29);
            txt_Msv.TabIndex = 3;
            // 
            // txt_Hvt
            // 
            txt_Hvt.Location = new Point(256, 126);
            txt_Hvt.Name = "txt_Hvt";
            txt_Hvt.Size = new Size(256, 29);
            txt_Hvt.TabIndex = 4;
            // 
            // txt_dt
            // 
            txt_dt.Location = new Point(256, 201);
            txt_dt.Name = "txt_dt";
            txt_dt.Size = new Size(256, 29);
            txt_dt.TabIndex = 5;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(846, 54);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 29);
            btn_Them.TabIndex = 6;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(846, 125);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 29);
            btn_Sua.TabIndex = 7;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(846, 205);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 29);
            btn_Xoa.TabIndex = 8;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // dgv_danhsach
            // 
            dgv_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhsach.Location = new Point(98, 342);
            dgv_danhsach.Name = "dgv_danhsach";
            dgv_danhsach.RowTemplate.Height = 25;
            dgv_danhsach.Size = new Size(823, 174);
            dgv_danhsach.TabIndex = 9;
            dgv_danhsach.CellClick += dgv_danhsach_CellClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(dgv_danhsach);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(txt_dt);
            Controls.Add(txt_Hvt);
            Controls.Add(txt_Msv);
            Controls.Add(lb_3);
            Controls.Add(lb_2);
            Controls.Add(lb_1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_1;
        private Label lb_2;
        private Label lb_3;
        private TextBox txt_Msv;
        private TextBox txt_Hvt;
        private TextBox txt_dt;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private DataGridView dgv_danhsach;
    }
}