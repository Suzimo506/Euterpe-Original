//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisAnimationStatePropertyModifier : VisBasePropertyModifier
{
	internal static class Defaults
	{
		public const AnimationStateProperty targetProperty = 1; //Field offset: 0x0
		public const string targetAnimation = "Idle"; //Field offset: 0x0

	}

	public AnimationStateProperty targetProperty; //Field offset: 0x50
	public string targetAnimation; //Field offset: 0x58

	public VisAnimationStatePropertyModifier() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

