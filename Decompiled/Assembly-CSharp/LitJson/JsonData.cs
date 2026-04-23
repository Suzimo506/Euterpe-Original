using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Cpp2ILInjected;

namespace LitJson;

[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
[Token(Token = "0x20003F3")]
public class JsonData : IJsonWrapper, IList, IEquatable<JsonData>, ICollection, IOrderedDictionary, IDictionary, IEnumerable
{
	[Token(Token = "0x4001607")]
	[FieldOffset(Offset = "0x10")]
	private IList<JsonData> inst_array;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001608")]
	private bool inst_boolean;

	[Token(Token = "0x4001609")]
	[FieldOffset(Offset = "0x20")]
	private double inst_double;

	[Token(Token = "0x400160A")]
	[FieldOffset(Offset = "0x28")]
	private int inst_int;

	[Token(Token = "0x400160B")]
	[FieldOffset(Offset = "0x30")]
	private long inst_long;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400160C")]
	private IDictionary<string, JsonData> inst_object;

	[Token(Token = "0x400160D")]
	[FieldOffset(Offset = "0x40")]
	private string inst_string;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400160E")]
	private string json;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400160F")]
	private JsonType type;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001610")]
	private IList<KeyValuePair<string, JsonData>> object_list;

	[Token(Token = "0x17000423")]
	public int Count
	{
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x5C8EA0", Offset = "0x5C76A0", Length = "0x51")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000424")]
	public bool IsArray
	{
		[Address(RVA = "0x5C8BB0", Offset = "0x5C73B0", Length = "0x8")]
		[Token(Token = "0x6002FE7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000425")]
	public bool IsBoolean
	{
		[Address(RVA = "0x5C8BC0", Offset = "0x5C73C0", Length = "0x8")]
		[Token(Token = "0x6002FE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000426")]
	public bool IsDouble
	{
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x5C8BD0", Offset = "0x5C73D0", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000427")]
	public bool IsInt
	{
		[Address(RVA = "0x5C8BE0", Offset = "0x5C73E0", Length = "0x8")]
		[Token(Token = "0x6002FEA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000428")]
	public bool IsLong
	{
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x5C8BF0", Offset = "0x5C73F0", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000429")]
	public bool IsObject
	{
		[Address(RVA = "0x5C8C00", Offset = "0x5C7400", Length = "0x8")]
		[Token(Token = "0x6002FEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700042A")]
	public bool IsString
	{
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x5C8C10", Offset = "0x5C7410", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700042B")]
	public ICollection<string> Keys
	{
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x5CB2E0", Offset = "0x5C9AE0", Length = "0x52")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700042C")]
	private int System_002ECollections_002EICollection_002ECount
	{
		[Address(RVA = "0x5C8EA0", Offset = "0x5C76A0", Length = "0x51")]
		[Token(Token = "0x6002FEF")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700042D")]
	private bool System_002ECollections_002EICollection_002EIsSynchronized
	{
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x5C8F00", Offset = "0x5C7700", Length = "0x51")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700042E")]
	private object System_002ECollections_002EICollection_002ESyncRoot
	{
		[Address(RVA = "0x5C8F60", Offset = "0x5C7760", Length = "0x51")]
		[Token(Token = "0x6002FF1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700042F")]
	private bool System_002ECollections_002EIDictionary_002EIsFixedSize
	{
		[Address(RVA = "0x5C9420", Offset = "0x5C7C20", Length = "0x51")]
		[Token(Token = "0x6002FF2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000430")]
	private bool System_002ECollections_002EIDictionary_002EIsReadOnly
	{
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x5C9480", Offset = "0x5C7C80", Length = "0x51")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000431")]
	private ICollection System_002ECollections_002EIDictionary_002EKeys
	{
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x5C9540", Offset = "0x5C7D40", Length = "0x242")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000432")]
	private ICollection System_002ECollections_002EIDictionary_002EValues
	{
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x5C9790", Offset = "0x5C7F90", Length = "0x247")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000433")]
	private bool LitJson_002EIJsonWrapper_002EIsArray
	{
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x5C8BB0", Offset = "0x5C73B0", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000434")]
	private bool LitJson_002EIJsonWrapper_002EIsBoolean
	{
		[Address(RVA = "0x5C8BC0", Offset = "0x5C73C0", Length = "0x8")]
		[Token(Token = "0x6002FF7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000435")]
	private bool LitJson_002EIJsonWrapper_002EIsDouble
	{
		[Address(RVA = "0x5C8BD0", Offset = "0x5C73D0", Length = "0x8")]
		[Token(Token = "0x6002FF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000436")]
	private bool LitJson_002EIJsonWrapper_002EIsInt
	{
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x5C8BE0", Offset = "0x5C73E0", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000437")]
	private bool LitJson_002EIJsonWrapper_002EIsLong
	{
		[Address(RVA = "0x5C8BF0", Offset = "0x5C73F0", Length = "0x8")]
		[Token(Token = "0x6002FFA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000438")]
	private bool LitJson_002EIJsonWrapper_002EIsObject
	{
		[Token(Token = "0x6002FFB")]
		[Address(RVA = "0x5C8C00", Offset = "0x5C7400", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000439")]
	private bool LitJson_002EIJsonWrapper_002EIsString
	{
		[Address(RVA = "0x5C8C10", Offset = "0x5C7410", Length = "0x8")]
		[Token(Token = "0x6002FFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700043A")]
	private bool System_002ECollections_002EIList_002EIsFixedSize
	{
		[Address(RVA = "0x5C9E60", Offset = "0x5C8660", Length = "0x51")]
		[Token(Token = "0x6002FFD")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700043B")]
	private bool System_002ECollections_002EIList_002EIsReadOnly
	{
		[Address(RVA = "0x5C9EC0", Offset = "0x5C86C0", Length = "0x51")]
		[Token(Token = "0x6002FFE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700043C")]
	private object System_002ECollections_002EIDictionary_002EItem
	{
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x5C94E0", Offset = "0x5C7CE0", Length = "0x5D")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x5C99E0", Offset = "0x5C81E0", Length = "0xD3")]
		set
		{
		}
	}

	[Token(Token = "0x1700043D")]
	private object System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem
	{
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x5CA2C0", Offset = "0x5C8AC0", Length = "0xBA")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x5CA380", Offset = "0x5C8B80", Length = "0x1DA")]
		set
		{
		}
	}

	[Token(Token = "0x1700043E")]
	private object System_002ECollections_002EIList_002EItem
	{
		[Address(RVA = "0x5C9F20", Offset = "0x5C8720", Length = "0x5C")]
		[Token(Token = "0x6003003")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003004")]
		[Address(RVA = "0x5C9F80", Offset = "0x5C8780", Length = "0x4B")]
		set
		{
		}
	}

	[Token(Token = "0x1700043F")]
	public JsonData Item
	{
		[Token(Token = "0x6003005")]
		[Address(RVA = "0x5CB220", Offset = "0x5C9A20", Length = "0xB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003006")]
		[Address(RVA = "0x5CB9F0", Offset = "0x5CA1F0", Length = "0x2A3")]
		set
		{
		}
	}

	[Token(Token = "0x17000440")]
	public JsonData Item
	{
		[Token(Token = "0x6003007")]
		[Address(RVA = "0x5CB0D0", Offset = "0x5C98D0", Length = "0x140")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003008")]
		[Address(RVA = "0x5CB770", Offset = "0x5C9F70", Length = "0x27D")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003009")]
	public JsonData()
	{
	}

	[Token(Token = "0x600300A")]
	[Address(RVA = "0x5CAE60", Offset = "0x5C9660", Length = "0x2D")]
	public JsonData(bool boolean)
	{
	}

	[Token(Token = "0x600300B")]
	[Address(RVA = "0x5CADD0", Offset = "0x5C95D0", Length = "0x2F")]
	public JsonData(double number)
	{
	}

	[Token(Token = "0x600300C")]
	[Address(RVA = "0x5CAE00", Offset = "0x5C9600", Length = "0x2B")]
	public JsonData(int number)
	{
	}

	[Address(RVA = "0x5CAE30", Offset = "0x5C9630", Length = "0x2D")]
	[Token(Token = "0x600300D")]
	public JsonData(long number)
	{
	}

	[Token(Token = "0x600300E")]
	[Address(RVA = "0x5CAE90", Offset = "0x5C9690", Length = "0x232")]
	public JsonData(object obj)
	{
	}

	[Token(Token = "0x600300F")]
	[Address(RVA = "0x5CAD90", Offset = "0x5C9590", Length = "0x37")]
	public JsonData(string str)
	{
	}

	[Token(Token = "0x6003010")]
	[Address(RVA = "0x5CB5F0", Offset = "0x5C9DF0", Length = "0x5A")]
	public static implicit operator JsonData(bool data)
	{
		return null;
	}

	[Address(RVA = "0x5CB6B0", Offset = "0x5C9EB0", Length = "0x5C")]
	[Token(Token = "0x6003011")]
	public static implicit operator JsonData(double data)
	{
		return null;
	}

	[Address(RVA = "0x5CB650", Offset = "0x5C9E50", Length = "0x58")]
	[Token(Token = "0x6003012")]
	public static implicit operator JsonData(int data)
	{
		return null;
	}

	[Token(Token = "0x6003013")]
	[Address(RVA = "0x5CB710", Offset = "0x5C9F10", Length = "0x5A")]
	public static implicit operator JsonData(long data)
	{
		return null;
	}

	[Address(RVA = "0x5CB580", Offset = "0x5C9D80", Length = "0x65")]
	[Token(Token = "0x6003014")]
	public static implicit operator JsonData(string data)
	{
		return null;
	}

	[Address(RVA = "0x5CB430", Offset = "0x5C9C30", Length = "0x6F")]
	[Token(Token = "0x6003015")]
	public static explicit operator bool(JsonData data)
	{
		return default(bool);
	}

	[Address(RVA = "0x5CB340", Offset = "0x5C9B40", Length = "0x70")]
	[Token(Token = "0x6003016")]
	public static explicit operator double(JsonData data)
	{
		return default(double);
	}

	[Token(Token = "0x6003017")]
	[Address(RVA = "0x5CB4A0", Offset = "0x5C9CA0", Length = "0x6E")]
	public static explicit operator int(JsonData data)
	{
		return default(int);
	}

	[Token(Token = "0x6003018")]
	[Address(RVA = "0x5CB3C0", Offset = "0x5C9BC0", Length = "0x6F")]
	public static explicit operator long(JsonData data)
	{
		return default(long);
	}

	[Token(Token = "0x6003019")]
	[Address(RVA = "0x5CB510", Offset = "0x5C9D10", Length = "0x6F")]
	public static explicit operator string(JsonData data)
	{
		return null;
	}

	[Token(Token = "0x600301A")]
	[Address(RVA = "0x5C8DD0", Offset = "0x5C75D0", Length = "0xC9")]
	private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
	{
	}

	[Token(Token = "0x600301B")]
	[Address(RVA = "0x5C8FC0", Offset = "0x5C77C0", Length = "0x17A")]
	private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
	{
	}

	[Token(Token = "0x600301C")]
	[Address(RVA = "0x5C9140", Offset = "0x5C7940", Length = "0x7D")]
	private void System_002ECollections_002EIDictionary_002EClear()
	{
	}

	[Token(Token = "0x600301D")]
	[Address(RVA = "0x5C91C0", Offset = "0x5C79C0", Length = "0x60")]
	private bool System_002ECollections_002EIDictionary_002EContains(object key)
	{
		return default(bool);
	}

	[Address(RVA = "0x5C9230", Offset = "0x5C7A30", Length = "0x3D")]
	[Token(Token = "0x600301E")]
	private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Address(RVA = "0x5C9270", Offset = "0x5C7A70", Length = "0x1A8")]
	[Token(Token = "0x600301F")]
	private void System_002ECollections_002EIDictionary_002ERemove(object key)
	{
	}

	[Token(Token = "0x6003020")]
	[Address(RVA = "0x5C9AC0", Offset = "0x5C82C0", Length = "0x4E")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Address(RVA = "0x5C87B0", Offset = "0x5C6FB0", Length = "0x64")]
	[Token(Token = "0x6003021")]
	private bool LitJson_002EIJsonWrapper_002EGetBoolean()
	{
		return default(bool);
	}

	[Address(RVA = "0x5C8820", Offset = "0x5C7020", Length = "0x65")]
	[Token(Token = "0x6003022")]
	private double LitJson_002EIJsonWrapper_002EGetDouble()
	{
		return default(double);
	}

	[Token(Token = "0x6003023")]
	[Address(RVA = "0x5C8890", Offset = "0x5C7090", Length = "0x63")]
	private int LitJson_002EIJsonWrapper_002EGetInt()
	{
		return default(int);
	}

	[Address(RVA = "0x5C8900", Offset = "0x5C7100", Length = "0x64")]
	[Token(Token = "0x6003024")]
	private long LitJson_002EIJsonWrapper_002EGetLong()
	{
		return default(long);
	}

	[Token(Token = "0x6003025")]
	[Address(RVA = "0x5C8970", Offset = "0x5C7170", Length = "0x64")]
	private string LitJson_002EIJsonWrapper_002EGetString()
	{
		return null;
	}

	[Token(Token = "0x6003026")]
	[Address(RVA = "0x5C89E0", Offset = "0x5C71E0", Length = "0x1C")]
	private void LitJson_002EIJsonWrapper_002ESetBoolean(bool val)
	{
	}

	[Token(Token = "0x6003027")]
	[Address(RVA = "0x5C8A00", Offset = "0x5C7200", Length = "0x1E")]
	private void LitJson_002EIJsonWrapper_002ESetDouble(double val)
	{
	}

	[Token(Token = "0x6003028")]
	[Address(RVA = "0x5C8A20", Offset = "0x5C7220", Length = "0x1C")]
	private void LitJson_002EIJsonWrapper_002ESetInt(int val)
	{
	}

	[Address(RVA = "0x5C8A40", Offset = "0x5C7240", Length = "0x1D")]
	[Token(Token = "0x6003029")]
	private void LitJson_002EIJsonWrapper_002ESetLong(long val)
	{
	}

	[Token(Token = "0x600302A")]
	[Address(RVA = "0x5C8A60", Offset = "0x5C7260", Length = "0x33")]
	private void LitJson_002EIJsonWrapper_002ESetString(string val)
	{
	}

	[Token(Token = "0x600302B")]
	[Address(RVA = "0x5C8AA0", Offset = "0x5C72A0", Length = "0xCE")]
	private string LitJson_002EIJsonWrapper_002EToJson()
	{
		return null;
	}

	[Address(RVA = "0x5C8B70", Offset = "0x5C7370", Length = "0x36")]
	[Token(Token = "0x600302C")]
	private void LitJson_002EIJsonWrapper_002EToJson(JsonWriter writer)
	{
	}

	[Address(RVA = "0x5C8250", Offset = "0x5C6A50", Length = "0x83")]
	[Token(Token = "0x600302D")]
	private int System_002ECollections_002EIList_002EAdd(object value)
	{
		return default(int);
	}

	[Token(Token = "0x600302E")]
	[Address(RVA = "0x5C9B10", Offset = "0x5C8310", Length = "0x63")]
	private void System_002ECollections_002EIList_002EClear()
	{
	}

	[Token(Token = "0x600302F")]
	[Address(RVA = "0x5C9B80", Offset = "0x5C8380", Length = "0x60")]
	private bool System_002ECollections_002EIList_002EContains(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003030")]
	[Address(RVA = "0x5C9BF0", Offset = "0x5C83F0", Length = "0x60")]
	private int System_002ECollections_002EIList_002EIndexOf(object value)
	{
		return default(int);
	}

	[Address(RVA = "0x5C9C60", Offset = "0x5C8460", Length = "0xF4")]
	[Token(Token = "0x6003031")]
	private void System_002ECollections_002EIList_002EInsert(int index, object value)
	{
	}

	[Address(RVA = "0x5C9DE0", Offset = "0x5C85E0", Length = "0x72")]
	[Token(Token = "0x6003032")]
	private void System_002ECollections_002EIList_002ERemove(object value)
	{
	}

	[Token(Token = "0x6003033")]
	[Address(RVA = "0x5C9D60", Offset = "0x5C8560", Length = "0x71")]
	private void System_002ECollections_002EIList_002ERemoveAt(int index)
	{
	}

	[Token(Token = "0x6003034")]
	[Address(RVA = "0x5C9FD0", Offset = "0x5C87D0", Length = "0x7D")]
	private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Address(RVA = "0x5CA050", Offset = "0x5C8850", Length = "0x15D")]
	[Token(Token = "0x6003035")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EInsert(int idx, object key, object value)
	{
	}

	[Token(Token = "0x6003036")]
	[Address(RVA = "0x5CA1B0", Offset = "0x5C89B0", Length = "0x10D")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002ERemoveAt(int idx)
	{
	}

	[Token(Token = "0x6003037")]
	[Address(RVA = "0x5C8350", Offset = "0x5C6B50", Length = "0xCD")]
	private ICollection EnsureCollection()
	{
		return null;
	}

	[Token(Token = "0x6003038")]
	[Address(RVA = "0x5C8420", Offset = "0x5C6C20", Length = "0x140")]
	private IDictionary EnsureDictionary()
	{
		return null;
	}

	[Token(Token = "0x6003039")]
	[Address(RVA = "0x5C8570", Offset = "0x5C6D70", Length = "0x105")]
	private IList EnsureList()
	{
		return null;
	}

	[Address(RVA = "0x5CA560", Offset = "0x5C8D60", Length = "0xE4")]
	[Token(Token = "0x600303A")]
	private JsonData ToJsonData(object obj)
	{
		return null;
	}

	[Address(RVA = "0x5CA800", Offset = "0x5C9000", Length = "0x587")]
	[Token(Token = "0x600303B")]
	private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
	{
	}

	[Address(RVA = "0x5C8250", Offset = "0x5C6A50", Length = "0x83")]
	[Token(Token = "0x600303C")]
	public int Add(object value)
	{
		return default(int);
	}

	[Token(Token = "0x600303D")]
	[Address(RVA = "0x5C82E0", Offset = "0x5C6AE0", Length = "0x67")]
	public void Clear()
	{
	}

	[Address(RVA = "0x5C8680", Offset = "0x5C6E80", Length = "0x104")]
	[Token(Token = "0x600303E")]
	public bool Equals(JsonData x)
	{
		return default(bool);
	}

	[Address(RVA = "0x492770", Offset = "0x490F70", Length = "0x4")]
	[Token(Token = "0x600303F")]
	public JsonType GetJsonType()
	{
		return default(JsonType);
	}

	[Address(RVA = "0x5C8C20", Offset = "0x5C7420", Length = "0x4C")]
	[Token(Token = "0x6003040")]
	public void SetJsonType(JsonType type)
	{
	}

	[Address(RVA = "0x5CA650", Offset = "0x5C8E50", Length = "0xD2")]
	[Token(Token = "0x6003041")]
	public string ToJson()
	{
		return null;
	}

	[Address(RVA = "0x5C8B70", Offset = "0x5C7370", Length = "0x36")]
	[Token(Token = "0x6003042")]
	public void ToJson(JsonWriter writer)
	{
	}

	[Address(RVA = "0x5CA730", Offset = "0x5C8F30", Length = "0xB4")]
	[Token(Token = "0x6003043")]
	public override string ToString()
	{
		return null;
	}
}
