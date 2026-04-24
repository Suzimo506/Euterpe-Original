namespace Spine.Unity;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
{
	internal class MecanimTranslator
	{
		private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
		{
			internal static readonly IEqualityComparer<AnimationClip> Instance; //Field offset: 0x65230

			private static AnimationClipEqualityComparer() { }

			public AnimationClipEqualityComparer() { }

			public override bool Equals(AnimationClip x, AnimationClip y) { }

			public override int GetHashCode(AnimationClip o) { }

		}

		private class IntEqualityComparer : IEqualityComparer<Int32>
		{
			internal static readonly IEqualityComparer<Int32> Instance; //Field offset: 0x652CC

			private static IntEqualityComparer() { }

			public IntEqualityComparer() { }

			public override bool Equals(int x, int y) { }

			public override int GetHashCode(int o) { }

		}

		internal enum MixMode
		{
			AlwaysMix = 0,
			MixNext = 1,
			SpineStyle = 2,
		}

		public bool autoReset; //Field offset: 0x10
		public MixMode[] layerMixModes; //Field offset: 0x18
		private readonly Dictionary<Int32, Animation> animationTable; //Field offset: 0x20
		private readonly Dictionary<AnimationClip, Int32> clipNameHashCodeTable; //Field offset: 0x28
		private readonly List<Animation> previousAnimations; //Field offset: 0x30
		private readonly List<AnimatorClipInfo> clipInfoCache; //Field offset: 0x38
		private readonly List<AnimatorClipInfo> nextClipInfoCache; //Field offset: 0x40
		private Animator animator; //Field offset: 0x48

		public Animator Animator
		{
			 get { } //Length: 5
		}

		public MecanimTranslator() { }

		private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed) { }

		private static float AnimationTime(float normalizedTime, float clipLength, bool reversed) { }

		public void Apply(Skeleton skeleton) { }

		public Animator get_Animator() { }

		private void GetAnimatorClipInfos(int layer, out int clipInfoCount, out int nextClipInfoCount, out IList<AnimatorClipInfo>& clipInfo, out IList<AnimatorClipInfo>& nextClipInfo) { }

		public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset) { }

		private int NameHashCode(AnimationClip clip) { }

	}

	[SerializeField]
	protected MecanimTranslator translator; //Field offset: 0xE0
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; //Field offset: 0xE8
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; //Field offset: 0xF0
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; //Field offset: 0xF8

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

	public SkeletonAnimator() { }

	[CompilerGenerated]
	protected void add__UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void add__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void add__UpdateWorld(UpdateBonesDelegate value) { }

	public override void add_UpdateComplete(UpdateBonesDelegate value) { }

	public override void add_UpdateLocal(UpdateBonesDelegate value) { }

	public override void add_UpdateWorld(UpdateBonesDelegate value) { }

	public MecanimTranslator get_Translator() { }

	public virtual void Initialize(bool overwrite) { }

	[CompilerGenerated]
	protected void remove__UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void remove__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	protected void remove__UpdateWorld(UpdateBonesDelegate value) { }

	public override void remove_UpdateComplete(UpdateBonesDelegate value) { }

	public override void remove_UpdateLocal(UpdateBonesDelegate value) { }

	public override void remove_UpdateWorld(UpdateBonesDelegate value) { }

	public void Update() { }

}

