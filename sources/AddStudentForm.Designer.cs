
namespace VSU.sources
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SecondnameLabel = new System.Windows.Forms.Label();
            this.MarksLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SecondnameTextBox = new System.Windows.Forms.TextBox();
            this.MarksTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(34, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя:";
            // 
            // SecondnameLabel
            // 
            this.SecondnameLabel.AutoSize = true;
            this.SecondnameLabel.Location = new System.Drawing.Point(12, 42);
            this.SecondnameLabel.Name = "SecondnameLabel";
            this.SecondnameLabel.Size = new System.Drawing.Size(61, 15);
            this.SecondnameLabel.TabIndex = 1;
            this.SecondnameLabel.Text = "Фамилия:";
            // 
            // MarksLabel
            // 
            this.MarksLabel.AutoSize = true;
            this.MarksLabel.Location = new System.Drawing.Point(12, 76);
            this.MarksLabel.Name = "MarksLabel";
            this.MarksLabel.Size = new System.Drawing.Size(142, 15);
            this.MarksLabel.TabIndex = 2;
            this.MarksLabel.Text = "Оценки (через запятую):";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(176, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(232, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // SecondnameTextBox
            // 
            this.SecondnameTextBox.Location = new System.Drawing.Point(176, 39);
            this.SecondnameTextBox.Name = "SecondnameTextBox";
            this.SecondnameTextBox.Size = new System.Drawing.Size(232, 23);
            this.SecondnameTextBox.TabIndex = 4;
            // 
            // MarksTextBox
            // 
            this.MarksTextBox.Location = new System.Drawing.Point(176, 73);
            this.MarksTextBox.Name = "MarksTextBox";
            this.MarksTextBox.Size = new System.Drawing.Size(232, 23);
            this.MarksTextBox.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 105);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(396, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 137);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MarksTextBox);
            this.Controls.Add(this.SecondnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MarksLabel);
            this.Controls.Add(this.SecondnameLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentForm";
            this.Text = "Информация о студенте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SecondnameLabel;
        private System.Windows.Forms.Label MarksLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SecondnameTextBox;
        private System.Windows.Forms.TextBox MarksTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}