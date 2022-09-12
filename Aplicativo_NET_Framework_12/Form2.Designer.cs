namespace Aplicativo_NET_Framework_12
{
    partial class frm_informacoes
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
            this.lbl_gastos = new System.Windows.Forms.Label();
            this.lbl_lucro = new System.Windows.Forms.Label();
            this.lbl_quantia_liquida = new System.Windows.Forms.Label();
            this.lbl_gastos_resultado = new System.Windows.Forms.Label();
            this.lbl_lucro_resultado = new System.Windows.Forms.Label();
            this.lbl_quantia_liquida_resultado = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gastos
            // 
            this.lbl_gastos.AutoSize = true;
            this.lbl_gastos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gastos.ForeColor = System.Drawing.Color.Red;
            this.lbl_gastos.Location = new System.Drawing.Point(47, 46);
            this.lbl_gastos.Name = "lbl_gastos";
            this.lbl_gastos.Size = new System.Drawing.Size(92, 27);
            this.lbl_gastos.TabIndex = 0;
            this.lbl_gastos.Text = "Gastos:";
            // 
            // lbl_lucro
            // 
            this.lbl_lucro.AutoSize = true;
            this.lbl_lucro.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lucro.ForeColor = System.Drawing.Color.Green;
            this.lbl_lucro.Location = new System.Drawing.Point(47, 105);
            this.lbl_lucro.Name = "lbl_lucro";
            this.lbl_lucro.Size = new System.Drawing.Size(78, 27);
            this.lbl_lucro.TabIndex = 1;
            this.lbl_lucro.Text = "Lucro:";
            // 
            // lbl_quantia_liquida
            // 
            this.lbl_quantia_liquida.AutoSize = true;
            this.lbl_quantia_liquida.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantia_liquida.ForeColor = System.Drawing.Color.Blue;
            this.lbl_quantia_liquida.Location = new System.Drawing.Point(47, 161);
            this.lbl_quantia_liquida.Name = "lbl_quantia_liquida";
            this.lbl_quantia_liquida.Size = new System.Drawing.Size(95, 54);
            this.lbl_quantia_liquida.TabIndex = 2;
            this.lbl_quantia_liquida.Text = "Quantia\r\nLíquida:";
            // 
            // lbl_gastos_resultado
            // 
            this.lbl_gastos_resultado.AutoSize = true;
            this.lbl_gastos_resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gastos_resultado.Location = new System.Drawing.Point(228, 51);
            this.lbl_gastos_resultado.Name = "lbl_gastos_resultado";
            this.lbl_gastos_resultado.Size = new System.Drawing.Size(73, 22);
            this.lbl_gastos_resultado.TabIndex = 3;
            this.lbl_gastos_resultado.Text = "R$0,00";
            // 
            // lbl_lucro_resultado
            // 
            this.lbl_lucro_resultado.AutoSize = true;
            this.lbl_lucro_resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lucro_resultado.Location = new System.Drawing.Point(228, 108);
            this.lbl_lucro_resultado.Name = "lbl_lucro_resultado";
            this.lbl_lucro_resultado.Size = new System.Drawing.Size(73, 22);
            this.lbl_lucro_resultado.TabIndex = 4;
            this.lbl_lucro_resultado.Text = "R$0,00";
            // 
            // lbl_quantia_liquida_resultado
            // 
            this.lbl_quantia_liquida_resultado.AutoSize = true;
            this.lbl_quantia_liquida_resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantia_liquida_resultado.Location = new System.Drawing.Point(228, 178);
            this.lbl_quantia_liquida_resultado.Name = "lbl_quantia_liquida_resultado";
            this.lbl_quantia_liquida_resultado.Size = new System.Drawing.Size(73, 22);
            this.lbl_quantia_liquida_resultado.TabIndex = 5;
            this.lbl_quantia_liquida_resultado.Text = "R$0,00";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Purple;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(142, 265);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(78, 35);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_informacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_quantia_liquida_resultado);
            this.Controls.Add(this.lbl_lucro_resultado);
            this.Controls.Add(this.lbl_gastos_resultado);
            this.Controls.Add(this.lbl_quantia_liquida);
            this.Controls.Add(this.lbl_lucro);
            this.Controls.Add(this.lbl_gastos);
            this.Name = "frm_informacoes";
            this.Text = "Sistema: Loja de Roupas - Informações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gastos;
        private System.Windows.Forms.Label lbl_lucro;
        private System.Windows.Forms.Label lbl_quantia_liquida;
        private System.Windows.Forms.Label lbl_gastos_resultado;
        private System.Windows.Forms.Label lbl_lucro_resultado;
        private System.Windows.Forms.Label lbl_quantia_liquida_resultado;
        private System.Windows.Forms.Button btn_voltar;
    }
}