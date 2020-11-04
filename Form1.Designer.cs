namespace Insert_in_Database__MDI_
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inserDansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassagerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PiloteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserDansToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(817, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // inserDansToolStripMenuItem
            // 
            this.inserDansToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.inserDansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PassagerItem,
            this.PiloteItem});
            this.inserDansToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inserDansToolStripMenuItem.Name = "inserDansToolStripMenuItem";
            this.inserDansToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.inserDansToolStripMenuItem.Text = "Inser Dans";
            // 
            // PassagerItem
            // 
            this.PassagerItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.PassagerItem.ForeColor = System.Drawing.Color.White;
            this.PassagerItem.Name = "PassagerItem";
            this.PassagerItem.Size = new System.Drawing.Size(120, 22);
            this.PassagerItem.Text = "Passager";
            this.PassagerItem.Click += new System.EventHandler(this.PassagerItem_Click);
            // 
            // PiloteItem
            // 
            this.PiloteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.PiloteItem.ForeColor = System.Drawing.Color.White;
            this.PiloteItem.Name = "PiloteItem";
            this.PiloteItem.Size = new System.Drawing.Size(120, 22);
            this.PiloteItem.Text = "Pilote";
            this.PiloteItem.Click += new System.EventHandler(this.PiloteItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(817, 412);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piloteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inserDansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PassagerItem;
        private System.Windows.Forms.ToolStripMenuItem PiloteItem;
    }
}

