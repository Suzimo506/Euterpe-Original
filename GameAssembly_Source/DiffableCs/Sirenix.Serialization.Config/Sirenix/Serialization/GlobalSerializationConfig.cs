namespace Sirenix.Serialization;

[HideMonoScript]
[SirenixGlobalConfig]
public class GlobalSerializationConfig : GlobalConfig<GlobalSerializationConfig>
{
	public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin's custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.

*Words of caution* 
However, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.

Warning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!"; //Field offset: 0x0
	public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.

Using prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.

Please keep all this in mind, if you wish to continue using Odin-serialized prefabs."; //Field offset: 0x0
	public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I'm about, son. Hide message forever."; //Field offset: 0x0
	public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I'm on my own. Hide message forever."; //Field offset: 0x0
	private static readonly DataFormat[] BuildFormats; //Field offset: 0x0
	[DetailedInfoBox(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Title(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ToggleLeft]
	public bool HideSerializationCautionaryMessage; //Field offset: 0x18
	[DetailedInfoBox(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ToggleLeft]
	public bool HidePrefabCautionaryMessage; //Field offset: 0x19
	[InfoBox(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[ToggleLeft]
	public bool HideOdinSerializeAttributeWarningMessages; //Field offset: 0x1A
	[InfoBox(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[LabelText(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[ToggleLeft]
	public bool HideNonSerializedShowInInspectorWarningMessages; //Field offset: 0x1B
	[SerializeField]
	[Title(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ValueDropdown(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private DataFormat buildSerializationFormat; //Field offset: 0x1C
	[SerializeField]
	private DataFormat editorSerializationFormat; //Field offset: 0x20
	[SerializeField]
	[Title(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LoggingPolicy loggingPolicy; //Field offset: 0x24
	[SerializeField]
	private ErrorHandlingPolicy errorHandlingPolicy; //Field offset: 0x28

	public DataFormat BuildSerializationFormat
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public DataFormat EditorSerializationFormat
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ErrorHandlingPolicy ErrorHandlingPolicy
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ILogger Logger
	{
		 get { } //Length: 72
	}

	public LoggingPolicy LoggingPolicy
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private static GlobalSerializationConfig() { }

	public GlobalSerializationConfig() { }

	public DataFormat get_BuildSerializationFormat() { }

	public DataFormat get_EditorSerializationFormat() { }

	public ErrorHandlingPolicy get_ErrorHandlingPolicy() { }

	public ILogger get_Logger() { }

	public LoggingPolicy get_LoggingPolicy() { }

	[OnInspectorGUI]
	private void OnInspectorGUI() { }

	public void set_BuildSerializationFormat(DataFormat value) { }

	public void set_EditorSerializationFormat(DataFormat value) { }

	public void set_ErrorHandlingPolicy(ErrorHandlingPolicy value) { }

	public void set_LoggingPolicy(LoggingPolicy value) { }

}

