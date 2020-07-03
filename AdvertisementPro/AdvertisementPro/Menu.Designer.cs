namespace AdvertisementPro
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
            this.buttonOrganisation = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonNewspaper = new System.Windows.Forms.Button();
            this.buttonAdvertisement = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOrganisation
            // 
            this.buttonOrganisation.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrganisation.Location = new System.Drawing.Point(136, 88);
            this.buttonOrganisation.Name = "buttonOrganisation";
            this.buttonOrganisation.Size = new System.Drawing.Size(162, 39);
            this.buttonOrganisation.TabIndex = 0;
            this.buttonOrganisation.Text = "Организации";
            this.buttonOrganisation.UseVisualStyleBackColor = true;
            this.buttonOrganisation.Click += new System.EventHandler(this.buttonOrganisation_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(173, 23);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(76, 29);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Меню";
            // 
            // buttonNewspaper
            // 
            this.buttonNewspaper.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.buttonNewspaper.Location = new System.Drawing.Point(136, 149);
            this.buttonNewspaper.Name = "buttonNewspaper";
            this.buttonNewspaper.Size = new System.Drawing.Size(162, 39);
            this.buttonNewspaper.TabIndex = 2;
            this.buttonNewspaper.Text = "Газеты";
            this.buttonNewspaper.UseVisualStyleBackColor = true;
            this.buttonNewspaper.Click += new System.EventHandler(this.buttonNewspaper_Click);
            // 
            // buttonAdvertisement
            // 
            this.buttonAdvertisement.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.buttonAdvertisement.Location = new System.Drawing.Point(136, 216);
            this.buttonAdvertisement.Name = "buttonAdvertisement";
            this.buttonAdvertisement.Size = new System.Drawing.Size(162, 39);
            this.buttonAdvertisement.TabIndex = 3;
            this.buttonAdvertisement.Text = "Реклама";
            this.buttonAdvertisement.UseVisualStyleBackColor = true;
            this.buttonAdvertisement.Click += new System.EventHandler(this.buttonAdvertisement_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdvertisementPro.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdvertisement);
            this.Controls.Add(this.buttonNewspaper);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonOrganisation);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrganisation;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonNewspaper;
        private System.Windows.Forms.Button buttonAdvertisement;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}