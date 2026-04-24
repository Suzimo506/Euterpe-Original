using System.Collections;
using System.Collections.Specialized;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F2")]
public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
{
	[Token(Token = "0x1700041C")]
	bool IsArray
	{
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700041D")]
	bool IsBoolean
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6002FD2")]
		get;
	}

	[Token(Token = "0x1700041E")]
	bool IsDouble
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6002FD3")]
		get;
	}

	[Token(Token = "0x1700041F")]
	bool IsInt
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6002FD4")]
		get;
	}

	[Token(Token = "0x17000420")]
	bool IsLong
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6002FD5")]
		get;
	}

	[Token(Token = "0x17000421")]
	bool IsObject
	{
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000422")]
	bool IsString
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6002FD7")]
		get;
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FD8")]
	bool GetBoolean();

	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x0", Length = "0x0")]
	double GetDouble();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FDA")]
	int GetInt();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FDB")]
	JsonType GetJsonType();

	[Token(Token = "0x6002FDC")]
	[Address(RVA = "0x0", Length = "0x0")]
	long GetLong();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FDD")]
	string GetString();

	[Token(Token = "0x6002FDE")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetBoolean(bool val);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FDF")]
	void SetDouble(double val);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FE0")]
	void SetInt(int val);

	[Token(Token = "0x6002FE1")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetJsonType(JsonType type);

	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetLong(long val);

	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetString(string val);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FE4")]
	string ToJson();

	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x0", Length = "0x0")]
	void ToJson(JsonWriter writer);
}
