namespace UnityEngine.UIElements;

[Extension]
internal static class StyleValueExtensions
{

	[Extension]
	internal static string DebugString(IStyleValue<T> styleValue) { }

	[Extension]
	internal static StyleEnum<T> ToStyleEnum(StyleInt styleInt, T value) { }

	[Extension]
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[Extension]
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

}

