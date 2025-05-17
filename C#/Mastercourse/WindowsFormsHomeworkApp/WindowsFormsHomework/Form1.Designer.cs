namespace WindowsFormsHomework
{
    partial class Form1
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
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            welcomeButton = new Button();
            adresButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(63, 36);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(63, 74);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(151, 33);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(151, 71);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // welcomeButton
            // 
            welcomeButton.Location = new Point(63, 135);
            welcomeButton.Name = "welcomeButton";
            welcomeButton.Size = new Size(224, 112);
            welcomeButton.TabIndex = 3;
            welcomeButton.Text = "Click here!";
            welcomeButton.UseVisualStyleBackColor = true;
            welcomeButton.Click += welcomeButton_Click;
            // 
            // adresButton
            // 
            adresButton.Location = new Point(419, 135);
            adresButton.Name = "adresButton";
            adresButton.Size = new Size(229, 112);
            adresButton.TabIndex = 4;
            adresButton.Text = "Add an address";
            adresButton.UseVisualStyleBackColor = true;
            adresButton.Click += adresButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adresButton);
            Controls.Add(welcomeButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Form1";
            Text = "HomeWorkApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button welcomeButton;
        private Button adresButton;
    }
}