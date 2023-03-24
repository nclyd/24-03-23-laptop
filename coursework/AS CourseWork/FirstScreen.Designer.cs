
namespace AS_CourseWork
{
    partial class FirstScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTakeToCreate = new System.Windows.Forms.Button();
            this.btnTakeToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTakeToCreate
            // 
            this.btnTakeToCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakeToCreate.Location = new System.Drawing.Point(160, 184);
            this.btnTakeToCreate.Name = "btnTakeToCreate";
            this.btnTakeToCreate.Size = new System.Drawing.Size(107, 80);
            this.btnTakeToCreate.TabIndex = 0;
            this.btnTakeToCreate.Text = "Create Account";
            this.btnTakeToCreate.UseVisualStyleBackColor = true;
            this.btnTakeToCreate.Click += new System.EventHandler(this.btnTakeToCreate_Click);
            // 
            // btnTakeToLogin
            // 
            this.btnTakeToLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakeToLogin.Location = new System.Drawing.Point(459, 184);
            this.btnTakeToLogin.Name = "btnTakeToLogin";
            this.btnTakeToLogin.Size = new System.Drawing.Size(103, 80);
            this.btnTakeToLogin.TabIndex = 1;
            this.btnTakeToLogin.Text = "Login";
            this.btnTakeToLogin.UseVisualStyleBackColor = true;
            this.btnTakeToLogin.Click += new System.EventHandler(this.btnTakeToLogin_Click);
            // 
            // FirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.btnTakeToLogin);
            this.Controls.Add(this.btnTakeToCreate);
            this.Name = "FirstScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakeToCreate;
        private System.Windows.Forms.Button btnTakeToLogin;
    }
}

