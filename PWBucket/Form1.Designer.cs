
namespace PWBucket
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TBPasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(354, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "PasswordBox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(465, 522);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(203, 85);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // TBPasswordInput
            // 
            this.TBPasswordInput.AccessibleDescription = "";
            this.TBPasswordInput.AccessibleName = "";
            this.TBPasswordInput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TBPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TBPasswordInput.Location = new System.Drawing.Point(383, 329);
            this.TBPasswordInput.Name = "TBPasswordInput";
            this.TBPasswordInput.PasswordChar = '*';
            this.TBPasswordInput.Size = new System.Drawing.Size(376, 53);
            this.TBPasswordInput.TabIndex = 2;
            this.TBPasswordInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1166, 771);
            this.Controls.Add(this.TBPasswordInput);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox TBPasswordInput;
    }
}

