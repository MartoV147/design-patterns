namespace ChatRoomHomeWork
{
    public abstract class User
    {
		public string name;
		protected MessageMediator mediator;

		public User(MessageMediator mediator, string name)
		{
			this.mediator = mediator;
			this.name = name;
		}

		public User(string name)
		{
			this.name = name;
		}

		public abstract void Send(string message);

		public abstract void Recieve(string message, User sender);
	}
}
