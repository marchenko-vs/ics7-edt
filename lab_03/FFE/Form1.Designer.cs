namespace FFE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FEGridView = new DataGridView();
            NormLinear = new TextBox();
            NormNonLinear = new TextBox();
            FactTime = new TextBox();
            FENonLinearTime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ModelBtn = new Button();
            label3 = new Label();
            Gen1Intensity = new TextBox();
            label4 = new Label();
            Gen2Intensity = new TextBox();
            label5 = new Label();
            Gen1Var = new TextBox();
            label6 = new Label();
            Gen2Var = new TextBox();
            label7 = new Label();
            Proc2Var = new TextBox();
            label8 = new Label();
            Proc1Var = new TextBox();
            label9 = new Label();
            Proc2Intensity = new TextBox();
            label10 = new Label();
            Proc1Intensity = new TextBox();
            label11 = new Label();
            X6Max = new TextBox();
            label12 = new Label();
            X5Max = new TextBox();
            label13 = new Label();
            X2Max = new TextBox();
            label14 = new Label();
            X1Max = new TextBox();
            label15 = new Label();
            X6Min = new TextBox();
            label16 = new Label();
            X5Min = new TextBox();
            label17 = new Label();
            X2Min = new TextBox();
            label18 = new Label();
            X1Min = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            X8Max = new TextBox();
            X7Max = new TextBox();
            X4Max = new TextBox();
            X3Max = new TextBox();
            X8Min = new TextBox();
            X7Min = new TextBox();
            X4Min = new TextBox();
            X3Min = new TextBox();
            FFDGridView = new DataGridView();
            FFDNormNonLinear = new TextBox();
            FFDNormLinear = new TextBox();
            label35 = new Label();
            label36 = new Label();
            FFDNonLinearTime = new TextBox();
            FFDNaturNonLinear = new TextBox();
            FFDNaturLinear = new TextBox();
            FENaturNonLinear = new TextBox();
            FENaturLinear = new TextBox();
            button1 = new Button();
            FFDDiff = new TextBox();
            label37 = new Label();
            FEDiff = new TextBox();
            FFDSqrDiff = new TextBox();
            label38 = new Label();
            FESqrDiff = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            ((System.ComponentModel.ISupportInitialize)FEGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FFDGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // FEGridView
            // 
            FEGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FEGridView.Location = new Point(12, 39);
            FEGridView.Name = "FEGridView";
            FEGridView.Size = new Size(934, 450);
            FEGridView.TabIndex = 0;
            // 
            // NormLinear
            // 
            NormLinear.Location = new Point(140, 497);
            NormLinear.Name = "NormLinear";
            NormLinear.Size = new Size(806, 23);
            NormLinear.TabIndex = 1;
            // 
            // NormNonLinear
            // 
            NormNonLinear.Location = new Point(140, 526);
            NormNonLinear.Name = "NormNonLinear";
            NormNonLinear.Size = new Size(806, 23);
            NormNonLinear.TabIndex = 2;
            // 
            // FactTime
            // 
            FactTime.Location = new Point(491, 114);
            FactTime.Name = "FactTime";
            FactTime.Size = new Size(290, 23);
            FactTime.TabIndex = 3;
            // 
            // FENonLinearTime
            // 
            FENonLinearTime.Location = new Point(491, 143);
            FENonLinearTime.Name = "FENonLinearTime";
            FENonLinearTime.Size = new Size(132, 23);
            FENonLinearTime.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 117);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 5;
            label1.Text = "Фактическое время";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 146);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Теоретическое время";
            // 
            // ModelBtn
            // 
            ModelBtn.Location = new Point(640, 918);
            ModelBtn.Name = "ModelBtn";
            ModelBtn.Size = new Size(321, 49);
            ModelBtn.TabIndex = 7;
            ModelBtn.Text = "Моделировать";
            ModelBtn.UseVisualStyleBackColor = true;
            ModelBtn.Click += ModelBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 677);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 9;
            label3.Text = "Интенсивность генератора 1";
            // 
            // Gen1Intensity
            // 
            Gen1Intensity.Location = new Point(829, 674);
            Gen1Intensity.Name = "Gen1Intensity";
            Gen1Intensity.Size = new Size(132, 23);
            Gen1Intensity.TabIndex = 8;
            Gen1Intensity.Text = "0,2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 738);
            label4.Name = "label4";
            label4.Size = new Size(165, 15);
            label4.TabIndex = 11;
            label4.Text = "Интенсивность генератора 2";
            // 
            // Gen2Intensity
            // 
            Gen2Intensity.Location = new Point(829, 735);
            Gen2Intensity.Name = "Gen2Intensity";
            Gen2Intensity.Size = new Size(132, 23);
            Gen2Intensity.TabIndex = 10;
            Gen2Intensity.Text = "0,55";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 708);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 13;
            label5.Text = "Разброс генератора 1";
            // 
            // Gen1Var
            // 
            Gen1Var.Location = new Point(829, 705);
            Gen1Var.Name = "Gen1Var";
            Gen1Var.Size = new Size(132, 23);
            Gen1Var.TabIndex = 12;
            Gen1Var.Text = "0,06";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(640, 768);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 15;
            label6.Text = "Разброс генератора 2";
            // 
            // Gen2Var
            // 
            Gen2Var.Location = new Point(829, 765);
            Gen2Var.Name = "Gen2Var";
            Gen2Var.Size = new Size(132, 23);
            Gen2Var.TabIndex = 14;
            Gen2Var.Text = "0,15";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(640, 892);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 23;
            label7.Text = "Разброс ОА 2";
            // 
            // Proc2Var
            // 
            Proc2Var.Location = new Point(829, 889);
            Proc2Var.Name = "Proc2Var";
            Proc2Var.Size = new Size(132, 23);
            Proc2Var.TabIndex = 22;
            Proc2Var.Text = "0,5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(640, 832);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 21;
            label8.Text = "Разброс ОА 1";
            // 
            // Proc1Var
            // 
            Proc1Var.Location = new Point(829, 829);
            Proc1Var.Name = "Proc1Var";
            Proc1Var.Size = new Size(132, 23);
            Proc1Var.TabIndex = 20;
            Proc1Var.Text = "0,25";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(640, 862);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 19;
            label9.Text = "Интенсивность ОА 2";
            // 
            // Proc2Intensity
            // 
            Proc2Intensity.Location = new Point(829, 859);
            Proc2Intensity.Name = "Proc2Intensity";
            Proc2Intensity.Size = new Size(132, 23);
            Proc2Intensity.TabIndex = 18;
            Proc2Intensity.Text = "1,35";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(640, 801);
            label10.Name = "label10";
            label10.Size = new Size(120, 15);
            label10.TabIndex = 17;
            label10.Text = "Интенсивность ОА 1";
            // 
            // Proc1Intensity
            // 
            Proc1Intensity.Location = new Point(829, 798);
            Proc1Intensity.Name = "Proc1Intensity";
            Proc1Intensity.Size = new Size(132, 23);
            Proc1Intensity.TabIndex = 16;
            Proc1Intensity.Text = "0,95";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 875);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 41;
            label11.Text = "Разброс ОА 2";
            // 
            // X6Max
            // 
            X6Max.Location = new Point(437, 753);
            X6Max.Name = "X6Max";
            X6Max.Size = new Size(132, 23);
            X6Max.TabIndex = 40;
            X6Max.Text = "0,2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 816);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 39;
            label12.Text = "Разброс ОА 1";
            // 
            // X5Max
            // 
            X5Max.Location = new Point(437, 694);
            X5Max.Name = "X5Max";
            X5Max.Size = new Size(132, 23);
            X5Max.TabIndex = 38;
            X5Max.Text = "0,07";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 845);
            label13.Name = "label13";
            label13.Size = new Size(120, 15);
            label13.TabIndex = 37;
            label13.Text = "Интенсивность ОА 2";
            // 
            // X2Max
            // 
            X2Max.Location = new Point(437, 723);
            X2Max.Name = "X2Max";
            X2Max.Size = new Size(132, 23);
            X2Max.TabIndex = 36;
            X2Max.Text = "0,7";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 785);
            label14.Name = "label14";
            label14.Size = new Size(120, 15);
            label14.TabIndex = 35;
            label14.Text = "Интенсивность ОА 1";
            // 
            // X1Max
            // 
            X1Max.Location = new Point(437, 663);
            X1Max.Name = "X1Max";
            X1Max.Size = new Size(132, 23);
            X1Max.TabIndex = 34;
            X1Max.Text = "0,3";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 756);
            label15.Name = "label15";
            label15.Size = new Size(126, 15);
            label15.TabIndex = 33;
            label15.Text = "Разброс генератора 2";
            // 
            // X6Min
            // 
            X6Min.Location = new Point(257, 753);
            X6Min.Name = "X6Min";
            X6Min.Size = new Size(132, 23);
            X6Min.TabIndex = 32;
            X6Min.Text = "0,1";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(23, 697);
            label16.Name = "label16";
            label16.Size = new Size(126, 15);
            label16.TabIndex = 31;
            label16.Text = "Разброс генератора 1";
            // 
            // X5Min
            // 
            X5Min.Location = new Point(257, 694);
            X5Min.Name = "X5Min";
            X5Min.Size = new Size(132, 23);
            X5Min.TabIndex = 30;
            X5Min.Text = "0,05";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 726);
            label17.Name = "label17";
            label17.Size = new Size(165, 15);
            label17.TabIndex = 29;
            label17.Text = "Интенсивность генератора 2";
            // 
            // X2Min
            // 
            X2Min.Location = new Point(257, 723);
            X2Min.Name = "X2Min";
            X2Min.Size = new Size(132, 23);
            X2Min.TabIndex = 28;
            X2Min.Text = "0,4";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(23, 666);
            label18.Name = "label18";
            label18.Size = new Size(165, 15);
            label18.TabIndex = 27;
            label18.Text = "Интенсивность генератора 1";
            // 
            // X1Min
            // 
            X1Min.Location = new Point(257, 663);
            X1Min.Name = "X1Min";
            X1Min.Size = new Size(132, 23);
            X1Min.TabIndex = 26;
            X1Min.Text = "0,1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(232, 666);
            label19.Name = "label19";
            label19.Size = new Size(19, 15);
            label19.TabIndex = 42;
            label19.Text = "от";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(232, 697);
            label20.Name = "label20";
            label20.Size = new Size(19, 15);
            label20.TabIndex = 43;
            label20.Text = "от";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(232, 757);
            label21.Name = "label21";
            label21.Size = new Size(19, 15);
            label21.TabIndex = 45;
            label21.Text = "от";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(232, 726);
            label22.Name = "label22";
            label22.Size = new Size(19, 15);
            label22.TabIndex = 44;
            label22.Text = "от";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(403, 666);
            label23.Name = "label23";
            label23.Size = new Size(20, 15);
            label23.TabIndex = 46;
            label23.Text = "до";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(403, 697);
            label24.Name = "label24";
            label24.Size = new Size(20, 15);
            label24.TabIndex = 47;
            label24.Text = "до";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(403, 757);
            label25.Name = "label25";
            label25.Size = new Size(20, 15);
            label25.TabIndex = 49;
            label25.Text = "до";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(403, 726);
            label26.Name = "label26";
            label26.Size = new Size(20, 15);
            label26.TabIndex = 48;
            label26.Text = "до";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(403, 876);
            label27.Name = "label27";
            label27.Size = new Size(20, 15);
            label27.TabIndex = 65;
            label27.Text = "до";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(403, 845);
            label28.Name = "label28";
            label28.Size = new Size(20, 15);
            label28.TabIndex = 64;
            label28.Text = "до";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(403, 816);
            label29.Name = "label29";
            label29.Size = new Size(20, 15);
            label29.TabIndex = 63;
            label29.Text = "до";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(403, 785);
            label30.Name = "label30";
            label30.Size = new Size(20, 15);
            label30.TabIndex = 62;
            label30.Text = "до";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(232, 876);
            label31.Name = "label31";
            label31.Size = new Size(19, 15);
            label31.TabIndex = 61;
            label31.Text = "от";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(232, 845);
            label32.Name = "label32";
            label32.Size = new Size(19, 15);
            label32.TabIndex = 60;
            label32.Text = "от";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(232, 816);
            label33.Name = "label33";
            label33.Size = new Size(19, 15);
            label33.TabIndex = 59;
            label33.Text = "от";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(232, 785);
            label34.Name = "label34";
            label34.Size = new Size(19, 15);
            label34.TabIndex = 58;
            label34.Text = "от";
            // 
            // X8Max
            // 
            X8Max.Location = new Point(437, 872);
            X8Max.Name = "X8Max";
            X8Max.Size = new Size(132, 23);
            X8Max.TabIndex = 57;
            X8Max.Text = "0,6";
            // 
            // X7Max
            // 
            X7Max.Location = new Point(437, 813);
            X7Max.Name = "X7Max";
            X7Max.Size = new Size(132, 23);
            X7Max.TabIndex = 56;
            X7Max.Text = "0,3";
            // 
            // X4Max
            // 
            X4Max.Location = new Point(437, 842);
            X4Max.Name = "X4Max";
            X4Max.Size = new Size(132, 23);
            X4Max.TabIndex = 55;
            X4Max.Text = "1,5";
            // 
            // X3Max
            // 
            X3Max.Location = new Point(437, 782);
            X3Max.Name = "X3Max";
            X3Max.Size = new Size(132, 23);
            X3Max.TabIndex = 54;
            X3Max.Text = "1,2";
            // 
            // X8Min
            // 
            X8Min.Location = new Point(257, 872);
            X8Min.Name = "X8Min";
            X8Min.Size = new Size(132, 23);
            X8Min.TabIndex = 53;
            X8Min.Text = "0,4";
            // 
            // X7Min
            // 
            X7Min.Location = new Point(257, 813);
            X7Min.Name = "X7Min";
            X7Min.Size = new Size(132, 23);
            X7Min.TabIndex = 52;
            X7Min.Text = "0,2";
            // 
            // X4Min
            // 
            X4Min.Location = new Point(257, 842);
            X4Min.Name = "X4Min";
            X4Min.Size = new Size(132, 23);
            X4Min.TabIndex = 51;
            X4Min.Text = "1,2";
            // 
            // X3Min
            // 
            X3Min.Location = new Point(257, 782);
            X3Min.Name = "X3Min";
            X3Min.Size = new Size(132, 23);
            X3Min.TabIndex = 50;
            X3Min.Text = "0,7";
            // 
            // FFDGridView
            // 
            FFDGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FFDGridView.Location = new Point(952, 39);
            FFDGridView.Name = "FFDGridView";
            FFDGridView.Size = new Size(940, 450);
            FFDGridView.TabIndex = 66;
            // 
            // FFDNormNonLinear
            // 
            FFDNormNonLinear.Location = new Point(952, 526);
            FFDNormNonLinear.Name = "FFDNormNonLinear";
            FFDNormNonLinear.Size = new Size(940, 23);
            FFDNormNonLinear.TabIndex = 69;
            // 
            // FFDNormLinear
            // 
            FFDNormLinear.Location = new Point(952, 497);
            FFDNormLinear.Name = "FFDNormLinear";
            FFDNormLinear.Size = new Size(940, 23);
            FFDNormLinear.TabIndex = 68;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(544, 85);
            label35.Name = "label35";
            label35.Size = new Size(32, 15);
            label35.TabIndex = 70;
            label35.Text = "ПФЭ";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(702, 85);
            label36.Name = "label36";
            label36.Size = new Size(31, 15);
            label36.TabIndex = 73;
            label36.Text = "ДФЭ";
            // 
            // FFDNonLinearTime
            // 
            FFDNonLinearTime.Location = new Point(649, 143);
            FFDNonLinearTime.Name = "FFDNonLinearTime";
            FFDNonLinearTime.Size = new Size(132, 23);
            FFDNonLinearTime.TabIndex = 72;
            // 
            // FFDNaturNonLinear
            // 
            FFDNaturNonLinear.Location = new Point(952, 584);
            FFDNaturNonLinear.Name = "FFDNaturNonLinear";
            FFDNaturNonLinear.Size = new Size(940, 23);
            FFDNaturNonLinear.TabIndex = 77;
            FFDNaturNonLinear.Visible = false;
            // 
            // FFDNaturLinear
            // 
            FFDNaturLinear.Location = new Point(952, 555);
            FFDNaturLinear.Name = "FFDNaturLinear";
            FFDNaturLinear.Size = new Size(940, 23);
            FFDNaturLinear.TabIndex = 76;
            // 
            // FENaturNonLinear
            // 
            FENaturNonLinear.Location = new Point(140, 584);
            FENaturNonLinear.Name = "FENaturNonLinear";
            FENaturNonLinear.Size = new Size(806, 23);
            FENaturNonLinear.TabIndex = 75;
            FENaturNonLinear.Visible = false;
            // 
            // FENaturLinear
            // 
            FENaturLinear.Location = new Point(140, 555);
            FENaturLinear.Name = "FENaturLinear";
            FENaturLinear.Size = new Size(806, 23);
            FENaturLinear.TabIndex = 74;
            // 
            // button1
            // 
            button1.Location = new Point(23, 913);
            button1.Name = "button1";
            button1.Size = new Size(546, 52);
            button1.TabIndex = 78;
            button1.Text = "Провести эксперименты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FFDDiff
            // 
            FFDDiff.Location = new Point(649, 174);
            FFDDiff.Name = "FFDDiff";
            FFDDiff.Size = new Size(132, 23);
            FFDDiff.TabIndex = 81;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(355, 177);
            label37.Name = "label37";
            label37.Size = new Size(56, 15);
            label37.TabIndex = 80;
            label37.Text = "Разность";
            // 
            // FEDiff
            // 
            FEDiff.Location = new Point(491, 174);
            FEDiff.Name = "FEDiff";
            FEDiff.Size = new Size(132, 23);
            FEDiff.TabIndex = 79;
            // 
            // FFDSqrDiff
            // 
            FFDSqrDiff.Location = new Point(649, 202);
            FFDSqrDiff.Name = "FFDSqrDiff";
            FFDSqrDiff.Size = new Size(132, 23);
            FFDSqrDiff.TabIndex = 84;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(355, 205);
            label38.Name = "label38";
            label38.Size = new Size(103, 15);
            label38.TabIndex = 83;
            label38.Text = "Квадрат разности";
            // 
            // FESqrDiff
            // 
            FESqrDiff.Location = new Point(491, 202);
            FESqrDiff.Name = "FESqrDiff";
            FESqrDiff.Size = new Size(132, 23);
            FESqrDiff.TabIndex = 82;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FFDSqrDiff);
            groupBox1.Controls.Add(label35);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(FactTime);
            groupBox1.Controls.Add(FESqrDiff);
            groupBox1.Controls.Add(FENonLinearTime);
            groupBox1.Controls.Add(FFDDiff);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label37);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FEDiff);
            groupBox1.Controls.Add(FFDNonLinearTime);
            groupBox1.Controls.Add(label36);
            groupBox1.Location = new Point(630, 638);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 338);
            groupBox1.TabIndex = 85;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сравнение результатов";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 638);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(569, 338);
            groupBox2.TabIndex = 86;
            groupBox2.TabStop = false;
            groupBox2.Text = "Интервалы варьирования факторов";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(437, 12);
            label39.Name = "label39";
            label39.Size = new Size(32, 15);
            label39.TabIndex = 87;
            label39.Text = "ПФЭ";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(1397, 12);
            label40.Name = "label40";
            label40.Size = new Size(31, 15);
            label40.TabIndex = 88;
            label40.Text = "ДФЭ";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(12, 500);
            label41.Name = "label41";
            label41.Size = new Size(73, 15);
            label41.TabIndex = 89;
            label41.Text = "Лин. (норм)";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(12, 529);
            label42.Name = "label42";
            label42.Size = new Size(118, 15);
            label42.TabIndex = 90;
            label42.Text = "Част.-нелин. (норм)";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(12, 587);
            label43.Name = "label43";
            label43.Size = new Size(119, 15);
            label43.TabIndex = 92;
            label43.Text = "Част.-нелин. (натур)";
            label43.Visible = false;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(12, 558);
            label44.Name = "label44";
            label44.Size = new Size(74, 15);
            label44.TabIndex = 91;
            label44.Text = "Лин. (натур)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 988);
            Controls.Add(label43);
            Controls.Add(label44);
            Controls.Add(label42);
            Controls.Add(label41);
            Controls.Add(label40);
            Controls.Add(label39);
            Controls.Add(button1);
            Controls.Add(FFDNaturNonLinear);
            Controls.Add(FFDNaturLinear);
            Controls.Add(FENaturNonLinear);
            Controls.Add(FENaturLinear);
            Controls.Add(FFDNormNonLinear);
            Controls.Add(FFDNormLinear);
            Controls.Add(FFDGridView);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(X8Max);
            Controls.Add(X7Max);
            Controls.Add(X4Max);
            Controls.Add(X3Max);
            Controls.Add(X8Min);
            Controls.Add(X7Min);
            Controls.Add(X4Min);
            Controls.Add(X3Min);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label11);
            Controls.Add(X6Max);
            Controls.Add(label12);
            Controls.Add(X5Max);
            Controls.Add(label13);
            Controls.Add(X2Max);
            Controls.Add(label14);
            Controls.Add(X1Max);
            Controls.Add(label15);
            Controls.Add(X6Min);
            Controls.Add(label16);
            Controls.Add(X5Min);
            Controls.Add(label17);
            Controls.Add(X2Min);
            Controls.Add(label18);
            Controls.Add(X1Min);
            Controls.Add(label7);
            Controls.Add(Proc2Var);
            Controls.Add(label8);
            Controls.Add(Proc1Var);
            Controls.Add(label9);
            Controls.Add(Proc2Intensity);
            Controls.Add(label10);
            Controls.Add(Proc1Intensity);
            Controls.Add(label6);
            Controls.Add(Gen2Var);
            Controls.Add(label5);
            Controls.Add(Gen1Var);
            Controls.Add(label4);
            Controls.Add(Gen2Intensity);
            Controls.Add(label3);
            Controls.Add(Gen1Intensity);
            Controls.Add(ModelBtn);
            Controls.Add(NormNonLinear);
            Controls.Add(NormLinear);
            Controls.Add(FEGridView);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FEGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)FFDGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FEGridView;
        private TextBox NormLinear;
        private TextBox NormNonLinear;
        private TextBox FactTime;
        private TextBox FENonLinearTime;
        private Label label1;
        private Label label2;
        private Button ModelBtn;
        private Label label3;
        private TextBox Gen1Intensity;
        private Label label4;
        private TextBox Gen2Intensity;
        private Label label5;
        private TextBox Gen1Var;
        private Label label6;
        private TextBox Gen2Var;
        private Label label7;
        private TextBox Proc2Var;
        private Label label8;
        private TextBox Proc1Var;
        private Label label9;
        private TextBox Proc2Intensity;
        private Label label10;
        private TextBox Proc1Intensity;
        private Label label11;
        private TextBox X6Max;
        private Label label12;
        private TextBox X5Max;
        private Label label13;
        private TextBox X2Max;
        private Label label14;
        private TextBox X1Max;
        private Label label15;
        private TextBox X6Min;
        private Label label16;
        private TextBox X5Min;
        private Label label17;
        private TextBox X2Min;
        private Label label18;
        private TextBox X1Min;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private TextBox X8Max;
        private TextBox X7Max;
        private TextBox X4Max;
        private TextBox X3Max;
        private TextBox X8Min;
        private TextBox X7Min;
        private TextBox X4Min;
        private TextBox X3Min;
        private DataGridView FFDGridView;
        private TextBox FFDNormNonLinear;
        private TextBox FFDNormLinear;
        private Label label35;
        private Label label36;
        private TextBox FFDNonLinearTime;
        private TextBox FFDNaturNonLinear;
        private TextBox FFDNaturLinear;
        private TextBox FENaturNonLinear;
        private TextBox FENaturLinear;
        private Button button1;
        private TextBox FFDDiff;
        private Label label37;
        private TextBox FEDiff;
        private TextBox FFDSqrDiff;
        private Label label38;
        private TextBox FESqrDiff;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
    }
}
