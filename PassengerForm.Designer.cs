namespace Insert_in_Database__MDI_
{
    partial class PassengerForm
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
            this.Passager_Nom = new System.Windows.Forms.TextBox();
            this.Passager_Prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Passager_ville = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Inserer_Passanger = new System.Windows.Forms.Button();
            this.Passager_Pass = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // Passager_Nom
            // 
            this.Passager_Nom.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passager_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Passager_Nom.Location = new System.Drawing.Point(209, 101);
            this.Passager_Nom.Name = "Passager_Nom";
            this.Passager_Nom.Size = new System.Drawing.Size(169, 30);
            this.Passager_Nom.TabIndex = 1;
            // 
            // Passager_Prenom
            // 
            this.Passager_Prenom.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passager_Prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Passager_Prenom.Location = new System.Drawing.Point(209, 177);
            this.Passager_Prenom.Name = "Passager_Prenom";
            this.Passager_Prenom.Size = new System.Drawing.Size(169, 30);
            this.Passager_Prenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom";
            // 
            // Passager_ville
            // 
            this.Passager_ville.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passager_ville.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Passager_ville.Location = new System.Drawing.Point(209, 252);
            this.Passager_ville.Name = "Passager_ville";
            this.Passager_ville.Size = new System.Drawing.Size(169, 30);
            this.Passager_ville.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "ville";
            // 
            // Inserer_Passanger
            // 
            this.Inserer_Passanger.BackColor = System.Drawing.Color.White;
            this.Inserer_Passanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inserer_Passanger.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Inserer_Passanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Inserer_Passanger.Location = new System.Drawing.Point(464, 118);
            this.Inserer_Passanger.Name = "Inserer_Passanger";
            this.Inserer_Passanger.Size = new System.Drawing.Size(99, 64);
            this.Inserer_Passanger.TabIndex = 15;
            this.Inserer_Passanger.Text = "Inserer";
            this.Inserer_Passanger.UseVisualStyleBackColor = false;
            this.Inserer_Passanger.Click += new System.EventHandler(this.Inserer_Passanger_Click);
            // 
            // Passager_Pass
            // 
            this.Passager_Pass.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passager_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.Passager_Pass.Location = new System.Drawing.Point(209, 26);
            this.Passager_Pass.Name = "Passager_Pass";
            this.Passager_Pass.Size = new System.Drawing.Size(169, 30);
            this.Passager_Pass.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(112, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 23);
            this.label.TabIndex = 16;
            this.label.Text = "pass";
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.Passager_Pass);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Inserer_Passanger);
            this.Controls.Add(this.Passager_ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passager_Prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Passager_Nom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassengerForm";
            this.Text = "Insert Passager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passager_Nom;
        private System.Windows.Forms.TextBox Passager_Prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passager_ville;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Inserer_Passanger;
        private System.Windows.Forms.TextBox Passager_Pass;
        private System.Windows.Forms.Label label;
    }
}