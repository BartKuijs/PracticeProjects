namespace WindowsFormsMiniProject
{
    partial class AddressEntry
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            streetLabel = new Label();
            streetTextBox = new TextBox();
            houseNumberLabel = new Label();
            houseNumberTextBox = new TextBox();
            postalCodeLabel = new Label();
            postalCodeTextBox = new TextBox();
            cityLabel = new Label();
            cityTextBox = new TextBox();
            addAddressesButton = new Button();
            SuspendLayout();
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(34, 35);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(40, 15);
            streetLabel.TabIndex = 0;
            streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(141, 32);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(259, 23);
            streetTextBox.TabIndex = 1;
            // 
            // houseNumberLabel
            // 
            houseNumberLabel.AutoSize = true;
            houseNumberLabel.Location = new Point(34, 75);
            houseNumberLabel.Name = "houseNumberLabel";
            houseNumberLabel.Size = new Size(91, 15);
            houseNumberLabel.TabIndex = 0;
            houseNumberLabel.Text = "House Number:";
            // 
            // houseNumberTextBox
            // 
            houseNumberTextBox.Location = new Point(141, 72);
            houseNumberTextBox.Name = "houseNumberTextBox";
            houseNumberTextBox.Size = new Size(259, 23);
            houseNumberTextBox.TabIndex = 1;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(34, 113);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(73, 15);
            postalCodeLabel.TabIndex = 0;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(141, 110);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(259, 23);
            postalCodeTextBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(34, 157);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(141, 154);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(259, 23);
            cityTextBox.TabIndex = 1;
            // 
            // addAddressesButton
            // 
            addAddressesButton.Location = new Point(141, 248);
            addAddressesButton.Name = "addAddressesButton";
            addAddressesButton.Size = new Size(151, 59);
            addAddressesButton.TabIndex = 3;
            addAddressesButton.Text = "Add Address";
            addAddressesButton.UseVisualStyleBackColor = true;
            addAddressesButton.Click += addAddressesButton_Click;
            // 
            // AddressEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 407);
            Controls.Add(addAddressesButton);
            Controls.Add(cityTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(houseNumberTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(cityLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(houseNumberLabel);
            Controls.Add(streetLabel);
            Name = "AddressEntry";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label streetLabel;
        private TextBox streetTextBox;
        private Label houseNumberLabel;
        private TextBox houseNumberTextBox;
        private Label postalCodeLabel;
        private TextBox postalCodeTextBox;
        private Label cityLabel;
        private TextBox cityTextBox;
        private Button addAddressesButton;
    }
}