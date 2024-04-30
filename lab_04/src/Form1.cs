using ConsoleApp1;
using System.Net.Http.Headers;

namespace FFE
{
    public partial class Form1 : Form
    {
        public List<List<double>> PlanningMatrix { get; set; } = new List<List<double>>();
        public List<double> NormalizedCoefficients { get; set; } = new List<double>();
        public List<double> NaturalCoefficients { get; set; } = new List<double>();
        public string[][] GridViewMatrix { get; set; } = new string[33][];
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
            for (int i = 1; i < N_SUM + 1; ++i)
            {
                double coefficient = 0.0;
                double znamenatel = 0.0;

                for (int j = 0; j < N_SUM; ++j)
                {
                    coefficient += (PlanningMatrix[j][i] * PlanningMatrix[j][N_SUM + 1]);
                    znamenatel += (PlanningMatrix[j][i] * PlanningMatrix[j][i]);
                }

                NormalizedCoefficients.Add(coefficient / znamenatel);
            }
        }

        public List<double> ExpandFactorsFe(List<double> factors)
        {
            List<double> expandedFactors = new List<double>(factors);

            for (int i = 10; i < N_SUM + 1; ++i)
            {
                var line = ColNames[i];
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

            for (int i = 10; i < N_SUM + 1; ++i)
            {
                var line = ColNames[i];
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
                double diff = time - PlanningMatrix[i][N_SUM + 1];
                PlanningMatrix[i].Add(diff);
                PlanningMatrix[i].Add(diff * diff);
            }
        }

        //public double Simulate(List<double> naturalFactors)
        //{
        //    Generator gen1 = new Generator(naturalFactors[1], naturalFactors[5]);
        //    Generator gen2 = new Generator(naturalFactors[2], naturalFactors[6]);
        //    Operator proc = new Operator(naturalFactors[3], naturalFactors[7],
        //                                 naturalFactors[4], naturalFactors[8]);
        //    QueuingSystem qs = new QueuingSystem(new List<Generator> { gen1, gen2 }, new List<Operator> { proc });

        //    double res = 0;

        //    for (int j = 0; j < 10; ++j)
        //    {
        //        qs.Simulate(100);
        //        res += qs.meanWaitingTime;
        //    }

        //    return res / 10;
        //}

        private void ModelBtn_Click(object sender, EventArgs e)
        {
            //var factors = new List<double>() { 1, Convert.ToDouble(Gen1Intensity.Text), Convert.ToDouble(Gen2Intensity.Text),
            //                                      Convert.ToDouble(Proc1Intensity.Text), Convert.ToDouble(Proc2Intensity.Text),
            //                                      Convert.ToDouble(Gen1Var.Text), Convert.ToDouble(Gen2Var.Text),
            //                                      Convert.ToDouble(Proc1Var.Text), Convert.ToDouble(Proc2Var.Text)};

            //double factTime = Simulate(factors);

            //double feTime = CountNonLinearFe(factors);
            //double feDiff = feTime - factTime;
            //double feSqrDiff = feDiff * feDiff;

            //double ffdTime = CountNonLinearFfd(factors);
            //double ffdDiff = ffdTime - factTime;
            //double ffdSqrDiff = ffdDiff * ffdDiff;

            //FactTime.Text = Convert.ToString(Math.Round(factTime, 3));

            //FENonLinearTime.Text = Convert.ToString(Math.Round(feTime, 3));
            //FEDiff.Text = Convert.ToString(Math.Round(feDiff, 3));
            //FESqrDiff.Text = Convert.ToString(Math.Round(feSqrDiff, 3));

            //FFDNonLinearTime.Text = Convert.ToString(Math.Round(ffdTime, 3));
            //FFDDiff.Text = Convert.ToString(Math.Round(ffdDiff, 3));
            //FFDSqrDiff.Text = Convert.ToString(Math.Round(ffdSqrDiff, 3));
        }

        private string CreateNormalizedEquation()
        {
            string linear = "y=";

            for (int i = 0; i < NormalizedCoefficients.Count; ++i)
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

        private void ConductExperiment()
        {
            Experiment();
            for (int i = 0; i < N_SUM; ++i)
            {
                mainGridView.Rows[i].Cells[N_SUM + 1].Value = Math.Round(PlanningMatrix[i][N_SUM + 1], 3);
            }

            CountNormalizedCoefficients();
            //CountNaturalCoefficients();

            normalizedEquation.Text = CreateNormalizedEquation();
            //naturalEquation.Text = CreateNaturalNonLinearEquation(NaturalCoefficients);

            EstimateNormalized();
            for (int i = 0; i < N_SUM; ++i)
            {
                mainGridView.Rows[i].Cells[N_SUM + 2].Value = Math.Round(PlanningMatrix[i][N_SUM + 2], 3);
                mainGridView.Rows[i].Cells[N_SUM + 3].Value = Math.Round(PlanningMatrix[i][N_SUM + 3], 3);
                mainGridView.Rows[i].Cells[N_SUM + 4].Value = Math.Round(PlanningMatrix[i][N_SUM + 4], 3);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            mainGridView.Rows.Clear();
            mainGridView.Columns.Clear();

            InitLists();
            ReadCsvFiles();

            ConductExperiment();
        }

        private readonly int N = 8;
        private readonly int K = 4;
        private readonly int N_FFD = 16;
        private readonly int N_SP = 16;
        private readonly int N_C = 1;
        private readonly int N_SUM = 33;
    }
}
