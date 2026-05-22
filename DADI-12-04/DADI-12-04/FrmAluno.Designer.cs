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
            this.DgvAluno = new System.Windows.Forms.DataGridView();
            this.BtnAlunoPrimeiro = new System.Windows.Forms.Button();
            this.BtnAlunoUltimo = new System.Windows.Forms.Button();
            this.BtnAlunoAnterior = new System.Windows.Forms.Button();
            this.BtnAlunoProximo = new System.Windows.Forms.Button();
            this.BtnAlunoNovo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblAlunoCodigo = new System.Windows.Forms.Label();
            this.LblAlunoNome = new System.Windows.Forms.Label();
            this.TbAlunoCodigo = new System.Windows.Forms.TextBox();
            this.TbAlunoNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAluno
            // 
            this.DgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAluno.Location = new System.Drawing.Point(12, 12);
            this.DgvAluno.Name = "DgvAluno";
            this.DgvAluno.RowTemplate.Height = 24;
            this.DgvAluno.Size = new System.Drawing.Size(532, 278);
            this.DgvAluno.TabIndex = 0;
            // 
            // BtnAlunoPrimeiro
            // 
            this.BtnAlunoPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlunoPrimeiro.Location = new System.Drawing.Point(12, 337);
            this.BtnAlunoPrimeiro.Name = "BtnAlunoPrimeiro";
            this.BtnAlunoPrimeiro.Size = new System.Drawing.Size(100, 50);
            this.BtnAlunoPrimeiro.TabIndex = 1;
            this.BtnAlunoPrimeiro.Text = "|<";
            this.BtnAlunoPrimeiro.UseVisualStyleBackColor = true;
            // 
            // BtnAlunoUltimo
            // 
            this.BtnAlunoUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlunoUltimo.Location = new System.Drawing.Point(151, 337);
            this.BtnAlunoUltimo.Name = "BtnAlunoUltimo";
            this.BtnAlunoUltimo.Size = new System.Drawing.Size(100, 50);
            this.BtnAlunoUltimo.TabIndex = 2;
            this.BtnAlunoUltimo.Text = ">|";
            this.BtnAlunoUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnAlunoAnterior
            // 
            this.BtnAlunoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlunoAnterior.Location = new System.Drawing.Point(12, 426);
            this.BtnAlunoAnterior.Name = "BtnAlunoAnterior";
            this.BtnAlunoAnterior.Size = new System.Drawing.Size(100, 50);
            this.BtnAlunoAnterior.TabIndex = 3;
            this.BtnAlunoAnterior.Text = "<<";
            this.BtnAlunoAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnAlunoProximo
            // 
            this.BtnAlunoProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlunoProximo.Location = new System.Drawing.Point(151, 426);
            this.BtnAlunoProximo.Name = "BtnAlunoProximo";
            this.BtnAlunoProximo.Size = new System.Drawing.Size(100, 50);
            this.BtnAlunoProximo.TabIndex = 4;
            this.BtnAlunoProximo.Text = ">>";
            this.BtnAlunoProximo.UseVisualStyleBackColor = true;
            // 
            // BtnAlunoNovo
            // 
            this.BtnAlunoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlunoNovo.Location = new System.Drawing.Point(293, 337);
            this.BtnAlunoNovo.Name = "BtnAlunoNovo";
            this.BtnAlunoNovo.Size = new System.Drawing.Size(100, 50);
            this.BtnAlunoNovo.TabIndex = 5;
            this.BtnAlunoNovo.Text = "Novo";
            this.BtnAlunoNovo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(444, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(444, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LblAlunoCodigo
            // 
            this.LblAlunoCodigo.AutoSize = true;
            this.LblAlunoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlunoCodigo.Location = new System.Drawing.Point(12, 521);
            this.LblAlunoCodigo.Name = "LblAlunoCodigo";
            this.LblAlunoCodigo.Size = new System.Drawing.Size(81, 25);
            this.LblAlunoCodigo.TabIndex = 9;
            this.LblAlunoCodigo.Text = "Código:";
            // 
            // LblAlunoNome
            // 
            this.LblAlunoNome.AutoSize = true;
            this.LblAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlunoNome.Location = new System.Drawing.Point(146, 521);
            this.LblAlunoNome.Name = "LblAlunoNome";
            this.LblAlunoNome.Size = new System.Drawing.Size(70, 25);
            this.LblAlunoNome.TabIndex = 10;
            this.LblAlunoNome.Text = "Nome:";
            // 
            // TbAlunoCodigo
            // 
            this.TbAlunoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAlunoCodigo.Location = new System.Drawing.Point(17, 549);
            this.TbAlunoCodigo.Name = "TbAlunoCodigo";
            this.TbAlunoCodigo.Size = new System.Drawing.Size(76, 30);
            this.TbAlunoCodigo.TabIndex = 11;
            // 
            // TbAlunoNome
            // 
            this.TbAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAlunoNome.Location = new System.Drawing.Point(151, 549);
            this.TbAlunoNome.Name = "TbAlunoNome";
            this.TbAlunoNome.Size = new System.Drawing.Size(242, 30);
            this.TbAlunoNome.TabIndex = 12;
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 647);
            this.Controls.Add(this.TbAlunoNome);
            this.Controls.Add(this.TbAlunoCodigo);
            this.Controls.Add(this.LblAlunoNome);
            this.Controls.Add(this.LblAlunoCodigo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAlunoNovo);
            this.Controls.Add(this.BtnAlunoProximo);
            this.Controls.Add(this.BtnAlunoAnterior);
            this.Controls.Add(this.BtnAlunoUltimo);
            this.Controls.Add(this.BtnAlunoPrimeiro);
            this.Controls.Add(this.DgvAluno);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAluno";
            this.Text = "Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAluno;
        private System.Windows.Forms.Button BtnAlunoPrimeiro;
        private System.Windows.Forms.Button BtnAlunoUltimo;
        private System.Windows.Forms.Button BtnAlunoAnterior;
        private System.Windows.Forms.Button BtnAlunoProximo;
        private System.Windows.Forms.Button BtnAlunoNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblAlunoCodigo;
        private System.Windows.Forms.Label LblAlunoNome;
        private System.Windows.Forms.TextBox TbAlunoCodigo;
        private System.Windows.Forms.TextBox TbAlunoNome;
    }
}