namespace Sirenix.Serialization;

public static class FormatterUtilities
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MemberInfo, String> <>9__15_0; //Field offset: 0x8
		public static Func<MemberInfo, MemberInfo> <>9__15_1; //Field offset: 0x10
		public static Func<MemberInfo, Boolean> <>9__16_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <FindSerializableMembers>b__16_0(MemberInfo n) { }

		internal string <FindSerializableMembersMap>b__15_0(MemberInfo n) { }

		internal MemberInfo <FindSerializableMembersMap>b__15_1(MemberInfo n) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public MemberInfo member; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <FindSerializableMembers>b__1(MemberInfo n) { }

	}

	private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, MemberInfo[]> MemberArrayCache; //Field offset: 0x0
	private const string UnityObjectRuntimeErrorString = "The variable nullValue of {0} has not been assigned.
You probably need to assign the nullValue variable of the {0} script in the inspector."; //Field offset: 0x0
	private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, Dictionary`2<String, MemberInfo>> MemberMapCache; //Field offset: 0x8
	private static readonly object LOCK; //Field offset: 0x10
	private static readonly HashSet<Type> PrimitiveArrayTypes; //Field offset: 0x18
	private static readonly FieldInfo UnityObjectRuntimeErrorStringField; //Field offset: 0x20

	private static FormatterUtilities() { }

	public static object CreateUnityNull(Type nullType, Type owningType) { }

	private static void FindSerializableMembers(Type type, List<MemberInfo> members, ISerializationPolicy policy) { }

	private static Dictionary<String, MemberInfo> FindSerializableMembersMap(Type type, ISerializationPolicy policy) { }

	public static Type GetContainedType(MemberInfo member) { }

	public static object GetMemberValue(MemberInfo member, object obj) { }

	internal static MemberInfo GetPrivateMemberAlias(MemberInfo member, string prefixString = null, string separatorString = null) { }

	public static MemberInfo[] GetSerializableMembers(Type type, ISerializationPolicy policy) { }

	public static Dictionary<String, MemberInfo> GetSerializableMembersMap(Type type, ISerializationPolicy policy) { }

	public static bool IsPrimitiveArrayType(Type type) { }

	public static bool IsPrimitiveType(Type type) { }

	private static bool MemberIsPrivate(MemberInfo member) { }

	public static void SetMemberValue(MemberInfo member, object obj, object value) { }

}

