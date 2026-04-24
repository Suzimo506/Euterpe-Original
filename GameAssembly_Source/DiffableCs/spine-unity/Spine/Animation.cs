namespace Spine;

public class Animation
{
	internal string name; //Field offset: 0x10
	internal ExposedList<Timeline> timelines; //Field offset: 0x18
	internal HashSet<Int32> timelineIds; //Field offset: 0x20
	internal float duration; //Field offset: 0x28

	public float Duration
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public ExposedList<Timeline> Timelines
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Animation(string name, ExposedList<Timeline> timelines, float duration) { }

	public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }

	internal static int BinarySearch(Single[] values, float target, int step) { }

	internal static int BinarySearch(Single[] values, float target) { }

	public float get_Duration() { }

	public string get_Name() { }

	public ExposedList<Timeline> get_Timelines() { }

	public bool HasTimeline(int id) { }

	internal static int LinearSearch(Single[] values, float target, int step) { }

	public void set_Duration(float value) { }

	public void set_Timelines(ExposedList<Timeline> value) { }

	public virtual string ToString() { }

}

