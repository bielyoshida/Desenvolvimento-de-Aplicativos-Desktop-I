namespace Conversor_de_temperatura
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.PnlFahrenheit = new System.Windows.Forms.Panel();
            this.LblFahrenheit = new System.Windows.Forms.Label();
            this.TbFahrenheit = new System.Windows.Forms.TextBox();
            this.PnlCelsius = new System.Windows.Forms.Panel();
            this.TbCeusius = new System.Windows.Forms.TextBox();
            this.LblCeusius = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TlpMain.SuspendLayout();
            this.PnlFahrenheit.SuspendLayout();
            this.PnlCelsius.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TlpMain
            // 
            this.TlpMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TlpMain.ColumnCount = 5;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Controls.Add(this.PnlFahrenheit, 3, 0);
            this.TlpMain.Controls.Add(this.PnlCelsius, 1, 0);
            this.TlpMain.Controls.Add(this.BtnCalcular, 2, 1);
            this.TlpMain.Controls.Add(this.BtnSair, 4, 1);
            this.TlpMain.Location = new System.Drawing.Point(12, 108);
            this.TlpMain.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 2;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.Size = new System.Drawing.Size(776, 330);
            this.TlpMain.TabIndex = 0;
            // 
            // PnlFahrenheit
            // 
            this.PnlFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlFahrenheit.Controls.Add(this.LblFahrenheit);
            this.PnlFahrenheit.Controls.Add(this.TbFahrenheit);
            this.PnlFahrenheit.Location = new System.Drawing.Point(468, 88);
            this.PnlFahrenheit.Name = "PnlFahrenheit";
            this.PnlFahrenheit.Size = new System.Drawing.Size(149, 74);
            this.PnlFahrenheit.TabIndex = 1;
            // 
            // LblFahrenheit
            // 
            this.LblFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFahrenheit.Location = new System.Drawing.Point(0, 0);
            this.LblFahrenheit.Name = "LblFahrenheit";
            this.LblFahrenheit.Size = new System.Drawing.Size(146, 30);
            this.LblFahrenheit.TabIndex = 3;
            this.LblFahrenheit.Text = "Fahrenheit";
            this.LblFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFahrenheit.Click += new System.EventHandler(this.LblFahrenheit_Click_1);
            // 
            // TbFahrenheit
            // 
            this.TbFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFahrenheit.Location = new System.Drawing.Point(6, 33);
            this.TbFahrenheit.Name = "TbFahrenheit";
            this.TbFahrenheit.Size = new System.Drawing.Size(79, 38);
            this.TbFahrenheit.TabIndex = 3;
            this.TbFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PnlCelsius
            // 
            this.PnlCelsius.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlCelsius.Controls.Add(this.TbCeusius);
            this.PnlCelsius.Controls.Add(this.LblCeusius);
            this.PnlCelsius.Location = new System.Drawing.Point(158, 88);
            this.PnlCelsius.Name = "PnlCelsius";
            this.PnlCelsius.Size = new System.Drawing.Size(149, 74);
            this.PnlCelsius.TabIndex = 0;
            // 
            // TbCeusius
            // 
            this.TbCeusius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbCeusius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCeusius.Location = new System.Drawing.Point(9, 33);
            this.TbCeusius.Name = "TbCeusius";
            this.TbCeusius.Size = new System.Drawing.Size(79, 38);
            this.TbCeusius.TabIndex = 4;
            this.TbCeusius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbCeusius.TextChanged += new System.EventHandler(this.TbCeusius_TextChanged);
            // 
            // LblCeusius
            // 
            this.LblCeusius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCeusius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCeusius.Location = new System.Drawing.Point(3, 0);
            this.LblCeusius.Name = "LblCeusius";
            this.LblCeusius.Size = new System.Drawing.Size(146, 30);
            this.LblCeusius.TabIndex = 2;
            this.LblCeusius.Text = "Ceusius";
            this.LblCeusius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCeusius.Click += new System.EventHandler(this.LblCeusius_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCalcular.AutoSize = true;
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(350, 168);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 27);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.AutoSize = true;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(698, 300);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 27);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 12);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(776, 89);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Conversor Celsius para Fahrenheit";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitulo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TlpMain);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.PnlFahrenheit.ResumeLayout(false);
            this.PnlFahrenheit.PerformLayout();
            this.PnlCelsius.ResumeLayout(false);
            this.PnlCelsius.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlFahrenheit;
        private System.Windows.Forms.Panel PnlCelsius;
        private System.Windows.Forms.Label LblFahrenheit;
        private System.Windows.Forms.Label LblCeusius;
        private System.Windows.Forms.TextBox TbFahrenheit;
        private System.Windows.Forms.TextBox TbCeusius;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
    }
}

