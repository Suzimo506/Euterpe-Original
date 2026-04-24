namespace Spine.Unity;

[CreateAssetMenu]
public class SkeletonDataAsset : ScriptableObject
{
	public AtlasAssetBase[] atlasAssets; //Field offset: 0x18
	public float scale; //Field offset: 0x20
	public TextAsset skeletonJSON; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public List<SkeletonDataModifierAsset> skeletonDataModifiers; //Field offset: 0x30
	[SpineAnimation(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public String[] fromAnimation; //Field offset: 0x38
	[SpineAnimation(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public String[] toAnimation; //Field offset: 0x40
	public Single[] duration; //Field offset: 0x48
	public float defaultMix; //Field offset: 0x50
	public RuntimeAnimatorController controller; //Field offset: 0x58
	private SkeletonData skeletonData; //Field offset: 0x60
	private AnimationStateData stateData; //Field offset: 0x68

	public bool IsLoaded
	{
		 get { } //Length: 9
	}

	public SkeletonDataAsset() { }

	public void Clear() { }

	public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase atlasAsset, bool initialize, float scale = 0.01) { }

	public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase[] atlasAssets, bool initialize, float scale = 0.01) { }

	public void FillStateData() { }

	public bool get_IsLoaded() { }

	public AnimationStateData GetAnimationStateData() { }

	internal Atlas[] GetAtlasArray() { }

	public SkeletonData GetSkeletonData(bool quiet) { }

	internal void InitializeWithData(SkeletonData sd) { }

	internal static SkeletonData ReadSkeletonData(Byte[] bytes, AttachmentLoader attachmentLoader, float scale) { }

	internal static SkeletonData ReadSkeletonData(string text, AttachmentLoader attachmentLoader, float scale) { }

	private void Reset() { }

}

