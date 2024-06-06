using ConsoleApp1;
using System.Net.Http.Headers;

namespace FFE
{
    public partial class Form1 : Form
    {
        private static readonly int N = 8;
        private static readonly int K = 2;
        private static readonly int N_FFD = 64;
        private static readonly int N_SP = 16;
        private static readonly int N_C = 1;
        private static readonly int N_SUM = 81;
        private static readonly int N_COEFF = 45;
        private static readonly double ALPHA = 2.0001;
        private static readonly double A = 0.8889;

        public List<List<double>> PlanningMatrix { get; set; } = new List<List<double>>();
        public List<double> NormalizedCoefficients { get; set; } = new List<double>();
        public List<double> NaturalCoefficients { get; set; } = new List<double>();
        public string[][] GridViewMatrix { get; set; } = new string[N_SUM][];
        public List<string> ColNames { get; set; } = new List<string>();

        public List<double> MinFactors { get; set; } = new List<double>();
        public List<double> MaxFactors { get; set; } = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

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

        public void ReadCsv(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                var line = reader.ReadLine();
                var values = line.Split(';'); // пропускаем строку с названиями столбцов
                ColNames = values.ToList();
                int j = 0;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(';');
                    List<double> matrix_row = new List<double>();

                    for (int i = 0; i < values.Count() - 1; ++i)
                    {
                        matrix_row.Add(Convert.ToDouble(values[i]));
                    }

                    PlanningMatrix.Add(matrix_row);
                    GridViewMatrix[j] = values;
                    ++j;
                }
            }
        }

        public void Experiment()
        {
            for (int i = 0; i < N_SUM; ++i)
            {
                double gen1intensity = PlanningMatrix[i][2]; // 0 - номер опыта, 1 - x0
                double gen2intensity = PlanningMatrix[i][3];
                double proc1intensity = PlanningMatrix[i][4];
                double proc2intensity = PlanningMatrix[i][5];
                double gen1var = PlanningMatrix[i][6];
                double gen2var = PlanningMatrix[i][7];
                double proc1var = PlanningMatrix[i][8];
                double proc2var = PlanningMatrix[i][9];

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

                PlanningMatrix[i].Add(res / 10);
            }
        }

        public void CountNormalizedCoefficients()
        {
            for (int i = 1; i < N_COEFF + 1; ++i)
            {
                double up = 0.0;
                double down = 0.0;

                for (int j = 0; j < N_SUM; ++j)
                {
                    up += (PlanningMatrix[j][i] * PlanningMatrix[j][N_COEFF + 1]);
                    down += (PlanningMatrix[j][i] * PlanningMatrix[j][i]);
                }

                NormalizedCoefficients.Add(up / down);
            }
        }

        public void CountNaturalCoefficients(List<double> normalizedCoefficients, List<double> minFactors, List<double> maxFactors)
        {
            double b_0 = normalizedCoefficients[0];

            for (int i = 1; i < N + 1; ++i)
            {
                double zero_lvl = (maxFactors[i - 1] + minFactors[i - 1]) / 2.0;
                double interval = (maxFactors[i - 1] - minFactors[i - 1]) / 2.0;

                b_0 -= ((normalizedCoefficients[i] * zero_lvl) / interval);
            }

            for (int i = N + 1; i < N_COEFF - N; ++i)
            {
                string colName = ColNames[i + 1];
                var indices = colName.Split('x');

                double zero_lvl_1 = (maxFactors[Convert.ToInt32(indices[1]) - 1] + minFactors[Convert.ToInt32(indices[1]) - 1]) / 2.0;
                double interval_1 = (maxFactors[Convert.ToInt32(indices[1]) - 1] - minFactors[Convert.ToInt32(indices[1]) - 1]) / 2.0;

                double zero_lvl_2 = (maxFactors[Convert.ToInt32(indices[2]) - 1] + minFactors[Convert.ToInt32(indices[2]) - 1]) / 2.0;
                double interval_2 = (maxFactors[Convert.ToInt32(indices[2]) - 1] - minFactors[Convert.ToInt32(indices[2]) - 1]) / 2.0;

                b_0 += ((normalizedCoefficients[i] * zero_lvl_1 * zero_lvl_2) / (interval_1 * interval_2));
            }

            for (int i = N_COEFF - N, j = 0; i < N_COEFF; ++i, ++j)
            {
                double zero_lvl = (maxFactors[j] + minFactors[j]) / 2.0;
                double interval = (maxFactors[j] - minFactors[j]) / 2.0;

                b_0 += ((normalizedCoefficients[i] * zero_lvl * zero_lvl) / (interval * interval));
            }

            NaturalCoefficients.Add(b_0);

            //for (int i = 1, k = N + 1; i < N + 1; ++i)
            //{
            //    double interval = (maxFactors[i - 1] - minFactors[i - 1]) / 2.0;
            //    double zero_lvl = (maxFactors[i - 1] + minFactors[i - 1]) / 2.0;

            //    double linearCoefficient = NormalizedCoefficients[i] / interval;

            //    for (int j = i + 1; j < N + 1; ++j)
            //    {
            //        double zero_lvl_2 = (maxFactors[j - 1] + minFactors[j - 1]) / 2.0;
            //        double interval_2 = (maxFactors[j - 1] - minFactors[j - 1]) / 2.0;

            //        linearCoefficient -= ((normalizedCoefficients[k++] * zero_lvl_2) / (interval * interval_2));
            //    }

            //    linearCoefficient -= ((2 * normalizedCoefficients[N_COEFF - N - 1 + i] * zero_lvl) / (interval * interval));

            //    NaturalCoefficients.Add(linearCoefficient);
            //}

            for (int i = 1, k = N + 1; i < N + 1; ++i)
            {
                double interval = (maxFactors[i - 1] - minFactors[i - 1]) / 2.0;
                double zero_lvl = (maxFactors[i - 1] + minFactors[i - 1]) / 2.0;

                double linearCoefficient = NormalizedCoefficients[i] / interval;

                for (int j = N + 1; j < N_COEFF - N; ++j)
                {
                    var line = ColNames[j + 1];
                    var values = line.Split('x').ToList();
                    
                    int index_1 = Convert.ToInt32(values[1]);
                    int index_2 = Convert.ToInt32(values[2]);

                    if (index_1 == i)
                    {
                        double zero_lvl_2 = (maxFactors[index_2 - 1] + minFactors[index_2 - 1]) / 2.0;
                        double interval_2 = (maxFactors[index_2 - 1] - minFactors[index_2 - 1]) / 2.0;

                        linearCoefficient -= ((normalizedCoefficients[j] * zero_lvl_2) / (interval * interval_2));
                    }
                    else if (index_2 == i)
                    {
                        double zero_lvl_2 = (maxFactors[index_1 - 1] + minFactors[index_1 - 1]) / 2.0;
                        double interval_2 = (maxFactors[index_1 - 1] - minFactors[index_1 - 1]) / 2.0;

                        linearCoefficient -= ((normalizedCoefficients[j] * zero_lvl_2) / (interval * interval_2));
                    }
                }

                linearCoefficient -= ((2 * normalizedCoefficients[N_COEFF - N - 1 + i] * zero_lvl) / (interval * interval));

                NaturalCoefficients.Add(linearCoefficient);
            }

            // non-linear coeffs
            for (int i = N + 1; i < N_COEFF - N; ++i)
            {
                string colName = ColNames[i + 1];
                var indices = colName.Split('x');

                double interval_1 = (maxFactors[Convert.ToInt32(indices[1]) - 1] - minFactors[Convert.ToInt32(indices[1]) - 1]) / 2.0;
                double interval_2 = (maxFactors[Convert.ToInt32(indices[2]) - 1] - minFactors[Convert.ToInt32(indices[2]) - 1]) / 2.0;

                double nonLinearCoefficient = ((normalizedCoefficients[i]) / (interval_1 * interval_2));

                NaturalCoefficients.Add(nonLinearCoefficient);
            }

            // sqr coeffs
            for (int i = N_COEFF - N, j = 0; i < N_COEFF; ++i, ++j)
            {
                double interval = (maxFactors[j] - minFactors[j]) / 2.0;

                double sqrCoefficient = ((normalizedCoefficients[i]) / (interval * interval));
                NaturalCoefficients.Add(sqrCoefficient);
            }
        }

        public void EstimateNormalized()
        {
            for (int i = 0; i < N_SUM; ++i)
            {
                double time = 0;

                for (int j = 0; j < NormalizedCoefficients.Count; ++j)
                {
                    time += (PlanningMatrix[i][j + 1] * NormalizedCoefficients[j]);
                }

                PlanningMatrix[i].Add(time);
                double diff = time - PlanningMatrix[i][N_COEFF + 1];
                PlanningMatrix[i].Add(diff);
                PlanningMatrix[i].Add(diff * diff);
            }
        }

        private double Simulate(List<double> naturalFactors)
        {
            Generator gen1 = new Generator(naturalFactors[1], naturalFactors[5]);
            Generator gen2 = new Generator(naturalFactors[2], naturalFactors[6]);
            Operator proc = new Operator(naturalFactors[3], naturalFactors[7],
                                         naturalFactors[4], naturalFactors[8]);
            QueuingSystem qs = new QueuingSystem(new List<Generator> { gen1, gen2 }, new List<Operator> { proc });

            double res = 0;

            for (int j = 0; j < 10; ++j)
            {
                qs.Simulate(100);
                res += qs.meanWaitingTime;
            }

            return res / 10;
        }

        private double CountNormalizedEquation(List<double> naturalFactors)
        {
            List<double> normalizedFactors = new List<double>();

            for (int i = 1; i < naturalFactors.Count; ++i)
            {
                normalizedFactors.Add(NaturalToNormalized(MinFactors[i - 1], MaxFactors[i - 1], naturalFactors[i]));
            }

            double res = NormalizedCoefficients[0];

            for (int i = 2; i < N_COEFF + 1; ++i)
            {
                var line = ColNames[i];
                var values = line.Split('x').ToList();

                double newVal = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    newVal *= normalizedFactors[Convert.ToInt32(values[j]) - 1];
                }

                res += (newVal * NormalizedCoefficients[i - 1]);
            }

            return res;
        }

        private double CountNaturalEquation(List<double> naturalFactors)
        {
            double res = NaturalCoefficients[0];

            for (int i = 2; i < N_COEFF + 1; ++i)
            {
                var line = ColNames[i];
                var values = line.Split('x').ToList();
                double newVal = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    newVal *= naturalFactors[Convert.ToInt32(values[j])];
                }

                res += (newVal * NaturalCoefficients[i - 1]);
            }

            return res;
        }

        private void ModelBtn_Click(object sender, EventArgs e)
        {
            var factors = new List<double>() { 1, Convert.ToDouble(Gen1Intensity.Text), Convert.ToDouble(Gen2Intensity.Text),
                                                  Convert.ToDouble(Proc1Intensity.Text), Convert.ToDouble(Proc2Intensity.Text),
                                                  Convert.ToDouble(Gen1Var.Text), Convert.ToDouble(Gen2Var.Text),
                                                  Convert.ToDouble(Proc1Var.Text), Convert.ToDouble(Proc2Var.Text)};

            double factTime = Simulate(factors);
            double ffdTime = CountNormalizedEquation(factors);
            double ffdDiff = ffdTime - factTime;
            double ffdSqrDiff = ffdDiff * ffdDiff;

            loadingTextBox.Text = Convert.ToString(Math.Round(((factors[1] + factors[2]) / ((factors[3] + factors[4]) / 2.0)), 3));
            factTimeTextBox.Text = Convert.ToString(Math.Round(factTime, 3));
            ocpTimeTextBox.Text = Convert.ToString(Math.Round(ffdTime, 3));
            ocpDiffTextBox.Text = Convert.ToString(Math.Round(ffdDiff, 3));
            ocpSqrDiffTextBox.Text = Convert.ToString(Math.Round(ffdSqrDiff, 3));
            ocpTimeNaturalTextBox.Text = Convert.ToString(Math.Round(CountNaturalEquation(factors), 3));
        }

        private string CreateNormalizedEquation()
        {
            string linear = "y=";

            for (int i = 0; i < N_COEFF; ++i)
            {
                if (NormalizedCoefficients[i] < 0)
                {
                    linear += $"{Math.Round(NormalizedCoefficients[i], 3)}*{ColNames[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(NormalizedCoefficients[i], 3)}*{ColNames[i + 1]}";
                }
            }

            return linear;
        }

        private string CreateNaturalEquation()
        {
            string linear = "y=";

            for (int i = 0; i < NaturalCoefficients.Count; ++i)
            {
                if (NaturalCoefficients[i] < 0)
                {
                    linear += $"{Math.Round(NaturalCoefficients[i], 3)}*{ColNames[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(NaturalCoefficients[i], 3)}*{ColNames[i + 1]}";
                }
            }

            return linear;
        }

        private void InitLists()
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

            PlanningMatrix.Clear();

            NormalizedCoefficients.Clear();

            NaturalCoefficients.Clear();
        }

        private void ReadCsvFiles()
        {
            ReadCsv(@"D:\bmstu\ics7-edt\lab_04\ocp.csv");

            foreach (var col_name in ColNames!)
            {
                mainGridView.Columns.Add(col_name, col_name);
            }

            foreach (var row in GridViewMatrix!)
            {
                mainGridView.Rows.Add(row);
            }
        }

        private void ConductExperiment()
        {
            Experiment();
            for (int i = 0; i < N_SUM; ++i)
            {
                mainGridView.Rows[i].Cells[N_COEFF + 1].Value = Math.Round(PlanningMatrix[i][N_COEFF + 1], 3);
            }

            CountNormalizedCoefficients();

            EstimateNormalized();
            for (int i = 0; i < N_SUM; ++i)
            {
                mainGridView.Rows[i].Cells[N_COEFF + 2].Value = Math.Round(PlanningMatrix[i][N_COEFF + 2], 3);
                mainGridView.Rows[i].Cells[N_COEFF + 3].Value = Math.Round(PlanningMatrix[i][N_COEFF + 3], 3);
                mainGridView.Rows[i].Cells[N_COEFF + 4].Value = Math.Round(PlanningMatrix[i][N_COEFF + 4], 3);
            }

            // correct b_0
            for (int i = 37; i < 44; ++i)
            {
                NormalizedCoefficients[0] -= (NormalizedCoefficients[i] * A);
            }

            CountNaturalCoefficients(NormalizedCoefficients, MinFactors, MaxFactors);
            normalizedEquation.Text = CreateNormalizedEquation();
            naturalEquation.Text = CreateNaturalEquation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainGridView.Rows.Clear();
            mainGridView.Columns.Clear();

            InitLists();
            ReadCsvFiles();

            ConductExperiment();
        }
    }
}
