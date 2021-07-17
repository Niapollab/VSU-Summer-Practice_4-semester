using System.Windows.Forms;
using VSU.Collections;
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
        }
    }
}
