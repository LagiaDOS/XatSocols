namespace XatSocols
{
    partial class Form1
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
            this.textbox_missatge = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textboxXat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_missatge
            // 
            this.textbox_missatge.AccessibleName = "textboxMissatge";
            this.textbox_missatge.Location = new System.Drawing.Point(12, 404);
            this.textbox_missatge.Name = "textbox_missatge";
            this.textbox_missatge.Size = new System.Drawing.Size(100, 23);
            this.textbox_missatge.TabIndex = 1;
            this.textbox_missatge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(713, 403);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textboxXat
            // 
            this.textboxXat.AccessibleName = "textboxXat";
            this.textboxXat.Location = new System.Drawing.Point(12, 12);
            this.textboxXat.Multiline = true;
            this.textboxXat.Name = "textboxXat";
            this.textboxXat.Size = new System.Drawing.Size(776, 370);
            this.textboxXat.TabIndex = 0;
            this.textboxXat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textbox_missatge);
            this.Controls.Add(this.textboxXat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textbox_missatge;
        private Button btnEnviar;
        private TextBox textboxXat;
    }
}