namespace PeroTools2.Commons;

[Extension]
public static class RandomUtils
{
	private static readonly Random s_Random; //Field offset: 0x6A1F0

	private static RandomUtils() { }

	[Extension]
	public static object LRandom(IList array) { }

	[Extension]
	public static T Random(IList<T> array) { }

	public static int Random(int min, int max) { }

	public static float Random(float min, float max) { }

	public static uint Random() { }

	public static int RandomEvent(IList<Single> probabilities, Action[] events) { }

}

