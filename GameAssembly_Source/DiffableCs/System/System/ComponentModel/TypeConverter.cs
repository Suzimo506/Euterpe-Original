namespace System.ComponentModel;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TypeConverter
{
	internal abstract class SimplePropertyDescriptor : PropertyDescriptor
	{
		private Type componentType; //Field offset: 0x88
		private Type propertyType; //Field offset: 0x90

		public virtual Type ComponentType
		{
			 get { } //Length: 8
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 131
		}

		public virtual Type PropertyType
		{
			 get { } //Length: 8
		}

		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

		public virtual Type get_ComponentType() { }

		public virtual bool get_IsReadOnly() { }

		public virtual Type get_PropertyType() { }

		public virtual bool ShouldSerializeValue(object component) { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal class StandardValuesCollection : ICollection, IEnumerable
	{
		private ICollection values; //Field offset: 0x10
		private Array valueArray; //Field offset: 0x18

		public int Count
		{
			 get { } //Length: 93
		}

		private override int System.Collections.ICollection.Count
		{
			private get { } //Length: 93
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 3
		}

		public StandardValuesCollection(ICollection values) { }

		public void CopyTo(Array array, int index) { }

		public int get_Count() { }

		public IEnumerator GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override int System.Collections.ICollection.get_Count() { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior"; //Field offset: 0x6A7D6
	private static bool useCompatibleTypeConversion; //Field offset: 0x2C927B4

	private static bool UseCompatibleTypeConversion
	{
		private get { } //Length: 97
	}

	private static TypeConverter() { }

	public TypeConverter() { }

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public bool CanConvertFrom(Type sourceType) { }

	public bool CanConvertTo(Type destinationType) { }

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public object ConvertFrom(object value) { }

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public object ConvertFromInvariantString(string text) { }

	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	public object ConvertFromString(string text) { }

	public object ConvertTo(object value, Type destinationType) { }

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public string ConvertToInvariantString(object value) { }

	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	public string ConvertToString(object value) { }

	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	public object CreateInstance(IDictionary propertyValues) { }

	private static bool get_UseCompatibleTypeConversion() { }

	protected Exception GetConvertFromException(object value) { }

	protected Exception GetConvertToException(object value, Type destinationType) { }

	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	public bool GetCreateInstanceSupported() { }

	public PropertyDescriptorCollection GetProperties(object value) { }

	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	public bool GetPropertiesSupported() { }

	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	public ICollection GetStandardValues() { }

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public bool GetStandardValuesExclusive() { }

	public bool GetStandardValuesSupported() { }

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	public bool IsValid(object value) { }

	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, String[] names) { }

}

