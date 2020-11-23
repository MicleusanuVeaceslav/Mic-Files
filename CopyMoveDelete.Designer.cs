namespace File_mover
{
    partial class CopyMoveDelete
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyMoveDelete));
            this.copy = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.dlg_save = new System.Windows.Forms.SaveFileDialog();
            this.select = new System.Windows.Forms.Button();
            this.dlg_select = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPath = new System.Windows.Forms.TextBox();
            this.options = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(190, 122);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(118, 23);
            this.copy.TabIndex = 0;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(351, 122);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(12, 122);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(118, 23);
            this.move.TabIndex = 2;
            this.move.Text = "Move";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(353, 42);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(116, 20);
            this.select.TabIndex = 3;
            this.select.Text = "Select File";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::File_mover.Properties.Resources.matrix;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 276);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // showPath
            // 
            this.showPath.BackColor = System.Drawing.Color.Black;
            this.showPath.ForeColor = System.Drawing.Color.White;
            this.showPath.Location = new System.Drawing.Point(12, 42);
            this.showPath.Name = "showPath";
            this.showPath.Size = new System.Drawing.Size(306, 20);
            this.showPath.TabIndex = 6;
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.Location = new System.Drawing.Point(12, 79);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(80, 24);
            this.options.TabIndex = 7;
            this.options.Text = "Options:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "by Micleusanu Veaceslav";
            // 
            // CopyMoveDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(496, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.options);
            this.Controls.Add(this.showPath);
            this.Controls.Add(this.select);
            this.Controls.Add(this.move);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(512, 315);
            this.MinimumSize = new System.Drawing.Size(512, 315);
            this.Name = "CopyMoveDelete";
            this.Text = "File Editing Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.SaveFileDialog dlg_save;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.OpenFileDialog dlg_select;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox showPath;
        private System.Windows.Forms.Label options;
        private System.Windows.Forms.Label label1;
    }
}

