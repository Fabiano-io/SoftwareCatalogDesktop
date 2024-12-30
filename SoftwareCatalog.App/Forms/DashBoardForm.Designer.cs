namespace SoftwareCatalog.App.Forms
{
    partial class DashBoardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            statusStrip1 = new StatusStrip();
            toolQuantidadeAplicacoes = new ToolStripStatusLabel();
            panelTreeview = new Panel();
            treeView1 = new TreeView();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            cmbSquads = new ComboBox();
            btnFechar = new Button();
            bnFiltrar = new Button();
            txtFiltro = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            imageList1 = new ImageList(components);
            contextMenuNovo = new ContextMenuStrip(components);
            mnuNovo = new ToolStripMenuItem();
            contextMenuExcluir = new ContextMenuStrip(components);
            mnuExcluir = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuCopiar = new ToolStripMenuItem();
            contextMenuSonar = new ContextMenuStrip(components);
            mnuSonar = new ToolStripMenuItem();
            contextMenuRepositorio = new ContextMenuStrip(components);
            mnuRepositorio = new ToolStripMenuItem();
            contextMenuDesenho = new ContextMenuStrip(components);
            mnuDesenho = new ToolStripMenuItem();
            contextMenuReadme = new ContextMenuStrip(components);
            mnuReadme = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            panelTreeview.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            contextMenuNovo.SuspendLayout();
            contextMenuExcluir.SuspendLayout();
            contextMenuSonar.SuspendLayout();
            contextMenuRepositorio.SuspendLayout();
            contextMenuDesenho.SuspendLayout();
            contextMenuReadme.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolQuantidadeAplicacoes });
            statusStrip1.Location = new Point(0, 1297);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(782, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolQuantidadeAplicacoes
            // 
            toolQuantidadeAplicacoes.Name = "toolQuantidadeAplicacoes";
            toolQuantidadeAplicacoes.Size = new Size(0, 15);
            // 
            // panelTreeview
            // 
            panelTreeview.Controls.Add(treeView1);
            panelTreeview.Controls.Add(panel4);
            panelTreeview.Controls.Add(panel5);
            panelTreeview.Controls.Add(panel1);
            panelTreeview.Dock = DockStyle.Fill;
            panelTreeview.Location = new Point(0, 0);
            panelTreeview.Margin = new Padding(4, 5, 4, 5);
            panelTreeview.Name = "panelTreeview";
            panelTreeview.Size = new Size(782, 1297);
            panelTreeview.TabIndex = 3;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 134);
            treeView1.Margin = new Padding(2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(782, 955);
            treeView1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 1089);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(782, 208);
            panel4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 25);
            label5.TabIndex = 3;
            label5.Text = "Não existe sonar para a aplicação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Green;
            label4.Location = new Point(22, 111);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(430, 25);
            label4.TabIndex = 2;
            label4.Text = "Aplicação está no Catálogo do Azure e no BackStage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(22, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(526, 25);
            label3.TabIndex = 1;
            label3.Text = "Aplicação está no Catálogo do Azure mas não esta no BackStage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(22, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(499, 25);
            label2.TabIndex = 0;
            label2.Text = "Aplicação está no BackStage e não está no catálogo do Azure";
            // 
            // panel5
            // 
            panel5.Controls.Add(cmbSquads);
            panel5.Controls.Add(btnFechar);
            panel5.Controls.Add(bnFiltrar);
            panel5.Controls.Add(txtFiltro);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 22);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(782, 112);
            panel5.TabIndex = 6;
            // 
            // cmbSquads
            // 
            cmbSquads.Dock = DockStyle.Top;
            cmbSquads.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSquads.FlatStyle = FlatStyle.Flat;
            cmbSquads.FormattingEnabled = true;
            cmbSquads.Location = new Point(121, 0);
            cmbSquads.Margin = new Padding(4, 5, 4, 5);
            cmbSquads.Name = "cmbSquads";
            cmbSquads.Size = new Size(643, 33);
            cmbSquads.TabIndex = 13;
            cmbSquads.SelectionChangeCommitted += cmbSquads_SelectionChangeCommitted;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1065, 12);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(10, 10);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // bnFiltrar
            // 
            bnFiltrar.FlatStyle = FlatStyle.Flat;
            bnFiltrar.Location = new Point(439, 52);
            bnFiltrar.Margin = new Padding(2);
            bnFiltrar.Name = "bnFiltrar";
            bnFiltrar.Size = new Size(112, 41);
            bnFiltrar.TabIndex = 11;
            bnFiltrar.Text = "Filtrar";
            bnFiltrar.UseVisualStyleBackColor = true;
            bnFiltrar.Click += bnFiltrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Location = new Point(121, 54);
            txtFiltro.Margin = new Padding(2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(310, 31);
            txtFiltro.TabIndex = 10;
            txtFiltro.KeyDown += txtFiltro_KeyDown;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(764, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 112);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 112);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 1;
            label6.Text = "Aplicação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Squad";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 22);
            panel1.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // contextMenuNovo
            // 
            contextMenuNovo.ImageScalingSize = new Size(24, 24);
            contextMenuNovo.Items.AddRange(new ToolStripItem[] { mnuNovo });
            contextMenuNovo.Name = "contextMenuStrip1";
            contextMenuNovo.Size = new Size(268, 36);
            contextMenuNovo.Click += contextMenuNovo_Click;
            // 
            // mnuNovo
            // 
            mnuNovo.Name = "mnuNovo";
            mnuNovo.Size = new Size(267, 32);
            mnuNovo.Text = "Incluir no table Storage";
            // 
            // contextMenuExcluir
            // 
            contextMenuExcluir.ImageScalingSize = new Size(24, 24);
            contextMenuExcluir.Items.AddRange(new ToolStripItem[] { mnuCopiar, toolStripSeparator1, mnuExcluir });
            contextMenuExcluir.Name = "contextMenuExcluir";
            contextMenuExcluir.Size = new Size(271, 107);
            contextMenuExcluir.ItemClicked += contextMenuExcluir_ItemClicked;
            // 
            // mnuExcluir
            // 
            mnuExcluir.Name = "mnuExcluir";
            mnuExcluir.Size = new Size(270, 32);
            mnuExcluir.Text = "Excluir do table Storage";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // mnuCopiar
            // 
            mnuCopiar.Name = "mnuCopiar";
            mnuCopiar.Size = new Size(270, 32);
            mnuCopiar.Text = "Copiar";
            // 
            // contextMenuSonar
            // 
            contextMenuSonar.ImageScalingSize = new Size(24, 24);
            contextMenuSonar.Items.AddRange(new ToolStripItem[] { mnuSonar });
            contextMenuSonar.Name = "contextMenuSonar";
            contextMenuSonar.Size = new Size(234, 36);
            contextMenuSonar.Click += contextMenuSonar_Click;
            // 
            // mnuSonar
            // 
            mnuSonar.Name = "mnuSonar";
            mnuSonar.Size = new Size(233, 32);
            mnuSonar.Text = "Ir para sonar cloud";
            // 
            // contextMenuRepositorio
            // 
            contextMenuRepositorio.ImageScalingSize = new Size(24, 24);
            contextMenuRepositorio.Items.AddRange(new ToolStripItem[] { mnuRepositorio });
            contextMenuRepositorio.Name = "contextMenuRepositorio";
            contextMenuRepositorio.Size = new Size(244, 36);
            contextMenuRepositorio.Click += contextMenuRepositorio_Click;
            // 
            // mnuRepositorio
            // 
            mnuRepositorio.Name = "mnuRepositorio";
            mnuRepositorio.Size = new Size(243, 32);
            mnuRepositorio.Text = "Ir para o repositório";
            // 
            // contextMenuDesenho
            // 
            contextMenuDesenho.ImageScalingSize = new Size(24, 24);
            contextMenuDesenho.Items.AddRange(new ToolStripItem[] { mnuDesenho });
            contextMenuDesenho.Name = "contextMenuDesenho";
            contextMenuDesenho.Size = new Size(197, 36);
            contextMenuDesenho.Click += contextMenuDesenho_Click;
            // 
            // mnuDesenho
            // 
            mnuDesenho.Name = "mnuDesenho";
            mnuDesenho.Size = new Size(196, 32);
            mnuDesenho.Text = "Abrir desenho";
            // 
            // contextMenuReadme
            // 
            contextMenuReadme.ImageScalingSize = new Size(24, 24);
            contextMenuReadme.Items.AddRange(new ToolStripItem[] { mnuReadme });
            contextMenuReadme.Name = "contextMenuReadme";
            contextMenuReadme.Size = new Size(196, 36);
            contextMenuReadme.Click += contextMenuReadme_Click;
            // 
            // mnuReadme
            // 
            mnuReadme.Name = "mnuReadme";
            mnuReadme.Size = new Size(195, 32);
            mnuReadme.Text = "Abrir read-me";
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = btnFechar;
            ClientSize = new Size(782, 1319);
            Controls.Add(panelTreeview);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2);
            Name = "DashBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo Desktop";
            Load += DashBoardForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelTreeview.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            contextMenuNovo.ResumeLayout(false);
            contextMenuExcluir.ResumeLayout(false);
            contextMenuSonar.ResumeLayout(false);
            contextMenuRepositorio.ResumeLayout(false);
            contextMenuDesenho.ResumeLayout(false);
            contextMenuReadme.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Panel panelTreeview;
        private Panel panel1;
        private ToolStripStatusLabel toolQuantidadeAplicacoes;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TreeView treeView1;
        private Label label5;
        private Button bnFiltrar;
        private TextBox txtFiltro;
        private Label label6;
        private Button btnFechar;
        private ComboBox cmbSquads;
        private ImageList imageList1;
        private ContextMenuStrip contextMenuNovo;
        private ToolStripMenuItem mnuNovo;
        private ContextMenuStrip contextMenuExcluir;
        private ToolStripMenuItem mnuExcluir;
        private ContextMenuStrip contextMenuSonar;
        private ContextMenuStrip contextMenuRepositorio;
        private ToolStripMenuItem mnuSonar;
        private ContextMenuStrip contextMenuDesenho;
        private ContextMenuStrip contextMenuReadme;
        private ToolStripMenuItem mnuRepositorio;
        private ToolStripMenuItem mnuDesenho;
        private ToolStripMenuItem mnuReadme;
        private ToolStripMenuItem mnuCopiar;
        private ToolStripSeparator toolStripSeparator1;
    }
}