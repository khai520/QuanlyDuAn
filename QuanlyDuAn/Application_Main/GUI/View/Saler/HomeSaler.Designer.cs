namespace WinFormsApp1
{
    partial class HomeSaler
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            clTenDuAn = new DataGridViewTextBoxColumn();
            cldiachi = new DataGridViewTextBoxColumn();
            clmota = new DataGridViewTextBoxColumn();
            clgia = new DataGridViewTextBoxColumn();
            cldientich = new DataGridViewTextBoxColumn();
            clidchungcu = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            btxtimkiemchucnang = new Button();
            btxtimkiem = new Button();
            btxID = new Button();
            btxtenduan = new Button();
            btxdiachi = new Button();
            txttenduan = new TextBox();
            txtdiachi = new TextBox();
            btxdientich = new Button();
            btxgia = new Button();
            btxmota = new Button();
            txtgia = new TextBox();
            textBox3 = new TextBox();
            txtmota = new TextBox();
            btxIDChungCu = new Button();
            txtChungCu = new TextBox();
            bxtchitietduan = new Button();
            button2 = new Button();
            btxduan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, clTenDuAn, cldiachi, clmota, clgia, cldientich, clidchungcu });
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 226);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // clTenDuAn
            // 
            clTenDuAn.HeaderText = "Ten du an";
            clTenDuAn.Name = "clTenDuAn";
            // 
            // cldiachi
            // 
            cldiachi.HeaderText = "dia chi";
            cldiachi.Name = "cldiachi";
            // 
            // clmota
            // 
            clmota.HeaderText = "mo ta ";
            clmota.Name = "clmota";
            // 
            // clgia
            // 
            clgia.HeaderText = "gia ";
            clgia.Name = "clgia";
            // 
            // cldientich
            // 
            cldientich.HeaderText = "dientich";
            cldientich.Name = "cldientich";
            // 
            // clidchungcu
            // 
            clidchungcu.HeaderText = "ID Chung Cu";
            clidchungcu.Name = "clidchungcu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 293);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 1;
            // 
            // btxtimkiemchucnang
            // 
            btxtimkiemchucnang.Location = new Point(36, 252);
            btxtimkiemchucnang.Name = "btxtimkiemchucnang";
            btxtimkiemchucnang.Size = new Size(100, 23);
            btxtimkiemchucnang.TabIndex = 2;
            btxtimkiemchucnang.Text = "tim kiem du an";
            btxtimkiemchucnang.UseVisualStyleBackColor = true;
            // 
            // btxtimkiem
            // 
            btxtimkiem.Location = new Point(158, 252);
            btxtimkiem.Name = "btxtimkiem";
            btxtimkiem.Size = new Size(75, 23);
            btxtimkiem.TabIndex = 3;
            btxtimkiem.Text = "tim kiem";
            btxtimkiem.UseVisualStyleBackColor = true;
            // 
            // btxID
            // 
            btxID.Location = new Point(32, 292);
            btxID.Name = "btxID";
            btxID.Size = new Size(75, 23);
            btxID.TabIndex = 4;
            btxID.Text = "ID";
            btxID.UseVisualStyleBackColor = true;
            // 
            // btxtenduan
            // 
            btxtenduan.Location = new Point(32, 336);
            btxtenduan.Name = "btxtenduan";
            btxtenduan.Size = new Size(75, 23);
            btxtenduan.TabIndex = 5;
            btxtenduan.Text = "Ten du an";
            btxtenduan.UseVisualStyleBackColor = true;
            // 
            // btxdiachi
            // 
            btxdiachi.Location = new Point(32, 387);
            btxdiachi.Name = "btxdiachi";
            btxdiachi.Size = new Size(75, 23);
            btxdiachi.TabIndex = 6;
            btxdiachi.Text = "dia chi";
            btxdiachi.UseVisualStyleBackColor = true;
            // 
            // txttenduan
            // 
            txttenduan.Location = new Point(113, 336);
            txttenduan.Name = "txttenduan";
            txttenduan.Size = new Size(120, 23);
            txttenduan.TabIndex = 7;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(113, 387);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(216, 23);
            txtdiachi.TabIndex = 8;
            // 
            // btxdientich
            // 
            btxdientich.Location = new Point(239, 293);
            btxdientich.Name = "btxdientich";
            btxdientich.Size = new Size(75, 23);
            btxdientich.TabIndex = 9;
            btxdientich.Text = "dien tich";
            btxdientich.UseVisualStyleBackColor = true;
            // 
            // btxgia
            // 
            btxgia.Location = new Point(239, 335);
            btxgia.Name = "btxgia";
            btxgia.Size = new Size(75, 23);
            btxgia.TabIndex = 10;
            btxgia.Text = "gia";
            btxgia.UseVisualStyleBackColor = true;
            // 
            // btxmota
            // 
            btxmota.Location = new Point(350, 387);
            btxmota.Name = "btxmota";
            btxmota.Size = new Size(75, 23);
            btxmota.TabIndex = 11;
            btxmota.Text = "mo ta ";
            btxmota.UseVisualStyleBackColor = true;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(320, 337);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(120, 23);
            txtgia.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(320, 294);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 13;
            // 
            // txtmota
            // 
            txtmota.Location = new Point(452, 389);
            txtmota.Name = "txtmota";
            txtmota.Size = new Size(211, 23);
            txtmota.TabIndex = 14;
            // 
            // btxIDChungCu
            // 
            btxIDChungCu.Location = new Point(451, 294);
            btxIDChungCu.Name = "btxIDChungCu";
            btxIDChungCu.Size = new Size(85, 23);
            btxIDChungCu.TabIndex = 15;
            btxIDChungCu.Text = "ID Chung Cu";
            btxIDChungCu.UseVisualStyleBackColor = true;
            // 
            // txtChungCu
            // 
            txtChungCu.Location = new Point(542, 295);
            txtChungCu.Name = "txtChungCu";
            txtChungCu.Size = new Size(120, 23);
            txtChungCu.TabIndex = 16;
            // 
            // bxtchitietduan
            // 
            bxtchitietduan.Location = new Point(798, 292);
            bxtchitietduan.Name = "bxtchitietduan";
            bxtchitietduan.Size = new Size(85, 23);
            bxtchitietduan.TabIndex = 17;
            bxtchitietduan.Text = "chi tiet du an";
            bxtchitietduan.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(798, 337);
            button2.Name = "button2";
            button2.Size = new Size(85, 55);
            button2.TabIndex = 18;
            button2.Text = "danh sach khach hang";
            button2.UseVisualStyleBackColor = true;
            // 
            // btxduan
            // 
            btxduan.Location = new Point(798, 252);
            btxduan.Name = "btxduan";
            btxduan.Size = new Size(85, 23);
            btxduan.TabIndex = 19;
            btxduan.Text = "tat ca du an";
            btxduan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 450);
            Controls.Add(btxduan);
            Controls.Add(button2);
            Controls.Add(bxtchitietduan);
            Controls.Add(txtChungCu);
            Controls.Add(btxIDChungCu);
            Controls.Add(txtmota);
            Controls.Add(textBox3);
            Controls.Add(txtgia);
            Controls.Add(btxmota);
            Controls.Add(btxgia);
            Controls.Add(btxdientich);
            Controls.Add(txtdiachi);
            Controls.Add(txttenduan);
            Controls.Add(btxdiachi);
            Controls.Add(btxtenduan);
            Controls.Add(btxID);
            Controls.Add(btxtimkiem);
            Controls.Add(btxtimkiemchucnang);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn clTenDuAn;
        private DataGridViewTextBoxColumn cldiachi;
        private DataGridViewTextBoxColumn clmota;
        private DataGridViewTextBoxColumn clgia;
        private DataGridViewTextBoxColumn cldientich;
        private DataGridViewTextBoxColumn clidchungcu;
        private TextBox textBox1;
        private Button btxtimkiemchucnang;
        private Button btxtimkiem;
        private Button btxID;
        private Button btxtenduan;
        private Button btxdiachi;
        private TextBox txttenduan;
        private TextBox txtdiachi;
        private Button btxdientich;
        private Button btxgia;
        private Button btxmota;
        private TextBox txtgia;
        private TextBox textBox3;
        private TextBox txtmota;
        private Button btxIDChungCu;
        private TextBox txtChungCu;
        private Button bxtchitietduan;
        private Button button2;
        private Button btxduan;
    }
}