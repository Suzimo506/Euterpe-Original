//Type is in global namespace

public abstract class VisBasePropertyTrigger : VisBaseTrigger
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
		public const bool limitIncreaseRate = False; //Field offset: 0x0
		public const float increaseRate = 1; //Field offset: 0x0
		public const bool limitDecreaseRate = False; //Field offset: 0x0
		public const float decreaseRate = 1; //Field offset: 0x0
		public const bool returnToRest = False; //Field offset: 0x0
		public const float restValue = 0; //Field offset: 0x0

	}

	public ControllerSourceValue controllerSourceValue; //Field offset: 0x50
	public float minControllerValue; //Field offset: 0x54
	public float maxControllerValue; //Field offset: 0x58
	public float minPropertyValue; //Field offset: 0x5C
	public float maxPropertyValue; //Field offset: 0x60
	public bool invertValue; //Field offset: 0x64
	public bool randomValue; //Field offset: 0x65
	public bool limitIncreaseRate; //Field offset: 0x66
	public float increaseRate; //Field offset: 0x68
	public bool limitDecreaseRate; //Field offset: 0x6C
	public float decreaseRate; //Field offset: 0x70
	public bool returnToRest; //Field offset: 0x74
	public float restValue; //Field offset: 0x78
	protected float m_fTargetPropertyValue; //Field offset: 0x7C
	protected float m_fCurrentPropertyValue; //Field offset: 0x80

	protected VisBasePropertyTrigger() { }

	public virtual void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	public virtual void Reset() { }

	public abstract void SetProperty(float propertyValue) { }

	public virtual void Start() { }

	public virtual void Update() { }

}

