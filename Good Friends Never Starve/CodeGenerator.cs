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
    public partial class CodeGenerator : UserControl
    {
        public FormRestaurante formTata { get; set; }
        public CodeGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// when clicked , the code is generated and made visible . Also , the close/go
        /// back buttonappears
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateCode_Click(object sender, EventArgs e)
        {
            this.checkStatusOrderButton.Visible = true;
            this.label2.Visible = true;
            this.codeTextBox.Visible = true;
            String codUnic = formTata._clientId + "/" + formTata._restaurantId + "/" + formTata._IdMaximActual;
            this.codeTextBox.Text = codUnic;
        }
        /// <summary>
        /// 
        /// Go back button , in our case , 'go to restaurants button' 
        /// 
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.formTata.Close();
        }
    }
}
