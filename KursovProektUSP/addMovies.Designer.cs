namespace KursovProektUSP
{
    partial class addMoviesF
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addToDB = new System.Windows.Forms.Button();
            this.rateTB = new System.Windows.Forms.TrackBar();
            this.oscar = new System.Windows.Forms.CheckBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.lengthTB = new System.Windows.Forms.TextBox();
            this.showTBValue = new System.Windows.Forms.Label();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rateTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oscar";
            // 
            // addToDB
            // 
            this.addToDB.Enabled = false;
            this.addToDB.Location = new System.Drawing.Point(15, 262);
            this.addToDB.Name = "addToDB";
            this.addToDB.Size = new System.Drawing.Size(75, 23);
            this.addToDB.TabIndex = 6;
            this.addToDB.Text = "Add";
            this.addToDB.UseVisualStyleBackColor = true;
            this.addToDB.Click += new System.EventHandler(this.addToDB_Click);
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(89, 167);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(150, 45);
            this.rateTB.TabIndex = 8;
            this.rateTB.Scroll += new System.EventHandler(this.rateTB_Scroll);
            // 
            // oscar
            // 
            this.oscar.AutoSize = true;
            this.oscar.Location = new System.Drawing.Point(89, 218);
            this.oscar.Name = "oscar";
            this.oscar.Size = new System.Drawing.Size(54, 17);
            this.oscar.TabIndex = 9;
            this.oscar.Text = "Oscar";
            this.oscar.UseVisualStyleBackColor = true;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(89, 18);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(100, 20);
            this.titleTB.TabIndex = 10;
            this.titleTB.TextChanged += new System.EventHandler(this.titleTB_TextChanged);
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(89, 95);
            this.yearTB.MaxLength = 4;
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(100, 20);
            this.yearTB.TabIndex = 12;
            this.yearTB.TextChanged += new System.EventHandler(this.yearTB_TextChanged);
            this.yearTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTB_KeyPress);
            // 
            // lengthTB
            // 
            this.lengthTB.Location = new System.Drawing.Point(89, 135);
            this.lengthTB.MaxLength = 3;
            this.lengthTB.Name = "lengthTB";
            this.lengthTB.Size = new System.Drawing.Size(100, 20);
            this.lengthTB.TabIndex = 13;
            this.lengthTB.TextChanged += new System.EventHandler(this.lengthTB_TextChanged);
            this.lengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lengthTB_KeyPress);
            // 
            // showTBValue
            // 
            this.showTBValue.AutoSize = true;
            this.showTBValue.Location = new System.Drawing.Point(245, 184);
            this.showTBValue.Name = "showTBValue";
            this.showTBValue.Size = new System.Drawing.Size(30, 13);
            this.showTBValue.TabIndex = 14;
            this.showTBValue.Text = "Rate";
            this.showTBValue.TextChanged += new System.EventHandler(this.showTBValue_TextChanged);
            // 
            // genreCB
            // 
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Items.AddRange(new object[] {
            "Action",
            "Animation",
            "Comedy",
            "Drama",
            "Thriller",
            "SCI-FI"});
            this.genreCB.Location = new System.Drawing.Point(89, 54);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(100, 21);
            this.genreCB.TabIndex = 15;
            this.genreCB.SelectedIndexChanged += new System.EventHandler(this.genreCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "minutes";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(237, 262);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 17;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(125, 262);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addMoviesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 299);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.showTBValue);
            this.Controls.Add(this.lengthTB);
            this.Controls.Add(this.yearTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.oscar);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.addToDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addMoviesF";
            this.Text = "addMovies";
            ((System.ComponentModel.ISupportInitialize)(this.rateTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addToDB;
        private System.Windows.Forms.TrackBar rateTB;
        private System.Windows.Forms.CheckBox oscar;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.TextBox lengthTB;
        private System.Windows.Forms.Label showTBValue;
        private System.Windows.Forms.ComboBox genreCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}