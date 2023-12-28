namespace Good_Friends_Never_Starve
{
    partial class Restaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurant));
            nameOfRestaurant = new Label();
            programOfRestaurant = new Label();
            costOfDelivery = new Label();
            restaurantImage = new PictureBox();
            decorativePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)restaurantImage).BeginInit();
            SuspendLayout();
            // 
            // nameOfRestaurant
            // 
            nameOfRestaurant.AutoSize = true;
            nameOfRestaurant.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameOfRestaurant.Location = new Point(185, 53);
            nameOfRestaurant.Name = "nameOfRestaurant";
            nameOfRestaurant.Size = new Size(65, 21);
            nameOfRestaurant.TabIndex = 1;
            nameOfRestaurant.Text = "label1";
            nameOfRestaurant.MouseEnter += afisareRestaurant;
            nameOfRestaurant.MouseLeave += afisareRestaurant2;
            // 
            // programOfRestaurant
            // 
            programOfRestaurant.AutoSize = true;
            programOfRestaurant.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            programOfRestaurant.Location = new Point(391, 53);
            programOfRestaurant.Name = "programOfRestaurant";
            programOfRestaurant.Size = new Size(66, 21);
            programOfRestaurant.TabIndex = 2;
            programOfRestaurant.Text = "label2";
            programOfRestaurant.MouseEnter += afisareRestaurant;
            programOfRestaurant.MouseLeave += afisareRestaurant2;
            // 
            // costOfDelivery
            // 
            costOfDelivery.AutoSize = true;
            costOfDelivery.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            costOfDelivery.Location = new Point(608, 53);
            costOfDelivery.Name = "costOfDelivery";
            costOfDelivery.Size = new Size(66, 21);
            costOfDelivery.TabIndex = 3;
            costOfDelivery.Text = "label3";
            costOfDelivery.MouseEnter += afisareRestaurant;
            costOfDelivery.MouseLeave += afisareRestaurant2;
            // 
            // restaurantImage
            // 
            restaurantImage.AccessibleRole = AccessibleRole.MenuBar;
            restaurantImage.Image = (Image)resources.GetObject("restaurantImage.Image");
            restaurantImage.Location = new Point(31, 21);
            restaurantImage.Name = "restaurantImage";
            restaurantImage.Size = new Size(114, 97);
            restaurantImage.SizeMode = PictureBoxSizeMode.StretchImage;
            restaurantImage.TabIndex = 4;
            restaurantImage.TabStop = false;
            restaurantImage.MouseEnter += afisareRestaurant;
            restaurantImage.MouseLeave += afisareRestaurant2;
            // 
            // decorativePanel
            // 
            decorativePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            decorativePanel.BackColor = Color.Tomato;
            decorativePanel.Location = new Point(1, 139);
            decorativePanel.Name = "decorativePanel";
            decorativePanel.Size = new Size(727, 11);
            decorativePanel.TabIndex = 5;
            decorativePanel.MouseDoubleClick += AfisareProduseRestaurant;
            // 
            // Restaurant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            Controls.Add(decorativePanel);
            Controls.Add(restaurantImage);
            Controls.Add(costOfDelivery);
            Controls.Add(programOfRestaurant);
            Controls.Add(nameOfRestaurant);
            Name = "Restaurant";
            Size = new Size(730, 152);
            MouseDoubleClick += AfisareProduseRestaurant;
            MouseEnter += afisareRestaurant;
            MouseLeave += afisareRestaurant2;
            ((System.ComponentModel.ISupportInitialize)restaurantImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label nameOfRestaurant;
        public Label programOfRestaurant;
        public Label costOfDelivery;
        public PictureBox restaurantImage;
        public Panel decorativePanel;
        public string idUserControl;
        //public Form parentForm;
    }
}
