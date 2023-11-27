using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Faker;

// Abstract class for User
public abstract class User
{
	public string RegistrationNumber { get; set; } = string.Empty;
	public int HoursParked { get; set; }

	public abstract double CalculateCharges();
}
public class Garage1User : User
{
	public Garage1User()
	{
		var faker = new Faker();
		RegistrationNumber = faker.Vehicle.Vin();

	}
	public override double CalculateCharges()
	{
		double minimumFee = 2.00;
		double additionalFee = 0.50 * Math.Max(0, HoursParked - 3);
		return Math.Min(minimumFee + additionalFee, 10.00);
	}
}
public class Garage2User : User
{
	public Garage2User()
	{
		var faker = new Faker();
		RegistrationNumber = faker.Vehicle.Vin();
	}

	public override double CalculateCharges()
	{
		double minimumFee = 2.00;
		double additionalFee = 0.60 * Math.Max(0, HoursParked - 3);
		return Math.Min(minimumFee + additionalFee, 10.00);
	}
}

public class Garage3User : User
{
	public Garage3User()
	{
		var faker = new Faker();
		RegistrationNumber = faker.Vehicle.Vin();
	}

	public override double CalculateCharges()
	{
		double minimumFee = 2.00;
		double additionalFee = 0.75 * Math.Max(0, HoursParked - 3);
		return Math.Min(minimumFee + additionalFee, 10.00);
	}
}