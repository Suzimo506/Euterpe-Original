namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRNotifications
{
	private IVRNotifications FnTable; //Field offset: 0x10

	internal CVRNotifications(IntPtr pInterface) { }

	public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId) { }

	public EVRNotificationError RemoveNotification(uint notificationId) { }

}

