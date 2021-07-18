
namespace VSU
{
    partial class AddStudentForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.secondnameLabel = new System.Windows.Forms.Label();
            this.marksLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondnameTextBox = new System.Windows.Forms.TextBox();
            this.marksTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя:";
            // 
            // secondnameLabel
            // 
            this.secondnameLabel.AutoSize = true;
            this.secondnameLabel.Location = new System.Drawing.Point(12, 42);
            this.secondnameLabel.Name = "secondnameLabel";
            this.secondnameLabel.Size = new System.Drawing.Size(61, 15);
            this.secondnameLabel.TabIndex = 1;
            this.secondnameLabel.Text = "Фамилия:";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Location = new System.Drawing.Point(12, 76);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(142, 15);
            this.marksLabel.TabIndex = 2;
            this.marksLabel.Text = "Оценки (через запятую):";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(176, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 23);
            this.nameTextBox.TabIndex = 3;
            // 
            // secondnameTextBox
            // 
            this.secondnameTextBox.Location = new System.Drawing.Point(176, 39);
            this.secondnameTextBox.Name = "secondnameTextBox";
            this.secondnameTextBox.Size = new System.Drawing.Size(232, 23);
            this.secondnameTextBox.TabIndex = 4;
            // 
            // marksTextBox
            // 
            this.marksTextBox.Location = new System.Drawing.Point(176, 73);
            this.marksTextBox.Name = "marksTextBox";
            this.marksTextBox.Size = new System.Drawing.Size(232, 23);
            this.marksTextBox.TabIndex = 5;
            this.marksTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MarksTextBoxKeyPressed);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(12, 105);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(396, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 137);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.marksTextBox);
            this.Controls.Add(this.secondnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.marksLabel);
            this.Controls.Add(this.secondnameLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentForm";
            this.Text = "Информация о студенте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label secondnameLabel;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondnameTextBox;
        private System.Windows.Forms.TextBox marksTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}