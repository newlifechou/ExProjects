using Examples_ClassicAlgorithm.DataStructure.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.TEST
{
    static class TestBTree
    {
        public static void TestBTreeCreate()
        {
            BTreeNode firstRoot = null;
            new BTreeCreator().PreOrderCreate(out firstRoot);
            
            Console.WriteLine("## PreOrderTraverse");
            new BTreeTraverse().PreOrder(firstRoot);
        }



        public static void TestPreOrderTraverse()
        {
            BTreeNode root = new BTreeNode();
            root.Data = "A";
            BTreeNode B = new BTreeNode("B");
            root.LeftChild = B;
            root.RightChild = new BTreeNode("C");
            B.LeftChild = new BTreeNode("D");
            B.RightChild = new BTreeNode("E");

            Console.WriteLine("##PreOrder Traverse");
            Console.WriteLine("##Should be ABDEC");
            BTreeTraverse traverse = new BTreeTraverse();
            traverse.PreOrder(root);
        }

        public static void TestPreOrderCreateWithClue()
        {
            BTreeNodeWithClue A = new BTreeNodeWithClue();
            A.Data = "A";
            BTreeNodeWithClue B = new BTreeNodeWithClue();
            B.Data = "B";
            BTreeNodeWithClue C = new BTreeNodeWithClue();
            C.Data = "C";
            BTreeNodeWithClue D = new BTreeNodeWithClue();
            D.Data = "D";
            BTreeNodeWithClue E = new BTreeNodeWithClue();
            E.Data = "E";

            A.LeftChild = B;
            A.RightChild = C;
            B.LeftChild = D;
            B.RightChild = E;

        }

    }
}
