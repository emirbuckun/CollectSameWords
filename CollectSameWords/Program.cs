namespace CollectSameWords
{
  internal class Program
  {
    private static void Main()
    {
      try
      {
        Console.WriteLine("Please enter an input: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
          SortedDictionary<string, int> dict = new();
          string[] stringArray = input.Split(" ");

          foreach (string item in stringArray)
          {
            if (dict.ContainsKey(item))
              dict[item] = dict[item] + 1;
            else
              dict.Add(item, 1);
          }

          PrintDictionary(dict);
        }
        else throw new Exception("Incorrect input!");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Exception occurred: {ex.Message}");
      }
    }

    private static void PrintDictionary(IDictionary<string, int> dict)
    {
      foreach (var kvp in dict)
        Console.WriteLine($"Word = {kvp.Key}, Count = {kvp.Value}");
    }
  }
}