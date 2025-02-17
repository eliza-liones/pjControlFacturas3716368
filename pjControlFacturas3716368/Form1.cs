using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjControlFacturas3716368
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int numFactura = int.Parse(txtNumFact.Text);
            DateTime fechaFact = DateTime.Parse(txtFechaFact.Text);
            double montoFact = double.Parse(txtMontoFact.Text);

            Factura objF = new Factura(numFactura, fechaFact, montoFact);

            ListViewItem fila = new ListViewItem(objF.numFacura.ToString());
            fila.SubItems.Add(objF.fechaFact.ToShortDateString());
            fila.SubItems.Add(objF.montoFact.ToString("C"));
            lvFacturas.Items.Add(fila);

            lblTotalFact.Text = objF.totalFacturas().ToString();
            lblTotalSub.Text = objF.calculaTotalSubtotal().ToString("C");
            lblComision.Text = objF.calculaComision().ToString("C");
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = muestraFecha();
        }

        Func<String> muestraFecha = () => DateTime.Now.ToShortDateString();


    }
}
