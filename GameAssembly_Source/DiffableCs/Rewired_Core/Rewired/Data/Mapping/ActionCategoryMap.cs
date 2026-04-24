namespace Rewired.Data.Mapping;

public sealed class ActionCategoryMap
{
	internal class Entry
	{
		[CompilerGenerated]
		private sealed class HdhasDrJXIYNnbtjPQWkICivvZGR : IDisposable, IEnumerable, IEnumerator, IEnumerable<Int32>, IEnumerator<Int32>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private int QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x14
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x18
			public Entry SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x20
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x28

			private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 66
			}

			[DebuggerHidden]
			public HdhasDrJXIYNnbtjPQWkICivvZGR(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

			[DebuggerHidden]
			private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public int categoryId; //Field offset: 0x10
		public List<Int32> actionIds; //Field offset: 0x18

		public IEnumerable<Int32> ActionIds
		{
			 get { } //Length: 131
		}

		public Entry() { }

		public Entry(int unnamed_param_0) { }

		public Entry(Entry unnamed_param_0) { }

		public void AddAction(int actionId) { }

		public Entry Clone() { }

		public bool ContainsAction(int id) { }

		public IEnumerable<Int32> get_ActionIds() { }

		public int IndexOfAction(int id) { }

		public bool InsertAction(int actionId, int index) { }

		public void RemoveAction(int actionId) { }

		public bool ReorderAction(int actionId, bool offsetDown, bool offsetNow) { }

	}

	[CompilerGenerated]
	private sealed class JTkghptzgWTicjgJkAmlVqKAbKIo : IDisposable, IEnumerable, IEnumerator, IEnumerable<Int32>, IEnumerator<Int32>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private int QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x14
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x18
		public ActionCategoryMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x20
		private int FnNssaMbbiGxCPHWGbPCicuJeNueA; //Field offset: 0x28
		public int ioIWfKzjXRsMYWaJRIDFcIXmgtnn; //Field offset: 0x2C
		private IEnumerator<Int32> inuxbZbMYBTTtRdheIzZHkqdxpdaA; //Field offset: 0x30

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 66
		}

		[DebuggerHidden]
		public JTkghptzgWTicjgJkAmlVqKAbKIo(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

		private void zrtCAIBkwslGrRiYMlNCOGQQuous() { }

	}

	[CustomObfuscation]
	[SerializeField]
	private List<Entry> list; //Field offset: 0x10

	public ActionCategoryMap() { }

	public ActionCategoryMap(ActionCategoryMap unnamed_param_0) { }

	public IEnumerable<Int32> ActionIdsInCategory(int categoryId) { }

	public bool AddAction(int categoryId, int actionId) { }

	public void AddCategory(int id) { }

	public bool ChangeCategory(int actionId, int newCategoryId) { }

	public ActionCategoryMap Clone() { }

	public int IndexOfAction(int categoryId, int actionId) { }

	public int IndexOfCategory(int id) { }

	public bool InsertAction(int categoryId, int actionId, int index) { }

	public void RemoveAction(int categoryId, int actionId) { }

	public void RemoveCategory(int id) { }

	public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow) { }

	public bool ReorderCategory(int id, bool offsetDown) { }

}

