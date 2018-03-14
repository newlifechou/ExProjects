using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    /// <summary>
    /// BTree创建器
    /// </summary>
    public class BTreeCreator
    {
        /// <summary>
        /// PreOrderCreate
        /// </summary>
        /// <param name="root">这里必须使用out，否则new的会被销毁</param>
        public void PreOrderCreate(out BTreeNode root)
        {
            Console.WriteLine("Enter value:(#=empty)");
            string inputData = Console.ReadLine();
            if (inputData == "#")
            {
                root = null;
            }
            else
            {
                root = new BTreeNode();
                root.Data = inputData;
                Console.WriteLine("#Current Root is " + root.Data);
                Console.WriteLine("Left Son of " + root.Data);
                PreOrderCreate(out root.LeftChild);
                Console.WriteLine("Right Son of " + root.Data);
                PreOrderCreate(out root.RightChild);
            }

        }

        private BTreeNodeWithClue pre;
        /// <summary>
        ///Clue PreOrder BTree
        /// </summary>
        /// <param name="currentNode"></param>
        public void CluePreOrderBTree(ref BTreeNodeWithClue currentNode)
        {
            if (currentNode == null)
                return;
            //if there is no left child,left node points to previous
            if (currentNode.LeftChild == null)
            {
                currentNode.IsLeft = false;
                currentNode.LeftChild = pre;
            }
            //if there is no right child,right node points to next
            if (pre != null && pre.RightChild == null)
            {
                pre.IsRight = false;
                pre.RightChild = currentNode;
            }

            pre = currentNode;

            CluePreOrderBTree(ref currentNode.LeftChild);
            CluePreOrderBTree(ref currentNode.RightChild);
        }




    }
}
