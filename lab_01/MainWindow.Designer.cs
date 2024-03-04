namespace QueuingSystem
{
    partial class MainWindow
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // listGenerator
            // 
            listGenerator.Location = new Point(7, 152);
            listGenerator.Margin = new Padding(2);
            listGenerator.Name = "listGenerator";
            listGenerator.Size = new Size(456, 122);
            listGenerator.TabIndex = 0;
            listGenerator.UseCompatibleStateImageBehavior = false;
            // 
            // labelGenerator
            // 
            labelGenerator.AutoSize = true;
            labelGenerator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelGenerator.Location = new Point(7, 2);
            labelGenerator.Margin = new Padding(2, 0, 2, 0);
            labelGenerator.Name = "labelGenerator";
            labelGenerator.Size = new Size(119, 30);
            labelGenerator.TabIndex = 1;
            labelGenerator.Text = "Генератор";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelGeneratorMean
            // 
            labelGeneratorMean.AutoSize = true;
            labelGeneratorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGeneratorMean.Location = new Point(7, 54);
            labelGeneratorMean.Margin = new Padding(2, 0, 2, 0);
            labelGeneratorMean.Name = "labelGeneratorMean";
            labelGeneratorMean.Size = new Size(180, 25);
            labelGeneratorMean.TabIndex = 3;
            labelGeneratorMean.Text = "Интенсивность, 1/c";
            // 
            // textBoxGeneratorMean
            // 
            textBoxGeneratorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratorMean.Location = new Point(322, 45);
            textBoxGeneratorMean.Margin = new Padding(2);
            textBoxGeneratorMean.Name = "textBoxGeneratorMean";
            textBoxGeneratorMean.Size = new Size(124, 32);
            textBoxGeneratorMean.TabIndex = 4;
            textBoxGeneratorMean.Text = "0,1";
            // 
            // btnAddGenerator
            // 
            btnAddGenerator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGenerator.Location = new Point(170, 106);
            btnAddGenerator.Margin = new Padding(2);
            btnAddGenerator.Name = "btnAddGenerator";
            btnAddGenerator.Size = new Size(126, 42);
            btnAddGenerator.TabIndex = 5;
            btnAddGenerator.Text = "Добавить";
            btnAddGenerator.UseVisualStyleBackColor = true;
            btnAddGenerator.Click += button1_Click;
            // 
            // labelGeneratorDerivation
            // 
            labelGeneratorDerivation.AutoSize = true;
            labelGeneratorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGeneratorDerivation.Location = new Point(7, 78);
            labelGeneratorDerivation.Margin = new Padding(2, 0, 2, 0);
            labelGeneratorDerivation.Name = "labelGeneratorDerivation";
            labelGeneratorDerivation.Size = new Size(254, 25);
            labelGeneratorDerivation.TabIndex = 6;
            labelGeneratorDerivation.Text = "Разброс интенсивности, 1/c";
            // 
            // textBoxGeneratorDerivation
            // 
            textBoxGeneratorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratorDerivation.Location = new Point(322, 81);
            textBoxGeneratorDerivation.Margin = new Padding(2);
            textBoxGeneratorDerivation.Name = "textBoxGeneratorDerivation";
            textBoxGeneratorDerivation.Size = new Size(124, 32);
            textBoxGeneratorDerivation.TabIndex = 7;
            textBoxGeneratorDerivation.Text = "0,02";
            // 
            // labelUniform
            // 
            labelUniform.AutoSize = true;
            labelUniform.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelUniform.Location = new Point(7, 30);
            labelUniform.Margin = new Padding(2, 0, 2, 0);
            labelUniform.Name = "labelUniform";
            labelUniform.Size = new Size(270, 25);
            labelUniform.TabIndex = 8;
            labelUniform.Text = "Равномерное распределение";
            // 
            // btnDeleteGenerator
            // 
            btnDeleteGenerator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteGenerator.Location = new Point(7, 106);
            btnDeleteGenerator.Margin = new Padding(2);
            btnDeleteGenerator.Name = "btnDeleteGenerator";
            btnDeleteGenerator.Size = new Size(126, 42);
            btnDeleteGenerator.TabIndex = 9;
            btnDeleteGenerator.Text = "Удалить";
            btnDeleteGenerator.UseVisualStyleBackColor = true;
            btnDeleteGenerator.Click += button2_Click;
            // 
            // btnDeleteOperator
            // 
            btnDeleteOperator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteOperator.Location = new Point(6, 467);
            btnDeleteOperator.Margin = new Padding(2);
            btnDeleteOperator.Name = "btnDeleteOperator";
            btnDeleteOperator.Size = new Size(126, 42);
            btnDeleteOperator.TabIndex = 18;
            btnDeleteOperator.Text = "Удалить";
            btnDeleteOperator.UseVisualStyleBackColor = true;
            btnDeleteOperator.Click += button3_Click;
            // 
            // labelNormal
            // 
            labelNormal.AutoSize = true;
            labelNormal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNormal.Location = new Point(6, 378);
            labelNormal.Margin = new Padding(2, 0, 2, 0);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(261, 25);
            labelNormal.TabIndex = 17;
            labelNormal.Text = "Нормальное распределение";
            // 
            // btnAddOperator
            // 
            btnAddOperator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddOperator.Location = new Point(170, 467);
            btnAddOperator.Margin = new Padding(2);
            btnAddOperator.Name = "btnAddOperator";
            btnAddOperator.Size = new Size(126, 42);
            btnAddOperator.TabIndex = 14;
            btnAddOperator.Text = "Добавить";
            btnAddOperator.UseVisualStyleBackColor = true;
            btnAddOperator.Click += button4_Click;
            // 
            // textBoxOperatorMean
            // 
            textBoxOperatorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatorMean.Location = new Point(321, 401);
            textBoxOperatorMean.Margin = new Padding(2);
            textBoxOperatorMean.Name = "textBoxOperatorMean";
            textBoxOperatorMean.Size = new Size(124, 32);
            textBoxOperatorMean.TabIndex = 13;
            textBoxOperatorMean.Text = "0,1";
            // 
            // labelOperatorMean
            // 
            labelOperatorMean.AutoSize = true;
            labelOperatorMean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperatorMean.Location = new Point(6, 409);
            labelOperatorMean.Margin = new Padding(2, 0, 2, 0);
            labelOperatorMean.Name = "labelOperatorMean";
            labelOperatorMean.Size = new Size(180, 25);
            labelOperatorMean.TabIndex = 12;
            labelOperatorMean.Text = "Интенсивность, 1/c";
            // 
            // labelOperator
            // 
            labelOperator.AutoSize = true;
            labelOperator.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperator.Location = new Point(6, 346);
            labelOperator.Margin = new Padding(2, 0, 2, 0);
            labelOperator.Name = "labelOperator";
            labelOperator.Size = new Size(277, 30);
            labelOperator.TabIndex = 11;
            labelOperator.Text = "Обслуживающий аппарат";
            // 
            // listOperator
            // 
            listOperator.Location = new Point(6, 510);
            listOperator.Margin = new Padding(2);
            listOperator.Name = "listOperator";
            listOperator.Size = new Size(456, 122);
            listOperator.TabIndex = 10;
            listOperator.UseCompatibleStateImageBehavior = false;
            // 
            // btnStartModelling
            // 
            btnStartModelling.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartModelling.Location = new Point(6, 769);
            btnStartModelling.Margin = new Padding(2);
            btnStartModelling.Name = "btnStartModelling";
            btnStartModelling.Size = new Size(447, 46);
            btnStartModelling.TabIndex = 21;
            btnStartModelling.Text = "Моделировать";
            btnStartModelling.UseVisualStyleBackColor = true;
            btnStartModelling.Click += button5_Click;
            // 
            // textBoxModellingTime
            // 
            textBoxModellingTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxModellingTime.Location = new Point(301, 730);
            textBoxModellingTime.Margin = new Padding(2);
            textBoxModellingTime.Name = "textBoxModellingTime";
            textBoxModellingTime.Size = new Size(152, 32);
            textBoxModellingTime.TabIndex = 20;
            textBoxModellingTime.Text = "1000";
            // 
            // labelModellingTime
            // 
            labelModellingTime.AutoSize = true;
            labelModellingTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelModellingTime.Location = new Point(6, 733);
            labelModellingTime.Margin = new Padding(2, 0, 2, 0);
            labelModellingTime.Name = "labelModellingTime";
            labelModellingTime.Size = new Size(229, 25);
            labelModellingTime.TabIndex = 19;
            labelModellingTime.Text = "Время моделирования, с";
            // 
            // textBoxTheorWorkload
            // 
            textBoxTheorWorkload.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTheorWorkload.Location = new Point(322, 912);
            textBoxTheorWorkload.Margin = new Padding(2);
            textBoxTheorWorkload.Name = "textBoxTheorWorkload";
            textBoxTheorWorkload.ReadOnly = true;
            textBoxTheorWorkload.Size = new Size(132, 32);
            textBoxTheorWorkload.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 915);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(257, 25);
            label9.TabIndex = 22;
            label9.Text = "Расчетная загрузка системы";
            // 
            // textBoxActualWorkload
            // 
            textBoxActualWorkload.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxActualWorkload.Location = new Point(322, 875);
            textBoxActualWorkload.Margin = new Padding(2);
            textBoxActualWorkload.Name = "textBoxActualWorkload";
            textBoxActualWorkload.ReadOnly = true;
            textBoxActualWorkload.Size = new Size(131, 32);
            textBoxActualWorkload.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(11, 878);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(278, 25);
            label10.TabIndex = 24;
            label10.Text = "Фактическая загрузка системы";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(2, 1041);
            splitter1.TabIndex = 107;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(2, 0);
            splitter2.Margin = new Padding(2);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(2, 1041);
            splitter2.TabIndex = 106;
            splitter2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(11, 953);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(256, 25);
            label11.TabIndex = 28;
            label11.Text = "Среднее время ожидания, с";
            // 
            // textBoxMeanWaitTime
            // 
            textBoxMeanWaitTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMeanWaitTime.Location = new Point(322, 950);
            textBoxMeanWaitTime.Margin = new Padding(2);
            textBoxMeanWaitTime.Name = "textBoxMeanWaitTime";
            textBoxMeanWaitTime.ReadOnly = true;
            textBoxMeanWaitTime.Size = new Size(131, 32);
            textBoxMeanWaitTime.TabIndex = 29;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(1122, 42);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(74, 32);
            textBox8.TabIndex = 34;
            textBox8.Text = "0,1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(670, 9);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(359, 25);
            label12.TabIndex = 33;
            label12.Text = "Интенсивность поступления заявок, 1/c";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1049, 45);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(34, 25);
            label13.TabIndex = 35;
            label13.Text = "От";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1230, 45);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(36, 25);
            label14.TabIndex = 36;
            label14.Text = "До";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(1286, 42);
            textBox9.Margin = new Padding(2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(80, 32);
            textBox9.TabIndex = 37;
            textBox9.Text = "0,3";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(1391, 48);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(47, 25);
            label21.TabIndex = 52;
            label21.Text = "Шаг";
            // 
            // textBoxOperatorDerivation
            // 
            textBoxOperatorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatorDerivation.Location = new Point(321, 438);
            textBoxOperatorDerivation.Margin = new Padding(2);
            textBoxOperatorDerivation.Name = "textBoxOperatorDerivation";
            textBoxOperatorDerivation.Size = new Size(124, 32);
            textBoxOperatorDerivation.TabIndex = 7;
            textBoxOperatorDerivation.Text = "0,02";
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(1473, 45);
            textBox14.Margin = new Padding(2);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(68, 32);
            textBox14.TabIndex = 53;
            textBox14.Text = "0,0025";
            // 
            // textBox17
            // 
            textBox17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox17.Location = new Point(1068, 5);
            textBox17.Margin = new Padding(2);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(80, 32);
            textBox17.TabIndex = 66;
            textBox17.Text = "0,1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1187, 9);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(118, 25);
            label19.TabIndex = 82;
            label19.Text = "Разброс, 1/c";
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(1362, 6);
            textBox13.Margin = new Padding(2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(80, 32);
            textBox13.TabIndex = 83;
            textBox13.Text = "0,02";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(670, 81);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(1135, 38);
            button6.TabIndex = 84;
            button6.Text = "Построить графики";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(1230, 123);
            chart2.Margin = new Padding(2);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(575, 357);
            chart2.TabIndex = 86;
            chart2.Text = "chart2";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(670, 45);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(341, 25);
            label20.TabIndex = 89;
            label20.Text = "Интенсивность обработки заявок, 1/c";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(670, 566);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(341, 25);
            label15.TabIndex = 103;
            label15.Text = "Интенсивность обработки заявок, 1/c";
            // 
            // labelOperatorDerivation
            // 
            labelOperatorDerivation.AutoSize = true;
            labelOperatorDerivation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperatorDerivation.Location = new Point(6, 440);
            labelOperatorDerivation.Margin = new Padding(2, 0, 2, 0);
            labelOperatorDerivation.Name = "labelOperatorDerivation";
            labelOperatorDerivation.Size = new Size(254, 25);
            labelOperatorDerivation.TabIndex = 12;
            labelOperatorDerivation.Text = "Разброс интенсивности, 1/c";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(670, 621);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(1135, 38);
            button7.TabIndex = 100;
            button7.Text = "Построить графики";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(1747, 523);
            textBox11.Margin = new Padding(2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(74, 32);
            textBox11.TabIndex = 99;
            textBox11.Text = "0,02";
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(1076, 563);
            textBox12.Margin = new Padding(2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(80, 32);
            textBox12.TabIndex = 97;
            textBox12.Text = "0,15";
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox15.Location = new Point(1487, 523);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(68, 32);
            textBox15.TabIndex = 96;
            textBox15.Text = "0,0025";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1415, 526);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(47, 25);
            label18.TabIndex = 95;
            label18.Text = "Шаг";
            // 
            // textBox16
            // 
            textBox16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox16.Location = new Point(1309, 523);
            textBox16.Margin = new Padding(2);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(80, 32);
            textBox16.TabIndex = 94;
            textBox16.Text = "0,15";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(1244, 526);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(36, 25);
            label22.TabIndex = 93;
            label22.Text = "До";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(1078, 526);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(34, 25);
            label23.TabIndex = 92;
            label23.Text = "От";
            // 
            // textBox18
            // 
            textBox18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox18.Location = new Point(1144, 523);
            textBox18.Margin = new Padding(2);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(74, 32);
            textBox18.TabIndex = 91;
            textBox18.Text = "0,05";
            // 
            // textBox19
            // 
            textBox19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox19.Location = new Point(1737, 42);
            textBox19.Margin = new Padding(2);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(68, 32);
            textBox19.TabIndex = 53;
            textBox19.Text = "0,05";
            // 
            // textBox20
            // 
            textBox20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox20.Location = new Point(1357, 563);
            textBox20.Margin = new Padding(2);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(68, 32);
            textBox20.TabIndex = 53;
            textBox20.Text = "0,02";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(1586, 526);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(118, 25);
            label17.TabIndex = 98;
            label17.Text = "Разброс, 1/с";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(670, 526);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(359, 25);
            label24.TabIndex = 90;
            label24.Text = "Интенсивность поступления заявок, 1/c";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(1578, 45);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(118, 25);
            label25.TabIndex = 52;
            label25.Text = "Разброс, 1/c";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(1194, 566);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(118, 25);
            label26.TabIndex = 52;
            label26.Text = "Разброс, 1/c";
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart3.Legends.Add(legend2);
            chart3.Location = new Point(1230, 663);
            chart3.Margin = new Padding(2);
            chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart3.Series.Add(series2);
            chart3.Size = new Size(575, 337);
            chart3.TabIndex = 105;
            chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea3.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart4.Legends.Add(legend3);
            chart4.Location = new Point(670, 663);
            chart4.Margin = new Padding(2);
            chart4.Name = "chart4";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart4.Series.Add(series3);
            chart4.Size = new Size(556, 337);
            chart4.TabIndex = 104;
            chart4.Text = "chart4";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart1.Legends.Add(legend4);
            chart1.Location = new Point(670, 123);
            chart1.Margin = new Padding(2);
            chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart1.Series.Add(series4);
            chart1.Size = new Size(556, 357);
            chart1.TabIndex = 85;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
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
            Margin = new Padding(2);
            Name = "MainWindow";
            Text = "Лабораторная работа №1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}