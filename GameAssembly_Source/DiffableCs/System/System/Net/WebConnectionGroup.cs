namespace System.Net;

internal class WebConnectionGroup
{
	private class ConnectionState : IWebConnectionState
	{
		[CompilerGenerated]
		private WebConnection <Connection>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private WebConnectionGroup <Group>k__BackingField; //Field offset: 0x18
		private bool busy; //Field offset: 0x20
		private DateTime idleSince; //Field offset: 0x28

		public override bool Busy
		{
			 get { } //Length: 5
		}

		public private WebConnection Connection
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private override WebConnectionGroup Group
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public override DateTime IdleSince
		{
			 get { } //Length: 5
		}

		public override ServicePoint ServicePoint
		{
			 get { } //Length: 27
		}

		public ConnectionState(WebConnectionGroup group) { }

		public override bool get_Busy() { }

		[CompilerGenerated]
		public WebConnection get_Connection() { }

		[CompilerGenerated]
		public override WebConnectionGroup get_Group() { }

		public override DateTime get_IdleSince() { }

		public override ServicePoint get_ServicePoint() { }

		[CompilerGenerated]
		private void set_Connection(WebConnection value) { }

		[CompilerGenerated]
		private void set_Group(WebConnectionGroup value) { }

		public override void SetIdle() { }

		public override bool TrySetBusy() { }

	}

	private ServicePoint sPoint; //Field offset: 0x10
	private string name; //Field offset: 0x18
	private LinkedList<ConnectionState> connections; //Field offset: 0x20
	private Queue queue; //Field offset: 0x28
	private bool closing; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler ConnectionClosed; //Field offset: 0x38

	public event EventHandler ConnectionClosed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public string Name
	{
		 get { } //Length: 5
	}

	internal Queue Queue
	{
		internal get { } //Length: 5
	}

	public WebConnectionGroup(ServicePoint sPoint, string name) { }

	[CompilerGenerated]
	public void add_ConnectionClosed(EventHandler value) { }

	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	private ConnectionState FindIdleConnection() { }

	public string get_Name() { }

	internal Queue get_Queue() { }

	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	[CompilerGenerated]
	public void remove_ConnectionClosed(EventHandler value) { }

	internal bool TryRecycle(TimeSpan maxIdleTime, ref DateTime idleSince) { }

}

