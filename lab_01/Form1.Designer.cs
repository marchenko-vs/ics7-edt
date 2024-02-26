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
            labelGeneratorMean = new Label();
            textBoxGeneratorMean = new TextBox();
            btnAddGenerator = new Button();
            labelGeneratorDerivation = new Label();
            textBoxGeneratorDerivation = new TextBox();
            labelUniform = new Label();
            btnDeleteGenerator = new Button();
            btnDeleteOperator = new Button();
            labelNormal = new Label();
            btnAddOperator = new Button();
            textBoxOperatorMean = new TextBox();
            labelOperatorMean = new Label();
            labelOperator = new Label();
            listOperator = new ListView();
            btnStartModelling = new Button();
            textBoxModellingTime = new TextBox();
            labelModellingTime = new Label();
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
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            
            label17 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            
            SuspendLayout();

            labelGenerator.AutoSize = true;
            labelGenerator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelGenerator.Location = new Point(10, 8);
            labelGenerator.Name = "labelGenerator";
            labelGenerator.Size = new Size(190, 45);
            labelGenerator.TabIndex = 1;
            labelGenerator.Text = "Генератор";

            labelUniform.AutoSize = true;
            labelUniform.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelUniform.Location = new Point(10, 50);
            labelUniform.Name = "labelUniform";
            labelUniform.Size = new Size(442, 45);
            labelUniform.TabIndex = 8;
            labelUniform.Text = "Равномерное распределение";

            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);

            labelGeneratorMean.AutoSize = true;
            labelGeneratorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGeneratorMean.Location = new Point(10, 90);
            labelGeneratorMean.Name = "labelGeneratorMean";
            labelGeneratorMean.Size = new Size(302, 45);
            labelGeneratorMean.TabIndex = 3;
            labelGeneratorMean.Text = "Интенсивность, 1/c";

            textBoxGeneratorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratorMean.Location = new Point(460, 90);
            textBoxGeneratorMean.Name = "textBoxGeneratorMean";
            textBoxGeneratorMean.Size = new Size(176, 40);
            textBoxGeneratorMean.TabIndex = 4;
            textBoxGeneratorMean.Text = "0,1";

            labelGeneratorDerivation.AutoSize = true;
            labelGeneratorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGeneratorDerivation.Location = new Point(10, 130);
            labelGeneratorDerivation.Name = "labelGeneratorDerivation";
            labelGeneratorDerivation.Size = new Size(429, 45);
            labelGeneratorDerivation.TabIndex = 6;
            labelGeneratorDerivation.Text = "Разброс интенсивности, 1/c";

            textBoxGeneratorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratorDerivation.Location = new Point(460, 130);
            textBoxGeneratorDerivation.Name = "textBoxGeneratorDerivation";
            textBoxGeneratorDerivation.Size = new Size(176, 40);
            textBoxGeneratorDerivation.TabIndex = 7;
            textBoxGeneratorDerivation.Text = "0,5";

            btnDeleteGenerator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteGenerator.Location = new Point(10, 170);
            btnDeleteGenerator.Name = "btnDeleteGenerator";
            btnDeleteGenerator.Size = new Size(180, 50);
            btnDeleteGenerator.TabIndex = 9;
            btnDeleteGenerator.Text = "Удалить";
            btnDeleteGenerator.UseVisualStyleBackColor = true;
            btnDeleteGenerator.Click += button2_Click;

            btnAddGenerator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGenerator.Location = new Point(300, 170);
            btnAddGenerator.Name = "btnAddGenerator";
            btnAddGenerator.Size = new Size(180, 50);
            btnAddGenerator.TabIndex = 5;
            btnAddGenerator.Text = "Добавить";
            btnAddGenerator.UseVisualStyleBackColor = true;
            btnAddGenerator.Click += button1_Click;

            listGenerator.Location = new Point(10, 230);
            listGenerator.Name = "listGenerator";
            listGenerator.Size = new Size(650, 200);
            listGenerator.TabIndex = 0;
            listGenerator.UseCompatibleStateImageBehavior = false;

            labelOperator.AutoSize = true;
            labelOperator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperator.Location = new Point(10, 460);
            labelOperator.Name = "labelOperator";
            labelOperator.Size = new Size(449, 48);
            labelOperator.TabIndex = 11;
            labelOperator.Text = "Обслуживающий аппарат";

            labelNormal.AutoSize = true;
            labelNormal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNormal.Location = new Point(10, 500);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(538, 45);
            labelNormal.TabIndex = 17;
            labelNormal.Text = "Нормальное распределение";

            labelOperatorMean.AutoSize = true;
            labelOperatorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperatorMean.Location = new Point(10, 540);
            labelOperatorMean.Name = "labelOperatorMean";
            labelOperatorMean.Size = new Size(302, 45);
            labelOperatorMean.TabIndex = 12;
            labelOperatorMean.Text = "Интенсивность, 1/c";

            textBoxOperatorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatorMean.Location = new Point(460, 540);
            textBoxOperatorMean.Name = "textBoxOperatorMean";
            textBoxOperatorMean.Size = new Size(176, 50);
            textBoxOperatorMean.TabIndex = 13;
            textBoxOperatorMean.Text = "0,08";
            
            labelOperatorDerivation.AutoSize = true;
            labelOperatorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperatorDerivation.Location = new Point(10, 580);
            labelOperatorDerivation.Name = "labelOperatorDerivation";
            labelOperatorDerivation.Size = new Size(429, 45);
            labelOperatorDerivation.TabIndex = 12;
            labelOperatorDerivation.Text = "Разброс интенсивности, 1/c";

            textBoxOperatorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatorDerivation.Location = new Point(460, 580);
            textBoxOperatorDerivation.Name = "textBoxOperatorDerivation";
            textBoxOperatorDerivation.Size = new Size(176, 50);
            textBoxOperatorDerivation.TabIndex = 7;
            textBoxOperatorDerivation.Text = "0,5";

            btnDeleteOperator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteOperator.Location = new Point(10, 620);
            btnDeleteOperator.Name = "btnDeleteOperator";
            btnDeleteOperator.Size = new Size(180, 50);
            btnDeleteOperator.TabIndex = 18;
            btnDeleteOperator.Text = "Удалить";
            btnDeleteOperator.UseVisualStyleBackColor = true;
            btnDeleteOperator.Click += button3_Click;

            btnAddOperator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddOperator.Location = new Point(432, 620);
            btnAddOperator.Name = "btnAddOperator";
            btnAddOperator.Size = new Size(180, 50);
            btnAddOperator.TabIndex = 14;
            btnAddOperator.Text = "Добавить";
            btnAddOperator.UseVisualStyleBackColor = true;
            btnAddOperator.Click += button4_Click;

            listOperator.Location = new Point(10, 670);
            listOperator.Name = "listOperator";
            listOperator.Size = new Size(650, 200);
            listOperator.TabIndex = 10;
            listOperator.UseCompatibleStateImageBehavior = false;

            labelModellingTime.AutoSize = true;
            labelModellingTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelModellingTime.Location = new Point(10, 900);
            labelModellingTime.Name = "labelModellingTime";
            labelModellingTime.Size = new Size(388, 45);
            labelModellingTime.TabIndex = 19;
            labelModellingTime.Text = "Время моделирования, с";

            textBoxModellingTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxModellingTime.Location = new Point(420, 900);
            textBoxModellingTime.Name = "textBoxModellingTime";
            textBoxModellingTime.Size = new Size(216, 50);
            textBoxModellingTime.TabIndex = 20;
            textBoxModellingTime.Text = "1000";

            btnStartModelling.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartModelling.Location = new Point(10, 960);
            btnStartModelling.Name = "btnStartModelling";
            btnStartModelling.Size = new Size(650, 50);
            btnStartModelling.TabIndex = 21;
            btnStartModelling.Text = "Моделировать";
            btnStartModelling.UseVisualStyleBackColor = true;
            btnStartModelling.Click += button5_Click;

            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 1020);
            label9.Name = "label9";
            label9.Size = new Size(431, 45);
            label9.TabIndex = 22;
            label9.Text = "Расчетная загрузка системы";

            textBoxTheorWorkload.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTheorWorkload.Location = new Point(512, 1020);
            textBoxTheorWorkload.Name = "textBoxTheorWorkload";
            textBoxTheorWorkload.ReadOnly = true;
            textBoxTheorWorkload.Size = new Size(136, 50);
            textBoxTheorWorkload.TabIndex = 23;

            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 1080);
            label10.Name = "label10";
            label10.Size = new Size(469, 45);
            label10.TabIndex = 24;
            label10.Text = "Фактическая загрузка системы";

            textBoxActualWorkload.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxActualWorkload.Location = new Point(512, 1080);
            textBoxActualWorkload.Name = "textBoxActualWorkload";
            textBoxActualWorkload.ReadOnly = true;
            textBoxActualWorkload.Size = new Size(136, 50);
            textBoxActualWorkload.TabIndex = 25;

            // splitter1.Location = new Point(0, 0);
            // splitter1.Name = "splitter1";
            // splitter1.Size = new Size(4, 1080);
            // splitter1.TabIndex = 26;
            // splitter1.TabStop = false;

            // splitter2.Location = new Point(4, 0);
            // splitter2.Name = "splitter2";
            // splitter2.Size = new Size(4, 1140);
            // splitter2.TabIndex = 27;
            // splitter2.TabStop = false;

            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(10, 1140);
            label11.Name = "label11";
            label11.Size = new Size(435, 45);
            label11.TabIndex = 28;
            label11.Text = "Среднее время ожидания, с";

            textBoxMeanWaitTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMeanWaitTime.Location = new Point(512, 1140);
            textBoxMeanWaitTime.Name = "textBoxMeanWaitTime";
            textBoxMeanWaitTime.ReadOnly = true;
            textBoxMeanWaitTime.Size = new Size(136, 50);
            textBoxMeanWaitTime.TabIndex = 29;

            // experiment

            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(750, 10);
            label12.Name = "label12";
            label12.Size = new Size(600, 45);
            label12.TabIndex = 33;
            label12.Text = "Интенсивность поступления заявок, 1/c";

            textBox17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox17.Location = new Point(1375, 10);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(112, 40);
            textBox17.TabIndex = 66;
            textBox17.Text = "0,1";

            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1550, 10);
            label19.Name = "label19";
            label19.Size = new Size(140, 45);
            label19.TabIndex = 82;
            label19.Text = "Разброс, 1/c";

            textBox13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(1750, 10);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(112, 50);
            textBox13.TabIndex = 83;
            textBox13.Text = "0,5";

            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(750, 60);
            label20.Name = "label20";
            label20.Size = new Size(577, 45);
            label20.TabIndex = 89;
            label20.Text = "Интенсивность обработки заявок, 1/c";

            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1375, 60);
            label13.Name = "label13";
            label13.Size = new Size(57, 45);
            label13.TabIndex = 35;
            label13.Text = "От";

            textBox8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(1450, 60);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(104, 50);
            textBox8.TabIndex = 34;
            textBox8.Text = "0,01";

            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1600, 60);
            label14.Name = "label14";
            label14.Size = new Size(61, 45);
            label14.TabIndex = 36;
            label14.Text = "До";

            textBox9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(1700, 60);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(112, 50);
            textBox9.TabIndex = 37;
            textBox9.Text = "1,0";

            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(1850, 60);
            label21.Name = "label21";
            label21.Size = new Size(78, 45);
            label21.TabIndex = 52;
            label21.Text = "Шаг";

            textBox14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(1950, 60);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(96, 50);
            textBox14.TabIndex = 53;
            textBox14.Text = "0,01";

            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(2075, 60);
            label25.Name = "label25";
            label25.Size = new Size(78, 45);
            label25.TabIndex = 52;
            label25.Text = "Разброс, 1/c";

            textBox19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox19.Location = new Point(2275, 60);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(96, 50);
            textBox19.TabIndex = 53;
            textBox19.Text = "0,5";

            button6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(750, 120);
            button6.Name = "button6";
            button6.Size = new Size(1500, 64);
            button6.TabIndex = 84;
            button6.Text = "Построить графики";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;

            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(750, 190);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(716, 432);
            chart1.TabIndex = 85;
            chart1.Text = "chart1";

            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(1500, 190);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(716, 432);
            chart2.TabIndex = 86;
            chart2.Text = "chart2";

            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(750, 632);
            label24.Name = "label24";
            label24.Size = new Size(603, 45);
            label24.TabIndex = 90;
            label24.Text = "Интенсивность поступления заявок, 1/c";

            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(1375, 632);
            label23.Name = "label23";
            label23.Size = new Size(57, 45);
            label23.TabIndex = 92;
            label23.Text = "От";

            textBox18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox18.Location = new Point(1450, 632);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(104, 50);
            textBox18.TabIndex = 91;
            textBox18.Text = "0,01";

            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(1600, 632);
            label22.Name = "label22";
            label22.Size = new Size(61, 45);
            label22.TabIndex = 93;
            label22.Text = "До";

            textBox16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox16.Location = new Point(1700, 632);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(112, 50);
            textBox16.TabIndex = 94;
            textBox16.Text = "0,19";

            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1850, 632);
            label18.Name = "label18";
            label18.Size = new Size(78, 45);
            label18.TabIndex = 95;
            label18.Text = "Шаг";

            textBox15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox15.Location = new Point(1950, 632);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(96, 50);
            textBox15.TabIndex = 96;
            textBox15.Text = "0,01";

            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(2075, 632);
            label17.Name = "label17";
            label17.Size = new Size(140, 45);
            label17.TabIndex = 98;
            label17.Text = "Разброс, 1/с";

            textBox11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(2275, 632);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(104, 50);
            textBox11.TabIndex = 99;
            textBox11.Text = "0,5";

            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(750, 688);
            label15.Name = "label15";
            label15.Size = new Size(577, 45);
            label15.TabIndex = 103;
            label15.Text = "Интенсивность обработки заявок, 1/c";

            textBox12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(1375, 688);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(112, 50);
            textBox12.TabIndex = 97;
            textBox12.Text = "0,08";

            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(1550, 688);
            label26.Name = "label26";
            label26.Size = new Size(78, 45);
            label26.TabIndex = 52;
            label26.Text = "Разброс, 1/c";

            textBox20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox20.Location = new Point(1750, 688);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(96, 50);
            textBox20.TabIndex = 53;
            textBox20.Text = "0,5";

            button7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(750, 752);
            button7.Name = "button7";
            button7.Size = new Size(1500, 64);
            button7.TabIndex = 100;
            button7.Text = "Построить графики";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;

            chartArea4.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart4.Legends.Add(legend4);
            chart4.Location = new Point(750, 824);
            chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart4.Series.Add(series4);
            chart4.Size = new Size(716, 420);
            chart4.TabIndex = 104;
            chart4.Text = "chart4";

            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(1500, 824);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(716, 420);
            chart3.TabIndex = 105;
            chart3.Text = "chart3";

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
            Controls.Add(textBoxModellingTime);
            Controls.Add(labelModellingTime);
            Controls.Add(btnDeleteOperator);
            Controls.Add(labelNormal);
            Controls.Add(btnAddOperator);
            Controls.Add(textBoxOperatorMean);
            Controls.Add(labelOperatorMean);
            Controls.Add(labelOperator);
            Controls.Add(listOperator);
            Controls.Add(btnDeleteGenerator);
            Controls.Add(labelUniform);
            Controls.Add(textBoxGeneratorDerivation);
            Controls.Add(labelGeneratorDerivation);
            Controls.Add(btnAddGenerator);
            Controls.Add(textBoxGeneratorMean);
            Controls.Add(labelGeneratorMean);
            Controls.Add(labelGenerator);
            Controls.Add(labelOperatorDerivation);
            Controls.Add(listGenerator);
            Controls.Add(textBox19);
            Controls.Add(textBox20);
            Controls.Add(label25);
            Controls.Add(label26);

            Name = "Form1";
            Text = "Лабораторная работа №1";
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
        private Label labelGeneratorMean;
        private TextBox textBoxGeneratorMean;
        private Button btnAddGenerator;
        private Label labelGeneratorDerivation;
        private TextBox textBoxGeneratorDerivation;
        private Label labelUniform;
        private Button btnDeleteGenerator;
        private Button btnDeleteOperator;
        private Label labelNormal;
        private Button btnAddOperator;
        private TextBox textBoxOperatorMean;
        private Label labelOperatorMean;
        private Label labelOperator;
        private ListView listOperator;
        private Button btnStartModelling;
        private TextBox textBoxModellingTime;
        private Label labelModellingTime;
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
        private TextBox textBox19;
        private TextBox textBox20;

        private Label label24;
        private Label labelOperatorDerivation;
        private Label label17;
        private Label label25;
        private Label label26;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}