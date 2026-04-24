namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Preserve]
internal sealed class SerializedObject : IEnumerable, IEnumerable<Field>, IAddValue<Object>, IAddKeyValue<String, Object>, IExportToXml, IExportToJson
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal struct Enumerator : IDisposable, IEnumerator, IEnumerator<Field>
	{
		private IndexedDictionary<String, RyoxxRCSFeGcEIeIGhLLElLfmbcf> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
		private Field RBNngEyRausHCyQGCZHTYRuPppaE; //Field offset: 0x8
		private IEnumerator<KeyValuePair`2<String, RyoxxRCSFeGcEIeIGhLLElLfmbcf>> sZfwWiJfPlHYVZZCFaRFIPFAYQam; //Field offset: 0x28

		public override Field Current
		{
			 get { } //Length: 19
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 77
		}

		internal Enumerator(object unnamed_param_0) { }

		public override void Dispose() { }

		public override Field get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal struct Field
	{
		public string name; //Field offset: 0x0
		public object value; //Field offset: 0x8
		public Type type; //Field offset: 0x10
		public FieldOptions options; //Field offset: 0x18

		public Field(string unnamed_param_0, object unnamed_param_1, Type unnamed_param_2, FieldOptions unnamed_param_3) { }

		public virtual string ToString() { }

	}

	[CustomObfuscation]
	[Flags]
	internal enum FieldOptions
	{
		None = 0,
		ExculdeFromXml = 1,
	}

	[CustomObfuscation]
	internal enum ObjectType
	{
		Object = 0,
		List = 1,
	}

	[CompilerGenerated]
	private sealed class oYoanMTAmELhdpufuJxGyZbypvKl
	{
		public static readonly oYoanMTAmELhdpufuJxGyZbypvKl <>9; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__63_0; //Field offset: 0x8
		public static Func<FieldInfo, String> <>9__63_1; //Field offset: 0x10
		public static Func<PropertyInfo, Boolean> <>9__63_2; //Field offset: 0x18
		public static Func<PropertyInfo, String> <>9__63_3; //Field offset: 0x20

		private static oYoanMTAmELhdpufuJxGyZbypvKl() { }

		public oYoanMTAmELhdpufuJxGyZbypvKl() { }

		internal string bZEqHJnzaOofSmcGwdpOtCGymzj(PropertyInfo unnamed_param_0) { }

		internal bool LMTqhsHTxsocIPltATtAwQdkGSlA(FieldInfo unnamed_param_0) { }

		internal bool wiPDikgqYsMioGrRTFfnfnvXJpJzA(PropertyInfo unnamed_param_0) { }

		internal string XwBxQdqeMsoKNDJlkZnOplMTnOzC(FieldInfo unnamed_param_0) { }

	}

	private struct RyoxxRCSFeGcEIeIGhLLElLfmbcf
	{
		public Type xnMKmLenorEMKCtKNVOAWcAVDjlBb; //Field offset: 0x0
		public object zRUQZDXXBkLNTaHWFlnOtpiXDsdt; //Field offset: 0x8
		public FieldOptions bjLYFyJlOtdQYlyBWNcsEDaLoEwd; //Field offset: 0x10

		public RyoxxRCSFeGcEIeIGhLLElLfmbcf(Type unnamed_param_0, object unnamed_param_1, FieldOptions unnamed_param_2) { }

		public virtual string YzUAmVZkidOyHulMUsNJKjhAkobF() { }

	}

	private class uocbNXKXuYcbSjIQEvHdrlZhQKqV
	{
		internal class JCTeobekrwMWptRoojZwghwsWRPpA
		{
			public readonly string wiPYqTOgGUWMzSeLFKhoYPvwuMJC; //Field offset: 0x10
			public readonly JCTeobekrwMWptRoojZwghwsWRPpA atZgslCuqsNRGiPhzHowhdKsEUdxA; //Field offset: 0x18
			public string xJsWHtatFwumWqcNxEcyLqpExOVv; //Field offset: 0x20
			public Dictionary<String, String> XYcJWcnsIeAQGQWIDcNQZdbjwpzu; //Field offset: 0x28
			public List<JCTeobekrwMWptRoojZwghwsWRPpA> ECOQRuUoFcpiDeZAGMbRASNiqaVf; //Field offset: 0x30

			public int KzAWkvOUEyFvpUcdHLbqrkGHTDus
			{
				 get { } //Length: 60
			}

			public int XsYaCGTUQVHDSpmoHenkdJvxmHsz
			{
				 get { } //Length: 70
			}

			public JCTeobekrwMWptRoojZwghwsWRPpA(string unnamed_param_0, JCTeobekrwMWptRoojZwghwsWRPpA unnamed_param_1) { }

			public void AqqyCRNnXWKfIKnDECfPzrQdFKhz(JCTeobekrwMWptRoojZwghwsWRPpA unnamed_param_0) { }

			public void ARBEfrhmuKxWkclARAmkeYIoBWYu(string unnamed_param_0, string unnamed_param_1) { }

			public JCTeobekrwMWptRoojZwghwsWRPpA DHWutqoNitUDJBmqhAOrdcxmHJFW(string unnamed_param_0) { }

			public bool jxbfTohmHCwgQlAEmDPjpPuqolYZ(string unnamed_param_0) { }

			public object pCNiwCcenraHoCHCDfyAKcpcjvnwb() { }

			public int UDaJqRbhbQcZCVdeZVOZFKDyWHzt() { }

			public int WwtRwCNwJgeAUgvypJmiHtbebWDk() { }

			public virtual string YzUAmVZkidOyHulMUsNJKjhAkobF() { }

			private string YzUAmVZkidOyHulMUsNJKjhAkobF(string unnamed_param_0, int unnamed_param_1) { }

		}

		private readonly JCTeobekrwMWptRoojZwghwsWRPpA vQCEEncoFAZtbRPObiyFaBYOdfsdb; //Field offset: 0x10

		public JCTeobekrwMWptRoojZwghwsWRPpA BeHKiQqjJqyozDYfDGgLcSGBljfY
		{
			 get { } //Length: 5
		}

		public bool MYyoenToyLcWvBbpEpbbtYnQCPTGb
		{
			 get { } //Length: 9
		}

		public uocbNXKXuYcbSjIQEvHdrlZhQKqV(string unnamed_param_0) { }

		public bool pzgUnXljbnBwMeFSFmaYCVphZuYR() { }

		public JCTeobekrwMWptRoojZwghwsWRPpA rYOJFbXHqIZKGkpKtPLAUQjOeZGL() { }

		private void vjQwQBwYDQFMzJCbATeOoVmNrVTU(XmlReader unnamed_param_0) { }

		public virtual string YzUAmVZkidOyHulMUsNJKjhAkobF() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class XmlInfo
	{
		internal class eBeNruLKbXcRidTjBrYEgCDsNImdA : TbNsBCFCOgfOWdffXBDYljpdCmBY
		{
			public string dzyGmGtXxNEiDAdqmcRBABakbDfLc; //Field offset: 0x10
			public string XcBzxvxeRVMcIiIzEnNTllOLqDTy; //Field offset: 0x18
			public string QOXZsoabJlOyOmHvfGsyGECldKSX; //Field offset: 0x20
			public string zRUQZDXXBkLNTaHWFlnOtpiXDsdt; //Field offset: 0x28

			public eBeNruLKbXcRidTjBrYEgCDsNImdA() { }

			public virtual string YzUAmVZkidOyHulMUsNJKjhAkobF() { }

		}

		internal abstract class TbNsBCFCOgfOWdffXBDYljpdCmBY
		{

			protected TbNsBCFCOgfOWdffXBDYljpdCmBY() { }

		}

		private List<TbNsBCFCOgfOWdffXBDYljpdCmBY> anrtoqQnQqRMbtSuNhAXNhcacdpk; //Field offset: 0x10

		public List<TbNsBCFCOgfOWdffXBDYljpdCmBY> attributes
		{
			 get { } //Length: 110
		}

		public XmlInfo() { }

		public List<TbNsBCFCOgfOWdffXBDYljpdCmBY> get_attributes() { }

		public virtual string ToString() { }

	}

	private static readonly Dictionary<Type, Dictionary`2<String, FieldInfo>> KuSgNhtJxAFyOAgstzWCHxHwklHRA; //Field offset: 0x0
	private static readonly Dictionary<Type, Dictionary`2<String, PropertyInfo>> gZJzglmaXaZKeyxoxiAeLIYviVMO; //Field offset: 0x8
	private readonly IndexedDictionary<String, RyoxxRCSFeGcEIeIGhLLElLfmbcf> IuNAUcZkbGNjRhBveluSeWHdBtwn; //Field offset: 0x10
	private XmlInfo UIbgSgjkylxEOLlWRlJowwbQNPuj; //Field offset: 0x18
	private Type MdraqIOVtXzaWmcbxlwwxKAyCuat; //Field offset: 0x20
	private ObjectType PjfkPheLXVcBphgawWNSxCcdqbkU; //Field offset: 0x28

	private bool allowDuplicateKeys
	{
		private get { } //Length: 8
	}

	public int count
	{
		 get { } //Length: 67
	}

	public Field Item
	{
		 get { } //Length: 200
	}

	public ObjectType objectType
	{
		 get { } //Length: 4
		 set { } //Length: 93
	}

	private override bool Rewired.Utils.Interfaces.IExportToXml.writesOwnElementTag
	{
		private get { } //Length: 3
	}

	public Type type
	{
		 get { } //Length: 5
	}

	public XmlInfo xmlInfo
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	private static SerializedObject() { }

	public SerializedObject(Type unnamed_param_0, IDictionary<String, Object> unnamed_param_1, ObjectType unnamed_param_2) { }

	public SerializedObject(Type unnamed_param_0, ObjectType unnamed_param_1, int unnamed_param_2) { }

	[CustomObfuscation]
	private SerializedObject() { }

	private SerializedObject(int unnamed_param_0) { }

	public SerializedObject(Type unnamed_param_0, ObjectType unnamed_param_1) { }

	public void Add(string fieldName, object value) { }

	public void Add(Type type, string fieldName, object value, FieldOptions options = 0) { }

	public void Add(string fieldName, T value, FieldOptions options = 0) { }

	private override void bGQFDwErauFDOaAzaGYzwOFBrsfdA(StringBuilder unnamed_param_0, Action<StringBuilder, Object> unnamed_param_1) { }

	public bool Contains(string fieldName) { }

	private override bool cXadNGCYGHherOOtaWYVNxbXiUNF() { }

	public static SerializedObject FromJson(Type type, string jsonString) { }

	public static SerializedObject FromXml(Type type, string xmlString) { }

	public int get_count() { }

	public Field get_Item(int index) { }

	public ObjectType get_objectType() { }

	public Type get_type() { }

	public XmlInfo get_xmlInfo() { }

	public Type GetDataType(string fieldName) { }

	public Field GetEntry(string fieldName) { }

	public T GetOriginalValue(int index) { }

	public T GetOriginalValue(string fieldName) { }

	public object GetOriginalValue(string fieldName) { }

	public object GetOriginalValue(int index) { }

	private override void lMCdEDXspcyGTzfkYKmZcaIGsusD(XmlWriter unnamed_param_0) { }

	private static bool ptDEYcbOrnsJXBPtqdKbIkZktZyQB(Type unnamed_param_0, SerializedObject unnamed_param_1, out object unnamed_param_2, NumberStyles unnamed_param_3 = 511, CultureInfo unnamed_param_4 = null) { }

	public bool Remove(string fieldName) { }

	private override void Rewired.Utils.Interfaces.IAddKeyValue<System.String,System.Object>.Add(string unnamed_param_0, object unnamed_param_1) { }

	private override void Rewired.Utils.Interfaces.IAddValue<System.Object>.Add(object unnamed_param_0) { }

	private void RGXWULiHDQwGdPpkVhtWVtXxQkbo(XmlWriter unnamed_param_0) { }

	private void rQdQBHYmlNJQDAVzQiCdUEutTMtV(XmlWriter unnamed_param_0) { }

	public void set_objectType(ObjectType value) { }

	public void set_xmlInfo(XmlInfo value) { }

	private override IEnumerator<Field> System.Collections.Generic.IEnumerable<Rewired.Utils.Classes.Data.SerializedObject.Field>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public string ToJsonString() { }

	public virtual string ToString() { }

	public string ToXmlString(bool writeDocumentTag) { }

	public bool TryGetDeserializedValue(int index, out T value) { }

	public bool TryGetDeserializedValue(string fieldName, out T value) { }

	public bool TryGetDeserializedValueByRef(int index, ref T value) { }

	public bool TryGetDeserializedValueByRef(string fieldName, ref T value) { }

	public bool TryGetOriginalValue(string fieldName, out object value) { }

	private bool wbmyiotgApgImXCsIvOFJaOpimul() { }

	private static bool YrhlFzALEpGSZCESvePqBpqQaAqCb(object unnamed_param_0, out  unnamed_param_1, NumberStyles unnamed_param_2 = 511, CultureInfo unnamed_param_3 = null) { }

	private static bool YrhlFzALEpGSZCESvePqBpqQaAqCb(Type unnamed_param_0, object unnamed_param_1, out object unnamed_param_2, NumberStyles unnamed_param_3 = 511, CultureInfo unnamed_param_4 = null) { }

}

