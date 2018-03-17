using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    /// <summary>
    /// Parent 
    /// </summary>
    class TreeNode1
    {
        public string Data { get; set; }
        public TreeNode1 Parent { get; set; }
    }

    /// <summary>
    /// Son
    /// </summary>
    class TreeNode2
    {
        public string Data { get; set; }
        public TreeNode2 Son { get; set; }
    }

    /// <summary>
    /// Son and sliblings
    /// </summary>
    class TreeNode3
    {
        public string Data { get; set; }
        public TreeNode3 Son { get; set; }
        public TreeNode3 Sibling { get; set; }

    }

}
