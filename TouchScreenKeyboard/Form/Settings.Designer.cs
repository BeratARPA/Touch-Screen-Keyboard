namespace TouchScreenKeyboard
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_boyutlandırma = new System.Windows.Forms.CheckBox();
            this.tbar_seffaflık = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_konumlandırma = new System.Windows.Forms.Button();
            this.lBox_renkler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_surukleme = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_seffaflık)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şeffaflık:";
            // 
            // cBox_boyutlandırma
            // 
            this.cBox_boyutlandırma.AutoSize = true;
            this.cBox_boyutlandırma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_boyutlandırma.Location = new System.Drawing.Point(13, 106);
            this.cBox_boyutlandırma.Name = "cBox_boyutlandırma";
            this.cBox_boyutlandırma.Size = new System.Drawing.Size(117, 21);
            this.cBox_boyutlandırma.TabIndex = 1;
            this.cBox_boyutlandırma.Text = "Boyutlandırma";
            this.cBox_boyutlandırma.UseVisualStyleBackColor = true;
            this.cBox_boyutlandırma.Visible = false;
            this.cBox_boyutlandırma.CheckedChanged += new System.EventHandler(this.cBox_boyutlandırma_CheckedChanged);
            // 
            // tbar_seffaflık
            // 
            this.tbar_seffaflık.Location = new System.Drawing.Point(93, 23);
            this.tbar_seffaflık.Maximum = 100;
            this.tbar_seffaflık.Name = "tbar_seffaflık";
            this.tbar_seffaflık.Size = new System.Drawing.Size(277, 45);
            this.tbar_seffaflık.TabIndex = 2;
            this.tbar_seffaflık.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbar_seffaflık.Value = 100;
            this.tbar_seffaflık.ValueChanged += new System.EventHandler(this.tbar_seffaflık_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_konumlandırma);
            this.groupBox1.Controls.Add(this.lBox_renkler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBox_surukleme);
            this.groupBox1.Controls.Add(this.cBox_boyutlandırma);
            this.groupBox1.Controls.Add(this.tbar_seffaflık);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(450, 337);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_konumlandırma
            // 
            this.btn_konumlandırma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_konumlandırma.Location = new System.Drawing.Point(13, 294);
            this.btn_konumlandırma.Name = "btn_konumlandırma";
            this.btn_konumlandırma.Size = new System.Drawing.Size(424, 30);
            this.btn_konumlandırma.TabIndex = 4;
            this.btn_konumlandırma.Text = "Konumlandır";
            this.btn_konumlandırma.UseVisualStyleBackColor = true;
            this.btn_konumlandırma.Click += new System.EventHandler(this.btn_konumlandırma_Click);
            // 
            // lBox_renkler
            // 
            this.lBox_renkler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBox_renkler.FormattingEnabled = true;
            this.lBox_renkler.ItemHeight = 16;
            this.lBox_renkler.Items.AddRange(new object[] {
            "White",
            "Black",
            "Dark",
            "Light",
            "Silver",
            "Grey",
            "Android",
            "Mac"});
            this.lBox_renkler.Location = new System.Drawing.Point(13, 188);
            this.lBox_renkler.Name = "lBox_renkler";
            this.lBox_renkler.Size = new System.Drawing.Size(424, 100);
            this.lBox_renkler.TabIndex = 3;
            this.lBox_renkler.SelectedIndexChanged += new System.EventHandler(this.lBox_renkler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Renkler:";
            // 
            // cBox_surukleme
            // 
            this.cBox_surukleme.AutoSize = true;
            this.cBox_surukleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_surukleme.Location = new System.Drawing.Point(13, 79);
            this.cBox_surukleme.Name = "cBox_surukleme";
            this.cBox_surukleme.Size = new System.Drawing.Size(94, 21);
            this.cBox_surukleme.TabIndex = 1;
            this.cBox_surukleme.Text = "Sürükleme";
            this.cBox_surukleme.UseVisualStyleBackColor = true;
            this.cBox_surukleme.CheckedChanged += new System.EventHandler(this.cBox_surukleme_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 361);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_seffaflık)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBox_boyutlandırma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbar_seffaflık;
        private System.Windows.Forms.Button btn_konumlandırma;
        private System.Windows.Forms.ListBox lBox_renkler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBox_surukleme;
    }
}