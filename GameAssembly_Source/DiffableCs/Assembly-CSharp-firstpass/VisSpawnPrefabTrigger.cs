//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisSpawnPrefabTrigger : VisBaseTrigger
{
	internal static class Defaults
	{
		public static readonly Vector3 randomOffset; //Field offset: 0x2C927B4

		private static Defaults() { }

	}

	public GameObject prefab; //Field offset: 0x50
	public Vector3 randomOffset; //Field offset: 0x58

	public VisSpawnPrefabTrigger() { }

	public virtual void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	public virtual void Reset() { }

	public virtual void Start() { }

}

