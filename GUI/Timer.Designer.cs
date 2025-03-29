namespace StopWatchC_
{
    partial class Timer_form
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
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAturWaktu = new System.Windows.Forms.Button();
            this.titikDua3 = new System.Windows.Forms.Label();
            this.titikDua2 = new System.Windows.Forms.Label();
            this.labelTimerJam = new System.Windows.Forms.Label();
            this.labelTimerMenit = new System.Windows.Forms.Label();
            this.btnMulai = new System.Windows.Forms.Button();
            this.labelTimerDetik = new System.Windows.Forms.Label();
            this.jamCount = new System.Windows.Forms.NumericUpDown();
            this.menitCount = new System.Windows.Forms.NumericUpDown();
            this.detikCount = new System.Windows.Forms.NumericUpDown();
            this.jamCountLabel = new System.Windows.Forms.Label();
            this.menitCountLabel = new System.Windows.Forms.Label();
            this.detikCountLabel = new System.Windows.Forms.Label();
            this.aturWaktuGroup = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.jamCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detikCount)).BeginInit();
            this.aturWaktuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(534, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 54);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAturWaktu
            // 
            this.btnAturWaktu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAturWaktu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAturWaktu.FlatAppearance.BorderSize = 0;
            this.btnAturWaktu.ForeColor = System.Drawing.Color.Black;
            this.btnAturWaktu.Location = new System.Drawing.Point(124, 285);
            this.btnAturWaktu.Name = "btnAturWaktu";
            this.btnAturWaktu.Size = new System.Drawing.Size(133, 54);
            this.btnAturWaktu.TabIndex = 14;
            this.btnAturWaktu.Text = "Atur Waktu";
            this.btnAturWaktu.UseVisualStyleBackColor = false;
            this.btnAturWaktu.Click += new System.EventHandler(this.btnAturWaktu_Click);
            // 
            // titikDua3
            // 
            this.titikDua3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titikDua3.AutoSize = true;
            this.titikDua3.BackColor = System.Drawing.Color.Transparent;
            this.titikDua3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titikDua3.ForeColor = System.Drawing.Color.White;
            this.titikDua3.Location = new System.Drawing.Point(250, 126);
            this.titikDua3.Name = "titikDua3";
            this.titikDua3.Size = new System.Drawing.Size(80, 116);
            this.titikDua3.TabIndex = 13;
            this.titikDua3.Text = ":";
            this.titikDua3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titikDua2
            // 
            this.titikDua2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titikDua2.AutoSize = true;
            this.titikDua2.BackColor = System.Drawing.Color.Transparent;
            this.titikDua2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titikDua2.ForeColor = System.Drawing.Color.White;
            this.titikDua2.Location = new System.Drawing.Point(456, 126);
            this.titikDua2.Name = "titikDua2";
            this.titikDua2.Size = new System.Drawing.Size(80, 116);
            this.titikDua2.TabIndex = 12;
            this.titikDua2.Text = ":";
            this.titikDua2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimerJam
            // 
            this.labelTimerJam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimerJam.AutoSize = true;
            this.labelTimerJam.BackColor = System.Drawing.Color.Transparent;
            this.labelTimerJam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerJam.ForeColor = System.Drawing.Color.White;
            this.labelTimerJam.Location = new System.Drawing.Point(114, 126);
            this.labelTimerJam.Name = "labelTimerJam";
            this.labelTimerJam.Size = new System.Drawing.Size(167, 116);
            this.labelTimerJam.TabIndex = 11;
            this.labelTimerJam.Text = "00";
            // 
            // labelTimerMenit
            // 
            this.labelTimerMenit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimerMenit.AutoSize = true;
            this.labelTimerMenit.BackColor = System.Drawing.Color.Transparent;
            this.labelTimerMenit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerMenit.ForeColor = System.Drawing.Color.White;
            this.labelTimerMenit.Location = new System.Drawing.Point(312, 126);
            this.labelTimerMenit.Name = "labelTimerMenit";
            this.labelTimerMenit.Size = new System.Drawing.Size(167, 116);
            this.labelTimerMenit.TabIndex = 10;
            this.labelTimerMenit.Text = "00";
            // 
            // btnMulai
            // 
            this.btnMulai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMulai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMulai.FlatAppearance.BorderSize = 0;
            this.btnMulai.ForeColor = System.Drawing.Color.Black;
            this.btnMulai.Location = new System.Drawing.Point(332, 285);
            this.btnMulai.Name = "btnMulai";
            this.btnMulai.Size = new System.Drawing.Size(133, 54);
            this.btnMulai.TabIndex = 9;
            this.btnMulai.Text = "Mulai";
            this.btnMulai.UseVisualStyleBackColor = false;
            this.btnMulai.Click += new System.EventHandler(this.btnMulai_Click);
            // 
            // labelTimerDetik
            // 
            this.labelTimerDetik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimerDetik.AutoSize = true;
            this.labelTimerDetik.BackColor = System.Drawing.Color.Transparent;
            this.labelTimerDetik.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerDetik.ForeColor = System.Drawing.Color.White;
            this.labelTimerDetik.Location = new System.Drawing.Point(520, 126);
            this.labelTimerDetik.Name = "labelTimerDetik";
            this.labelTimerDetik.Size = new System.Drawing.Size(167, 116);
            this.labelTimerDetik.TabIndex = 8;
            this.labelTimerDetik.Text = "00";
            // 
            // jamCount
            // 
            this.jamCount.AccessibleName = "";
            this.jamCount.Location = new System.Drawing.Point(94, 7);
            this.jamCount.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.jamCount.Name = "jamCount";
            this.jamCount.Size = new System.Drawing.Size(71, 26);
            this.jamCount.TabIndex = 16;
            // 
            // menitCount
            // 
            this.menitCount.AccessibleName = "";
            this.menitCount.Location = new System.Drawing.Point(94, 39);
            this.menitCount.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.menitCount.Name = "menitCount";
            this.menitCount.Size = new System.Drawing.Size(71, 26);
            this.menitCount.TabIndex = 17;
            // 
            // detikCount
            // 
            this.detikCount.AccessibleName = "";
            this.detikCount.Location = new System.Drawing.Point(94, 71);
            this.detikCount.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.detikCount.Name = "detikCount";
            this.detikCount.Size = new System.Drawing.Size(71, 26);
            this.detikCount.TabIndex = 18;
            // 
            // jamCountLabel
            // 
            this.jamCountLabel.AccessibleName = "";
            this.jamCountLabel.AutoSize = true;
            this.jamCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.jamCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.jamCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jamCountLabel.Location = new System.Drawing.Point(38, 7);
            this.jamCountLabel.Name = "jamCountLabel";
            this.jamCountLabel.Size = new System.Drawing.Size(46, 22);
            this.jamCountLabel.TabIndex = 19;
            this.jamCountLabel.Text = "Jam";
            // 
            // menitCountLabel
            // 
            this.menitCountLabel.AccessibleName = "";
            this.menitCountLabel.AutoSize = true;
            this.menitCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.menitCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.menitCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menitCountLabel.Location = new System.Drawing.Point(26, 39);
            this.menitCountLabel.Name = "menitCountLabel";
            this.menitCountLabel.Size = new System.Drawing.Size(58, 22);
            this.menitCountLabel.TabIndex = 20;
            this.menitCountLabel.Text = "Menit";
            // 
            // detikCountLabel
            // 
            this.detikCountLabel.AccessibleName = "";
            this.detikCountLabel.AutoSize = true;
            this.detikCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.detikCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.detikCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detikCountLabel.Location = new System.Drawing.Point(30, 71);
            this.detikCountLabel.Name = "detikCountLabel";
            this.detikCountLabel.Size = new System.Drawing.Size(56, 22);
            this.detikCountLabel.TabIndex = 21;
            this.detikCountLabel.Text = "Detik";
            // 
            // aturWaktuGroup
            // 
            this.aturWaktuGroup.Controls.Add(this.menitCountLabel);
            this.aturWaktuGroup.Controls.Add(this.detikCount);
            this.aturWaktuGroup.Controls.Add(this.detikCountLabel);
            this.aturWaktuGroup.Controls.Add(this.jamCountLabel);
            this.aturWaktuGroup.Controls.Add(this.jamCount);
            this.aturWaktuGroup.Controls.Add(this.menitCount);
            this.aturWaktuGroup.Location = new System.Drawing.Point(94, 345);
            this.aturWaktuGroup.Name = "aturWaktuGroup";
            this.aturWaktuGroup.Size = new System.Drawing.Size(200, 100);
            this.aturWaktuGroup.TabIndex = 23;
            this.aturWaktuGroup.Visible = false;
            // 
            // Timer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.aturWaktuGroup);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAturWaktu);
            this.Controls.Add(this.titikDua3);
            this.Controls.Add(this.titikDua2);
            this.Controls.Add(this.labelTimerJam);
            this.Controls.Add(this.labelTimerMenit);
            this.Controls.Add(this.btnMulai);
            this.Controls.Add(this.labelTimerDetik);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Timer_form";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.jamCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detikCount)).EndInit();
            this.aturWaktuGroup.ResumeLayout(false);
            this.aturWaktuGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAturWaktu;
        private System.Windows.Forms.Label titikDua3;
        private System.Windows.Forms.Label titikDua2;
        private System.Windows.Forms.Label labelTimerJam;
        private System.Windows.Forms.Label labelTimerMenit;
        private System.Windows.Forms.Button btnMulai;
        private System.Windows.Forms.Label labelTimerDetik;
        private System.Windows.Forms.NumericUpDown jamCount;
        private System.Windows.Forms.NumericUpDown menitCount;
        private System.Windows.Forms.NumericUpDown detikCount;
        private System.Windows.Forms.Label jamCountLabel;
        private System.Windows.Forms.Label menitCountLabel;
        private System.Windows.Forms.Label detikCountLabel;
        private System.Windows.Forms.Panel aturWaktuGroup;
    }
}