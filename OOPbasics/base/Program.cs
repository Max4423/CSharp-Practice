using Inheritance;
namespace baseKeyWord;

class Point2D
{
	public int x { get; set; }
	public int y { get; set; }

	public Point2D(int x, int y)
	{

		this.x = x;
		this.y = y;
		Console.WriteLine("Point 2D constructor called");
	}

	public void Print()
	{
		Console.Write($"X: {x} \nY: {y}\n");
	}


}

class Point3D : Point2D
{
	public int z { get; set; }

	public Point3D(int x, int y, int z): base(x, y)
	{
		this.z = z;
		Console.WriteLine("Point 3D constructor called");
	}

	public void Print()
	{
		base.Print();
		Console.Write($"Z: {z}");
	}
}

internal class Program
{
	static void Main(string[] args)
	{
		Point3D point3d = new Point3D(2,3,4);

		point3d.Print();
		Console.WriteLine();

		Point2D point2d = new Point2D(14,38);


		point2d.Print();

		point3d.Print();


		Object pt3 = new Point3D(2, 3, 1);


		//Point3D pt3d = (Point3D)pt3;



		Point3D pt3dAs = pt3 as Point3D;



		
		Person tch = new Teacher { FullName = "Marina", Age = 45, Salary = 12300, subject = Subjects.Biology };

		Teacher tchAs = tch as Teacher;

		if (tch is Person marinaTch)
		{
			Console.WriteLine("Marina is a person");
			marinaTch.PrintInfo();
		}



	}
}
