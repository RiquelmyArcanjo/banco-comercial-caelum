
namespace Banco_Comercial_IBM
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.cmbTipoMovimento = new System.Windows.Forms.ComboBox();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.lblTipoMovimento = new System.Windows.Forms.Label();
            this.lblValorOperacao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumeroContaDestino = new System.Windows.Forms.TextBox();
            this.lblNumContaDestino = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.grpConta = new System.Windows.Forms.GroupBox();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.lblSaldoConta = new System.Windows.Forms.Label();
            this.txtBuscaTitular = new System.Windows.Forms.TextBox();
            this.lblBuscaTitular = new System.Windows.Forms.Label();
            this.btnBuscaTitular = new System.Windows.Forms.Button();
            this.lblEscolhaConta = new System.Windows.Forms.Label();
            this.cmbContas = new System.Windows.Forms.ComboBox();
            this.grpBuscaConta = new System.Windows.Forms.GroupBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.txtTipoConta = new System.Windows.Forms.TextBox();
            this.grpConta.SuspendLayout();
            this.grpBuscaConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Enabled = false;
            this.txtSaldoFinal.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtSaldoFinal.Location = new System.Drawing.Point(500, 201);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.Size = new System.Drawing.Size(480, 37);
            this.txtSaldoFinal.TabIndex = 8;
            // 
            // cmbTipoMovimento
            // 
            this.cmbTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMovimento.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.cmbTipoMovimento.FormattingEnabled = true;
            this.cmbTipoMovimento.Items.AddRange(new object[] {
            "Sacar",
            "Depositar",
            "Transferir"});
            this.cmbTipoMovimento.Location = new System.Drawing.Point(500, 270);
            this.cmbTipoMovimento.Name = "cmbTipoMovimento";
            this.cmbTipoMovimento.Size = new System.Drawing.Size(480, 38);
            this.cmbTipoMovimento.TabIndex = 9;
            this.cmbTipoMovimento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMovimento_SelectedIndexChanged);
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacao.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.ForeColor = System.Drawing.Color.White;
            this.btnMovimentacao.Location = new System.Drawing.Point(499, 471);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(480, 71);
            this.btnMovimentacao.TabIndex = 12;
            this.btnMovimentacao.Text = "Efetuar Movimentação";
            this.btnMovimentacao.UseVisualStyleBackColor = false;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblTipoMovimento.ForeColor = System.Drawing.Color.White;
            this.lblTipoMovimento.Location = new System.Drawing.Point(29, 277);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(337, 30);
            this.lblTipoMovimento.TabIndex = 13;
            this.lblTipoMovimento.Text = "Tipo de movimento:";
            // 
            // lblValorOperacao
            // 
            this.lblValorOperacao.AutoSize = true;
            this.lblValorOperacao.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblValorOperacao.ForeColor = System.Drawing.Color.White;
            this.lblValorOperacao.Location = new System.Drawing.Point(29, 344);
            this.lblValorOperacao.Name = "lblValorOperacao";
            this.lblValorOperacao.Size = new System.Drawing.Size(337, 30);
            this.lblValorOperacao.TabIndex = 12;
            this.lblValorOperacao.Text = "Valor da operação:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtValor.Location = new System.Drawing.Point(500, 338);
            this.txtValor.MaxLength = 15;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(480, 37);
            this.txtValor.TabIndex = 10;
            // 
            // txtNumeroContaDestino
            // 
            this.txtNumeroContaDestino.Enabled = false;
            this.txtNumeroContaDestino.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtNumeroContaDestino.Location = new System.Drawing.Point(500, 404);
            this.txtNumeroContaDestino.Name = "txtNumeroContaDestino";
            this.txtNumeroContaDestino.Size = new System.Drawing.Size(480, 37);
            this.txtNumeroContaDestino.TabIndex = 11;
            // 
            // lblNumContaDestino
            // 
            this.lblNumContaDestino.AutoSize = true;
            this.lblNumContaDestino.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblNumContaDestino.ForeColor = System.Drawing.Color.White;
            this.lblNumContaDestino.Location = new System.Drawing.Point(29, 410);
            this.lblNumContaDestino.Name = "lblNumContaDestino";
            this.lblNumContaDestino.Size = new System.Drawing.Size(373, 30);
            this.lblNumContaDestino.TabIndex = 26;
            this.lblNumContaDestino.Text = "N° da conta destino:";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Enabled = false;
            this.txtNumeroConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtNumeroConta.Location = new System.Drawing.Point(499, 70);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(480, 37);
            this.txtNumeroConta.TabIndex = 6;
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaConta.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaConta.ForeColor = System.Drawing.Color.White;
            this.btnNovaConta.Location = new System.Drawing.Point(474, 957);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(285, 71);
            this.btnNovaConta.TabIndex = 13;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Lucida Console", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.lblMsg.Location = new System.Drawing.Point(29, 561);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 28);
            this.lblMsg.TabIndex = 33;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold);
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(797, 957);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(277, 71);
            this.btnRelatorios.TabIndex = 14;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.lblTipoConta);
            this.grpConta.Controls.Add(this.txtTipoConta);
            this.grpConta.Controls.Add(this.lblNumConta);
            this.grpConta.Controls.Add(this.lblSaldoConta);
            this.grpConta.Controls.Add(this.lblValorOperacao);
            this.grpConta.Controls.Add(this.lblTipoMovimento);
            this.grpConta.Controls.Add(this.lblMsg);
            this.grpConta.Controls.Add(this.btnMovimentacao);
            this.grpConta.Controls.Add(this.cmbTipoMovimento);
            this.grpConta.Controls.Add(this.txtValor);
            this.grpConta.Controls.Add(this.txtSaldoFinal);
            this.grpConta.Controls.Add(this.lblNumContaDestino);
            this.grpConta.Controls.Add(this.txtNumeroConta);
            this.grpConta.Controls.Add(this.txtNumeroContaDestino);
            this.grpConta.Font = new System.Drawing.Font("Lucida Console", 9.900001F, System.Drawing.FontStyle.Bold);
            this.grpConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.grpConta.Location = new System.Drawing.Point(54, 298);
            this.grpConta.Name = "grpConta";
            this.grpConta.Size = new System.Drawing.Size(1020, 615);
            this.grpConta.TabIndex = 5;
            this.grpConta.TabStop = false;
            this.grpConta.Text = "Conta";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblNumConta.ForeColor = System.Drawing.Color.White;
            this.lblNumConta.Location = new System.Drawing.Point(29, 77);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(229, 30);
            this.lblNumConta.TabIndex = 34;
            this.lblNumConta.Text = "N° da conta:";
            // 
            // lblSaldoConta
            // 
            this.lblSaldoConta.AutoSize = true;
            this.lblSaldoConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblSaldoConta.ForeColor = System.Drawing.Color.White;
            this.lblSaldoConta.Location = new System.Drawing.Point(29, 207);
            this.lblSaldoConta.Name = "lblSaldoConta";
            this.lblSaldoConta.Size = new System.Drawing.Size(283, 30);
            this.lblSaldoConta.TabIndex = 30;
            this.lblSaldoConta.Text = "Saldo da conta:";
            // 
            // txtBuscaTitular
            // 
            this.txtBuscaTitular.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtBuscaTitular.Location = new System.Drawing.Point(499, 122);
            this.txtBuscaTitular.MaxLength = 80;
            this.txtBuscaTitular.Name = "txtBuscaTitular";
            this.txtBuscaTitular.Size = new System.Drawing.Size(263, 37);
            this.txtBuscaTitular.TabIndex = 3;
            // 
            // lblBuscaTitular
            // 
            this.lblBuscaTitular.AutoSize = true;
            this.lblBuscaTitular.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblBuscaTitular.ForeColor = System.Drawing.Color.White;
            this.lblBuscaTitular.Location = new System.Drawing.Point(28, 121);
            this.lblBuscaTitular.Name = "lblBuscaTitular";
            this.lblBuscaTitular.Size = new System.Drawing.Size(337, 30);
            this.lblBuscaTitular.TabIndex = 35;
            this.lblBuscaTitular.Text = "Busca por titular:";
            // 
            // btnBuscaTitular
            // 
            this.btnBuscaTitular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.btnBuscaTitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaTitular.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaTitular.ForeColor = System.Drawing.Color.White;
            this.btnBuscaTitular.Location = new System.Drawing.Point(803, 121);
            this.btnBuscaTitular.Name = "btnBuscaTitular";
            this.btnBuscaTitular.Size = new System.Drawing.Size(176, 67);
            this.btnBuscaTitular.TabIndex = 4;
            this.btnBuscaTitular.Text = "Buscar";
            this.btnBuscaTitular.UseVisualStyleBackColor = false;
            this.btnBuscaTitular.Click += new System.EventHandler(this.btnBuscaTitular_Click);
            // 
            // lblEscolhaConta
            // 
            this.lblEscolhaConta.AutoSize = true;
            this.lblEscolhaConta.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaConta.ForeColor = System.Drawing.Color.White;
            this.lblEscolhaConta.Location = new System.Drawing.Point(28, 74);
            this.lblEscolhaConta.Name = "lblEscolhaConta";
            this.lblEscolhaConta.Size = new System.Drawing.Size(301, 30);
            this.lblEscolhaConta.TabIndex = 11;
            this.lblEscolhaConta.Text = "Escolha a conta:";
            // 
            // cmbContas
            // 
            this.cmbContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContas.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.cmbContas.FormattingEnabled = true;
            this.cmbContas.Location = new System.Drawing.Point(499, 59);
            this.cmbContas.Name = "cmbContas";
            this.cmbContas.Size = new System.Drawing.Size(480, 38);
            this.cmbContas.TabIndex = 2;
            this.cmbContas.SelectedIndexChanged += new System.EventHandler(this.cmbContas_SelectedIndexChanged);
            // 
            // grpBuscaConta
            // 
            this.grpBuscaConta.Controls.Add(this.cmbContas);
            this.grpBuscaConta.Controls.Add(this.lblEscolhaConta);
            this.grpBuscaConta.Controls.Add(this.btnBuscaTitular);
            this.grpBuscaConta.Controls.Add(this.lblBuscaTitular);
            this.grpBuscaConta.Controls.Add(this.txtBuscaTitular);
            this.grpBuscaConta.Font = new System.Drawing.Font("Lucida Console", 9.900001F, System.Drawing.FontStyle.Bold);
            this.grpBuscaConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.grpBuscaConta.Location = new System.Drawing.Point(54, 46);
            this.grpBuscaConta.Name = "grpBuscaConta";
            this.grpBuscaConta.Size = new System.Drawing.Size(1020, 216);
            this.grpBuscaConta.TabIndex = 1;
            this.grpBuscaConta.TabStop = false;
            this.grpBuscaConta.Text = "Busca de Conta";
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblTipoConta.ForeColor = System.Drawing.Color.White;
            this.lblTipoConta.Location = new System.Drawing.Point(30, 143);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(265, 30);
            this.lblTipoConta.TabIndex = 36;
            this.lblTipoConta.Text = "Tipo de conta:";
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Enabled = false;
            this.txtTipoConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtTipoConta.Location = new System.Drawing.Point(500, 136);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(480, 37);
            this.txtTipoConta.TabIndex = 7;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1148, 1099);
            this.Controls.Add(this.grpConta);
            this.Controls.Add(this.grpBuscaConta);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnNovaConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.grpConta.ResumeLayout(false);
            this.grpConta.PerformLayout();
            this.grpBuscaConta.ResumeLayout(false);
            this.grpBuscaConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.ComboBox cmbTipoMovimento;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Label lblTipoMovimento;
        private System.Windows.Forms.Label lblValorOperacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumeroContaDestino;
        private System.Windows.Forms.Label lblNumContaDestino;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.GroupBox grpConta;
        private System.Windows.Forms.Label lblSaldoConta;
        private System.Windows.Forms.TextBox txtBuscaTitular;
        private System.Windows.Forms.Label lblBuscaTitular;
        private System.Windows.Forms.Button btnBuscaTitular;
        private System.Windows.Forms.Label lblEscolhaConta;
        private System.Windows.Forms.ComboBox cmbContas;
        private System.Windows.Forms.GroupBox grpBuscaConta;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.TextBox txtTipoConta;
    }
}

