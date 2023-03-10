class programm
 {
    static void Main(string[] args)
    {
Console.Write("Enter number of mast(1-4):");
string mm = Console.ReadLine(); // Номер масті
int m = Convert.ToInt32(mm);
Console.Write("Enter number of card(6-14):");
string kk = Console.ReadLine(); // Номер карти
int k = Convert.ToInt32(kk);

string mast = ""; // Змінна для збереження назви масті
string card = ""; // Змінна для збереження назви карти

// Оператор switch для визначення назви масті за її номером
switch (m)
{
    case 1:
        mast = "Піки";
        break;
    case 2:
        mast = "Трефи";
        break;
    case 3:
        mast = "Чирви";
        break;
    case 4:
        mast = "Бубни";
        break;
    default:
        Console.WriteLine("Неправильний номер масті!");
        break;
}

// Оператор switch для визначення назви карти за її номером
switch (k)
{
    case 6:
        card = "Шістка";
        break;
    case 7:
        card = "Сімка";
        break;
    case 8:
        card = "Вісімка";
        break;
    case 9:
        card = "Дев'ятка";
        break;
    case 10:
        card = "Десятка";
        break;
    case 11:
        card = "Валет";
        break;
    case 12:
        card = "Дама";
        break;
    case 13:
        card = "Король";
        break;
    case 14:
        card = "Туз";
        break;
    default:
        Console.WriteLine("Неправильний номер карти!");
        break;
}

// Виведення результату
Console.WriteLine("Карта: " + card + " Масть: " + mast);
 }
    }