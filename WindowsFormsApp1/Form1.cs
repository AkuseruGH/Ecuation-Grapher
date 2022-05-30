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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            datosBox.Text = "";

            this.chartA.Series.Clear();
            var seriesAY = chartA.Series.Add("ValorY");
            seriesAY.ChartType = SeriesChartType.Spline;
            seriesAY.XValueType = ChartValueType.Single;
            chartA.Series["ValorY"].Color = Color.Red;

            string ecuacion = ecuacionBox.Text;
            string[] tokens = ecuacion.Split('^');
            double xinicial = -10.0;
            double y;
            for(int i = 1; i<=20; i++)
            {
                y = System.Math.Pow(xinicial, Double.Parse(tokens[1]));
                datosBox.Text = datosBox.Text + "    " + xinicial.ToString() + "    " + y.ToString() + Environment.NewLine;
                xinicial += 1.0;
                this.chartA.Series["ValorY"].Points.AddXY(xinicial, y);
            }
        }
    }
}
