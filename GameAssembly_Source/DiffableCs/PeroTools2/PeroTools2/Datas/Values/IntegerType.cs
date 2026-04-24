namespace PeroTools2.Datas.Values;

public class IntegerType : IValue, IBaseValue, IEquatable<Int32>
{
	[SerializeField]
	private int m_Result; //Field offset: 0x10
	[CompilerGenerated]
	private ValueDelegate onResultChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Delegate <onGenericResultChanged>k__BackingField; //Field offset: 0x20

	public override event ValueDelegate onResultChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override Delegate onGenericResultChanged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public int result
	{
		 get { } //Length: 4
		 set { } //Length: 133
	}

	public IntegerType() { }

	[CompilerGenerated]
	public override void add_onResultChanged(ValueDelegate value) { }

	public override bool Equals(int other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public override Delegate get_onGenericResultChanged() { }

	public int get_result() { }

	[CompilerGenerated]
	public override void remove_onResultChanged(ValueDelegate value) { }

	[CompilerGenerated]
	public override void set_onGenericResultChanged(Delegate value) { }

	public void set_result(int value) { }

}

