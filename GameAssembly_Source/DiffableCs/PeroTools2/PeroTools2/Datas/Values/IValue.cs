namespace PeroTools2.Datas.Values;

public interface IValue : IBaseValue
{

	[Obsolete]
	public event ValueDelegate onResultChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Delegate onGenericResultChanged
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_onResultChanged(ValueDelegate value) { }

	public Delegate get_onGenericResultChanged() { }

	[CompilerGenerated]
	public void remove_onResultChanged(ValueDelegate value) { }

	public void set_onGenericResultChanged(Delegate value) { }

}

