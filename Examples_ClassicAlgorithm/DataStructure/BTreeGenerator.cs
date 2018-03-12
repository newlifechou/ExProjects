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
            Console.WriteLine("Please enter value of BTree:(-1=empty)");
            int inputValue;
            string inputStr = Console.ReadLine();
            int.TryParse(inputStr, out inputValue);

            if (inputValue == -1)
            {
                node = null;
            }
            else
            {
                node = new BTreeNode();
                node.data = inputValue;
                Generate(node.LChild);
                Generate(node.RChild);
            }

        }
    }
}
