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
            // Aqui você pode acessar os valores da ViewModel
            double precoInicialValue = viewModel.PrecoInicial;
            double volatilidadeValue = viewModel.Volatilidade;
            double mediaRetornoValue = viewModel.MediaRetorno;
            double tempoValue = viewModel.Tempo;

            // Calcula o preço usando a função GenerateBrownianMotion
            double[] simulatedPrices = Btg.Utils.SimulationUtils.GenerateBrownianMotion(volatilidadeValue, mediaRetornoValue, precoInicialValue, (int)tempoValue);

            // Cria os ChartEntries com base nos preços simulados
            ChartEntry[] brownianoEntries = new ChartEntry[simulatedPrices.Length];
            for (int i = 0; i < simulatedPrices.Length; i++)
            {
                brownianoEntries[i] = new ChartEntry((float)simulatedPrices[i])
                {
                    Color = SKColor.Parse("#7a00dd")
                };
            }



            // Atualiza o gráfico como um gráfico de linha
            myChart.Chart = new LineChart()
            {
                Entries = brownianoEntries,
                LineMode = LineMode.Spline,
                LineSize = 1,
                PointMode = PointMode.None, // Remover pontos
                LabelTextSize = 0 // Define o tamanho do texto do rótulo como 0 para ocultar os rótulos dos dias
            };
        }
    }
}
