//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisLightPropertyModifier : VisBasePropertyModifier
{
	internal static class Defaults
	{
		public const LightProperty targetProperty = 5; //Field offset: 0x0

	}

	public LightProperty targetProperty; //Field offset: 0x50

	public VisLightPropertyModifier() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

