using ConsoleApp1;
using System.Net.Http.Headers;

namespace FFE
{
    public partial class Form1 : Form
    {
        public List<List<double>> PlanningMatrixFe { get; set; }
        public List<double> NormalizedCoefficientsFe { get; set; } = new List<double>();
        public string[][] GridViewMatrixFe { get; set; }
        public List<string> ColNamesFe { get; set; }

        public List<List<double>> PlanningMatrixFfd { get; set; }
        public List<double> NormalizedCoefficientsFfd { get; set; } = new List<double>();
        public string[][] GridViewMatrixFfd { get; set; }
        public List<string> ColNamesFfd { get; set; }

        public List<double> MinFactors { get; set; } = new List<double>();
        public List<double> MaxFactors { get; set; } = new List<double>();

        public static double NaturalToNormalized(double natural_min, double natural_max, double natural)
        {
            double natural_null_lvl = (natural_min + natural_max) / 2;
            double delta_natural = natural_max - natural_null_lvl;

            return (natural - natural_null_lvl) / delta_natural;
        }

        public static double NormalizedToNatural(double natural_min, double natural_max, double normalized)
        {
            double natural_null_lvl = (natural_min + natural_max) / 2;
            double delta_natural = natural_max - natural_null_lvl;

            return natural_null_lvl + normalized * delta_natural;
        }

        public void ReadCsvFe(string filename)
        {
            PlanningMatrixFe = new List<List<double>>();
            ColNamesFe = new List<string>();
            GridViewMatrixFe = new string[256][];

            using (var reader = new StreamReader(filename))
            {
                var line = reader.ReadLine();
                var values = line.Split(','); // пропускаем строку с названиями столбцов
                ColNamesFe = values.ToList();
                int j = 0;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(',');
                    List<double> matrix_row = new List<double>();

                    for (int i = 0; i < values.Count() - 1; ++i)
                    {
                        matrix_row.Add(Convert.ToDouble(values[i]));
                    }

                    PlanningMatrixFe.Add(matrix_row);
                    GridViewMatrixFe[j] = values;
                    ++j;
                }
            }
        }

