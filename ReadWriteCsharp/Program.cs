

// StreamReader + StreamWriter
// ---
//string data;
//StreamReader reader = null;
//StreamWriter writer = null;


//string rootPath = @"C:\Users\User\Documents\data\";

//reader = new StreamReader(rootPath + "dog.txt");

//List<string> lines = new List<string>();
//do
//{
//    data = reader.ReadLine();
//    lines.Add(data);

//} while (!reader.EndOfStream);
//reader.Close();

//lines.ForEach(Console.WriteLine);
//string newLine = $"between {lines[0]} and {lines[1]}";
//lines.Insert(1, newLine);

//writer = new StreamWriter(rootPath + "dog.txt");
//lines.ForEach (writer.WriteLine);
//writer.Close();

// ---
// File
// ---


//const char LAKE_TILE = (char)9619; 

//string rootPath = @"C:\Users\User\Documents\data\";
//string fileName = "map.txt";
//string path = Path.Combine(rootPath, fileName);

////string[] content = { "qwre", "asdf", "zxcv" };

////if (File.Exists(path))
////{
////    File.WriteAllLines(path, content);
////}

//string[] lines = { };

//if (File.Exists(path))
//{
//    lines = File.ReadAllLines(path);
//}

//int rowsNum = lines.Length;
//int colsNum = lines[0].Length;
//char[,] map = new char[rowsNum, colsNum];

//for (int i = 0; i < rowsNum; i++)
//    for (int j = 0; j < colsNum; j++)
//        map[i, j] = lines[i][j];


//for (int i = 0; i < rowsNum; i++)
//{
//    for (int j = 0; j < colsNum; j++)
//    {
//        char item = map[i, j];
//        if(item == LAKE_TILE)
//            Console.Write("~");
//        else if (item == '.')
//            Console.Write(" ");
//        else
//            Console.Write(item);

//    }
//    Console.WriteLine();
//}



// FILES



string rootPath = @"C:\Users\User\Documents\data";
string path = rootPath + @"\map.txt";

if (File.Exists(path))
{
    string fileText = File.ReadAllText(path);
    Console.WriteLine(fileText);
}


string[] lines = File.ReadAllLines(path);

int rowsCount = lines.Length;
int colsCount = lines[0].Length;

char[,] map = new char[rowsCount, colsCount];


for (int i = 0; i < rowsCount; i++)
{
    char[] elems = lines[i].ToCharArray();

    for (int j = 0; j < elems.Length; j++)
    {
        map[i, j] = elems[j];
    }

}

for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < colsCount; j++)
    {
        Console.Write(map[i, j]);
    }
    Console.WriteLine();
}












// const value
// path
// combin
// file.exists
// File.read/write
// asciiart