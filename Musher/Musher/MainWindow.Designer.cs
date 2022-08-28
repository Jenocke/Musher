namespace Musher
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mushersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMusherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importArrivalsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewArrivalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.mushersToolStripMenuItem,
            this.importArrivalsFileToolStripMenuItem,
            this.viewArrivalsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fichierToolStripMenuItem.Text = "Files";
            // 
            // mushersToolStripMenuItem
            // 
            this.mushersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMusherToolStripMenuItem});
            this.mushersToolStripMenuItem.Name = "mushersToolStripMenuItem";
            this.mushersToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mushersToolStripMenuItem.Text = "Mushers";
            // 
            // addMusherToolStripMenuItem
            // 
            this.addMusherToolStripMenuItem.Name = "addMusherToolStripMenuItem";
            this.addMusherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addMusherToolStripMenuItem.Text = "Add Musher";
            this.addMusherToolStripMenuItem.Click += new System.EventHandler(this.addMusherToolStripMenuItem_Click);
            // 
            // importArrivalsFileToolStripMenuItem
            // 
            this.importArrivalsFileToolStripMenuItem.Name = "importArrivalsFileToolStripMenuItem";
            this.importArrivalsFileToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.importArrivalsFileToolStripMenuItem.Text = "Import Arrivals File";
            this.importArrivalsFileToolStripMenuItem.Click += new System.EventHandler(this.importArrivalsFileToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*\"";
            // 
            // viewArrivalsToolStripMenuItem
            // 
            this.viewArrivalsToolStripMenuItem.Name = "viewArrivalsToolStripMenuItem";
            this.viewArrivalsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.viewArrivalsToolStripMenuItem.Text = "View arrivals";
            this.viewArrivalsToolStripMenuItem.Click += new System.EventHandler(this.viewArrivalsToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 570);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mushersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMusherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importArrivalsFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewArrivalsToolStripMenuItem;
    }
}