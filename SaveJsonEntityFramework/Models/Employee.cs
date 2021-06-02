using System;
using System.Text.Json;

namespace SaveJsonEntityFramework.Models
{
	public class Employee
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
		public DateTime DateOfAdmission { get; set; }
		public JsonElement Data { get; set; }
	}
}
