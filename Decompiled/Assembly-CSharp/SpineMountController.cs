using Cpp2ILInjected;
using Spine;
using UnityEngine;

[Token(Token = "0x2000018")]
public class SpineMountController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007A")]
	private string[] sklNames;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007B")]
	private GameObject[] dymanicObjects;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007C")]
	[SerializeField]
	private SkeletonMountData[] mountData;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x514E00", Offset = "0x513600", Length = "0x2D")]
	private static bool FindBones(Bone elem, string _name)
	{
		return default(bool);
	}

	[Address(RVA = "0x515200", Offset = "0x513A00", Length = "0x4B0")]
	[Token(Token = "0x600009A")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x514B70", Offset = "0x513370", Length = "0xCA")]
	public void AddData()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x514C50", Offset = "0x513450", Length = "0x96")]
	public void DelData(int idx)
	{
	}

	[Address(RVA = "0x5151A0", Offset = "0x5139A0", Length = "0x5A")]
	[Token(Token = "0x600009D")]
	public void SetData(int idx, SkeletonMountData d)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x514C40", Offset = "0x513440", Length = "0xE")]
	public int DataCount()
	{
		return default(int);
	}

	[Address(RVA = "0x514E30", Offset = "0x513630", Length = "0x51")]
	[Token(Token = "0x600009F")]
	public SkeletonMountData GetData(int idx)
	{
		return default(SkeletonMountData);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x514CF0", Offset = "0x5134F0", Length = "0x104")]
	public void DestoryDynamicObjects()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
	public GameObject[] GetMountObjects()
	{
		return null;
	}

	[Address(RVA = "0x514E90", Offset = "0x513690", Length = "0x38")]
	[Token(Token = "0x60000A2")]
	public GameObject GetMountObjectByIdx(int index)
	{
		return null;
	}

	[Address(RVA = "0x515060", Offset = "0x513860", Length = "0x13A")]
	[Token(Token = "0x60000A3")]
	public void OnControllerStart()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x514ED0", Offset = "0x5136D0", Length = "0x18C")]
	private void InitSkeletonName()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SpineMountController()
	{
	}
}
