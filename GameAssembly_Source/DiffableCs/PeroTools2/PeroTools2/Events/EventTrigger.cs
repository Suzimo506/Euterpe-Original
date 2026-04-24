namespace PeroTools2.Events;

public class EventTrigger
{
	private readonly uint m_Id; //Field offset: 0x10
	[CompilerGenerated]
	private BaseValueDelegate trigger; //Field offset: 0x18

	public event BaseValueDelegate trigger
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public uint id
	{
		 get { } //Length: 4
	}

	internal EventTrigger(uint id) { }

	[CompilerGenerated]
	public void add_trigger(BaseValueDelegate value) { }

	internal void ClearEvents() { }

	protected override void ClearEventsImpl() { }

	public uint get_id() { }

	internal void Play(IBaseValue value) { }

	[CompilerGenerated]
	public void remove_trigger(BaseValueDelegate value) { }

}

