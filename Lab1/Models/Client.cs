namespace Lab1.Models;

public class Client : Person
{
	public string CarModel { get; set; }
	public string PlateNumber { get; set; }
	public List<Service> OrderedServices { get; } = new();

	public Client(string firstName, string lastName, string phone,
				  string carModel, string plateNumber)
		: base(firstName, lastName, phone)
	{
		CarModel = carModel;
		PlateNumber = plateNumber;
	}

	public decimal TotalSpent()
	{
		decimal sum = 0;
		foreach (var s in OrderedServices) sum += s.Price;
		return sum;
	}

	public override string GetInfo()
		=> base.GetInfo() +
		   $", авто: {CarModel} ({PlateNumber}), замовлень: {OrderedServices.Count}, " +
		   $"витрачено: {TotalSpent()} грн";
}