using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VSU.Models;

namespace VSU
{
    public partial class AddStudentForm : Form
    {
        private static readonly char[] s_AllowedKeys = new[] { '2', '3', '4', '5', ' ', ',', Convert.ToChar(Keys.Back), Convert.ToChar(Keys.Enter) };

        public Student Student { get; }

        public AddStudentForm(Student student = null)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            Student = student ?? new Student(null, null, new MarkCollection());

            nameTextBox.Text = Student?.FirstName ?? string.Empty;
            secondnameTextBox.Text = Student?.SecondName ?? string.Empty;
            marksTextBox.Text = Student?.Marks?.ToString() ?? string.Empty;

            TextBox[] textBoxes = new[] { nameTextBox, secondnameTextBox, marksTextBox };
            foreach (TextBox textbox in textBoxes)
            {
                textbox.KeyPress += EnterIsPressed;
                textbox.TextChanged += OneOfTextBoxIsEmpty;
            }

            OneOfTextBoxIsEmpty(this, EventArgs.Empty);
        }

        private void OneOfTextBoxIsEmpty(object sender, EventArgs e)
            => saveButton.Enabled = nameTextBox.Text.Length > 0
                && secondnameTextBox.Text.Length > 0
                && marksTextBox.Text.Length > 0;

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Mark[] marks = marksTextBox.Text.Split(',', StringSplitOptions.TrimEntries)
                    .Select(x => (Mark)int.Parse(x))
                    .ToArray();

                Student.FirstName = nameTextBox.Text;
                Student.SecondName = secondnameTextBox.Text;
                Student.Marks = new MarkCollection(marks);

                Close();
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnterIsPressed(object sender, KeyPressEventArgs e)
        {
            char enterKey = Convert.ToChar(Keys.Enter);
            if (e.KeyChar == enterKey)
                saveButton.PerformClick();
        }

        private void MarksTextBoxKeyPressed(object sender, KeyPressEventArgs e)
            => e.Handled = !s_AllowedKeys.Contains(e.KeyChar);
    }
}
