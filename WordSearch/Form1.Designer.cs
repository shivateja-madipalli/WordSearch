namespace WordSearch
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddtextbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(38, 54);
            this.txt1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(25, 26);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(145, 54);
            this.txt3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(25, 26);
            this.txt3.TabIndex = 1;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(197, 54);
            this.txt4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(25, 26);
            this.txt4.TabIndex = 2;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(90, 54);
            this.txt2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(25, 26);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(289, 157);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 37);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddtextbox
            // 
            this.btnAddtextbox.Location = new System.Drawing.Point(264, 49);
            this.btnAddtextbox.Name = "btnAddtextbox";
            this.btnAddtextbox.Size = new System.Drawing.Size(37, 36);
            this.btnAddtextbox.TabIndex = 5;
            this.btnAddtextbox.Text = "+";
            this.btnAddtextbox.UseVisualStyleBackColor = true;
            this.btnAddtextbox.Click += new System.EventHandler(this.btnAddtextbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 206);
            this.Controls.Add(this.btnAddtextbox);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddtextbox;
    }
}

