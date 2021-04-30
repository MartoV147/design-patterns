using System;
namespace ChatRoomHomeWork
{
    public class ChatBot : User
    {
		private static ChatBot instance;

        public static ChatBot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChatBot("MartoBot");
                }
                return instance; 
            }
        }

        private ChatBot(string name) : base(name)
		{}

		public override void Recieve(string message, User sender)
        {
            if (message.Contains("cat"))
            {
                //mediator.SendMessage(sender.name + " has been kicked", this);
                Console.WriteLine(sender.name + " has been kicked");
                mediator.MarkToKick(sender);
                
            }
        }

        public override void Send(string message)
        {
        }

        public void SetChat(MessageMediator mediator) 
        {
            this.mediator = mediator;
            mediator.AddUser(this);
        }
	}
}
