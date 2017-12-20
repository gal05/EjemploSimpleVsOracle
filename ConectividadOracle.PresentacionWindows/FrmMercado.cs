using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectividadOracle.PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






    private void ListarMercados()
        {
            List<MERCADOS> Lista;
            using (Entities DB = new Entities())
            {
                //List<MERCADOS> Lista = DB.MERCADOS.ToList();
                 Lista = (from x in DB.MERCADOS select x).ToList();
            }
            DgvMercado.DataSource = Lista;
        }
    private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarMercados();
        }




        private void DgvMercado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
