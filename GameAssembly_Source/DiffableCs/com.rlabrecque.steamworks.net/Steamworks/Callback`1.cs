namespace Steamworks;

public sealed class Callback : Callback, IDisposable
{
	internal sealed class DispatchDelegate : MulticastDelegate
	{

		public DispatchDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T param, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T param) { }

	}

	[CompilerGenerated]
	private DispatchDelegate<T> m_Func; //Field offset: 0x0
	private bool m_bGameServer; //Field offset: 0x0
	private bool m_bIsRegistered; //Field offset: 0x0
	private bool m_bDisposed; //Field offset: 0x0

	private event DispatchDelegate<T> m_Func
	{
		[CompilerGenerated]
		private add { } //Length: 188
		[CompilerGenerated]
		private remove { } //Length: 188
	}

	public virtual bool IsGameServer
	{
		 get { } //Length: 5
	}

	public Callback`1(DispatchDelegate<T> func, bool bGameServer = false) { }

	[CompilerGenerated]
	private void add_m_Func(DispatchDelegate<T> value) { }

	public static Callback<T> Create(DispatchDelegate<T> func) { }

	public static Callback<T> CreateGameServer(DispatchDelegate<T> func) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public virtual bool get_IsGameServer() { }

	internal virtual Type GetCallbackType() { }

	internal virtual void OnRunCallback(IntPtr pvParam) { }

	public void Register(DispatchDelegate<T> func) { }

	[CompilerGenerated]
	private void remove_m_Func(DispatchDelegate<T> value) { }

	internal virtual void SetUnregistered() { }

	public void Unregister() { }

}

