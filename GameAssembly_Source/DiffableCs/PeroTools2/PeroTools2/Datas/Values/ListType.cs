namespace PeroTools2.Datas.Values;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ListType : IValue, IBaseValue
{
	[SerializeField]
	private List<IValue> m_Result; //Field offset: 0x10
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

	public int count
	{
		 get { } //Length: 59
	}

	public IValue Item
	{
		 get { } //Length: 89
		 set { } //Length: 177
	}

	public override Delegate onGenericResultChanged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public List<IValue> result
	{
		 get { } //Length: 5
		 set { } //Length: 184
	}

	public ListType() { }

	[CompilerGenerated]
	public override void add_onResultChanged(ValueDelegate value) { }

	private IValue CustomAddFunction() { }

	public int get_count() { }

	public IValue get_Item(int index) { }

	[CompilerGenerated]
	public override Delegate get_onGenericResultChanged() { }

	public List<IValue> get_result() { }

	[CompilerGenerated]
	public override void remove_onResultChanged(ValueDelegate value) { }

	public void set_Item(int index, IValue value) { }

	[CompilerGenerated]
	public override void set_onGenericResultChanged(Delegate value) { }

	public void set_result(List<IValue> value) { }

}

