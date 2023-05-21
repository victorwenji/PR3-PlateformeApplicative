namespace _3ilAdministrationPlatforme
{
    partial class CreationEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationEtudiant));
            this.lb_id = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.lbprenom = new System.Windows.Forms.Label();
            this.lbREf = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGRoupe = new System.Windows.Forms.ComboBox();
            this.comboPromo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(281, 26);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(207, 29);
            this.lb_id.TabIndex = 2;
            this.lb_id.Text = "Crée un Etudiant";
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.Location = new System.Drawing.Point(36, 106);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(83, 29);
            this.lbnom.TabIndex = 3;
            this.lbnom.Text = "Nom : ";
            // 
            // lbprenom
            // 
            this.lbprenom.AutoSize = true;
            this.lbprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprenom.Location = new System.Drawing.Point(36, 173);
            this.lbprenom.Name = "lbprenom";
            this.lbprenom.Size = new System.Drawing.Size(121, 29);
            this.lbprenom.TabIndex = 4;
            this.lbprenom.Text = "PreNom : ";
            // 
            // lbREf
            // 
            this.lbREf.AutoSize = true;
            this.lbREf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREf.Location = new System.Drawing.Point(36, 228);
            this.lbREf.Name = "lbREf";
            this.lbREf.Size = new System.Drawing.Size(86, 29);
            this.lbREf.TabIndex = 5;
            this.lbREf.Text = "Email :";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(35, 281);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(112, 29);
            this.lbdate.TabIndex = 6;
            this.lbdate.Text = "Groupe : ";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(636, 399);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(152, 39);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "CREATE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(181, 101);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 34);
            this.tbName.TabIndex = 9;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(181, 170);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(320, 34);
            this.tbPrenom.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(181, 225);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 34);
            this.tbEmail.TabIndex = 11;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(12, 399);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(152, 39);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Promotion :";
            // 
            // comboGRoupe
            // 
            this.comboGRoupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGRoupe.FormattingEnabled = true;
            this.comboGRoupe.Items.AddRange(new object[] {
            "MS2D-FA",
            "MS2D-FE"});
            this.comboGRoupe.Location = new System.Drawing.Point(181, 278);
            this.comboGRoupe.Name = "comboGRoupe";
            this.comboGRoupe.Size = new System.Drawing.Size(320, 37);
            this.comboGRoupe.TabIndex = 15;
            // 
            // comboPromo
            // 
            this.comboPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPromo.FormattingEnabled = true;
            this.comboPromo.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.comboPromo.Location = new System.Drawing.Point(181, 328);
            this.comboPromo.Name = "comboPromo";
            this.comboPromo.Size = new System.Drawing.Size(320, 37);
            this.comboPromo.TabIndex = 16;
            // 
            // CreationEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboPromo);
            this.Controls.Add(this.comboGRoupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbREf);
            this.Controls.Add(this.lbprenom);
            this.Controls.Add(this.lbnom);
            this.Controls.Add(this.lb_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreationEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreationEtudiant";
            this.Load += new System.EventHandler(this.CreationEtudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lbnom;
        private System.Windows.Forms.Label lbprenom;
        private System.Windows.Forms.Label lbREf;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGRoupe;
        private System.Windows.Forms.ComboBox comboPromo;
    }
}