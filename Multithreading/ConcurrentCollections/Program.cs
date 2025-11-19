using System.Collections.Concurrent;

List<string> wordTypes = new List<string>() { "apple", "banana", "orange" };
Random random = new Random();
List<string> words = new List<string>();

for (int i = 0; i < 1000; i++)
{
    words.Add(wordTypes[random.Next(0, wordTypes.Count)]);
}

ConcurrentDictionary<string, int> counts = new ConcurrentDictionary<string, int>();

Parallel.ForEach(words, word => counts.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1));

foreach (var pair in counts)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}