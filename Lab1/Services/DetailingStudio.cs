using Lab1.Models;

namespace Lab1.Services;

public class DetailingStudio
{
    public string Name { get; }
    private readonly List<Service> _services = new();
    private readonly List<Person> _people = new();
    private readonly List<(Client client, Service service)> _orders = new();

    public DetailingStudio(string name) => Name = name;

    public void AddService(Service s) => _services.Add(s);
    public void AddPerson(Person p) => _people.Add(p);

    public void CreateOrder(Client client, Service service)
    {
        client.OrderedServices.Add(service);
        _orders.Add((client, service));
    }

    public void PrintPriceList()
    {
        Console.WriteLine($"\n=== ѕрайс-лист \"{Name}\" ===");
        foreach (var s in _services)
            Console.WriteLine(" Х " + s.GetDescription());
    }

    public void PrintStaff()
    {
        Console.WriteLine("\n=== ѕерсонал та кл≥Їнти ===");
        foreach (var p in _people)
            Console.WriteLine(" Х " + p.GetInfo());
    }

    public void PrintOrders()
    {
        Console.WriteLine("\n=== ∆урнал замовлень ===");
        foreach (var (client, service) in _orders)
            Console.WriteLine($" Х {client.FirstName} {client.LastName} " +
                              $"({client.PlateNumber}) ? {service.Name} Ч {service.Price} грн");
    }

    public decimal TotalRevenue()
    {
        decimal sum = 0;
        foreach (var (_, s) in _orders) sum += s.Price;
        return sum;
    }
}