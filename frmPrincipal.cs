using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winHamburguesa.Clases;

namespace winHamburguesa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        OrdenCompra ordenCompra;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            OrdenFactory ordenFactory = new OrdenFactory();
            ordenCompra = ordenFactory.CrearOrden(ckbCebolla.Checked, ckbTocineta.Checked, ckbPepinillo.Checked);
            
            this.txtTotal.Text = ordenCompra.CalcularTotal().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {                
                if (ordenCompra != null)
                {
                    saveFileDialog1.Filter = "Solo XML | *.xml";
                    DialogResult resultado = saveFileDialog1.ShowDialog();
                    if (resultado == System.Windows.Forms.DialogResult.OK)
                    {
                        string ruta = saveFileDialog1.FileName;
                        ordenCompra.Guardar(ruta);
                        //MostrarOrden(ruta);

                        ruta = ordenCompra.TransformXMLToHTML(ruta);
                        webBrowser1.Url = new Uri(Application.StartupPath +"\\"+ ruta); 
                    }                    
                }
                else
                {
                    MessageBox.Show("Primero debe crear la orden de compra", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarOrden(string ruta)
        {           
            webBrowser1.Url = new Uri(ruta);            

            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.Arguments = ruta;
            info.FileName = "iexplore.exe";
            proceso.StartInfo = info;
            proceso.Start();
         }

        
    }
}
