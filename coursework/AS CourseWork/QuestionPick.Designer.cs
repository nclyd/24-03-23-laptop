
namespace AS_CourseWork
{
    partial class QuestionPick
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
            this.btnCompSci = new System.Windows.Forms.Button();
            this.btnDragAndDropPick = new System.Windows.Forms.Button();
            this.btnQuickfirePick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompSci
            // 
            this.btnCompSci.Location = new System.Drawing.Point(147, 400);
            this.btnCompSci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompSci.Name = "btnCompSci";
            this.btnCompSci.Size = new System.Drawing.Size(224, 38);
            this.btnCompSci.TabIndex = 0;
            this.btnCompSci.Text = "Computer Science";
            this.btnCompSci.UseVisualStyleBackColor = true;
            this.btnCompSci.Click += new System.EventHandler(this.btnMCQPick_Click);
            // 
            // btnDragAndDropPick
            // 
            this.btnDragAndDropPick.Location = new System.Drawing.Point(477, 400);
            this.btnDragAndDropPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDragAndDropPick.Name = "btnDragAndDropPick";
            this.btnDragAndDropPick.Size = new System.Drawing.Size(180, 38);
            this.btnDragAndDropPick.TabIndex = 1;
            this.btnDragAndDropPick.Text = "Drag and Drop";
            this.btnDragAndDropPick.UseVisualStyleBackColor = true;
            // 
            // btnQuickfirePick
            // 
            this.btnQuickfirePick.Location = new System.Drawing.Point(813, 400);
            this.btnQuickfirePick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuickfirePick.Name = "btnQuickfirePick";
            this.btnQuickfirePick.Size = new System.Drawing.Size(206, 38);
            this.btnQuickfirePick.TabIndex = 2;
            this.btnQuickfirePick.Text = "Quickfire";
            this.btnQuickfirePick.UseVisualStyleBackColor = true;
            // 
            // QuestionPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnQuickfirePick);
            this.Controls.Add(this.btnDragAndDropPick);
            this.Controls.Add(this.btnCompSci);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuestionPick";
            this.Text = "QuestionPick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompSci;
        private System.Windows.Forms.Button btnDragAndDropPick;
        private System.Windows.Forms.Button btnQuickfirePick;
    }
}