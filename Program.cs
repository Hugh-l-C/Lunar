using MoonLander;

    Lander moonLander = new Lander(1.625, 1000);
    Simulation simulator = new Simulation();
    simulator.MoonLander = moonLander;
    simulator.Run ();
    Console.ReadKey();
