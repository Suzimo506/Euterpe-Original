//Type is in global namespace

public abstract class VisBasePropertyModifier : VisBaseModifier
{
	internal static class Defaults
	{
		public const ControllerSourceValue controllerSourceValue = 0; //Field offset: 0x0
		public const float minControllerValue = 0; //Field offset: 0x0
		public const float maxControllerValue = 1; //Field offset: 0x0
		public const float minPropertyValue = -1; //Field offset: 0x0
		public const float maxPropertyValue = 1; //Field offset: 0x0
		public const bool invertValue = False; //Field offset: 0x0
		public const bool randomValue = True; //Field offset: 0x0

	}

	public ControllerSourceValue controllerSourceValue; //Field offset: 0x38
	public float minControllerValue; //Field offset: 0x3C
	public float maxControllerValue; //Field offset: 0x40
	public float minPropertyValue; //Field offset: 0x44
	public float maxPropertyValue; //Field offset: 0x48
	public bool invertValue; //Field offset: 0x4C

	protected VisBasePropertyModifier() { }

	public virtual void OnValueUpdated(float current, float previous, float difference, float adjustedDifference) { }

	public virtual void Reset() { }

	public abstract void SetProperty(float propertyValue) { }

	public virtual void Start() { }

}

