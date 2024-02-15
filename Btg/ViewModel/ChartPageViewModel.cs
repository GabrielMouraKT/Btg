using System.ComponentModel;
using Microcharts;
using SkiaSharp;

namespace Btg.Views
{
    public class ChartViewModel : INotifyPropertyChanged
    {
        private double precoInicial;
        public double PrecoInicial
        {
            get { return precoInicial; }
            set
            {
                if (precoInicial != value)
                {
                    precoInicial = value;
                    OnPropertyChanged(nameof(PrecoInicial));
                }
            }
        }

        private double volatilidade;
        public double Volatilidade
        {
            get { return volatilidade; }
            set
            {
                if (volatilidade != value)
                {
                    volatilidade = value;
                    OnPropertyChanged(nameof(Volatilidade));
                }
            }
        }

        private double mediaRetorno;
        public double MediaRetorno
        {
            get { return mediaRetorno; }
            set
            {
                if (mediaRetorno != value)
                {
                    mediaRetorno = value;
                    OnPropertyChanged(nameof(MediaRetorno));
                }
            }
        }

        private double tempo;
        public double Tempo
        {
            get { return tempo; }
            set
            {
                if (tempo != value)
                {
                    tempo = value;
                    OnPropertyChanged(nameof(Tempo));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
