static void Start(int min, int sec)
{
    int startSec = -1;
    int startMin = 0;
    bool stopMin = false;
    bool stopSec = false;

    if (sec == 0)
        stopSec = true;
    if (min == 0)
        stopMin = true;

    while (stopMin == false || stopSec == false)
    {
        Console.Clear();
        startSec++;

        if (startSec == 60)
        {
            startSec = 0;
            startMin++;

            if (startMin == min)
                stopMin = true;
        }

        if (startSec == sec)
            stopSec = true;
        else
            stopSec = false;

        if (startSec < 10)
            Console.WriteLine($"{startMin}:0{startSec}");
        else
            Console.WriteLine($"{startMin}:{startSec}");

        Thread.Sleep(1000);
    }
}

Start(0, 13);