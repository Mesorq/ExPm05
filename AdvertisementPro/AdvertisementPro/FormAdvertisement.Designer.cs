namespace AdvertisementPro
{
    partial class FormAdvertisement
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
            this.listViewAdvertisement = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxAdvertisementSize = new System.Windows.Forms.TextBox();
            this.labelAdvertisementSize = new System.Windows.Forms.Label();
            this.textBoxNewspaperNumber = new System.Windows.Forms.TextBox();
            this.labelNewapaperNumber = new System.Windows.Forms.Label();
            this.comboBoxOrganisation = new System.Windows.Forms.ComboBox();
            this.comboBoxNewspaper = new System.Windows.Forms.ComboBox();
            this.labelNewspaper = new System.Windows.Forms.Label();
            this.labelOrganisation = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewAdvertisement
            // 
            this.listViewAdvertisement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAdvertisement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAdvertisement.FullRowSelect = true;
            this.listViewAdvertisement.GridLines = true;
            this.listViewAdvertisement.HideSelection = false;
            this.listViewAdvertisement.Location = new System.Drawing.Point(296, 56);
            this.listViewAdvertisement.MultiSelect = false;
            this.listViewAdvertisement.Name = "listViewAdvertisement";
            this.listViewAdvertisement.Size = new System.Drawing.Size(610, 261);
            this.listViewAdvertisement.TabIndex = 35;
            this.listViewAdvertisement.UseCompatibleStateImageBehavior = false;
            this.listViewAdvertisement.View = System.Windows.Forms.View.Details;
            this.listViewAdvertisement.SelectedIndexChanged += new System.EventHandler(this.listViewNewsPaper_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(467, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 48);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(634, 337);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 48);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(794, 337);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(112, 48);
            this.buttonDel.TabIndex = 31;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxAdvertisementSize
            // 
            this.textBoxAdvertisementSize.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBoxAdvertisementSize.Location = new System.Drawing.Point(52, 232);
            this.textBoxAdvertisementSize.Name = "textBoxAdvertisementSize";
            this.textBoxAdvertisementSize.Size = new System.Drawing.Size(160, 27);
            this.textBoxAdvertisementSize.TabIndex = 30;
            // 
            // labelAdvertisementSize
            // 
            this.labelAdvertisementSize.AutoSize = true;
            this.labelAdvertisementSize.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelAdvertisementSize.Location = new System.Drawing.Point(48, 210);
            this.labelAdvertisementSize.Name = "labelAdvertisementSize";
            this.labelAdvertisementSize.Size = new System.Drawing.Size(122, 19);
            this.labelAdvertisementSize.TabIndex = 29;
            this.labelAdvertisementSize.Text = "Объем рекламы";
            // 
            // textBoxNewspaperNumber
            // 
            this.textBoxNewspaperNumber.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBoxNewspaperNumber.Location = new System.Drawing.Point(52, 177);
            this.textBoxNewspaperNumber.Name = "textBoxNewspaperNumber";
            this.textBoxNewspaperNumber.Size = new System.Drawing.Size(160, 27);
            this.textBoxNewspaperNumber.TabIndex = 26;
            // 
            // labelNewapaperNumber
            // 
            this.labelNewapaperNumber.AutoSize = true;
            this.labelNewapaperNumber.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelNewapaperNumber.Location = new System.Drawing.Point(52, 155);
            this.labelNewapaperNumber.Name = "labelNewapaperNumber";
            this.labelNewapaperNumber.Size = new System.Drawing.Size(104, 19);
            this.labelNewapaperNumber.TabIndex = 25;
            this.labelNewapaperNumber.Text = "Номер газеты";
            // 
            // comboBoxOrganisation
            // 
            this.comboBoxOrganisation.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxOrganisation.FormattingEnabled = true;
            this.comboBoxOrganisation.Location = new System.Drawing.Point(52, 76);
            this.comboBoxOrganisation.Name = "comboBoxOrganisation";
            this.comboBoxOrganisation.Size = new System.Drawing.Size(160, 27);
            this.comboBoxOrganisation.TabIndex = 36;
            // 
            // comboBoxNewspaper
            // 
            this.comboBoxNewspaper.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxNewspaper.FormattingEnabled = true;
            this.comboBoxNewspaper.Location = new System.Drawing.Point(52, 127);
            this.comboBoxNewspaper.Name = "comboBoxNewspaper";
            this.comboBoxNewspaper.Size = new System.Drawing.Size(160, 27);
            this.comboBoxNewspaper.TabIndex = 37;
            // 
            // labelNewspaper
            // 
            this.labelNewspaper.AutoSize = true;
            this.labelNewspaper.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelNewspaper.Location = new System.Drawing.Point(52, 105);
            this.labelNewspaper.Name = "labelNewspaper";
            this.labelNewspaper.Size = new System.Drawing.Size(52, 19);
            this.labelNewspaper.TabIndex = 38;
            this.labelNewspaper.Text = "Газета";
            // 
            // labelOrganisation
            // 
            this.labelOrganisation.AutoSize = true;
            this.labelOrganisation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrganisation.Location = new System.Drawing.Point(52, 56);
            this.labelOrganisation.Name = "labelOrganisation";
            this.labelOrganisation.Size = new System.Drawing.Size(101, 19);
            this.labelOrganisation.TabIndex = 39;
            this.labelOrganisation.Text = "Организация";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Организация";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Газета";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Номер газеты";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Объем рекламы";
            this.columnHeader6.Width = 124;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AdvertisementPro.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(28, 316);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 87);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 34;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 423);
            this.Controls.Add(this.labelOrganisation);
            this.Controls.Add(this.labelNewspaper);
            this.Controls.Add(this.comboBoxNewspaper);
            this.Controls.Add(this.comboBoxOrganisation);
            this.Controls.Add(this.listViewAdvertisement);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBoxAdvertisementSize);
            this.Controls.Add(this.labelAdvertisementSize);
            this.Controls.Add(this.textBoxNewspaperNumber);
            this.Controls.Add(this.labelNewapaperNumber);
            this.Name = "FormAdvertisement";
            this.Text = "Реклама";
            this.Load += new System.EventHandler(this.FormAdvertisement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAdvertisement;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxAdvertisementSize;
        private System.Windows.Forms.Label labelAdvertisementSize;
        private System.Windows.Forms.TextBox textBoxNewspaperNumber;
        private System.Windows.Forms.Label labelNewapaperNumber;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBoxOrganisation;
        private System.Windows.Forms.ComboBox comboBoxNewspaper;
        private System.Windows.Forms.Label labelNewspaper;
        private System.Windows.Forms.Label labelOrganisation;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}