using QueueWeek3;

List<QueuePriority> queue = [];
void Enqueue(char element, int p)
{
    Console.WriteLine($"Queued {element} with priority {p}");
    queue.Add(new QueuePriority(lttr:element, p:p));
}

void Process()
{
    // loop ? hash ?
    QueuePriority bigPriority = new QueuePriority('z', -1);
    for (int i = 0; i < queue.Count; i++)
    {
        if (queue[i].priority > bigPriority.priority)
        {
            bigPriority = queue[i];
        }
    }

    Console.WriteLine($"Processed {bigPriority.letter}");
    queue.Remove(bigPriority);

}


Enqueue('A', 1);
Enqueue('D', 50);
Enqueue('B', 5);
Enqueue('C', 5);

Process();
Process();
Process();