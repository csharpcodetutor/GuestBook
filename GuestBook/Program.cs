using GuestBook;

Services service = new Services();

GuestModel person = new GuestModel();
person.firestName = GuestFactory.Host;
person.lastName = "Johnson";
person.age = 50;


List<GuestModel> people = new List<GuestModel>();
bool moreGuestComing;

do
{
    Console.WriteLine("Enter your first name:");
    string fname = Console.ReadLine();

    Console.WriteLine("Enter your last name:");
    string lname = Console.ReadLine();
    int age;

    Console.WriteLine("Enter your age:");
    while (!int.TryParse(Console.ReadLine(), out age))
    {
        Console.WriteLine("Enter your age:");
    }

    Console.WriteLine("Are more guest coming?");
    moreGuestComing =  "yes" == Console.ReadLine().ToLower()  ;


} while(moreGuestComing);


