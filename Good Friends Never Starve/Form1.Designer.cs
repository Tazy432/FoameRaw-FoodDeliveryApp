using System.Windows.Forms;

namespace Good_Friends_Never_Starve
{
    partial class logInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInForm));
            usernameLabel = new Label();
            passwordLabel = new Label();
            backgroundImage = new PictureBox();
            logInButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logoImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backgroundImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(306, 213);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(194, 43);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(294, 275);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(206, 43);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // backgroundImage
            // 
            backgroundImage.Dock = DockStyle.Fill;
            backgroundImage.Image = (Image)resources.GetObject("backgroundImage.Image");
            backgroundImage.Location = new Point(0, 0);
            backgroundImage.Margin = new Padding(3, 4, 3, 4);
            backgroundImage.Name = "backgroundImage";
            backgroundImage.Size = new Size(914, 600);
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundImage.TabIndex = 8;
            backgroundImage.TabStop = false;
            // 
            // logInButton
            // 
            logInButton.Anchor = AnchorStyles.None;
            logInButton.Location = new Point(414, 357);
            logInButton.Margin = new Padding(3, 4, 3, 4);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(86, 31);
            logInButton.TabIndex = 9;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += button1_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(506, 231);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(115, 27);
            usernameTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(507, 291);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(114, 27);
            passwordTextBox.TabIndex = 11;
            // 
            // logoImage
            // 
            logoImage.Anchor = AnchorStyles.None;
            logoImage.BackgroundImage = (Image)resources.GetObject("logoImage.BackgroundImage");
            logoImage.Location = new Point(353, 12);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(197, 187);
            logoImage.SizeMode = PictureBoxSizeMode.CenterImage;
            logoImage.TabIndex = 12;
            logoImage.TabStop = false;
            // 
            // logInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(logoImage);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(logInButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(backgroundImage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "logInForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)backgroundImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usernameLabel;
        private Label passwordLabel;
        private PictureBox backgroundImage;
        private Button logInButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private PictureBox logoImage;
    }
}