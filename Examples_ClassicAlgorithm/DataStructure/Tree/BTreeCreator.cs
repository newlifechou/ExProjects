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
        public void PreOrderCreate(BTreeNode root)
        {
            Console.WriteLine("Please enter value of BTree:(#=empty)");
            string inputData = Console.ReadLine();
            if (inputData == "#")
            {
                root = null;
            }
            else
            {
                if (root == null)
                {
                    root = new BTreeNode();
                }
                root.Data = inputData;
                Console.WriteLine("#Current Root is " + root.Data);
                Console.WriteLine("Left Son of " + root.Data);
                PreOrderCreate(root.LeftChild);
                Console.WriteLine("Right Son of " + root.Data);
                PreOrderCreate(root.RightChild);
            }

        }
    }
}
