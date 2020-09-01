namespace BestOil
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOil = new System.Windows.Forms.GroupBox();
            this.grpPreTotalLeft = new System.Windows.Forms.GroupBox();
            this.tbSum1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSumOil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbqtyoil = new System.Windows.Forms.TextBox();
            this.radSummOil = new System.Windows.Forms.RadioButton();
            this.radQtyOil = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPriceOil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCafe = new System.Windows.Forms.GroupBox();
            this.tbPriceCola = new System.Windows.Forms.TextBox();
            this.tbPriceCheese = new System.Windows.Forms.TextBox();
            this.tbPriceHum = new System.Windows.Forms.TextBox();
            this.tbPriceHotDog = new System.Windows.Forms.TextBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkHum = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbQtyCola = new System.Windows.Forms.TextBox();
            this.chkHot = new System.Windows.Forms.CheckBox();
            this.tbQtyCheese = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQtyHum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSum2 = new System.Windows.Forms.TextBox();
            this.tbQtyHotDog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpSum = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSumTotal = new System.Windows.Forms.TextBox();
            this.lbTotalDay = new System.Windows.Forms.Label();
            this.grpOil.SuspendLayout();
            this.grpPreTotalLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCafe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOil
            // 
            this.grpOil.Controls.Add(this.grpPreTotalLeft);
            this.grpOil.Controls.Add(this.groupBox1);
            this.grpOil.Controls.Add(this.label3);
            this.grpOil.Controls.Add(this.tbPriceOil);
            this.grpOil.Controls.Add(this.label2);
            this.grpOil.Controls.Add(this.cbOil);
            this.grpOil.Controls.Add(this.label1);
            this.grpOil.Location = new System.Drawing.Point(22, 12);
            this.grpOil.Name = "grpOil";
            this.grpOil.Size = new System.Drawing.Size(282, 303);
            this.grpOil.TabIndex = 0;
            this.grpOil.TabStop = false;
            this.grpOil.Text = "Топливо";
            // 
            // grpPreTotalLeft
            // 
            this.grpPreTotalLeft.Controls.Add(this.tbSum1);
            this.grpPreTotalLeft.Location = new System.Drawing.Point(0, 204);
            this.grpPreTotalLeft.Name = "grpPreTotalLeft";
            this.grpPreTotalLeft.Size = new System.Drawing.Size(282, 100);
            this.grpPreTotalLeft.TabIndex = 6;
            this.grpPreTotalLeft.TabStop = false;
            this.grpPreTotalLeft.Text = "К оплате";
            // 
            // tbSum1
            // 
            this.tbSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbSum1.Location = new System.Drawing.Point(25, 19);
            this.tbSum1.Multiline = true;
            this.tbSum1.Name = "tbSum1";
            this.tbSum1.ReadOnly = true;
            this.tbSum1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSum1.Size = new System.Drawing.Size(241, 62);
            this.tbSum1.TabIndex = 3;
            this.tbSum1.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSumOil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbqtyoil);
            this.groupBox1.Controls.Add(this.radSummOil);
            this.groupBox1.Controls.Add(this.radQtyOil);
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tbSumOil
            // 
            this.tbSumOil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSumOil.Location = new System.Drawing.Point(132, 42);
            this.tbSumOil.Name = "tbSumOil";
            this.tbSumOil.ReadOnly = true;
            this.tbSumOil.Size = new System.Drawing.Size(100, 20);
            this.tbSumOil.TabIndex = 5;
            this.tbSumOil.Text = "0";
            this.tbSumOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSumOil.TextChanged += new System.EventHandler(this.tbSumOil_TextChanged);
            this.tbSumOil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqtyoil_keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "л.";
            // 
            // tbqtyoil
            // 
            this.tbqtyoil.Location = new System.Drawing.Point(132, 19);
            this.tbqtyoil.Name = "tbqtyoil";
            this.tbqtyoil.Size = new System.Drawing.Size(100, 20);
            this.tbqtyoil.TabIndex = 2;
            this.tbqtyoil.Text = "0";
            this.tbqtyoil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbqtyoil.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbqtyoil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqtyoil_keypress);
            // 
            // radSummOil
            // 
            this.radSummOil.AutoSize = true;
            this.radSummOil.Location = new System.Drawing.Point(6, 42);
            this.radSummOil.Name = "radSummOil";
            this.radSummOil.Size = new System.Drawing.Size(59, 17);
            this.radSummOil.TabIndex = 1;
            this.radSummOil.Text = "Сумма";
            this.radSummOil.UseVisualStyleBackColor = true;
            this.radSummOil.CheckedChanged += new System.EventHandler(this.radSumm_CheckedChanged);
            // 
            // radQtyOil
            // 
            this.radQtyOil.AutoSize = true;
            this.radQtyOil.Checked = true;
            this.radQtyOil.Location = new System.Drawing.Point(6, 19);
            this.radQtyOil.Name = "radQtyOil";
            this.radQtyOil.Size = new System.Drawing.Size(84, 17);
            this.radQtyOil.TabIndex = 0;
            this.radQtyOil.TabStop = true;
            this.radQtyOil.Text = "Количество";
            this.radQtyOil.UseVisualStyleBackColor = true;
            this.radQtyOil.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(239, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "руб.";
            // 
            // tbPriceOil
            // 
            this.tbPriceOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPriceOil.Location = new System.Drawing.Point(132, 69);
            this.tbPriceOil.Name = "tbPriceOil";
            this.tbPriceOil.ReadOnly = true;
            this.tbPriceOil.Size = new System.Drawing.Size(100, 26);
            this.tbPriceOil.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            // 
            // cbOil
            // 
            this.cbOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbOil.FormattingEnabled = true;
            this.cbOil.Location = new System.Drawing.Point(132, 26);
            this.cbOil.Name = "cbOil";
            this.cbOil.Size = new System.Drawing.Size(144, 28);
            this.cbOil.TabIndex = 1;
            this.cbOil.SelectedIndexChanged += new System.EventHandler(this.cbOil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид топлива";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpCafe
            // 
            this.grpCafe.Controls.Add(this.tbPriceCola);
            this.grpCafe.Controls.Add(this.tbPriceCheese);
            this.grpCafe.Controls.Add(this.tbPriceHum);
            this.grpCafe.Controls.Add(this.tbPriceHotDog);
            this.grpCafe.Controls.Add(this.chkCola);
            this.grpCafe.Controls.Add(this.label11);
            this.grpCafe.Controls.Add(this.chkCheese);
            this.grpCafe.Controls.Add(this.label10);
            this.grpCafe.Controls.Add(this.chkHum);
            this.grpCafe.Controls.Add(this.label9);
            this.grpCafe.Controls.Add(this.tbQtyCola);
            this.grpCafe.Controls.Add(this.chkHot);
            this.grpCafe.Controls.Add(this.tbQtyCheese);
            this.grpCafe.Controls.Add(this.label8);
            this.grpCafe.Controls.Add(this.tbQtyHum);
            this.grpCafe.Controls.Add(this.groupBox3);
            this.grpCafe.Controls.Add(this.tbQtyHotDog);
            this.grpCafe.Controls.Add(this.label7);
            this.grpCafe.Controls.Add(this.label6);
            this.grpCafe.Location = new System.Drawing.Point(311, 12);
            this.grpCafe.Name = "grpCafe";
            this.grpCafe.Size = new System.Drawing.Size(487, 303);
            this.grpCafe.TabIndex = 1;
            this.grpCafe.TabStop = false;
            this.grpCafe.Text = "Мини-кафе";
            this.grpCafe.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbPriceCola
            // 
            this.tbPriceCola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPriceCola.Location = new System.Drawing.Point(168, 124);
            this.tbPriceCola.Name = "tbPriceCola";
            this.tbPriceCola.ReadOnly = true;
            this.tbPriceCola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPriceCola.Size = new System.Drawing.Size(100, 20);
            this.tbPriceCola.TabIndex = 5;
            // 
            // tbPriceCheese
            // 
            this.tbPriceCheese.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPriceCheese.Location = new System.Drawing.Point(168, 94);
            this.tbPriceCheese.Name = "tbPriceCheese";
            this.tbPriceCheese.ReadOnly = true;
            this.tbPriceCheese.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPriceCheese.Size = new System.Drawing.Size(100, 20);
            this.tbPriceCheese.TabIndex = 5;
            // 
            // tbPriceHum
            // 
            this.tbPriceHum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPriceHum.Location = new System.Drawing.Point(168, 64);
            this.tbPriceHum.Name = "tbPriceHum";
            this.tbPriceHum.ReadOnly = true;
            this.tbPriceHum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPriceHum.Size = new System.Drawing.Size(100, 20);
            this.tbPriceHum.TabIndex = 5;
            // 
            // tbPriceHotDog
            // 
            this.tbPriceHotDog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPriceHotDog.Location = new System.Drawing.Point(168, 34);
            this.tbPriceHotDog.Name = "tbPriceHotDog";
            this.tbPriceHotDog.ReadOnly = true;
            this.tbPriceHotDog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPriceHotDog.Size = new System.Drawing.Size(100, 20);
            this.tbPriceHotDog.TabIndex = 5;
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkCola.Location = new System.Drawing.Point(29, 124);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(105, 24);
            this.chkCola.TabIndex = 7;
            this.chkCola.Text = "Кока-кола";
            this.chkCola.UseVisualStyleBackColor = true;
            this.chkCola.CheckedChanged += new System.EventHandler(this.chkCola_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(274, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "руб.";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkCheese.Location = new System.Drawing.Point(29, 94);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(107, 24);
            this.chkCheese.TabIndex = 7;
            this.chkCheese.Text = "Чизбургер";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(274, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "руб.";
            // 
            // chkHum
            // 
            this.chkHum.AutoSize = true;
            this.chkHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkHum.Location = new System.Drawing.Point(29, 64);
            this.chkHum.Name = "chkHum";
            this.chkHum.Size = new System.Drawing.Size(107, 24);
            this.chkHum.TabIndex = 7;
            this.chkHum.Text = "Гамбургер";
            this.chkHum.UseVisualStyleBackColor = true;
            this.chkHum.CheckedChanged += new System.EventHandler(this.chkHum_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(274, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "руб.";
            // 
            // tbQtyCola
            // 
            this.tbQtyCola.Location = new System.Drawing.Point(314, 124);
            this.tbQtyCola.Name = "tbQtyCola";
            this.tbQtyCola.ReadOnly = true;
            this.tbQtyCola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbQtyCola.Size = new System.Drawing.Size(100, 20);
            this.tbQtyCola.TabIndex = 2;
            this.tbQtyCola.Text = "0";
            this.tbQtyCola.TextChanged += new System.EventHandler(this.tbQtyCola_TextChanged);
            this.tbQtyCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqtyoil_keypress);
            // 
            // chkHot
            // 
            this.chkHot.AutoSize = true;
            this.chkHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkHot.Location = new System.Drawing.Point(29, 34);
            this.chkHot.Name = "chkHot";
            this.chkHot.Size = new System.Drawing.Size(88, 24);
            this.chkHot.TabIndex = 7;
            this.chkHot.Text = "Хот дог";
            this.chkHot.UseVisualStyleBackColor = true;
            this.chkHot.CheckedChanged += new System.EventHandler(this.chkHot_CheckedChanged);
            // 
            // tbQtyCheese
            // 
            this.tbQtyCheese.Location = new System.Drawing.Point(314, 94);
            this.tbQtyCheese.Name = "tbQtyCheese";
            this.tbQtyCheese.ReadOnly = true;
            this.tbQtyCheese.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbQtyCheese.Size = new System.Drawing.Size(100, 20);
            this.tbQtyCheese.TabIndex = 2;
            this.tbQtyCheese.Text = "0";
            this.tbQtyCheese.TextChanged += new System.EventHandler(this.tbQtyCheese_TextChanged);
            this.tbQtyCheese.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqtyoil_keypress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(274, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "руб.";
            // 
            // tbQtyHum
            // 
            this.tbQtyHum.Location = new System.Drawing.Point(314, 64);
            this.tbQtyHum.Name = "tbQtyHum";
            this.tbQtyHum.ReadOnly = true;
            this.tbQtyHum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbQtyHum.Size = new System.Drawing.Size(100, 20);
            this.tbQtyHum.TabIndex = 2;
            this.tbQtyHum.Text = "0";
            this.tbQtyHum.TextChanged += new System.EventHandler(this.tbQtyHum_TextChanged);
            this.tbQtyHum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqtyoil_keypress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSum2);
            this.groupBox3.Location = new System.Drawing.Point(6, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "К оплате";
            // 
            // tbSum2
            // 
            this.tbSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbSum2.Location = new System.Drawing.Point(23, 19);
            this.tbSum2.Multiline = true;
            this.tbSum2.Name = "tbSum2";
            this.tbSum2.ReadOnly = true;
            this.tbSum2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSum2.Size = new System.Drawing.Size(441, 62);
            this.tbSum2.TabIndex = 3;
            this.tbSum2.Text = "0";
            // 
            // tbQtyHotDog
            // 
            this.tbQtyHotDog.Location = new System.Drawing.Point(314, 34);
            this.tbQtyHotDog.Name = "tbQtyHotDog";
            this.tbQtyHotDog.ReadOnly = true;
            this.tbQtyHotDog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbQtyHotDog.Size = new System.Drawing.Size(100, 20);
            this.tbQtyHotDog.TabIndex = 2;
            this.tbQtyHotDog.Text = "0";
            this.tbQtyHotDog.TextChanged += new System.EventHandler(this.tbQtyHotDog_TextChanged);
            this.tbQtyHotDog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqtyoil_keypress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(310, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(220, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // grpSum
            // 
            this.grpSum.Controls.Add(this.lbTotalDay);
            this.grpSum.Controls.Add(this.label12);
            this.grpSum.Controls.Add(this.button1);
            this.grpSum.Controls.Add(this.tbSumTotal);
            this.grpSum.Location = new System.Drawing.Point(22, 313);
            this.grpSum.Name = "grpSum";
            this.grpSum.Size = new System.Drawing.Size(776, 158);
            this.grpSum.TabIndex = 2;
            this.grpSum.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(281, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 44);
            this.label12.TabIndex = 5;
            this.label12.Text = "ИТОГО:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.button1.Location = new System.Drawing.Point(25, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "РАССЧИТАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSumTotal
            // 
            this.tbSumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSumTotal.Location = new System.Drawing.Point(457, 29);
            this.tbSumTotal.Multiline = true;
            this.tbSumTotal.Name = "tbSumTotal";
            this.tbSumTotal.ReadOnly = true;
            this.tbSumTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSumTotal.Size = new System.Drawing.Size(302, 62);
            this.tbSumTotal.TabIndex = 3;
            // 
            // lbTotalDay
            // 
            this.lbTotalDay.AutoSize = true;
            this.lbTotalDay.Location = new System.Drawing.Point(746, 120);
            this.lbTotalDay.Name = "lbTotalDay";
            this.lbTotalDay.Size = new System.Drawing.Size(13, 13);
            this.lbTotalDay.TabIndex = 6;
            this.lbTotalDay.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 498);
            this.Controls.Add(this.grpSum);
            this.Controls.Add(this.grpCafe);
            this.Controls.Add(this.grpOil);
            this.Name = "MainForm";
            this.Text = "Автозаправка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpOil.ResumeLayout(false);
            this.grpOil.PerformLayout();
            this.grpPreTotalLeft.ResumeLayout(false);
            this.grpPreTotalLeft.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCafe.ResumeLayout(false);
            this.grpCafe.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpSum.ResumeLayout(false);
            this.grpSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOil;
        private System.Windows.Forms.GroupBox grpCafe;
        private System.Windows.Forms.GroupBox grpSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPreTotalLeft;
        private System.Windows.Forms.TextBox tbSum1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSumOil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbqtyoil;
        private System.Windows.Forms.RadioButton radSummOil;
        private System.Windows.Forms.RadioButton radQtyOil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPriceOil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOil;
        private System.Windows.Forms.TextBox tbPriceCola;
        private System.Windows.Forms.TextBox tbPriceCheese;
        private System.Windows.Forms.TextBox tbPriceHum;
        private System.Windows.Forms.TextBox tbPriceHotDog;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkHum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbQtyCola;
        private System.Windows.Forms.CheckBox chkHot;
        private System.Windows.Forms.TextBox tbQtyCheese;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQtyHum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSum2;
        private System.Windows.Forms.TextBox tbQtyHotDog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSumTotal;
        private System.Windows.Forms.Label lbTotalDay;
    }
}

