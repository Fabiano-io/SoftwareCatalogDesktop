namespace SoftwareCatalog.App.Forms
{
    partial class CadastroTableStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTableStorage));
            groupBox1 = new GroupBox();
            label1 = new Label();
            cmbSquads = new ComboBox();
            label2 = new Label();
            txtNomeAplicacao = new TextBox();
            label3 = new Label();
            txtTipoAplicacao = new TextBox();
            btnSalvar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 13);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome da Squad";
            // 
            // cmbSquads
            // 
            cmbSquads.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSquads.FlatStyle = FlatStyle.Flat;
            cmbSquads.FormattingEnabled = true;
            cmbSquads.Location = new Point(225, 46);
            cmbSquads.Name = "cmbSquads";
            cmbSquads.Size = new Size(737, 33);
            cmbSquads.TabIndex = 2;
            cmbSquads.SelectionChangeCommitted += cmbSquads_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 107);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 3;
            label2.Text = "Nome da Aplicação";
            // 
            // txtNomeAplicacao
            // 
            txtNomeAplicacao.BorderStyle = BorderStyle.FixedSingle;
            txtNomeAplicacao.Location = new Point(225, 104);
            txtNomeAplicacao.Name = "txtNomeAplicacao";
            txtNomeAplicacao.Size = new Size(737, 31);
            txtNomeAplicacao.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 169);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 5;
            label3.Text = "Tipo de Aplicação";
            // 
            // txtTipoAplicacao
            // 
            txtTipoAplicacao.BorderStyle = BorderStyle.FixedSingle;
            txtTipoAplicacao.Location = new Point(225, 163);
            txtTipoAplicacao.Name = "txtTipoAplicacao";
            txtTipoAplicacao.Size = new Size(737, 31);
            txtTipoAplicacao.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(649, 270);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(148, 51);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(814, 270);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(148, 51);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // CadastroTableStorage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFechar;
            ClientSize = new Size(1008, 355);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTipoAplicacao);
            Controls.Add(label3);
            Controls.Add(txtNomeAplicacao);
            Controls.Add(label2);
            Controls.Add(cmbSquads);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroTableStorage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroTableStorage";
            Load += CadastroTableStorage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbSquads;
        private Label label2;
        private TextBox txtNomeAplicacao;
        private Label label3;
        private TextBox txtTipoAplicacao;
        private Button btnSalvar;
        private Button btnFechar;
    }
}