namespace Aplicativo_NET_Framework_12
{
    partial class frm_sistema_loja_de_roupas
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
            this.btn_importar_arquivo = new System.Windows.Forms.Button();
            this.btn_marcar_todos = new System.Windows.Forms.Button();
            this.btn_desmarcar_todos = new System.Windows.Forms.Button();
            this.btn_aplicar_percentual = new System.Windows.Forms.Button();
            this.btn_excluir_itens_selecionados = new System.Windows.Forms.Button();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.lbl_percentual = new System.Windows.Forms.Label();
            this.nup_percentual = new System.Windows.Forms.NumericUpDown();
            this.btn_informacoes = new System.Windows.Forms.Button();
            this.btn_legenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_percentual)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_importar_arquivo
            // 
            this.btn_importar_arquivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_importar_arquivo.BackColor = System.Drawing.Color.Orange;
            this.btn_importar_arquivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importar_arquivo.ForeColor = System.Drawing.Color.White;
            this.btn_importar_arquivo.Location = new System.Drawing.Point(12, 12);
            this.btn_importar_arquivo.Name = "btn_importar_arquivo";
            this.btn_importar_arquivo.Size = new System.Drawing.Size(174, 35);
            this.btn_importar_arquivo.TabIndex = 0;
            this.btn_importar_arquivo.Text = "Importar Arquivo";
            this.btn_importar_arquivo.UseVisualStyleBackColor = false;
            this.btn_importar_arquivo.Click += new System.EventHandler(this.btn_importar_arquivo_Click);
            // 
            // btn_marcar_todos
            // 
            this.btn_marcar_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_marcar_todos.BackColor = System.Drawing.Color.Magenta;
            this.btn_marcar_todos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcar_todos.ForeColor = System.Drawing.Color.White;
            this.btn_marcar_todos.Location = new System.Drawing.Point(434, 12);
            this.btn_marcar_todos.Name = "btn_marcar_todos";
            this.btn_marcar_todos.Size = new System.Drawing.Size(174, 35);
            this.btn_marcar_todos.TabIndex = 1;
            this.btn_marcar_todos.Text = "Marcar Todos";
            this.btn_marcar_todos.UseVisualStyleBackColor = false;
            this.btn_marcar_todos.Click += new System.EventHandler(this.btn_marcar_todos_Click);
            // 
            // btn_desmarcar_todos
            // 
            this.btn_desmarcar_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_desmarcar_todos.BackColor = System.Drawing.Color.Purple;
            this.btn_desmarcar_todos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcar_todos.ForeColor = System.Drawing.Color.White;
            this.btn_desmarcar_todos.Location = new System.Drawing.Point(614, 12);
            this.btn_desmarcar_todos.Name = "btn_desmarcar_todos";
            this.btn_desmarcar_todos.Size = new System.Drawing.Size(174, 35);
            this.btn_desmarcar_todos.TabIndex = 2;
            this.btn_desmarcar_todos.Text = "Desmarcar Todos";
            this.btn_desmarcar_todos.UseVisualStyleBackColor = false;
            this.btn_desmarcar_todos.Click += new System.EventHandler(this.btn_desmarcar_todos_Click);
            // 
            // btn_aplicar_percentual
            // 
            this.btn_aplicar_percentual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aplicar_percentual.BackColor = System.Drawing.Color.Green;
            this.btn_aplicar_percentual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aplicar_percentual.ForeColor = System.Drawing.Color.White;
            this.btn_aplicar_percentual.Location = new System.Drawing.Point(381, 403);
            this.btn_aplicar_percentual.Name = "btn_aplicar_percentual";
            this.btn_aplicar_percentual.Size = new System.Drawing.Size(174, 35);
            this.btn_aplicar_percentual.TabIndex = 3;
            this.btn_aplicar_percentual.Text = "Aplicar Percentual";
            this.btn_aplicar_percentual.UseVisualStyleBackColor = false;
            this.btn_aplicar_percentual.Click += new System.EventHandler(this.btn_aplicar_percentual_Click);
            // 
            // btn_excluir_itens_selecionados
            // 
            this.btn_excluir_itens_selecionados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excluir_itens_selecionados.BackColor = System.Drawing.Color.Red;
            this.btn_excluir_itens_selecionados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_itens_selecionados.ForeColor = System.Drawing.Color.White;
            this.btn_excluir_itens_selecionados.Location = new System.Drawing.Point(561, 403);
            this.btn_excluir_itens_selecionados.Name = "btn_excluir_itens_selecionados";
            this.btn_excluir_itens_selecionados.Size = new System.Drawing.Size(227, 35);
            this.btn_excluir_itens_selecionados.TabIndex = 4;
            this.btn_excluir_itens_selecionados.Text = "Excluir Itens Selecionados";
            this.btn_excluir_itens_selecionados.UseVisualStyleBackColor = false;
            this.btn_excluir_itens_selecionados.Click += new System.EventHandler(this.btn_excluir_itens_selecionados_Click);
            // 
            // dgv_registros
            // 
            this.dgv_registros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(12, 53);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.Size = new System.Drawing.Size(776, 344);
            this.dgv_registros.TabIndex = 5;
            this.dgv_registros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellClick);
            this.dgv_registros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellContentClick);
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "openFileDialog1";
            this.ofd_arquivo.Title = "Escolha o arquivo desejado:";
            // 
            // lbl_percentual
            // 
            this.lbl_percentual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_percentual.AutoSize = true;
            this.lbl_percentual.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentual.Location = new System.Drawing.Point(93, 412);
            this.lbl_percentual.Name = "lbl_percentual";
            this.lbl_percentual.Size = new System.Drawing.Size(197, 18);
            this.lbl_percentual.TabIndex = 6;
            this.lbl_percentual.Text = "Percentual a ser aplicado:";
            // 
            // nup_percentual
            // 
            this.nup_percentual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nup_percentual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_percentual.Location = new System.Drawing.Point(296, 411);
            this.nup_percentual.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.nup_percentual.Name = "nup_percentual";
            this.nup_percentual.Size = new System.Drawing.Size(56, 22);
            this.nup_percentual.TabIndex = 7;
            this.nup_percentual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nup_percentual_KeyPress);
            // 
            // btn_informacoes
            // 
            this.btn_informacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_informacoes.BackColor = System.Drawing.Color.Blue;
            this.btn_informacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informacoes.ForeColor = System.Drawing.Color.White;
            this.btn_informacoes.Location = new System.Drawing.Point(12, 403);
            this.btn_informacoes.Name = "btn_informacoes";
            this.btn_informacoes.Size = new System.Drawing.Size(34, 35);
            this.btn_informacoes.TabIndex = 8;
            this.btn_informacoes.Text = "?";
            this.btn_informacoes.UseVisualStyleBackColor = false;
            this.btn_informacoes.Click += new System.EventHandler(this.btn_informacoes_Click);
            // 
            // btn_legenda
            // 
            this.btn_legenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_legenda.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_legenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_legenda.ForeColor = System.Drawing.Color.White;
            this.btn_legenda.Location = new System.Drawing.Point(223, 12);
            this.btn_legenda.Name = "btn_legenda";
            this.btn_legenda.Size = new System.Drawing.Size(174, 35);
            this.btn_legenda.TabIndex = 9;
            this.btn_legenda.Text = "Legenda";
            this.btn_legenda.UseVisualStyleBackColor = false;
            this.btn_legenda.Click += new System.EventHandler(this.btn_legenda_Click);
            // 
            // frm_sistema_loja_de_roupas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_legenda);
            this.Controls.Add(this.btn_informacoes);
            this.Controls.Add(this.nup_percentual);
            this.Controls.Add(this.lbl_percentual);
            this.Controls.Add(this.dgv_registros);
            this.Controls.Add(this.btn_excluir_itens_selecionados);
            this.Controls.Add(this.btn_aplicar_percentual);
            this.Controls.Add(this.btn_desmarcar_todos);
            this.Controls.Add(this.btn_marcar_todos);
            this.Controls.Add(this.btn_importar_arquivo);
            this.Name = "frm_sistema_loja_de_roupas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Loja de Roupas";
            this.Load += new System.EventHandler(this.frm_sistema_loja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_percentual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_importar_arquivo;
        private System.Windows.Forms.Button btn_marcar_todos;
        private System.Windows.Forms.Button btn_desmarcar_todos;
        private System.Windows.Forms.Button btn_aplicar_percentual;
        private System.Windows.Forms.Button btn_excluir_itens_selecionados;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
        private System.Windows.Forms.Label lbl_percentual;
        private System.Windows.Forms.NumericUpDown nup_percentual;
        private System.Windows.Forms.Button btn_informacoes;
        private System.Windows.Forms.Button btn_legenda;
    }
}

