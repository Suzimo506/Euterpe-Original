//Type is in global namespace

public class EditorCoroutine
{
	private class Coroutine
	{
		public ICoroutineYield CurrentYield; //Field offset: 0x10
		public IEnumerator Routine; //Field offset: 0x18
		public string RoutineUniqueHash; //Field offset: 0x20
		public string OwnerUniqueHash; //Field offset: 0x28
		public string MethodName; //Field offset: 0x30
		public int OwnerHash; //Field offset: 0x38
		public string OwnerType; //Field offset: 0x40
		public bool Finished; //Field offset: 0x48

		public Coroutine(IEnumerator routine, int ownerHash, string ownerType) { }

		public Coroutine(string methodName, int ownerHash, string ownerType) { }

	}

	private abstract class ICoroutineYield
	{

		protected ICoroutineYield() { }

		public abstract bool IsDone(float deltaTime) { }

	}

	private class YieldAsync : ICoroutineYield
	{
		public AsyncOperation asyncOperation; //Field offset: 0x10

		public YieldAsync() { }

		public virtual bool IsDone(float deltaTime) { }

	}

	private class YieldDefault : ICoroutineYield
	{

		public YieldDefault() { }

		public virtual bool IsDone(float deltaTime) { }

	}

	private class YieldWaitForSeconds : ICoroutineYield
	{
		public float TimeLeft; //Field offset: 0x10

		public YieldWaitForSeconds() { }

		public virtual bool IsDone(float deltaTime) { }

	}

	private class YieldWWW : ICoroutineYield
	{
		public WWW Www; //Field offset: 0x10

		public YieldWWW() { }

		public virtual bool IsDone(float deltaTime) { }

	}

	private static EditorCoroutine instance; //Field offset: 0x0
	private Dictionary<String, List`1<Coroutine>> coroutineDict; //Field offset: 0x10
	private Dictionary<String, Dictionary`2<String, Coroutine>> coroutineOwnerDict; //Field offset: 0x18
	private DateTime previousTimeSinceStartup; //Field offset: 0x20

	private static EditorCoroutine() { }

	public EditorCoroutine() { }

	private Coroutine CreateCoroutine(IEnumerator routine, object thisReference) { }

	private Coroutine CreateCoroutineFromString(string methodName, object thisReference) { }

	private static void CreateInstanceIfNeeded() { }

	private static object GetInstanceField(Type type, object instance, string fieldName) { }

	private void GoStartCoroutine(Coroutine coroutine) { }

	private void GoStartCoroutine(IEnumerator routine, object thisReference) { }

	private void GoStopActualRoutine(Coroutine routine) { }

	private void GoStopAllCoroutines(object thisReference) { }

	private void GoStopCoroutine(IEnumerator routine, object thisReference) { }

	private void GoStopCoroutine(string methodName, object thisReference) { }

	private void Initialize() { }

	private bool MoveNext(Coroutine coroutine) { }

	private void OnUpdate() { }

	private bool Process(Coroutine coroutine) { }

	public static void StartCoroutine(string methodName, object value, object thisReference) { }

	public static void StartCoroutine(string methodName, object thisReference) { }

	public static void StartCoroutine(IEnumerator routine, object thisReference) { }

	public static void StopAllCoroutines(object thisReference) { }

	public static void StopCoroutine(string methodName, object thisReference) { }

	public static void StopCoroutine(IEnumerator routine, object thisReference) { }

	private static void Test() { }

}

