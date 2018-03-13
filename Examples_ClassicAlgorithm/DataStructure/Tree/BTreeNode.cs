using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    /// <summary>
    /// 二叉树节点
    /// 使用int类型作为简化
    /// </summary>
    public class BTreeNode
    {
        public BTreeNode()
        {

        }

        public BTreeNode(string data)
        {
            this.Data = data;
            this.LeftChild = null;
            this.RightChild = null;
        }

        public BTreeNode(string data,BTreeNode left,BTreeNode right)
        {
            this.Data = data;
            this.LeftChild = left;
            this.RightChild = right;
        }
        public string Data;
        public BTreeNode LeftChild { get; set; }
        public BTreeNode RightChild { get; set; }
    }
}
