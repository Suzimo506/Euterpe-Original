namespace FlexFramework.Excel;

public sealed class WorkBook : KeyedCollection<String, WorkSheet>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Cell last; //Field offset: 0x10
		public Cell cell; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal Cell <Read>b__0(int i) { }

		internal Cell <Read>b__1(int i) { }

	}

	[CompilerGenerated]
	private SharedStringCollection <SharedStrings>k__BackingField; //Field offset: 0x38

	public private SharedStringCollection SharedStrings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public WorkBook(Byte[] buffer) { }

	public WorkBook(Stream stream) { }

	public WorkBook(string fileName) { }

	[CompilerGenerated]
	public SharedStringCollection get_SharedStrings() { }

	protected virtual string GetKeyForItem(WorkSheet item) { }

	public void Merge() { }

	private void Read(ZipFile zip) { }

	[CompilerGenerated]
	private void set_SharedStrings(SharedStringCollection value) { }

}

