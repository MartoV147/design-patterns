import java.util.ArrayList;
import java.util.List;
public class Sensor implements Observable 
{
	List<Observer> sensorListeners;
	
	private String data;
	
	public Sensor() 
	{
		sensorListeners = new ArrayList<Observer>(); 	
	}
	
	@Override
	public void subscribe(Observer obs) 
	{
		sensorListeners.add(obs);
		obs.setTopic(this);
	}

	@Override
	public void unsubscribe(Observer obs) 
	{
		sensorListeners.remove(obs);
		obs.setTopic(null);
	}

	@Override
	public void notifyObservers() 
	{
		for(int i = 0; i < sensorListeners.size(); i++) 
		{
			sensorListeners.get(i).notifyObserver();
		}
	}

	@Override
	public String getUpdate() 
	{
		return data;
	}

	public void setTopic(String topic) 
	{
		this.data = topic;
		notifyObservers(); 
	}
}
