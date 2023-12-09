namespace Application
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lb_TenDn = new Label();
            txt_TenDn = new TextBox();
            lb_Mk = new Label();
            txt_Mk = new TextBox();
            lb_XnMk = new Label();
            txt_XnMk = new TextBox();
            btn_Dk = new Button();
            btn_Dn = new Button();
            lb_ThongBao = new Label();
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
            // lb_TenDn
            // 
            resources.ApplyResources(lb_TenDn, "lb_TenDn");
            lb_TenDn.BackColor = Color.Transparent;
            lb_TenDn.Name = "lb_TenDn";
            // 
            // txt_TenDn
            // 
            resources.ApplyResources(txt_TenDn, "txt_TenDn");
            txt_TenDn.Name = "txt_TenDn";
            // 
            // lb_Mk
            // 
            resources.ApplyResources(lb_Mk, "lb_Mk");
            lb_Mk.BackColor = Color.Transparent;
            lb_Mk.Name = "lb_Mk";
            // 
            // txt_Mk
            // 
            resources.ApplyResources(txt_Mk, "txt_Mk");
            txt_Mk.Name = "txt_Mk";
            // 
            // lb_XnMk
            // 
            resources.ApplyResources(lb_XnMk, "lb_XnMk");
            lb_XnMk.BackColor = Color.Transparent;
            lb_XnMk.Name = "lb_XnMk";
            // 
            // txt_XnMk
            // 
            resources.ApplyResources(txt_XnMk, "txt_XnMk");
            txt_XnMk.Name = "txt_XnMk";
            // 
            // btn_Dk
            // 
            resources.ApplyResources(btn_Dk, "btn_Dk");
            btn_Dk.Name = "btn_Dk";
            btn_Dk.UseVisualStyleBackColor = true;
            btn_Dk.Click += btn_Dk_Click;
            // 
            // btn_Dn
            // 
            resources.ApplyResources(btn_Dn, "btn_Dn");
            btn_Dn.Name = "btn_Dn";
            btn_Dn.UseVisualStyleBackColor = true;
            btn_Dn.Click += btn_Dn_Click;
            // 
            // lb_ThongBao
            // 
            resources.ApplyResources(lb_ThongBao, "lb_ThongBao");
            lb_ThongBao.BackColor = Color.White;
            lb_ThongBao.Name = "lb_ThongBao";
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner7;
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
            banner1ToolStripMenuItem.Click += banner1ToolStripMenuItem_Click;
            // 
            // banner2ToolStripMenuItem
            // 
            banner2ToolStripMenuItem.Name = "banner2ToolStripMenuItem";
            resources.ApplyResources(banner2ToolStripMenuItem, "banner2ToolStripMenuItem");
            banner2ToolStripMenuItem.Click += banner2ToolStripMenuItem_Click;
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
            // Register
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner7;
            Controls.Add(menuStrip1);
            Controls.Add(lb_ThongBao);
            Controls.Add(btn_Dn);
            Controls.Add(btn_Dk);
            Controls.Add(txt_XnMk);
            Controls.Add(lb_XnMk);
            Controls.Add(txt_Mk);
            Controls.Add(lb_Mk);
            Controls.Add(txt_TenDn);
            Controls.Add(lb_TenDn);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Register";
            ShowIcon = false;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_TenDn;
        private TextBox txt_TenDn;
        private Label lb_Mk;
        private TextBox txt_Mk;
        private Label lb_XnMk;
        private TextBox txt_XnMk;
        private Button btn_Dk;
        private Button btn_Dn;
        private Label lb_ThongBao;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem changerBackgroundToolStripMenuItem;
        private ToolStripMenuItem banner1ToolStripMenuItem;
        private ToolStripMenuItem banner2ToolStripMenuItem;
        private ToolStripMenuItem banner3ToolStripMenuItem;
        private ToolStripMenuItem banner4ToolStripMenuItem;
    }
}