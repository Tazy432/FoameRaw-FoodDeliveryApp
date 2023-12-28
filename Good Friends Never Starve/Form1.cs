using System.Data;
using System.Data.SqlClient;

namespace Good_Friends_Never_Starve
{
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FTIQA47\MSSQLSERVER11;Initial Catalog=""Baza de date food app"";Integrated Security=True");
        /// <summary>
        /// 
        /// label's 1 and 2's backcolour is set to transparent , and their parent is the pictureBox.
        /// By doing this we create labels without that boring white background of default labels
        /// ,instead we 'integrate'
        /// the labels inside the image
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            usernameLabel.Parent = backgroundImage;
            passwordLabel.Parent = backgroundImage;
            usernameLabel.BackColor = Color.Transparent;
            passwordLabel.BackColor = Color.Transparent;
        }
        /// <summary>
        /// 
        /// button 1 -log in button
        /// when the button is pressed , the program searches inside the database (Users table)
        /// for a record whose 'name' and 'password' is equal to credentials given by the user 
        /// inside the textBox.If no such record exist , en error messageBox is displayed , and the 
        /// textboxes are cleared of content
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string username1 = usernameTextBox.Text;
            string parola1 = passwordTextBox.Text;
            try
            {
                String comanda = "Select * from Users where nume= '" + username1 + "' And parola='" + parola1 + "'";
                SqlDataAdapter sda = new SqlDataAdapter(comanda, conn);
                DataTable tabel = new DataTable();
                sda.Fill(tabel);
                if (tabel.Rows.Count > 0)
                {


                    this.Hide();
                    FormRestaurante form2 = new FormRestaurante();
                    form2._clientOrderLabel.Text = "It's good to see you , \n" + "       " + username1;
                    foreach (DataRow i in tabel.Rows)
                    {
                        form2._clientId = i["idUser"].ToString();
                        break;
                    }
                    form2.Show();


                }
                else
                {
                    MessageBox.Show("Invalid combination of credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
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
    }
}