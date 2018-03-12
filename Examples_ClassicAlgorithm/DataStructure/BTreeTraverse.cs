using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure
{
    /// <summary>
    ////使用递归思想，栈
    /// </summary>
    public class BTreeTraverse
    {

        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(BTreeNode root)
        {
            if (root == null) return;
            //Access Data
            Console.WriteLine(root.data);
            //递归左和右
            PreOrder(root.LChild);
            PreOrder(root.RChild);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        public void MidOrder(BTreeNode root)
        {
            if (root == null) return;
            //Access Data
            PreOrder(root.LChild);
            Console.WriteLine(root.data);
            PreOrder(root.RChild);
        }

        public void AfterOrder(BTreeNode root)
        {
            if (root == null) return;
            //Access Data
            PreOrder(root.LChild);
            PreOrder(root.RChild);
            Console.WriteLine(root.data);
        }

        /// <summary>
        /// 顺序遍历
        /// 
        /// </summary>
        /// <param name="root"></param>
        public void NaturalOrder(BTreeNode root)
        {
            //使用队列
            Queue<BTreeNode> queue = new Queue<BTreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root.LChild);
            queue.Enqueue(root.RChild);


        }

    }
}
