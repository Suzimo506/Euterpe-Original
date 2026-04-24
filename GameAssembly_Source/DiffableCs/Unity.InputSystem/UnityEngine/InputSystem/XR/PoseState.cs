namespace UnityEngine.InputSystem.XR;

public struct PoseState : IInputStateTypeInfo
{
	internal const int kSizeInBytes = 60; //Field offset: 0x0
	[InputControl]
	public bool isTracked; //Field offset: 0x0
	[InputControl]
	public InputTrackingState trackingState; //Field offset: 0x4
	[InputControl]
	public Vector3 position; //Field offset: 0x8
	[InputControl]
	public Quaternion rotation; //Field offset: 0x14
	[InputControl]
	public Vector3 velocity; //Field offset: 0x24
	[InputControl]
	public Vector3 angularVelocity; //Field offset: 0x30

	public override FourCC format
	{
		 get { } //Length: 6
	}

	public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity) { }

	public override FourCC get_format() { }

}

