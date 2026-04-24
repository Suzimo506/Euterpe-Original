namespace System.Reflection;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComDefaultInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	public class ResolveEventHolder
	{

		public ResolveEventHolder() { }

	}

	public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
	{
		private Module module; //Field offset: 0x68

		public UnmanagedMemoryStreamForModule(Byte* pointer, long length, Module module) { }

		protected virtual void Dispose(bool disposing) { }

	}

	internal IntPtr _mono_assembly; //Field offset: 0x10
	private ResolveEventHolder resolve_event_holder; //Field offset: 0x18
	private object _evidence; //Field offset: 0x20
	private object _minimum; //Field offset: 0x28
	private object _optional; //Field offset: 0x30
	private object _refuse; //Field offset: 0x38
	private object _granted; //Field offset: 0x40
	private object _denied; //Field offset: 0x48
	private bool fromByteArray; //Field offset: 0x50
	private string assemblyName; //Field offset: 0x58

	public override string CodeBase
	{
		 get { } //Length: 7
	}

	internal bool FromByteArray
	{
		internal set { } //Length: 4
	}

	public override string FullName
	{
		 get { } //Length: 17
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		 get { } //Length: 3
	}

	public override string Location
	{
		 get { } //Length: 78
	}

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override bool ReflectionOnly
	{
		 get { } //Length: 5
	}

	protected Assembly() { }

	private static Exception CreateNIE() { }

	public virtual bool Equals(object o) { }

	private string get_code_base(bool escaped) { }

	public override string get_CodeBase() { }

	private string get_fullname() { }

	public override string get_FullName() { }

	public bool get_IsFullyTrusted() { }

	private string get_location() { }

	public override string get_Location() { }

	public override bool get_ReflectionOnly() { }

	internal static string GetAotId() { }

	public static Assembly GetAssembly(Type type) { }

	public static Assembly GetCallingAssembly() { }

	private string GetCodeBase(bool escaped) { }

	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override Object[] GetCustomAttributes(bool inherit) { }

	public static Assembly GetExecutingAssembly() { }

	private AssemblyNameFlags GetFlags() { }

	public virtual int GetHashCode() { }

	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	public override String[] GetManifestResourceNames() { }

	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	public override Stream GetManifestResourceStream(string name) { }

	public override Module GetModule(string name) { }

	public override Module[] GetModules(bool getResourceModules) { }

	internal override Module[] GetModulesInternal() { }

	public override AssemblyName GetName(bool copiedName) { }

	public override AssemblyName GetName() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal Byte[] GetPublicKey() { }

	internal string GetSimpleName() { }

	public override Type GetType(string name) { }

	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	public override Type GetType(string name, bool throwOnError) { }

	internal override Type[] GetTypes(bool exportedOnly) { }

	public override Type[] GetTypes() { }

	internal Version GetVersion() { }

	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public static Assembly Load(Byte[] rawAssembly) { }

	public static Assembly Load(string assemblyString) { }

	private static Assembly load_with_partial_name(string name, Evidence e) { }

	public static Assembly LoadFrom(string assemblyFile) { }

	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	[Obsolete]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	[Obsolete]
	public static Assembly LoadWithPartialName(string partialName) { }

	public static bool op_Equality(Assembly left, Assembly right) { }

	public static bool op_Inequality(Assembly left, Assembly right) { }

	internal void set_FromByteArray(bool value) { }

	public virtual string ToString() { }

}

