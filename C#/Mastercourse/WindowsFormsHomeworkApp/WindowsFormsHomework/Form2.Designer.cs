namespace WindowsFormsHomework
{
    partial class Form2
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
            listOfAddressBox = new ListBox();
            addAddressToListButton = new Button();
            streetLabel = new Label();
            streetTextBox = new TextBox();
            postalCodeLabel = new Label();
            houseNumberLabel = new Label();
            postalCodeTextBox = new TextBox();
            houseNumberTextBox = new TextBox();
            SuspendLayout();
            // 
            // listOfAddressBox
            // 
            listOfAddressBox.FormattingEnabled = true;
            listOfAddressBox.ItemHeight = 15;
            listOfAddressBox.Location = new Point(218, 239);
            listOfAddressBox.Name = "listOfAddressBox";
            listOfAddressBox.Size = new Size(293, 169);
            listOfAddressBox.TabIndex = 0;
            // 
            // addAddressToListButton
            // 
            addAddressToListButton.Location = new Point(234, 188);
            addAddressToListButton.Name = "addAddressToListButton";
            addAddressToListButton.Size = new Size(145, 23);
            addAddressToListButton.TabIndex = 1;
            addAddressToListButton.Text = "Add address to list";
            addAddressToListButton.UseVisualStyleBackColor = true;
            addAddressToListButton.Click += addAddressToListButton_Click;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(48, 30);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(43, 15);
            streetLabel.TabIndex = 2;
            streetLabel.Text = "Street: ";
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(178, 30);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(100, 23);
            streetTextBox.TabIndex = 3;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(48, 81);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(73, 15);
            postalCodeLabel.TabIndex = 2;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // houseNumberLabel
            // 
            houseNumberLabel.AutoSize = true;
            houseNumberLabel.Location = new Point(48, 130);
            houseNumberLabel.Name = "houseNumberLabel";
            houseNumberLabel.Size = new Size(91, 15);
            houseNumberLabel.TabIndex = 2;
            houseNumberLabel.Text = "House Number:";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(178, 79);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(100, 23);
            postalCodeTextBox.TabIndex = 3;
            // 
            // houseNumberTextBox
            // 
            houseNumberTextBox.Location = new Point(178, 127);
            houseNumberTextBox.Name = "houseNumberTextBox";
            houseNumberTextBox.Size = new Size(100, 23);
            houseNumberTextBox.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(houseNumberTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(houseNumberLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(streetLabel);
            Controls.Add(addAddressToListButton);
            Controls.Add(listOfAddressBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listOfAddressBox;
        private Button addAddressToListButton;
        private Label streetLabel;
        private TextBox streetTextBox;
        private Label postalCodeLabel;
        private Label houseNumberLabel;
        private TextBox postalCodeTextBox;
        private TextBox houseNumberTextBox;
    }
}