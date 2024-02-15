using Microcharts;
using SkiaSharp;

namespace Btg.Views
{
    public partial class ChartPage : ContentPage
    {
        ChartViewModel viewModel;

        public ChartPage()
        {
            InitializeComponent();
            viewModel = new ChartViewModel();
            BindingContext = viewModel;
        }

        private void GerarGraficoButton_Clicked(object sender, EventArgs e)
        {
            // Aqui voc� pode acessar os valores da ViewModel
            // viewModel.PrecoInicial, viewModel.Volatilidade, viewModel.MediaRetorno, viewModel.Tempo

            // Use esses valores para gerar os dados do gr�fico
            ChartEntry[] brownianoEntries = new[]
            {
                new ChartEntry((float)viewModel.PrecoInicial)
                {
                    Label = "Pre�o Inicial",
                    ValueLabel = viewModel.PrecoInicial.ToString(),
                    Color = SKColor.Parse("#266489")
                },
                new ChartEntry((float)viewModel.Volatilidade)
                {
                    Label = "Volatilidade",
                    ValueLabel = viewModel.Volatilidade.ToString(),
                    Color = SKColor.Parse("#68B9C0")
                },
                new ChartEntry((float)viewModel.MediaRetorno)
                {
                    Label = "M�dia do Retorno",
                    ValueLabel = viewModel.MediaRetorno.ToString(),
                    Color = SKColor.Parse("#90D585")
                },
                new ChartEntry((float)viewModel.Tempo)
                {
                    Label = "Tempo",
                    ValueLabel = viewModel.Tempo.ToString(),
                    Color = SKColor.Parse("#68b9d0")
                },
            };

            // Aqui voc� pode usar 'brownianoEntries' para atualizar o gr�fico
            myChart.Chart = new LineChart()
            {
                Entries = brownianoEntries
            };
        }
    }
}
