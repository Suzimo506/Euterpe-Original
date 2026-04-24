namespace Spine;

public abstract class CurveTimeline : Timeline
{
	protected const float LINEAR = 0; //Field offset: 0x0
	protected const float STEPPED = 1; //Field offset: 0x0
	protected const float BEZIER = 2; //Field offset: 0x0
	protected const int BEZIER_SIZE = 19; //Field offset: 0x0
	internal Single[] curves; //Field offset: 0x10

	public int FrameCount
	{
		 get { } //Length: 43
	}

	public abstract int PropertyId
	{
		 get { } //Length: 0
	}

	public CurveTimeline(int frameCount) { }

	public abstract void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public int get_FrameCount() { }

	public abstract int get_PropertyId() { }

	public float GetCurvePercent(int frameIndex, float percent) { }

	public float GetCurveType(int frameIndex) { }

	public void SetCurve(int frameIndex, float cx1, float cy1, float cx2, float cy2) { }

	public void SetLinear(int frameIndex) { }

	public void SetStepped(int frameIndex) { }

}

