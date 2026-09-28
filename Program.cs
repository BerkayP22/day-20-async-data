static async Task<string> FetchAsync(string name, int delayMs)
{
    await Task.Delay(delayMs);
    return $"{name} hazır";
}

var stopwatch = System.Diagnostics.Stopwatch.StartNew();
var first = FetchAsync("Ürünler", 500);
var second = FetchAsync("Müşteriler", 700);
foreach (var result in await Task.WhenAll(first, second)) Console.WriteLine(result);
Console.WriteLine($"Geçen süre: {stopwatch.ElapsedMilliseconds} ms");
