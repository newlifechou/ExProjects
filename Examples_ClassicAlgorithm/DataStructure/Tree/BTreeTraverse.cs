﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.Tree
{
    /// <summary>
    ////使用递归思想，栈
    /// </summary>
    public class BTreeTraverse
    {

        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(BTreeNode root)
        {
            if (root == null) return;
            //Access Data
            Console.Write(root.Data);
            //递归左和右
            PreOrder(root.LeftChild);
            PreOrder(root.RightChild);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(BTreeNode root)
        {
            if (root == null) return;
            //Access Data
            PreOrder(root.LeftChild);
            Console.Write(root.Data);
            PreOrder(root.RightChild);
        }

        public void PostOrder(BTreeNode root)
        {
            if (root == null) return;
            //Access Data
            PreOrder(root.LeftChild);
            PreOrder(root.RightChild);
            Console.Write(root.Data);
        }

        /// <summary>
        /// 顺序遍历
        /// 
        /// </summary>
        /// <param name="root"></param>
        public void SequenceOrder(BTreeNode root)
        {
            //使用队列
            Queue<BTreeNode> queue = new Queue<BTreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root.LeftChild);
            queue.Enqueue(root.RightChild);


        }

    }
}
