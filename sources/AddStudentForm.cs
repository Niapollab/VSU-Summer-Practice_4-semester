using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSU.Models;

namespace VSU
{
    public partial class AddStudentForm : Form
    {
        private readonly Student _student;

        public AddStudentForm(Student student = null)
        {
            InitializeComponent();
            _student = student;

            SetBoxes();
        }

        private void SaveFormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SetBoxes()
        {
            nameTextBox.Text = _student?.FirstName ?? "";
            secondnameTextBox.Text = _student?.SecondName ?? "";
            marksTextBox.Text = _student?.Marks?.ToString() ?? "";
        }
    }
}
