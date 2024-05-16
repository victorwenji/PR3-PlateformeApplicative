namespace _3ilAdministrationPlatforme
{
    partial class Promotions
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 36);
            this.label2.TabIndex = 48;
            this.label2.Text = "Year";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(619, 396);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(152, 39);
            this.btnModifier.TabIndex = 46;
            this.btnModifier.Text = "Crée";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(236, 123);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(320, 34);
            this.tbId.TabIndex = 45;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(236, 212);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 34);
            this.tbName.TabIndex = 43;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(252, 15);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(295, 36);
            this.lb_id.TabIndex = 42;
            this.lb_id.Text = "Crée une promotion";
            // 
            // Promotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lb_id);
            this.Name = "Promotions";
            this.Text = "Promotions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lb_id;
    }
}