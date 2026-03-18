using System;

namespace projeto_1
{
    partial class FrmPrincipal
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
            this.lblTítulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtbValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbValor2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.bntMultiplicar = new System.Windows.Forms.Button();
            this.bntSubtrair = new System.Windows.Forms.Button();
            this.bntDividir = new System.Windows.Forms.Button();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(332, 9);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(142, 29);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Calculadora";
            this.lblTítulo.Click += new System.EventHandler(this.lblTítulo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(713, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtbValor1
            // 
            this.txtbValor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbValor1.Location = new System.Drawing.Point(65, 169);
            this.txtbValor1.Name = "txtbValor1";
            this.txtbValor1.Size = new System.Drawing.Size(55, 23);
            this.txtbValor1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbValor2
            // 
            this.txtbValor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbValor2.Location = new System.Drawing.Point(65, 238);
            this.txtbValor2.Name = "txtbValor2";
            this.txtbValor2.Size = new System.Drawing.Size(55, 23);
            this.txtbValor2.TabIndex = 4;
            // 
            // btnSoma
            // 
            this.btnSoma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(223, 169);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(31, 31);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // bntMultiplicar
            // 
            this.bntMultiplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMultiplicar.Location = new System.Drawing.Point(223, 204);
            this.bntMultiplicar.Name = "bntMultiplicar";
            this.bntMultiplicar.Size = new System.Drawing.Size(31, 31);
            this.bntMultiplicar.TabIndex = 7;
            this.bntMultiplicar.Text = "x";
            this.bntMultiplicar.UseVisualStyleBackColor = true;
            this.bntMultiplicar.Click += new System.EventHandler(this.bntMultiplicar_Click);
            // 
            // bntSubtrair
            // 
            this.bntSubtrair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSubtrair.Location = new System.Drawing.Point(260, 169);
            this.bntSubtrair.Name = "bntSubtrair";
            this.bntSubtrair.Size = new System.Drawing.Size(31, 31);
            this.bntSubtrair.TabIndex = 8;
            this.bntSubtrair.Text = "-";
            this.bntSubtrair.UseVisualStyleBackColor = true;
            this.bntSubtrair.Click += new System.EventHandler(this.bntSubtrair_Click);
            // 
            // bntDividir
            // 
            this.bntDividir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDividir.Location = new System.Drawing.Point(260, 206);
            this.bntDividir.Name = "bntDividir";
            this.bntDividir.Size = new System.Drawing.Size(31, 31);
            this.bntDividir.TabIndex = 9;
            this.bntDividir.Text = "/";
            this.bntDividir.UseVisualStyleBackColor = true;
            this.bntDividir.Click += new System.EventHandler(this.bntDividir_Click);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(387, 173);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(132, 62);
            this.pnlTotal.TabIndex = 10;
            this.pnlTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(53, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.bntDividir);
            this.Controls.Add(this.bntSubtrair);
            this.Controls.Add(this.bntMultiplicar);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbValor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbValor1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTítulo);
            this.Name = "FrmPrincipal";
            this.Text = "Teste";
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtbValor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbValor2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button bntMultiplicar;
        private System.Windows.Forms.Button bntSubtrair;
        private System.Windows.Forms.Button bntDividir;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

