namespace Assets.Scripts.PeroTools.Commons;

[Extension]
public static class RandomUtils
{

	[Extension]
	public static object LRandom(IList array) { }

	[Extension]
	public static T Random(IList<T> array) { }

	[Extension]
	public static T Random(IList<T> array, out int index) { }

	public static int Random(int min, int max) { }

	public static float Random(float min, float max) { }

	public static int RandomEvent(IList<Single> probabilities, Action[] events) { }

}

