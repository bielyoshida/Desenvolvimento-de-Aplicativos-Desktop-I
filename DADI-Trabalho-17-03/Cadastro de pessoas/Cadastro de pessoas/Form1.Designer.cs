namespace Cadastro_de_pessoas
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNome = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbIdade = new System.Windows.Forms.TextBox();
            this.LblIdade = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LbLista = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnListar = new System.Windows.Forms.Button();
            this.LblLista = new System.Windows.Forms.Label();
            this.TlpMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(776, 75);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "CADASTRO DE PESSOAS";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 2;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.Controls.Add(this.panel2, 1, 0);
            this.TlpMain.Controls.Add(this.panel1, 0, 0);
            this.TlpMain.Location = new System.Drawing.Point(12, 87);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 1;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.Size = new System.Drawing.Size(776, 351);
            this.TlpMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Controls.Add(this.TbIdade);
            this.panel1.Controls.Add(this.LblIdade);
            this.panel1.Controls.Add(this.TbNome);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 345);
            this.panel1.TabIndex = 0;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(153, 39);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(86, 31);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // TbNome
            // 
            this.TbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNome.Location = new System.Drawing.Point(58, 73);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(291, 38);
            this.TbNome.TabIndex = 1;
            this.TbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TbIdade
            // 
            this.TbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdade.Location = new System.Drawing.Point(139, 163);
            this.TbIdade.Name = "TbIdade";
            this.TbIdade.Size = new System.Drawing.Size(100, 38);
            this.TbIdade.TabIndex = 3;
            this.TbIdade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdade.Location = new System.Drawing.Point(148, 129);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(82, 31);
            this.LblIdade.TabIndex = 2;
            this.LblIdade.Text = "Idade";
            this.LblIdade.Click += new System.EventHandler(this.LblIdade_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(139, 218);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(109, 32);
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LbLista
            // 
            this.LbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLista.FormattingEnabled = true;
            this.LbLista.ItemHeight = 25;
            this.LbLista.Location = new System.Drawing.Point(45, 73);
            this.LbLista.Name = "LbLista";
            this.LbLista.Size = new System.Drawing.Size(287, 179);
            this.LbLista.TabIndex = 5;
            this.LbLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblLista);
            this.panel2.Controls.Add(this.BtnListar);
            this.panel2.Controls.Add(this.LbLista);
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 345);
            this.panel2.TabIndex = 6;
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(148, 292);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(80, 32);
            this.BtnListar.TabIndex = 7;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLista.Location = new System.Drawing.Point(142, 27);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(72, 31);
            this.LblLista.TabIndex = 8;
            this.LblLista.Text = "Lista";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TlpMain);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.TlpMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TbIdade;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox LbLista;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnListar;
    }
}

