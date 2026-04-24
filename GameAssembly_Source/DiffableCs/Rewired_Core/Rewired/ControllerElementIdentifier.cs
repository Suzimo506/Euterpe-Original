namespace Rewired;

[CustomClassObfuscation]
public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal
{
	private static ControllerElementIdentifier OahKnWGoFnhRfjXuaPVxHHEIqnO; //Field offset: 0x0
	[CustomObfuscation]
	[SerializeField]
	private int _id; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private string _name; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private string _positiveName; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private string _negativeName; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	private ControllerElementType _elementType; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	private CompoundControllerElementType _compoundElementType; //Field offset: 0x34
	internal readonly bool isMappableOnPlatform; //Field offset: 0x38
	private bool UFChGqanKEUpdhEsVHyJxLINywbqA; //Field offset: 0x39

	internal static ControllerElementIdentifier BlankReadOnly
	{
		internal get { } //Length: 135
	}

	public CompoundControllerElementType compoundElementType
	{
		 get { } //Length: 4
	}

	public ControllerElementType elementType
	{
		 get { } //Length: 4
	}

	public override int id
	{
		 get { } //Length: 4
	}

	internal bool isCompoundElement
	{
		internal get { } //Length: 8
	}

	public internal override string name
	{
		 get { } //Length: 5
		internal set { } //Length: 122
	}

	public internal override string negativeName
	{
		 get { } //Length: 5
		internal set { } //Length: 122
	}

	public internal override string positiveName
	{
		 get { } //Length: 5
		internal set { } //Length: 122
	}

	private override ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride
	{
		private get { } //Length: 4
	}

	private override object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType
	{
		private get { } //Length: 66
	}

	private override bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride
	{
		private get { } //Length: 3
	}

	public ControllerElementIdentifier(ControllerElementIdentifier unnamed_param_0) { }

	internal ControllerElementIdentifier(ControllerElementIdentifier unnamed_param_0, bool unnamed_param_1, ControllerElementType unnamed_param_2) { }

	internal ControllerElementIdentifier(int unnamed_param_0, string unnamed_param_1, string unnamed_param_2, string unnamed_param_3, ControllerElementType unnamed_param_4, bool unnamed_param_5) { }

	internal ControllerElementIdentifier(int unnamed_param_0, string unnamed_param_1, string unnamed_param_2, string unnamed_param_3, ControllerElementType unnamed_param_4, CompoundControllerElementType unnamed_param_5, bool unnamed_param_6) { }

	public ControllerElementIdentifier() { }

	public ControllerElementIdentifier Clone() { }

	internal static ControllerElementIdentifier get_BlankReadOnly() { }

	public CompoundControllerElementType get_compoundElementType() { }

	public ControllerElementType get_elementType() { }

	public override int get_id() { }

	internal bool get_isCompoundElement() { }

	public override string get_name() { }

	public override string get_negativeName() { }

	public override string get_positiveName() { }

	public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange) { }

	public string GetDisplayName(AxisRange axisRange) { }

	private void kEVbyEGYixlsyStfwQSlFTBkPbBwA() { }

	private override ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_editorElementTypeOverride() { }

	private override object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_elementType() { }

	private override bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_useEditorElementTypeOverride() { }

	internal void set_name(string value) { }

	internal void set_negativeName(string value) { }

	internal void set_positiveName(string value) { }

}

