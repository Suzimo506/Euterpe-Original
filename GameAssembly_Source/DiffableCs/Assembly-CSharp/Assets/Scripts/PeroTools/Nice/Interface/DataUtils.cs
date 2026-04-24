namespace Assets.Scripts.PeroTools.Nice.Interface;

[Extension]
public static class DataUtils
{

	[Extension]
	public static bool Exists(IData data, string uid) { }

	[Extension]
	public static T Get(IData data) { }

	[Extension]
	public static IVariable Get(IData data, string uid) { }

	[Extension]
	public static void Set(IData data, string uid, IVariable variable) { }

}

