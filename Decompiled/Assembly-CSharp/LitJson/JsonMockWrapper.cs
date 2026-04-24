using System;
using System.Collections;
using System.Collections.Specialized;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003FF")]
public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
{
	[Token(Token = "0x1700044B")]
	public bool IsArray
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600308D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700044C")]
	public bool IsBoolean
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600308E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700044D")]
	public bool IsDouble
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600308F")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700044E")]
	public bool IsInt
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6003090")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700044F")]
	public bool IsLong
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6003091")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000450")]
	public bool IsObject
	{
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000451")]
	public bool IsString
	{
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000452")]
	private bool System_002ECollections_002EIList_002EIsFixedSize
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x60030A2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000453")]
	private bool System_002ECollections_002EIList_002EIsReadOnly
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x60030A3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000454")]
	private object System_002ECollections_002EIList_002EItem
	{
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		[Token(Token = "0x60030A4")]
		get
		{
			return null;
		}
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		[Token(Token = "0x60030A5")]
		set
		{
		}
	}

	[Token(Token = "0x17000455")]
	private int System_002ECollections_002EICollection_002ECount
	{
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000456")]
	private bool System_002ECollections_002EICollection_002EIsSynchronized
	{
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000457")]
	private object System_002ECollections_002EICollection_002ESyncRoot
	{
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		[Token(Token = "0x60030AF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000458")]
	private bool System_002ECollections_002EIDictionary_002EIsFixedSize
	{
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000459")]
	private bool System_002ECollections_002EIDictionary_002EIsReadOnly
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x60030B3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700045A")]
	private ICollection System_002ECollections_002EIDictionary_002EKeys
	{
		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045B")]
	private ICollection System_002ECollections_002EIDictionary_002EValues
	{
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045C")]
	private object System_002ECollections_002EIDictionary_002EItem
	{
		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		set
		{
		}
	}

	[Token(Token = "0x1700045D")]
	private object System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem
	{
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		[Token(Token = "0x60030BD")]
		get
		{
			return null;
		}
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		[Token(Token = "0x60030BE")]
		set
		{
		}
	}

	[Token(Token = "0x6003094")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public bool GetBoolean()
	{
		return default(bool);
	}

	[Address(RVA = "0x73A090", Offset = "0x738890", Length = "0x4")]
	[Token(Token = "0x6003095")]
	public double GetDouble()
	{
		return default(double);
	}

	[Token(Token = "0x6003096")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	public int GetInt()
	{
		return default(int);
	}

	[Token(Token = "0x6003097")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	public JsonType GetJsonType()
	{
		return default(JsonType);
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x6003098")]
	public long GetLong()
	{
		return default(long);
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x8B3CB0", Offset = "0x8B24B0", Length = "0x2B")]
	public string GetString()
	{
		return null;
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600309A")]
	public void SetBoolean(bool val)
	{
	}

	[Token(Token = "0x600309B")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SetDouble(double val)
	{
	}

	[Token(Token = "0x600309C")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SetInt(int val)
	{
	}

	[Token(Token = "0x600309D")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SetJsonType(JsonType type)
	{
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SetLong(long val)
	{
	}

	[Token(Token = "0x600309F")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SetString(string val)
	{
	}

	[Address(RVA = "0x8B3CE0", Offset = "0x8B24E0", Length = "0x2B")]
	[Token(Token = "0x60030A0")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void ToJson(JsonWriter writer)
	{
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x60030A6")]
	private int System_002ECollections_002EIList_002EAdd(object value)
	{
		return default(int);
	}

	[Token(Token = "0x60030A7")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void System_002ECollections_002EIList_002EClear()
	{
	}

	[Token(Token = "0x60030A8")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	private bool System_002ECollections_002EIList_002EContains(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x4E94D0", Offset = "0x4E7CD0", Length = "0x6")]
	private int System_002ECollections_002EIList_002EIndexOf(object value)
	{
		return default(int);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030AA")]
	private void System_002ECollections_002EIList_002EInsert(int i, object v)
	{
	}

	[Token(Token = "0x60030AB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void System_002ECollections_002EIList_002ERemove(object value)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030AC")]
	private void System_002ECollections_002EIList_002ERemoveAt(int index)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030B0")]
	private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
	{
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x60030B1")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030B8")]
	private void System_002ECollections_002EIDictionary_002EAdd(object k, object v)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030B9")]
	private void System_002ECollections_002EIDictionary_002EClear()
	{
	}

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	private bool System_002ECollections_002EIDictionary_002EContains(object key)
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030BB")]
	private void System_002ECollections_002EIDictionary_002ERemove(object key)
	{
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60030C0")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EInsert(int i, object k, object v)
	{
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002ERemoveAt(int i)
	{
	}

	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public JsonMockWrapper()
	{
	}
}
