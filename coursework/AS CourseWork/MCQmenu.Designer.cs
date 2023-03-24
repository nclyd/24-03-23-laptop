
namespace AS_CourseWork
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
            this.btnAns1 = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAns1
            // 
            this.btnAns1.Location = new System.Drawing.Point(193, 142);
            this.btnAns1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(107, 38);
            this.btnAns1.TabIndex = 0;
            this.btnAns1.Text = "button1";
            this.btnAns1.UseVisualStyleBackColor = true;
            this.btnAns1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(509, 307);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(111, 25);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Place Holder";
            // 
            // btnAns2
            // 
            this.btnAns2.Location = new System.Drawing.Point(809, 142);
            this.btnAns2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(107, 38);
            this.btnAns2.TabIndex = 2;
            this.btnAns2.Text = "button2";
            this.btnAns2.UseVisualStyleBackColor = true;
            this.btnAns2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnAns3
            // 
            this.btnAns3.Location = new System.Drawing.Point(193, 513);
            this.btnAns3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(107, 38);
            this.btnAns3.TabIndex = 3;
            this.btnAns3.Text = "button3";
            this.btnAns3.UseVisualStyleBackColor = true;
            this.btnAns3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnAns4
            // 
            this.btnAns4.Location = new System.Drawing.Point(809, 513);
            this.btnAns4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(107, 38);
            this.btnAns4.TabIndex = 4;
            this.btnAns4.Text = "button4";
            this.btnAns4.UseVisualStyleBackColor = true;
            this.btnAns4.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.btnAns1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
    }
}