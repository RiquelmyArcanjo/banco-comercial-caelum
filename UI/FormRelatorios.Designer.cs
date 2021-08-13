
namespace Banco_Comercial_IBM.UI
{
    partial class FormRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorios));
            this.cmbRelatorios = new System.Windows.Forms.ComboBox();
            this.txtResultadoRelatorio = new System.Windows.Forms.TextBox();
            this.grpRelatorios = new System.Windows.Forms.GroupBox();
            this.btnSalvarRelatorio = new System.Windows.Forms.Button();
            this.lblEscolhaRelatorio = new System.Windows.Forms.Label();
            this.grpRelatorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRelatorios
            // 
            this.cmbRelatorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelatorios.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.cmbRelatorios.FormattingEnabled = true;
            this.cmbRelatorios.Items.AddRange(new object[] {
            "Saldo Geral",
            "Saldo > 500",
            "Maior Saldo",
            "Histórico de Movimentações",
            "Tributos das Contas Correntes",
            "Código Titular < 10 e Saldo > 1000"});
            this.cmbRelatorios.Location = new System.Drawing.Point(577, 98);
            this.cmbRelatorios.Name = "cmbRelatorios";
            this.cmbRelatorios.Size = new System.Drawing.Size(780, 38);
            this.cmbRelatorios.TabIndex = 3;
            this.cmbRelatorios.SelectedIndexChanged += new System.EventHandler(this.cmbRelatorios_SelectedIndexChanged);
            // 
            // txtResultadoRelatorio
            // 
            this.txtResultadoRelatorio.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.txtResultadoRelatorio.Location = new System.Drawing.Point(75, 179);
            this.txtResultadoRelatorio.Multiline = true;
            this.txtResultadoRelatorio.Name = "txtResultadoRelatorio";
            this.txtResultadoRelatorio.ReadOnly = true;
            this.txtResultadoRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultadoRelatorio.Size = new System.Drawing.Size(1282, 493);
            this.txtResultadoRelatorio.TabIndex = 4;
            // 
            // grpRelatorios
            // 
            this.grpRelatorios.Controls.Add(this.btnSalvarRelatorio);
            this.grpRelatorios.Controls.Add(this.lblEscolhaRelatorio);
            this.grpRelatorios.Controls.Add(this.txtResultadoRelatorio);
            this.grpRelatorios.Controls.Add(this.cmbRelatorios);
            this.grpRelatorios.Font = new System.Drawing.Font("Lucida Console", 9.900001F, System.Drawing.FontStyle.Bold);
            this.grpRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.grpRelatorios.Location = new System.Drawing.Point(63, 61);
            this.grpRelatorios.Name = "grpRelatorios";
            this.grpRelatorios.Size = new System.Drawing.Size(1435, 835);
            this.grpRelatorios.TabIndex = 5;
            this.grpRelatorios.TabStop = false;
            this.grpRelatorios.Text = "Relatórios";
            // 
            // btnSalvarRelatorio
            // 
            this.btnSalvarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRelatorio.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnSalvarRelatorio.Location = new System.Drawing.Point(949, 715);
            this.btnSalvarRelatorio.Name = "btnSalvarRelatorio";
            this.btnSalvarRelatorio.Size = new System.Drawing.Size(408, 71);
            this.btnSalvarRelatorio.TabIndex = 14;
            this.btnSalvarRelatorio.Text = "Salvar Relatório";
            this.btnSalvarRelatorio.UseVisualStyleBackColor = true;
            this.btnSalvarRelatorio.Click += new System.EventHandler(this.btnSalvarRelatorio_Click);
            // 
            // lblEscolhaRelatorio
            // 
            this.lblEscolhaRelatorio.AutoSize = true;
            this.lblEscolhaRelatorio.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblEscolhaRelatorio.ForeColor = System.Drawing.Color.White;
            this.lblEscolhaRelatorio.Location = new System.Drawing.Point(70, 98);
            this.lblEscolhaRelatorio.Name = "lblEscolhaRelatorio";
            this.lblEscolhaRelatorio.Size = new System.Drawing.Size(373, 30);
            this.lblEscolhaRelatorio.TabIndex = 5;
            this.lblEscolhaRelatorio.Text = "Escolha o relatório:";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1556, 968);
            this.Controls.Add(this.grpRelatorios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorios";
            this.Text = "Consultar Relatórios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.grpRelatorios.ResumeLayout(false);
            this.grpRelatorios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRelatorios;
        private System.Windows.Forms.TextBox txtResultadoRelatorio;
        private System.Windows.Forms.GroupBox grpRelatorios;
        private System.Windows.Forms.Label lblEscolhaRelatorio;
        private System.Windows.Forms.Button btnSalvarRelatorio;
    }
}