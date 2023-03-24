namespace AS_CourseWork
{
    partial class DnDForm
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
            this.lblTextDrop1 = new System.Windows.Forms.Label();
            this.lblTextDrop2 = new System.Windows.Forms.Label();
            this.lblTextDrop3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDnDQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextDrop1
            // 
            this.lblTextDrop1.AutoSize = true;
            this.lblTextDrop1.Location = new System.Drawing.Point(74, 91);
            this.lblTextDrop1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextDrop1.Name = "lblTextDrop1";
            this.lblTextDrop1.Size = new System.Drawing.Size(73, 15);
            this.lblTextDrop1.TabIndex = 0;
            this.lblTextDrop1.Text = "lblTextDrop1";
            this.lblTextDrop1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lblTextDrop2
            // 
            this.lblTextDrop2.AutoSize = true;
            this.lblTextDrop2.Location = new System.Drawing.Point(74, 179);
            this.lblTextDrop2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextDrop2.Name = "lblTextDrop2";
            this.lblTextDrop2.Size = new System.Drawing.Size(73, 15);
            this.lblTextDrop2.TabIndex = 1;
            this.lblTextDrop2.Text = "lblTextDrop2";
            this.lblTextDrop2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lblTextDrop3
            // 
            this.lblTextDrop3.AutoSize = true;
            this.lblTextDrop3.Location = new System.Drawing.Point(74, 290);
            this.lblTextDrop3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextDrop3.Name = "lblTextDrop3";
            this.lblTextDrop3.Size = new System.Drawing.Size(73, 15);
            this.lblTextDrop3.TabIndex = 2;
            this.lblTextDrop3.Text = "lblTextDrop3";
            this.lblTextDrop3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(368, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 45);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDropped);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(368, 166);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 45);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDropped);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(368, 277);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 45);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDropped);
            this.pictureBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // lblDnDQuestion
            // 
            this.lblDnDQuestion.AutoSize = true;
            this.lblDnDQuestion.Location = new System.Drawing.Point(234, 32);
            this.lblDnDQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDnDQuestion.Name = "lblDnDQuestion";
            this.lblDnDQuestion.Size = new System.Drawing.Size(91, 15);
            this.lblDnDQuestion.TabIndex = 7;
            this.lblDnDQuestion.Text = "lblDnDQuestion";
            // 
            // DnDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.lblDnDQuestion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTextDrop3);
            this.Controls.Add(this.lblTextDrop2);
            this.Controls.Add(this.lblTextDrop1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DnDForm";
            this.Text = "DnDForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextDrop1;
        private System.Windows.Forms.Label lblTextDrop2;
        private System.Windows.Forms.Label lblTextDrop3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDnDQuestion;
    }
}