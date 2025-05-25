namespace Generics_Constraints
{
	class Message
	{
		public string Text { get; }
		public Message(string text)
		{
			Text = text;
		}
	}
	class EmailMessage : Message
	{
		public EmailMessage(string text) : base(text) { }
	}

	internal class Program
	{
		static void SendMessage<T>(T message) where T: Message  //  обмеження дженеріків
		{
			Console.WriteLine(message.Text);
		}
		static void Main(string[] args)
		{
			Message mssg = new EmailMessage("qwertyuio");

			SendMessage(mssg);
			SendMessage(new EmailMessage("kuku"));
		}
	}
}
