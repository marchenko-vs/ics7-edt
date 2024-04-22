using ConsoleApp1;
using System.Net.Http.Headers;

namespace FFE
{
    public partial class Form1 : Form
    {
        public List<List<double>> PlanningMatrixFe { get; set; } = new List<List<double>>();
        public List<double> NormalizedCoefficientsFe { get; set; } = new List<double>();
        public List<double> NaturalCoefficientsFe { get; set; } = new List<double>();
        public string[][] GridViewMatrixFe { get; set; } = new string[256][];
        public List<string> ColNamesFe { get; set; } = new List<string>();

        public List<List<double>> PlanningMatrixFfd { get; set; } = new List<List<double>>();
        public List<double> NormalizedCoefficientsFfd { get; set; } = new List<double>();
        public List<double> NaturalCoefficientsFfd { get; set; } = new List<double>();
        public string[][] GridViewMatrixFfd { get; set; } = new string[256][];
        public List<string> ColNamesFfd { get; set; } = new List<string>();

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

                FFD_N = j;
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
            for (int i = 1; i < FE_N + 1; ++i)
            {
                double coefficient = 0;

                for (int j = 0; j < FE_N; ++j)
                {
                    coefficient += (PlanningMatrixFe[j][i] * PlanningMatrixFe[j][FE_N + 1]);
                }

                NormalizedCoefficientsFe.Add(coefficient / FE_N);
            }
        }

        public List<double> ExpandFactorsFe(List<double> factors)
        {
            List<double> expandedFactors = new List<double>(factors);

            for (int i = 10; i < FE_N + 1; ++i)
            {
                var line = ColNamesFe[i];
                var values = line.Split('x').ToList();
                double newVal = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    newVal *= factors[Convert.ToInt32(values[j]) - 1];
                }

                expandedFactors.Add(newVal);
            }

