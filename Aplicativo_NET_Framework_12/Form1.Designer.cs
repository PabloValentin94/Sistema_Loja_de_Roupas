namespace Aplicativo_NET_Framework_12
{
    partial class frm_sistema_loja
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
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
            // 
            // dgv_registros
            // 
            this.dgv_registros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(12, 53);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.Size = new System.Drawing.Size(776, 344);
            this.dgv_registros.TabIndex = 5;
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "openFileDialog1";
            // 
            // frm_sistema_loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_registros);
            this.Controls.Add(this.btn_excluir_itens_selecionados);
            this.Controls.Add(this.btn_aplicar_percentual);
            this.Controls.Add(this.btn_desmarcar_todos);
            this.Controls.Add(this.btn_marcar_todos);
            this.Controls.Add(this.btn_importar_arquivo);
            this.Name = "frm_sistema_loja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Loja";
            this.Load += new System.EventHandler(this.frm_sistema_loja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_importar_arquivo;
        private System.Windows.Forms.Button btn_marcar_todos;
        private System.Windows.Forms.Button btn_desmarcar_todos;
        private System.Windows.Forms.Button btn_aplicar_percentual;
        private System.Windows.Forms.Button btn_excluir_itens_selecionados;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
    }
}

