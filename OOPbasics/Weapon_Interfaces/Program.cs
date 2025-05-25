namespace Weapon_Interfaces
{

	interface IShowInfo
	{
		public void ShowInfo();
	}
	interface IFire
	{
		public void Fire();
		public abstract int Damage { get; }

	}
	interface IThrow: IFire
	{
		public void Throw();
	} 
	interface IReload
	{
		public void Reload();
	}


	abstract class Weapon : IShowInfo, IFire
	{
		public abstract void Fire();
		public abstract int Damage { get; } 
		public void ShowInfo()
		{
			Console.WriteLine($"{GetType().Name} {Damage}");
		}


	}


	class Gun : Weapon, IReload
	{
		public override int Damage { get { return 10; } }

		public void Reload()
		{
			Console.WriteLine("Reloaded");
		}
		public override void Fire()
		{
			Console.WriteLine("SHOT FROM GUN!");
			Reload();
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

	class Knife : Weapon, IThrow
	{
		public override int Damage { get; } = 12;

		public override void Fire()
		{
			Console.WriteLine("SHOT FROM KNIFE :)))!");
		}

		public void Throw()
		{
			Console.WriteLine("THROWN KNIFE!");
		}
	}
	class Box : IShowInfo
	{
		public void ShowInfo()
		{
			Console.WriteLine("i`m Box");
		}
	}

	class Player
	{
		public void Fire(Weapon weapon)
		{
			weapon.Fire();

		}

		public void Throw(IThrow weapon)
		{
			weapon.Throw();
		}

		public void CheckInfo(IShowInfo showinfo)
		{
			showinfo.ShowInfo();
		}

	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();

			Weapon[] inventory = { new Gun(), new Riffle(), new Knife() };

			foreach (Weapon weap in inventory)
			{
				player.Fire(weap);
				if (weap is IThrow throwableWeapon)
				{
				player.Throw(throwableWeapon);
				}
				player.CheckInfo(weap);
				player.CheckInfo(new Box());

			}

		}
	 }


}
