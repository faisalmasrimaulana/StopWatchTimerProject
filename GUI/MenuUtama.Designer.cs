namespace StopWatchTimerProject
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_pilihan = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_stopwatch = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_timer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_pilihan});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(948, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_pilihan
            // 
            this.menu_pilihan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_stopwatch,
            this.subMenu_timer});
            this.menu_pilihan.Name = "menu_pilihan";
            this.menu_pilihan.Size = new System.Drawing.Size(110, 29);
            this.menu_pilihan.Text = "&Pilih Menu";
            // 
            // subMenu_stopwatch
            // 
            this.subMenu_stopwatch.Name = "subMenu_stopwatch";
            this.subMenu_stopwatch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.subMenu_stopwatch.Size = new System.Drawing.Size(253, 34);
            this.subMenu_stopwatch.Text = "&Stopwatch";
            this.subMenu_stopwatch.Click += new System.EventHandler(this.subMenu_stopwatch_Click);
            // 
            // subMenu_timer
            // 
            this.subMenu_timer.Name = "subMenu_timer";
            this.subMenu_timer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.subMenu_timer.Size = new System.Drawing.Size(253, 34);
            this.subMenu_timer.Text = "&Timer";
            this.subMenu_timer.Click += new System.EventHandler(this.subMenu_timer_Click);
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem menu_pilihan;
        private System.Windows.Forms.ToolStripMenuItem subMenu_stopwatch;
        public System.Windows.Forms.ToolStripMenuItem subMenu_timer;
    }
}



