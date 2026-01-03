using System.Text.RegularExpressions;

List<Person> users = new List<Person>
{
	new Person{ Id = Guid.NewGuid().ToString(), Name = "Alice", Age = 30 },
	new Person{ Id = Guid.NewGuid().ToString(), Name = "Bob", Age = 25 },
	new Person{ Id = Guid.NewGuid().ToString(), Name = "Charlie", Age = 35 }
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
	var request = context.Request;
	var response = context.Response;
	var path = request.Path;

	string expressionForGuid = @"^/api/users/\w{8}-\w{4}-\w{4}-\w{4}-\w{12}$";

	if (path == "/api/users" && request.Method == "GET")
	{
		await GetAllPeople(response);
	}
	else if (Regex.IsMatch(path, expressionForGuid) && request.Method == "GET")
	{
		var id = path.ToString().Split('/').Last();
		await GetPerson(id, response);
	}
	else if (path == "/api/users" && request.Method == "POST")
	{
		await CreatePerson(request, response);
	}
	else if (path == "/api/users" && request.Method == "PUT")
	{
		await UpdatePerson(request, response);
	}
	else if (Regex.IsMatch(path, expressionForGuid) && request.Method == "DELETE")
	{
		string? id = path.Value?.Split("/")[3];
		await DeletePerson(id, response);
	}
	else
	{
		response.ContentType = "text/html; charset=utf-8";
		await response.SendFileAsync("html/index.html");
	}

});
app.Run();

async Task GetAllPeople(HttpResponse response)
{
	response.ContentType = "application/json";
	await response.WriteAsJsonAsync(users);
}

async Task GetPerson(string id, HttpResponse response)
{
	Person? person = users.FirstOrDefault(u => u.Id == id);
	if (person != null)
	{
		response.ContentType = "application/json";
		await response.WriteAsJsonAsync(person);
	}
	else
	{
		response.StatusCode = 404;
		await response.WriteAsync("Person not found");
	}
}
async Task CreatePerson(HttpRequest request, HttpResponse response)
{
	try
	{
		var user = await request.ReadFromJsonAsync<Person>();
		if (user != null)
		{
			user.Id = Guid.NewGuid().ToString();
			users.Add(user);
			await response.WriteAsJsonAsync<Person>(user);
		}
		else
		{
			throw new Exception("Incorrect data");
		}
	}
	catch (Exception)
	{
		response.StatusCode = 400;
		await response.WriteAsJsonAsync(new { message = "Incorrect data" });
	}
}
async Task UpdatePerson(HttpRequest request, HttpResponse response)
{
	try
	{
		Person? userData = await request.ReadFromJsonAsync<Person>();
		if (userData != null)
		{
			var user = users.FirstOrDefault(u => u.Id == userData.Id);

			if (user != null)
			{
				user.Age = userData.Age;
				user.Name = userData.Name;
				await response.WriteAsJsonAsync(user);
			}
			else
			{
				response.StatusCode = 404;
				await response.WriteAsJsonAsync(new { message = "User not found" });

			}
		}
		else
		{
			throw new Exception("Incorrect data");
		}
	}
	catch (Exception)
	{
		response.StatusCode = 400;
		await response.WriteAsJsonAsync(new { message = "Incorrect data" });
	}
}
async Task DeletePerson(string id, HttpResponse response)
{
	Person? user = users.FirstOrDefault(u => u.Id == id);
	if (user != null)
	{
		users.Remove(user);
		await response.WriteAsJsonAsync(user);	
	}
	else
	{
		response.StatusCode = 404;
		await response.WriteAsJsonAsync(new { message = "User not found" });
	}
}

public class Person
{
	public string Id { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public int Age { get; set; }
}
