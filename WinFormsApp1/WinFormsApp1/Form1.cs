using Microsoft.ML;
using Microsoft.ML.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private MLContext mlContext;
        private ITransformer model;
        private PredictionEngine<KiloVerisi, KiloTahmini> predictionEngine;

        public Form1()
        {
            InitializeComponent();
            MLModelHazirla();
        }

        public class KiloVerisi
        {
            public float Boy { get; set; }
            public float Kilo { get; set; }
        }

        // Çýktý sýnýfý
        public class KiloTahmini
        {
            [ColumnName("Score")]
            public float Kilo { get; set; }
        }

        private void MLModelHazirla()
        {
            mlContext = new MLContext();

            var veri = new[]
            {
                new KiloVerisi { Boy = 160, Kilo = 55 },
                new KiloVerisi { Boy = 165, Kilo = 60 },
                new KiloVerisi { Boy = 170, Kilo = 65 },
                new KiloVerisi { Boy = 175, Kilo = 70 },
                new KiloVerisi { Boy = 180, Kilo = 75 },
                new KiloVerisi { Boy = 185, Kilo = 80 },
            };

            var data = mlContext.Data.LoadFromEnumerable(veri);

            var pipeline = mlContext.Transforms.Concatenate("Features", "Boy")
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Kilo"));

            model = pipeline.Fit(data);
            predictionEngine = mlContext.Model.CreatePredictionEngine<KiloVerisi, KiloTahmini>(model);
        }


        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBoy.Text, out float boy))
            {
                var tahmin = predictionEngine.Predict(new KiloVerisi { Boy = boy });
                lblSonuc.Text = $"Tahmini Kilo: {tahmin.Kilo:F2} kg";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin.");
            }
        }
    }
}
