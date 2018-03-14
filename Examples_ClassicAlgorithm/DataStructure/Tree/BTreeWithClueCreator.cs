using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    class BTreeWithClueCreator
    {



        public void ClueInOrderBTree(ref BTreeNodeWithClue root)
        {
            if (root == null)
                return;
            ClueInOrderBTree(ref root.LeftChild);
            if(root.LeftChild==null)
            {
                root.LeftType = NodeType.Thread;
                root.LeftChild = pre;
            }

            if (pre!=null&&pre.RightChild == null)
            {
                pre.RightChild = root;
                pre.RightType = NodeType.Thread;
            }
            pre = root;
            ClueInOrderBTree(ref root.RightChild);
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
                currentNode.LeftType = NodeType.Thread;
                currentNode.LeftChild = pre;
            }
            //if there is no right child,right node points to next
            if (pre != null && pre.RightChild == null)
            {
                pre.RightType = NodeType.Thread;
                pre.RightChild = currentNode;
            }

            pre = currentNode;//keep last node
            //check whether the tag indicate child or link,if child go to recursive
            if (currentNode.LeftType== NodeType.Link)
                CluePreOrderBTree(ref currentNode.LeftChild);
            if (currentNode.RightType == NodeType.Link)
                CluePreOrderBTree(ref currentNode.RightChild);
        }

        public void PreOrderTraverse(ref BTreeNodeWithClue rootwithClue)
        {
            if (rootwithClue == null)
                return;

            BTreeNodeWithClue prev = rootwithClue;
            while (pre != null)
            {
                //如果左边的孩子不为空且标记为前继
                while (pre.LeftChild != null && pre.LeftType== NodeType.Link)
                {
                    Console.Write(pre.Data);
                    pre = pre.LeftChild;
                }

                Console.Write(pre.Data);

                //if there is a thread  ,visit right node
                if (pre.LeftType == NodeType.Thread)
                {
                    pre = pre.RightChild;
                }
                //iterate right nodes
                while (pre != null)
                {
                    //if there is a left node, visit it
                    if (pre.LeftChild != null && pre.LeftType == NodeType.Link)
                    {
                        break;
                    }
                    Console.Write(pre.Data);
                    pre = pre.RightChild;
                }

            }

        }

        public void InOrderTraverse(ref BTreeNodeWithClue root)
        {
            if (root == null)
                return;
            BTreeNodeWithClue pCursor = root;
            while (pCursor != null)
            {
                //look for the left node
                while (pCursor.LeftType == NodeType.Link)
                {
                    pCursor = pCursor.LeftChild;
                }

                Console.Write(pCursor.Data);
                //look for
                while (pCursor != null && pCursor.RightType == NodeType.Thread)
                {
                    pCursor = pCursor.RightChild;
                    Console.Write(pCursor.Data);
                }
                pCursor = pCursor.RightChild;

            }
        }

    }
}
