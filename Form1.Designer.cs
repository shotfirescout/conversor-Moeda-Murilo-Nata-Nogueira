namespace conversor_Moeda
{
    partial class Form1
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
            this.textValorMoeda = new System.Windows.Forms.TextBox();
            this.comboMoedaOrigem = new System.Windows.Forms.ComboBox();
            this.comboMoedaDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCoverter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.resultadoConvercao = new System.Windows.Forms.Label();
            this.tipoMoedaResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textValorMoeda
            // 
            this.textValorMoeda.Location = new System.Drawing.Point(145, 162);
            this.textValorMoeda.Name = "textValorMoeda";
            this.textValorMoeda.Size = new System.Drawing.Size(166, 22);
            this.textValorMoeda.TabIndex = 0;
            // 
            // comboMoedaOrigem
            // 
            this.comboMoedaOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoedaOrigem.FormattingEnabled = true;
            this.comboMoedaOrigem.Items.AddRange(new object[] {
            "BRL",
            "EUR",
            "USD"});
            this.comboMoedaOrigem.Location = new System.Drawing.Point(11, 78);
            this.comboMoedaOrigem.Name = "comboMoedaOrigem";
            this.comboMoedaOrigem.Size = new System.Drawing.Size(121, 24);
            this.comboMoedaOrigem.TabIndex = 1;
            // 
            // comboMoedaDestino
            // 
            this.comboMoedaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoedaDestino.FormattingEnabled = true;
            this.comboMoedaDestino.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "BRL"});
            this.comboMoedaDestino.Location = new System.Drawing.Point(315, 78);
            this.comboMoedaDestino.Name = "comboMoedaDestino";
            this.comboMoedaDestino.Size = new System.Drawing.Size(121, 24);
            this.comboMoedaDestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "valor da moeda de origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moeda Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moeda Destino";
            // 
            // btnCoverter
            // 
            this.btnCoverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoverter.Location = new System.Drawing.Point(75, 217);
            this.btnCoverter.Name = "btnCoverter";
            this.btnCoverter.Size = new System.Drawing.Size(141, 41);
            this.btnCoverter.TabIndex = 6;
            this.btnCoverter.Text = "Converter";
            this.btnCoverter.UseVisualStyleBackColor = true;
            this.btnCoverter.Click += new System.EventHandler(this.btnCoverter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Converter para";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Convertido:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(245, 217);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 41);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // resultadoConvercao
            // 
            this.resultadoConvercao.AutoSize = true;
            this.resultadoConvercao.Location = new System.Drawing.Point(137, 279);
            this.resultadoConvercao.Name = "resultadoConvercao";
            this.resultadoConvercao.Size = new System.Drawing.Size(31, 16);
            this.resultadoConvercao.TabIndex = 10;
            this.resultadoConvercao.Text = "0.00";
            // 
            // tipoMoedaResultado
            // 
            this.tipoMoedaResultado.AutoSize = true;
            this.tipoMoedaResultado.Location = new System.Drawing.Point(107, 279);
            this.tipoMoedaResultado.Name = "tipoMoedaResultado";
            this.tipoMoedaResultado.Size = new System.Drawing.Size(24, 16);
            this.tipoMoedaResultado.TabIndex = 11;
            this.tipoMoedaResultado.Text = "R$";
            this.tipoMoedaResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.tipoMoedaResultado);
            this.Controls.Add(this.resultadoConvercao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCoverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMoedaDestino);
            this.Controls.Add(this.comboMoedaOrigem);
            this.Controls.Add(this.textValorMoeda);
            this.Name = "Form1";
            this.Text = "Conversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValorMoeda;
        private System.Windows.Forms.ComboBox comboMoedaOrigem;
        private System.Windows.Forms.ComboBox comboMoedaDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCoverter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label resultadoConvercao;
        private System.Windows.Forms.Label tipoMoedaResultado;
    }
}

