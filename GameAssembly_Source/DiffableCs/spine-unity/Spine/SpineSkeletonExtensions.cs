namespace Spine;

[Extension]
public static class SpineSkeletonExtensions
{

	[Extension]
	public static void AllowImmediateQueue(TrackEntry trackEntry) { }

	[Extension]
	public static bool InheritsRotation(TransformMode mode) { }

	[Extension]
	public static bool InheritsScale(TransformMode mode) { }

	[Extension]
	public static bool IsRenderable(Attachment a) { }

	[Extension]
	public static bool IsWeighted(VertexAttachment va) { }

	[Extension]
	public static void SetAttachmentToSetupPose(Slot slot) { }

	[Extension]
	public static void SetColorToSetupPose(Slot slot) { }

	[Extension]
	public static void SetDrawOrderToSetupPose(Skeleton skeleton) { }

	[Extension]
	public static void SetKeyedItemsToSetupPose(Animation animation, Skeleton skeleton) { }

	[Extension]
	internal static void SetPropertyToSetupPose(Skeleton skeleton, int propertyID) { }

	[Extension]
	public static void SetSlotAttachmentsToSetupPose(Skeleton skeleton) { }

	[Extension]
	public static void SetSlotAttachmentToSetupPose(Skeleton skeleton, int slotIndex) { }

}

