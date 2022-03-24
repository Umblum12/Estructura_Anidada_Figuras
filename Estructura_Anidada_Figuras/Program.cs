Figuras[] age = new Figuras[5];
age[0].Nombre = "Triangulo";
age[0].Color = "Rojo";
age[0].TDL.Total_de_Lados = 3;

age[1].Nombre = "Circulo";
age[1].Color = "Azul";
age[1].TDL.Total_de_Lados = 1;

age[2].Nombre = "Trapecio";
age[2].Color = "Morado";
age[2].TDL.Total_de_Lados = 4;

age[3].Nombre = "Cuadrado";
age[3].Color = "Amarillo";
age[3].TDL.Total_de_Lados = 4;

age[4].Nombre = "Rombo";
age[4].Color = "Rosa";
age[4].TDL.Total_de_Lados = 4;

Console.WriteLine("La Figura es: {0}, su Color es: {1}, EL Total de lados es: {2}", age[0].Nombre, age[0].Color, age[0].TDL.Total_de_Lados);
Console.WriteLine("La Figura es: {0}, su Color es: {1}, EL Total de lados es: {2}", age[1].Nombre, age[1].Color, age[1].TDL.Total_de_Lados);
Console.WriteLine("La Figura es: {0}, su Color es: {1}, EL Total de lados es: {2}", age[2].Nombre, age[2].Color, age[2].TDL.Total_de_Lados);
Console.WriteLine("La Figura es: {0}, su Color es: {1}, EL Total de lados es: {2}", age[3].Nombre, age[3].Color, age[3].TDL.Total_de_Lados);
Console.WriteLine("La Figura es: {0}, su Color es: {1}, EL Total de lados es: {2}", age[4].Nombre, age[4].Color, age[4].TDL.Total_de_Lados);
Console.ReadKey(true);
struct Figuras
{
    public string Nombre;
    public string Color;
    public TL TDL;
}
struct TL
{
    public int Total_de_Lados;
}