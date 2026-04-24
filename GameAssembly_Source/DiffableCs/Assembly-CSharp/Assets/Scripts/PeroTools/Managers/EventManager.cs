namespace Assets.Scripts.PeroTools.Managers;

public class EventManager : Singleton<EventManager>
{
	internal sealed class EventCallFunc : MulticastDelegate
	{

		public EventCallFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Object[] args, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Object[] args) { }

	}

	public class EventParam
	{
		public List<Object> paramList; //Field offset: 0x10

		public EventParam(Object[] objs) { }

	}

	internal class EventTrigger
	{
		internal sealed class TriggerHandler : MulticastDelegate
		{

			public TriggerHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(object sender, object reciever, Object[] args, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(object sender, object reciever, Object[] args) { }

		}

		public string uid; //Field offset: 0x10
		public object receiver; //Field offset: 0x18
		[CompilerGenerated]
		private TriggerHandler trigger; //Field offset: 0x20

		public event TriggerHandler trigger
		{
			[CompilerGenerated]
			 add { } //Length: 158
			[CompilerGenerated]
			 remove { } //Length: 158
		}

		public EventTrigger() { }

		[CompilerGenerated]
		public void add_trigger(TriggerHandler value) { }

		internal EventTrigger Clear() { }

		internal void Play(Object[] args) { }

		internal void Play(object r, Object[] args) { }

		[CompilerGenerated]
		public void remove_trigger(TriggerHandler value) { }

	}

	public readonly Dictionary<String, Object> events; //Field offset: 0x10
	private readonly Dictionary<String, EventTrigger> m_EventTriggers; //Field offset: 0x18

	public EventManager() { }

	public void Invoke(string uid, Object[] args) { }

	public void InvokeReceiver(string uid, object reciever, Object[] args) { }

	public EventTrigger RegEvent(string uid, object receiver = null) { }

	public EventTrigger UnregEvent(string uid) { }

}

