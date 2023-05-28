using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Good_Friends_Never_Starve
{
    public partial class listaDeProduserestaurant : UserControl
    {
        /// <summary>
        /// we declare the a FormRestaurante object , as the father of this , in order to
        /// have acces to father methods essential to the program
        /// </summary>
        public FormRestaurante formTata { get; set; }
        public listaDeProduserestaurant()
        {
            InitializeComponent();

        }
        /// <summary>
        /// A function that just checks wheater the father's Form label5 is newly created
        /// in label 5 we store the list of elements , and so we set it to an empty string.
        /// Father's Label 3's text is set to 0(the label representing the total sum)
        /// 
        /// we also set some controls of the father form to be visble if they are not . 
        /// label 6 representing a label thats just saying 'total'      
        /// formTata.button 1 , the control responsable for adding the elements to the list(important)
        /// <summary>
        /// we check 
        /// </summary>
        private void afisareControls()
        {
            if (formTata.label5.Text == "label5")
            {
                formTata.label5.Text = "";
                formTata.label3.Text = "0";

            }
            if (formTata.label6.Visible == false)
            {
                formTata.label6.Visible = true;
                formTata.button1.Visible = true;
                formTata.label3.Visible = true;
                formTata._button2.Visible = true;
                
            }

        }
        /// <summary>
        /// first we use the afisare comtrol function from upper part of this file . it is required , so that
        /// we set inside  the father form , some controls to be visible , for the user to be able to see
        /// his product list , and the price sum.
        /// when we click on the add to cart button(button1) , the price of the products ,and the products
        /// themselves are saved inside dormTata.label5.text ( label 5 is practicly a list of products)
        /// inside form3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            afisareControls();
            formTata.label5.Text = formTata.label5.Text + this.label1.Text + "     " + this.label2.Text + "\n";
            formTata.mancaruri = formTata.mancaruri + this.label1.Text + '/';
            int value = int.Parse(this.label2.Text);
            int value2 = int.Parse(formTata.label3.Text);
            int valoareToatala = value + value2;
            formTata.label3.Text = valoareToatala.ToString();



        }
    }
}
