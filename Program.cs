internal class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T? num1, T? num2, T num3)
    {
        dynamic? temp1 = num1;
        dynamic? temp2 = num2;
        dynamic? temp3 = num3;

        dynamic? largest = temp1;

        if (temp2 > largest)
        {
            largest = temp2;
        }
        
        if (temp3 > largest)
        {
            largest = temp3;
        }

        return largest!;
    }
}
internal class Program
{
    public static void Main(string[] args)
    {
        PemrosesData pemroses = new PemrosesData();
        Console.WriteLine(pemroses.DapatkanNilaiTerbesar<double>(1, 2, 3));
    }
}