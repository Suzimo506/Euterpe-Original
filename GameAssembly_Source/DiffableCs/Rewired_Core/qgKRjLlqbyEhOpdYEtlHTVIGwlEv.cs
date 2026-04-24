//Type is in global namespace

internal static class qgKRjLlqbyEhOpdYEtlHTVIGwlEv
{
	[CustomObfuscation]
	internal sealed class EventFunction : MulticastDelegate
	{

		public EventFunction`2(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(T handler, TArgs value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T handler, TArgs value) { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class HierarchyEventHelper
	{
		[Flags]
		internal enum kNJNRIhyQQgzGFWMXhchCFbdnZFd
		{
			None = 0,
			Self = 1,
			Children = 4,
			Parents = 8,
			All = -1,
		}

		private readonly EventFunction<THandler, TValue> xiBtueAeKjTBGtLipEpXoVLbcGjI; //Field offset: 0x0
		private readonly List<THandler> RIKvDtuYOduKzgmdIBxwEVzapkMQ; //Field offset: 0x0
		private readonly kNJNRIhyQQgzGFWMXhchCFbdnZFd<THandler, TValue> BqwDgCxMPIBmSZGwFpunhwOSBMSk; //Field offset: 0x0

		public HierarchyEventHelper`2(EventFunction<THandler, TValue> unnamed_param_0) { }

		public HierarchyEventHelper`2(EventFunction<THandler, TValue> unnamed_param_0, kNJNRIhyQQgzGFWMXhchCFbdnZFd<THandler, TValue> unnamed_param_1) { }

		public void ExecuteOnAll(TValue value) { }

		public void GetHandlers(Transform transform) { }

	}


	public static void KfImIPOBUDqNuOiBKeCUTgFDvLNN(IList<> unnamed_param_0,  unnamed_param_1, EventFunction<, > unnamed_param_2, bool unnamed_param_3) { }

	public static void rStqPAmoNpkvfVMdnYstvoVzAABd(IList<> unnamed_param_0,  unnamed_param_1, EventFunction<, > unnamed_param_2) { }

	public static void rStqPAmoNpkvfVMdnYstvoVzAABd( unnamed_param_0,  unnamed_param_1, EventFunction<, > unnamed_param_2) { }

}

