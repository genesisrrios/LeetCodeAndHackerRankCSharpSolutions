using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class BTreeSolutions
    {
        private IList<int> TreeNodeList = new List<int>();
        private IList<IList<int>> LevelOrderNodeList = new List<IList<int>>();
        private bool IsFirstNode = true;
        public IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            //Not working yet.
            var nodes = new List<int>();
            if (root != default)
            {
                if (IsFirstNode)
                {
                    IsFirstNode = false;
                    LevelOrderNodeList.Add(new int[] { root.val });
                }

                if (root.left != default) nodes.Add(root.left.val);

                if (root.right != default) nodes.Add(root.right.val);

                if (nodes.Count > 0) LevelOrderNodeList.Add(nodes);

                if (root.left != default) LevelOrderTraversal(root.left);

                if (root.right != default) LevelOrderTraversal(root.right);
            }
            return LevelOrderNodeList;
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root != default)
            {
                TreeNodeList.Add(root.val);
                if (root.left != default)
                {
                    PreorderTraversal(root.left);
                }
                if (root.right != default)
                {
                    PreorderTraversal(root.right);
                }
            }
            return TreeNodeList;
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root != default)
            {
                if (root.left != default)
                {
                    InorderTraversal(root.left);
                }
                TreeNodeList.Add(root.val);
                if (root.right != default)
                {
                    InorderTraversal(root.right);
                }
            }
            return TreeNodeList;
        }
        public IList<int> PostOrderTraversal(TreeNode root)
        {
            if (root != default)
            {
                if (root.left != default)
                {
                    PostOrderTraversal(root.left);
                }
                if (root.right != default)
                {
                    PostOrderTraversal(root.right);
                }
                TreeNodeList.Add(root.val);
            }
            return TreeNodeList;
        }

        public TreeNode GetNode()
        {
            var node = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode
                    {
                        val = 4,
                        left = default,
                        right = default
                    },
                    right = default
                },
                right = new TreeNode
                {
                    val = 3,
                    right = new TreeNode
                    {
                        val = 5,
                        left = default,
                        right = default
                    },
                    left = default
                }
            };
            return node;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = default, TreeNode right = default)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
