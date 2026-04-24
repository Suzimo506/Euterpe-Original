namespace Spine.Unity;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, IAnimationStateComponent
{
	public AnimationState state; //Field offset: 0xE0
	public bool isUnscaleDeltaTime; //Field offset: 0xE8
	private bool wasUpdatedAfterInit; //Field offset: 0xE9
	[CompilerGenerated]
	private UpdateBonesDelegate _BeforeApply; //Field offset: 0xF0
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; //Field offset: 0xF8
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; //Field offset: 0x100
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; //Field offset: 0x108
	[SerializeField]
	[SpineAnimation(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _animationName; //Field offset: 0x110
	public bool loop; //Field offset: 0x118
	public float timeScale; //Field offset: 0x11C

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

	public string AnimationName
	{
		 get { } //Length: 80
		 set { } //Length: 259
	}

	public override AnimationState AnimationState
	{
		 get { } //Length: 8
	}

	public SkeletonAnimation() { }

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

	public static SkeletonAnimation AddToGameObject(GameObject gameObject, SkeletonDataAsset skeletonDataAsset) { }

	protected void ApplyAnimation() { }

	public virtual void ClearState() { }

	public void ForceUpdate(bool lateUpdate = false) { }

	public string get_AnimationName() { }

	public override AnimationState get_AnimationState() { }

	public virtual void Initialize(bool overwrite) { }

	public virtual void LateUpdate() { }

	public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset skeletonDataAsset) { }

	private void OnDisable() { }

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

	public void set_AnimationName(string value) { }

	private void Update() { }

	public void Update(float deltaTime) { }

	protected void UpdateAnimationStatus(float deltaTime) { }

}

