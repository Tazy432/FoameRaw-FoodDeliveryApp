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
            if (formTata._clientOrderLabel.Text == "label5")
            {
                formTata._clientOrderLabel.Text = "";
                formTata._total.Text = "0";

            }
            if (formTata._labelTotal.Visible == false)
            {
                formTata._labelTotal.Visible = true;
                formTata._button1.Visible = true;
                formTata._total.Visible = true;
                formTata._goBackButton.Visible = true;

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
            formTata._clientOrderLabel.Text = formTata._clientOrderLabel.Text + this.numeProdus.Text + "     " + this.pretProdus.Text + "\n";
            formTata._mancaruri = formTata._mancaruri + this.numeProdus.Text + '/';
            int value = int.Parse(this.pretProdus.Text);
            int value2 = int.Parse(formTata._total.Text);
            int valoareToatala = value + value2;
            formTata._total.Text = valoareToatala.ToString();



        }
    }
}
