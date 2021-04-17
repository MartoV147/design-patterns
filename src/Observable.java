public interface Observable 
{
	void subscribe(Observer obs);
	void unsubscribe(Observer obs);
	
	void notifyObservers();
	
	String getUpdate();
}
