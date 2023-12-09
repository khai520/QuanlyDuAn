namespace Application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lb_MK = new Label();
            txt_TenDn = new TextBox();
            btn_DN = new Button();
            lb_TenDN = new Label();
            btn_DK = new Button();
            txt_Mk = new TextBox();
            lb_TB = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            changerBackgroundToolStripMenuItem = new ToolStripMenuItem();
            banner1ToolStripMenuItem = new ToolStripMenuItem();
            banner2ToolStripMenuItem = new ToolStripMenuItem();
            banner3ToolStripMenuItem = new ToolStripMenuItem();
            banner4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_MK
            // 
            resources.ApplyResources(lb_MK, "lb_MK");
            lb_MK.BackColor = Color.Transparent;
            lb_MK.Name = "lb_MK";
            // 
            // txt_TenDn
            // 
            resources.ApplyResources(txt_TenDn, "txt_TenDn");
            txt_TenDn.Name = "txt_TenDn";
            // 
            // btn_DN
            // 
            resources.ApplyResources(btn_DN, "btn_DN");
            btn_DN.Name = "btn_DN";
            btn_DN.UseVisualStyleBackColor = true;
            btn_DN.Click += btn_DN_Click;
            // 
            // lb_TenDN
            // 
            resources.ApplyResources(lb_TenDN, "lb_TenDN");
            lb_TenDN.BackColor = Color.Transparent;
            lb_TenDN.ForeColor = Color.Black;
            lb_TenDN.Name = "lb_TenDN";
            // 
            // btn_DK
            // 
            btn_DK.BackColor = Color.White;
            resources.ApplyResources(btn_DK, "btn_DK");
            btn_DK.Name = "btn_DK";
            btn_DK.UseVisualStyleBackColor = false;
            btn_DK.Click += btn_DK_Click;
            // 
            // txt_Mk
            // 
            resources.ApplyResources(txt_Mk, "txt_Mk");
            txt_Mk.Name = "txt_Mk";
            // 
            // lb_TB
            // 
            lb_TB.BackColor = Color.Transparent;
            resources.ApplyResources(lb_TB, "lb_TB");
            lb_TB.ForeColor = Color.Black;
            lb_TB.Name = "lb_TB";
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner5;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changerBackgroundToolStripMenuItem });
            resources.ApplyResources(menuToolStripMenuItem, "menuToolStripMenuItem");
            menuToolStripMenuItem.ForeColor = Color.Black;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // changerBackgroundToolStripMenuItem
            // 
            changerBackgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { banner1ToolStripMenuItem, banner2ToolStripMenuItem, banner3ToolStripMenuItem, banner4ToolStripMenuItem });
            changerBackgroundToolStripMenuItem.Name = "changerBackgroundToolStripMenuItem";
            resources.ApplyResources(changerBackgroundToolStripMenuItem, "changerBackgroundToolStripMenuItem");
            // 
            // banner1ToolStripMenuItem
            // 
            banner1ToolStripMenuItem.Name = "banner1ToolStripMenuItem";
            resources.ApplyResources(banner1ToolStripMenuItem, "banner1ToolStripMenuItem");
            banner1ToolStripMenuItem.Click += banner1ToolStripMenuItem_Click_1;
            // 
            // banner2ToolStripMenuItem
            // 
            banner2ToolStripMenuItem.Name = "banner2ToolStripMenuItem";
            resources.ApplyResources(banner2ToolStripMenuItem, "banner2ToolStripMenuItem");
            banner2ToolStripMenuItem.Click += banner2ToolStripMenuItem_Click_1;
            // 
            // banner3ToolStripMenuItem
            // 
            banner3ToolStripMenuItem.Name = "banner3ToolStripMenuItem";
            resources.ApplyResources(banner3ToolStripMenuItem, "banner3ToolStripMenuItem");
            banner3ToolStripMenuItem.Click += banner3ToolStripMenuItem_Click;
            // 
            // banner4ToolStripMenuItem
            // 
            banner4ToolStripMenuItem.Name = "banner4ToolStripMenuItem";
            resources.ApplyResources(banner4ToolStripMenuItem, "banner4ToolStripMenuItem");
            banner4ToolStripMenuItem.Click += banner4ToolStripMenuItem_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner5;
            Controls.Add(menuStrip1);
            Controls.Add(lb_TB);
            Controls.Add(txt_Mk);
            Controls.Add(lb_MK);
            Controls.Add(txt_TenDn);
            Controls.Add(btn_DN);
            Controls.Add(lb_TenDN);
            Controls.Add(btn_DK);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Login";
            ShowIcon = false;
            Load += Login_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_MK;
        private TextBox txt_TenDn;
        private Button btn_DN;
        private Label lb_TenDN;
        private Button btn_DK;
        private TextBox txt_Mk;
        private Label lb_TB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem changerBackgroundToolStripMenuItem;
        private ToolStripMenuItem banner1ToolStripMenuItem;
        private ToolStripMenuItem banner2ToolStripMenuItem;
        private ToolStripMenuItem banner3ToolStripMenuItem;
        private ToolStripMenuItem banner4ToolStripMenuItem;
    }
}