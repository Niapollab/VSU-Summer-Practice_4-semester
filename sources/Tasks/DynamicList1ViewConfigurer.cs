using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VSU.Collections;
using VSU.Models;
using VSU.Utils;

namespace VSU.Tasks
{
    public class DynamicList1ViewConfigurer : ITaskConfigure<Student>
    {
        private readonly CachedState _state;
        private readonly ListView _view;

        public DynamicList1ViewConfigurer(CachedState state, ListView view)
        {
            _state = state;
            _view = view;
        }

        private static bool HasBadMarks(Student student)
            => student.Marks.Where(x => x >= 2 && x <= 3).Any();

        public void Configure(IEnumerable<Student> collection)
        {
            if (!_state.Cached)
            {
                _view.BeginUpdate();
                _view.Items.Clear();

                var list = new Collections.LinkedList<TaskStudent>();
                ILinkedListNode<TaskStudent> firstHasOnlyGoodMarks = null;
                foreach (Student student in collection)
                {
                    var taskStudent = new TaskStudent(student);
                    bool hasBadMarks = HasBadMarks(student);
                    if (firstHasOnlyGoodMarks != null && hasBadMarks)
                        list.AddBefore(taskStudent, firstHasOnlyGoodMarks);
                    else
                    {
                        ILinkedListNode<TaskStudent> addedNode = list.AddAfter(taskStudent);
                        if (firstHasOnlyGoodMarks == null && !hasBadMarks)
                            firstHasOnlyGoodMarks = addedNode;
                    }
                }

                foreach (TaskStudent taskStudent in list)
                    _view.Items.Add(new ListViewItem(new string[] { taskStudent.FirstName, taskStudent.SecondName, taskStudent.AverageMark.ToString() }));

                _view.EndUpdate();
                _state.Cached = true;
            }
        }
    }
}
