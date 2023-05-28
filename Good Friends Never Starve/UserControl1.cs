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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        #region Proprieties
        private string numeRes;
        private string programRes;
        private string costLivare;


        [Category("nume restaurant")]
        public string Label1
        {
            get { return numeRes; }
            set { numeRes = value; label1.Text = value; }
        }
        [Category("program restaurant")]
        public string Label2
        {
            get { return programRes; }
            set { programRes = value; label2.Text = value; }
        }
        [Category("costLivrare restaurant")]
        public string Label3
        {
            get { return costLivare; }
            set { costLivare = value; label3.Text = value; }
        }

        [Category("poza restaurant")]
        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox2.Image = value; }
        }
        #endregion
    }

}







