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

internal class Program
{
    public static void Main(string[] args) {
        SimpleDataBase<double?> simpleDB = new();
        simpleDB.AddNewData<double?>(12);
        simpleDB.AddNewData<double?>(34);
        simpleDB.AddNewData<double?>(56);
        simpleDB.PrintAllData();
    }
}