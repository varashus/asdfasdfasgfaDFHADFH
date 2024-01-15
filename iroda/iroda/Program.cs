List<Iroda> lista = new();


using (var sr = new StreamReader(@"..\..\..\src\irodahaz.txt"))
{
    string header = sr.ReadLine();

    while (!sr.EndOfStream)
    {
        var line = sr.ReadLine();
        var iroda = new Iroda(line);
        lista.Add(iroda);

    }
}

foreach (var iroda in lista)
{
    Console.WriteLine(iroda.ToString());
    foreach (var item in iroda.Irodak)
    {

    }


}

var ketto = 0;
var negyedik = 0;
foreach (var iroda in lista)
{
    var elso = "";


    foreach (var item in iroda.Irodak)
    {
        elso = iroda.Irodak.Sum().ToString();
        
    }
    Console.Write($"{elso} ");
    ketto = elso.Max();

}
Console.WriteLine();
Console.WriteLine(negyedik);
Console.WriteLine(ketto);





