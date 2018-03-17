using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    public enum NodeType
    {
        Thread,//线索
        Link//子
    }
    public class BTreeNodeWithClue
    {
        public BTreeNodeWithClue()
        {
            LeftType = NodeType.Link;
            RightType =NodeType.Link;
        }
        public string Data;
        public BTreeNodeWithClue LeftChild;
        public NodeType LeftType;
        public BTreeNodeWithClue RightChild;
        public NodeType RightType;
    }
}
