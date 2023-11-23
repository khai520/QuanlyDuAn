namespace Kt1
{
    partial class Form3
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
            dgv_Diem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Diem).BeginInit();
            SuspendLayout();
            // 
            // dgv_Diem
            // 
            dgv_Diem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Diem.Location = new Point(37, 27);
            dgv_Diem.Name = "dgv_Diem";
            dgv_Diem.RowTemplate.Height = 25;
            dgv_Diem.Size = new Size(723, 284);
            dgv_Diem.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Diem);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Diem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Diem;
    }
}