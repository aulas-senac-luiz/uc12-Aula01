
namespace uc12_Aula01
{
    partial class Inicio
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
            this.btnEscola = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscola
            // 
            this.btnEscola.Location = new System.Drawing.Point(104, 118);
            this.btnEscola.Name = "btnEscola";
            this.btnEscola.Size = new System.Drawing.Size(90, 63);
            this.btnEscola.TabIndex = 0;
            this.btnEscola.Text = "Escola";
            this.btnEscola.UseVisualStyleBackColor = true;
            this.btnEscola.Click += new System.EventHandler(this.btnEscola_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(312, 118);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(90, 63);
            this.btnPessoa.TabIndex = 1;
            this.btnPessoa.Text = "Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 321);
            this.Controls.Add(this.btnPessoa);
            this.Controls.Add(this.btnEscola);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEscola;
        private System.Windows.Forms.Button btnPessoa;
    }
}