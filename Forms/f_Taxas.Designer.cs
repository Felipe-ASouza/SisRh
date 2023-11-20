namespace SisRH_Desktop
{
    partial class f_Taxas
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdicionarNovaTaxa = new System.Windows.Forms.Label();
            this.textTaxa = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.checkBoxDesconto = new System.Windows.Forms.CheckBox();
            this.checkBoxAcrescimo = new System.Windows.Forms.CheckBox();
            this.labelTaxa = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.textFuncionario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AdicionarNovaTaxa
            // 
            this.AdicionarNovaTaxa.AutoSize = true;
            this.AdicionarNovaTaxa.BackColor = System.Drawing.Color.Transparent;
            this.AdicionarNovaTaxa.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarNovaTaxa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.AdicionarNovaTaxa.Location = new System.Drawing.Point(158, 85);
            this.AdicionarNovaTaxa.Name = "AdicionarNovaTaxa";
            this.AdicionarNovaTaxa.Size = new System.Drawing.Size(195, 25);
            this.AdicionarNovaTaxa.TabIndex = 73;
            this.AdicionarNovaTaxa.Text = "Adicionar Nova Taxa";
            // 
            // textTaxa
            // 
            this.textTaxa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTaxa.Location = new System.Drawing.Point(127, 166);
            this.textTaxa.Name = "textTaxa";
            this.textTaxa.Size = new System.Drawing.Size(379, 27);
            this.textTaxa.TabIndex = 74;
            this.textTaxa.TextChanged += new System.EventHandler(this.textTaxa_TextChanged);
            // 
            // textValor
            // 
            this.textValor.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValor.Location = new System.Drawing.Point(127, 210);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(379, 27);
            this.textValor.TabIndex = 75;
            this.textValor.TextChanged += new System.EventHandler(this.textValor_TextChanged);
            // 
            // checkBoxDesconto
            // 
            this.checkBoxDesconto.AutoSize = true;
            this.checkBoxDesconto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesconto.Location = new System.Drawing.Point(171, 247);
            this.checkBoxDesconto.Name = "checkBoxDesconto";
            this.checkBoxDesconto.Size = new System.Drawing.Size(91, 24);
            this.checkBoxDesconto.TabIndex = 76;
            this.checkBoxDesconto.Text = "Desconto";
            this.checkBoxDesconto.UseVisualStyleBackColor = true;
            this.checkBoxDesconto.CheckedChanged += new System.EventHandler(this.checkBoxDesconto_CheckedChanged);
            // 
            // checkBoxAcrescimo
            // 
            this.checkBoxAcrescimo.AutoSize = true;
            this.checkBoxAcrescimo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAcrescimo.Location = new System.Drawing.Point(268, 247);
            this.checkBoxAcrescimo.Name = "checkBoxAcrescimo";
            this.checkBoxAcrescimo.Size = new System.Drawing.Size(97, 24);
            this.checkBoxAcrescimo.TabIndex = 77;
            this.checkBoxAcrescimo.Text = "Acréscimo";
            this.checkBoxAcrescimo.UseVisualStyleBackColor = true;
            this.checkBoxAcrescimo.CheckedChanged += new System.EventHandler(this.checkBoxAcrescimo_CheckedChanged);
            // 
            // labelTaxa
            // 
            this.labelTaxa.AutoSize = true;
            this.labelTaxa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxa.Location = new System.Drawing.Point(80, 169);
            this.labelTaxa.Name = "labelTaxa";
            this.labelTaxa.Size = new System.Drawing.Size(41, 20);
            this.labelTaxa.TabIndex = 78;
            this.labelTaxa.Text = "Taxa:";
            this.labelTaxa.Click += new System.EventHandler(this.labelTaxa_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(53, 213);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(68, 20);
            this.labelValor.TabIndex = 79;
            this.labelValor.Text = "Valor(%):";
            this.labelValor.Click += new System.EventHandler(this.labelValor_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(123, 247);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(42, 20);
            this.labelTipo.TabIndex = 80;
            this.labelTipo.Text = "Tipo:";
            this.labelTipo.Click += new System.EventHandler(this.labelTipo_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionar.Location = new System.Drawing.Point(377, 245);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(129, 26);
            this.buttonAdicionar.TabIndex = 81;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionario.Location = new System.Drawing.Point(32, 127);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(89, 20);
            this.labelFuncionario.TabIndex = 82;
            this.labelFuncionario.Text = "Funcionário:";
            this.labelFuncionario.Click += new System.EventHandler(this.labelFuncionario_Click);
            // 
            // textFuncionario
            // 
            this.textFuncionario.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFuncionario.Location = new System.Drawing.Point(127, 127);
            this.textFuncionario.Name = "textFuncionario";
            this.textFuncionario.Size = new System.Drawing.Size(379, 27);
            this.textFuncionario.TabIndex = 83;
            this.textFuncionario.TextChanged += new System.EventHandler(this.textFuncionario_TextChanged);
            // 
            // f_Taxas
            // 
            this.ClientSize = new System.Drawing.Size(682, 511);
            this.Controls.Add(this.textFuncionario);
            this.Controls.Add(this.labelFuncionario);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelTaxa);
            this.Controls.Add(this.checkBoxAcrescimo);
            this.Controls.Add(this.checkBoxDesconto);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textTaxa);
            this.Controls.Add(this.AdicionarNovaTaxa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_Taxas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sis.RH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdicionarNovaTaxa;
        private System.Windows.Forms.TextBox textTaxa;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.CheckBox checkBoxDesconto;
        private System.Windows.Forms.CheckBox checkBoxAcrescimo;
        private System.Windows.Forms.Label labelTaxa;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.TextBox textFuncionario;
    }
}