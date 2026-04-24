namespace UnityEngine.UIElements.StyleSheets;

internal static class StyleSheetCache
{
	private struct SheetHandleKey
	{
		public readonly int sheetInstanceID; //Field offset: 0x0
		public readonly int index; //Field offset: 0x4

	}

	private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey>
	{

		public SheetHandleKeyComparer() { }

		public override bool Equals(SheetHandleKey x, SheetHandleKey y) { }

		public override int GetHashCode(SheetHandleKey key) { }

	}

	private static SheetHandleKeyComparer s_Comparer; //Field offset: 0x0
	private static Dictionary<SheetHandleKey, Int32> s_EnumToIntCache; //Field offset: 0x8
	private static Dictionary<SheetHandleKey, StylePropertyID[]> s_RulePropertyIDsCache; //Field offset: 0x10
	private static Dictionary<String, StylePropertyID> s_NameToIDCache; //Field offset: 0x18
	private static StyleValue[] s_InitialStyleValues; //Field offset: 0x20
	private static Dictionary<String, String> s_DeprecatedNames; //Field offset: 0x28

	private static StyleSheetCache() { }

	internal static StyleValue GetInitialValue(StylePropertyID propertyId) { }

}

