//classe: definir un tipo de referencia - contiene miembros 

using Clases;
using Clases.Matematicas;

var carro1 = new Carro();

carro1.Marca = "Nisan";
ModificarMarca(carro1);
Console.WriteLine(carro1.Marca);

var carro2 = new Carro();
carro2.Marca = "toyota";
carro2.Año = 1989;


Console.WriteLine(carro2.Marca + carro2.velocidad);

void ModificarMarca(Carro carro)
{
    carro.Marca += "2";
}

//carro1.Acelerar();
carro1.Detener();
Console.WriteLine("Acelerar velocidad: " + carro1.velocidad);

//condtructores
var carro3 = new Carro();
Console.WriteLine(carro3.Marca);


var calculadora = new calculadora();
var resultadoD3 = calculadora.CalcularDuploTriplo(5);
Console.WriteLine(resultadoD3.Triplo + resultadoD3.Duplo + resultadoD3.Valor);

//ejemplo sin descontructor

//miembro esaticos 

//var carro5 = new Carro();
//Carro carro6 = new Carro();
//var carro7 = new Carro();
//var carro8 = new Carro();

Console.WriteLine($"han sido instanciados {Carro.ConteonInstancias}");

//meotodos de extencion

var mensaje = "hola rafa ";
var cantidadPalabras = mensaje.ContarPalabras();
Console.WriteLine(cantidadPalabras);

//patrones de propiedad - identificar

var apellido = "morales3";

if(apellido is { Length: 7 })
{
    Console.WriteLine("la longitud de string es 7");
}
else
{
    Console.WriteLine("no es 7");
}

//patrones de propiedades ejemplo 2

var carro9 = new Carro("toyota");
carro9.Año = 2010;

if (carro9 is { Marca: "toyota" or  "nisamm", Año: > 2010 })
{
    Console.WriteLine("carrazo");
}
else
{
    Console.WriteLine("ya esta viejo tu carro");
}

//tipo anonimo
var persona = new { Nombre = "rafa" };
//no se puede editat las propiedades de tipo anonimo son de solo lectura

//Namepes y using

var calculadora2 = new Clases.Matematicas.Calculadora();
var res = calculadora2.CalculaPI();
Console.WriteLine(res);

var calculadora23 = new Calculadora();
calculadora23.CalculaPI();

var PuntOa = new Punto(3, 4);

//records
var persona1 = new Persona()
{
    Nombre = "Rafa", Apellido = "morales"
};

var persona2 = new Persona()
{
    Nombre = "Rafa",
    Apellido = "morales"
};

var igualdad = persona1 == persona2;

Console.WriteLine($"son igualers los record: {igualdad}");

//elvis
int[]? nuneros = { 1, 2 };
nuneros = null;
Console.WriteLine(nuneros?.Length);

