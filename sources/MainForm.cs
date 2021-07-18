using System;
using System.Windows.Forms;
using VSU.Collections;

namespace VSU
{
    public partial class MainForm : Form
    {
        private readonly StudentList _list;

        public MainForm()
        {
            InitializeComponent();
            _list = new StudentList();
            studentsListView.DataSource = _list;
            _list.ListChanged += (s, e) =>
            {
                if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemAdded)
                    removeStudentButton.Enabled = true;
                else if (_list.Count < 1)
                    removeStudentButton.Enabled = false;
            };
        }

        private void AddStudentButtonClick(object sender, EventArgs e)
        {
            var dialog = new AddStudentForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void RemoveStudentButtonClick(object sender, EventArgs e)
        {
            if (studentsListView.SelectedIndices.Count > 0)
            {
                int index = studentsListView.SelectedIndices[0];
                _list.RemoveAt(index);
            }
        }

        private void StudentsListDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = studentsListView.HitTest(e.X, e.Y).Item;

        }
    }
}
