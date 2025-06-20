namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var publisher = new MessagePublisher();
			var email = new EmailSubscriber();
			var sms = new SMSSubscriber();

			publisher.notify += email.ReceiveEmail;

			publisher.notify += sms.ReceiveSMS;

			publisher.RaiseNotification("ljhgf");

		}

	}
	delegate void Notify(string text);
	class MessagePublisher
	{
		public event Notify notify;

		public void RaiseNotification(string text)
		{
			notify?.Invoke(text);
		}

	}
	class EmailSubscriber
	{
		public void ReceiveEmail(string text)
		{
			Console.WriteLine($"Email: {text}");
		}
	}

	class SMSSubscriber
	{
		public void ReceiveSMS(string text)
		{
			Console.WriteLine($"SMS: {text}");
		}
	}
}
