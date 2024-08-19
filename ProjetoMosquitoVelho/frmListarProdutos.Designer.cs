
namespace ProjetoMosquitoVelho
{
    partial class frmListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProdutos));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.ltbListaProdutos = new System.Windows.Forms.ListBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbListarItens = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTestarPessoa = new System.Windows.Forms.Button();
            this.lblTestarPessoa = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroCartao = new System.Windows.Forms.Label();
            this.lblMostrarNumeroCartao = new System.Windows.Forms.Label();
            this.lblMostrarDocumeto = new System.Windows.Forms.Label();
            this.mtbNumeroCartao = new System.Windows.Forms.MaskedTextBox();
            this.btnTestaLogin = new System.Windows.Forms.Button();
            this.txtTestaLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(652, 310);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(182, 60);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "&Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // ltbListaProdutos
            // 
            this.ltbListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaProdutos.FormattingEnabled = true;
            this.ltbListaProdutos.ItemHeight = 20;
            this.ltbListaProdutos.Location = new System.Drawing.Point(663, 72);
            this.ltbListaProdutos.Name = "ltbListaProdutos";
            this.ltbListaProdutos.Size = new System.Drawing.Size(171, 204);
            this.ltbListaProdutos.TabIndex = 1;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(12, 72);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(183, 28);
            this.cbbProdutos.TabIndex = 2;
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProdutos.Location = new System.Drawing.Point(663, 41);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(132, 20);
            this.lblListaProdutos.TabIndex = 3;
            this.lblListaProdutos.Text = "Lista de produtos";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(12, 41);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(73, 20);
            this.lblProdutos.TabIndex = 4;
            this.lblProdutos.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listar itens";
            // 
            // cbbListarItens
            // 
            this.cbbListarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListarItens.FormattingEnabled = true;
            this.cbbListarItens.Location = new System.Drawing.Point(443, 82);
            this.cbbListarItens.Name = "cbbListarItens";
            this.cbbListarItens.Size = new System.Drawing.Size(183, 28);
            this.cbbListarItens.TabIndex = 5;
            this.cbbListarItens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbListarItens_MouseClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(652, 385);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(182, 60);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTestarPessoa
            // 
            this.btnTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarPessoa.Location = new System.Drawing.Point(12, 128);
            this.btnTestarPessoa.Name = "btnTestarPessoa";
            this.btnTestarPessoa.Size = new System.Drawing.Size(182, 60);
            this.btnTestarPessoa.TabIndex = 8;
            this.btnTestarPessoa.Text = "&Testar pessoa";
            this.btnTestarPessoa.UseVisualStyleBackColor = true;
            this.btnTestarPessoa.Click += new System.EventHandler(this.btnTestarPessoa_Click);
            // 
            // lblTestarPessoa
            // 
            this.lblTestarPessoa.AutoSize = true;
            this.lblTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestarPessoa.Location = new System.Drawing.Point(439, 138);
            this.lblTestarPessoa.Name = "lblTestarPessoa";
            this.lblTestarPessoa.Size = new System.Drawing.Size(114, 20);
            this.lblTestarPessoa.TabIndex = 9;
            this.lblTestarPessoa.Text = "Mostra pessoa";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(12, 217);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(182, 60);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "&Reserva";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(12, 304);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(92, 20);
            this.lblDocumento.TabIndex = 12;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(12, 327);
            this.txtDocumento.MaxLength = 30;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(170, 26);
            this.txtDocumento.TabIndex = 13;
            // 
            // lblNumeroCartao
            // 
            this.lblNumeroCartao.AutoSize = true;
            this.lblNumeroCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCartao.Location = new System.Drawing.Point(12, 379);
            this.lblNumeroCartao.Name = "lblNumeroCartao";
            this.lblNumeroCartao.Size = new System.Drawing.Size(136, 20);
            this.lblNumeroCartao.TabIndex = 14;
            this.lblNumeroCartao.Text = "Número do cartão";
            // 
            // lblMostrarNumeroCartao
            // 
            this.lblMostrarNumeroCartao.AutoSize = true;
            this.lblMostrarNumeroCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNumeroCartao.Location = new System.Drawing.Point(229, 405);
            this.lblMostrarNumeroCartao.Name = "lblMostrarNumeroCartao";
            this.lblMostrarNumeroCartao.Size = new System.Drawing.Size(194, 20);
            this.lblMostrarNumeroCartao.TabIndex = 17;
            this.lblMostrarNumeroCartao.Text = "Mostrar Número do cartão";
            // 
            // lblMostrarDocumeto
            // 
            this.lblMostrarDocumeto.AutoSize = true;
            this.lblMostrarDocumeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDocumeto.Location = new System.Drawing.Point(229, 330);
            this.lblMostrarDocumeto.Name = "lblMostrarDocumeto";
            this.lblMostrarDocumeto.Size = new System.Drawing.Size(150, 20);
            this.lblMostrarDocumeto.TabIndex = 16;
            this.lblMostrarDocumeto.Text = "Mostrar Documento";
            // 
            // mtbNumeroCartao
            // 
            this.mtbNumeroCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumeroCartao.Location = new System.Drawing.Point(16, 402);
            this.mtbNumeroCartao.Mask = "000,000,000-00";
            this.mtbNumeroCartao.Name = "mtbNumeroCartao";
            this.mtbNumeroCartao.Size = new System.Drawing.Size(166, 26);
            this.mtbNumeroCartao.TabIndex = 18;
            // 
            // btnTestaLogin
            // 
            this.btnTestaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestaLogin.Location = new System.Drawing.Point(258, 216);
            this.btnTestaLogin.Name = "btnTestaLogin";
            this.btnTestaLogin.Size = new System.Drawing.Size(182, 60);
            this.btnTestaLogin.TabIndex = 19;
            this.btnTestaLogin.Text = "&Testar login";
            this.btnTestaLogin.UseVisualStyleBackColor = true;
            this.btnTestaLogin.Click += new System.EventHandler(this.btnTestaLogin_Click);
            // 
            // txtTestaLogin
            // 
            this.txtTestaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestaLogin.Location = new System.Drawing.Point(258, 175);
            this.txtTestaLogin.MaxLength = 30;
            this.txtTestaLogin.Name = "txtTestaLogin";
            this.txtTestaLogin.Size = new System.Drawing.Size(182, 26);
            this.txtTestaLogin.TabIndex = 20;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 457);
            this.Controls.Add(this.txtTestaLogin);
            this.Controls.Add(this.btnTestaLogin);
            this.Controls.Add(this.mtbNumeroCartao);
            this.Controls.Add(this.lblMostrarNumeroCartao);
            this.Controls.Add(this.lblMostrarDocumeto);
            this.Controls.Add(this.lblNumeroCartao);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblTestarPessoa);
            this.Controls.Add(this.btnTestarPessoa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbListarItens);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblListaProdutos);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ltbListaProdutos);
            this.Controls.Add(this.btnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ABC - ListarProdutos";
            this.Load += new System.EventHandler(this.frmListarProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox ltbListaProdutos;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbListarItens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnTestarPessoa;
        private System.Windows.Forms.Label lblTestarPessoa;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblNumeroCartao;
        private System.Windows.Forms.Label lblMostrarNumeroCartao;
        private System.Windows.Forms.Label lblMostrarDocumeto;
        private System.Windows.Forms.MaskedTextBox mtbNumeroCartao;
        private System.Windows.Forms.Button btnTestaLogin;
        private System.Windows.Forms.TextBox txtTestaLogin;
    }
}