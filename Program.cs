using Tarea1;

Automovil auto = new Automovil(12345, "Toyota", "Supra", 12000, 600000);
Console.WriteLine("Caracteristicas del auto: " + auto.ToString());
AutomovilDeLujo automovilDeLujo = new AutomovilDeLujo(123, "Nissan", "GTR", 0, 100000000);
automovilDeLujo.agregarAireAcondicionado();
automovilDeLujo.agregarVentanaElectrica();
Console.WriteLine("Caracteristicas del auto de lujo: " + automovilDeLujo.ToString());

Console.WriteLine("-------Tarea 1 SALIDA--------");
Concesionaria concesionaria = new Concesionaria(4);
Automovil auto1 = new Automovil(12345, "Toyota1", "Supra", 12000, 600000);
Automovil auto2 = new Automovil(12346, "Toyota2", "Supra", 12000, 600000);
Automovil auto3 = new Automovil(12347, "Toyota3", "Supra", 12000, 600000);
Automovil auto4 = new Automovil(12348, "Toyota4", "Supra", 12000, 600000);

Console.WriteLine("-------Agrega autos--------");

concesionaria.agregarAuto(auto1);
concesionaria.agregarAuto(auto2);
concesionaria.agregarAuto(auto3);
concesionaria.agregarAuto(auto4);

Console.WriteLine("-------Muestra auto1--------");

concesionaria.mostrarAuto(auto1);

Console.WriteLine("-------Muestra autos--------");

concesionaria.mostrarAutos();

Console.WriteLine("-------Elimina auto4--------");
/*
concesionaria.eliminarAuto(auto4);
concesionaria.mostrarAutos();*/

Console.WriteLine("-------Vacia la concesionaria--------");

concesionaria.vaciarConcesionaria();


