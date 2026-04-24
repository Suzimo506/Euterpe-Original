namespace PeroTools2.Datas.Values;

public class Vector2Type : IValue, IBaseValue, IEquatable<Vector2>
{
	[SerializeField]
	private Vector2 m_Result; //Field offset: 0x10
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

	public Vector2 result
	{
		 get { } //Length: 19
		 set { } //Length: 229
	}

	public Vector2Type() { }

	[CompilerGenerated]
	public override void add_onResultChanged(ValueDelegate value) { }

	public override bool Equals(Vector2 other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public override Delegate get_onGenericResultChanged() { }

	public Vector2 get_result() { }

	[CompilerGenerated]
	public override void remove_onResultChanged(ValueDelegate value) { }

	[CompilerGenerated]
	public override void set_onGenericResultChanged(Delegate value) { }

	public void set_result(Vector2 value) { }

}

