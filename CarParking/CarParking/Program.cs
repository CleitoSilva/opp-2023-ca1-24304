
class Program
{
	static void Main()
	{
		List<User> garage1Users = new List<User>();
		List<User> garage2Users = new List<User>();
		List<User> garage3Users = new List<User>();

		Random random = new Random();

		for (int i = 0; i < 10; i++)
		{
			Garage1User user = new Garage1User();
			user.HoursParked = random.Next(1, 10); 
			garage1Users.Add(user);
		}

		for (int i = 0; i < 6; i++)
		{
			Garage2User user = new Garage2User();
			user.HoursParked = random.Next(1, 10)
			garage2Users.Add(user);
		}

		for (int i = 0; i < 8; i++)
		{
			Garage3User user = new Garage3User();
			user.HoursParked = random.Next(1, 10); 
			garage3Users.Add(user);
		}

		// Display charges for each garage
		DisplayCharges(garage1Users, "Garage 1");
		DisplayCharges(garage2Users, "Garage 2");
		DisplayCharges(garage3Users, "Garage 3");
	}

	// Method to display charges for a garage
	static void DisplayCharges(List<User> users, string garageName)
	{
		double totalCharge = 0;

		Console.WriteLine($"Charges for {garageName}:");
		foreach (var user in users)
		{
			double charge = user.CalculateCharges();
			totalCharge += charge;

			Console.WriteLine($"Registration Number: {user.RegistrationNumber}, Hours Parked: {user.HoursParked}, Charge: €{charge:F2}");
		}

		Console.WriteLine($"Total Charges for {garageName}: €{totalCharge:F2}\n");
	}
}