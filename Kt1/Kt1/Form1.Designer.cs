namespace Kt1
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
            btn_Xttsv = new Button();
            btn_XemDiem = new Button();
            SuspendLayout();
            // 
            // btn_Xttsv
            // 
            btn_Xttsv.Location = new Point(160, 48);
            btn_Xttsv.Name = "btn_Xttsv";
            btn_Xttsv.Size = new Size(159, 49);
            btn_Xttsv.TabIndex = 0;
            btn_Xttsv.Text = "Xem thông tin sinh viên";
            btn_Xttsv.UseVisualStyleBackColor = true;
            btn_Xttsv.Click += btn_Xttsv_Click;
            // 
            // btn_XemDiem
            // 
            btn_XemDiem.Location = new Point(160, 144);
            btn_XemDiem.Name = "btn_XemDiem";
            btn_XemDiem.Size = new Size(159, 47);
            btn_XemDiem.TabIndex = 1;
            btn_XemDiem.Text = "Xem điểm";
            btn_XemDiem.UseVisualStyleBackColor = true;
            btn_XemDiem.Click += btn_XemDiem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 253);
            Controls.Add(btn_XemDiem);
            Controls.Add(btn_Xttsv);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Xttsv;
        private Button btn_XemDiem;
    }
}