namespace queuing_system
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            listGenerator = new ListView();
            labelGenerator = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            textBoxGeneratorMean = new TextBox();
            btnAddGenerator = new Button();
            label3 = new Label();
            textBoxGeneratorDerivation = new TextBox();
            label4 = new Label();
            deleteGenerator = new Button();
            deleteOperator = new Button();
            label5 = new Label();
            btnAddOperator = new Button();
            textBoxOperatorMean = new TextBox();
            labelOperatorMean = new Label();
            label8 = new Label();
            listOperator = new ListView();
            btnStartModelling = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            textBoxTheorWorkload = new TextBox();
            label9 = new Label();
            textBoxActualWorkload = new TextBox();
            label10 = new Label();
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            label11 = new Label();
            textBoxMeanWaitTime = new TextBox();
            textBox8 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            label21 = new Label();
            textBoxOperatorDerivation = new TextBox();
            textBox14 = new TextBox();
            textBox17 = new TextBox();
            label19 = new Label();
            textBox13 = new TextBox();
            button6 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label20 = new Label();
            label15 = new Label();
            labelOperatorDerivation = new Label();
            button7 = new Button();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox15 = new TextBox();
            label18 = new Label();
            textBox16 = new TextBox();
            label22 = new Label();
            label23 = new Label();
            textBox18 = new TextBox();
            label24 = new Label();
            label17 = new Label();
            
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            
            SuspendLayout();

            listGenerator.Location = new Point(16, 312);
            listGenerator.Name = "listGenerator";
            listGenerator.Size = new Size(944, 216);
            listGenerator.TabIndex = 0;
            listGenerator.UseCompatibleStateImageBehavior = false;

            labelGenerator.AutoSize = true;
            labelGenerator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelGenerator.Location = new Point(8, 8);
            labelGenerator.Name = "labelGenerator";
            labelGenerator.Size = new Size(192, 48);
            labelGenerator.TabIndex = 1;
            labelGenerator.Text = "Генератор";

            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 120);
            label2.Name = "label2";
            label2.Size = new Size(302, 45);
            label2.TabIndex = 3;
            label2.Text = "Интенсивность, 1/c";

            textBoxGeneratorMean.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratorMean.Location = new Point(464, 120);
            textBoxGeneratorMean.Name = "textBoxGeneratorMean";
            textBoxGeneratorMean.Size = new Size(176, 50);
            textBoxGeneratorMean.TabIndex = 4;
            textBoxGeneratorMean.Text = "0,1";

            btnAddGenerator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGenerator.Location = new Point(464, 240);
            btnAddGenerator.Name = "btnAddGenerator";
            btnAddGenerator.Size = new Size(176, 64);
            btnAddGenerator.TabIndex = 5;
            btnAddGenerator.Text = "Добавить";
            btnAddGenerator.UseVisualStyleBackColor = true;
            btnAddGenerator.Click += button1_Click;

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 184);
            label3.Name = "label3";
            label3.Size = new Size(429, 45);
            label3.TabIndex = 6;
            label3.Text = "Разброс интенсивности, 1/c";
            // 
            // textBoxGeneratorDerivation
            // 
            textBoxGeneratorDerivation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratorDerivation.Location = new Point(464, 184);
            textBoxGeneratorDerivation.Name = "textBoxGeneratorDerivation";
            textBoxGeneratorDerivation.Size = new Size(176, 50);
            textBoxGeneratorDerivation.TabIndex = 7;
            textBoxGeneratorDerivation.Text = "0,5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 64);
            label4.Name = "label4";
            label4.Size = new Size(442, 45);
            label4.TabIndex = 8;
            label4.Text = "Равномерное распределение";

            deleteGenerator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            deleteGenerator.Location = new Point(16, 240);
            deleteGenerator.Name = "deleteGenerator";
            deleteGenerator.Size = new Size(432, 64);
            deleteGenerator.TabIndex = 9;
            deleteGenerator.Text = "Удалить выделенное";
            deleteGenerator.UseVisualStyleBackColor = true;
            deleteGenerator.Click += button2_Click;

            deleteOperator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            deleteOperator.Location = new Point(24, 750);
            deleteOperator.Name = "deleteOperator";
            deleteOperator.Size = new Size(392, 64);
            deleteOperator.TabIndex = 18;
            deleteOperator.Text = "Удалить выделенное";
            deleteOperator.UseVisualStyleBackColor = true;
            deleteOperator.Click += button3_Click;

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 592);
            label5.Name = "label5";
            label5.Size = new Size(538, 45);
            label5.TabIndex = 17;
            label5.Text = "Нормальное распределение";

            btnAddOperator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddOperator.Location = new Point(432, 750);
            btnAddOperator.Name = "btnAddOperator";
            btnAddOperator.Size = new Size(216, 64);
            btnAddOperator.TabIndex = 14;
            btnAddOperator.Text = "Добавить";
            btnAddOperator.UseVisualStyleBackColor = true;
            btnAddOperator.Click += button4_Click;

            labelOperatorMean.AutoSize = true;
            labelOperatorMean.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperatorMean.Location = new Point(24, 648);
            labelOperatorMean.Name = "labelOperatorMean";
            labelOperatorMean.Size = new Size(302, 45);
            labelOperatorMean.TabIndex = 12;
            labelOperatorMean.Text = "Интенсивность, 1/c";

            textBoxOperatorMean.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatorMean.Location = new Point(472, 648);
            textBoxOperatorMean.Name = "textBoxOperatorMean";
            textBoxOperatorMean.Size = new Size(176, 50);
            textBoxOperatorMean.TabIndex = 13;
            textBoxOperatorMean.Text = "0,08";
            
            labelOperatorDerivation.AutoSize = true;
            labelOperatorDerivation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperatorDerivation.Location = new Point(24, 700);
            labelOperatorDerivation.Name = "labelOperatorDerivation";
            labelOperatorDerivation.Size = new Size(429, 45);
            labelOperatorDerivation.TabIndex = 12;
            labelOperatorDerivation.Text = "Разброс интенсивности, 1/c";

            textBoxOperatorDerivation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatorDerivation.Location = new Point(24, 760);
            textBoxOperatorDerivation.Name = "textBoxOperatorDerivation";
            textBoxOperatorDerivation.Size = new Size(176, 50);
            textBoxOperatorDerivation.TabIndex = 7;
            textBoxOperatorDerivation.Text = "0,5";

            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 536);
            label8.Name = "label8";
            label8.Size = new Size(449, 48);
            label8.TabIndex = 11;
            label8.Text = "Обслуживающий аппарат";

            listOperator.Location = new Point(24, 800);
            listOperator.Name = "listOperator";
            listOperator.Size = new Size(944, 232);
            listOperator.TabIndex = 10;
            listOperator.UseCompatibleStateImageBehavior = false;

            btnStartModelling.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartModelling.Location = new Point(32, 1080);
            btnStartModelling.Name = "btnStartModelling";
            btnStartModelling.Size = new Size(616, 64);
            btnStartModelling.TabIndex = 21;
            btnStartModelling.Text = "Моделировать";
            btnStartModelling.UseVisualStyleBackColor = true;
            btnStartModelling.Click += button5_Click;

            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(432, 1024);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 50);
            textBox3.TabIndex = 20;
            textBox3.Text = "1000";

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 1024);
            label6.Name = "label6";
            label6.Size = new Size(388, 45);
            label6.TabIndex = 19;
            label6.Text = "Время моделирования, с";

            textBoxTheorWorkload.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTheorWorkload.Location = new Point(512, 1144);
            textBoxTheorWorkload.Name = "textBoxTheorWorkload";
            textBoxTheorWorkload.ReadOnly = true;
            textBoxTheorWorkload.Size = new Size(136, 50);
            textBoxTheorWorkload.TabIndex = 23;

            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(32, 1152);
            label9.Name = "label9";
            label9.Size = new Size(431, 45);
            label9.TabIndex = 22;
            label9.Text = "Расчетная загрузка системы";
            // 
            // textBoxActualWorkload
            // 
            textBoxActualWorkload.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxActualWorkload.Location = new Point(512, 1200);
            textBoxActualWorkload.Name = "textBoxActualWorkload";
            textBoxActualWorkload.ReadOnly = true;
            textBoxActualWorkload.Size = new Size(136, 50);
            textBoxActualWorkload.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(32, 1208);
            label10.Name = "label10";
            label10.Size = new Size(469, 45);
            label10.TabIndex = 24;
            label10.Text = "Фактическая загрузка системы";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 1324);
            splitter1.TabIndex = 26;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(4, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 1324);
            splitter2.TabIndex = 27;
            splitter2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(32, 1264);
            label11.Name = "label11";
            label11.Size = new Size(435, 45);
            label11.TabIndex = 28;
            label11.Text = "Среднее время ожидания, с";
            // 
            // textBoxMeanWaitTime
            // 
            textBoxMeanWaitTime.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMeanWaitTime.Location = new Point(512, 1256);
            textBoxMeanWaitTime.Name = "textBoxMeanWaitTime";
            textBoxMeanWaitTime.ReadOnly = true;
            textBoxMeanWaitTime.Size = new Size(136, 50);
            textBoxMeanWaitTime.TabIndex = 29;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(1632, 64);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(104, 50);
            textBox8.TabIndex = 34;
            textBox8.Text = "1,1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(960, 8);
            label12.Name = "label12";
            label12.Size = new Size(603, 45);
            label12.TabIndex = 33;
            label12.Text = "Интенсивность поступления заявок, 1/c";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1552, 64);
            label13.Name = "label13";
            label13.Size = new Size(57, 45);
            label13.TabIndex = 35;
            label13.Text = "От";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1744, 64);
            label14.Name = "label14";
            label14.Size = new Size(61, 45);
            label14.TabIndex = 36;
            label14.Text = "До";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(1824, 64);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(112, 50);
            textBox9.TabIndex = 37;
            textBox9.Text = "3";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(1944, 64);
            label21.Name = "label21";
            label21.Size = new Size(78, 45);
            label21.TabIndex = 52;
            label21.Text = "Шаг";
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(2040, 64);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(96, 50);
            textBox14.TabIndex = 53;
            textBox14.Text = "0,1";
            // 
            // textBox17
            // 
            textBox17.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox17.Location = new Point(1576, 8);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(112, 50);
            textBox17.TabIndex = 66;
            textBox17.Text = "1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1696, 8);
            label19.Name = "label19";
            label19.Size = new Size(140, 45);
            label19.TabIndex = 82;
            label19.Text = "Разброс";
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(1856, 8);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(112, 50);
            textBox13.TabIndex = 83;
            textBox13.Text = "0,1";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(960, 120);
            button6.Name = "button6";
            button6.Size = new Size(1472, 64);
            button6.TabIndex = 84;
            button6.Text = "Построить график";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(968, 192);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(716, 432);
            chart1.TabIndex = 85;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(1712, 192);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(716, 432);
            chart2.TabIndex = 86;
            chart2.Text = "chart2";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(960, 64);
            label20.Name = "label20";
            label20.Size = new Size(577, 45);
            label20.TabIndex = 89;
            label20.Text = "Интенсивность обработки заявок, 1/c";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(968, 688);
            label15.Name = "label15";
            label15.Size = new Size(577, 45);
            label15.TabIndex = 103;
            label15.Text = "Интенсивность обработки заявок, 1/c";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(976, 752);
            button7.Name = "button7";
            button7.Size = new Size(1464, 64);
            button7.TabIndex = 100;
            button7.Text = "Построить график";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(2328, 632);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(104, 50);
            textBox11.TabIndex = 99;
            textBox11.Text = "0,1";
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(1560, 688);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(112, 50);
            textBox12.TabIndex = 97;
            textBox12.Text = "3";
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox15.Location = new Point(2072, 632);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(96, 50);
            textBox15.TabIndex = 96;
            textBox15.Text = "0,1";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1976, 632);
            label18.Name = "label18";
            label18.Size = new Size(78, 45);
            label18.TabIndex = 95;
            label18.Text = "Шаг";
            // 
            // textBox16
            // 
            textBox16.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox16.Location = new Point(1856, 632);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(112, 50);
            textBox16.TabIndex = 94;
            textBox16.Text = "2,9";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(1776, 632);
            label22.Name = "label22";
            label22.Size = new Size(61, 45);
            label22.TabIndex = 93;
            label22.Text = "До";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(1584, 632);
            label23.Name = "label23";
            label23.Size = new Size(57, 45);
            label23.TabIndex = 92;
            label23.Text = "От";
            // 
            // textBox18
            // 
            textBox18.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox18.Location = new Point(1664, 632);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(104, 50);
            textBox18.TabIndex = 91;
            textBox18.Text = "0,1";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(968, 632);
            label24.Name = "label24";
            label24.Size = new Size(603, 45);
            label24.TabIndex = 90;
            label24.Text = "Интенсивность поступления заявок, 1/c";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(2176, 632);
            label17.Name = "label17";
            label17.Size = new Size(140, 45);
            label17.TabIndex = 98;
            label17.Text = "Разброс";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(1720, 824);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(716, 448);
            chart3.TabIndex = 105;
            chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart4.Legends.Add(legend4);
            chart4.Location = new Point(976, 824);
            chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart4.Series.Add(series4);
            chart4.Size = new Size(716, 448);
            chart4.TabIndex = 104;
            chart4.Text = "chart4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2440, 1324);
            Controls.Add(chart3);
            Controls.Add(chart4);
            Controls.Add(label15);
            Controls.Add(button7);
            Controls.Add(textBox11);
            Controls.Add(label17);
            Controls.Add(textBox12);
            Controls.Add(textBox15);
            Controls.Add(label18);
            Controls.Add(textBoxOperatorDerivation);
            Controls.Add(textBox16);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(textBox18);
            Controls.Add(label24);
            Controls.Add(label20);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(button6);
            Controls.Add(textBox13);
            Controls.Add(label19);
            Controls.Add(textBox17);
            Controls.Add(textBox14);
            Controls.Add(label21);
            Controls.Add(textBox9);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(textBoxMeanWaitTime);
            Controls.Add(label11);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(textBoxActualWorkload);
            Controls.Add(label10);
            Controls.Add(textBoxTheorWorkload);
            Controls.Add(label9);
            Controls.Add(btnStartModelling);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(deleteOperator);
            Controls.Add(label5);
            Controls.Add(btnAddOperator);
            Controls.Add(textBoxOperatorMean);
            Controls.Add(labelOperatorMean);
            Controls.Add(label8);
            Controls.Add(listOperator);
            Controls.Add(deleteGenerator);
            Controls.Add(label4);
            Controls.Add(textBoxGeneratorDerivation);
            Controls.Add(label3);
            Controls.Add(btnAddGenerator);
            Controls.Add(textBoxGeneratorMean);
            Controls.Add(label2);
            Controls.Add(labelGenerator);
            Controls.Add(labelOperatorDerivation);
            Controls.Add(listGenerator);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listGenerator;
        private Label labelGenerator;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private TextBox textBoxGeneratorMean;
        private Button btnAddGenerator;
        private Label label3;
        private TextBox textBoxGeneratorDerivation;
        private Label label4;
        private Button deleteGenerator;
        private Button deleteOperator;
        private Label label5;
        private Button btnAddOperator;
        private TextBox textBoxOperatorMean;
        private Label labelOperatorMean;
        private Label label8;
        private ListView listOperator;
        private Button btnStartModelling;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBoxTheorWorkload;
        private Label label9;
        private TextBox textBoxActualWorkload;
        private Label label10;
        private Splitter splitter1;
        private Splitter splitter2;
        private Label label11;
        private TextBox textBoxMeanWaitTime;
        private TextBox textBox8;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox9;
        private Label label21;
        private TextBox textBox14;
        private TextBox textBox17;
        private Label label19;
        private TextBox textBox13;
        private Button button6;
        private TextBox textBoxOperatorDerivation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label20;
        private Label label15;
        private Button button7;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox15;
        private Label label18;
        private TextBox textBox16;
        private Label label22;
        private Label label23;
        private TextBox textBox18;
        private Label label24;
        private Label labelOperatorDerivation;
        private Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}