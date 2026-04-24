namespace UnityEngine.ResourceManagement;

internal class WebRequestQueueOperation
{
	private bool m_Completed; //Field offset: 0x10
	public UnityWebRequestAsyncOperation Result; //Field offset: 0x18
	public Action<UnityWebRequestAsyncOperation> OnComplete; //Field offset: 0x20
	internal UnityWebRequest m_WebRequest; //Field offset: 0x28

	public bool IsDone
	{
		 get { } //Length: 18
	}

	public WebRequestQueueOperation(UnityWebRequest request) { }

	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }

	public bool get_IsDone() { }

}

