namespace Musher
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_MushName = new System.Windows.Forms.Label();
            this.txtBox_MushName = new System.Windows.Forms.TextBox();
            this.num_MushNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_MushNumber = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_MushNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(323, 36);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(159, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Chip control";
            // 
            // lbl_MushName
            // 
            this.lbl_MushName.AutoSize = true;
            this.lbl_MushName.Location = new System.Drawing.Point(126, 97);
            this.lbl_MushName.Name = "lbl_MushName";
            this.lbl_MushName.Size = new System.Drawing.Size(73, 13);
            this.lbl_MushName.TabIndex = 1;
            this.lbl_MushName.Text = "Musher Name";
            // 
            // txtBox_MushName
            // 
            this.txtBox_MushName.Location = new System.Drawing.Point(129, 113);
            this.txtBox_MushName.Name = "txtBox_MushName";
            this.txtBox_MushName.Size = new System.Drawing.Size(211, 20);
            this.txtBox_MushName.TabIndex = 2;
            // 
            // num_MushNumber
            // 
            this.num_MushNumber.Location = new System.Drawing.Point(431, 114);
            this.num_MushNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_MushNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_MushNumber.Name = "num_MushNumber";
            this.num_MushNumber.Size = new System.Drawing.Size(120, 20);
            this.num_MushNumber.TabIndex = 3;
            this.num_MushNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl_MushNumber
            // 
            this.lbl_MushNumber.AutoSize = true;
            this.lbl_MushNumber.Location = new System.Drawing.Point(431, 99);
            this.lbl_MushNumber.Name = "lbl_MushNumber";
            this.lbl_MushNumber.Size = new System.Drawing.Size(82, 13);
            this.lbl_MushNumber.TabIndex = 4;
            this.lbl_MushNumber.Text = "Musher Number";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(669, 388);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(119, 50);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cbb_Category
            // 
            this.cbb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Items.AddRange(new object[] {
            "Sky-Joging",
            "A1",
            "A2",
            "A3",
            "D1",
            "D2",
            "D3",
            "O1",
            "O2"});
            this.cbb_Category.Location = new System.Drawing.Point(129, 251);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(121, 21);
            this.cbb_Category.TabIndex = 6;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(129, 232);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(49, 13);
            this.lbl_Category.TabIndex = 7;
            this.lbl_Category.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cbb_Category);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_MushNumber);
            this.Controls.Add(this.num_MushNumber);
            this.Controls.Add(this.txtBox_MushName);
            this.Controls.Add(this.lbl_MushName);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_MushNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_MushName;
        private System.Windows.Forms.TextBox txtBox_MushName;
        private System.Windows.Forms.NumericUpDown num_MushNumber;
        private System.Windows.Forms.Label lbl_MushNumber;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.Label lbl_Category;
    }
}

