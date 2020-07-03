namespace AdvertisementPro
{
    partial class FormNewspaper
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
            this.listViewNewspaper = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAdvertisementPrice = new System.Windows.Forms.TextBox();
            this.labelAdPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewNewspaper
            // 
            this.listViewNewspaper.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listViewNewspaper.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.listViewNewspaper.FullRowSelect = true;
            this.listViewNewspaper.GridLines = true;
            this.listViewNewspaper.HideSelection = false;
            this.listViewNewspaper.Location = new System.Drawing.Point(258, 52);
            this.listViewNewspaper.MultiSelect = false;
            this.listViewNewspaper.Name = "listViewNewspaper";
            this.listViewNewspaper.Size = new System.Drawing.Size(452, 261);
            this.listViewNewspaper.TabIndex = 24;
            this.listViewNewspaper.UseCompatibleStateImageBehavior = false;
            this.listViewNewspaper.View = System.Windows.Forms.View.Details;
            this.listViewNewspaper.SelectedIndexChanged += new System.EventHandler(this.listViewNewspaper_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Адрес";
            this.columnHeader3.Width = 129;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(328, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 48);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(460, 336);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 48);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonDel.Location = new System.Drawing.Point(598, 336);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(112, 48);
            this.buttonDel.TabIndex = 20;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBoxPhone.Location = new System.Drawing.Point(14, 146);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(160, 27);
            this.textBoxPhone.TabIndex = 19;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelPhone.Location = new System.Drawing.Point(12, 124);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 19);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxAdvertisementPrice
            // 
            this.textBoxAdvertisementPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBoxAdvertisementPrice.Location = new System.Drawing.Point(14, 206);
            this.textBoxAdvertisementPrice.Name = "textBoxAdvertisementPrice";
            this.textBoxAdvertisementPrice.Size = new System.Drawing.Size(160, 27);
            this.textBoxAdvertisementPrice.TabIndex = 17;
            // 
            // labelAdPrice
            // 
            this.labelAdPrice.AutoSize = true;
            this.labelAdPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelAdPrice.Location = new System.Drawing.Point(14, 184);
            this.labelAdPrice.Name = "labelAdPrice";
            this.labelAdPrice.Size = new System.Drawing.Size(109, 19);
            this.labelAdPrice.TabIndex = 16;
            this.labelAdPrice.Text = "Цена рекламы";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBoxName.Location = new System.Drawing.Point(14, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 27);
            this.textBoxName.TabIndex = 15;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelName.Location = new System.Drawing.Point(10, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 19);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Название";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена рекламы";
            this.columnHeader5.Width = 137;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AdvertisementPro.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 304);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 87);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormNewspaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 416);
            this.Controls.Add(this.listViewNewspaper);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAdvertisementPrice);
            this.Controls.Add(this.labelAdPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormNewspaper";
            this.Text = "Газеты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNewspaper;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAdvertisementPrice;
        private System.Windows.Forms.Label labelAdPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}