namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRNotifications
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CreateNotification : MulticastDelegate
	{

		public _CreateNotification(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId, AsyncCallback callback, object object) { }

		public override EVRNotificationError EndInvoke(ref NotificationBitmap_t pImage, ref uint pNotificationId, IAsyncResult result) { }

		public override EVRNotificationError Invoke(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RemoveNotification : MulticastDelegate
	{

		public _RemoveNotification(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint notificationId, AsyncCallback callback, object object) { }

		public override EVRNotificationError EndInvoke(IAsyncResult result) { }

		public override EVRNotificationError Invoke(uint notificationId) { }

	}

	internal _CreateNotification CreateNotification; //Field offset: 0x0
	internal _RemoveNotification RemoveNotification; //Field offset: 0x8

}

