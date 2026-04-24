//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisMaterialPropertyTrigger : VisBasePropertyTrigger
{
	internal static class Defaults
	{
		public const string targetProperty = ""; //Field offset: 0x0
		public const bool setAsProceduralMaterial = False; //Field offset: 0x0
		public const bool rebuildProceduralTexturesImmediately = False; //Field offset: 0x0
		public const bool applyToMaterialIndex = False; //Field offset: 0x0
		public const int materialIndex = 0; //Field offset: 0x0

	}

	public string targetProperty; //Field offset: 0x88
	public bool setAsProceduralMaterial; //Field offset: 0x90
	public bool rebuildProceduralTexturesImmediately; //Field offset: 0x91
	public bool applyToMaterialIndex; //Field offset: 0x92
	public int materialIndex; //Field offset: 0x94
	private bool specialTargetProperty; //Field offset: 0x98

	public VisMaterialPropertyTrigger() { }

	public virtual void Reset() { }

	public virtual void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

