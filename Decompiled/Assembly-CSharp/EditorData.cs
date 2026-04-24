using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000010")]
public class EditorData : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	private static string PATH;

	[Token(Token = "0x400002A")]
	private static GameObject dataObject;

	[Token(Token = "0x400002B")]
	private static EditorData instance;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400002C")]
	public string[] SpineActionKeys;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x20")]
	public string[] SpineActionDes;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002E")]
	public string[] SpineEventName;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x30")]
	public string[] SpineEventDes;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000030")]
	public string[] SpineModeName;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x40")]
	public string[] SpineModeDes;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x48")]
	public StageEvent[] StageEvents;

	[Token(Token = "0x17000006")]
	public static EditorData Instance
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4464A0", Offset = "0x444CA0", Length = "0x191")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x446290", Offset = "0x444A90", Length = "0x57")]
	public static GameObject GetDataObject()
	{
		return null;
	}

	[Address(RVA = "0x445F80", Offset = "0x444780", Length = "0xB6")]
	[Token(Token = "0x6000027")]
	public void AddStringListItem(ref string item, ref string[] strList)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x4461F0", Offset = "0x4449F0", Length = "0x93")]
	public void DelStringListItem(int idx, ref string[] strList)
	{
	}

	[Address(RVA = "0x445DF0", Offset = "0x4445F0", Length = "0xB4")]
	[Token(Token = "0x6000029")]
	public void AddIntListItem(int item, ref int[] intList)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x446150", Offset = "0x444950", Length = "0x93")]
	public void DelIntListItem(int idx, ref int[] intList)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x445D30", Offset = "0x444530", Length = "0xB6")]
	public void AddGameObjectListItem(ref GameObject item, ref GameObject[] objList)
	{
	}

	[Address(RVA = "0x4460B0", Offset = "0x4448B0", Length = "0x93")]
	[Token(Token = "0x600002C")]
	public void DelGameObjectListItem(int idx, ref GameObject[] objList)
	{
	}

	[Address(RVA = "0x446040", Offset = "0x444840", Length = "0x64")]
	[Token(Token = "0x600002D")]
	public void AfterSave()
	{
	}

	[Address(RVA = "0x4462F0", Offset = "0x444AF0", Length = "0x167")]
	[Token(Token = "0x600002E")]
	public StageEvent GetStageEventDataById(int idx)
	{
		return default(StageEvent);
	}

	[Address(RVA = "0x445EB0", Offset = "0x4446B0", Length = "0xCE")]
	[Token(Token = "0x600002F")]
	public void AddStageEvent(ref StageEvent item)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000030")]
	public EditorData()
	{
	}
}
