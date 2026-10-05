using Lab1.Models;
using Lab1.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var studio = new DetailingStudio("DetailPro");

// Послуги
studio.AddService(new CarWash(450m, 40, isContactless: true, withInteriorCleaning: false));
studio.AddService(new CarWash(800m, 70, isContactless: false, withInteriorCleaning: true));
studio.AddService(new Polishing(3500m, 180, "середнє", withWaxProtection: true));
studio.AddService(new Polishing(5200m, 240, "глибоке", withWaxProtection: true));
studio.AddService(new CeramicCoating(18000m, 600, layersCount: 3, warrantyMonths: 24));

// Клієнти
var c1 = new Client("Олег", "Гончар", "+380501112233", "BMW X5", "AA 1234 BB");
var c2 = new Client("Ірина", "Савчук", "+380672223344", "Toyota RAV4", "BC 5678 KM");

// Майстри
var d1 = new Detailer("Андрій", "Кравець", "+380631112200", "Полірування", 7, 350m);
var d2 = new Detailer("Максим", "Ткачук", "+380931113300", "Кераміка", 5, 420m);

studio.AddPerson(c1);
studio.AddPerson(c2);
studio.AddPerson(d1);
studio.AddPerson(d2);
// Демонстрація
studio.PrintPriceList();
studio.PrintStaff();

Console.WriteLine("\n=== Оформлення замовлень ===");
studio.CreateOrder(c1, new CarWash(450m, 40, true, false));
studio.CreateOrder(c1, new Polishing(3500m, 180, "середнє", true));
studio.CreateOrder(c2, new CeramicCoating(18000m, 600, 3, 24));

studio.PrintOrders();

Console.WriteLine($"\nЗагальний дохід студії: {studio.TotalRevenue()} грн");

Console.WriteLine("\n=== Оновлена картка клієнта ===");
Console.WriteLine(c1.GetInfo());