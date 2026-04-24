namespace Spine.Unity;

[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonMecanim : SkeletonRenderer, ISkeletonAnimation
{
	internal class MecanimTranslator
	{
		private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
		{
			internal static readonly IEqualityComparer<AnimationClip> Instance; //Field offset: 0x64A01

			private static AnimationClipEqualityComparer() { }

			public AnimationClipEqualityComparer() { }

			public override bool Equals(AnimationClip x, AnimationClip y) { }

			public override int GetHashCode(AnimationClip o) { }

		}

		internal class ClipInfos
		{
			public bool isInterruptionActive; //Field offset: 0x10
			public bool isLastFrameOfInterruption; //Field offset: 0x11
			public int clipInfoCount; //Field offset: 0x14
			public int nextClipInfoCount; //Field offset: 0x18
			public int interruptingClipInfoCount; //Field offset: 0x1C
			public readonly List<AnimatorClipInfo> clipInfos; //Field offset: 0x20
			public readonly List<AnimatorClipInfo> nextClipInfos; //Field offset: 0x28
			public readonly List<AnimatorClipInfo> interruptingClipInfos; //Field offset: 0x30
			public AnimatorStateInfo stateInfo; //Field offset: 0x38
			public AnimatorStateInfo nextStateInfo; //Field offset: 0x5C
			public AnimatorStateInfo interruptingStateInfo; //Field offset: 0x80
			public float interruptingClipTimeAddition; //Field offset: 0xA4

			public ClipInfos() { }

		}

		private class IntEqualityComparer : IEqualityComparer<Int32>
		{
			internal static readonly IEqualityComparer<Int32> Instance; //Field offset: 0x2C927BC

			private static IntEqualityComparer() { }

			public IntEqualityComparer() { }

			public override bool Equals(int x, int y) { }

			public override int GetHashCode(int o) { }

		}

		internal enum MixMode
		{
			AlwaysMix = 0,
			MixNext = 1,
			Hard = 2,
		}

		internal sealed class OnClipAppliedDelegate : MulticastDelegate
		{

			public OnClipAppliedDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward) { }

		}

		public bool autoReset; //Field offset: 0x10
		public bool useCustomMixMode; //Field offset: 0x11
		public MixMode[] layerMixModes; //Field offset: 0x18
		public MixBlend[] layerBlendModes; //Field offset: 0x20
		[CompilerGenerated]
		private OnClipAppliedDelegate _OnClipApplied; //Field offset: 0x28
		private readonly Dictionary<Int32, Animation> animationTable; //Field offset: 0x30
		private readonly Dictionary<AnimationClip, Int32> clipNameHashCodeTable; //Field offset: 0x38
		private readonly List<Animation> previousAnimations; //Field offset: 0x40
		protected ClipInfos[] layerClipInfos; //Field offset: 0x48
		private Animator animator; //Field offset: 0x50

		protected event OnClipAppliedDelegate _OnClipApplied
		{
			[CompilerGenerated]
			 add { } //Length: 158
			[CompilerGenerated]
			 remove { } //Length: 158
		}

		public event OnClipAppliedDelegate OnClipApplied
		{
			 add { } //Length: 158
			 remove { } //Length: 158
		}

		public Animator Animator
		{
			 get { } //Length: 5
		}

		public int MecanimLayerCount
		{
			 get { } //Length: 132
		}

		public String[] MecanimLayerNames
		{
			 get { } //Length: 357
		}

		public MecanimTranslator() { }

		[CompilerGenerated]
		protected void add__OnClipApplied(OnClipAppliedDelegate value) { }

		public void add_OnClipApplied(OnClipAppliedDelegate value) { }

		private static float AnimationTime(float normalizedTime, float clipLength, bool reversed) { }

		private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed) { }

		public void Apply(Skeleton skeleton) { }

		private bool ApplyAnimation(Skeleton skeleton, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, bool useClipWeight1 = false) { }

		private bool ApplyInterruptionAnimation(Skeleton skeleton, bool interpolateWeightTo1, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, float interruptingClipTimeAddition, bool useClipWeight1 = false) { }

		private void ClearClipInfosForLayers() { }

		public Animator get_Animator() { }

		public int get_MecanimLayerCount() { }

		public String[] get_MecanimLayerNames() { }

		public KeyValuePair<Animation, Single> GetActiveAnimationAndTime(int layer) { }

		private Animation GetAnimation(AnimationClip clip) { }

		private void GetAnimatorClipInfos(int layer, out bool isInterruptionActive, out int clipInfoCount, out int nextClipInfoCount, out int interruptingClipInfoCount, out IList<AnimatorClipInfo>& clipInfo, out IList<AnimatorClipInfo>& nextClipInfo, out IList<AnimatorClipInfo>& interruptingClipInfo, out bool shallInterpolateWeightTo1) { }

		private void GetAnimatorStateInfos(int layer, out bool isInterruptionActive, out AnimatorStateInfo stateInfo, out AnimatorStateInfo nextStateInfo, out AnimatorStateInfo interruptingStateInfo, out float interruptingClipTimeAddition) { }

		private MixMode GetMixMode(int layer, MixBlend layerBlendMode) { }

		private void GetStateUpdatesFromAnimator(int layer) { }

		private void InitClipInfosForLayers() { }

		public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset) { }

		private void OnClipAppliedCallback(Animation clip, AnimatorStateInfo stateInfo, int layerIndex, float time, bool isLooping, float weight) { }

		[CompilerGenerated]
		protected void remove__OnClipApplied(OnClipAppliedDelegate value) { }

		public void remove_OnClipApplied(OnClipAppliedDelegate value) { }

	}

	[SerializeField]
	protected MecanimTranslator translator; //Field offset: 0xE0
	private bool wasUpdatedAfterInit; //Field offset: 0xE8
	[CompilerGenerated]
	private UpdateBonesDelegate _BeforeApply; //Field offset: 0xF0
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; //Field offset: 0xF8
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; //Field offset: 0x100
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; //Field offset: 0x108

	protected event UpdateBonesDelegate _BeforeApply
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected event UpdateBonesDelegate _UpdateComplete
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected event UpdateBonesDelegate _UpdateLocal
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected event UpdateBonesDelegate _UpdateWorld
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UpdateBonesDelegate BeforeApply
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public override event UpdateBonesDelegate UpdateComplete
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public override event UpdateBonesDelegate UpdateLocal
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public override event UpdateBonesDelegate UpdateWorld
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public MecanimTranslator Translator
	{
		 get { } //Length: 8
	}

	public SkeletonMecanim() { }

	[CompilerGenerated]
	protected void add__BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void add__UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void add__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void add__UpdateWorld(UpdateBonesDelegate value) { }

	public void add_BeforeApply(UpdateBonesDelegate value) { }

	public override void add_UpdateComplete(UpdateBonesDelegate value) { }

	public override void add_UpdateLocal(UpdateBonesDelegate value) { }

	public override void add_UpdateWorld(UpdateBonesDelegate value) { }

	protected void ApplyAnimation() { }

	public MecanimTranslator get_Translator() { }

	public virtual void Initialize(bool overwrite) { }

	public virtual void LateUpdate() { }

	[CompilerGenerated]
	protected void remove__BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void remove__UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void remove__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void remove__UpdateWorld(UpdateBonesDelegate value) { }

	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	public override void remove_UpdateComplete(UpdateBonesDelegate value) { }

	public override void remove_UpdateLocal(UpdateBonesDelegate value) { }

	public override void remove_UpdateWorld(UpdateBonesDelegate value) { }

	public void Update() { }

}

