namespace Rewired;

[Preserve]
public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable
{
	internal enum Type
	{
		All = 0,
		ControllerType = 1,
		HardwareType = 2,
		ControllerTemplateType = 3,
		PersistentControllerInstance = 4,
		SessionControllerInstance = 5,
	}

	[Serialize]
	[SerializeField]
	private Type _type; //Field offset: 0x10
	[Serialize]
	[SerializeField]
	private ControllerType _controllerType; //Field offset: 0x14
	[Serialize]
	[SerializeField]
	private string _guid; //Field offset: 0x18
	[Serialize]
	[SerializeField]
	private string _hardwareIdentifier; //Field offset: 0x20
	[Serialize]
	[SerializeField]
	private int _controllerId; //Field offset: 0x28
	private Guid lzXoJnVVZeijCreNKbUGdwImbQn; //Field offset: 0x2C

	internal bool BKfpzOncXOGdsKHMrRfXqUNztKASA
	{
		internal get { } //Length: 8
	}

	public int controllerId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Guid controllerTemplateTypeGuid
	{
		 get { } //Length: 137
		 set { } //Length: 216
	}

	public ControllerType controllerType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Guid deviceInstanceGuid
	{
		 get { } //Length: 137
		 set { } //Length: 216
	}

	public string hardwareIdentifier
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Guid hardwareTypeGuid
	{
		 get { } //Length: 137
		 set { } //Length: 216
	}

	public Type type
	{
		 get { } //Length: 4
		 set { } //Length: 158
	}

	internal ControllerSetSelector(Type unnamed_param_0) { }

	public ControllerSetSelector() { }

	public ControllerSetSelector(ControllerSetSelector unnamed_param_0) { }

	internal ControllerSetSelector(Type unnamed_param_0, ControllerType unnamed_param_1, string unnamed_param_2, string unnamed_param_3, int unnamed_param_4) { }

	public int get_controllerId() { }

	public Guid get_controllerTemplateTypeGuid() { }

	public ControllerType get_controllerType() { }

	public Guid get_deviceInstanceGuid() { }

	public string get_hardwareIdentifier() { }

	public Guid get_hardwareTypeGuid() { }

	public Type get_type() { }

	internal bool iUrdlZemxceIjsqhfgGNcvRULsScb() { }

	public bool Matches(Controller controller) { }

	private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	public static ControllerSetSelector SelectAll() { }

	public static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate) { }

	public static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid) { }

	public static ControllerSetSelector SelectControllerType(ControllerType controllerType) { }

	public static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier) { }

	public static ControllerSetSelector SelectHardwareType(Controller controller) { }

	public static ControllerSetSelector SelectPersistentControllerInstance(Controller controller) { }

	public static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid) { }

	public static ControllerSetSelector SelectSessionControllerInstance(Controller controller) { }

	public static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId) { }

	public void set_controllerId(int value) { }

	public void set_controllerTemplateTypeGuid(Guid value) { }

	public void set_controllerType(ControllerType value) { }

	public void set_deviceInstanceGuid(Guid value) { }

	public void set_hardwareIdentifier(string value) { }

	public void set_hardwareTypeGuid(Guid value) { }

	public void set_type(Type value) { }

	public virtual string ToString() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private void yoVaPyGXOnLwUvtHjgRoBFEGrMIF() { }

}

