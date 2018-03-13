using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure
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
        public BTreeNode(string data,BTreeNode left,BTreeNode right)
        {
            this.data = data;
            this.LChild = left;
            this.RChild = right;
        }
        public string data;
        public BTreeNode LChild { get; set; }
        public BTreeNode RChild { get; set; }
    }
}
