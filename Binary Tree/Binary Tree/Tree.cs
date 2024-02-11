
using System.Diagnostics.Contracts;

namespace Binary.Tree;

class Tree
{
    private Node root;
    public Tree()
    {
        root=null;
    }
    public void Insert(int value)
    {
        if(root==null)
        {
            root=new Node(value);
        }
        else
        {
            root.Insert(value);
        }
    }
    public bool Search(int value)
    {
        Node node = Search(root, value);
        if (node != null)
            return true;
        else
            return false;
    }
    public Node Search(Node current,int value)
    {
        if(value==current.Data)
        {
            return current;
        }
        else if(current!=null)
        {
            if(value>current.Data)
            {
                current=current.right;
                Search(current,value);
            }
            else if(value<current.Data)
            {
                current=current.left;
                Search(current,value);
            }
        }
        return null;
    }
    public void Delete(int value)
    {
        Delete(ref root,value);
    }
    private void Delete(ref Node current, int value)
    {
        if(current==null) return;
        if(value<current.Data)
        {
            Delete(ref current.left,value);
        }
        else if(value>current.Data)
        {
            Delete(ref current.right,value);
        }
        else if(current.right==null)
        {
            current=current.left;
        }
        else if(current.left==null)
        {
            current=current.right;
        }
        else
        {
            current.Data=DeleteSuccesor(ref current.right);
        }
    }
    private int DeleteSuccesor(ref Node current)
    {
        int succesor;
        if(current.left==null)
        {
            succesor=current.Data;
            current=current.right;
            return succesor;
        }
        return DeleteSuccesor(ref current.left);
    }
    public void Traverse(TraversalType traverse)
    {
        switch (traverse) 
        {
            case TraversalType.PreOrder:
                TraversePreorder(root);
                break;
            case TraversalType.InOrder:
                TraverseInorder (root);
                break;
            case TraversalType.PostOrder:
                TraversePostorder(root);
                break;
            default:
                Console.WriteLine("What a #@$@#@!");
                break;
        }
    }
    private void TraversePreorder(Node node)
    {
        if(node!=null)
        {
            System.Console.WriteLine(node.Data +"");
            TraversePreorder(node.left);
            TraversePreorder(node.right);
        }
    }
    private void TraverseInorder(Node node)
    {
        if(node!=null)
        {
            TraverseInorder(node.left);
            System.Console.WriteLine(node.Data +"");
            TraverseInorder(node.right);
        }
    }
    private void TraversePostorder(Node node)
    {
        if(node!=null)
        {
            TraversePostorder(node.left);
            TraversePostorder(node.right);
            System.Console.WriteLine(node.Data +"");
        }
    }
}