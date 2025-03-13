namespace AbstractClasses
{
	abstract class Weapon
	{
		public abstract void Fire();
		public abstract int Damage { get; }

		public void ShowInfo()
		{
			Console.WriteLine($"{GetType().Name} {Damage}");
		}

	}


	class Gun : Weapon
	{
		public override int Damage { get { return 10; } }

		public override void Fire()
		{
			Console.WriteLine("SHOT FROM GUN!");
		}


	}

	class Riffle : Weapon
	{
		public override int Damage { get { return 15; } }

		public override void Fire()
		{
			Console.WriteLine("SHOT FROM RIFFLE!");
		}
	}

	class Player
	{
		public void Fire(Weapon weapon)
		{
			weapon.Fire();

		}

		public void CheckInfo(Weapon weapon)
		{
			weapon.ShowInfo();
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();

			Weapon[] inventory = { new Gun(), new Riffle() };

			foreach (Weapon weap in inventory)
			{
				player.Fire(weap);
				player.CheckInfo(weap);
			}
		}
	}
}
