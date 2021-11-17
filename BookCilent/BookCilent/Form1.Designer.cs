
namespace BookCilent
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
            this.listBoxBook = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPublicsher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.buttonPublicsher = new System.Windows.Forms.Button();
            this.buttonID = new System.Windows.Forms.Button();
            this.buttonLoadDS = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBook
            // 
            this.listBoxBook.FormattingEnabled = true;
            this.listBoxBook.ItemHeight = 20;
            this.listBoxBook.Location = new System.Drawing.Point(439, 12);
            this.listBoxBook.Name = "listBoxBook";
            this.listBoxBook.Size = new System.Drawing.Size(644, 324);
            this.listBoxBook.TabIndex = 0;
            this.listBoxBook.SelectedIndexChanged += new System.EventHandler(this.listBoxBook_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(115, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(318, 26);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(115, 44);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(318, 26);
            this.textBoxTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "title";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(115, 76);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(318, 26);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "author";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(115, 108);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(318, 26);
            this.textBoxPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "price";
            // 
            // textBoxPublicsher
            // 
            this.textBoxPublicsher.Location = new System.Drawing.Point(115, 140);
            this.textBoxPublicsher.Name = "textBoxPublicsher";
            this.textBoxPublicsher.Size = new System.Drawing.Size(318, 26);
            this.textBoxPublicsher.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "publicsher";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(167, 197);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(116, 43);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.Location = new System.Drawing.Point(223, 246);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(210, 43);
            this.buttonAuthor.TabIndex = 12;
            this.buttonAuthor.Text = "Tìm kiếm cùng author";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            // 
            // buttonPublicsher
            // 
            this.buttonPublicsher.Location = new System.Drawing.Point(7, 246);
            this.buttonPublicsher.Name = "buttonPublicsher";
            this.buttonPublicsher.Size = new System.Drawing.Size(210, 43);
            this.buttonPublicsher.TabIndex = 13;
            this.buttonPublicsher.Text = "Tìm kiếm cùng publicsher";
            this.buttonPublicsher.UseVisualStyleBackColor = true;
            // 
            // buttonID
            // 
            this.buttonID.Location = new System.Drawing.Point(289, 197);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(144, 43);
            this.buttonID.TabIndex = 14;
            this.buttonID.Text = "Tìm kiếm theo ID";
            this.buttonID.UseVisualStyleBackColor = true;
            this.buttonID.Click += new System.EventHandler(this.buttonID_Click);
            // 
            // buttonLoadDS
            // 
            this.buttonLoadDS.Location = new System.Drawing.Point(7, 197);
            this.buttonLoadDS.Name = "buttonLoadDS";
            this.buttonLoadDS.Size = new System.Drawing.Size(154, 43);
            this.buttonLoadDS.TabIndex = 15;
            this.buttonLoadDS.Text = "Load Danh Sach";
            this.buttonLoadDS.UseVisualStyleBackColor = true;
            this.buttonLoadDS.Click += new System.EventHandler(this.buttonLoadDS_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(7, 307);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(88, 29);
            this.buttonThoat.TabIndex = 16;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 359);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLoadDS);
            this.Controls.Add(this.buttonID);
            this.Controls.Add(this.buttonPublicsher);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxPublicsher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBook);
            this.Name = "Form1";
            this.Text = "FormBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPublicsher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.Button buttonPublicsher;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.Button buttonLoadDS;
        private System.Windows.Forms.Button buttonThoat;
    }
}

