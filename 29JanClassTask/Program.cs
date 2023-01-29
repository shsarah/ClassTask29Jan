namespace _29JanClassTask;
class Program
{
    static void Main(string[] args)
    {
        byte number;
    l4:
        Console.WriteLine("How do you want to see the books? : 1 or 2? ");
        if (byte.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l4;
        }
        if (number == 1)
        {
            Task1();
        }
        else if (number == 2)
        {
            Task2();
        }
        else
        {
            Console.WriteLine("ERROR: Choose 1 or 2");
            goto l4;
        }
    }
    static void Task1()
    {
        Book book = new Book();

        Console.Write("Enter the name of book: ");
        book.Name = Console.ReadLine();
        Console.Write("Enter author of book: ");
        book.AuthorName = Console.ReadLine();
    l2:
        Console.Write("Enter the published date (year): ");
        if (int.TryParse(Console.ReadLine(), out book.PublishedDate) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }
    l3:
        Console.Write("Enter count of pages: ");
        if (int.TryParse(Console.ReadLine(), out book.PageCount) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        if (book.PageCount < 10)
        {
            Console.WriteLine("Enter a number higher than 10");
            goto l3;
        }

        Console.WriteLine(book.ToString());
    }

    static void Task2()
    {
        Book book = new Book();

        Console.Write("Enter the name of book: ");
        book.Name = Console.ReadLine();
        Console.Write("Enter author of book: ");
        book.AuthorName = Console.ReadLine();
    l2:
        Console.Write("Enter the published date (year): ");
        if (int.TryParse(Console.ReadLine(), out book.PublishedDate) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }
    l3:
        Console.Write("Enter count of pages: ");
        if (int.TryParse(Console.ReadLine(), out book.PageCount) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        if (book.PageCount < 10)
        {
            Console.WriteLine("Enter a number higher than 10");
            goto l3;
        }

        Console.WriteLine($" Name: {book.Name} \n AuthorName: {book.AuthorName} \n Published date: {book.PublishedDate} \nPage count: {book.PageCount}");
    }
}

