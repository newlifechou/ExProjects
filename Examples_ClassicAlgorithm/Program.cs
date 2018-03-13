using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples_ClassicAlgorithm.DataStructure.Tree;

namespace Examples_ClassicAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            BTreeNode root = new BTreeNode();
            root.Data = "A";
            BTreeNode B = new BTreeNode("B", null, null);
            root.LeftChild = B;
            root.RightChild = new BTreeNode("C", null, null);
            B.LeftChild = new BTreeNode("D", null, null);
            B.RightChild = new BTreeNode("E", null, null);
            //BTreeCreator creator = new BTreeCreator();
            //creator.PreOrderCreate(root);


            Console.WriteLine("## Traverse");
            BTreeTraverse traverse = new BTreeTraverse();
            traverse.PreOrder(root);

            Console.Read();
        }
    }
}
