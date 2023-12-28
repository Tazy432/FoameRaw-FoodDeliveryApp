namespace Good_Friends_Never_Starve
{
    partial class FormRestaurante
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
        #region getters and setters for the buttons inside FormRestaurante class
        public Button _goBackButton
        {
            get { return goBackButton; }
            set { goBackButton = value; }
        }
        public Button _button1
        {
            get { return finishOrderButton; }
            set { finishOrderButton = value; }
        }
        public Button _searchByUniqueCodeButton
        {
            get { return searchByUniqueCodeButton; }
            set { searchByUniqueCodeButton = value; }
        }
        #endregion
        #region getters and setters for the panels inside the FormRestaurante class 
        public Panel _panelForLogo
        {
            get { return panelForLogo; }
            set { panelForLogo = value; }
        }
        public Panel _panelForRestaurantDetails
        {
            get { return panelForRestaurantDetails; }
            set { panelForRestaurantDetails = value; }
        }
        public Panel _panelForCheckClient
        {
            get { return panelForCheckClient; }
            set { panelForCheckClient = value; }
        }
        public Panel _panelForClientOrder
        {
            get { return panelForClientOrder; }
            set { panelForClientOrder = value; }
        }
        #endregion       
        #region getters and setters for the labels inside the formRestaurante class
        public Label _labelNumeRes
        {
            get { return labelNumeRes; }
            set { labelNumeRes = value; }
        }
        public Label _labelProgramRes
        {
            get { return labelProgramRes; }
            set { labelProgramRes = value; }
        }
        public Label _total
        {
            get { return total; }
            set { total = value; }
        }
        public Label _labelTaxaLivrareRes
        {
            get { return labelTaxaLivrareRes; }
            set { labelTaxaLivrareRes = value; }
        }
        public Label _clientOrderLabel
        {
            get { return clientOrderLabel; }
            set { clientOrderLabel = value; }
        }
        public Label _labelTotal
        {
            get { return labelTotal; }
            set { labelTotal = value; }
        }
        public Label _minimuRequOrder
        {
            get { return minimuRequOrder; }
            set { minimuRequOrder = value; }
        }
        public Label _priceOfStandardDelivery
        {
            get { return priceOfStandardDelivery; }
            set { priceOfStandardDelivery = value; }
        }
        public Label _uniqueOrderCodeLabel
        {
            get { return uniqueOrderCodeLabel; }
            set { uniqueOrderCodeLabel = value; }
        }
        #endregion
        #region getters and setters for the picture box, flowLayoutPanel and text box from the FormRestaurante class
        public FlowLayoutPanel _flowLayoutPanel1
        {
            get { return flowLayoutPanel1; }
            set { flowLayoutPanel1 = value; }
        }
        public PictureBox _appLogo
        {
            get { return appLogo; }
            set { appLogo = value; }
        }
        public TextBox _uniqueCodeSearchBar
        {
            get { return uniqueCodeSearchBar; }
            set { uniqueCodeSearchBar = value; }
        }
        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestaurante));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelForRestaurantDetails = new Panel();
            goBackButton = new Button();
            labelNumeRes = new Label();
            labelTaxaLivrareRes = new Label();
            labelProgramRes = new Label();
            panelForCheckClient = new Panel();
            searchByUniqueCodeButton = new Button();
            uniqueCodeSearchBar = new TextBox();
            uniqueOrderCodeLabel = new Label();
            priceOfStandardDelivery = new Label();
            minimuRequOrder = new Label();
            total = new Label();
            labelTotal = new Label();
            finishOrderButton = new Button();
            panelForClientOrder = new Panel();
            clientOrderLabel = new Label();
            panelForLogo = new Panel();
            appLogo = new PictureBox();
            panelForRestaurantDetails.SuspendLayout();
            panelForCheckClient.SuspendLayout();
            panelForClientOrder.SuspendLayout();
            panelForLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appLogo).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightSalmon;
            flowLayoutPanel1.Location = new Point(215, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(752, 653);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panelForRestaurantDetails
            // 
            panelForRestaurantDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForRestaurantDetails.AutoSize = true;
            panelForRestaurantDetails.BackColor = Color.IndianRed;
            panelForRestaurantDetails.Controls.Add(goBackButton);
            panelForRestaurantDetails.Controls.Add(labelNumeRes);
            panelForRestaurantDetails.Controls.Add(labelTaxaLivrareRes);
            panelForRestaurantDetails.Controls.Add(labelProgramRes);
            panelForRestaurantDetails.Location = new Point(215, 0);
            panelForRestaurantDetails.Name = "panelForRestaurantDetails";
            panelForRestaurantDetails.Size = new Size(752, 48);
            panelForRestaurantDetails.TabIndex = 3;
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(14, 4);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(94, 29);
            goBackButton.TabIndex = 4;
            goBackButton.Text = "Back\r\n";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Visible = false;
            goBackButton.Click += button2_Click;
            // 
            // labelNumeRes
            // 
            labelNumeRes.AutoSize = true;
            labelNumeRes.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeRes.Location = new Point(177, 9);
            labelNumeRes.Name = "labelNumeRes";
            labelNumeRes.Size = new Size(65, 21);
            labelNumeRes.TabIndex = 0;
            labelNumeRes.Text = "Nume ";
            // 
            // labelTaxaLivrareRes
            // 
            labelTaxaLivrareRes.AutoSize = true;
            labelTaxaLivrareRes.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTaxaLivrareRes.Location = new Point(561, 9);
            labelTaxaLivrareRes.Name = "labelTaxaLivrareRes";
            labelTaxaLivrareRes.Size = new Size(135, 21);
            labelTaxaLivrareRes.TabIndex = 3;
            labelTaxaLivrareRes.Text = "Cost livrare";
            // 
            // labelProgramRes
            // 
            labelProgramRes.AutoSize = true;
            labelProgramRes.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelProgramRes.Location = new Point(373, 9);
            labelProgramRes.Name = "labelProgramRes";
            labelProgramRes.Size = new Size(101, 21);
            labelProgramRes.TabIndex = 1;
            labelProgramRes.Text = "Program";
            // 
            // panelForCheckClient
            // 
            panelForCheckClient.BackColor = Color.IndianRed;
            panelForCheckClient.Controls.Add(searchByUniqueCodeButton);
            panelForCheckClient.Controls.Add(uniqueCodeSearchBar);
            panelForCheckClient.Controls.Add(uniqueOrderCodeLabel);
            panelForCheckClient.Controls.Add(priceOfStandardDelivery);
            panelForCheckClient.Controls.Add(minimuRequOrder);
            panelForCheckClient.Controls.Add(total);
            panelForCheckClient.Controls.Add(labelTotal);
            panelForCheckClient.Controls.Add(finishOrderButton);
            panelForCheckClient.Controls.Add(panelForClientOrder);
            panelForCheckClient.Controls.Add(panelForLogo);
            panelForCheckClient.Dock = DockStyle.Left;
            panelForCheckClient.Location = new Point(0, 0);
            panelForCheckClient.Name = "panelForCheckClient";
            panelForCheckClient.Size = new Size(222, 701);
            panelForCheckClient.TabIndex = 4;
            // 
            // searchByUniqueCodeButton
            // 
            searchByUniqueCodeButton.Location = new Point(79, 81);
            searchByUniqueCodeButton.Name = "searchByUniqueCodeButton";
            searchByUniqueCodeButton.Size = new Size(49, 29);
            searchByUniqueCodeButton.TabIndex = 10;
            searchByUniqueCodeButton.Text = "Go!";
            searchByUniqueCodeButton.UseVisualStyleBackColor = true;
            searchByUniqueCodeButton.Click += button3_Click;
            // 
            // uniqueCodeSearchBar
            // 
            uniqueCodeSearchBar.Location = new Point(39, 48);
            uniqueCodeSearchBar.Name = "uniqueCodeSearchBar";
            uniqueCodeSearchBar.Size = new Size(135, 27);
            uniqueCodeSearchBar.TabIndex = 9;
            // 
            // uniqueOrderCodeLabel
            // 
            uniqueOrderCodeLabel.AutoSize = true;
            uniqueOrderCodeLabel.Location = new Point(39, 25);
            uniqueOrderCodeLabel.Name = "uniqueOrderCodeLabel";
            uniqueOrderCodeLabel.Size = new Size(135, 20);
            uniqueOrderCodeLabel.TabIndex = 8;
            uniqueOrderCodeLabel.Text = "Unique Order code";
            // 
            // priceOfStandardDelivery
            // 
            priceOfStandardDelivery.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceOfStandardDelivery.Location = new Point(0, 525);
            priceOfStandardDelivery.Name = "priceOfStandardDelivery";
            priceOfStandardDelivery.Size = new Size(215, 31);
            priceOfStandardDelivery.TabIndex = 7;
            priceOfStandardDelivery.Text = "+Standard Delivery";
            priceOfStandardDelivery.Visible = false;
            // 
            // minimuRequOrder
            // 
            minimuRequOrder.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            minimuRequOrder.Location = new Point(0, 556);
            minimuRequOrder.Name = "minimuRequOrder";
            minimuRequOrder.Size = new Size(219, 25);
            minimuRequOrder.TabIndex = 6;
            minimuRequOrder.Text = "MinimumOrder";
            minimuRequOrder.Visible = false;
            // 
            // total
            // 
            total.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(97, 489);
            total.Name = "total";
            total.Size = new Size(122, 25);
            total.TabIndex = 5;
            total.Text = "0";
            total.Visible = false;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(0, 489);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(82, 36);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            labelTotal.Visible = false;
            // 
            // finishOrderButton
            // 
            finishOrderButton.Location = new Point(39, 603);
            finishOrderButton.Name = "finishOrderButton";
            finishOrderButton.Size = new Size(109, 53);
            finishOrderButton.TabIndex = 3;
            finishOrderButton.Text = "Yep , that's about it";
            finishOrderButton.UseVisualStyleBackColor = true;
            finishOrderButton.Visible = false;
            finishOrderButton.Click += button1_Click;
            // 
            // panelForClientOrder
            // 
            panelForClientOrder.AutoScroll = true;
            panelForClientOrder.Controls.Add(clientOrderLabel);
            panelForClientOrder.Location = new Point(3, 295);
            panelForClientOrder.Name = "panelForClientOrder";
            panelForClientOrder.Size = new Size(216, 191);
            panelForClientOrder.TabIndex = 2;
            // 
            // clientOrderLabel
            // 
            clientOrderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clientOrderLabel.AutoSize = true;
            clientOrderLabel.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            clientOrderLabel.Location = new Point(19, 13);
            clientOrderLabel.Name = "clientOrderLabel";
            clientOrderLabel.Size = new Size(53, 17);
            clientOrderLabel.TabIndex = 2;
            clientOrderLabel.Text = "label5";
            // 
            // panelForLogo
            // 
            panelForLogo.BackColor = Color.LightSalmon;
            panelForLogo.Controls.Add(appLogo);
            panelForLogo.Location = new Point(22, 127);
            panelForLogo.Name = "panelForLogo";
            panelForLogo.Size = new Size(160, 141);
            panelForLogo.TabIndex = 1;
            // 
            // appLogo
            // 
            appLogo.Image = (Image)resources.GetObject("appLogo.Image");
            appLogo.Location = new Point(17, 17);
            appLogo.Name = "appLogo";
            appLogo.Size = new Size(125, 103);
            appLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            appLogo.TabIndex = 0;
            appLogo.TabStop = false;
            // 
            // FormRestaurante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(968, 701);
            Controls.Add(panelForCheckClient);
            Controls.Add(panelForRestaurantDetails);
            Controls.Add(flowLayoutPanel1);
            Name = "FormRestaurante";
            Text = "FormRestaurante";
            Load += FormRestaurante_Load;
            panelForRestaurantDetails.ResumeLayout(false);
            panelForRestaurantDetails.PerformLayout();
            panelForCheckClient.ResumeLayout(false);
            panelForCheckClient.PerformLayout();
            panelForClientOrder.ResumeLayout(false);
            panelForClientOrder.PerformLayout();
            panelForLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelForLogo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelForRestaurantDetails;
        private Label labelNumeRes;
        private Label labelTaxaLivrareRes;
        private Label labelProgramRes;
        private Panel panelForCheckClient;
        private PictureBox appLogo;
        private Label clientOrderLabel;
        private Panel panelForClientOrder;
        private Label labelTotal;
        private Button finishOrderButton;
        private Label total;
        private Button goBackButton;
        private Label minimuRequOrder;
        private Label priceOfStandardDelivery;
        private TextBox uniqueCodeSearchBar;
        private Label uniqueOrderCodeLabel;
        private Button searchByUniqueCodeButton;
    }
}