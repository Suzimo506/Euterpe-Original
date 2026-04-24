namespace Steamworks;

public sealed class CallResult : CallResult, IDisposable
{
	internal sealed class APIDispatchDelegate : MulticastDelegate
	{

		public APIDispatchDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T param, bool bIOFailure, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T param, bool bIOFailure) { }

	}

	[CompilerGenerated]
	private APIDispatchDelegate<T> m_Func; //Field offset: 0x0
	private SteamAPICall_t m_hAPICall; //Field offset: 0x0
	private bool m_bDisposed; //Field offset: 0x0

	private event APIDispatchDelegate<T> m_Func
	{
		[CompilerGenerated]
		private add { } //Length: 188
		[CompilerGenerated]
		private remove { } //Length: 188
	}

	public SteamAPICall_t Handle
	{
		 get { } //Length: 5
	}

	public CallResult`1(APIDispatchDelegate<T> func = null) { }

	[CompilerGenerated]
	private void add_m_Func(APIDispatchDelegate<T> value) { }

	public void Cancel() { }

	public static CallResult<T> Create(APIDispatchDelegate<T> func = null) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public SteamAPICall_t get_Handle() { }

	internal virtual Type GetCallbackType() { }

	public bool IsActive() { }

	internal virtual void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_) { }

	[CompilerGenerated]
	private void remove_m_Func(APIDispatchDelegate<T> value) { }

	public void Set(SteamAPICall_t hAPICall, APIDispatchDelegate<T> func = null) { }

	internal virtual void SetUnregistered() { }

}

