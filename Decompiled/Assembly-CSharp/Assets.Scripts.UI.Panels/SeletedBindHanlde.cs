using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F7")]
public class SeletedBindHanlde : MonoBehaviour
{
	[Token(Token = "0x4002FFC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject targetObj;

	[Token(Token = "0x4002FFD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject bindObj;

	[Token(Token = "0x4002FFE")]
	[FieldOffset(Offset = "0x28")]
	public UISelectManage targetSelectManage;

	[Token(Token = "0x4002FFF")]
	[FieldOffset(Offset = "0x30")]
	public bool needPlayInvokeMusic;

	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4003000")]
	public bool isForce;

	[Address(RVA = "0x4D0B50", Offset = "0x4CF350", Length = "0x80")]
	[Token(Token = "0x6005168")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4D0C70", Offset = "0x4CF470", Length = "0x16D")]
	[Token(Token = "0x6005169")]
	private void OnTargetSelectObjChange(GameObject curSelectobj)
	{
	}

	[Address(RVA = "0x4D0BE0", Offset = "0x4CF3E0", Length = "0x80")]
	[Token(Token = "0x600516A")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x42A5D0", Offset = "0x428DD0", Length = "0xB")]
	[Token(Token = "0x600516B")]
	public SeletedBindHanlde()
	{
	}
}
