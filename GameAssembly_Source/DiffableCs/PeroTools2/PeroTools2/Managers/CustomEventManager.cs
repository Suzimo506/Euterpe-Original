namespace PeroTools2.Managers;

public class CustomEventManager : SingletonScriptableObject<CustomEventManager>
{
	internal struct CustomEvent
	{
		public uint id; //Field offset: 0x0
		public string comment; //Field offset: 0x8

	}

	[CompilerGenerated]
	private Dictionary<String, CustomEvent> <customEvents>k__BackingField; //Field offset: 0x58

	[SerializeField]
	public private Dictionary<String, CustomEvent> customEvents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public CustomEventManager() { }

	[CompilerGenerated]
	public Dictionary<String, CustomEvent> get_customEvents() { }

	[CompilerGenerated]
	private void set_customEvents(Dictionary<String, CustomEvent> value) { }

}