        public void ReadCsvFfd(string filename)
        {
            PlanningMatrixFfd = new List<List<double>>();
            ColNamesFfd = new List<string>();
            GridViewMatrixFfd = new string[FFD_N][];

            using (var reader = new StreamReader(filename))
            {
                var line = reader.ReadLine();
                var values = line.Split(','); // пропускаем строку с названиями столбцов
                ColNamesFfd = values.ToList();
                int j = 0;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(',');
                    List<double> matrix_row = new List<double>();

                    for (int i = 0; i < values.Count() - 1; ++i)
                    {
                        matrix_row.Add(Convert.ToDouble(values[i]));
                    }

                    PlanningMatrixFfd.Add(matrix_row);
                    GridViewMatrixFfd[j] = values;
                    ++j;
                }
            }
        }

        public void Experiment()
        {
            for (int i = 0; i < 256; ++i)
            {
                double gen1intensity = PlanningMatrixFe[i][2]; // 0 - номер опыта, 1 - x0
                double gen2intensity = PlanningMatrixFe[i][3];
                double proc1intensity = PlanningMatrixFe[i][4];
                double proc2intensity = PlanningMatrixFe[i][5];
                double gen1var = PlanningMatrixFe[i][6];
                double gen2var = PlanningMatrixFe[i][7];
                double proc1var = PlanningMatrixFe[i][8];
                double proc2var = PlanningMatrixFe[i][9];

                Generator gen1 = new Generator(NormalizedToNatural(MinFactors[0], MaxFactors[0], gen1intensity),
                                               NormalizedToNatural(MinFactors[4], MaxFactors[4], gen1var));
                Generator gen2 = new Generator(NormalizedToNatural(MinFactors[1], MaxFactors[1], gen2intensity),
                                               NormalizedToNatural(MinFactors[5], MaxFactors[5], gen2var));
                Operator proc = new Operator(NormalizedToNatural(MinFactors[2], MaxFactors[2], proc1intensity),
                                             NormalizedToNatural(MinFactors[6], MaxFactors[6], proc1var),
                                             NormalizedToNatural(MinFactors[3], MaxFactors[3], proc2intensity),
                                             NormalizedToNatural(MinFactors[7], MaxFactors[7], proc2var));
                QueuingSystem qs = new QueuingSystem(new List<Generator> { gen1, gen2 }, new List<Operator> { proc });

                double res = 0;

                for (int j = 0; j < 10; ++j)
                {
                    qs.Simulate(100);
                    res += qs.meanWaitingTime;
                }

                PlanningMatrixFe[i].Add(res / 10);
            }
        }

        public void ExperimentFfd()
        {
            for (int i = 0; i < FFD_N; ++i)
            {
                double gen1intensity = PlanningMatrixFfd[i][2]; // 0 - номер опыта, 1 - x0
                double gen2intensity = PlanningMatrixFfd[i][3];
                double proc1intensity = PlanningMatrixFfd[i][4];
                double proc2intensity = PlanningMatrixFfd[i][5];
                double gen1var = PlanningMatrixFfd[i][6];
                double gen2var = PlanningMatrixFfd[i][7];
                double proc1var = PlanningMatrixFfd[i][8];
                double proc2var = PlanningMatrixFfd[i][9];

                Generator gen1 = new Generator(NormalizedToNatural(MinFactors[0], MaxFactors[0], gen1intensity),
                                               NormalizedToNatural(MinFactors[4], MaxFactors[4], gen1var));
                Generator gen2 = new Generator(NormalizedToNatural(MinFactors[1], MaxFactors[1], gen2intensity),
                                               NormalizedToNatural(MinFactors[5], MaxFactors[5], gen2var));
                Operator proc = new Operator(NormalizedToNatural(MinFactors[2], MaxFactors[2], proc1intensity),
                                             NormalizedToNatural(MinFactors[6], MaxFactors[6], proc1var),
                                             NormalizedToNatural(MinFactors[3], MaxFactors[3], proc2intensity),
                                             NormalizedToNatural(MinFactors[7], MaxFactors[7], proc2var));
                QueuingSystem qs = new QueuingSystem(new List<Generator> { gen1, gen2 }, new List<Operator> { proc });

                double res = 0;

                for (int j = 0; j < 10; ++j)
                {
                    qs.Simulate(100);
                    res += qs.meanWaitingTime;
                }

                PlanningMatrixFfd[i].Add(res / 10);
            }
        }

        public void CountNormalizedCoefficientsFe()
        {
            for (int i = 1; i < 257; ++i)
            {
                double coefficient = 0;

                for (int j = 0; j < 256; ++j)
                {
                    coefficient += (PlanningMatrixFe[j][i] * PlanningMatrixFe[j][257]);
                }

                NormalizedCoefficientsFe.Add(coefficient / 256.0);
            }
        }

        public void CountNormalizedCoefficientsFfd()
        {
            for (int i = 1; i < FFD_N + 1; ++i)
            {
                double coefficient = 0;

                for (int j = 0; j < FFD_N; ++j)
                {
                    coefficient += (PlanningMatrixFfd[j][i] * PlanningMatrixFfd[j][FFD_N + 1]);
                }

                NormalizedCoefficientsFfd.Add(coefficient / 256.0);
            }
        }

        public void EstimateNormalized()
        {
            for (int i = 0; i < 256; ++i)
            {
                double linear_time = 0;

                for (int j = 0; j < 9; ++j)
                {
                    linear_time += (PlanningMatrixFe[i][j + 1] * NormalizedCoefficientsFe[j]);
                }

                PlanningMatrixFe[i].Add(linear_time);
                PlanningMatrixFe[i].Add(linear_time - PlanningMatrixFe[i][257]);

                double non_linear_time = 0;

                for (int j = 0; j < NormalizedCoefficientsFe.Count; ++j)
                {
                    non_linear_time += (PlanningMatrixFe[i][j + 1] * NormalizedCoefficientsFe[j]);
                }

                PlanningMatrixFe[i].Add(non_linear_time);
                PlanningMatrixFe[i].Add(non_linear_time - PlanningMatrixFe[i][257]);
            }
        }

        public void EstimateNormalizedFfd()
        {
            for (int i = 0; i < FFD_N; ++i)
            {
                double linear_time = 0;

                for (int j = 0; j < 9; ++j)
                {
                    linear_time += (PlanningMatrixFfd[i][j + 1] * NormalizedCoefficientsFfd[j]);
                }

                PlanningMatrixFfd[i].Add(linear_time);
                PlanningMatrixFfd[i].Add(linear_time - PlanningMatrixFfd[i][FFD_N + 1]);

                double non_linear_time = 0;

                for (int j = 0; j < NormalizedCoefficientsFfd.Count; ++j)
                {
                    non_linear_time += (PlanningMatrixFfd[i][j + 1] * NormalizedCoefficientsFfd[j]);
                }

                PlanningMatrixFfd[i].Add(non_linear_time);
                PlanningMatrixFfd[i].Add(non_linear_time - PlanningMatrixFfd[i][FFD_N + 1]);
            }
        }

        public double Simulate(List<double> normalizedFactors)
        {
            Generator gen1 = new Generator(normalizedFactors[1], normalizedFactors[5]);
            Generator gen2 = new Generator(normalizedFactors[2], normalizedFactors[6]);
            Operator proc = new Operator(normalizedFactors[3], normalizedFactors[7],
                                         normalizedFactors[4], normalizedFactors[8]);
            QueuingSystem qs = new QueuingSystem(new List<Generator> { gen1, gen2 }, new List<Operator> { proc });

            double res = 0;

            for (int j = 0; j < 10; ++j)
            {
                qs.Simulate(100);
                res += qs.meanWaitingTime;
            }

            return res / 10;
        }

        public double CountNonLinear(List<double> _normalizedFactors)
        {
            List<double> normalizedFactors = new List<double>(_normalizedFactors);

            for (int i = 1; i < normalizedFactors.Count; ++i)
            {
                normalizedFactors[i] = NormalizedToNatural(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
            }

            double non_linear_time = 0;

            for (int i = 10; i < 257; ++i)
            {
                var line = ColNamesFe[i];
                var values = line.Split('x').ToList();
                double mul = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    mul *= normalizedFactors[Convert.ToInt32(values[j])];
                }

                normalizedFactors.Add(mul);
            }

            for (int i = 0; i < NormalizedCoefficientsFe.Count; ++i)
            {
                non_linear_time += (NormalizedCoefficientsFe[i] * normalizedFactors[i]);
            }

            return non_linear_time;
        }

        public double CountLinearFfd(List<double> _normalizedFactors)
        {
            List<double> normalizedFactors = new List<double>(_normalizedFactors);

            for (int i = 1; i < normalizedFactors.Count; ++i)
            {
                normalizedFactors[i] = NormalizedToNatural(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
            }

            double non_linear_time = 0;

            for (int i = 0; i < 9; ++i)
            {
                non_linear_time += (NormalizedCoefficientsFfd[i] * normalizedFactors[i]);
            }

            return non_linear_time;
        }

        public double CountNonLinearFfd(List<double> _normalizedFactors)
        {
            List<double> normalizedFactors = new List<double>(_normalizedFactors);

            for (int i = 1; i < normalizedFactors.Count; ++i)
            {
                normalizedFactors[i] = NormalizedToNatural(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
            }

            double non_linear_time = 0;

            for (int i = 10; i < FFD_N + 1; ++i)
            {
                var line = ColNamesFfd[i];
                var values = line.Split('x').ToList();
                double mul = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    mul *= normalizedFactors[Convert.ToInt32(values[j])];
                }

                normalizedFactors.Add(mul);
            }

            for (int i = 0; i < NormalizedCoefficientsFfd.Count; ++i)
            {
                non_linear_time += (NormalizedCoefficientsFfd[i] * normalizedFactors[i]);
            }

            return non_linear_time;
        }

        public Form1()
        {
            InitializeComponent();

            ReadCsvFe(@"D:\bmstu\ics7-edt\lab_03\FFE\fe.csv");

            foreach (var col_name in ColNamesFe!)
            {
                FEGridView.Columns.Add(col_name, col_name);
            }

            foreach (var row in GridViewMatrixFe!)
            {
                FEGridView.Rows.Add(row);
            }

            ReadCsvFfd(@"D:\bmstu\ics7-edt\lab_03\FFE\ffd.csv");

            foreach (var col_name in ColNamesFfd!)
            {
                FFDGridView.Columns.Add(col_name, col_name);
            }

            foreach (var row in GridViewMatrixFfd!)
            {
                FFDGridView.Rows.Add(row);
            }
        }

        private void ModelBtn_Click(object sender, EventArgs e)
        {
            var factors = new List<double>() { 1, Convert.ToDouble(Gen1Intensity.Text), Convert.ToDouble(Gen2Intensity.Text),
                                                  Convert.ToDouble(Proc1Intensity.Text), Convert.ToDouble(Proc2Intensity.Text),
                                                  Convert.ToDouble(Gen1Var.Text), Convert.ToDouble(Gen2Var.Text),
                                                  Convert.ToDouble(Proc1Var.Text), Convert.ToDouble(Proc2Var.Text)};
            FactTime.Text = Convert.ToString(Math.Round(Simulate(factors), 3));
            NonLinearTime.Text = Convert.ToString(Math.Round(CountNonLinear(factors), 3));
            FFDNonLinearTime.Text = Convert.ToString(Math.Round(CountLinearFfd(factors), 3));
        }

        private string CreateLinearEquation()
        {
            string linear = "y=";

            for (int i = 0; i < 9; ++i)
            {
                if (NormalizedCoefficientsFe[i] < 0)
                {
                    linear += $"{Math.Round(NormalizedCoefficientsFe[i], 3)}*{ColNamesFe[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(NormalizedCoefficientsFe[i], 3)}*{ColNamesFe[i + 1]}";
                }
            }

            return linear;
        }

        private string CreateLinearEquationFfd()
        {
            string linear = "y=";

            for (int i = 0; i < 9; ++i)
            {
                if (NormalizedCoefficientsFfd[i] < 0)
                {
                    linear += $"{Math.Round(NormalizedCoefficientsFfd[i], 3)}*{ColNamesFfd[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(NormalizedCoefficientsFfd[i], 3)}*{ColNamesFfd[i + 1]}";
                }
            }

            return linear;
        }

        private string CreateNaturalLinearEquationFfd(List<double> coefficients)
        {
            string linear = "y=";

            for (int i = 0; i < 9; ++i)
            {
                if (coefficients[i] < 0)
                {
                    linear += $"{Math.Round(coefficients[i], 3)}*{ColNamesFfd[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(coefficients[i], 3)}*{ColNamesFfd[i + 1]}";
                }
            }

            return linear;
        }

        private string CreateNonLinearEquation()
        {
            string linear = "y=";

            for (int i = 0; i < NormalizedCoefficientsFe.Count; ++i)
            {
                if (NormalizedCoefficientsFe[i] < 0)
                {
                    linear += $"{Math.Round(NormalizedCoefficientsFe[i], 3)}*{ColNamesFe[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(NormalizedCoefficientsFe[i], 3)}*{ColNamesFe[i + 1]}";
                }
            }

            return linear;
        }

        private string CreateNonLinearEquationFfd()
        {
            string linear = "y=";

            for (int i = 0; i < NormalizedCoefficientsFfd.Count; ++i)
            {
                if (NormalizedCoefficientsFfd[i] < 0)
                {
                    linear += $"{Math.Round(NormalizedCoefficientsFfd[i], 3)}*{ColNamesFfd[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(NormalizedCoefficientsFfd[i], 3)}*{ColNamesFfd[i + 1]}";
                }
            }

            return linear;
        }

        private List<double> NormalizedToNaturalCoefficients(List<double> normalizedCoefficients)
        {
            List<double> naturalCoefficients = new List<double>();

            double sum = 0;
            for (int i = 1; i < 9; ++i)
            {
                sum += (normalizedCoefficients[i] * (MaxFactors[i - 1] + MinFactors[i - 1]) / (MaxFactors[i - 1] - MinFactors[i - 1]));
            }
            naturalCoefficients.Add(normalizedCoefficients[0] - sum);

            for (int i = 1; i < 9; ++i)
            {
                double naturalCoefficient = (2 * normalizedCoefficients[i]) / (MaxFactors[i - 1] - MinFactors[i - 1]);

                naturalCoefficients.Add(naturalCoefficient);
            }

            return naturalCoefficients;
        }

        private void InitFactors()
        {
            MinFactors.Clear();
            MinFactors.Add(Convert.ToDouble(X1Min.Text));
            MinFactors.Add(Convert.ToDouble(X2Min.Text));
            MinFactors.Add(Convert.ToDouble(X3Min.Text));
            MinFactors.Add(Convert.ToDouble(X4Min.Text));
            MinFactors.Add(Convert.ToDouble(X5Min.Text));
            MinFactors.Add(Convert.ToDouble(X6Min.Text));
            MinFactors.Add(Convert.ToDouble(X7Min.Text));
            MinFactors.Add(Convert.ToDouble(X8Min.Text));

            MaxFactors.Clear();
            MaxFactors.Add(Convert.ToDouble(X1Max.Text));
            MaxFactors.Add(Convert.ToDouble(X2Max.Text));
            MaxFactors.Add(Convert.ToDouble(X3Max.Text));
            MaxFactors.Add(Convert.ToDouble(X4Max.Text));
            MaxFactors.Add(Convert.ToDouble(X5Max.Text));
            MaxFactors.Add(Convert.ToDouble(X6Max.Text));
            MaxFactors.Add(Convert.ToDouble(X7Max.Text));
            MaxFactors.Add(Convert.ToDouble(X8Max.Text));
        }

        private void FEBtn_Click(object sender, EventArgs e)
        {
            InitFactors();

            Experiment();
            for (int i = 0; i < 256; ++i)
            {
                FEGridView.Rows[i].Cells[257].Value = Math.Round(PlanningMatrixFe[i][257], 3);
            }

            CountNormalizedCoefficientsFe();

            NormLinear.Text = CreateLinearEquation();
            NormNonLinear.Text = CreateNonLinearEquation();

            EstimateNormalized();
            for (int i = 0; i < 256; ++i)
            {
                FEGridView.Rows[i].Cells[258].Value = Math.Round(PlanningMatrixFe[i][258], 3);
                FEGridView.Rows[i].Cells[259].Value = Math.Round(PlanningMatrixFe[i][259], 3);
                FEGridView.Rows[i].Cells[260].Value = Math.Round(PlanningMatrixFe[i][260], 3);
                FEGridView.Rows[i].Cells[261].Value = Math.Round(PlanningMatrixFe[i][261], 3);
            }
        }

        private void FFDBtn_Click(object sender, EventArgs e)
        {
            InitFactors();

            ExperimentFfd();
            for (int i = 0; i < FFD_N; ++i)
            {
                FFDGridView.Rows[i].Cells[FFD_N + 1].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 1], 3);
            }

            CountNormalizedCoefficientsFfd();

            FFDNormLinear.Text = CreateLinearEquationFfd();
            FFDNaturLinear.Text = CreateNaturalLinearEquationFfd(NormalizedToNaturalCoefficients(NormalizedCoefficientsFfd));
            FFDNormNonLinear.Text = CreateNonLinearEquationFfd();

            EstimateNormalizedFfd();
            for (int i = 0; i < FFD_N; ++i)
            {
                FFDGridView.Rows[i].Cells[FFD_N + 2].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 2], 3);
                FFDGridView.Rows[i].Cells[FFD_N + 3].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 3], 3);
                FFDGridView.Rows[i].Cells[FFD_N + 4].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 4], 3);
                FFDGridView.Rows[i].Cells[FFD_N + 5].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 5], 3);
            }
        }

        private readonly int FFD_N = 16;
    }
}
