namespace UnityEngine;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController
{
	public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
	{

		public OnOverrideControllerDirtyCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0x18

	[Obsolete]
	public AnimationClipPair[] clips
	{
		 get { } //Length: 484
		 set { } //Length: 219
	}

	public AnimationClip Item
	{
		 get { } //Length: 69
		 set { } //Length: 82
	}

	public AnimationClip Item
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public int overridesCount
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 66
	}

	public AnimatorOverrideController() { }

	public AnimatorOverrideController(RuntimeAnimatorController controller) { }

	public void ApplyOverrides(IList<KeyValuePair`2<AnimationClip, AnimationClip>> overrides) { }

	public AnimationClipPair[] get_clips() { }

	public AnimationClip get_Item(string name) { }

	public AnimationClip get_Item(AnimationClip clip) { }

	[NativeMethod]
	public int get_overridesCount() { }

	[NativeMethod]
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	private AnimationClip GetOriginalClip(int index) { }

	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	public void GetOverrides(List<KeyValuePair`2<AnimationClip, AnimationClip>> overrides) { }

	[FreeFunction]
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	[NativeMethod]
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[NativeMethod]
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[RequiredByNativeCode]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void PerformOverrideClipListCleanup() { }

	private void SendNotification() { }

	public void set_clips(AnimationClipPair[] value) { }

	public void set_Item(AnimationClip clip, AnimationClip value) { }

	public void set_Item(string name, AnimationClip value) { }

	[NativeMethod]
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

}

