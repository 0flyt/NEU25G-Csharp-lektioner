internal class Program
{

    private static HttpClient client = new HttpClient();
    private static async Task Main(string[] args)
    {

        Console.WriteLine("Program start.");
        var myTask = Download();
        Console.WriteLine("Main continues ...");

        for (int i = 0; i < 500; i++)
        {
            await Task.Delay(10);
            Console.Write($"{i}, ");
        }

        int dataLength = await myTask;

        Console.WriteLine($"Got {dataLength} chars of data.");
        Console.WriteLine("Program end.");
    }

    private static async Task<int> Download()
    {
        Task<string> download = client.GetStringAsync("http://google.com");

        Console.WriteLine("Download started ...");

        string data = await download;

        Console.WriteLine("Download complete!");

        await Task.Delay(1000);

        Console.WriteLine("Completed unnecessary delay in Download!");

        Console.WriteLine("Start CPU-bound operation asyncronously");

        await Task.Run(() =>
        {
            for (int i = 0; i < 2_000_000_000; i++) ;
        });


        Console.WriteLine("CPU-bound operation ended.");

        return data.Length;
    }
}