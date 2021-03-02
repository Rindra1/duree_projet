namespace duree_projet
{
    partial class Form1
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
            this.chk_samedi = new System.Windows.Forms.CheckBox();
            this.chk_dimanche = new System.Windows.Forms.CheckBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.bt_fichier = new System.Windows.Forms.Button();
            this.bt_calculer = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week-end";
            // 
            // chk_samedi
            // 
            this.chk_samedi.AutoSize = true;
            this.chk_samedi.Location = new System.Drawing.Point(12, 40);
            this.chk_samedi.Name = "chk_samedi";
            this.chk_samedi.Size = new System.Drawing.Size(61, 17);
            this.chk_samedi.TabIndex = 1;
            this.chk_samedi.Text = "Samedi";
            this.chk_samedi.UseVisualStyleBackColor = true;
            // 
            // chk_dimanche
            // 
            this.chk_dimanche.AutoSize = true;
            this.chk_dimanche.Location = new System.Drawing.Point(12, 64);
            this.chk_dimanche.Name = "chk_dimanche";
            this.chk_dimanche.Size = new System.Drawing.Size(74, 17);
            this.chk_dimanche.TabIndex = 2;
            this.chk_dimanche.Text = "Dimanche";
            this.chk_dimanche.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(12, 99);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 20);
            this.txt_date.TabIndex = 3;
            // 
            // bt_fichier
            // 
            this.bt_fichier.Location = new System.Drawing.Point(12, 135);
            this.bt_fichier.Name = "bt_fichier";
            this.bt_fichier.Size = new System.Drawing.Size(156, 23);
            this.bt_fichier.TabIndex = 4;
            this.bt_fichier.Text = "Ouvrir Fichier";
            this.bt_fichier.UseVisualStyleBackColor = true;
            this.bt_fichier.Click += new System.EventHandler(this.bt_fichier_Click);
            // 
            // bt_calculer
            // 
            this.bt_calculer.Location = new System.Drawing.Point(12, 175);
            this.bt_calculer.Name = "bt_calculer";
            this.bt_calculer.Size = new System.Drawing.Size(156, 23);
            this.bt_calculer.TabIndex = 5;
            this.bt_calculer.Text = "Calculer";
            this.bt_calculer.UseVisualStyleBackColor = true;
            this.bt_calculer.Click += new System.EventHandler(this.bt_calculer_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(12, 215);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(156, 23);
            this.bt_quitter.TabIndex = 6;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 605);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1133, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_calculer);
            this.Controls.Add(this.bt_fichier);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.chk_dimanche);
            this.Controls.Add(this.chk_samedi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_samedi;
        private System.Windows.Forms.CheckBox chk_dimanche;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Button bt_fichier;
        private System.Windows.Forms.Button bt_calculer;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

