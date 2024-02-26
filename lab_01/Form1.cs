using queuingSystem;
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

namespace queuing_system
{
    public partial class Form1 : Form
    {
        public Form1()
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

            listGenerator.Columns.Add("Интенсивность поступления, 1/с");
            listGenerator.Columns.Add("Разброс поступления, 1/с");

            listGenerator.Columns[0].Width = 450;
            listGenerator.Columns[1].Width = 450;

            listGenerator.Font = new Font("Arial", 14);

            listGenerator.MultiSelect = true;
        }

        private void InitializeListView2()
        {
            listOperator.View = View.Details;

            listOperator.Columns.Add("Интенсивность обслуживания, 1/с");
            listOperator.Columns.Add("Разброс обслуживания, 1/с");

            listOperator.Columns[0].Width = 450;
            listOperator.Columns[1].Width = 450;

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
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (listOperator.SelectedItems.Count > 0)
            {
                listOperator.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Generator> generators = new List<Generator>();
            List<Operator> operatingDevices = new List<Operator>();

            double generationIntensity = 0;
            
            foreach (ListViewItem item in listGenerator.Items)
            {
                generationIntensity += Convert.ToDouble(item.SubItems[0].Text);

                double mean = 1 / Convert.ToDouble(item.SubItems[0].Text);
                double spread = 1 / Convert.ToDouble(item.SubItems[0].Text);

                generators.Add(new Generator(mean, spread));
            }

            double operatingIntensity = 0;

            foreach (ListViewItem item in listOperator.Items)
            {
                operatingIntensity += Convert.ToDouble(item.SubItems[0].Text);

                double mean = 1 / Convert.ToDouble(item.SubItems[0].Text);
                double spread = 1 / Convert.ToDouble(item.SubItems[0].Text);

                operatingDevices.Add(new Operator(mean, spread));
            }

            double time = readDouble(textBox3);

            if (generators.Count == 0 || operatingDevices.Count == 0)
            {
                MessageBox.Show("Пожалуйста, добавьте генераторы и обслуживающие аппараты");
                return;
            }

            QueuingSystem queuingSystem = new QueuingSystem(generators, operatingDevices);
            queuingSystem.simulate(time);

            double theoreticWorkload = generationIntensity / operatingIntensity;
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
            double generatorIntensity = readDouble(textBox17);
            double generatorSpread = readDouble(textBox13);

            double operatingDeviceIntensityMin = readDouble(textBox8);
            double operatingDeviceIntensityMax = readDouble(textBox9);
            double operatingDeviceIntensityStep = readDouble(textBox14);

            double time = readDouble(textBox3);

            chart1.Series.Clear();
            chart1.Series.Add(new Series("operatingIntensity"));
            chart1.Series["operatingIntensity"].ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisX.Title = "Интенсивность обработки, 1/с";
            chart1.ChartAreas[0].AxisY.Title = "Время ожидания в очереди, с";
            chart1.Legends.Clear();

            chart2.Series.Clear();
            chart2.Series.Add(new Series("workloadOperatingIntensity"));
            chart2.Series["workloadOperatingIntensity"].ChartType = SeriesChartType.Line;
            chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.ChartAreas[0].AxisX.Title = "Загрузка";
            chart2.ChartAreas[0].AxisY.Title = "Время ожидания в очереди, с";
            chart2.Legends.Clear();
            for (double i = operatingDeviceIntensityMin; i <= operatingDeviceIntensityMax; i += operatingDeviceIntensityStep)
            {
                double meanWaitingTime = 0;
                int iterations = 100;
                for (int j = 0; j < iterations; ++j)
                {
                    Generator generator = new Generator(generatorIntensity, generatorSpread);
                    Operator operatingDevice = new Operator(i, 0);

                    QueuingSystem queuingSystem = new QueuingSystem(generator, operatingDevice);
                    queuingSystem.simulate(time);
                    meanWaitingTime += queuingSystem.meanWaitingTime;
                }

                chart1.Series["operatingIntensity"].Points.AddXY(i, meanWaitingTime / iterations);
                chart2.Series["workloadOperatingIntensity"].Points.AddXY(Math.Round(generatorIntensity / i, 3), meanWaitingTime / iterations);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double generatorIntensityMin = readDouble(textBox18);
            double generatorIntensityMax = readDouble(textBox16);
            double generatorIntensityStep = readDouble(textBox15);
            double generatorSpread = readDouble(textBox11);

            double operatingDeviceIntensity = readDouble(textBox12);

            double time = readDouble(textBox3);

            chart4.Series.Clear();
            chart4.Series.Add(new Series("generatorIntensity"));
            chart4.Series["generatorIntensity"].ChartType = SeriesChartType.Line;
            chart4.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart4.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart4.ChartAreas[0].AxisX.Title = "Интенсивность поступления, 1/с";
            chart4.ChartAreas[0].AxisY.Title = "Время ожидания в очереди, с";
            chart4.Legends.Clear();

            chart3.Series.Clear();
            chart3.Series.Add(new Series("workloadGeneratingIntensity"));
            chart3.Series["workloadGeneratingIntensity"].ChartType = SeriesChartType.Line;
            chart3.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart3.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart3.ChartAreas[0].AxisX.Title = "Загрузка";
            chart3.ChartAreas[0].AxisY.Title = "Время ожидания в очереди, с";
            chart3.Legends.Clear();
            for (double i = generatorIntensityMin; i <= generatorIntensityMax; i += generatorIntensityStep)
            {
                double meanWaitingTime = 0;
                int iterations = 100;
                for (int j = 0; j < iterations; ++j)
                {
                    double mean = 1 / i;
                    double spread = generatorSpread;
                    Generator generator = new Generator(mean, spread);
                    Operator operatingDevice = new Operator(operatingDeviceIntensity, 0);

                    QueuingSystem queuingSystem = new QueuingSystem(generator, operatingDevice);
                    queuingSystem.simulate(time);
                    meanWaitingTime += queuingSystem.meanWaitingTime;
                }

                chart4.Series["generatorIntensity"].Points.AddXY(i, meanWaitingTime / iterations);
                chart3.Series["workloadGeneratingIntensity"].Points.AddXY(Math.Round(i / operatingDeviceIntensity, 3), meanWaitingTime / iterations);
            }
        }
    }
}
