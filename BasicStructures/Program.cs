
using BasicStructures;
using System.Diagnostics;

static class Program
{
    public static void Main()
    {
       // Debag();
    }

    static void Debag()
    {
        List<int> testData = new List<int>();
        int i = 0;
        while ((i += 1000) < 20000)
        {
            testData.Add(i);
        }
        IArray<int> array;

        Console.WriteLine(string.Format("Size |{0} |{1} |{2}  |{3} |{4}",
            typeof(SingleArray<int>).Name,
            typeof(VectorArray<int>).Name,
            typeof(FactorArray<int>).Name,
            typeof(MatrixArray<int>).Name,
            typeof(Wrap<int>).Name));

        Console.WriteLine("----------------------------------------------------------------------------------------");
        foreach (var item in testData)
        {
            array = new SingleArray<int>();
            int count = 0;
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            while (++count < item)
            {
                array.Add(count, count);
            }
            sw1.Stop();

            array = new VectorArray<int>();
            count = 0;
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            while (++count < item)
            {
                array.Add(count, count);
            }
            sw2.Stop();

            array = new FactorArray<int>();
            count = 0;
            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            while (++count < item)
            {
                array.Add(count, count);
            }
            sw3.Stop();

            array = new MatrixArray<int>();
            count = 0;
            Stopwatch swMatrix = new Stopwatch();
            swMatrix.Start();
            while (++count < item)
            {
                array.Add(count, count);
            }
            swMatrix.Stop();

            array = new Wrap<int>();
            count = 0;
            Stopwatch swWrap = new Stopwatch();
            swWrap.Start();
            while (++count < item)
            {
                array.Add(count, count);
            }
            swWrap.Stop();

            Console.WriteLine(string.Format("{0}  |{1} ms      {2} ms      {3} ms     {4} ms     {5} ms",
                item,
                sw1.Elapsed.TotalMilliseconds.ToString(),
                sw2.Elapsed.TotalMilliseconds.ToString(),
                sw3.Elapsed.TotalMilliseconds.ToString(),
                swMatrix.Elapsed.TotalMilliseconds.ToString(),
                swWrap.Elapsed.TotalMilliseconds.ToString())
                );
        }
    }
}
