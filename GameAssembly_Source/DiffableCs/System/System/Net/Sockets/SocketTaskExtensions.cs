namespace System.Net.Sockets;

[Extension]
public static class SocketTaskExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPAddress, Int32, AsyncCallback, Object, IAsyncResult> <>9__3_0; //Field offset: 0x8
		public static Action<IAsyncResult> <>9__3_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IAsyncResult <ConnectAsync>b__3_0(IPAddress targetAddress, int targetPort, AsyncCallback callback, object state) { }

		internal void <ConnectAsync>b__3_1(IAsyncResult asyncResult) { }

	}


	[Extension]
	public static Task ConnectAsync(Socket socket, IPAddress address, int port) { }

}

