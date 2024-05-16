namespace _3ilBorne
{
    partial class Capteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capteur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_recherche = new System.Windows.Forms.Label();
            this.comboCamera = new System.Windows.Forms.ComboBox();
            this.btnScane = new System.Windows.Forms.Button();
            this.Lbstatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(8, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(192, 9);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(379, 46);
            this.lb_titre.TabIndex = 2;
            this.lb_titre.Text = "3il Borne Platforme";
            // 
            // lb_recherche
            // 
            this.lb_recherche.AutoSize = true;
            this.lb_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recherche.Location = new System.Drawing.Point(25, 77);
            this.lb_recherche.Name = "lb_recherche";
            this.lb_recherche.Size = new System.Drawing.Size(98, 29);
            this.lb_recherche.TabIndex = 3;
            this.lb_recherche.Text = "Camera";
            // 
            // comboCamera
            // 
            this.comboCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCamera.FormattingEnabled = true;
            this.comboCamera.Location = new System.Drawing.Point(140, 72);
            this.comboCamera.Name = "comboCamera";
            this.comboCamera.Size = new System.Drawing.Size(243, 37);
            this.comboCamera.TabIndex = 40;
            this.comboCamera.SelectedIndexChanged += new System.EventHandler(this.comboCamera_SelectedIndexChanged);
            // 
            // btnScane
            // 
            this.btnScane.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScane.Location = new System.Drawing.Point(596, 119);
            this.btnScane.Name = "btnScane";
            this.btnScane.Size = new System.Drawing.Size(152, 50);
            this.btnScane.TabIndex = 41;
            this.btnScane.Text = "&Scaner";
            this.btnScane.UseVisualStyleBackColor = true;
            this.btnScane.Click += new System.EventHandler(this.btnScane_Click);
            // 
            // Lbstatus
            // 
            this.Lbstatus.AutoSize = true;
            this.Lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbstatus.Location = new System.Drawing.Point(631, 231);
            this.Lbstatus.Name = "Lbstatus";
            this.Lbstatus.Size = new System.Drawing.Size(79, 29);
            this.Lbstatus.TabIndex = 42;
            this.Lbstatus.Text = "Status";
            this.Lbstatus.Click += new System.EventHandler(this.Lbstatus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 157);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = " ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(389, 68);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(152, 43);
            this.btnstart.TabIndex = 44;
            this.btnstart.Text = "&Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Capteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbstatus);
            this.Controls.Add(this.btnScane);
            this.Controls.Add(this.comboCamera);
            this.Controls.Add(this.lb_recherche);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Capteur";
            this.Text = "Capteur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Capteur_FormClosing);
            this.Load += new System.EventHandler(this.Capteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_recherche;
        private System.Windows.Forms.ComboBox comboCamera;
        private System.Windows.Forms.Button btnScane;
        private System.Windows.Forms.Label Lbstatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer timer1;
    }
}