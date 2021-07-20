using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VSU.Collections;
using VSU.Models;
using VSU.Utils;

namespace VSU.Tasks
{
    public class AVLTreeViewConfigurer : ITaskConfigure<Student>
    {
        private const int MaxDepth = 3;
        private readonly CachedState _state;
        private readonly TreeView _view;

        public AVLTreeViewConfigurer(CachedState state, TreeView view)
        {
            _state = state;
            _view = view;
        }

        private TreeNode CopyTreeToView(ITreeNode<TaskStudent> node, int depth = 1)
        {
            if (depth > MaxDepth || node == null)
                return null;

            TreeNode[] childrens = new[]
            {
                CopyTreeToView(node.LeftChild, depth + 1),
                CopyTreeToView(node.RightChild, depth + 1)
            }.Where(x => x != null).ToArray();

            return new TreeNode($"{ node.Value.SecondName } - { node.Value.AverageMark }", childrens);
        }

        public void Configure(IEnumerable<Student> collection)
        {
            if (!_state.Cached)
            {
                _view.BeginUpdate();
                _view.Nodes.Clear();

                var tree = new AVLTree<TaskStudent>();
                foreach (Student student in collection)
                    tree.Add(new TaskStudent(student));

                if (!tree.IsEmpty)
                    _view.Nodes.Add(CopyTreeToView(tree.Root));

                _view.EndUpdate();
                _state.Cached = true;
            }
        }
    }
}
