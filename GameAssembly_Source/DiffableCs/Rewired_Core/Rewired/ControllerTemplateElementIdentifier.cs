namespace Rewired;

[CustomClassObfuscation]
public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
{
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
	private ControllerTemplateElementType _elementType; //Field offset: 0x30
	internal readonly bool isMappableOnPlatform; //Field offset: 0x34

	internal override ControllerElementType editorElementTypeOverride
	{
		internal get { } //Length: 73
	}

	public override ControllerTemplateElementType elementType
	{
		 get { } //Length: 4
	}

	public override int id
	{
		 get { } //Length: 4
	}

	public internal override string name
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal override string negativeName
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal override string positiveName
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	private override ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride
	{
		private get { } //Length: 17
	}

	private override object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType
	{
		private get { } //Length: 66
	}

	private override bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride
	{
		private get { } //Length: 17
	}

	internal override bool useEditorElementTypeOverride
	{
		internal get { } //Length: 3
	}

	internal ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier unnamed_param_0, ControllerTemplateElementType unnamed_param_1, bool unnamed_param_2) { }

	internal ControllerTemplateElementIdentifier(int unnamed_param_0, string unnamed_param_1, string unnamed_param_2, string unnamed_param_3, ControllerTemplateElementType unnamed_param_4, bool unnamed_param_5) { }

	public ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier unnamed_param_0) { }

	public ControllerTemplateElementIdentifier() { }

	public override ControllerTemplateElementIdentifier Clone() { }

	internal override ControllerElementType get_editorElementTypeOverride() { }

	public override ControllerTemplateElementType get_elementType() { }

	public override int get_id() { }

	public override string get_name() { }

	public override string get_negativeName() { }

	public override string get_positiveName() { }

	internal override bool get_useEditorElementTypeOverride() { }

	public string GetDisplayName(AxisRange axisRange) { }

	private override ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_editorElementTypeOverride() { }

	private override object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_elementType() { }

	private override bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_useEditorElementTypeOverride() { }

	internal void set_name(string value) { }

	internal void set_negativeName(string value) { }

	internal void set_positiveName(string value) { }

	internal ControllerElementIdentifier ToControllerElementIdentifier() { }

}

