namespace Rewired.Data;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor
{
	[CustomObfuscation]
	[SerializeField]
	private string _scriptingName; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	private string _alternateScriptingName; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	private bool _excludeFromExport; //Field offset: 0x48
	[CustomObfuscation]
	[SerializeField]
	private bool _useEditorElementTypeOverride; //Field offset: 0x49
	[CustomObfuscation]
	[SerializeField]
	private ControllerElementType _editorElementTypeOverride; //Field offset: 0x4C

	internal string alternateScriptingName
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal virtual ControllerElementType editorElementTypeOverride
	{
		internal get { } //Length: 4
	}

	internal ControllerTemplateElementType effectiveElementType
	{
		internal get { } //Length: 23
	}

	internal bool excludeFromExport
	{
		internal get { } //Length: 5
	}

	private override string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.alternateScriptingName
	{
		private get { } //Length: 5
	}

	private override string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.scriptingName
	{
		private get { } //Length: 5
	}

	internal string scriptingName
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal virtual bool useEditorElementTypeOverride
	{
		internal get { } //Length: 5
	}

	public ControllerTemplateElementIdentifier_Editor() { }

	public ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor unnamed_param_0) { }

	public virtual ControllerTemplateElementIdentifier Clone() { }

	internal string get_alternateScriptingName() { }

	internal virtual ControllerElementType get_editorElementTypeOverride() { }

	internal ControllerTemplateElementType get_effectiveElementType() { }

	internal bool get_excludeFromExport() { }

	internal string get_scriptingName() { }

	internal virtual bool get_useEditorElementTypeOverride() { }

	private override string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.get_alternateScriptingName() { }

	private override string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.get_scriptingName() { }

	internal void set_alternateScriptingName(string value) { }

	internal void set_scriptingName(string value) { }

}

