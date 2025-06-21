using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RatingSystem
{
	enum rate
	{
		Excellent,    // A
		VeryGood,     // B
		Good,         // C
		Satisfactory, // D
		Poor,         // E
		Fail          // F
	}
	internal class Program
	{

		static void Main(string[] args)
		{
			RatingSystem rating = new RatingSystem();

			rating.ratings = new Dictionary<int, rate>() { { 1, rate.Satisfactory }, { 2, rate.Excellent }, {4, rate.Good } };

			Console.WriteLine(rating[1]);
		}
	}

	class RatingSystem
	{
		public Dictionary<int, rate> ratings = new Dictionary<int, rate>();


		public rate this[int userId]
		{
			get
			{
				return ratings.ContainsKey(userId) ? ratings[userId] : 0;
			}
			set
			{
				ratings[userId] = value;
			}
		}
	}

}
