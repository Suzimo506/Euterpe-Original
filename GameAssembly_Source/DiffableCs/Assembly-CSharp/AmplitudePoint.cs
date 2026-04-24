//Type is in global namespace

public class AmplitudePoint
{
	public float time; //Field offset: 0x10
	public float vaule; //Field offset: 0x14
	public Slider slider; //Field offset: 0x18

	public AmplitudePoint(float t, float v) { }

	public void OnSelect(Action onSelect) { }

	public virtual string ToString() { }

}

