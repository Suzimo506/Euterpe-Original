namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRInput
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _DecompressSkeletalBoneData : MulticastDelegate
	{

		public _DecompressSkeletalBoneData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, out VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, out VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetActionHandle : MulticastDelegate
	{

		public _GetActionHandle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchActionName, ref ulong pHandle, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref ulong pHandle, IAsyncResult result) { }

		public override EVRInputError Invoke(string pchActionName, ref ulong pHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetActionOrigins : MulticastDelegate
	{

		public _GetActionOrigins(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong actionSetHandle, ulong digitalActionHandle, out UInt64[] originsOut, uint originOutCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong actionSetHandle, ulong digitalActionHandle, out UInt64[] originsOut, uint originOutCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetActionSetHandle : MulticastDelegate
	{

		public _GetActionSetHandle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchActionSetName, ref ulong pHandle, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref ulong pHandle, IAsyncResult result) { }

		public override EVRInputError Invoke(string pchActionSetName, ref ulong pHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetAnalogActionData : MulticastDelegate
	{

		public _GetAnalogActionData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref InputAnalogActionData_t pActionData, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetBoneCount : MulticastDelegate
	{

		public _GetBoneCount(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ref uint pBoneCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref uint pBoneCount, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ref uint pBoneCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetBoneHierarchy : MulticastDelegate
	{

		public _GetBoneHierarchy(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, out Int32[] pParentIndices, uint unIndexArayCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, out Int32[] pParentIndices, uint unIndexArayCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetBoneName : MulticastDelegate
	{

		public _GetBoneName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDigitalActionData : MulticastDelegate
	{

		public _GetDigitalActionData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref InputDigitalActionData_t pActionData, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetInputSourceHandle : MulticastDelegate
	{

		public _GetInputSourceHandle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchInputSourcePath, ref ulong pHandle, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref ulong pHandle, IAsyncResult result) { }

		public override EVRInputError Invoke(string pchInputSourcePath, ref ulong pHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOriginLocalizedName : MulticastDelegate
	{

		public _GetOriginLocalizedName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOriginTrackedDeviceInfo : MulticastDelegate
	{

		public _GetOriginTrackedDeviceInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref InputOriginInfo_t pOriginInfo, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetPoseActionData : MulticastDelegate
	{

		public _GetPoseActionData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref InputPoseActionData_t pActionData, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSkeletalActionData : MulticastDelegate
	{

		public _GetSkeletalActionData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref InputSkeletalActionData_t pActionData, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSkeletalBoneData : MulticastDelegate
	{

		public _GetSkeletalBoneData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, out VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, out VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSkeletalBoneDataCompressed : MulticastDelegate
	{

		public _GetSkeletalBoneDataCompressed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref uint punRequiredCompressedSize, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSkeletalReferenceTransforms : MulticastDelegate
	{

		public _GetSkeletalReferenceTransforms(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, out VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, out VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSkeletalSummaryData : MulticastDelegate
	{

		public _GetSkeletalSummaryData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ref VRSkeletalSummaryData_t pSkeletalSummaryData, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref VRSkeletalSummaryData_t pSkeletalSummaryData, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ref VRSkeletalSummaryData_t pSkeletalSummaryData) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSkeletalTrackingLevel : MulticastDelegate
	{

		public _GetSkeletalTrackingLevel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel, IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetActionManifestPath : MulticastDelegate
	{

		public _SetActionManifestPath(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchActionManifestPath, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(string pchActionManifestPath) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowActionOrigins : MulticastDelegate
	{

		public _ShowActionOrigins(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong actionSetHandle, ulong ulActionHandle, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong actionSetHandle, ulong ulActionHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowBindingsForActionSet : MulticastDelegate
	{

		public _ShowBindingsForActionSet(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, ulong originToHighlight, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(out VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, ulong originToHighlight) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _TriggerHapticVibrationAction : MulticastDelegate
	{

		public _TriggerHapticVibrationAction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _UpdateActionState : MulticastDelegate
	{

		public _UpdateActionState(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, AsyncCallback callback, object object) { }

		public override EVRInputError EndInvoke(IAsyncResult result) { }

		public override EVRInputError Invoke(out VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount) { }

	}

	internal _SetActionManifestPath SetActionManifestPath; //Field offset: 0x0
	internal _GetActionSetHandle GetActionSetHandle; //Field offset: 0x8
	internal _GetActionHandle GetActionHandle; //Field offset: 0x10
	internal _GetInputSourceHandle GetInputSourceHandle; //Field offset: 0x18
	internal _UpdateActionState UpdateActionState; //Field offset: 0x20
	internal _GetDigitalActionData GetDigitalActionData; //Field offset: 0x28
	internal _GetAnalogActionData GetAnalogActionData; //Field offset: 0x30
	internal _GetPoseActionData GetPoseActionData; //Field offset: 0x38
	internal _GetSkeletalActionData GetSkeletalActionData; //Field offset: 0x40
	internal _GetBoneCount GetBoneCount; //Field offset: 0x48
	internal _GetBoneHierarchy GetBoneHierarchy; //Field offset: 0x50
	internal _GetBoneName GetBoneName; //Field offset: 0x58
	internal _GetSkeletalReferenceTransforms GetSkeletalReferenceTransforms; //Field offset: 0x60
	internal _GetSkeletalTrackingLevel GetSkeletalTrackingLevel; //Field offset: 0x68
	internal _GetSkeletalBoneData GetSkeletalBoneData; //Field offset: 0x70
	internal _GetSkeletalSummaryData GetSkeletalSummaryData; //Field offset: 0x78
	internal _GetSkeletalBoneDataCompressed GetSkeletalBoneDataCompressed; //Field offset: 0x80
	internal _DecompressSkeletalBoneData DecompressSkeletalBoneData; //Field offset: 0x88
	internal _TriggerHapticVibrationAction TriggerHapticVibrationAction; //Field offset: 0x90
	internal _GetActionOrigins GetActionOrigins; //Field offset: 0x98
	internal _GetOriginLocalizedName GetOriginLocalizedName; //Field offset: 0xA0
	internal _GetOriginTrackedDeviceInfo GetOriginTrackedDeviceInfo; //Field offset: 0xA8
	internal _ShowActionOrigins ShowActionOrigins; //Field offset: 0xB0
	internal _ShowBindingsForActionSet ShowBindingsForActionSet; //Field offset: 0xB8

}

