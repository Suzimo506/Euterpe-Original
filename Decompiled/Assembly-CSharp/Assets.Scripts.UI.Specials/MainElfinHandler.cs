using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000876")]
public class MainElfinHandler : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C30")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_HidePosition;

	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4002C31")]
	private Vector3 m_SidePosition;

	[Token(Token = "0x4002C32")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_OriPosition;

	[Token(Token = "0x6004D39")]
	[Address(RVA = "0x610C90", Offset = "0x60F490", Length = "0xDB")]
	private void Awake()
	{
	}

	[Address(RVA = "0x610E30", Offset = "0x60F630", Length = "0xA9")]
	[Token(Token = "0x6004D3A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D3B")]
	[Address(RVA = "0x610EE0", Offset = "0x60F6E0", Length = "0xAC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004D3C")]
	[Address(RVA = "0x610D70", Offset = "0x60F570", Length = "0xB8")]
	private Vector3 GetTargetPos(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004D3D")]
	[Address(RVA = "0x610F90", Offset = "0x60F790", Length = "0x71")]
	private void OnOceanBgSelected(int index)
	{
	}

	[Token(Token = "0x6004D3E")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MainElfinHandler()
	{
	}
}
