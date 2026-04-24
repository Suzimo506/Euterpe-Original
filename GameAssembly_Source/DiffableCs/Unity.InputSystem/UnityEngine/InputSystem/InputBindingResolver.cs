namespace UnityEngine.InputSystem;

internal struct InputBindingResolver : IDisposable
{
	public int totalProcessorCount; //Field offset: 0x0
	public int totalCompositeCount; //Field offset: 0x4
	public int totalInteractionCount; //Field offset: 0x8
	public InputActionMap[] maps; //Field offset: 0x10
	public InputControl[] controls; //Field offset: 0x18
	public UnmanagedMemory memory; //Field offset: 0x20
	public IInputInteraction[] interactions; //Field offset: 0x90
	public InputProcessor[] processors; //Field offset: 0x98
	public InputBindingComposite[] composites; //Field offset: 0xA0
	public Nullable<InputBinding> bindingMask; //Field offset: 0xA8
	private List<NameAndParameters> m_Parameters; //Field offset: 0x108

	public int totalActionCount
	{
		 get { } //Length: 4
	}

	public int totalBindingCount
	{
		 get { } //Length: 4
	}

	public int totalControlCount
	{
		 get { } //Length: 4
	}

	public int totalMapCount
	{
		 get { } //Length: 4
	}

	public void AddActionMap(InputActionMap map) { }

	private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) { }

	public override void Dispose() { }

	public int get_totalActionCount() { }

	public int get_totalBindingCount() { }

	public int get_totalControlCount() { }

	public int get_totalMapCount() { }

	private static InputBindingComposite InstantiateBindingComposite(string nameAndParameters) { }

	private int ResolveInteractions(string interactionString) { }

	private int ResolveProcessors(string processorString) { }

	public void StartWithArraysFrom(InputActionState state) { }

}

