namespace FlexFramework.Excel;

public sealed class Document : Table
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Row, Row> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Row <DeepClone>b__10_0(Row row) { }

	}

	public static char Delimiter; //Field offset: 0x0
	public static char Enclose; //Field offset: 0x2

	private static Document() { }

	public Document(IList<Row> list) { }

	public Document() { }

	public virtual Table DeepClone() { }

	public static Document Load(string content) { }

	public static Document Load(Stream stream) { }

	public static Document Load(Byte[] buffer) { }

	public static Document Load(TextReader reader) { }

	public static Document LoadAt(string path) { }

	public static void Reset() { }

	public virtual Table ShallowClone() { }

}

