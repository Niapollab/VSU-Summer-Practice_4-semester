namespace VSU
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.studentsListView = new System.Windows.Forms.BindableListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.secondnameColumn = new System.Windows.Forms.ColumnHeader();
            this.marksColumn = new System.Windows.Forms.ColumnHeader();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainTabControl.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage0);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Controls.Add(this.tabPage5);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(603, 206);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.studentsListView);
            this.tabPage0.Controls.Add(this.removeStudentButton);
            this.tabPage0.Controls.Add(this.addStudentButton);
            this.tabPage0.Location = new System.Drawing.Point(4, 24);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(595, 178);
            this.tabPage0.TabIndex = 5;
            this.tabPage0.Text = "Список студентов";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // studentsListView
            // 
            this.studentsListView.AutoArrange = false;
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.secondnameColumn,
            this.marksColumn});
            this.studentsListView.DataMember = null;
            this.studentsListView.DataSource = null;
            this.studentsListView.FullRowSelect = true;
            this.studentsListView.HideSelection = false;
            this.studentsListView.Location = new System.Drawing.Point(4, 3);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(586, 136);
            this.studentsListView.TabIndex = 0;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            this.studentsListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentsListKeyDown);
            this.studentsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StudentsListDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Имя";
            this.nameColumn.Width = 100;
            // 
            // secondnameColumn
            // 
            this.secondnameColumn.Text = "Фамилия";
            this.secondnameColumn.Width = 100;
            // 
            // marksColumn
            // 
            this.marksColumn.Text = "Оценки";
            this.marksColumn.Width = 382;
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Enabled = false;
            this.removeStudentButton.Location = new System.Drawing.Point(312, 145);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(278, 23);
            this.removeStudentButton.TabIndex = 3;
            this.removeStudentButton.Text = "Удалить студента";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.RemoveStudentButtonClick);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(4, 145);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(290, 23);
            this.addStudentButton.TabIndex = 2;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.AddStudentButtonClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Динамическая цепочка 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Динамическая цепочка 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(595, 178);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бинарное дерево";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(595, 178);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "АВЛ-Дерево";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(595, 178);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Лучшие студенты";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(16, 224);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(294, 23);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Открыть файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(326, 224);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(285, 23);
            this.saveFileButton.TabIndex = 5;
            this.saveFileButton.Text = "Сохранить файл";
            this.saveFileButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 258);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Летняя практика ВГУ (4 семестр)";
            this.mainTabControl.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.BindableListView studentsListView;
        private System.Windows.Forms.ColumnHeader secondnameColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader marksColumn;
    }
}

