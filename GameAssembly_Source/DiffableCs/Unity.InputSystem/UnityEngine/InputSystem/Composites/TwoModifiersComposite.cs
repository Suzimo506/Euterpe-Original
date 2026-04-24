namespace UnityEngine.InputSystem.Composites;

[DisplayName]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TwoModifiersComposite : InputBindingComposite
{
	[InputControl]
	public int modifier1; //Field offset: 0x10
	[InputControl]
	public int modifier2; //Field offset: 0x14
	[InputControl]
	public int binding; //Field offset: 0x18
	private int m_ValueSizeInBytes; //Field offset: 0x1C
	private Type m_ValueType; //Field offset: 0x20

	public virtual int valueSizeInBytes
	{
		 get { } //Length: 4
	}

	public virtual Type valueType
	{
		 get { } //Length: 5
	}

	public TwoModifiersComposite() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	public virtual int get_valueSizeInBytes() { }

	public virtual Type get_valueType() { }

	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

