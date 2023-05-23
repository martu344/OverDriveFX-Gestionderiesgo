namespace lote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblstoploss = new Label();
            lblForex = new Label();
            txtCapital = new TextBox();
            txtResultado = new TextBox();
            button1 = new Button();
            lblcapital = new Label();
            lblporcentaje = new Label();
            txtPorcentaje = new TextBox();
            comboBox1 = new ComboBox();
            txtStoploss = new TextBox();
            txtTakeProfit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            txtGanancia = new TextBox();
            txtPerdida = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblstoploss
            // 
            lblstoploss.Location = new Point(24, 102);
            lblstoploss.Name = "lblstoploss";
            lblstoploss.Size = new Size(63, 23);
            lblstoploss.TabIndex = 0;
            lblstoploss.Text = "Stoploss : ";
            // 
            // lblForex
            // 
            lblForex.Location = new Point(232, 12);
            lblForex.Name = "lblForex";
            lblForex.Size = new Size(47, 23);
            lblForex.TabIndex = 0;
            lblForex.Text = "Forex : ";
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(99, 54);
            txtCapital.Name = "txtCapital";
            txtCapital.PlaceholderText = "Capital";
            txtCapital.Size = new Size(52, 23);
            txtCapital.TabIndex = 0;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(99, 191);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(52, 23);
            txtResultado.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.GhostWhite;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(183, 146);
            button1.Name = "button1";
            button1.Size = new Size(62, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // lblcapital
            // 
            lblcapital.Location = new Point(24, 54);
            lblcapital.Name = "lblcapital";
            lblcapital.Size = new Size(51, 23);
            lblcapital.TabIndex = 0;
            lblcapital.Text = "Capital :";
            // 
            // lblporcentaje
            // 
            lblporcentaje.Location = new Point(243, 110);
            lblporcentaje.Name = "lblporcentaje";
            lblporcentaje.Size = new Size(63, 18);
            lblporcentaje.TabIndex = 0;
            lblporcentaje.Text = "Riesgo % :";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(314, 107);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.PlaceholderText = "Porc. %";
            txtPorcentaje.Size = new Size(52, 23);
            txtPorcentaje.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DarkViolet;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EUR/USD", "EUR/AUD" });
            comboBox1.Location = new Point(301, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(76, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtStoploss
            // 
            txtStoploss.Location = new Point(99, 102);
            txtStoploss.Name = "txtStoploss";
            txtStoploss.PlaceholderText = "StopLoss";
            txtStoploss.Size = new Size(52, 23);
            txtStoploss.TabIndex = 5;
            // 
            // txtTakeProfit
            // 
            txtTakeProfit.Location = new Point(314, 196);
            txtTakeProfit.Name = "txtTakeProfit";
            txtTakeProfit.Size = new Size(52, 23);
            txtTakeProfit.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 199);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "TakeProfit :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 199);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Lote :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 54);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Factor RR :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1/2", "1/3" });
            comboBox2.Location = new Point(314, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(52, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(99, 247);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(51, 23);
            txtGanancia.TabIndex = 11;
            // 
            // txtPerdida
            // 
            txtPerdida.Location = new Point(314, 247);
            txtPerdida.Name = "txtPerdida";
            txtPerdida.Size = new Size(52, 23);
            txtPerdida.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 247);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 13;
            label4.Text = "Ganancia :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 247);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 14;
            label5.Text = "Perdida :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(35, 9);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 15;
            label6.Text = "OverDriveFX";
            // 
            // Form1
            // 
            AccessibleName = "Gestion OverDriveFX";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(413, 309);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPerdida);
            Controls.Add(txtGanancia);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTakeProfit);
            Controls.Add(lblForex);
            Controls.Add(lblstoploss);
            Controls.Add(txtStoploss);
            Controls.Add(comboBox1);
            Controls.Add(txtPorcentaje);
            Controls.Add(lblcapital);
            Controls.Add(lblporcentaje);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Controls.Add(txtCapital);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Gestion OverDriveFX";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblForex;
        private Label lblstoploss;
        private TextBox txtCapital;
        private TextBox txtResultado;
        private Button button1;
        private Label lblcapital;
        private TextBox txtPorcentaje;
        private Label lblporcentaje;
        private ComboBox comboBox1;
        private TextBox txtStoploss;
        private TextBox txtTakeProfit;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private TextBox txtGanancia;
        private TextBox txtPerdida;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}