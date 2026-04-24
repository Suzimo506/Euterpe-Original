namespace Spine.Unity.AttachmentTools;

[Extension]
public static class SkinUtilities
{

	[Extension]
	public static void AddAttachments(Skin skin, Skin otherSkin) { }

	[Extension]
	public static void Append(Skin destination, Skin source) { }

	[Extension]
	public static void Clear(Skin skin) { }

	[Extension]
	public static void CopyTo(Skin source, Skin destination, bool overwrite, bool cloneAttachments, bool cloneMeshesAsLinked = true) { }

	[Extension]
	public static Attachment GetAttachment(Skin skin, string slotName, string keyName, Skeleton skeleton) { }

	[Extension]
	public static Skin GetClone(Skin original) { }

	[Extension]
	public static Skin GetClonedSkin(Skeleton skeleton, string newSkinName, bool includeDefaultSkin = false, bool cloneAttachments = false, bool cloneMeshesAsLinked = true) { }

	[Extension]
	public static void RemoveAttachment(Skin skin, string slotName, string keyName, SkeletonData skeletonData) { }

	[Extension]
	public static void SetAttachment(Skin skin, string slotName, string keyName, Attachment attachment, Skeleton skeleton) { }

	[Extension]
	public static void SetAttachment(Skin skin, int slotIndex, string keyName, Attachment attachment) { }

	[Extension]
	public static Skin UnshareSkin(Skeleton skeleton, bool includeDefaultSkin, bool unshareAttachments, AnimationState state = null) { }

}

