namespace UnityEngine.ResourceManagement;

internal static class WebRequestQueue
{
	internal static int s_MaxRequest; //Field offset: 0x0
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; //Field offset: 0x8
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; //Field offset: 0x10

	private static WebRequestQueue() { }

	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	public static void SetMaxConcurrentRequests(int maxRequests) { }

}

