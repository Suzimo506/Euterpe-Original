namespace PeroTools2.Datas.Values;

public class LayerMaskType : IValue, IBaseValue, IEquatable<LayerMask>
{
	[SerializeField]
	private LayerMask m_Result; //Field offset: 0x10
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

	public LayerMask result
	{
		 get { } //Length: 4
		 set { } //Length: 161
	}

	public LayerMaskType() { }

	[CompilerGenerated]
	public override void add_onResultChanged(ValueDelegate value) { }

	public override bool Equals(LayerMask other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public override Delegate get_onGenericResultChanged() { }

	public LayerMask get_result() { }

	[CompilerGenerated]
	public override void remove_onResultChanged(ValueDelegate value) { }

	[CompilerGenerated]
	public override void set_onGenericResultChanged(Delegate value) { }

	public void set_result(LayerMask value) { }

}

