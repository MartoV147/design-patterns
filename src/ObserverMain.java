public class ObserverMain 
{
	public static void main(String[] args) 
	{
		Sensor sensor = new Sensor();
		
		Observer sl1 = new SensorListener("listener1");
		Observer sl2 = new SensorListener("listener2");
		Observer sl3 = new SensorListener("listener3");
		
		sensor.subscribe(sl1);
		sensor.subscribe(sl2);
		sensor.subscribe(sl3);
		
		sensor.setTopic("TEST");
		sensor.setTopic("TEST1");
		
		sensor.unsubscribe(sl3);
		
		sensor.setTopic("TEST3");
		
	}
}
