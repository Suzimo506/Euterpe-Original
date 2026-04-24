namespace UnityEngine.Events;

internal class PersistentCall
{
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private object m_Target; //Field offset: 0x10
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_MethodName; //Field offset: 0x18
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private PersistentListenerMode m_Mode; //Field offset: 0x20
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private ArgumentCache m_Arguments; //Field offset: 0x28
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private UnityEventCallState m_CallState; //Field offset: 0x30

	public ArgumentCache arguments
	{
		 get { } //Length: 7
	}

	public string methodName
	{
		 get { } //Length: 7
	}

	public PersistentListenerMode mode
	{
		 get { } //Length: 6
	}

	public object target
	{
		 get { } //Length: 7
	}

	public PersistentCall() { }

	public ArgumentCache get_arguments() { }

	public string get_methodName() { }

	public PersistentListenerMode get_mode() { }

	public object get_target() { }

	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	public bool IsValid() { }

}

