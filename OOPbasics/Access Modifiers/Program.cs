namespace Access_Modifiers
{
	class Gun
	{
		public Gun(bool isLoaded)
		{
			this.isLoaded = isLoaded;
		}

		private bool isLoaded = false;

	
		private void Reload()
		{
			Console.WriteLine("Reloading...");
			isLoaded = true;
			Console.WriteLine("The gun was reloaded!");

		}

		public void Shot()
		{
			if (isLoaded == false)
			{
				Console.WriteLine("The gun wasn`t load!");
				Reload();
			}
			Console.WriteLine("BOOM BOOM!!!!!");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Gun gun = new Gun(true);
			gun.Shot();

		}
	}
}
