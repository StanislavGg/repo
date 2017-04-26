
namespace KursovProektUSP
{
    
    partial class showMoviesF
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
            this.addMovieB = new System.Windows.Forms.Button();
            this.searchMovieB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieB
            // 
            this.addMovieB.Location = new System.Drawing.Point(12, 391);
            this.addMovieB.Name = "addMovieB";
            this.addMovieB.Size = new System.Drawing.Size(75, 23);
            this.addMovieB.TabIndex = 1;
            this.addMovieB.Text = "Add";
            this.addMovieB.UseVisualStyleBackColor = true;
            this.addMovieB.Click += new System.EventHandler(this.addMovieB_Click);
            // 
            // searchMovieB
            // 
            this.searchMovieB.Location = new System.Drawing.Point(105, 391);
            this.searchMovieB.Name = "searchMovieB";
            this.searchMovieB.Size = new System.Drawing.Size(75, 23);
            this.searchMovieB.TabIndex = 2;
            this.searchMovieB.Text = "Search";
            this.searchMovieB.UseVisualStyleBackColor = true;
            this.searchMovieB.Click += new System.EventHandler(this.searchMovieB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // showMoviesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchMovieB);
            this.Controls.Add(this.addMovieB);
            this.Name = "showMoviesF";
            this.Text = "showMoviesF";
            this.Load += new System.EventHandler(this.showMoviesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMovieB;
        private System.Windows.Forms.Button searchMovieB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}