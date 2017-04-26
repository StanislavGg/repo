namespace KursovProektUSP
{
    partial class searchMoviesF
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
            this.showSearchResultsLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionCB = new System.Windows.Forms.CheckBox();
            this.comedyCB = new System.Windows.Forms.CheckBox();
            this.dramaCB = new System.Windows.Forms.CheckBox();
            this.scifiCB = new System.Windows.Forms.CheckBox();
            this.thrillerCB = new System.Windows.Forms.CheckBox();
            this.animationCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchMTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchMLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showSearchResultsLB
            // 
            this.showSearchResultsLB.FormattingEnabled = true;
            this.showSearchResultsLB.Location = new System.Drawing.Point(12, 12);
            this.showSearchResultsLB.Name = "showSearchResultsLB";
            this.showSearchResultsLB.Size = new System.Drawing.Size(217, 264);
            this.showSearchResultsLB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genres";
            // 
            // actionCB
            // 
            this.actionCB.AutoSize = true;
            this.actionCB.Location = new System.Drawing.Point(235, 40);
            this.actionCB.Name = "actionCB";
            this.actionCB.Size = new System.Drawing.Size(56, 17);
            this.actionCB.TabIndex = 2;
            this.actionCB.Text = "Action";
            this.actionCB.UseVisualStyleBackColor = true;
            // 
            // comedyCB
            // 
            this.comedyCB.AutoSize = true;
            this.comedyCB.Location = new System.Drawing.Point(375, 40);
            this.comedyCB.Name = "comedyCB";
            this.comedyCB.Size = new System.Drawing.Size(64, 17);
            this.comedyCB.TabIndex = 3;
            this.comedyCB.Text = "Comedy";
            this.comedyCB.UseVisualStyleBackColor = true;
            // 
            // dramaCB
            // 
            this.dramaCB.AutoSize = true;
            this.dramaCB.Location = new System.Drawing.Point(235, 63);
            this.dramaCB.Name = "dramaCB";
            this.dramaCB.Size = new System.Drawing.Size(57, 17);
            this.dramaCB.TabIndex = 4;
            this.dramaCB.Text = "Drama";
            this.dramaCB.UseVisualStyleBackColor = true;
            // 
            // scifiCB
            // 
            this.scifiCB.AutoSize = true;
            this.scifiCB.Location = new System.Drawing.Point(375, 63);
            this.scifiCB.Name = "scifiCB";
            this.scifiCB.Size = new System.Drawing.Size(55, 17);
            this.scifiCB.TabIndex = 5;
            this.scifiCB.Text = "SCI-FI";
            this.scifiCB.UseVisualStyleBackColor = true;
            // 
            // thrillerCB
            // 
            this.thrillerCB.AutoSize = true;
            this.thrillerCB.Location = new System.Drawing.Point(297, 63);
            this.thrillerCB.Name = "thrillerCB";
            this.thrillerCB.Size = new System.Drawing.Size(57, 17);
            this.thrillerCB.TabIndex = 6;
            this.thrillerCB.Text = "Thriller";
            this.thrillerCB.UseVisualStyleBackColor = true;
            // 
            // animationCB
            // 
            this.animationCB.AutoSize = true;
            this.animationCB.Location = new System.Drawing.Point(297, 40);
            this.animationCB.Name = "animationCB";
            this.animationCB.Size = new System.Drawing.Size(72, 17);
            this.animationCB.TabIndex = 7;
            this.animationCB.Text = "Animation";
            this.animationCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Movie title";
            // 
            // searchMTitle
            // 
            this.searchMTitle.Location = new System.Drawing.Point(238, 113);
            this.searchMTitle.Name = "searchMTitle";
            this.searchMTitle.Size = new System.Drawing.Size(100, 20);
            this.searchMTitle.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Length";
            // 
            // searchMLength
            // 
            this.searchMLength.Location = new System.Drawing.Point(238, 153);
            this.searchMLength.MaxLength = 3;
            this.searchMLength.Name = "searchMLength";
            this.searchMLength.Size = new System.Drawing.Size(100, 20);
            this.searchMLength.TabIndex = 11;
            this.searchMLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchMLength_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "minutes";
            // 
            // searchMoviesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchMLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchMTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animationCB);
            this.Controls.Add(this.thrillerCB);
            this.Controls.Add(this.scifiCB);
            this.Controls.Add(this.dramaCB);
            this.Controls.Add(this.comedyCB);
            this.Controls.Add(this.actionCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSearchResultsLB);
            this.Name = "searchMoviesF";
            this.Text = "searchMovies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showSearchResultsLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox actionCB;
        private System.Windows.Forms.CheckBox comedyCB;
        private System.Windows.Forms.CheckBox dramaCB;
        private System.Windows.Forms.CheckBox scifiCB;
        private System.Windows.Forms.CheckBox thrillerCB;
        private System.Windows.Forms.CheckBox animationCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchMTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchMLength;
        private System.Windows.Forms.Label label4;
    }
}