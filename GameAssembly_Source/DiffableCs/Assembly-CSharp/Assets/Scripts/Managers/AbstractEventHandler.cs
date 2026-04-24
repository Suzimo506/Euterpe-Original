namespace Assets.Scripts.Managers;

public abstract class AbstractEventHandler
{
	internal sealed class TriggerHandler : MulticastDelegate
	{

		public TriggerHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class TriggerHandler : MulticastDelegate
	{

		public TriggerHandler`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T arg1, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T arg1) { }

	}

	internal sealed class TriggerHandler : MulticastDelegate
	{

		public TriggerHandler`2(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T arg1, T2 arg2, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T arg1, T2 arg2) { }

	}

	internal sealed class TriggerHandler : MulticastDelegate
	{

		public TriggerHandler`3(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T arg1, T2 arg2, T3 arg3) { }

	}

	public string uid; //Field offset: 0x10

	protected AbstractEventHandler() { }

	public abstract void ClearEvent() { }

	internal override void Play(Object[] args = null) { }

}

