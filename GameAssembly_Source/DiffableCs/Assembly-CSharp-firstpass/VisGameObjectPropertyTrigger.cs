//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisGameObjectPropertyTrigger : VisBasePropertyTrigger
{
	internal static class Defaults
	{
		public const GameObjectProperty targetProperty = 12; //Field offset: 0x0

	}

	public GameObjectProperty targetProperty; //Field offset: 0x88

	public VisGameObjectPropertyTrigger() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

