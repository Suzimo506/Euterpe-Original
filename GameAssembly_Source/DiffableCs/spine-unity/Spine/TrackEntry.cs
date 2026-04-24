namespace Spine;

public class TrackEntry : IPoolable<TrackEntry>
{
	internal Animation animation; //Field offset: 0x10
	internal TrackEntry next; //Field offset: 0x18
	internal TrackEntry mixingFrom; //Field offset: 0x20
	internal TrackEntry mixingTo; //Field offset: 0x28
	[CompilerGenerated]
	private TrackEntryDelegate Start; //Field offset: 0x30
	[CompilerGenerated]
	private TrackEntryDelegate Interrupt; //Field offset: 0x38
	[CompilerGenerated]
	private TrackEntryDelegate End; //Field offset: 0x40
	[CompilerGenerated]
	private TrackEntryDelegate Dispose; //Field offset: 0x48
	[CompilerGenerated]
	private TrackEntryDelegate Complete; //Field offset: 0x50
	[CompilerGenerated]
	private TrackEntryEventDelegate Event; //Field offset: 0x58
	internal int trackIndex; //Field offset: 0x60
	internal bool loop; //Field offset: 0x64
	internal bool holdPrevious; //Field offset: 0x65
	internal float eventThreshold; //Field offset: 0x68
	internal float attachmentThreshold; //Field offset: 0x6C
	internal float drawOrderThreshold; //Field offset: 0x70
	internal float animationStart; //Field offset: 0x74
	internal float animationEnd; //Field offset: 0x78
	internal float animationLast; //Field offset: 0x7C
	internal float nextAnimationLast; //Field offset: 0x80
	internal float delay; //Field offset: 0x84
	internal float trackTime; //Field offset: 0x88
	internal float trackLast; //Field offset: 0x8C
	internal float nextTrackLast; //Field offset: 0x90
	internal float trackEnd; //Field offset: 0x94
	internal float timeScale; //Field offset: 0x98
	internal float alpha; //Field offset: 0x9C
	internal float mixTime; //Field offset: 0xA0
	internal float mixDuration; //Field offset: 0xA4
	internal float interruptAlpha; //Field offset: 0xA8
	internal float totalAlpha; //Field offset: 0xAC
	internal MixBlend mixBlend; //Field offset: 0xB0
	internal readonly ExposedList<Int32> timelineMode; //Field offset: 0xB8
	internal readonly ExposedList<TrackEntry> timelineHoldMix; //Field offset: 0xC0
	internal readonly ExposedList<Single> timelinesRotation; //Field offset: 0xC8

	public event TrackEntryDelegate Complete
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event TrackEntryDelegate Dispose
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event TrackEntryDelegate End
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event TrackEntryEventDelegate Event
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event TrackEntryDelegate Interrupt
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event TrackEntryDelegate Start
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public float Alpha
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public Animation Animation
	{
		 get { } //Length: 5
	}

	public float AnimationEnd
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AnimationLast
	{
		 get { } //Length: 6
		 set { } //Length: 14
	}

	public float AnimationStart
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AnimationTime
	{
		 get { } //Length: 211
	}

	public float AttachmentThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Delay
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float DrawOrderThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float EventThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool HoldPrevious
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool IsComplete
	{
		 get { } //Length: 25
	}

	public bool Loop
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public MixBlend MixBlend
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public float MixDuration
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public TrackEntry MixingFrom
	{
		 get { } //Length: 5
	}

	public TrackEntry MixingTo
	{
		 get { } //Length: 5
	}

	public float MixTime
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public TrackEntry Next
	{
		 get { } //Length: 5
	}

	public float TimeScale
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float TrackEnd
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public int TrackIndex
	{
		 get { } //Length: 4
	}

	public float TrackTime
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public TrackEntry() { }

	[CompilerGenerated]
	public void add_Complete(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void add_Dispose(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void add_End(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void add_Event(TrackEntryEventDelegate value) { }

	[CompilerGenerated]
	public void add_Interrupt(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void add_Start(TrackEntryDelegate value) { }

	public float get_Alpha() { }

	public Animation get_Animation() { }

	public float get_AnimationEnd() { }

	public float get_AnimationLast() { }

	public float get_AnimationStart() { }

	public float get_AnimationTime() { }

	public float get_AttachmentThreshold() { }

	public float get_Delay() { }

	public float get_DrawOrderThreshold() { }

	public float get_EventThreshold() { }

	public bool get_HoldPrevious() { }

	public bool get_IsComplete() { }

	public bool get_Loop() { }

	public MixBlend get_MixBlend() { }

	public float get_MixDuration() { }

	public TrackEntry get_MixingFrom() { }

	public TrackEntry get_MixingTo() { }

	public float get_MixTime() { }

	public TrackEntry get_Next() { }

	public float get_TimeScale() { }

	public float get_TrackEnd() { }

	public int get_TrackIndex() { }

	public float get_TrackTime() { }

	internal void OnComplete() { }

	internal void OnDispose() { }

	internal void OnEnd() { }

	internal void OnEvent(Event e) { }

	internal void OnInterrupt() { }

	internal void OnStart() { }

	[CompilerGenerated]
	public void remove_Complete(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void remove_Dispose(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void remove_End(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void remove_Event(TrackEntryEventDelegate value) { }

	[CompilerGenerated]
	public void remove_Interrupt(TrackEntryDelegate value) { }

	[CompilerGenerated]
	public void remove_Start(TrackEntryDelegate value) { }

	public override void Reset() { }

	public void ResetRotationDirections() { }

	public void set_Alpha(float value) { }

	public void set_AnimationEnd(float value) { }

	public void set_AnimationLast(float value) { }

	public void set_AnimationStart(float value) { }

	public void set_AttachmentThreshold(float value) { }

	public void set_Delay(float value) { }

	public void set_DrawOrderThreshold(float value) { }

	public void set_EventThreshold(float value) { }

	public void set_HoldPrevious(bool value) { }

	public void set_Loop(bool value) { }

	public void set_MixBlend(MixBlend value) { }

	public void set_MixDuration(float value) { }

	public void set_MixTime(float value) { }

	public void set_TimeScale(float value) { }

	public void set_TrackEnd(float value) { }

	public void set_TrackTime(float value) { }

	public virtual string ToString() { }

}

