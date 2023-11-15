namespace PROYECTO_FINAL
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_subir_ejer = new System.Windows.Forms.Button();
            this.btn_subir_vid = new System.Windows.Forms.Button();
            this.btn_ejer = new System.Windows.Forms.Button();
            this.btn_videos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // btn_mod
            // 
            this.btn_mod.Image = global::PROYECTO_FINAL.Properties.Resources.modificar;
            this.btn_mod.Location = new System.Drawing.Point(399, 418);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(228, 141);
            this.btn_mod.TabIndex = 7;
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_subir_ejer
            // 
            this.btn_subir_ejer.Image = global::PROYECTO_FINAL.Properties.Resources.subir_ejer;
            this.btn_subir_ejer.Location = new System.Drawing.Point(698, 252);
            this.btn_subir_ejer.Name = "btn_subir_ejer";
            this.btn_subir_ejer.Size = new System.Drawing.Size(228, 141);
            this.btn_subir_ejer.TabIndex = 6;
            this.btn_subir_ejer.UseVisualStyleBackColor = true;
            this.btn_subir_ejer.Click += new System.EventHandler(this.btn_subir_ejer_Click);
            // 
            // btn_subir_vid
            // 
            this.btn_subir_vid.Image = global::PROYECTO_FINAL.Properties.Resources.subir;
            this.btn_subir_vid.Location = new System.Drawing.Point(399, 252);
            this.btn_subir_vid.Name = "btn_subir_vid";
            this.btn_subir_vid.Size = new System.Drawing.Size(228, 141);
            this.btn_subir_vid.TabIndex = 5;
            this.btn_subir_vid.UseVisualStyleBackColor = true;
            this.btn_subir_vid.Click += new System.EventHandler(this.btn_subir_vid_Click);
            // 
            // btn_ejer
            // 
            this.btn_ejer.Image = global::PROYECTO_FINAL.Properties.Resources.ejercicios;
            this.btn_ejer.Location = new System.Drawing.Point(96, 418);
            this.btn_ejer.Name = "btn_ejer";
            this.btn_ejer.Size = new System.Drawing.Size(228, 141);
            this.btn_ejer.TabIndex = 4;
            this.btn_ejer.UseVisualStyleBackColor = true;
            this.btn_ejer.Click += new System.EventHandler(this.btn_ejer_Click);
            // 
            // btn_videos
            // 
            this.btn_videos.Image = global::PROYECTO_FINAL.Properties.Resources.videos;
            this.btn_videos.Location = new System.Drawing.Point(96, 252);
            this.btn_videos.Name = "btn_videos";
            this.btn_videos.Size = new System.Drawing.Size(228, 141);
            this.btn_videos.TabIndex = 3;
            this.btn_videos.UseVisualStyleBackColor = true;
            this.btn_videos.Click += new System.EventHandler(this.btn_videos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = global::PROYECTO_FINAL.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(431, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 632);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_subir_ejer);
            this.Controls.Add(this.btn_subir_vid);
            this.Controls.Add(this.btn_ejer);
            this.Controls.Add(this.btn_videos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_videos;
        private System.Windows.Forms.Button btn_ejer;
        private System.Windows.Forms.Button btn_subir_vid;
        private System.Windows.Forms.Button btn_subir_ejer;
        private System.Windows.Forms.Button btn_mod;
    }
}