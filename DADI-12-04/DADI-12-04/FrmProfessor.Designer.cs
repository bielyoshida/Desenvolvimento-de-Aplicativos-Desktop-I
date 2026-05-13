namespace DADI_12_04
{
    partial class FrmProfessor
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblAlunoIdade = new System.Windows.Forms.Label();
            this.TbProfessorNome = new System.Windows.Forms.TextBox();
            this.LblProfessorNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(59, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 53);
            this.textBox2.TabIndex = 8;
            // 
            // LblAlunoIdade
            // 
            this.LblAlunoIdade.AutoSize = true;
            this.LblAlunoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlunoIdade.Location = new System.Drawing.Point(53, 242);
            this.LblAlunoIdade.Name = "LblAlunoIdade";
            this.LblAlunoIdade.Size = new System.Drawing.Size(118, 46);
            this.LblAlunoIdade.TabIndex = 7;
            this.LblAlunoIdade.Text = "Idade";
            // 
            // TbProfessorNome
            // 
            this.TbProfessorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbProfessorNome.Location = new System.Drawing.Point(59, 147);
            this.TbProfessorNome.Name = "TbProfessorNome";
            this.TbProfessorNome.Size = new System.Drawing.Size(690, 53);
            this.TbProfessorNome.TabIndex = 6;
            // 
            // LblProfessorNome
            // 
            this.LblProfessorNome.AutoSize = true;
            this.LblProfessorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfessorNome.Location = new System.Drawing.Point(51, 98);
            this.LblProfessorNome.Name = "LblProfessorNome";
            this.LblProfessorNome.Size = new System.Drawing.Size(127, 46);
            this.LblProfessorNome.TabIndex = 5;
            this.LblProfessorNome.Text = "Nome";
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblAlunoIdade);
            this.Controls.Add(this.TbProfessorNome);
            this.Controls.Add(this.LblProfessorNome);
            this.Name = "FrmProfessor";
            this.Text = "Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblAlunoIdade;
        private System.Windows.Forms.TextBox TbProfessorNome;
        private System.Windows.Forms.Label LblProfessorNome;
    }
}