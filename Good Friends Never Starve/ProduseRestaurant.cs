using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Friends_Never_Starve
{
    public partial class ProduseRestaurant : Form
    {
        public string ourRestaurantId;
        public ProduseRestaurant()
        {
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
        private void ProduseRestaurant_Load(object sender, EventArgs e)
        {
            try
            {
                String comanda = "Select * from Restaurant where id=" + "'ourRestaurantId'";
                //MessageBox.Show(comanda);
                System.Data.SqlClient.SqlDataAdapter sda3 = new System.Data.SqlClient.SqlDataAdapter(comanda, conn);
                DataTable tabel2 = new DataTable();
                sda3.Fill(tabel2);
                foreach (DataRow i in tabel2.Rows)
                {
                    listaDeProduserestaurant produsNou = new listaDeProduserestaurant();
                    //produsNou.label1=
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
