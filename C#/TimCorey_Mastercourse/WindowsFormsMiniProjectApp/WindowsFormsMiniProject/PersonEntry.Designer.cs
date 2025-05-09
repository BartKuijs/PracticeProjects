namespace WindowsFormsMiniProject
{
    partial class PersonEntry
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            saveDataButton = new Button();
            addressFormButton = new Button();
            isActive = new CheckBox();
            isActiveLabel = new Label();
            addressesList = new ListBox();
            addressesListLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(28, 32);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(125, 29);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(162, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(28, 75);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(125, 72);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(162, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // saveDataButton
            // 
            saveDataButton.Location = new Point(194, 480);
            saveDataButton.Name = "saveDataButton";
            saveDataButton.Size = new Size(93, 57);
            saveDataButton.TabIndex = 2;
            saveDataButton.Text = "Save";
            saveDataButton.UseVisualStyleBackColor = true;
            saveDataButton.Click += saveDataButton_Click;
            // 
            // addressFormButton
            // 
            addressFormButton.Location = new Point(350, 110);
            addressFormButton.Name = "addressFormButton";
            addressFormButton.Size = new Size(127, 57);
            addressFormButton.TabIndex = 2;
            addressFormButton.Text = "Add an address";
            addressFormButton.UseVisualStyleBackColor = true;
            addressFormButton.Click += addressFormButton_Click_1;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(125, 132);
            isActive.Name = "isActive";
            isActive.Size = new Size(15, 14);
            isActive.TabIndex = 3;
            isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new Point(28, 131);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new Size(43, 15);
            isActiveLabel.TabIndex = 0;
            isActiveLabel.Text = "Active:";
            // 
            // addressesList
            // 
            addressesList.FormattingEnabled = true;
            addressesList.ItemHeight = 15;
            addressesList.Location = new Point(29, 194);
            addressesList.Name = "addressesList";
            addressesList.Size = new Size(448, 259);
            addressesList.TabIndex = 4;
            // 
            // addressesListLabel
            // 
            addressesListLabel.AutoSize = true;
            addressesListLabel.Location = new Point(29, 169);
            addressesListLabel.Name = "addressesListLabel";
            addressesListLabel.Size = new Size(63, 15);
            addressesListLabel.TabIndex = 0;
            addressesListLabel.Text = "Addresses:";
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 574);
            Controls.Add(addressesList);
            Controls.Add(isActive);
            Controls.Add(addressFormButton);
            Controls.Add(saveDataButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(addressesListLabel);
            Controls.Add(isActiveLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Name = "PersonEntry";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Button saveDataButton;
        private Button addressFormButton;
        private CheckBox isActive;
        private Label isActiveLabel;
        private ListBox addressesList;
        private Label addressesListLabel;
    }
}