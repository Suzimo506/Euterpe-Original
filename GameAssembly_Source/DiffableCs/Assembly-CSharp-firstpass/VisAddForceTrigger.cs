//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisAddForceTrigger : VisBaseTrigger
{
	internal static class Defaults
	{
		public const float minControllerValue = 0; //Field offset: 0x64C10
		public const float maxControllerValue = 1; //Field offset: 0x64C4C
		public const float maxForceValue = 200; //Field offset: 0x64C50
		public const bool invertValue = False; //Field offset: 0x64C8E
		public static readonly Vector3 forceDirection; //Field offset: 0x64C90
		public const ForceMode forceMode = 1; //Field offset: 0x64CCE
		public const float minForceValue = 10; //Field offset: 0x2C927B4
		public const bool randomValue = False; //Field offset: 0x2C927B4
		public const ControllerSourceValue controllerValue = 0; //Field offset: 0x2C927BC

		private static Defaults() { }

	}

	public ControllerSourceValue controllerValue; //Field offset: 0x50
	public float minControllerValue; //Field offset: 0x54
	public float maxControllerValue; //Field offset: 0x58
	public float minForceValue; //Field offset: 0x5C
	public float maxForceValue; //Field offset: 0x60
	public bool invertValue; //Field offset: 0x64
	public bool randomValue; //Field offset: 0x65
	public Vector3 forceDirection; //Field offset: 0x68
	public ForceMode forceMode; //Field offset: 0x74

	public VisAddForceTrigger() { }

	public virtual void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	public virtual void Reset() { }

	public virtual void Start() { }

}

