namespace Spine;

public class PathConstraintSpacingTimeline : PathConstraintPositionTimeline
{

	public virtual int PropertyId
	{
		 get { } //Length: 9
	}

	public PathConstraintSpacingTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }

	public virtual int get_PropertyId() { }

}

