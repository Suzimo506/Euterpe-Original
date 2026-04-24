namespace System.ComponentModel;

internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
{
	private class ReflectedTypeData
	{
		private Type _type; //Field offset: 0x10
		private AttributeCollection _attributes; //Field offset: 0x18
		private EventDescriptorCollection _events; //Field offset: 0x20
		private PropertyDescriptorCollection _properties; //Field offset: 0x28
		private TypeConverter _converter; //Field offset: 0x30
		private Object[] _editors; //Field offset: 0x38
		private Type[] _editorTypes; //Field offset: 0x40
		private int _editorCount; //Field offset: 0x48

		internal bool IsPopulated
		{
			internal get { } //Length: 35
		}

		internal ReflectedTypeData(Type type) { }

		internal bool get_IsPopulated() { }

		internal AttributeCollection GetAttributes() { }

		internal TypeConverter GetConverter(object instance) { }

		internal PropertyDescriptorCollection GetProperties() { }

		private Type GetTypeFromName(string typeName) { }

		internal void Refresh() { }

	}

	private static Type[] _typeConstructor; //Field offset: 0x0
	private static Hashtable _intrinsicTypeConverters; //Field offset: 0x8
	private static object _intrinsicReferenceKey; //Field offset: 0x10
	private static object _intrinsicNullableKey; //Field offset: 0x18
	private static object _dictionaryKey; //Field offset: 0x20
	private static Hashtable _propertyCache; //Field offset: 0x28
	private static Hashtable _attributeCache; //Field offset: 0x30
	private static Hashtable _extendedPropertyCache; //Field offset: 0x38
	private static readonly Guid _extenderProviderKey; //Field offset: 0x40
	private static readonly Guid _extenderPropertiesKey; //Field offset: 0x50
	private static readonly Guid _extenderProviderPropertiesKey; //Field offset: 0x60
	private static readonly Type[] _skipInterfaceAttributeList; //Field offset: 0x70
	private static object _internalSyncObject; //Field offset: 0x78
	private Hashtable _typeData; //Field offset: 0x20

	private static Hashtable IntrinsicTypeConverters
	{
		private get { } //Length: 1796
	}

	private static ReflectTypeDescriptionProvider() { }

	internal ReflectTypeDescriptionProvider() { }

	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	private static object CreateInstance(Type objectType, Type callingType) { }

	private static Hashtable get_IntrinsicTypeConverters() { }

	internal AttributeCollection GetAttributes(Type type) { }

	public virtual IDictionary GetCache(object instance) { }

	internal TypeConverter GetConverter(Type type, object instance) { }

	internal AttributeCollection GetExtendedAttributes(object instance) { }

	internal TypeConverter GetExtendedConverter(object instance) { }

	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	internal PropertyDescriptorCollection GetProperties(Type type) { }

	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	public virtual Type GetReflectionType(Type objectType, object instance) { }

	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	private static Type GetTypeFromName(string typeName) { }

	internal bool IsPopulated(Type type) { }

	private static Attribute[] ReflectGetAttributes(Type type) { }

	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	internal void Refresh(Type type) { }

	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

}

