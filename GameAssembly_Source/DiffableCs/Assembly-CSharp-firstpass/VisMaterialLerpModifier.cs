//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisMaterialLerpModifier : VisBasePropertyModifier
{
	internal static class Defaults
	{

	}

	public Material lerpFromMaterial; //Field offset: 0x50
	public Material lerpToMaterial; //Field offset: 0x58

	public VisMaterialLerpModifier() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

