namespace PeroTools2.Datas.Values;

public class GameObjectType : IValue, IBaseValue
{
	[SerializeField]
	private GameObject m_Result; //Field offset: 0x10
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

	public GameObject result
	{
		 get { } //Length: 5
		 set { } //Length: 217
	}

	public GameObjectType() { }

	[CompilerGenerated]
	public override void add_onResultChanged(ValueDelegate value) { }

	[CompilerGenerated]
	public override Delegate get_onGenericResultChanged() { }

	public GameObject get_result() { }

	[CompilerGenerated]
	public override void remove_onResultChanged(ValueDelegate value) { }

	[CompilerGenerated]
	public override void set_onGenericResultChanged(Delegate value) { }

	public void set_result(GameObject value) { }

}

