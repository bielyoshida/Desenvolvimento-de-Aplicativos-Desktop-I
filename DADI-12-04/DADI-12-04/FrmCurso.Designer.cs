namespace DADI_12_04
{
    partial class FrmCurso
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
            this.TbCursoCodigo = new System.Windows.Forms.TextBox();
            this.LblCursoCodigo = new System.Windows.Forms.Label();
            this.TbCursoNome = new System.Windows.Forms.TextBox();
            this.LblCursoNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbCursoCodigo
            // 
            this.TbCursoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCursoCodigo.Location = new System.Drawing.Point(98, 239);
            this.TbCursoCodigo.Name = "TbCursoCodigo";
            this.TbCursoCodigo.Size = new System.Drawing.Size(100, 53);
            this.TbCursoCodigo.TabIndex = 8;
            // 
            // LblCursoCodigo
            // 
            this.LblCursoCodigo.AutoSize = true;
            this.LblCursoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCursoCodigo.Location = new System.Drawing.Point(90, 190);
            this.LblCursoCodigo.Name = "LblCursoCodigo";
            this.LblCursoCodigo.Size = new System.Drawing.Size(314, 46);
            this.LblCursoCodigo.TabIndex = 7;
            this.LblCursoCodigo.Text = "Código do curso";
            // 
            // TbCursoNome
            // 
            this.TbCursoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCursoNome.Location = new System.Drawing.Point(98, 119);
            this.TbCursoNome.Name = "TbCursoNome";
            this.TbCursoNome.Size = new System.Drawing.Size(343, 53);
            this.TbCursoNome.TabIndex = 6;
            // 
            // LblCursoNome
            // 
            this.LblCursoNome.AutoSize = true;
            this.LblCursoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCursoNome.Location = new System.Drawing.Point(90, 70);
            this.LblCursoNome.Name = "LblCursoNome";
            this.LblCursoNome.Size = new System.Drawing.Size(293, 46);
            this.LblCursoNome.TabIndex = 5;
            this.LblCursoNome.Text = "Nome do curso";
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbCursoCodigo);
            this.Controls.Add(this.LblCursoCodigo);
            this.Controls.Add(this.TbCursoNome);
            this.Controls.Add(this.LblCursoNome);
            this.Name = "FrmCurso";
            this.Text = "Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbCursoCodigo;
        private System.Windows.Forms.Label LblCursoCodigo;
        private System.Windows.Forms.TextBox TbCursoNome;
        private System.Windows.Forms.Label LblCursoNome;
    }
}