namespace DADI_12_04
{
    partial class FrmAluno
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
            this.LblAlunoNome = new System.Windows.Forms.Label();
            this.TbAlunoNome = new System.Windows.Forms.TextBox();
            this.TbAlunoIdade = new System.Windows.Forms.TextBox();
            this.LblAlunoIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAlunoNome
            // 
            this.LblAlunoNome.AutoSize = true;
            this.LblAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlunoNome.Location = new System.Drawing.Point(44, 68);
            this.LblAlunoNome.Name = "LblAlunoNome";
            this.LblAlunoNome.Size = new System.Drawing.Size(127, 46);
            this.LblAlunoNome.TabIndex = 0;
            this.LblAlunoNome.Text = "Nome";
            // 
            // TbAlunoNome
            // 
            this.TbAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAlunoNome.Location = new System.Drawing.Point(52, 117);
            this.TbAlunoNome.Name = "TbAlunoNome";
            this.TbAlunoNome.Size = new System.Drawing.Size(690, 53);
            this.TbAlunoNome.TabIndex = 2;
            // 
            // TbAlunoIdade
            // 
            this.TbAlunoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAlunoIdade.Location = new System.Drawing.Point(52, 270);
            this.TbAlunoIdade.Name = "TbAlunoIdade";
            this.TbAlunoIdade.Size = new System.Drawing.Size(100, 53);
            this.TbAlunoIdade.TabIndex = 4;
            // 
            // LblAlunoIdade
            // 
            this.LblAlunoIdade.AutoSize = true;
            this.LblAlunoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlunoIdade.Location = new System.Drawing.Point(46, 212);
            this.LblAlunoIdade.Name = "LblAlunoIdade";
            this.LblAlunoIdade.Size = new System.Drawing.Size(118, 46);
            this.LblAlunoIdade.TabIndex = 3;
            this.LblAlunoIdade.Text = "Idade";
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbAlunoIdade);
            this.Controls.Add(this.LblAlunoIdade);
            this.Controls.Add(this.TbAlunoNome);
            this.Controls.Add(this.LblAlunoNome);
            this.Name = "FrmAluno";
            this.Text = "Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAlunoNome;
        private System.Windows.Forms.TextBox TbAlunoNome;
        private System.Windows.Forms.TextBox TbAlunoIdade;
        private System.Windows.Forms.Label LblAlunoIdade;
    }
}