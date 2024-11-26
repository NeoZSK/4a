using System.Collections;

namespace krt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zad 1
            int[] testResults = new int[240];
            for (int i = 0; i < testResults.Length; i++)
                testResults[i] = i % 6 + 1;

            // zad 2
            ArrayList db = new ArrayList { 2, "DOL123123", 3.3 };
            db.Add(1);
            db.Add(1.1);
            db.Add("asd");

            foreach (var item in db)
                if (item is double) db.Remove(item);

            for (int i = 0; i < db.Count; i++)
                if (db[i] is double) db.RemoveAt(i);


            // zad 3
            List<int> brokenParts = new List<int>() { 6, 3 };
            for (int i = 0; i < 30; i++)
            {
                int val = brokenParts[i] + brokenParts[i + 1];
                brokenParts.Add(val);
            }

            foreach (int item in brokenParts)
                if (item % 2 == 0) brokenParts.Remove(item);
        }
    }
}