using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using DevExpress.CodeParser;
using DevExpress.Map.Native;
using DevExpress.XtraMap;

namespace Good_Friends_Never_Starve
{
    /// <summary>
    /// An essential part of the program , UserControlMap is needed to display the route 
    /// needed by the delivery company to complete in order to fullfil the order , and
    /// to compute the distance from the client to the restaurant
    /// </summary>
    public partial class UserControlMap : UserControl
    {
        /// <summary>
        /// we once again declare a formRestaurante object to be the father of this
        /// </summary>
        public FormRestaurante formTata { get; set; }

        /// <summary>
        /// bing key , required for the Bing api for connection.Whithout it , 
        /// the program wouldn't get any responses
        /// from bing , and so there wouldnt be no map
        /// </summary>
        string bingKey = "Aj4Cr79BAoa2NQ5BIxcYkomY-wjQL2-Ahif79rtnGV0y7O6k-vEw7Efz49_8ZBsf";
        string adresaLivrare, adresaRestaurant = "";
        public static int x = 0;     
        public UserControlMap()
        {
            InitializeComponent();

        }
        /// <summary>
        /// The most important function from this class ,AddWaypoint .
        /// we set the label 4 to visbile(in label 4 were print the total sum of the order
        /// we declare the bing bing , and erase the old layer . This is needeed because if a client chooses
        /// an adress and then decides to change it , the map would print both the adresses , which is wrong
        /// We add layers to our user control objects ( image -representing the map , and info - representing
        /// the adresses). We chose the adress found at the current reastaurant ( for the restaurant) and we c
        /// compute the adress of the client using the data provided by him inside the texxtBox. We then
        /// add these adressed as waiponints inside a list, erase the old ones , and using the provider (Bing routeDataProvider
        /// object) we compute the image of the route between the waipoints(adresses) , and the distance between then
        /// by adding the provider the methods(OnRouteCalculated - for computing distance , androuteLayerItemGenerating
        /// for generating the image map)
        /// 
        ///
        /// </summary>
        public void addWaypoint()
        {

            label4.Visible = true;
            try
            {

                BingRouteDataProvider provider = new BingRouteDataProvider
                {
                    BingKey = bingKey
                };                
                if (mapControl1.Layers.Count > 0)
                {
                    mapControl1.Layers.RemoveAt(x);
                    x++;
                }             
                mapControl1.Layers.Add(new InformationLayer
                {
                    DataProvider = provider
                });
                mapControl1.Layers.Add(new ImageLayer()
                {
                    DataProvider = new BingMapDataProvider()
                    {
                        BingKey = bingKey
                    }
                });
                provider.RouteCalculated += OnRouteCalculated;
                List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
                adresaLivrare = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
                try
                {
                    string comanda = "Select adresaRestaurant from Restaurant where restaurantId='" + FormRestaurante.restaurantId + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(comanda, conn);
                    DataTable tabelAdresa = new DataTable();
                    sda.Fill(tabelAdresa);
                    foreach (DataRow i in tabelAdresa.Rows)
                    {

                        adresaRestaurant = i["adresaRestaurant"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                waypoints.Add(new RouteWaypoint("Restaurant Adress", adresaRestaurant));
                waypoints.Add(new RouteWaypoint("Delivery Adress", adresaLivrare));
                if (waypoints.Count > 2)
                {
                    waypoints.RemoveAt(1);
                    waypoints.RemoveAt(1);
                }
                provider.CalculateRoute(waypoints);
                provider.LayerItemsGenerating += routeLayerItemGenerating;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// A function required for computing the distance between the client and the restaurant
        /// we indirectly declare the size of the map , by creating the two geoPoints topleft , bottomRight
        /// and then with the help of the bing Api , we compute the distance between the waipoints
        /// and we modify 'this' with the afisareFactura method at the end . 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e)
        {
            SearchBoundingBox box = e.CalculationResult.RouteResults[0].BoundingBox;
            GeoPoint topleft = new GeoPoint
            {
                Latitude = box.NorthLatitude,
                Longitude = box.WestLongitude
            };
            GeoPoint bottomRight = new GeoPoint
            {
                Latitude = box.SouthLatitude,
                Longitude = box.EastLongitude
            };
            mapControl1.ZoomToRegion(topleft, bottomRight, 0.4);
            RouteCalculationResult result = e.CalculationResult;
            if ((result.ResultCode != null) & (result.ResultCode == RequestResultCode.Success))
            {
                for (int rnum = 0; rnum < e.CalculationResult.RouteResults.Count; rnum++)
                {
                    if (e.CalculationResult.RouteResults[rnum].Legs != null)
                    {

                        foreach (BingRouteLeg leg in e.CalculationResult.RouteResults[rnum].Legs)
                        {
                            label16.Text = (leg.Distance * 1.6).ToString("0.00") + "km";
                            afisareFactura();
                        }

                    }
                }

            }
        }
        /// <summary>
        /// Function required for drawing the route on the map . We draw a line passing trogh 
        /// all our point , creating a route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void routeLayerItemGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            if (e.Cancelled || (e.Error != null))
                return;
            foreach (MapItem item in e.Items)
            {
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null)
                {
                    polyline.Stroke = System.Drawing.Color.DarkRed;
                    polyline.StrokeWidth = 4;
                }
            }
        }
        /// <summary>
        /// The purpose of this function is to print the distace of the route, and to compute
        /// the full price of the order for the client . If the distance<maximum && distance>standard
        /// (distance delivery) then extra fee is applied . If the distance > maximum , the user is alerted
        /// , and message box is printed , telling him that the distance is too big and the order
        /// cannot be fulfilled . If the distance is lower than standard delivey , no extra fee is applied
        /// </summary>
        public void afisareFactura()
        {

            this.label8.Text = FormRestaurante.costLivrare;

            if (double.Parse(this.label16.Text.Substring(0, (this.label16.Text.Length - 2))) > double.Parse(FormRestaurante.livrareStandard) && double.Parse(this.label16.Text.Substring(0, (this.label16.Text.Length - 2))) < int.Parse(FormRestaurante.livrareMaxima))
            {
                this.label9.Text = FormRestaurante.livrareExtra;
            }
            else if (double.Parse(this.label16.Text.Substring(0, (this.label16.Text.Length - 2))) > int.Parse(FormRestaurante.livrareMaxima))
            {
                MessageBox.Show("Your order exceeds the maximum distance\n" + "Please change the adress , or select another restaurant", "Location too far", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.panel3.Visible = false;
                return;
            }
            this.label10.Text = formTata.label3.Text;
            this.label12.Text = (double.Parse(FormRestaurante.costLivrare) + double.Parse(this.label9.Text) + double.Parse(formTata.label3.Text)).ToString();
            this.label15.Text = FormRestaurante.livrareMaxima;
            this.panel3.Visible = true;

        }
        /// <summary>
        /// button 1 in our case is the buuton that gets the info from the textbox(representing the clients adress)
        /// , and adds an waipoint to the MapControl Control (representing the clients adress)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            addWaypoint();
        }
        /// <summary>
        /// This is one of the last stepts of the program . The button 2 transforms the father form ,
        /// and adds the data (of the transaction : clientId , restaurantId , listaId , pret ..) inside the factura
        /// table . this table represents the past orders of the clients. After that , the UserControlMAp is 
        /// erased from the fathertForm flowLayoutForm , and a CodeGenerator User control is added instead
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.formTata.label3.Visible = false;
            this.formTata.label6.Visible = false;
            this.formTata.label7.Visible = false;
            this.formTata.label8.Visible = false;
            Panel factura = this.panel3 as Panel;
            factura.Width = formTata.flowLayoutPanel1.Width - 8;
            factura.Height = formTata.flowLayoutPanel1.Height - 8;
            this.formTata.flowLayoutPanel1.Controls.Clear();
            this.formTata._button2.Visible = false;          
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
            using (conn)
            {
                try
                {

                    conn.Open();
                    string comanda = "insert into Factura values(@primu,@doilea,@treilea,@patrulea,@cincilea)";
                    using (SqlCommand cmd = new SqlCommand(comanda, conn))
                    {
                        cmd.Parameters.Add("@primu", SqlDbType.Int).Value = FormRestaurante.clientId;
                        cmd.Parameters.Add("@doilea", SqlDbType.Int).Value = FormRestaurante.restaurantId;
                        cmd.Parameters.Add("@treilea", SqlDbType.Int).Value = FormRestaurante.idMaximActual;
                        cmd.Parameters.Add("@patrulea", SqlDbType.Int).Value = this.label12.Text;
                        cmd.Parameters.Add("@cincilea", SqlDbType.Int).Value = 0;
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            CodeGenerator generator = new CodeGenerator();
            generator.formTata = this.formTata;
            this.formTata.flowLayoutPanel1.Controls.Add(generator);

        }
    }
}
