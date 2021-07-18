using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VSU.Collections;
using VSU.Models;
using VSU.Models.DataLoader;

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
                _list.Add(dialog.Student);
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
            int index = studentsListView.HitTest(e.X, e.Y).Item.Index;
            var dialog = new AddStudentForm(_list[index]);
            dialog.ShowDialog(this);
        }

        private void StudentsListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                removeStudentButton.PerformClick();
        }

        private async void OpenFileButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var loader = new StudentsJSONDataLoader(openFileDialog.FileName);
                
                try
                {
                    Enabled = false;
                    IEnumerable<Student> students = await loader.ReadStudentsAsync();
                    _list.Clear();
                    foreach (Student student in students)
                        _list.Add(student);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Enabled = true;
                }
            }
        }

        private async void SaveFileButtonClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var loader = new StudentsJSONDataLoader(saveFileDialog.FileName);

                try
                {
                    Enabled = false;
                    await loader.SaveStudentsAsync(_list);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Enabled = true;
                }
            }
        }
    }
}
