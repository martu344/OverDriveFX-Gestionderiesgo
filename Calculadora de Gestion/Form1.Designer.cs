using System.Drawing;
using System.Windows.Forms;

namespace Calculadora_de_Gestion
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
            this.lblstoploss = new System.Windows.Forms.Label();
            this.lblForex = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcapital = new System.Windows.Forms.Label();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtStoploss = new System.Windows.Forms.TextBox();
            this.txtTakeProfit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.txtPerdida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblstoploss
            // 
            this.lblstoploss.Location = new System.Drawing.Point(24, 102);
            this.lblstoploss.Name = "lblstoploss";
            this.lblstoploss.Size = new System.Drawing.Size(63, 23);
            this.lblstoploss.TabIndex = 0;
            this.lblstoploss.Text = "Stoploss : ";
            // 
            // lblForex
            // 
            this.lblForex.Location = new System.Drawing.Point(243, 11);
            this.lblForex.Name = "lblForex";
            this.lblForex.Size = new System.Drawing.Size(47, 23);
            this.lblForex.TabIndex = 0;
            this.lblForex.Text = "Forex : ";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(99, 54);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(52, 23);
            this.txtCapital.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(99, 191);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(72, 23);
            this.txtResultado.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(183, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblcapital
            // 
            this.lblcapital.Location = new System.Drawing.Point(24, 54);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(51, 23);
            this.lblcapital.TabIndex = 0;
            this.lblcapital.Text = "Capital :";
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.Location = new System.Drawing.Point(243, 110);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(63, 18);
            this.lblporcentaje.TabIndex = 0;
            this.lblporcentaje.Text = "Riesgo % :";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(314, 107);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(52, 23);
            this.txtPorcentaje.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EUR/USD",
            "EUR/AUD"});
            this.comboBox1.Location = new System.Drawing.Point(301, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtStoploss
            // 
            this.txtStoploss.Location = new System.Drawing.Point(99, 102);
            this.txtStoploss.Name = "txtStoploss";
            this.txtStoploss.Size = new System.Drawing.Size(52, 23);
            this.txtStoploss.TabIndex = 5;
            // 
            // txtTakeProfit
            // 
            this.txtTakeProfit.Location = new System.Drawing.Point(312, 196);
            this.txtTakeProfit.Name = "txtTakeProfit";
            this.txtTakeProfit.Size = new System.Drawing.Size(72, 23);
            this.txtTakeProfit.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TakeProfit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lote :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Factor RR :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1/2",
            "1/3"});
            this.comboBox2.Location = new System.Drawing.Point(314, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 23);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(99, 247);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(72, 23);
            this.txtGanancia.TabIndex = 11;
            // 
            // txtPerdida
            // 
            this.txtPerdida.Location = new System.Drawing.Point(312, 247);
            this.txtPerdida.Name = "txtPerdida";
            this.txtPerdida.Size = new System.Drawing.Size(72, 23);
            this.txtPerdida.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ganancia :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Perdida :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "OverDriveFX";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(160, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By Bottaro Martin";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AccessibleName = "Gestion OverDriveFX";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(413, 322);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPerdida);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTakeProfit);
            this.Controls.Add(this.lblForex);
            this.Controls.Add(this.lblstoploss);
            this.Controls.Add(this.txtStoploss);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblcapital);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCapital);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.Text = "Gestion OverDriveFX";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private LinkLabel linkLabel1;
    }
}

