namespace ZenFulcrum.EmbeddedBrowser.VR;

internal class NoVRInput : VRInput
{

	public NoVRInput() { }

	public virtual float GetAxis(XRNodeState node, InputAxis axis) { }

}

