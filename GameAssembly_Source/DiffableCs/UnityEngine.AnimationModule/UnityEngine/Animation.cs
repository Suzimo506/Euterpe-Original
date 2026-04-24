namespace UnityEngine;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Animation : Behaviour, IEnumerable
{
	private sealed class Enumerator : IEnumerator
	{
		private Animation m_Outer; //Field offset: 0x10
		private int m_CurrentIndex; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 76
		}

		internal Enumerator(Animation outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	[Obsolete]
	public bool animateOnlyIfVisible
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
		[GeneratedByOldBindingsGenerator]
		 set { } //Length: 66
	}

	public bool animatePhysics
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
		[GeneratedByOldBindingsGenerator]
		 set { } //Length: 66
	}

	public AnimationClip clip
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
		[GeneratedByOldBindingsGenerator]
		 set { } //Length: 66
	}

	public AnimationCullingType cullingType
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
		[GeneratedByOldBindingsGenerator]
		 set { } //Length: 64
	}

	public bool isPlaying
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
	}

	public AnimationState Item
	{
		 get { } //Length: 66
	}

	public Bounds localBounds
	{
		 get { } //Length: 115
		 set { } //Length: 66
	}

	public bool playAutomatically
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
		[GeneratedByOldBindingsGenerator]
		 set { } //Length: 66
	}

	public WrapMode wrapMode
	{
		[GeneratedByOldBindingsGenerator]
		 get { } //Length: 51
		[GeneratedByOldBindingsGenerator]
		 set { } //Length: 64
	}

	public Animation() { }

	[ExcludeFromDocs]
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	[GeneratedByOldBindingsGenerator]
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	public void AddClip(AnimationClip clip, string newName) { }

	[ExcludeFromDocs]
	public void Blend(string animation) { }

	[ExcludeFromDocs]
	public void Blend(string animation, float targetWeight) { }

	[GeneratedByOldBindingsGenerator]
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation, float fadeLength) { }

	[GeneratedByOldBindingsGenerator]
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[GeneratedByOldBindingsGenerator]
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	[GeneratedByOldBindingsGenerator]
	public bool get_animateOnlyIfVisible() { }

	[GeneratedByOldBindingsGenerator]
	public bool get_animatePhysics() { }

	[GeneratedByOldBindingsGenerator]
	public AnimationClip get_clip() { }

	[GeneratedByOldBindingsGenerator]
	public AnimationCullingType get_cullingType() { }

	[GeneratedByOldBindingsGenerator]
	public bool get_isPlaying() { }

	public AnimationState get_Item(string name) { }

	public Bounds get_localBounds() { }

	[GeneratedByOldBindingsGenerator]
	public bool get_playAutomatically() { }

	[GeneratedByOldBindingsGenerator]
	public WrapMode get_wrapMode() { }

	public AnimationClip GetClip(string name) { }

	[GeneratedByOldBindingsGenerator]
	public int GetClipCount() { }

	public override IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGenerator]
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGenerator]
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGenerator]
	internal int GetStateCount() { }

	[GeneratedByOldBindingsGenerator]
	private static void INTERNAL_CALL_Rewind(Animation self) { }

	[GeneratedByOldBindingsGenerator]
	private static void INTERNAL_CALL_Sample(Animation self) { }

	[GeneratedByOldBindingsGenerator]
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGenerator]
	private static void INTERNAL_CALL_SyncLayer(Animation self, int layer) { }

	[GeneratedByOldBindingsGenerator]
	private void INTERNAL_get_localBounds(out Bounds value) { }

	[GeneratedByOldBindingsGenerator]
	private void Internal_RewindByName(string name) { }

	[GeneratedByOldBindingsGenerator]
	private void INTERNAL_set_localBounds(ref Bounds value) { }

	[GeneratedByOldBindingsGenerator]
	private void Internal_StopByName(string name) { }

	[GeneratedByOldBindingsGenerator]
	public bool IsPlaying(string name) { }

	[ExcludeFromDocs]
	public bool Play() { }

	[ExcludeFromDocs]
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGenerator]
	public bool Play(string animation, PlayMode mode) { }

	public bool Play(PlayMode mode) { }

	[Obsolete]
	public bool Play(string animation, AnimationPlayMode mode) { }

	[Obsolete]
	public bool Play(AnimationPlayMode mode) { }

	[GeneratedByOldBindingsGenerator]
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState PlayQueued(string animation) { }

	[ExcludeFromDocs]
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[GeneratedByOldBindingsGenerator]
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	public void RemoveClip(string clipName) { }

	[GeneratedByOldBindingsGenerator]
	public void RemoveClip(AnimationClip clip) { }

	[GeneratedByOldBindingsGenerator]
	private void RemoveClip2(string clipName) { }

	public void Rewind() { }

	public void Rewind(string name) { }

	public void Sample() { }

	[GeneratedByOldBindingsGenerator]
	public void set_animateOnlyIfVisible(bool value) { }

	[GeneratedByOldBindingsGenerator]
	public void set_animatePhysics(bool value) { }

	[GeneratedByOldBindingsGenerator]
	public void set_clip(AnimationClip value) { }

	[GeneratedByOldBindingsGenerator]
	public void set_cullingType(AnimationCullingType value) { }

	public void set_localBounds(Bounds value) { }

	[GeneratedByOldBindingsGenerator]
	public void set_playAutomatically(bool value) { }

	[GeneratedByOldBindingsGenerator]
	public void set_wrapMode(WrapMode value) { }

	public void Stop() { }

	public void Stop(string name) { }

	public void SyncLayer(int layer) { }

}

