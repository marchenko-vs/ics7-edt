using QueuingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QueuingSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeListView1();
            InitializeListView2();
            button6_Click(this, EventArgs.Empty);
            button7_Click(this, EventArgs.Empty);
        }

        private void InitializeListView1()
        {
            listGenerator.View = View.Details;

            listGenerator.Columns.Add("Интенсивность, 1/с");
            listGenerator.Columns.Add("Разброс, 1/с");

            listGenerator.Columns[0].Width = 250;
            listGenerator.Columns[1].Width = 250;

            listGenerator.Font = new Font("Arial", 14);

            listGenerator.MultiSelect = true;
        }

        private void InitializeListView2()
        {
            listOperator.View = View.Details;

            listOperator.Columns.Add("Интенсивность, 1/с");
            listOperator.Columns.Add("Разброс, 1/с");

            listOperator.Columns[0].Width = 250;
            listOperator.Columns[1].Width = 250;

            listOperator.Font = new Font("Arial", 14);

            listOperator.MultiSelect = true;
        }

        private double readDouble(TextBox textbox)
        {
            double result;
            if (!double.TryParse(textbox.Text, out result))
            {
                Console.WriteLine("Некорректное значение в " + textbox.Name);
            }
            return result;
        }

        private int readInt(TextBox textbox)
        {
            int result;
            if (!int.TryParse(textbox.Text, out result))
            {
                Console.WriteLine("Некорректное значение в " + textbox.Name);
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double intensity = readDouble(textBoxGeneratorMean);
            double spread = readDouble(textBoxGeneratorDerivation);

            ListViewItem item = new(new[] {
                Convert.ToString(intensity),
                Convert.ToString(spread)
            });

            listGenerator.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listGenerator.SelectedItems.Count > 0)
            {
                listGenerator.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Выберите генератор для удаления.", "Ошибка!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listOperator.SelectedItems.Count > 0)
            {
                listOperator.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Выберите обслуживающий аппарат для удаления.", "Ошибка!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double intensity = readDouble(textBoxOperatorMean);
            double spread = readDouble(textBoxOperatorDerivation);

            ListViewItem item = new(new[] {
                Convert.ToString(intensity),
                Convert.ToString(spread)
            });

            listOperator.Items.Add(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Generator> generators = new List<Generator>();
            List<Operator> operatingDevices = new List<Operator>();

            double generatingIntensity = 0;

            foreach (ListViewItem item in listGenerator.Items)
            {
                generatingIntensity += Convert.ToDouble(item.SubItems[0].Text);

                double meanIntensity = Convert.ToDouble(item.SubItems[0].Text);
                double spreadIntensity = Convert.ToDouble(item.SubItems[1].Text);

                double mean = 1 / meanIntensity;
                double spread = Math.Abs((1 / (meanIntensity + spreadIntensity)) - (1 / (meanIntensity - spreadIntensity))) / 2;

                generators.Add(new Generator(mean, spread));
            }

            double operatorIntensity = 0;

            foreach (ListViewItem item in listOperator.Items)
            {
                operatorIntensity += Convert.ToDouble(item.SubItems[0].Text);

                double meanIntensity = Convert.ToDouble(item.SubItems[0].Text);
                double spreadIntensity = Convert.ToDouble(item.SubItems[1].Text);

                double mean = 1 / meanIntensity;
                double spread = Math.Abs((1 / (meanIntensity + spreadIntensity)) - (1 / (meanIntensity - spreadIntensity))) / 2;

                operatingDevices.Add(new Operator(mean, spread));
            }

            double time = readDouble(textBoxModellingTime);

            if (generators.Count == 0 || operatingDevices.Count == 0)
            {
                MessageBox.Show("Необходимо добавить генераторы и обслуживающие аппараты.", "Ошибка!");
                return;
            }

            QueuingSystem queuingSystem = new QueuingSystem(generators, operatingDevices);
            queuingSystem.simulate(time);

            double theoreticWorkload = generatingIntensity / operatorIntensity;
            double actualWorkload = 0;

            if (queuingSystem.proccessed != 0)
            {
                actualWorkload = (double)queuingSystem.generated / (double)queuingSystem.proccessed;
            }
            else
            {
                actualWorkload = double.MaxValue;
            }

            textBoxTheorWorkload.Text = Math.Round(theoreticWorkload, 3).ToString();
            textBoxActualWorkload.Text = Math.Round(actualWorkload, 3).ToString();
            textBoxMeanWaitTime.Text = Math.Round(queuingSystem.meanWaitingTime, 3).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double generatorMeanIntensity = readDouble(textBox17);
            double generatorSpreadIntensity = readDouble(textBox13);

            MessageBox.Show($"Gen mean {generatorMeanIntensity} gen spread {generatorSpreadIntensity}", "DBG");

            double operatorMeanIntensityMin = readDouble(textBox8);
            double operatorMeanIntensityMax = readDouble(textBox9);
            double operatorMeanIntensityStep = readDouble(textBox14);
            double operatorSpreadIntensity = readDouble(textBox19);

            double generatorMean = 1 / generatorMeanIntensity;
            double generatorSpread = Math.Abs((1 / (generatorMeanIntensity + generatorSpreadIntensity)) -
                (1 / (generatorMeanIntensity - generatorSpreadIntensity))) / 2;

            double time = readDouble(textBoxModellingTime);

            chart1.Series.Clear();
            chart1.Series.Add(new Series("series1"));
            chart1.Series["series1"].ChartType = SeriesChartType.Line;
            chart1.Series["series1"].BorderWidth = 4;
            chart1.Series["series1"].Color = Color.Red;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisX.Title = "Интенсивность обработки, 1/с";
            chart1.ChartAreas[0].AxisY.Title = "Время пребывания заявки, с";
            chart1.Legends.Clear();

            chart2.Series.Clear();
            chart2.Series.Add(new Series("series2"));
            chart2.Series["series2"].ChartType = SeriesChartType.Line;
            chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.Series["series2"].BorderWidth = 5;
            chart2.Series["series2"].Color = Color.Green;
            chart2.ChartAreas[0].AxisX.Title = "Загрузка";
            chart2.ChartAreas[0].AxisY.Title = "Время пребывания заявки, с";
            chart2.Legends.Clear();

            for (double operatorMeanIntensityCurr = operatorMeanIntensityMin;
                 operatorMeanIntensityCurr <= operatorMeanIntensityMax;
                 operatorMeanIntensityCurr += operatorMeanIntensityStep)
            {
                double meanWaitingTime = 0;
                int iterations = 100;

                double operatorMean = 1 / operatorMeanIntensityCurr;
                double operatorSpread = Math.Abs((1 / (operatorMeanIntensityCurr + operatorSpreadIntensity)) -
                    (1 / (operatorMeanIntensityCurr - generatorSpreadIntensity))) / 2;

                for (int j = 0; j < iterations; ++j)
                {
                    Generator generator = new Generator(generatorMean, generatorSpread);
                    Operator operatingDevice = new Operator(operatorMean, operatorSpread);

                    QueuingSystem queuingSystem = new QueuingSystem(generator, operatingDevice);

                    queuingSystem.simulate(time);
                    meanWaitingTime += queuingSystem.meanWaitingTime;
                }

                chart1.Series["series1"].Points.AddXY(operatorMeanIntensityCurr, meanWaitingTime / iterations);
                chart2.Series["series2"].Points.AddXY(Math.Round(generatorMeanIntensity / operatorMeanIntensityCurr, 3),
                    meanWaitingTime / iterations);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double generatorMeanIntensityMin = readDouble(textBox18);
            double generatorMeanIntensityMax = readDouble(textBox16);
            double generatorMeanIntensityStep = readDouble(textBox15);
            double generatorSpreadIntensity = readDouble(textBox11);

            double operatorMeanIntensity = readDouble(textBox12);
            double operatorSpreadIntensity = readDouble(textBox20);

            double operatorMean = 1 / operatorMeanIntensity;
            double operatorSpread = Math.Abs((1 / (operatorMeanIntensity + operatorSpreadIntensity)) -
                (1 / (operatorMeanIntensity - operatorSpreadIntensity))) / 2;

            double time = readDouble(textBoxModellingTime);

            chart4.Series.Clear();
            chart4.Series.Add(new Series("series4"));
            chart4.Series["series4"].ChartType = SeriesChartType.Line;
            chart4.Series["series4"].BorderWidth = 4;
            chart4.Series["series4"].Color = Color.Red;
            chart4.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart4.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart4.ChartAreas[0].AxisX.Title = "Интенсивность поступления, 1/с";
            chart4.ChartAreas[0].AxisY.Title = "Время пребывания заявки, с";
            chart4.Legends.Clear();

            chart3.Series.Clear();
            chart3.Series.Add(new Series("series3"));
            chart3.Series["series3"].ChartType = SeriesChartType.Line;
            chart3.Series["series3"].BorderWidth = 4;
            chart3.Series["series3"].Color = Color.Green;
            chart3.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart3.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart3.ChartAreas[0].AxisX.Title = "Загрузка";
            chart3.ChartAreas[0].AxisY.Title = "Время пребывания заявки, с";
            chart3.Legends.Clear();

            for (double generatorMeanIntensityCurr = generatorMeanIntensityMin;
                generatorMeanIntensityCurr <= generatorMeanIntensityMax;
                generatorMeanIntensityCurr += generatorMeanIntensityStep)
            {
                double meanWaitingTime = 0;
                int iterations = 100;

                double generatorMean = 1 / generatorMeanIntensityCurr;
                double generatorSpread = Math.Abs((1 / (generatorMeanIntensityCurr + generatorSpreadIntensity)) -
                    (1 / (generatorMeanIntensityCurr - generatorSpreadIntensity))) / 2;

                for (int j = 0; j < iterations; ++j)
                {
                    Generator generator = new Generator(generatorMean, generatorSpread);
                    Operator operatingDevice = new Operator(operatorMean, operatorSpread);

                    QueuingSystem queuingSystem = new QueuingSystem(generator, operatingDevice);
                    queuingSystem.simulate(time);
                    meanWaitingTime += queuingSystem.meanWaitingTime;
                }

                chart4.Series["series4"].Points.AddXY(generatorMeanIntensityCurr, meanWaitingTime / iterations);
                chart3.Series["series3"].Points.AddXY(Math.Round(generatorMeanIntensityCurr / operatorMeanIntensity, 3),
                    meanWaitingTime / iterations);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
