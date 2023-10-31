//tamrin shomare 6 --donbale mosalati--  amir mahdi hosein njad
do
{
    Console.Write("adad N ra vared konid = ");

    int N =Convert.ToInt32(Console.ReadLine());

    Console.Write("adad M ra vared konid = ");

    int M =Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("donbale mosalasaty bein N M");

    for (int i = N; i <= M; i++)
    {
        long S = i * (i + 1) / 2;
        Console.WriteLine(S);
    }

    Console.WriteLine("mikhay dobare anzamesh bedi ?y or n");
} while (Console.ReadLine() == "y");
Console.WriteLine("----payan----");
