static void Menu()
{


    Console.WriteLine(
        @"
        Bem vindo ao seu Cronômetro!

        Digite o número correspondente a qual ação deseja executar:

        1 - Cronômetro infinito (Em breve)
        2 - Cronometro de tempo específico
        3 - Sair"
    );

    string option = Console.ReadLine();

    switch (option)
    {
        case "2":
            {
                Console.Clear();
                Console.WriteLine("Quantos minutos deseja cronometrar?");
                int selectedMin = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Quantos segundos deseja cronometrar?");
                int selectedSec = int.Parse(Console.ReadLine());

                StartSpecific(selectedMin, selectedSec);

                Console.WriteLine("Tempo encerrado!");

                break;
            }
        case "3":
            {
                Console.Clear();
                Console.WriteLine("Programa encerrado.");

                break;
            }

        default:
            {
                Console.WriteLine("Comando inválido! Aguarde 5 segundos e tente novamente.");
                Thread.Sleep(5000);
                Menu();

                break;

            }
    }
}

static void StartSpecific(int min, int sec)
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

Menu();