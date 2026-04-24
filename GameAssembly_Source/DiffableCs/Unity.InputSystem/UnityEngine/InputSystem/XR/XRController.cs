namespace UnityEngine.InputSystem.XR;

[InputControlLayout]
public class XRController : TrackedDevice
{

	public static XRController leftHand
	{
		 get { } //Length: 153
	}

	public static XRController rightHand
	{
		 get { } //Length: 153
	}

	public XRController() { }

	protected virtual void FinishSetup() { }

	public static XRController get_leftHand() { }

	public static XRController get_rightHand() { }

}

