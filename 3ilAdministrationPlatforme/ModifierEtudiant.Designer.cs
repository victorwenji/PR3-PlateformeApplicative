namespace _3ilAdministrationPlatforme
{
    partial class ModifierEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierEtudiant));
            this.lb_id = new System.Windows.Forms.Label();
            this.comboPromo = new System.Windows.Forms.ComboBox();
            this.comboGRoupe = new System.Windows.Forms.ComboBox();
            this.lbPromotion = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbGroupe = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbprenom = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(279, 19);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(246, 29);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "Modifier un Etudiant";
            // 
            // comboPromo
            // 
            this.comboPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPromo.FormattingEnabled = true;
            this.comboPromo.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.comboPromo.Location = new System.Drawing.Point(205, 359);
            this.comboPromo.Name = "comboPromo";
            this.comboPromo.Size = new System.Drawing.Size(320, 37);
            this.comboPromo.TabIndex = 26;
            // 
            // comboGRoupe
            // 
            this.comboGRoupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGRoupe.FormattingEnabled = true;
            this.comboGRoupe.Items.AddRange(new object[] {
            "MS2D-FA",
            "MS2D-FE"});
            this.comboGRoupe.Location = new System.Drawing.Point(205, 309);
            this.comboGRoupe.Name = "comboGRoupe";
            this.comboGRoupe.Size = new System.Drawing.Size(320, 37);
            this.comboGRoupe.TabIndex = 25;
            // 
            // lbPromotion
            // 
            this.lbPromotion.AutoSize = true;
            this.lbPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromotion.Location = new System.Drawing.Point(56, 362);
            this.lbPromotion.Name = "lbPromotion";
            this.lbPromotion.Size = new System.Drawing.Size(136, 29);
            this.lbPromotion.TabIndex = 24;
            this.lbPromotion.Text = "Promotion :";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(205, 256);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 34);
            this.tbEmail.TabIndex = 23;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(205, 201);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(320, 34);
            this.tbPrenom.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(205, 146);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 34);
            this.tbName.TabIndex = 21;
            // 
            // lbGroupe
            // 
            this.lbGroupe.AutoSize = true;
            this.lbGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupe.Location = new System.Drawing.Point(59, 312);
            this.lbGroupe.Name = "lbGroupe";
            this.lbGroupe.Size = new System.Drawing.Size(112, 29);
            this.lbGroupe.TabIndex = 20;
            this.lbGroupe.Text = "Groupe : ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(60, 259);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(86, 29);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Email :";
            // 
            // lbprenom
            // 
            this.lbprenom.AutoSize = true;
            this.lbprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprenom.Location = new System.Drawing.Point(60, 204);
            this.lbprenom.Name = "lbprenom";
            this.lbprenom.Size = new System.Drawing.Size(121, 29);
            this.lbprenom.TabIndex = 18;
            this.lbprenom.Text = "PreNom : ";
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.Location = new System.Drawing.Point(60, 152);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(83, 29);
            this.lbnom.TabIndex = 17;
            this.lbnom.Text = "Nom : ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(60, 98);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(51, 29);
            this.lbId.TabIndex = 27;
            this.lbId.Text = "Id : ";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(205, 91);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(320, 34);
            this.tbId.TabIndex = 28;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(647, 399);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(152, 39);
            this.btnModifier.TabIndex = 30;
            this.btnModifier.Text = "UpDate";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // ModifierEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.comboPromo);
            this.Controls.Add(this.comboGRoupe);
            this.Controls.Add(this.lbPromotion);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbGroupe);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbprenom);
            this.Controls.Add(this.lbnom);
            this.Controls.Add(this.lb_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifierEtudiant";
            this.Text = "ModifierEtudiant";
            this.Load += new System.EventHandler(this.ModifierEtudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox comboPromo;
        private System.Windows.Forms.ComboBox comboGRoupe;
        private System.Windows.Forms.Label lbPromotion;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbGroupe;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbprenom;
        private System.Windows.Forms.Label lbnom;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnModifier;
    }
}