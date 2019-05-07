namespace ApCalculadora
{
    partial class frmCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lbSequencias = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAbre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisor.Location = new System.Drawing.Point(13, 21);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(206, 20);
            this.txtVisor.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(13, 47);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(206, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // lbSequencias
            // 
            this.lbSequencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSequencias.AutoSize = true;
            this.lbSequencias.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSequencias.Location = new System.Drawing.Point(13, 74);
            this.lbSequencias.Name = "lbSequencias";
            this.lbSequencias.Size = new System.Drawing.Size(47, 17);
            this.lbSequencias.TabIndex = 2;
            this.lbSequencias.Text = "Pósfixa";
            // 
            // btnPotencia
            // 
            this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPotencia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(12, 118);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(47, 23);
            this.btnPotencia.TabIndex = 3;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDivisao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(65, 118);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(47, 23);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(118, 118);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(47, 23);
            this.btnMultiplicacao.TabIndex = 5;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubtracao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(171, 118);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(47, 23);
            this.btnSubtracao.TabIndex = 6;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 147);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(65, 147);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(118, 147);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnAdicao
            // 
            this.btnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(171, 147);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(47, 23);
            this.btnAdicao.TabIndex = 10;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 176);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 23);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(65, 176);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 23);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(118, 176);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 23);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecimal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(171, 176);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(47, 23);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 23);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(65, 205);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 23);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(118, 205);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 23);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnFecha
            // 
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha.Location = new System.Drawing.Point(171, 205);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(47, 23);
            this.btnFecha.TabIndex = 18;
            this.btnFecha.Text = ")";
            this.btnFecha.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn0.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 234);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(47, 23);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResultado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(65, 234);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(47, 23);
            this.btnResultado.TabIndex = 20;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApagar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(118, 234);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(47, 23);
            this.btnApagar.TabIndex = 21;
            this.btnApagar.Text = "C";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAbre
            // 
            this.btnAbre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbre.Location = new System.Drawing.Point(171, 234);
            this.btnAbre.Name = "btnAbre";
            this.btnAbre.Size = new System.Drawing.Size(47, 23);
            this.btnAbre.TabIndex = 22;
            this.btnAbre.Text = "(";
            this.btnAbre.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(231, 277);
            this.Controls.Add(this.btnAbre);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.lbSequencias);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtVisor);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lbSequencias;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAbre;
    }
}

