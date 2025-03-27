namespace StopWatchC_
{
    partial class StopWatch_form
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
            this.components = new System.ComponentModel.Container();
            this.btnMulai = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.labelStopWatchJam = new System.Windows.Forms.Label();
            this.labelStopWatchDetik = new System.Windows.Forms.Label();
            this.labelStopWatchMenit = new System.Windows.Forms.Label();
            this.titikDua2 = new System.Windows.Forms.Label();
            this.titikDua3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxStopWatch = new System.Windows.Forms.ListBox();
            this.btnResetSave = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // btnMulai
            // 
            this.btnMulai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMulai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMulai.FlatAppearance.BorderSize = 0;
            this.btnMulai.ForeColor = System.Drawing.Color.Black;
            this.btnMulai.Location = new System.Drawing.Point(346, 189);
            this.btnMulai.Name = "btnMulai";
            this.btnMulai.Size = new System.Drawing.Size(133, 54);
            this.btnMulai.TabIndex = 1;
            this.btnMulai.Text = "Mulai";
            this.btnMulai.UseVisualStyleBackColor = false;
            this.btnMulai.Click += new System.EventHandler(this.btnMulai_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // labelStopWatchJam
            // 
            this.labelStopWatchJam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStopWatchJam.AutoSize = true;
            this.labelStopWatchJam.BackColor = System.Drawing.Color.Transparent;
            this.labelStopWatchJam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatchJam.Location = new System.Drawing.Point(128, 30);
            this.labelStopWatchJam.Name = "labelStopWatchJam";
            this.labelStopWatchJam.Size = new System.Drawing.Size(167, 116);
            this.labelStopWatchJam.TabIndex = 3;
            this.labelStopWatchJam.Text = "00";
            // 
            // labelStopWatchDetik
            // 
            this.labelStopWatchDetik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStopWatchDetik.AutoSize = true;
            this.labelStopWatchDetik.BackColor = System.Drawing.Color.Transparent;
            this.labelStopWatchDetik.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatchDetik.Location = new System.Drawing.Point(534, 30);
            this.labelStopWatchDetik.Name = "labelStopWatchDetik";
            this.labelStopWatchDetik.Size = new System.Drawing.Size(167, 116);
            this.labelStopWatchDetik.TabIndex = 0;
            this.labelStopWatchDetik.Text = "00";
            // 
            // labelStopWatchMenit
            // 
            this.labelStopWatchMenit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStopWatchMenit.AutoSize = true;
            this.labelStopWatchMenit.BackColor = System.Drawing.Color.Transparent;
            this.labelStopWatchMenit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatchMenit.Location = new System.Drawing.Point(326, 30);
            this.labelStopWatchMenit.Name = "labelStopWatchMenit";
            this.labelStopWatchMenit.Size = new System.Drawing.Size(167, 116);
            this.labelStopWatchMenit.TabIndex = 2;
            this.labelStopWatchMenit.Text = "00";
            // 
            // titikDua2
            // 
            this.titikDua2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titikDua2.AutoSize = true;
            this.titikDua2.BackColor = System.Drawing.Color.Transparent;
            this.titikDua2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titikDua2.Location = new System.Drawing.Point(470, 30);
            this.titikDua2.Name = "titikDua2";
            this.titikDua2.Size = new System.Drawing.Size(80, 116);
            this.titikDua2.TabIndex = 4;
            this.titikDua2.Text = ":";
            this.titikDua2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titikDua3
            // 
            this.titikDua3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titikDua3.AutoSize = true;
            this.titikDua3.BackColor = System.Drawing.Color.Transparent;
            this.titikDua3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titikDua3.Location = new System.Drawing.Point(264, 30);
            this.titikDua3.Name = "titikDua3";
            this.titikDua3.Size = new System.Drawing.Size(80, 116);
            this.titikDua3.TabIndex = 5;
            this.titikDua3.Text = ":";
            this.titikDua3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(138, 189);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 54);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(548, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 54);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Rekam";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxStopWatch
            // 
            this.listBoxStopWatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxStopWatch.BackColor = System.Drawing.Color.Black;
            this.listBoxStopWatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStopWatch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStopWatch.ForeColor = System.Drawing.Color.White;
            this.listBoxStopWatch.FormattingEnabled = true;
            this.listBoxStopWatch.ItemHeight = 34;
            this.listBoxStopWatch.Location = new System.Drawing.Point(346, 258);
            this.listBoxStopWatch.Name = "listBoxStopWatch";
            this.listBoxStopWatch.Size = new System.Drawing.Size(214, 136);
            this.listBoxStopWatch.TabIndex = 8;
            // 
            // btnResetSave
            // 
            this.btnResetSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetSave.FlatAppearance.BorderSize = 0;
            this.btnResetSave.ForeColor = System.Drawing.Color.Black;
            this.btnResetSave.Location = new System.Drawing.Point(363, 377);
            this.btnResetSave.Name = "btnResetSave";
            this.btnResetSave.Size = new System.Drawing.Size(103, 35);
            this.btnResetSave.TabIndex = 9;
            this.btnResetSave.Text = "Reset";
            this.btnResetSave.UseVisualStyleBackColor = false;
            this.btnResetSave.Click += new System.EventHandler(this.btnResetSave_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // StopWatch_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetSave);
            this.Controls.Add(this.listBoxStopWatch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.titikDua3);
            this.Controls.Add(this.titikDua2);
            this.Controls.Add(this.labelStopWatchJam);
            this.Controls.Add(this.labelStopWatchMenit);
            this.Controls.Add(this.btnMulai);
            this.Controls.Add(this.labelStopWatchDetik);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StopWatch_form";
            this.Text = "Stop Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMulai;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Label labelStopWatchJam;
        private System.Windows.Forms.Label labelStopWatchDetik;
        private System.Windows.Forms.Label labelStopWatchMenit;
        private System.Windows.Forms.Label titikDua2;
        private System.Windows.Forms.Label titikDua3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxStopWatch;
        private System.Windows.Forms.Button btnResetSave;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
    }
}

