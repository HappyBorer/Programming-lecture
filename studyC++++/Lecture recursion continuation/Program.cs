// Рекурсия

// Собрать строку с числами от а до b, a <= b.

/* string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
    else return String.Empty;
} */


// Собрать строку с числами от а до b, a >= b.

/* string NumbersRec(int a, int b)
{
    if (a < b) return NumbersRec(a + 1, b) + $"{a}";
    else return b;
} */

// Сумма чисел от 1 до n.

/*int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}*/

// Вычислить a^n;

/* int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
} */

/* Перебор слов
В некотором машинном алфавите имеются четыре
буквы <<a>>, <<и>>,<<с>> и <<в>>. Покажите все слова,
состоящие из Т букв, которые можно построить из букв
этого алфавита */

/* void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine($"{new String(word)}.");
        return;
    }
    for(int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
} */

// Как посмотреть содержимое папки?

/* void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalogs.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");     
    }


} */




/* void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + "  ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
} */

// Игра в пирамидки

/* void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
} */

// Обход разных структур

string emp =  string.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(right < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
    }
}


