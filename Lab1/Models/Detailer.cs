namespace Lab1.Models;

public class Detailer : Person
{
	public string Specialization { get; set; }
	public int ExperienceYears { get; set; }
	public decimal HourRate { get; set; }

	public Detailer(string firstName, string lastName, string phone,
					string specialization, int experienceYears, decimal hourRate)
		: base(firstName, lastName, phone)
	{
		Specialization = specialization;
		ExperienceYears = experienceYears;
		HourRate = hourRate;
	}

	public override string GetInfo()
		=> base.GetInfo() +
		   $", спеціалізація: {Specialization}, стаж: {ExperienceYears} р., " +
		   $"ставка: {HourRate} грн/год";
}