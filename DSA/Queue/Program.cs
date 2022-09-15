Queue.Queue<int> queue = new Queue.Queue<int>(5);
Util.WriteDebug($"Add item 4");
queue.Enqueue(4);
Util.WriteDebug($"Add item 5");
queue.Enqueue(5);
Util.WriteDebug($"Add item 6");
queue.Enqueue(6);
Util.WriteDebug($"Add item 7");
queue.Enqueue(7);
Util.WriteDebug($"Add item 8");
queue.Enqueue(8);

queue.Print();

Util.WriteDebug($"Dequeue:{queue.Dequeue()}");

Util.WriteDebug($"Peak:{queue.Peek()}");

Util.WriteDebug($"Dequeue:{queue.Dequeue()}");
Util.WriteDebug($"Dequeue:{queue.Dequeue()}");
Util.WriteDebug($"Dequeue:{queue.Dequeue()}");

queue.Print();