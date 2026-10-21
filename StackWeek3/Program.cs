
List<string> myStack = [];
List<string> undoStack = [];

void Type(string text)
{
    if (myStack.Count == 3)
    {
        myStack.RemoveAt(0);
        myStack.Add(text);
        Console.WriteLine($"Dropped bottom, Typed [{text}]");
        return;
    }
    Console.WriteLine($"Typed [{text}] ");
    myStack.Add(text);
}

void Undo()
{

    if (myStack.Count != 0)
    {

        var text = myStack[myStack.Count - 1];

        // move item to undo stack
        undoStack.Add(myStack[myStack.Count-1]);

        // remove item
        myStack.RemoveAt(myStack.Count - 1);
        Console.WriteLine($"Undid [{text}] ");
        return;
    }

    Console.WriteLine("Stack Empty ");
}

void Redo()
{
    if (undoStack.Count == 0)
    {
        Console.WriteLine("NOTHING HERE BROTHER");
        return;
    }
    myStack.Add(undoStack[undoStack.Count-1]);
    Console.WriteLine($"Redid [{undoStack[undoStack.Count-1]}]");

    // clear history
    undoStack.Clear();
}

Type("foo");
Type("bar");
Type("stranger");
Type("things");

Undo();
Undo();
Redo();
Redo();
Undo();
Undo();

Type("Superman");
Undo();
