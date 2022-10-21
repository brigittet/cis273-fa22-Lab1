using System.Collections.Generic;

namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");
    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        // are the first and last items the same?
        // if so, move toward the middle
        var frontNode = linkedList.First;
        var endNode = linkedList.Last;
        while ((frontNode == endNode) & (frontNode.Next != null) & (endNode.Previous != null))
        {
            frontNode = frontNode.Next;
            endNode = endNode.Previous;
        }

        if (frontNode.Value.Equals(endNode.Value) == false)
        {
            return false;
        }

        return true;
    }
}

