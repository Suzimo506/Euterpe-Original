//Type is in global namespace

public class NsVibrationValue
{
	public List<AmplitudePoint> lowAmplitude; //Field offset: 0x10
	public List<AmplitudePoint> highAmplitude; //Field offset: 0x18
	public float totalTime; //Field offset: 0x20

	public NsVibrationValue(AmplitudePoint low, AmplitudePoint high, float time) { }

	public NsVibrationValue(List<AmplitudePoint> low, List<AmplitudePoint> high, float time) { }

	public bool isEmpty() { }

	public virtual string ToString() { }

}

