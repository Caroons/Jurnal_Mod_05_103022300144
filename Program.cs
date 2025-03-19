internal class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData<T>(T input)
    {
        dynamic? convert = input;

        storedData.Add(convert);
        inputDates.Add(DateTime.Now);    
    }

    public void PrintAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data1 berisi: "+ storedData[i] + ", " + "yang disimpan pada waktu " + inputDates[i].ToString());
        }
    }
}

﻿internal class PemrosesData
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

        SimpleDataBase<double?> simpleDB = new();
        simpleDB.AddNewData<double?>(12);
        simpleDB.AddNewData<double?>(34);
        simpleDB.AddNewData<double?>(56);
        simpleDB.PrintAllData();
    }
}