namespace PeroTools2.Datas.Values;

public sealed class SheetType : IValue, IBaseValue
{
	[CompilerGenerated]
	private ValueDelegate onResultChanged; //Field offset: 0x10
	[SerializeField]
	private SheetData m_Result; //Field offset: 0x18
	private Delegate m_OnGenericResultChanged; //Field offset: 0x20

	private event ValueDelegate onResultChanged
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private override event ValueDelegate PeroTools2.Datas.Values.IValue.onResultChanged
	{
		private add { } //Length: 158
		private remove { } //Length: 158
	}

	private override Delegate PeroTools2.Datas.Values.IValue.onGenericResultChanged
	{
		private get { } //Length: 5
		private set { } //Length: 12
	}

	public SheetData result
	{
		 get { } //Length: 5
		 set { } //Length: 158
	}

	public SheetType(SheetData data) { }

	[CompilerGenerated]
	private void add_onResultChanged(ValueDelegate value) { }

	public SheetData get_result() { }

	private override void PeroTools2.Datas.Values.IValue.add_onResultChanged(ValueDelegate value) { }

	private override Delegate PeroTools2.Datas.Values.IValue.get_onGenericResultChanged() { }

	private override void PeroTools2.Datas.Values.IValue.remove_onResultChanged(ValueDelegate value) { }

	private override void PeroTools2.Datas.Values.IValue.set_onGenericResultChanged(Delegate value) { }

	[CompilerGenerated]
	private void remove_onResultChanged(ValueDelegate value) { }

	public void set_result(SheetData value) { }

}

