using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000113")]
public class VipPrefabSelector : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006A6")]
	[SerializeField]
	private Transform transformParent;

	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x20")]
	private VipDisPlayControl vipDisPlayControl;

	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x28")]
	private GameObject vipAssetCached;

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0xD30E90", Offset = "0xD2F690", Length = "0x29E")]
	public void Refresh()
	{
	}

	[Address(RVA = "0xD31130", Offset = "0xD2F930", Length = "0x7B")]
	[Token(Token = "0x60007E6")]
	public void ResetVip()
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0xD30D70", Offset = "0xD2F570", Length = "0x119")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public VipPrefabSelector()
	{
	}
}
