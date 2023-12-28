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
{/// <summary>
/// this class , of user Control type represents a restaurant. There are some mistakes here 
/// some duplicate data , and some wrong one because at first i didnt really knew how to work with it .
/// it was a bit later i understodood how geters and setters work in c# , and how i could set the form
/// as the parent object . In spite of all this , the class work just fine . I woulve corrected some of this,
/// but time was relly not by my side , being in pressesion and all that .
/// </summary>
    public partial class Restaurant : UserControl

    {
        private string idClient = "0";
        private string comandaMinima = "0";//minim comanda
        private string costLivrare = "0";//cost standart de livrare
        private string livrareStandard = "0";//distanta de livrare 
        private string livrareExtra = "0";//cost livrare extra
        private string livrareMaxima = "0";//distanta maxima de livrare
        private string idRestaurant = "0";

        #region geters and setters for the info's about the chosen restaurant
        public string _idRestaurant
        {
            get { return idRestaurant; }
            set { idRestaurant = value; }
        }

        public string _idClient
        {
            get { return idClient; }
            set { idClient = value; }
        }
        public string LivrareExtra
        {
            get { return livrareExtra; }
            set { livrareExtra = value; }
        }
        public string ComandaMinima
        {
            get { return comandaMinima; }
            set { comandaMinima = value; }
        }
        public string CostLivrare
        {
            get { return costLivrare; }
            set { costLivrare = value; }
        }
        public string LivrareStandard
        {
            get { return livrareStandard; }
            set { livrareStandard = value; }
        }
        public string LivrareMaxima
        {
            get { return livrareMaxima; }
            set { livrareMaxima = value; }
        }
        #endregion
        /// <summary>
        /// This function checks wheter the restaurant is open or closed by getting the work hors of the
        /// restuarant in a "hh:mm-hh:mm" string format h-hour , m-minute . When the program is overnigh
        /// like 16:00-04:00 , and the actual time is 01 in the night , the program checks the dates actualTime
        /// and end time with 24 hours more , to add for the day change 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Boolean openClosed(String a)
        {
            string startTimeS = a.Substring(0, 5);
            string endTimeS = a.Substring(6, 5);
            string oraActualaS = DateTime.Now.ToString();
            DateTime startTime = DateTime.Parse(startTimeS, System.Globalization.CultureInfo.CurrentCulture);
            DateTime endTime = DateTime.Parse(endTimeS, System.Globalization.CultureInfo.CurrentCulture);
            DateTime actualTime = DateTime.Parse(oraActualaS, System.Globalization.CultureInfo.CurrentCulture);

            if (endTime < startTime)
            {
                if (actualTime > startTime)
                    return true;
                else
                    if (actualTime.AddHours(24) > startTime && actualTime < endTime)
                {
                    return true;
                }
                return false;

            }
            else
            {
                if (actualTime <= endTime && actualTime >= startTime)
                {
                    return true;
                }
                return false;
            }

        }
        public Restaurant()
        {
            InitializeComponent();

        }


        /*
        public string idRestaurant;
        
        private string _numeRes;
        private string _programRes;
        private string _costDeliver;
        private Image _imagineRes;
        */
        /// <summary>
        /// When a retaurant is closed , it becomes 'inactive' . Changing its collor to gray , and removing 
        /// Some mouse methods . The click method remains .
        /// </summary>
        public void dezactivateEvents()
        {
            this.BackColor = Color.Gray;
            this.MouseEnter -= this.afisareRestaurant;
            this.MouseLeave -= this.afisareRestaurant2;
            this.nameOfRestaurant.MouseEnter -= this.afisareRestaurant;
            this.nameOfRestaurant.MouseLeave -= this.afisareRestaurant2;
            this.programOfRestaurant.MouseEnter -= this.afisareRestaurant;
            this.programOfRestaurant.MouseLeave -= this.afisareRestaurant2;
            this.costOfDelivery.MouseEnter -= this.afisareRestaurant;
            this.costOfDelivery.MouseLeave -= this.afisareRestaurant2;
            this.restaurantImage.MouseEnter -= this.afisareRestaurant;
            this.restaurantImage.MouseLeave -= this.afisareRestaurant2;
        }


        /// <summary>
        /// functions for better , more fluent UI ( afisareRestaurant , afisareRestaurant 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void afisareRestaurant(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }
        public void afisareRestaurant2(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSalmon;
        }
        /// <summary>
        /// The most relevant function of the User Control class, when clicked on(UserControl2 object)
        /// if the actual time is inside the work hours program of the restaurant , A new form(form3) is created ,
        /// and , inside it 'listaDeProduserestaurant' objects are added representing the products (from the 
        /// database) of the selected restaurant. We save some attributes that we need from the UserControl2 object
        /// as static members(for better manuvrability) to the newly created form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfisareProduseRestaurant(object sender, MouseEventArgs e)
        {
            if (openClosed(this.programOfRestaurant.Text) == false)
            {
                MessageBox.Show("Restaurant is currently closed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormRestaurante form3 = new FormRestaurante();
                form3._comandaMinima = this.ComandaMinima;
                form3._costLivrare = this.CostLivrare;
                form3._livrareStandard = this.LivrareStandard;
                form3._livrareMaxima = this.LivrareMaxima;
                form3._livrareExtra = this.LivrareExtra;
                form3._restaurantId = this.idRestaurant;
                form3._clientId = idClient;

                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
                String comanda = "Select * from PreturiRestaurante p join Foods f on p.foodId=f.foodId where restaurantId='" + this.idRestaurant + "'";
                System.Data.SqlClient.SqlDataAdapter sda3 = new System.Data.SqlClient.SqlDataAdapter(comanda, conn);
                DataTable tabel = new DataTable();
                sda3.Fill(tabel);
                form3._minimuRequOrder.Text = "Minimum order: " + this.comandaMinima.ToString();
                form3._minimuRequOrder.Visible = true;
                form3._priceOfStandardDelivery.Text = "Standard delivery: " + this.livrareStandard.ToString();
                form3._priceOfStandardDelivery.Visible = true;
                form3.Show();
                form3._uniqueCodeSearchBar.Visible = false;
                form3._uniqueOrderCodeLabel.Visible = false;
                form3._searchByUniqueCodeButton.Visible = false;
                form3._flowLayoutPanel1.Controls.Clear();
                foreach (DataRow i in tabel.Rows)
                {

                    listaDeProduserestaurant a = new listaDeProduserestaurant();

                    a.pretProdus.Text = i["pret"].ToString();
                    a.descriereProdus.Text = i["descriere"].ToString();
                    a.numeProdus.Text = i["denumire"].ToString();
                    a.Width = form3._flowLayoutPanel1.Width * 2;
                    a.panel1.Width = form3._flowLayoutPanel1.Width * 2;
                    a.formTata = form3;
                    form3._flowLayoutPanel1.Controls.Add(a);


                }
                form3._labelNumeRes.Text = "Nume Produs";
                form3._labelProgramRes.Text = "Pret";
                form3._labelTaxaLivrareRes.Text = "Descriere";
                form3._clientOrderLabel.Text = "";

            }


        }

    }


}
