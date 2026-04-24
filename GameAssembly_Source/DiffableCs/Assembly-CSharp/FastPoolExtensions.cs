//Type is in global namespace

[Extension]
public static class FastPoolExtensions
{

	[Extension]
	public static void FastDestroy(GameObject objectToDestroy, GameObject sourcePrefab) { }

	[Extension]
	public static void FastDestroy(GameObject objectToDestroy, Component sourcePrefab) { }

	[Extension]
	public static void FastDestroy(GameObject objectToDestroy, FastPool pool) { }

	[Extension]
	public static void FastDestroy(GameObject objectToDestroy, int poolID) { }

	[Extension]
	public static GameObject FastInstantiate(GameObject sourcePrefab, Transform parentTransform = null) { }

	[Extension]
	public static GameObject FastInstantiate(GameObject sourcePrefab, Vector3 position, Quaternion rotation, Transform parentTransform = null) { }

	[Extension]
	public static GameObject FastInstantiate(GameObject sourcePrefab, int poolID, Transform parentTransform = null) { }

	[Extension]
	public static GameObject FastInstantiate(GameObject sourcePrefab, int poolID, Vector3 position, Quaternion rotation, Transform parentTransform = null) { }

}

