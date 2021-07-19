namespace VSU.Utils
{
    public class CachedStateManager
    {
        public CachedState DynamicList1 { get; }
        public CachedState DynamicList2 { get; }
        public CachedState BinarySearchTree { get; }
        public CachedState AVLTree { get; }
        public CachedState BestList { get; }

        public CachedStateManager()
        {
            DynamicList1 = new CachedState();
            DynamicList2 = new CachedState();
            BinarySearchTree = new CachedState();
            AVLTree = new CachedState();
            BestList = new CachedState();
        }

        public void CacheDynamicList1()
            => DynamicList1.Cached = true;

        public void CacheDynamicList2()
            => DynamicList2.Cached = true;

        public void CacheBinarySearchTree()
            => BinarySearchTree.Cached = true;

        public void CacheAVLTree()
            => AVLTree.Cached = true;

        public void CacheBestList()
            => BestList.Cached = true;

        public void UncacheAll()
        {
            DynamicList1.Cached = false;
            DynamicList2.Cached = false;
            BinarySearchTree.Cached = false;
            AVLTree.Cached = false;
            BestList.Cached = false;
        }
    }
}
