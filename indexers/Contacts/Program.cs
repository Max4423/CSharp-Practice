namespace Contacts
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Contacts friends = new();
			friends.contactBook = new Dictionary<string, string> { { "098069734", "Max" }, { "098023444", "Ivan" } };
			Console.WriteLine(friends["098069734"]);
		}
	}

	class Contacts
	{
		public Dictionary<string, string> contactBook;

		public string this[string phoneNumber]
		{
			get
			{
				return ((contactBook.ContainsKey(phoneNumber)) ? contactBook[phoneNumber] : null);

			}
			set
			{
				if (contactBook.ContainsKey(phoneNumber))
				{
					contactBook[phoneNumber] = value;
				}
			}
		}

		
	}
}
