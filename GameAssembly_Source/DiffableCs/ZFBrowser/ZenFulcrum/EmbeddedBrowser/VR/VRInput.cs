namespace ZenFulcrum.EmbeddedBrowser.VR;

public abstract class VRInput
{
	internal struct Pose
	{
		public Vector3 pos; //Field offset: 0x0
		public Quaternion rot; //Field offset: 0xC

	}

	[CompilerGenerated]
	private static VRInput <Impl>k__BackingField; //Field offset: 0x6A426

	public private static VRInput Impl
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	protected VRInput() { }

	[CompilerGenerated]
	public static VRInput get_Impl() { }

	public abstract float GetAxis(XRNodeState node, InputAxis axis) { }

	private static VRInput GetImpl() { }

	public override JoyPadType GetJoypadTypes(XRNodeState node) { }

	public override string GetNodeName(XRNodeState node) { }

	public override Pose GetPose(XRNodeState node) { }

	public static void Init() { }

	[CompilerGenerated]
	private static void set_Impl(VRInput value) { }

}

