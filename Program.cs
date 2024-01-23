//LinkedList <T> temellleri
//Tanımlama
// başlangıç il ordu olacak şekilde sahil boyunca yol haritası çıkarılacak
// trabzon ikinci olacak
// istanbul son il olacak

var sehirler = new LinkedList<string>();
sehirler.AddFirst("Ordu");
sehirler.AddFirst("Trabzon"); //artık ordu Last oldu
sehirler.AddLast("İstanbul");
sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
sehirler.AddBefore(sehirler.First.Next.Next,("Giresun"));
sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
sehirler.AddAfter(sehirler.Last.Previous,"Zonguldak");
sehirler.AddAfter(sehirler.Find("Zonguldak"),"Akçakoca");

// Trabzon çıkışlı güzergah
System.Console.WriteLine("Gidiş güzergahı");

foreach (string s in sehirler)
{
    System.Console.WriteLine(s);   
}

System.Console.WriteLine();
System.Console.WriteLine("Donüş güzergahı");
//Dönüş güzergahı

var donus = sehirler.Last;
while (donus!=null)
{
    System.Console.WriteLine(donus.Value);
    donus = donus.Previous;
}