            return expandedFactors;
        }

        public List<double> ExpandFactorsFfd(List<double> factors)
        {
            List<double> expandedFactors = new List<double>(factors);

            for (int i = 10; i < FFD_N + 1; ++i)
            {
                var line = ColNamesFe[i];
                var values = line.Split('x').ToList();
                double newVal = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    newVal *= factors[Convert.ToInt32(values[j]) - 1];
                }

                expandedFactors.Add(newVal);
            }

            return expandedFactors;
        }

        public void CountNaturalLinearCoefficientsFe()
        {
            double sum = 0;

            for (int i = 1; i < 9; ++i)
            {
                sum += (NormalizedCoefficientsFe[i] * (MaxFactors[i - 1] + MinFactors[i - 1]) /
                    (MaxFactors[i - 1] - MinFactors[i - 1]));
            }

            NaturalCoefficientsFe.Add(NormalizedCoefficientsFe[0] - sum);

            for (int i = 1; i < 9; ++i)
            {
                double naturalCoefficient = (2 * NormalizedCoefficientsFe[i]) /
                    (MaxFactors[i - 1] - MinFactors[i - 1]);

                NaturalCoefficientsFe.Add(naturalCoefficient);
            }
        }

        public void CountNaturalNonLinearCoefficientsFe()
        {
            List<double> expandedMinFactors = ExpandFactorsFe(MinFactors);
            List<double> expandedMaxFactors = ExpandFactorsFe(MaxFactors);

            double sum = 0;

            for (int i = 1; i < 9; ++i)
            {
                sum += (NormalizedCoefficientsFe[i] * (expandedMaxFactors[i - 1] + expandedMinFactors[i - 1]) /
                    (expandedMaxFactors[i - 1] - expandedMinFactors[i - 1]));
            }

            //NaturalCoefficientsFe[0] = NormalizedCoefficientsFe[0] - sum;

            for (int i = 9; i < FE_N; ++i)
            {
                double naturalCoefficient = (2 * NormalizedCoefficientsFe[i]) / 
                    (expandedMaxFactors[i - 1] - expandedMinFactors[i - 1]);

                NaturalCoefficientsFe.Add(naturalCoefficient);
            }
        }

        public void CountNaturalNonLinearCoefficientsFfd()
        {
            List<double> expandedMinFactors = ExpandFactorsFfd(MinFactors);
            List<double> expandedMaxFactors = ExpandFactorsFfd(MaxFactors);

            double sum = 0;

            for (int i = 1; i < 9; ++i)
            {
                sum += (NormalizedCoefficientsFfd[i] * (expandedMaxFactors[i - 1] + expandedMinFactors[i - 1]) /
                    (expandedMaxFactors[i - 1] - expandedMinFactors[i - 1]));
            }

            NaturalCoefficientsFfd[0] = NormalizedCoefficientsFfd[0] - sum;

            for (int i = 9; i < FFD_N; ++i)
            {
                double naturalCoefficient = (2 * NormalizedCoefficientsFfd[i]) /
                    (expandedMaxFactors[i - 1] - expandedMinFactors[i - 1]);

                NaturalCoefficientsFfd.Add(naturalCoefficient);
            }
        }

        public void CountNaturalCoefficientsFfd()
        {
            double sum = 0;

            for (int i = 1; i < 9; ++i)
            {
                sum += (NormalizedCoefficientsFfd[i] * (MaxFactors[i - 1] + MinFactors[i - 1]) / (MaxFactors[i - 1] - MinFactors[i - 1]));
            }

            NaturalCoefficientsFfd.Add(NormalizedCoefficientsFfd[0] - sum);

            for (int i = 1; i < 9; ++i)
            {
                double naturalCoefficient = (2 * NormalizedCoefficientsFfd[i]) / (MaxFactors[i - 1] - MinFactors[i - 1]);

                NaturalCoefficientsFfd.Add(naturalCoefficient);
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

                NormalizedCoefficientsFfd.Add(coefficient / FFD_N);
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

        public double Simulate(List<double> naturalFactors)
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

        public double CountNonLinearFe(List<double> _normalizedFactors)
        {
            List<double> normalizedFactors = new List<double>(_normalizedFactors);

            for (int i = 1; i < normalizedFactors.Count; ++i)
            {
                normalizedFactors[i] = NaturalToNormalized(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
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

        public double CountNaturalLinearFe(List<double> _naturalFactors)
        {
            double linear_time = 0;

            for (int i = 0; i < 9; ++i)
            {
                linear_time += (NaturalCoefficientsFe[i] * _naturalFactors[i]);
            }

            return linear_time;
        }

        public double CountNaturalNonLinearFe(List<double> naturalFactors)
        {
            double non_linear_time = 0;

            for (int i = 10; i < FE_N + 1; ++i)
            {
                var line = ColNamesFe[i];
                var values = line.Split('x').ToList();
                double mul = 1;

                for (int j = 1; j < values.Count; ++j)
                {
                    mul *= naturalFactors[Convert.ToInt32(values[j])];
                }

                naturalFactors.Add(mul);
            }

            for (int i = 0; i < NaturalCoefficientsFe.Count; ++i)
            {
                non_linear_time += (NaturalCoefficientsFe[i] * naturalFactors[i]);
            }

            return non_linear_time;
        }

        public double CountNaturalLinearFfd(List<double> _naturalFactors)
        {
            double linear_time = 0;

            for (int i = 0; i < 9; ++i)
            {
                linear_time += (NaturalCoefficientsFfd[i] * _naturalFactors[i]);
            }

            return linear_time;
        }

        public double CountLinearFe(List<double> _normalizedFactors)
        {
            List<double> normalizedFactors = new List<double>(_normalizedFactors);

            for (int i = 1; i < normalizedFactors.Count; ++i)
            {
                normalizedFactors[i] = NaturalToNormalized(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
            }

            double non_linear_time = 0;

            for (int i = 0; i < 9; ++i)
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
                normalizedFactors[i] = NaturalToNormalized(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
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
                normalizedFactors[i] = NaturalToNormalized(MinFactors[i - 1], MaxFactors[i - 1], normalizedFactors[i]);
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
        }

        private void ModelBtn_Click(object sender, EventArgs e)
        {
            var factors = new List<double>() { 1, Convert.ToDouble(Gen1Intensity.Text), Convert.ToDouble(Gen2Intensity.Text),
                                                  Convert.ToDouble(Proc1Intensity.Text), Convert.ToDouble(Proc2Intensity.Text),
                                                  Convert.ToDouble(Gen1Var.Text), Convert.ToDouble(Gen2Var.Text),
                                                  Convert.ToDouble(Proc1Var.Text), Convert.ToDouble(Proc2Var.Text)};

            double factTime = Simulate(factors);

            double feTime = CountNonLinearFe(factors);
            double feDiff = feTime - factTime;
            double feSqrDiff = feDiff * feDiff;

            double ffdTime = CountNonLinearFfd(factors);
            double ffdDiff = ffdTime - factTime;
            double ffdSqrDiff = ffdDiff * ffdDiff;

            FactTime.Text = Convert.ToString(Math.Round(factTime, 3));

            FENonLinearTime.Text = Convert.ToString(Math.Round(feTime, 3));
            FEDiff.Text = Convert.ToString(Math.Round(feDiff, 3));
            FESqrDiff.Text = Convert.ToString(Math.Round(feSqrDiff, 3));

            FFDNonLinearTime.Text = Convert.ToString(Math.Round(ffdTime, 3));
            FFDDiff.Text = Convert.ToString(Math.Round(ffdDiff, 3));
            FFDSqrDiff.Text = Convert.ToString(Math.Round(ffdSqrDiff, 3));
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

        private string CreateNaturalLinearEquation(List<double> coefficients)
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

        private string CreateNaturalNonLinearEquation(List<double> coefficients)
        {
            string linear = "y=";

            for (int i = 0; i < FE_N; ++i)
            {
                if (coefficients[i] < 0)
                {
                    linear += $"{Math.Round(coefficients[i], 3)}*{ColNamesFe[i + 1]}";
                }
                else
                {
                    linear += $"+{Math.Round(coefficients[i], 3)}*{ColNamesFe[i + 1]}";
                }
            }

            return linear;
        }

        private string CreateNaturalNonLinearEquationFfd(List<double> coefficients)
        {
            string linear = "y=";

            for (int i = 0; i < FFD_N; ++i)
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

            PlanningMatrixFe.Clear();
            PlanningMatrixFfd.Clear();

            NormalizedCoefficientsFe.Clear();
            NormalizedCoefficientsFfd.Clear();

            NaturalCoefficientsFe.Clear();
            NaturalCoefficientsFfd.Clear();
        }

        private void ConductFE()
        {
            Experiment();
            for (int i = 0; i < FE_N; ++i)
            {
                FEGridView.Rows[i].Cells[FE_N + 1].Value = Math.Round(PlanningMatrixFe[i][FE_N + 1], 3);
            }

            CountNormalizedCoefficientsFe();
            CountNaturalLinearCoefficientsFe();
            //CountNaturalNonLinearCoefficientsFe();

            NormLinear.Text = CreateLinearEquation();
            NormNonLinear.Text = CreateNonLinearEquation();
            FENaturLinear.Text = CreateNaturalLinearEquation(NaturalCoefficientsFe);
            //FENaturNonLinear.Text = CreateNaturalNonLinearEquation(NaturalCoefficientsFe);

            EstimateNormalized();
            for (int i = 0; i < FE_N; ++i)
            {
                FEGridView.Rows[i].Cells[FE_N + 2].Value = Math.Round(PlanningMatrixFe[i][FE_N + 2], 3);
                FEGridView.Rows[i].Cells[FE_N + 3].Value = Math.Round(PlanningMatrixFe[i][FE_N + 3], 3);
                FEGridView.Rows[i].Cells[FE_N + 4].Value = Math.Round(PlanningMatrixFe[i][FE_N + 4], 3);
                FEGridView.Rows[i].Cells[FE_N + 5].Value = Math.Round(PlanningMatrixFe[i][FE_N + 5], 3);
            }
        }

        private void ConductFFD()
        {
            ExperimentFfd();
            for (int i = 0; i < FFD_N; ++i)
            {
                FFDGridView.Rows[i].Cells[FFD_N + 1].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 1], 3);
            }

            CountNormalizedCoefficientsFfd();
            CountNaturalCoefficientsFfd();
            //CountNaturalNonLinearCoefficientsFfd();

            FFDNormLinear.Text = CreateLinearEquationFfd();
            FFDNormNonLinear.Text = CreateNonLinearEquationFfd();
            FFDNaturLinear.Text = CreateNaturalLinearEquation(NaturalCoefficientsFfd);
            //FFDNaturNonLinear.Text = CreateNaturalNonLinearEquationFfd(NaturalCoefficientsFfd);

            EstimateNormalizedFfd();
            for (int i = 0; i < FFD_N; ++i)
            {
                FFDGridView.Rows[i].Cells[FFD_N + 2].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 2], 3);
                FFDGridView.Rows[i].Cells[FFD_N + 3].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 3], 3);
                FFDGridView.Rows[i].Cells[FFD_N + 4].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 4], 3);
                FFDGridView.Rows[i].Cells[FFD_N + 5].Value = Math.Round(PlanningMatrixFfd[i][FFD_N + 5], 3);
            }
        }

        private void ReadCsvFiles()
        {
            ReadCsvFe(@"D:\bmstu\ics7-edt\lab_03\FFE\fe.csv");

            foreach (var col_name in ColNamesFe!)
            {
                FEGridView.Columns.Add(col_name, col_name);
            }

            foreach (var row in GridViewMatrixFe!)
            {
                FEGridView.Rows.Add(row);
            }

            ReadCsvFfd(@"D:\bmstu\ics7-edt\lab_03\FFE\ffd16.csv");

            foreach (var col_name in ColNamesFfd!)
            {
                FFDGridView.Columns.Add(col_name, col_name);
            }

            foreach (var row in GridViewMatrixFfd!)
            {
                if (row != null)
                {
                    FFDGridView.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FEGridView.Rows.Clear();
            FEGridView.Columns.Clear();

            FFDGridView.Rows.Clear();
            FFDGridView.Columns.Clear();

            InitLists();
            ReadCsvFiles();

            ConductFE();
            ConductFFD();
        }

        private int FFD_N = 16;
        private readonly int FE_N = 256;
    }
}
