//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisMaterialLerpTrigger : VisBasePropertyTrigger
{
	internal static class Defaults
	{

	}

	public Material lerpFromMaterial; //Field offset: 0x88
	public Material lerpToMaterial; //Field offset: 0x90

	public VisMaterialLerpTrigger() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

