namespace UnityEngine.InputSystem.Composites;

[DisplayName]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OneModifierComposite : InputBindingComposite
{
	[InputControl]
	public int modifier; //Field offset: 0x10
	[InputControl]
	public int binding; //Field offset: 0x14
	private int m_ValueSizeInBytes; //Field offset: 0x18
	private Type m_ValueType; //Field offset: 0x20

	public virtual int valueSizeInBytes
	{
		 get { } //Length: 4
	}

	public virtual Type valueType
	{
		 get { } //Length: 5
	}

	public OneModifierComposite() { }

	internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes) { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	public virtual int get_valueSizeInBytes() { }

	public virtual Type get_valueType() { }

	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

