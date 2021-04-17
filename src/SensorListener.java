public class SensorListener implements Observer 
{
	private String name;
	private Observable subscribedTo;

	public SensorListener(String name) 
	{
		this.name = name;
	}

	@Override
	public void notifyObserver() 
	{
		if(subscribedTo == null) 
		{
			System.out.println(getName() + " has no sensors set");
			return;
		}
		
		String newData = subscribedTo.getUpdate();
		System.out.println(getName() + " recieved an update: " + newData);
	}

	@Override
	public void setTopic(Observable topic) 
	{
		subscribedTo = topic;
	}

	public String getName() 
	{
		return name;
	}
}
