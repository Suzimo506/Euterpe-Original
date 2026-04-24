namespace Sirenix.Serialization;

public class DefaultSerializationBinder : TwoWaySerializationBinder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x68240

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__12_0(object sender, AssemblyLoadEventArgs args) { }

	}

	private static readonly object ASSEMBLY_LOOKUP_LOCK; //Field offset: 0x0
	private static readonly Dictionary<String, Assembly> assemblyNameLookUp; //Field offset: 0x8
	private static readonly Dictionary<String, Type> customTypeNameToTypeBindings; //Field offset: 0x10
	private static readonly object TYPETONAME_LOCK; //Field offset: 0x18
	private static readonly Dictionary<Type, String> nameMap; //Field offset: 0x20
	private static readonly object NAMETOTYPE_LOCK; //Field offset: 0x28
	private static readonly Dictionary<String, Type> typeMap; //Field offset: 0x30
	private static readonly List<String> genericArgNamesList; //Field offset: 0x38
	private static readonly List<Type> genericArgTypesList; //Field offset: 0x40
	private static readonly object ASSEMBLY_REGISTER_QUEUE_LOCK; //Field offset: 0x48
	private static readonly List<Assembly> assembliesQueuedForRegister; //Field offset: 0x50
	private static readonly List<AssemblyLoadEventArgs> assemblyLoadEventsQueuedForRegister; //Field offset: 0x58

	private static DefaultSerializationBinder() { }

	public DefaultSerializationBinder() { }

	public virtual string BindToName(Type type, DebugContext debugContext = null) { }

	public virtual Type BindToType(string typeName, DebugContext debugContext = null) { }

	public virtual bool ContainsType(string typeName) { }

	private Type ParseGenericAndOrArrayType(string typeName, DebugContext debugContext) { }

	private static void ParseName(string fullName, out string typeName, out string assemblyName) { }

	private Type ParseTypeName(string typeName, DebugContext debugContext) { }

	private static char Peek(string str, int i, int ahead) { }

	private static bool ReadGenericArg(string typeName, ref int i, out string argName) { }

	private static void RegisterAllQueuedAssembliesRepeating() { }

	private static void RegisterAssembly(Assembly assembly) { }

	private static bool RegisterQueuedAssemblies() { }

	private static bool RegisterQueuedAssemblyLoadEvents() { }

	private static bool TryParseGenericAndOrArrayTypeName(string typeName, out string actualTypeName, out bool isGeneric, out List<String>& genericArgNames, out bool isArray, out int arrayRank) { }

}

