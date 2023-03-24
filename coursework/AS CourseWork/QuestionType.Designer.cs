
namespace AS_CourseWork
{
    partial class QuestionType
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
            this.cBoxDiff = new System.Windows.Forms.ComboBox();
            this.cBoxQType = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxDiff
            // 
            this.cBoxDiff.FormattingEnabled = true;
            this.cBoxDiff.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cBoxDiff.Location = new System.Drawing.Point(153, 392);
            this.cBoxDiff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxDiff.Name = "cBoxDiff";
            this.cBoxDiff.Size = new System.Drawing.Size(171, 33);
            this.cBoxDiff.TabIndex = 0;
            // 
            // cBoxQType
            // 
            this.cBoxQType.FormattingEnabled = true;
            this.cBoxQType.Items.AddRange(new object[] {
            "Comp Sci"});
            this.cBoxQType.Location = new System.Drawing.Point(787, 392);
            this.cBoxQType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxQType.Name = "cBoxQType";
            this.cBoxQType.Size = new System.Drawing.Size(171, 33);
            this.cBoxQType.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(494, 552);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 38);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // QuestionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cBoxQType);
            this.Controls.Add(this.cBoxDiff);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuestionType";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxDiff;
        private System.Windows.Forms.ComboBox cBoxQType;
        private System.Windows.Forms.Button btnConfirm;
    }
}