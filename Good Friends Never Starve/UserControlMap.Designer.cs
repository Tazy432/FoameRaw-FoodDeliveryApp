namespace Good_Friends_Never_Starve
{
    partial class UserControlMap
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
            confirmDeliveryAdressPanel = new Panel();
            distanceDelivery = new Label();
            maxDistanceDelivery = new Label();
            distanceDeliveryLabel = new Label();
            maxDeliveryDistanceLabel = new Label();
            confirmOrderPanel = new Panel();
            confirmOrderButton = new Button();
            totalPrice = new Label();
            deliveryPriceLabel = new Label();
            productsPrice = new Label();
            totalPriceLabel = new Label();
            extraDeliveryPrice = new Label();
            extraDeliveryPriceLabel = new Label();
            deliveryPrice = new Label();
            productsPriceLabel = new Label();
            confirmDeliverAdressButton = new Button();
            nrTextBox = new TextBox();
            streetTextBox = new TextBox();
            cityTextBox = new TextBox();
            label4 = new Label();
            nrLabel = new Label();
            streetLabel = new Label();
            cityLabel = new Label();
            panel2 = new Panel();
            mapControl1 = new DevExpress.XtraMap.MapControl();
            confirmDeliveryAdressPanel.SuspendLayout();
            confirmOrderPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mapControl1).BeginInit();
            SuspendLayout();
            // 
            // confirmDeliveryAdressPanel
            // 
            confirmDeliveryAdressPanel.BackColor = Color.LightSalmon;
            confirmDeliveryAdressPanel.Controls.Add(distanceDelivery);
            confirmDeliveryAdressPanel.Controls.Add(maxDistanceDelivery);
            confirmDeliveryAdressPanel.Controls.Add(distanceDeliveryLabel);
            confirmDeliveryAdressPanel.Controls.Add(maxDeliveryDistanceLabel);
            confirmDeliveryAdressPanel.Controls.Add(confirmOrderPanel);
            confirmDeliveryAdressPanel.Controls.Add(confirmDeliverAdressButton);
            confirmDeliveryAdressPanel.Controls.Add(nrTextBox);
            confirmDeliveryAdressPanel.Controls.Add(streetTextBox);
            confirmDeliveryAdressPanel.Controls.Add(cityTextBox);
            confirmDeliveryAdressPanel.Controls.Add(label4);
            confirmDeliveryAdressPanel.Controls.Add(nrLabel);
            confirmDeliveryAdressPanel.Controls.Add(streetLabel);
            confirmDeliveryAdressPanel.Controls.Add(cityLabel);
            confirmDeliveryAdressPanel.Dock = DockStyle.Left;
            confirmDeliveryAdressPanel.Location = new Point(0, 0);
            confirmDeliveryAdressPanel.Margin = new Padding(3, 4, 3, 4);
            confirmDeliveryAdressPanel.Name = "confirmDeliveryAdressPanel";
            confirmDeliveryAdressPanel.Size = new Size(312, 559);
            confirmDeliveryAdressPanel.TabIndex = 0;
            // 
            // distanceDelivery
            // 
            distanceDelivery.Location = new Point(231, 312);
            distanceDelivery.Name = "distanceDelivery";
            distanceDelivery.Size = new Size(72, 25);
            distanceDelivery.TabIndex = 20;
            distanceDelivery.Text = "0";
            // 
            // maxDistanceDelivery
            // 
            maxDistanceDelivery.Location = new Point(231, 287);
            maxDistanceDelivery.Name = "maxDistanceDelivery";
            maxDistanceDelivery.Size = new Size(72, 25);
            maxDistanceDelivery.TabIndex = 19;
            maxDistanceDelivery.Text = "0";
            // 
            // distanceDeliveryLabel
            // 
            distanceDeliveryLabel.Location = new Point(26, 312);
            distanceDeliveryLabel.Name = "distanceDeliveryLabel";
            distanceDeliveryLabel.Size = new Size(190, 25);
            distanceDeliveryLabel.TabIndex = 18;
            distanceDeliveryLabel.Text = "Distance Delivery Order";
            // 
            // maxDeliveryDistanceLabel
            // 
            maxDeliveryDistanceLabel.Location = new Point(26, 287);
            maxDeliveryDistanceLabel.Name = "maxDeliveryDistanceLabel";
            maxDeliveryDistanceLabel.Size = new Size(199, 25);
            maxDeliveryDistanceLabel.TabIndex = 17;
            maxDeliveryDistanceLabel.Text = "Maximum Delivery Distance";
            // 
            // confirmOrderPanel
            // 
            confirmOrderPanel.BackColor = Color.DarkOrange;
            confirmOrderPanel.Controls.Add(confirmOrderButton);
            confirmOrderPanel.Controls.Add(totalPrice);
            confirmOrderPanel.Controls.Add(deliveryPriceLabel);
            confirmOrderPanel.Controls.Add(productsPrice);
            confirmOrderPanel.Controls.Add(totalPriceLabel);
            confirmOrderPanel.Controls.Add(extraDeliveryPrice);
            confirmOrderPanel.Controls.Add(extraDeliveryPriceLabel);
            confirmOrderPanel.Controls.Add(deliveryPrice);
            confirmOrderPanel.Controls.Add(productsPriceLabel);
            confirmOrderPanel.Dock = DockStyle.Bottom;
            confirmOrderPanel.Location = new Point(0, 340);
            confirmOrderPanel.Name = "confirmOrderPanel";
            confirmOrderPanel.Size = new Size(312, 219);
            confirmOrderPanel.TabIndex = 16;
            confirmOrderPanel.Visible = false;
            // 
            // confirmOrderButton
            // 
            confirmOrderButton.Location = new Point(74, 137);
            confirmOrderButton.Name = "confirmOrderButton";
            confirmOrderButton.Size = new Size(121, 55);
            confirmOrderButton.TabIndex = 16;
            confirmOrderButton.Text = "Looks good , let's go !";
            confirmOrderButton.UseVisualStyleBackColor = true;
            confirmOrderButton.Click += button2_Click;
            // 
            // totalPrice
            // 
            totalPrice.Font = new Font("Castellar", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalPrice.Location = new Point(171, 107);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(72, 25);
            totalPrice.TabIndex = 15;
            totalPrice.Text = "0";
            // 
            // deliveryPriceLabel
            // 
            deliveryPriceLabel.Location = new Point(37, 31);
            deliveryPriceLabel.Name = "deliveryPriceLabel";
            deliveryPriceLabel.Size = new Size(128, 25);
            deliveryPriceLabel.TabIndex = 8;
            deliveryPriceLabel.Text = "DeliveryPrice\r\n";
            // 
            // productsPrice
            // 
            productsPrice.Location = new Point(171, 81);
            productsPrice.Name = "productsPrice";
            productsPrice.Size = new Size(72, 25);
            productsPrice.TabIndex = 13;
            productsPrice.Text = "0";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Font = new Font("Castellar", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(37, 107);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(128, 33);
            totalPriceLabel.TabIndex = 14;
            totalPriceLabel.Text = "Total";
            // 
            // extraDeliveryPrice
            // 
            extraDeliveryPrice.Location = new Point(171, 56);
            extraDeliveryPrice.Name = "extraDeliveryPrice";
            extraDeliveryPrice.Size = new Size(62, 25);
            extraDeliveryPrice.TabIndex = 12;
            extraDeliveryPrice.Text = "0";
            // 
            // extraDeliveryPriceLabel
            // 
            extraDeliveryPriceLabel.Location = new Point(37, 56);
            extraDeliveryPriceLabel.Name = "extraDeliveryPriceLabel";
            extraDeliveryPriceLabel.Size = new Size(128, 25);
            extraDeliveryPriceLabel.TabIndex = 9;
            extraDeliveryPriceLabel.Text = "ExtraDeliveryPrice";
            // 
            // deliveryPrice
            // 
            deliveryPrice.Location = new Point(171, 31);
            deliveryPrice.Name = "deliveryPrice";
            deliveryPrice.Size = new Size(62, 25);
            deliveryPrice.TabIndex = 11;
            deliveryPrice.Text = "0";
            // 
            // productsPriceLabel
            // 
            productsPriceLabel.Location = new Point(37, 81);
            productsPriceLabel.Name = "productsPriceLabel";
            productsPriceLabel.Size = new Size(128, 25);
            productsPriceLabel.TabIndex = 10;
            productsPriceLabel.Text = "ProductsPrice";
            // 
            // confirmDeliverAdressButton
            // 
            confirmDeliverAdressButton.Location = new Point(104, 219);
            confirmDeliverAdressButton.Margin = new Padding(3, 4, 3, 4);
            confirmDeliverAdressButton.Name = "confirmDeliverAdressButton";
            confirmDeliverAdressButton.Size = new Size(86, 53);
            confirmDeliverAdressButton.TabIndex = 7;
            confirmDeliverAdressButton.Text = "Cmon im hungry!";
            confirmDeliverAdressButton.UseVisualStyleBackColor = true;
            confirmDeliverAdressButton.Click += button1_Click;
            // 
            // nrTextBox
            // 
            nrTextBox.Location = new Point(139, 167);
            nrTextBox.Margin = new Padding(3, 4, 3, 4);
            nrTextBox.Name = "nrTextBox";
            nrTextBox.Size = new Size(114, 27);
            nrTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(139, 113);
            streetTextBox.Margin = new Padding(3, 4, 3, 4);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(114, 27);
            streetTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(139, 57);
            cityTextBox.Margin = new Padding(3, 4, 3, 4);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(114, 27);
            cityTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(16, 244);
            label4.Name = "label4";
            label4.Size = new Size(79, 43);
            label4.TabIndex = 3;
            label4.Text = "\r\n";
            label4.Visible = false;
            // 
            // nrLabel
            // 
            nrLabel.AutoSize = true;
            nrLabel.Location = new Point(74, 167);
            nrLabel.Name = "nrLabel";
            nrLabel.Size = new Size(63, 20);
            nrLabel.TabIndex = 2;
            nrLabel.Text = "Number";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(90, 117);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(48, 20);
            streetLabel.TabIndex = 1;
            streetLabel.Text = "Street";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(101, 61);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City";
            // 
            // panel2
            // 
            panel2.Controls.Add(mapControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(312, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 559);
            panel2.TabIndex = 1;
            // 
            // mapControl1
            // 
            mapControl1.Dock = DockStyle.Fill;
            mapControl1.Location = new Point(0, 0);
            mapControl1.Margin = new Padding(3, 4, 3, 4);
            mapControl1.Name = "mapControl1";
            mapControl1.Size = new Size(839, 559);
            mapControl1.TabIndex = 0;
            // 
            // UserControlMap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(confirmDeliveryAdressPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlMap";
            Size = new Size(1151, 559);
            confirmDeliveryAdressPanel.ResumeLayout(false);
            confirmDeliveryAdressPanel.PerformLayout();
            confirmOrderPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mapControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel confirmDeliveryAdressPanel;
        private Panel panel2;
        private DevExpress.XtraMap.MapControl mapControl1;
        private Button confirmDeliverAdressButton;
        private TextBox nrTextBox;
        private TextBox streetTextBox;
        private TextBox cityTextBox;
        private Label label4;
        private Label nrLabel;
        private Label streetLabel;
        private Label cityLabel;
        private Label extraDeliveryPriceLabel;
        private Label deliveryPriceLabel;
        private Panel confirmOrderPanel;
        private Label totalPrice;
        private Label totalPriceLabel;
        private Label productsPrice;
        private Label extraDeliveryPrice;
        private Label deliveryPrice;
        private Label productsPriceLabel;
        private Label distanceDeliveryLabel;
        private Label maxDeliveryDistanceLabel;
        private Label distanceDelivery;
        private Label maxDistanceDelivery;
        private Button confirmOrderButton;
    }
}
