using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    public class BTreeNodeWithClue
    {
        public BTreeNodeWithClue()
        {
            IsLeft = true;
            IsRight = true;
        }
        public string Data;
        public BTreeNodeWithClue LeftChild;
        public bool IsLeft;
        public BTreeNodeWithClue RightChild;
        public bool IsRight;
    }
}
