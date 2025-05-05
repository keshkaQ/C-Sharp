//public class Tree <T> where T:IComparable<T>
//{
//    private class Node <T>
//    {
//        public T Value { get; set; }
//        public Node<T> Left { get; set; }
//        public Node<T> Right { get; set; }
//    }

//    private Node<T> _root;
//    public Tree(T root)
//    {
//        _root = new Node<T>
//        {
//            Value = root
//        };
//    }
//    public void Add(T value)
//    {
//        AddWithRoot(value, _root);
//        var currentRoot = _root;
//        T parent = default;

//        while (currentRoot.Left != null && currentRoot.Right != null)
//        {
//            if (currentRoot.Value.CompareTo(value) >= 0)
//            {
//                currentRoot = currentRoot.Right;
//                parent = currentRoot.Value;
//            }
//            else
//            {
//                currentRoot = currentRoot.Left;
//                parent = currentRoot.Value;
//            }
//        }
//        if (parent.CompareTo(value) >= 0)
//        {
//            _root.Right = new Node<T>
//            {
//                Value = value
//            };
//        }
//        else
//        {
//            _root.Left = new Node<T>
//            {
//                Value = value
//            };
//        }
//    }
//    private void AddWithRoot(T value, Node<T> node)
//    {
//        if (_root.Value.CompareTo(value) >= 0)
//        {
//            if (_root.Right == null)
//            {
//                _root.Right = new Node<T>
//                {
//                    Value = value
//                };
//            }
//            else
//            {
//                AddWithRoot(value, _root.Left);
//            }

//        }
//        else
//        {
//            if (_root.Left == null)
//            {
//                _root.Left = new Node<T>
//                {
//                    Value = value
//                };
//            }
//            else
//            {
//                AddWithRoot(value, _root.Left);
//            }

//        }
//    }
//}