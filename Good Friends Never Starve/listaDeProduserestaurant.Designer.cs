namespace Good_Friends_Never_Starve
{
    partial class listaDeProduserestaurant
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numeProdus = new Label();
            pretProdus = new Label();
            descriereProdus = new Label();
            addToCartButton = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // numeProdus
            // 
            numeProdus.AutoSize = true;
            numeProdus.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            numeProdus.Location = new Point(127, 23);
            numeProdus.Name = "numeProdus";
            numeProdus.Size = new Size(166, 21);
            numeProdus.TabIndex = 0;
            numeProdus.Text = "denumireProdus";
            // 
            // pretProdus
            // 
            pretProdus.AutoSize = true;
            pretProdus.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pretProdus.Location = new Point(326, 23);
            pretProdus.Name = "pretProdus";
            pretProdus.Size = new Size(121, 21);
            pretProdus.TabIndex = 1;
            pretProdus.Text = "pretProdus";
            // 
            // descriereProdus
            // 
            descriereProdus.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            descriereProdus.Location = new Point(477, 23);
            descriereProdus.Name = "descriereProdus";
            descriereProdus.Size = new Size(220, 102);
            descriereProdus.TabIndex = 2;
            descriereProdus.Text = "DescriereProdus";
            // 
            // addToCartButton
            // 
            addToCartButton.BackColor = Color.Transparent;
            addToCartButton.Location = new Point(687, 43);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(115, 48);
            addToCartButton.TabIndex = 3;
            addToCartButton.Text = "Add to cart";
            addToCartButton.UseVisualStyleBackColor = false;
            addToCartButton.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Location = new Point(0, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 10);
            panel1.TabIndex = 4;
            // 
            // listaDeProduserestaurant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            Controls.Add(panel1);
            Controls.Add(addToCartButton);
            Controls.Add(descriereProdus);
            Controls.Add(pretProdus);
            Controls.Add(numeProdus);
            Name = "listaDeProduserestaurant";
            Size = new Size(833, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label numeProdus;
        public Label pretProdus;
        public Label descriereProdus;
        public Button addToCartButton;
        public Panel panel1;
    }
}
