namespace Insert_in_Database__MDI_
{
    partial class PiloteForm
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
            this.Pilote_ville = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pilote_Code_Postal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pilote_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Inserer_Pilote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pilote_ville
            // 
            this.Pilote_ville.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilote_ville.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Pilote_ville.Location = new System.Drawing.Point(233, 228);
            this.Pilote_ville.Name = "Pilote_ville";
            this.Pilote_ville.Size = new System.Drawing.Size(169, 30);
            this.Pilote_ville.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "ville";
            // 
            // Pilote_Code_Postal
            // 
            this.Pilote_Code_Postal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilote_Code_Postal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Pilote_Code_Postal.Location = new System.Drawing.Point(233, 153);
            this.Pilote_Code_Postal.Name = "Pilote_Code_Postal";
            this.Pilote_Code_Postal.Size = new System.Drawing.Size(169, 30);
            this.Pilote_Code_Postal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code Postal";
            // 
            // Pilote_Nom
            // 
            this.Pilote_Nom.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilote_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Pilote_Nom.Location = new System.Drawing.Point(233, 77);
            this.Pilote_Nom.Name = "Pilote_Nom";
            this.Pilote_Nom.Size = new System.Drawing.Size(169, 30);
            this.Pilote_Nom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "nom";
            // 
            // Inserer_Pilote
            // 
            this.Inserer_Pilote.BackColor = System.Drawing.Color.White;
            this.Inserer_Pilote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inserer_Pilote.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Inserer_Pilote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Inserer_Pilote.Location = new System.Drawing.Point(482, 135);
            this.Inserer_Pilote.Name = "Inserer_Pilote";
            this.Inserer_Pilote.Size = new System.Drawing.Size(99, 64);
            this.Inserer_Pilote.TabIndex = 14;
            this.Inserer_Pilote.Text = "Inserer";
            this.Inserer_Pilote.UseVisualStyleBackColor = false;
            this.Inserer_Pilote.Click += new System.EventHandler(this.Inserer_Pilote_Click);
            // 
            // PiloteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(743, 366);
            this.Controls.Add(this.Inserer_Pilote);
            this.Controls.Add(this.Pilote_ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pilote_Code_Postal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pilote_Nom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PiloteForm";
            this.Text = "PiloteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pilote_ville;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pilote_Code_Postal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pilote_Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Inserer_Pilote;
    }
}