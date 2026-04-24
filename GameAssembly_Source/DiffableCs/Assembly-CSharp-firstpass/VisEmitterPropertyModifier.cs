//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisEmitterPropertyModifier : VisBasePropertyModifier
{
	internal static class Defaults
	{
		public const EmitterProperty targetProperty = 2; //Field offset: 0x0

	}

	public EmitterProperty targetProperty; //Field offset: 0x50

	public VisEmitterPropertyModifier() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

