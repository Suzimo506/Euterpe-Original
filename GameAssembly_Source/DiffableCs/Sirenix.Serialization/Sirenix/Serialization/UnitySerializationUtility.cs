namespace Sirenix.Serialization;

public static class UnitySerializationUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<PrefabModification> <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SerializePrefabModifications>b__33_0(PrefabModification a, PrefabModification b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public MemberInfo member; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal object <GetCachedUnityMemberGetter>b__0(ref object instance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public MemberInfo member; //Field offset: 0x10

		public <>c__DisplayClass40_0() { }

		internal void <GetCachedUnityMemberSetter>b__0(ref object instance, object value) { }

	}

	private struct CachedSerializationBackendResult
	{
		public bool HasCalculatedSerializeUnityFieldsTrueResult; //Field offset: 0x0
		public bool HasCalculatedSerializeUnityFieldsFalseResult; //Field offset: 0x1
		public bool SerializeUnityFieldsTrueResult; //Field offset: 0x2
		public bool SerializeUnityFieldsFalseResult; //Field offset: 0x3

	}

	public static readonly Type SerializeReferenceAttributeType; //Field offset: 0x0
	private static readonly Assembly String_Assembly; //Field offset: 0x8
	private static readonly Assembly HashSet_Assembly; //Field offset: 0x10
	private static readonly Assembly LinkedList_Assembly; //Field offset: 0x18
	private static readonly Dictionary<MemberInfo, WeakValueGetter> UnityMemberGetters; //Field offset: 0x20
	private static readonly Dictionary<MemberInfo, WeakValueSetter> UnityMemberSetters; //Field offset: 0x28
	private static readonly Dictionary<MemberInfo, Boolean> UnityWillSerializeMembersCache; //Field offset: 0x30
	private static readonly Dictionary<Type, Boolean> UnityWillSerializeTypesCache; //Field offset: 0x38
	private static readonly HashSet<Type> UnityNeverSerializesTypes; //Field offset: 0x40
	private static readonly HashSet<String> UnityNeverSerializesTypeNames; //Field offset: 0x48
	private static readonly ISerializationPolicy UnityPolicy; //Field offset: 0x50
	private static readonly ISerializationPolicy EverythingPolicy; //Field offset: 0x58
	private static readonly ISerializationPolicy StrictPolicy; //Field offset: 0x60
	private static readonly Dictionary<MemberInfo, CachedSerializationBackendResult> OdinWillSerializeCache_UnityPolicy; //Field offset: 0x68
	private static readonly Dictionary<MemberInfo, CachedSerializationBackendResult> OdinWillSerializeCache_EverythingPolicy; //Field offset: 0x70
	private static readonly Dictionary<MemberInfo, CachedSerializationBackendResult> OdinWillSerializeCache_StrictPolicy; //Field offset: 0x78
	private static readonly Dictionary<ISerializationPolicy, Dictionary`2<MemberInfo, CachedSerializationBackendResult>> OdinWillSerializeCache_CustomPolicies; //Field offset: 0x80

	private static UnitySerializationUtility() { }

	private static void ApplyPrefabModifications(object unityObject, List<String> modificationData, List<Object> referencedUnityObjects) { }

	private static bool CalculateOdinWillSerialize(MemberInfo member, bool serializeUnityFields, ISerializationPolicy policy) { }

	private static object CreateDefaultUnityInitializedObject(Type type, int depth) { }

	public static object CreateDefaultUnityInitializedObject(Type type) { }

	public static List<PrefabModification> DeserializePrefabModifications(List<String> modifications, List<Object> referencedUnityObjects) { }

	public static void DeserializeUnityObject(object unityObject, IDataReader reader) { }

	public static void DeserializeUnityObject(object unityObject, ref Byte[] bytes, ref List<Object>& referencedUnityObjects, DataFormat format, DeserializationContext context = null) { }

	private static void DeserializeUnityObject(object unityObject, ref SerializationData data, DeserializationContext context, bool isPrefabData, List<Object> prefabInstanceUnityObjects) { }

	public static void DeserializeUnityObject(object unityObject, ref SerializationData data, DeserializationContext context = null) { }

	public static void DeserializeUnityObject(object unityObject, ref string base64Bytes, ref List<Object>& referencedUnityObjects, DataFormat format, DeserializationContext context = null) { }

	private static WeakValueGetter GetCachedUnityMemberGetter(MemberInfo member) { }

	private static WeakValueSetter GetCachedUnityMemberSetter(MemberInfo member) { }

	private static ICache GetCachedUnityReader(DataFormat format, Stream stream, DeserializationContext context) { }

	private static ICache GetCachedUnityWriter(DataFormat format, Stream stream, SerializationContext context) { }

	private static string GetStringFromStreamAndReset(Stream stream) { }

	public static bool GuessIfUnityWillSerialize(Type type) { }

	public static bool GuessIfUnityWillSerialize(MemberInfo member) { }

	private static bool GuessIfUnityWillSerializePrivate(Type type) { }

	private static bool GuessIfUnityWillSerializePrivate(MemberInfo member) { }

	public static bool OdinWillSerialize(MemberInfo member, bool serializeUnityFields, ISerializationPolicy policy = null) { }

	public static List<String> SerializePrefabModifications(List<PrefabModification> modifications, ref List<Object>& referencedUnityObjects) { }

	public static void SerializeUnityObject(object unityObject, ref Byte[] bytes, ref List<Object>& referencedUnityObjects, DataFormat format, bool serializeUnityFields = false, SerializationContext context = null) { }

	public static void SerializeUnityObject(object unityObject, ref string base64Bytes, ref List<Object>& referencedUnityObjects, DataFormat format, bool serializeUnityFields = false, SerializationContext context = null) { }

	public static void SerializeUnityObject(object unityObject, ref SerializationData data, bool serializeUnityFields = false, SerializationContext context = null) { }

	public static void SerializeUnityObject(object unityObject, IDataWriter writer, bool serializeUnityFields = false) { }

}

