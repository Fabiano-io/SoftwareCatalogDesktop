using SoftwareCatalog.Business.Contracts;

namespace SoftwareCatalog.App.Forms
{
    public partial class CadastroTableStorage : Form
    {
        public string NomeSquad;

        private readonly ISquadService _squadService;
        private readonly ICatalogAzureService _catalogAzureService;
        public CadastroTableStorage(ISquadService squadService,
                                    ICatalogAzureService catalogAzureService)
        {
            _squadService = squadService;
            _catalogAzureService = catalogAzureService;

            InitializeComponent();
        }


        #region Eventos
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CadastroTableStorage_Load(object sender, EventArgs e)
        {
            this.Text = "Salva uma determinada aplicação no table Storage";
            txtNomeAplicacao.Text = string.Empty;
            txtTipoAplicacao.Text = string.Empty;
            await CarregarSquads();
            txtNomeAplicacao.Focus();

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
                await Salvar();
        }

        private void cmbSquads_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNomeAplicacao.Focus();
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

            cmbSquads.SelectedValue = NomeSquad;
        }

        private bool ValidaCampos()
        {
            if (cmbSquads.SelectedValue.ToString().ToUpper() == "CONECTCAR")
            {
                MessageBox.Show($"Selecione o nome da Squad!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(txtNomeAplicacao.Text))
            {
                MessageBox.Show($"Informe o nome da aplicação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(txtTipoAplicacao.Text))
            {
                MessageBox.Show($"Informe o tipo da aplicação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private async Task Salvar()
        {
            var resultado = await _catalogAzureService.CadastraNoCatalogoAzure(cmbSquads.SelectedValue.ToString(), txtNomeAplicacao.Text, txtTipoAplicacao.Text);

            if (resultado)
            {
                MessageBox.Show($"Aplicação '{txtNomeAplicacao.Text}' cadastrada com sucesso!" + "\n" + "A atualização pode demorar alguns minutos.",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show($"Falha ao cadastrar a aplicação '{txtNomeAplicacao.Text}'", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
