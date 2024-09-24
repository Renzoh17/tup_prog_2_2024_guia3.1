using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            FResultados vtnR = new FResultados();
            Evaluador ev = null;
            Moto m = new Moto(tbMarca.Text, (int)nudModelo.Value, Convert.ToDouble(tbValorFabr.Text));
            if (rbLineal.Checked)
            {
                ev = new EvaluadorLineal(m, (int)nudAñoACalc.Value, Convert.ToInt32(tbVidaUtil.Text));
            }
            if (rbAnual.Checked)
            {
                ev = new EvaluadorAnual(m, (int)nudAñoACalc.Value, Convert.ToDouble(tbTasaDepreciacion.Text));
            }
            vtnR.tbResultados.Text = ev.VerDescripcion();
            vtnR.ShowDialog();
            vtnR.Dispose();
            tbMarca.Clear();
            nudModelo.Value = nudModelo.Minimum;
            tbValorFabr.Clear();
            nudAñoACalc.Value = nudAñoACalc.Minimum;
            tbTasaDepreciacion.Clear();
            tbVidaUtil.Clear();
        }
    }
}
