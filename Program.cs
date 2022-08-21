Console.WriteLine("Bienvenido a Pizzas El Fercho.\nTipos de pizza\n\t1- Vegetariana\n\t2- No vegetariana\n");
Console.WriteLine("Introduce el número correspondiente al tipo de pizza que quieres:");
int  numero = int.Parse(Console.ReadLine());

if (numero == 1){
     Console.WriteLine("Ingredientes de pizzas vegetarianas\n\t 1- Pimiento\n\t2- Champiñones\n");
     Console.WriteLine("Introduce el ingrediente que deseas: ");
     int ingrediente = int.Parse(Console.ReadLine());
     Console.WriteLine("Pizza vegetariana con mozzarella, tomate y " + ingrediente);
    if (ingrediente == 1){
         Console.WriteLine("pimiento");
    }else{
        Console.WriteLine("Champiñones");}
}
else{
    Console.WriteLine("Ingredientes de pizzas no vegetarianas\n\t1- Peperoni\n\t2- Salami\n\t3- Pollo\n");
    Console.WriteLine("Introduce el ingrediente que deseas: ");
    int  ingrediente2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Pizza no vegetarina con mozarrella, tomate y "+ ingrediente2);

    if (ingrediente2 == 1){
        Console.WriteLine("peperoni");
    }
    if (ingrediente2 == 2){
        Console.WriteLine("Salami");
    }
    else{
        Console.WriteLine("Pollo");
    }
}