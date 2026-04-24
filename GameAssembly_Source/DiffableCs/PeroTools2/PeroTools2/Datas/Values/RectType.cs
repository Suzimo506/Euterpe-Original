namespace PeroTools2.Datas.Values;

public class RectType : IValue, IBaseValue, IEquatable<Rect>
{
	[SerializeField]
	private Rect m_Result; //Field offset: 0x10
	[CompilerGenerated]
	private ValueDelegate onResultChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Delegate <onGenericResultChanged>k__BackingField; //Field offset: 0x28

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

	public Rect result
	{
		 get { } //Length: 11
		 set { } //Length: 191
	}

	public RectType() { }

	[CompilerGenerated]
	public override void add_onResultChanged(ValueDelegate value) { }

	public override bool Equals(Rect other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public override Delegate get_onGenericResultChanged() { }

	public Rect get_result() { }

	[CompilerGenerated]
	public override void remove_onResultChanged(ValueDelegate value) { }

	[CompilerGenerated]
	public override void set_onGenericResultChanged(Delegate value) { }

	public void set_result(Rect value) { }

}

