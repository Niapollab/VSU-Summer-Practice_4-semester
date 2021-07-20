using System.Collections.Generic;
using System.Windows.Forms;
using VSU.Collections;
using VSU.Models;
using VSU.Utils;

namespace VSU.Tasks
{
    public class DynamicList2ViewConfigurer : ITaskConfigure<Student>
    {
        private readonly CachedState _state;
        private readonly ListView _view;

        public DynamicList2ViewConfigurer(CachedState state, ListView view)
        {
            _state = state;
            _view = view;
        }

        public void Configure(IEnumerable<Student> collection)
        {
            if (!_state.Cached)
            {
                _view.BeginUpdate();
                _view.Items.Clear();

                var list = new SortedLinkedList<TaskStudent>();

                foreach (Student student in collection)
                    list.Add(new TaskStudent(student));

                foreach (TaskStudent taskStudent in list)
                    _view.Items.Add(new ListViewItem(new string[] { taskStudent.SecondName, taskStudent.AverageMark.ToString() }));

                _view.EndUpdate();
                _state.Cached = true;
            }
        }
    }
}
