using LinkedListWeek3;

// CustomNode checkIsTail(CustomNode checkThisNode)
// {
//     if (checkThisNode.tail is not null)
//     {
//         return checkIsTail(checkThisNode.tail);
//     }

//     return checkThisNode;
// }

CustomNode lookForPosition(int val, CustomNode theNode)
{
    // Console.WriteLine($"INI VAL - {val}, INI CUSTOM NODE YG DICEK - {theNode.myNum}");
    if (theNode.myNum < val)
    {
        if (theNode.tail is null)
        {
            // insert after this node
            return theNode;
        }
        return lookForPosition(val, theNode.tail);
    }
    // insert after this node
    return theNode.prev!;
}

void newAppended(int val)
{

    CustomNode newNode = new CustomNode();
    if (CustomNode.head is null)
    {
        CustomNode.head = new CustomNode { myNum = val };
        Console.WriteLine($"Appended [{val}]");
        return;
    }



    if (CustomNode.head.myNum > val)
    {

        int tempContainer = CustomNode.head.myNum;
        
        newNode.myNum = CustomNode.head.myNum;
        // newNode.tail = CustomNode.head.tail;
        // newNode.prev = CustomNode.head;


        CustomNode.head.myNum = val;
        CustomNode.head.tail = newNode;
        newNode.prev = CustomNode.head;


       
        Console.WriteLine($"Appended [{val}]");
        return;
    }

    if (CustomNode.head.tail is null)
    {
        CustomNode.head.tail = new CustomNode { myNum = val, prev = CustomNode.head };
        Console.WriteLine($"Appended [{val}]");
        return;
    }

    CustomNode insertAfterThisNode = lookForPosition(val, CustomNode.head.tail);
    CustomNode afterNewNode = new CustomNode();
    newNode.myNum  = val;
    if (insertAfterThisNode.tail is not null)
    {
        afterNewNode = insertAfterThisNode.tail;
        newNode.tail = afterNewNode;
        afterNewNode.prev = newNode;
    }


    
    insertAfterThisNode.tail = newNode;
    newNode.prev = insertAfterThisNode;
    Console.WriteLine($"Appended [{val}]");
}




void Print()
{
    Console.Write("Sequence : ");
    PrintHelper(CustomNode.head);
    Console.WriteLine("");
}

void PrintHelper(CustomNode printThisNode)
{
    Console.Write($"{printThisNode.myNum}");
    if (printThisNode.tail is not null)
    {
        Console.Write(" -> ");
        PrintHelper(printThisNode.tail);
    }
    Console.WriteLine("");
}



newAppended(5);
newAppended(2);
// Appended(245);
// Appended(5);
newAppended(6);
// Appended(7);
newAppended(3);
Print();

// PrintReverse();