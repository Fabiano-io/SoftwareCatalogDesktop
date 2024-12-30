using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Business.Contracts.Util;
using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.App.Forms
{
    public partial class DashBoardForm : Form
    {
        private readonly ISquadService _squadService;
        private readonly ICatalogAzureService _catalogAzureService;
        private readonly IBackStageService _backStageService;
        private readonly ISonarService _sonarService;
        private readonly IUtilService _utilService;

        private readonly CadastroTableStorage _cadastroTableStorage;

        private IEnumerable<AplicacaoAzure> cataloAzure;
        private IEnumerable<ApplicacaoBackStage> catalogoBackStage;
        public DashBoardForm(ICatalogAzureService catalogAzureService,
                             IBackStageService backStageService,
                             ISquadService squadService,
                             ISonarService sonarService,
                             IUtilService utilService,
                             CadastroTableStorage cadastroTableStorage)
        {
            _utilService = utilService;
            _sonarService = sonarService;
            _squadService = squadService;
            _backStageService = backStageService;
            _catalogAzureService = catalogAzureService;
            _cadastroTableStorage = cadastroTableStorage;

            InitializeComponent();
        }


        #region Eventos
        private async void DashBoardForm_Load(object sender, EventArgs e)
        {
            this.Text = "Software Catalog Desktop - v0.0.10";
            await CarregarSquads();
            txtFiltro.Focus();
        }

        private void cmbSquads_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarTreeview(cmbSquads.SelectedValue.ToString());
        }

        private async void bnFiltrar_Click(object sender, EventArgs e)
        {
            await CarregarTreeview(cmbSquads.SelectedValue.ToString());
        }
        private async void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                await CarregarTreeview(cmbSquads.SelectedValue.ToString());
                txtFiltro.SelectAll();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuSonar_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
                _utilService.OpenUrl(treeView1.SelectedNode.Tag.ToString());
        }

        private void contextMenuRepositorio_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
                _utilService.OpenUrl(treeView1.SelectedNode.Tag.ToString());

        }

        private void contextMenuDesenho_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
                _utilService.OpenUrl(treeView1.SelectedNode.Tag.ToString());

        }

        private void contextMenuReadme_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
                _utilService.OpenUrl(treeView1.SelectedNode.Tag.ToString());


        }
        private async void contextMenuNovo_Click(object sender, EventArgs e)
        {
            _cadastroTableStorage.NomeSquad = cmbSquads.SelectedValue.ToString();
            await Task.Delay(1000);
            _cadastroTableStorage.ShowDialog();
        }

        private async void contextMenuExcluir_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "mnuExcluir")
                await ExcluirAplicacaoTableStorage();

            if (e.ClickedItem.Name == "mnuCopiar")
                System.Windows.Forms.Clipboard.SetText(treeView1.SelectedNode.Text);
        }

        #endregion



        #region Metodos
        private async Task CarregarSquads()
        {
            var squads = await _squadService.ObterSquads();

            var squadsLista = _squadService.RetornaListaSquadSimplificada(squads);

            cmbSquads.DataSource = squadsLista;
            cmbSquads.DisplayMember = "displayName";
            cmbSquads.ValueMember = "name";
        }

        private async Task CarregarTreeview(string squad)
        {
            Application.UseWaitCursor = true;

            toolQuantidadeAplicacoes.Text = $"Azure: {0} : BackStage: {0} : Match: {0}";

            try
            {
                treeView1.Nodes.Clear();

                TreeNode rootNode = treeView1.Nodes.Add("Azure");

                rootNode.ContextMenuStrip = contextMenuNovo;

                cataloAzure = await _catalogAzureService.ObterCatalogoAzure(squad);
                catalogoBackStage = await _backStageService.ObterCatalogoBackStage(squad);

                catalogoBackStage = catalogoBackStage.OrderBy(x => x.metadata.name);

                int quantidadeRelacionada = 0;

                AdicionaAplicacaoCatalogoQueNaoEstaoNoCatalogoDoAzure(rootNode, catalogoBackStage);

                foreach (var itemCatalogo in cataloAzure)
                {
                    var aplicacaoBackStage = _backStageService.BuscaAplicacaoPeloAzureName(catalogoBackStage, itemCatalogo.Aplicacao);

                    if (txtFiltro.Text != "" && itemCatalogo.Aplicacao.IndexOf(txtFiltro.Text, 0, StringComparison.OrdinalIgnoreCase) == -1)
                        continue;

                    TreeNode child = new TreeNode(itemCatalogo.Aplicacao);

                    child.ContextMenuStrip = contextMenuExcluir;

                    child.ForeColor = Color.Red;

                    child.Tag = itemCatalogo.Squad;

                    if (aplicacaoBackStage != null)
                    {
                        child.ForeColor = Color.DarkGreen;

                        child.Nodes.Add(PossuiDesenho(aplicacaoBackStage));
                        child.Nodes.Add(PossuiReadMe(aplicacaoBackStage));
                        child.Nodes.Add(PossuiRepositorio(aplicacaoBackStage));
                        child.Nodes.Add(await RetornaDadosSonar(aplicacaoBackStage));

                        quantidadeRelacionada++;
                    }

                    rootNode.Nodes.Add(child);
                }

                ExpandNode(rootNode);

                treeView1.SelectedNode = treeView1.Nodes[0].FirstNode;

                toolQuantidadeAplicacoes.Text = $"Azure: {cataloAzure.Count()} : BackStage: {catalogoBackStage.Count()} : Match: {quantidadeRelacionada}";
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                MessageBox.Show(ex.Message, "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.UseWaitCursor = false;
                txtFiltro.Focus();
            }
        }

        private void ExpandNode(TreeNode child)
        {
            foreach (var item in child.Nodes)
            {
                TreeNode node = ((System.Windows.Forms.TreeNode)item);

                if (node.ForeColor != Color.Green)
                    child.Expand();

                ExpandNode(node);
            }
        }

        private TreeNode PossuiRepositorio(ApplicacaoBackStage applicacaoBackStage)
        {
            var links = applicacaoBackStage.metadata.links.FirstOrDefault(x => (x.type?.ToLower() ?? string.Empty) == "repository".ToLower());

            string possui = (links == null) ? "Não" : "Sim";

            TreeNode child = new TreeNode($"Repo: {possui}");

            if (possui == "Não")
                child.ForeColor = Color.Red;
            else
            {
                child.ForeColor = Color.Green;
                child.Tag = links.url.ToString();
                child.ContextMenuStrip = contextMenuRepositorio;
            }

            return child;
        }

        private TreeNode PossuiDesenho(ApplicacaoBackStage applicacaoBackStage)
        {
            var links = applicacaoBackStage.metadata.links.FirstOrDefault(x => (x.type?.ToLower() ?? string.Empty) == "desenho".ToLower());

            string possui = (links == null) ? "Não" : "Sim";

            TreeNode child = new TreeNode($"Desenho: {possui}");

            if (possui == "Não")
                child.ForeColor = Color.Red;
            else
            {
                child.Tag = links.url.ToString();
                child.ForeColor = Color.Green;
                child.ContextMenuStrip = contextMenuDesenho;
            }

            return child;
        }

        private TreeNode PossuiReadMe(ApplicacaoBackStage applicacaoBackStage)
        {
            var links = applicacaoBackStage.metadata.links.FirstOrDefault(x => (x.type?.ToLower() ?? string.Empty) == "ReadMe".ToLower());

            var possui = (links == null) ? "Não" : "Sim";

            TreeNode child = new TreeNode($"ReadMe: {possui}");

            if (possui == "Não")
                child.ForeColor = Color.Red;
            else
            {
                child.Tag = links.url.ToString();
                child.ForeColor = Color.Green;
                child.ContextMenuStrip = contextMenuReadme;
            }

            return child;
        }

        private async Task<TreeNode> RetornaDadosSonar(ApplicacaoBackStage applicacaoBackStage)
        {
            var projectkey = _sonarService.RetornaProjectKey(applicacaoBackStage.metadata.annotations.sonarqubeorgprojectkey);

            TreeNode child = new TreeNode($"Sonar");

            if (String.IsNullOrWhiteSpace(projectkey))
                return child;

            var sonar = await _sonarService.ObterDadosSonar(projectkey);

            if (sonar == null)
                return child;

            child.ForeColor = Color.Green;
            child.Tag = $"https://sonarcloud.io/project/overview?id={projectkey}";
            child.ContextMenuStrip = contextMenuSonar;

            if (sonar.status != "OK")
                child.ForeColor = Color.Red;

            return RetornaDetalheSonar(child, sonar, projectkey);
        }


        private TreeNode RetornaDetalheSonar(TreeNode child, Sonar sonar, string projectkey)
        {
            foreach (var condition in sonar.conditions)
            {
                var childCondition = new TreeNode(condition.metricKey);

                childCondition.ForeColor = Color.Green;
                childCondition.Tag = $"https://sonarcloud.io/project/overview?id={projectkey}";
                childCondition.ContextMenuStrip = contextMenuSonar;

                if (condition.status != "OK")
                    childCondition.ForeColor = Color.Red;

                child.Nodes.Add(childCondition);
            }

            return child;
        }

        private void AdicionaAplicacaoCatalogoQueNaoEstaoNoCatalogoDoAzure(TreeNode child, IEnumerable<ApplicacaoBackStage> applicacaoBackStage)
        {
            foreach (var aplicacao in applicacaoBackStage)
            {
                var aplicacaoName = _backStageService.RetornaCatalogoBackStageAplicacaoName(aplicacao);

                if (txtFiltro.Text != "" && aplicacaoName.IndexOf(txtFiltro.Text, 0, StringComparison.OrdinalIgnoreCase) == -1)
                    continue;

                if (!_catalogAzureService.EstaNoCatalogoAzure(cataloAzure, aplicacaoName))
                {
                    var nodeChild = new TreeNode(aplicacaoName);
                    nodeChild.ForeColor = Color.Blue;
                    child.Nodes.Add(nodeChild);
                }
            }
        }

        private async Task ExcluirAplicacaoTableStorage()
        {
            if (MessageBox.Show($"Confirma a exclusão da aplicação '{treeView1.SelectedNode.Text}' do table Storage ?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var squad = treeView1.SelectedNode.Tag.ToString();
                var aplicacao = treeView1.SelectedNode.Text;

                var excluido = await _catalogAzureService.ExcluirDoCatalogoAzure(squad, aplicacao);

                if (excluido)
                {
                    MessageBox.Show($"Aplicação '{treeView1.SelectedNode.Text}' excluida com sucesso!" + "\n" + "A atualização pode demorar alguns minutos.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    treeView1.SelectedNode.Remove();
                }
                else
                    MessageBox.Show($"Falha ao excluir aplicação '{treeView1.SelectedNode.Text}' do table Storage!", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
