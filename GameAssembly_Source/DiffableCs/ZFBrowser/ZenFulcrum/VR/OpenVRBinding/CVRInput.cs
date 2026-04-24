namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRInput
{
	private IVRInput FnTable; //Field offset: 0x10

	internal CVRInput(IntPtr pInterface) { }

	public EVRInputError DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, VRBoneTransform_t[] pTransformArray) { }

	public EVRInputError GetActionHandle(string pchActionName, ref ulong pHandle) { }

	public EVRInputError GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, UInt64[] originsOut) { }

	public EVRInputError GetActionSetHandle(string pchActionSetName, ref ulong pHandle) { }

	public EVRInputError GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice) { }

	public EVRInputError GetBoneCount(ulong action, ref uint pBoneCount) { }

	public EVRInputError GetBoneHierarchy(ulong action, Int32[] pParentIndices) { }

	public EVRInputError GetBoneName(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize) { }

	public EVRInputError GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice) { }

	public EVRInputError GetInputSourceHandle(string pchInputSourcePath, ref ulong pHandle) { }

	public EVRInputError GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude) { }

	public EVRInputError GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize) { }

	public EVRInputError GetPoseActionData(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice) { }

	public EVRInputError GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize) { }

	public EVRInputError GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, VRBoneTransform_t[] pTransformArray) { }

	public EVRInputError GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize) { }

	public EVRInputError GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, VRBoneTransform_t[] pTransformArray) { }

	public EVRInputError GetSkeletalSummaryData(ulong action, ref VRSkeletalSummaryData_t pSkeletalSummaryData) { }

	public EVRInputError GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel) { }

	public EVRInputError SetActionManifestPath(string pchActionManifestPath) { }

	public EVRInputError ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle) { }

	public EVRInputError ShowBindingsForActionSet(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, ulong originToHighlight) { }

	public EVRInputError TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice) { }

	public EVRInputError UpdateActionState(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t) { }

}

