//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisEmitterPropertyTrigger : VisBasePropertyTrigger
{
	internal static class Defaults
	{
		public const EmitterProperty targetProperty = 2; //Field offset: 0x0

	}

	public EmitterProperty targetProperty; //Field offset: 0x88

	public VisEmitterPropertyTrigger() { }

	public virtual void SetProperty(float propertyValue) { }

}

