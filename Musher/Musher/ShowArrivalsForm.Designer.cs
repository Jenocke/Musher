namespace Musher
{
    partial class ShowArrivalsForm
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
            this.arrivalsView = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalsView)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalsView
            // 
            this.arrivalsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrivalsView.Location = new System.Drawing.Point(12, 71);
            this.arrivalsView.Name = "arrivalsView";
            this.arrivalsView.Size = new System.Drawing.Size(776, 367);
            this.arrivalsView.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(322, 21);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(171, 31);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "View Arrivals";
            // 
            // ShowArrivalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.arrivalsView);
            this.Name = "ShowArrivalsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShowArrivalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrivalsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView arrivalsView;
        private System.Windows.Forms.Label lbl_Title;
    }
}