namespace Spine;

public class ScaleTimeline : TranslateTimeline, IBoneTimeline
{

	public virtual int PropertyId
	{
		 get { } //Length: 9
	}

	public ScaleTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public virtual int get_PropertyId() { }

}

