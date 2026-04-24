namespace Spine;

public interface Timeline
{

	public int PropertyId
	{
		 get { } //Length: 0
	}

	public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }

	public int get_PropertyId() { }

}

