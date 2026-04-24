namespace FlexFramework.Excel;

public abstract class TableMapperBase : MapperBase<T>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Int32[] rows; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal bool <Include>b__0(int i) { }

	}

	protected readonly List<Int32> excludes; //Field offset: 0x0
	protected int index; //Field offset: 0x0

	protected TableMapperBase`1(Type type) { }

	public T Exclude(Int32[] rows) { }

	public virtual void Extract() { }

	public T Include(Int32[] rows) { }

	public T IncludeAll() { }

}

