
namespace Banco_Comercial_IBM
{
    partial class FormCadastroConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroConta));
            this.txtNomeTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.lblNomeTitular = new System.Windows.Forms.Label();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.btnCadastraConta = new System.Windows.Forms.Button();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.grpCadastroConta = new System.Windows.Forms.GroupBox();
            this.grpCadastroConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeTitular
            // 
            this.txtNomeTitular.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtNomeTitular.Location = new System.Drawing.Point(521, 83);
            this.txtNomeTitular.Name = "txtNomeTitular";
            this.txtNomeTitular.Size = new System.Drawing.Size(480, 37);
            this.txtNomeTitular.TabIndex = 2;
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Enabled = false;
            this.txtNumeroConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtNumeroConta.Location = new System.Drawing.Point(521, 224);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(480, 37);
            this.txtNumeroConta.TabIndex = 4;
            // 
            // lblNomeTitular
            // 
            this.lblNomeTitular.AutoSize = true;
            this.lblNomeTitular.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblNomeTitular.ForeColor = System.Drawing.Color.White;
            this.lblNomeTitular.Location = new System.Drawing.Point(37, 86);
            this.lblNomeTitular.Name = "lblNomeTitular";
            this.lblNomeTitular.Size = new System.Drawing.Size(301, 30);
            this.lblNomeTitular.TabIndex = 33;
            this.lblNomeTitular.Text = "Nome do titular:";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblNumConta.ForeColor = System.Drawing.Color.White;
            this.lblNumConta.Location = new System.Drawing.Point(37, 230);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(301, 30);
            this.lblNumConta.TabIndex = 34;
            this.lblNumConta.Text = "Número da conta:";
            // 
            // btnCadastraConta
            // 
            this.btnCadastraConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnCadastraConta.ForeColor = System.Drawing.Color.White;
            this.btnCadastraConta.Location = new System.Drawing.Point(521, 296);
            this.btnCadastraConta.Name = "btnCadastraConta";
            this.btnCadastraConta.Size = new System.Drawing.Size(480, 55);
            this.btnCadastraConta.TabIndex = 5;
            this.btnCadastraConta.Text = "Cadastrar";
            this.btnCadastraConta.UseVisualStyleBackColor = true;
            this.btnCadastraConta.Click += new System.EventHandler(this.btnCadastraConta_Click);
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblTipoConta.ForeColor = System.Drawing.Color.White;
            this.lblTipoConta.Location = new System.Drawing.Point(37, 157);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(265, 30);
            this.lblTipoConta.TabIndex = 36;
            this.lblTipoConta.Text = "Tipo de conta:";
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConta.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança",
            "Conta Estudante",
            "Conta Investimento"});
            this.cmbTipoConta.Location = new System.Drawing.Point(521, 150);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(480, 38);
            this.cmbTipoConta.TabIndex = 3;
            // 
            // grpCadastroConta
            // 
            this.grpCadastroConta.Controls.Add(this.btnCadastraConta);
            this.grpCadastroConta.Controls.Add(this.cmbTipoConta);
            this.grpCadastroConta.Controls.Add(this.txtNomeTitular);
            this.grpCadastroConta.Controls.Add(this.lblTipoConta);
            this.grpCadastroConta.Controls.Add(this.txtNumeroConta);
            this.grpCadastroConta.Controls.Add(this.lblNomeTitular);
            this.grpCadastroConta.Controls.Add(this.lblNumConta);
            this.grpCadastroConta.Font = new System.Drawing.Font("Lucida Console", 9.900001F, System.Drawing.FontStyle.Bold);
            this.grpCadastroConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.grpCadastroConta.Location = new System.Drawing.Point(65, 50);
            this.grpCadastroConta.Name = "grpCadastroConta";
            this.grpCadastroConta.Size = new System.Drawing.Size(1043, 402);
            this.grpCadastroConta.TabIndex = 1;
            this.grpCadastroConta.TabStop = false;
            this.grpCadastroConta.Text = "Cadastro Conta";
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1164, 503);
            this.Controls.Add(this.grpCadastroConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroConta";
            this.Text = "Cadastrar Nova Conta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.grpCadastroConta.ResumeLayout(false);
            this.grpCadastroConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeTitular;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label lblNomeTitular;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Button btnCadastraConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.GroupBox grpCadastroConta;
    }
}