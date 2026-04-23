using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200000A")]
public class AdminData : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	private const string PATH = "AdminData";

	[Token(Token = "0x4000011")]
	private static GameObject dataObject;

	[Token(Token = "0x4000012")]
	private static AdminData instance;

	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000013")]
	public string defaultStageName;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000014")]
	public int defualtDifficulty;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000015")]
	public int defaultClothUid;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x28")]
	public int defaultElfinUid;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x30")]
	public List<int> defaultSkills;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000018")]
	public int defaultPetSkill;

	[Token(Token = "0x17000005")]
	public static AdminData Instance
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x590B60", Offset = "0x58F360", Length = "0x182")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x590B00", Offset = "0x58F300", Length = "0x56")]
	public static GameObject GetDataObject()
	{
		return null;
	}

	[Address(RVA = "0x590A90", Offset = "0x58F290", Length = "0x64")]
	[Token(Token = "0x600001E")]
	public void AfterSave()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600001F")]
	public AdminData()
	{
	}
}
