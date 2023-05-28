using DevExpress.CodeParser;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Good_Friends_Never_Starve
{
    public partial class FormRestaurante : Form
    {
        public static string clientId = "";//the clients id
        public static string idMaximActual = "";//the id of the current list if items
        public static string restaurantId = "";//the restaurants id
        public string mancaruri = "";//empty string needed later

        private listaDeProduserestaurant myUserControl = new listaDeProduserestaurant();//products from the restaurant
        private UserControlMap harta = new UserControlMap();//user map , the map required for computing distances
        private CodeGenerator codeGenerator = new CodeGenerator();// the code generator required to generate unique code for each order

        public static string comandaMinima = "0";//minim comanda
        public static string costLivrare = "0";//cost standart de livrare
        public static string livrareStandard = "0";//distanta de livrare 
        public static string livrareExtra = "0";//cost livrare extra
        public static string livrareMaxima = "0";//distanta maxima de livrare
        /// <summary>
        /// 
        /// 
        /// when the go back button is pressed , before finishing the order , the order disapears in
        /// reality , but in database is still added , so when the go back button is pressed ,
        /// this function is called with the current listId as the parameter , and erases the list with
        /// that id
        /// 
        /// 
        /// </summary>
        /// <param name="idDeSters"></param>
        public void deleteLista(string idDeSters)
        {
            if (idDeSters != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
                using (conn)
                {
                    try
                    {
                        conn.Open();
                        string comanda = "delete from ListaProduse where listaId=@primu";
                        using (SqlCommand cmd = new SqlCommand(comanda, conn))
                        {
                            cmd.Parameters.Add("@primu", SqlDbType.Int).Value = idMaximActual;
                            cmd.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// we declare its children ,and specifity to them who their parent is
        /// </summary>
        public FormRestaurante()
        {
            InitializeComponent();
            this.myUserControl.formTata = this;
            this.harta.formTata = this;
            this.codeGenerator.formTata = this;

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
        /// <summary>
        /// when the form is loaded , it is filled with 'Restaurants' , if the restaurant is closed (openClosed)
        /// then we erase some of its attributes ( color , hover mouse functions etc ).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRestaurante_Load(object sender, EventArgs e)
        {
            try
            {
                String comanda = "Select * from Restaurant ";               
                SqlDataAdapter sda2 = new SqlDataAdapter(comanda, conn);
                DataTable tabel2 = new DataTable();
                sda2.Fill(tabel2);
                foreach (DataRow i in tabel2.Rows)
                {
                    UserControl2 restaurantEntitate = new UserControl2();
                    restaurantEntitate.Width = flowLayoutPanel1.Width * 2;
                    restaurantEntitate.panel1.Width = flowLayoutPanel1.Width * 2;
                    restaurantEntitate.label1.Text = i["numeRestaurant"].ToString();
                    restaurantEntitate.label2.Text = i["programIncepere"].ToString().Substring(0, 5) + "-" + i["programInchidere"].ToString().Substring(0, 5);
                    restaurantEntitate.label3.Text = i["pretLivare"].ToString();
                    restaurantEntitate.pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Food For Friends\\Good Friends Never Starve\\Resources\\ricardo.jpg");
                    restaurantEntitate.idRestaurant = i["restaurantId"].ToString();
                    restaurantEntitate.idClient = FormRestaurante.clientId;


                    restaurantEntitate.ComandaMinima = i["comandaMinima"].ToString(); // comanda minima a restaurantului

                    restaurantEntitate.CostLivrare = i["pretLivare"].ToString();
                    restaurantEntitate.LivrareStandard = i["distantaStandart"].ToString();// costul , si distanta standard

                    restaurantEntitate.LivrareMaxima = i["distantaMaxima"].ToString();// distanta maxima acceptata

                    restaurantEntitate.LivrareExtra = i["pretLivrareExtra"].ToString();// pret distanta extra



                    if (UserControl2.openClosed(restaurantEntitate.label2.Text) == false)
                    {
                        restaurantEntitate.dezactivateEvents();
                    }
                    flowLayoutPanel1.Controls.Add(restaurantEntitate);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// when the  user preses the button1 , the program checks if the price order is greater than the minimun,
        /// and if not, he is denied from placing the order until completing it.If the order is valid ,
        /// then we start saving the id's of the foods that were added and we create list entities(
        /// from ListaProduse) , and we save tham in database . At the end , after the list is saved in the database,
        /// we clear the flowlayoutpanel and we add a Map Control element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(FormRestaurante.comandaMinima) > int.Parse(this.label3.Text))
            {
                MessageBox.Show("Minimum order not fullfilled\n" + "Please add more products", "Order too small", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (MessageBox.Show("do u want to proceed with the selected products?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String listaProduseSiPreturi2 = label5.Text;
                String clientId2 = FormRestaurante.clientId;
                String restaurantId2 = FormRestaurante.restaurantId;
                string idUri = "";
                string[] altString = this.mancaruri.Split('/');
                foreach (string i in altString)
                {

                    try
                    {
                        string comanda = "select * from Foods where denumire='" + i + "'";
                        SqlDataAdapter noroc = new SqlDataAdapter(comanda, conn);
                        DataTable idUri2 = new DataTable();
                        noroc.Fill(idUri2);
                        foreach (DataRow row in idUri2.Rows)
                        {
                            idUri = idUri + row["foodId"].ToString() + '/';

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

                Dictionary<string, int> stringCounts = new Dictionary<string, int>();
                idUri = idUri.Substring(0, idUri.Length - 1);
                string[] stringuri = idUri.Split('/');

                foreach (string str in stringuri)
                {

                    if (str == null)
                    {
                        break;
                    }
                    if (stringCounts.ContainsKey(str))
                    {
                        stringCounts[str]++;
                    }
                    else
                    {
                        stringCounts.Add(str, 1);
                    }
                }

                try
                {
                    string idMaximTrecut = "";
                    string idMaximActual = "";
                    string comandaRecuperareUltimId = "Select max(listaId) as idMaxim from ListaProduse";
                    SqlDataAdapter executor = new SqlDataAdapter(comandaRecuperareUltimId, conn);
                    DataTable tabelIdMaxim = new DataTable();
                    executor.Fill(tabelIdMaxim);
                    foreach (DataRow i in tabelIdMaxim.Rows)
                    {
                        if (i["idMaxim"].ToString() == "")
                        {
                            idMaximTrecut = "0";

                        }
                        else
                        {

                            idMaximTrecut = i["idMaxim"].ToString();
                        }

                    }
                    idMaximActual = (int.Parse(idMaximTrecut) + 1).ToString();
                    FormRestaurante.idMaximActual = idMaximActual;
                    foreach (KeyValuePair<string, int> pereche in stringCounts)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
                        using (conn)
                        {
                            try
                            {
                                conn.Open();
                                string comanda = "Insert into ListaProduse values(@una,@doua,@treia)";
                                using (SqlCommand cmd = new SqlCommand(comanda, conn))
                                {
                                    cmd.Parameters.Add("@una", SqlDbType.Int).Value = idMaximActual;
                                    cmd.Parameters.Add("@doua", SqlDbType.Int).Value = pereche.Key;
                                    cmd.Parameters.Add("@treia", SqlDbType.Int).Value = pereche.Value;
                                    int rowsAdded = cmd.ExecuteNonQuery();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR:" + ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }


                }
                catch
                {
                    MessageBox.Show("Am cazut");
                }
                finally
                {
                    conn.Close();
                }
                this.flowLayoutPanel1.Controls.Clear();
                this.label1.Visible = false;
                this.label4.Visible = false;
                this.label2.Visible = false;
                this.button1.Visible = false;
                UserControlMap harta = new UserControlMap();
                harta.formTata = this;
                harta.Width = flowLayoutPanel1.Width - 8;
                harta.Height = flowLayoutPanel1.Height - 8;
                this.flowLayoutPanel1.Controls.Add(harta);



            }
            else
            {
                this.label5.Text = "";
                this.label3.Visible = false;
                this.label6.Visible = false;
                this.button1.Visible = false;
                this.button2.Visible = false;

            }

        }
        /// <summary>
        /// Buuton for going back . If pressed  Form restaurant goes back to default , 
        /// and if items were added to the database they are destroyed .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really wanna go back ?\n" + "The items from your list will be removed", "Go back to restaurants", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                deleteLista(FormRestaurante.idMaximActual);
                
                UserControlMap.x = 0;
                FormRestaurante.comandaMinima = "0";
                FormRestaurante.livrareStandard = "0";
                FormRestaurante.costLivrare = "0";
                FormRestaurante.livrareExtra = "0";
                FormRestaurante.livrareMaxima = "0";
                this.Close();
            }
        }
        /// <summary>
        /// When the go button is pressed , we search in our 
        /// database the order matching the code . if one is found , the detaials and status of the order
        /// are printed via a message box . if not , the user is informed via another message box , that the code
        /// is wrong
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string codUnic = this.textBox1.Text;
            string statusComanda = "";
            string numeClient = "";
            string pretFactura = "";
            String[] stringuri = codUnic.Split('/');
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
            try
            {
                conn.Open();
                string comanda = "select f.pret,u.nume,fo.denumire,l.cantitate from Factura f " +
                    "join Users u on f.userId=u.idUser " +
                    "join ListaProduse l on l.listaId=f.listaId " +
                    "join Foods fo on l.foodId=fo.foodId " +
                    "where l.listaId='" + stringuri[2] + "'";
                SqlDataAdapter sda = new SqlDataAdapter(comanda, conn);
                DataTable tabel = new DataTable();
                sda.Fill(tabel);
                if(tabel.Rows.Count == 0) 
                {
                    MessageBox.Show("No order with this code");
                    return;                        
                }
                foreach(DataRow i in tabel.Rows)
                {
                    statusComanda = statusComanda + i["cantitate"].ToString()  + " X " + i["denumire"].ToString() + "\n";
                    numeClient = i["nume"].ToString();
                    pretFactura = i["pret"].ToString();
                }
                MessageBox.Show("Hello ,"+numeClient + " your order of \n" + statusComanda + "is on the way.Total pricing: " + pretFactura,"Order status",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}




