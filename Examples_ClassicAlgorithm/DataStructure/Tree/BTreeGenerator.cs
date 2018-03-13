using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure
{
    /// <summary>
    /// BTree创建器
    /// </summary>
    public class BTreeGenerator
    {
        public void Generate(BTreeNode node)
        {
            Console.WriteLine("Please enter value of BTree:(#=empty)");
            string inputStr = Console.ReadLine();

            if (inputStr =="#")
            {
                node = null;
            }
            else
            {
                node = new BTreeNode();
                node.data = inputStr;
                Generate(node.LChild);
                Generate(node.RChild);
            }

        }
    }
}
