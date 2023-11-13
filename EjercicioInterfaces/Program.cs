

using EjercicioInterfaces;

Vertebrado vert = new Vertebrado();
Console.WriteLine("Animales Vertebrados");
vert.nombre = "Gato";
vert.color = "Negro";
vert.tamano = "Mediano";
vert.familia = "Angora";
vert.tipo = "Mascota";
vert.tienepatas = "Si" ;
vert.numeropatas = 4;
vert.esdomestico = true;
vert.imprimir1();
vert.imprimirInformacion(); 
vert.imprimirValidar();
Console.WriteLine("");  
Invertebrado inver = new Invertebrado();
Console.WriteLine("Animales Invertebrados");
inver.nombre = "gusano";
inver.color = "Gris";
inver.tamano = "Pequeño";
inver.familia = "Insecto";
inver.tipo = "Salvaje";
inver.tienepatas = "NO";
inver.numeropatas = 0;
inver.esdomestico = false;
inver.imprimir1();
inver.imprimirInformacion();
inver.imprimirValidar();
