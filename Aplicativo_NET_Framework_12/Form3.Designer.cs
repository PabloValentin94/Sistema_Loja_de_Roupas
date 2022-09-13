namespace Aplicativo_NET_Framework_12
{
    partial class frm_legenda
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
            this.lbl_vermelho = new System.Windows.Forms.Label();
            this.lbl_cinza = new System.Windows.Forms.Label();
            this.lbl_verde = new System.Windows.Forms.Label();
            this.lbl_cinza_descricao = new System.Windows.Forms.Label();
            this.lbl_verde_descricao = new System.Windows.Forms.Label();
            this.lbl_vermelho_descricao = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vermelho
            // 
            this.lbl_vermelho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_vermelho.AutoSize = true;
            this.lbl_vermelho.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_vermelho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vermelho.ForeColor = System.Drawing.Color.White;
            this.lbl_vermelho.Location = new System.Drawing.Point(21, 39);
            this.lbl_vermelho.Name = "lbl_vermelho";
            this.lbl_vermelho.Size = new System.Drawing.Size(87, 19);
            this.lbl_vermelho.TabIndex = 0;
            this.lbl_vermelho.Text = "Vermelho:";
            // 
            // lbl_cinza
            // 
            this.lbl_cinza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cinza.AutoSize = true;
            this.lbl_cinza.BackColor = System.Drawing.Color.DimGray;
            this.lbl_cinza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinza.ForeColor = System.Drawing.Color.White;
            this.lbl_cinza.Location = new System.Drawing.Point(49, 90);
            this.lbl_cinza.Name = "lbl_cinza";
            this.lbl_cinza.Size = new System.Drawing.Size(59, 19);
            this.lbl_cinza.TabIndex = 1;
            this.lbl_cinza.Text = "Cinza:";
            // 
            // lbl_verde
            // 
            this.lbl_verde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_verde.AutoSize = true;
            this.lbl_verde.BackColor = System.Drawing.Color.DarkGreen;
            this.lbl_verde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verde.ForeColor = System.Drawing.Color.White;
            this.lbl_verde.Location = new System.Drawing.Point(49, 136);
            this.lbl_verde.Name = "lbl_verde";
            this.lbl_verde.Size = new System.Drawing.Size(59, 19);
            this.lbl_verde.TabIndex = 2;
            this.lbl_verde.Text = "Verde:";
            // 
            // lbl_cinza_descricao
            // 
            this.lbl_cinza_descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cinza_descricao.AutoSize = true;
            this.lbl_cinza_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinza_descricao.Location = new System.Drawing.Point(114, 90);
            this.lbl_cinza_descricao.Name = "lbl_cinza_descricao";
            this.lbl_cinza_descricao.Size = new System.Drawing.Size(283, 19);
            this.lbl_cinza_descricao.TabIndex = 5;
            this.lbl_cinza_descricao.Text = "preço de venda e de compra, iguais.";
            // 
            // lbl_verde_descricao
            // 
            this.lbl_verde_descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_verde_descricao.AutoSize = true;
            this.lbl_verde_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verde_descricao.Location = new System.Drawing.Point(114, 136);
            this.lbl_verde_descricao.Name = "lbl_verde_descricao";
            this.lbl_verde_descricao.Size = new System.Drawing.Size(314, 19);
            this.lbl_verde_descricao.TabIndex = 4;
            this.lbl_verde_descricao.Text = "preço de venda, maior que o de compra.";
            // 
            // lbl_vermelho_descricao
            // 
            this.lbl_vermelho_descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_vermelho_descricao.AutoSize = true;
            this.lbl_vermelho_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vermelho_descricao.Location = new System.Drawing.Point(114, 39);
            this.lbl_vermelho_descricao.Name = "lbl_vermelho_descricao";
            this.lbl_vermelho_descricao.Size = new System.Drawing.Size(314, 19);
            this.lbl_vermelho_descricao.TabIndex = 3;
            this.lbl_vermelho_descricao.Text = "preço de compra, maior que o de venda.";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.BackColor = System.Drawing.Color.Purple;
            this.btn_fechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(188, 200);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(78, 35);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // frm_legenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lbl_cinza_descricao);
            this.Controls.Add(this.lbl_verde_descricao);
            this.Controls.Add(this.lbl_vermelho_descricao);
            this.Controls.Add(this.lbl_verde);
            this.Controls.Add(this.lbl_cinza);
            this.Controls.Add(this.lbl_vermelho);
            this.Name = "frm_legenda";
            this.Text = "Sistema: Loja de Roupas - Legenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vermelho;
        private System.Windows.Forms.Label lbl_cinza;
        private System.Windows.Forms.Label lbl_verde;
        private System.Windows.Forms.Label lbl_cinza_descricao;
        private System.Windows.Forms.Label lbl_verde_descricao;
        private System.Windows.Forms.Label lbl_vermelho_descricao;
        private System.Windows.Forms.Button btn_fechar;
    }
}