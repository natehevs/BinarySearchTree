using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int numberValue;
        public Node left;
        public Node right;
        public Node(int value)
        {
            this.numberValue = value;
            left = null;
            right = null;
        }

        
    }
}
