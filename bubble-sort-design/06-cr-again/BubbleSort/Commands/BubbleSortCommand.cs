namespace BubbleSort.Commands;

using Microsoft.AspNetCore.Mvc;
using BubbleSort.Comparer;
using System.Text.Json;
using System.Data.SqlClient;

public abstract class BubbleSortCommand<T> : ISorter<T>
{
    private readonly IComparerFactory _comparerFactory;

    public BubbleSortCommand(IComparerFactory comparerFactory)
    {
        _comparerFactory = comparerFactory;
    }

    public T[] Sort(T[] input)
    {
        var comparer = _comparerFactory.Create<T>();

        var inputLength = input.Length;

        for (var i = 0; i < inputLength - 1; i++)
        {
            for (var j = 0; j < inputLength - i - 1; j++)
            {
                if (comparer.Compare(input[j], input[j + 1]) > 0)
                {
                    input.Swap(j, j + 1);
                }
            }
        }

        SaveResult(input);

        return input;
    }

    private void SaveResult(T[] input)
    {
        var jsonString = JsonSerializer.Serialize(input);

        using var conn = new SqlConnection("");

        using var cmd = conn.CreateCommand();

        cmd.CommandText = $"INSERT INTO SortResults(SortedResult) VALUES ({jsonString})";

        cmd.ExecuteNonQuery();
    }
}
