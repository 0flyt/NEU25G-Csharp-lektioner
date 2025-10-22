

for (int i = 0; i < 1000; i++)
{


    Count();
}


static void Count()
{
    object myLock = new object();
    int count = 0;

    var taskA = Task.Run(DoCount);
    var taskB = Task.Run(DoCount);
    var taskC = Task.Run(DoCount);
    var taskD = Task.Run(DoCount);


    Task.WaitAll(taskA, taskB, taskC, taskD);
    Console.WriteLine(count);

    void DoCount()
    {
        for (int i = 0; i < 10000; i++)
        {
            // lock låser operationen så att den inte kan avbrytas mitt i.
            lock (myLock)
            {
                int temp = count; // count 0
                temp = temp + 1; // temp 1
                // Utan lock skulle denna operation avbrytas ibland och fortsätta i taskB. När taskB sedan avbryts och börjar här igen så blir count 1 igen.
                count = temp; // count 1
            }
        }
    }
}