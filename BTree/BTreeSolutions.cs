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
            var nodes = new List<int>();
            if (root != default)
            {
                if (IsFirstNode)
                {
                    IsFirstNode = false;
                    LevelOrderNodeList.Add(new int[] { root.val });
                }

                if (root.left != default)
                {
                    nodes.Add(root.left.val);
                }
                if (root.right != default)
                {
                    nodes.Add(root.right.val);
                }
                if (root.right != default || root.left != default)
                {
                    LevelOrderNodeList.Add(nodes);
                }
                if (root.left != default)
                {
                    LevelOrderTraversal(root.left);
                }
                if (root.right != default)
                {
                    LevelOrderTraversal(root.right);
                }
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
