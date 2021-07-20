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
            this.dynamicChain1View = new System.Windows.Forms.ListView();
            this.secondnameColumnC1 = new System.Windows.Forms.ColumnHeader();
            this.marksColumnDC1 = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dynamicChain2View = new System.Windows.Forms.ListView();
            this.secondnameColumnDC2 = new System.Windows.Forms.ColumnHeader();
            this.marksColumnDC2 = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bestStudentsView = new System.Windows.Forms.ListView();
            this.secondnameColumnBS = new System.Windows.Forms.ColumnHeader();
            this.marksColumnBS = new System.Windows.Forms.ColumnHeader();
            this.mainTabControl.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabIndexChanged);
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
            this.tabPage1.Controls.Add(this.dynamicChain1View);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Динамическая цепочка 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dynamicChain1View
            // 
            this.dynamicChain1View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.secondnameColumnC1,
            this.marksColumnDC1});
            this.dynamicChain1View.FullRowSelect = true;
            this.dynamicChain1View.HideSelection = false;
            this.dynamicChain1View.Location = new System.Drawing.Point(3, 3);
            this.dynamicChain1View.Name = "dynamicChain1View";
            this.dynamicChain1View.Size = new System.Drawing.Size(589, 172);
            this.dynamicChain1View.TabIndex = 0;
            this.dynamicChain1View.UseCompatibleStateImageBehavior = false;
            this.dynamicChain1View.View = System.Windows.Forms.View.Details;
            // 
            // secondnameColumnC1
            // 
            this.secondnameColumnC1.Text = "Фамилия";
            this.secondnameColumnC1.Width = 100;
            // 
            // marksColumnDC1
            // 
            this.marksColumnDC1.Text = "Средний балл";
            this.marksColumnDC1.Width = 482;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dynamicChain2View);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Динамическая цепочка 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dynamicChain2View
            // 
            this.dynamicChain2View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.secondnameColumnDC2,
            this.marksColumnDC2});
            this.dynamicChain2View.FullRowSelect = true;
            this.dynamicChain2View.HideSelection = false;
            this.dynamicChain2View.Location = new System.Drawing.Point(3, 3);
            this.dynamicChain2View.Name = "dynamicChain2View";
            this.dynamicChain2View.Size = new System.Drawing.Size(589, 172);
            this.dynamicChain2View.TabIndex = 1;
            this.dynamicChain2View.UseCompatibleStateImageBehavior = false;
            this.dynamicChain2View.View = System.Windows.Forms.View.Details;
            // 
            // secondnameColumnDC2
            // 
            this.secondnameColumnDC2.Text = "Фамилия";
            this.secondnameColumnDC2.Width = 100;
            // 
            // marksColumnDC2
            // 
            this.marksColumnDC2.Text = "Средний балл";
            this.marksColumnDC2.Width = 482;
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
            this.tabPage5.Controls.Add(this.bestStudentsView);
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
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButtonClick);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(326, 224);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(285, 23);
            this.saveFileButton.TabIndex = 5;
            this.saveFileButton.Text = "Сохранить файл";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFileButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.FileName = "students";
            this.openFileDialog.Filter = "JSON файл (*.json)|*.json|Все файлы (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.FileName = "students";
            this.saveFileDialog.Filter = "JSON файл (*.json)|*.json|Все файлы (*.*)|*.*";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // bestStudentsView
            // 
            this.bestStudentsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.secondnameColumnBS,
            this.marksColumnBS});
            this.bestStudentsView.FullRowSelect = true;
            this.bestStudentsView.HideSelection = false;
            this.bestStudentsView.Location = new System.Drawing.Point(3, 3);
            this.bestStudentsView.Name = "bestStudentsView";
            this.bestStudentsView.Size = new System.Drawing.Size(589, 172);
            this.bestStudentsView.TabIndex = 6;
            this.bestStudentsView.UseCompatibleStateImageBehavior = false;
            this.bestStudentsView.View = System.Windows.Forms.View.Details;
            // 
            // secondnameColumnBS
            // 
            this.secondnameColumnBS.Text = "Фамилия";
            this.secondnameColumnBS.Width = 100;
            // 
            // marksColumnBS
            // 
            this.marksColumnBS.Text = "Средний балл";
            this.marksColumnBS.Width = 482;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
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
        private System.Windows.Forms.ListView dynamicChain1View;
        private System.Windows.Forms.ColumnHeader secondnameColumnC1;
        private System.Windows.Forms.ColumnHeader marksColumnDC1;
        private System.Windows.Forms.ListView dynamicChain2View;
        private System.Windows.Forms.ColumnHeader secondnameColumnDC2;
        private System.Windows.Forms.ColumnHeader marksColumnDC2;
        private System.Windows.Forms.ListView bestStudentsView;
        private System.Windows.Forms.ColumnHeader secondnameColumnBS;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader marksColumnBS;
    }
}

