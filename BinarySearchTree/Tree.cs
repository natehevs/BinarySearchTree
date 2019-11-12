using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        public Node root;
        public void SearchForNumber()
        {

        }

        public void AddANumber(int value)
        {
            Node node = new Node(value);
            node.numberValue = value;
            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                Node presentNode = root;
                Node parent;
                while (true)
                {
                    parent = presentNode;
                    if(value <= presentNode.numberValue)
                    {
                        presentNode = presentNode.left;
                        if(presentNode == null)
                        {
                            parent.left = node;
                            return;
                        }
                    }
                }
            }
            //check if root is null, if it is then assign this node to it.
            //if its not null then check if 

            //if node.numberValue is greater than root numberValue determine direction
            //check if node.right/left is null then place node there.
            //add all these into a loop
        }
        
    }
}
