using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VSU.Models;
using VSU.Utils;

namespace VSU.Tasks
{
    public class BestStudentsConfigurer : ITaskConfigure<Student>
    {
        private readonly CachedState _state;
        private readonly ListView _view;

        public BestStudentsConfigurer(CachedState state, ListView view)
        {
            _state = state;
            _view = view;
        }

        private static int GetCountOfGoodMarks(IEnumerable<Mark> marks)
            => marks.Where(x => x >= 4 && x <= 5).Count();

        public void Configure(IEnumerable<Student> collection)
        {
            if (!_state.Cached)
            {
                _view.BeginUpdate();
                _view.Items.Clear();

                IEnumerable<Student> descMarksCollection = collection.OrderByDescending(selector => GetCountOfGoodMarks(selector.Marks));

                int goodMarksMaxCount = 0;
                var students = descMarksCollection.TakeWhile(x =>
                {
                    int currentGoodMarksCount = GetCountOfGoodMarks(x.Marks);
                    if (goodMarksMaxCount <= currentGoodMarksCount)
                    {
                        goodMarksMaxCount = currentGoodMarksCount;
                        return true;
                    }
                    return false;
                }).Select(x => new TaskStudent(x));

                foreach (TaskStudent taskStudent in students)
                    _view.Items.Add(new ListViewItem(new string[] { taskStudent.SecondName, taskStudent.AverageMark.ToString() }));

                _view.EndUpdate();
                _state.Cached = true;
            }
        }
    }
}
