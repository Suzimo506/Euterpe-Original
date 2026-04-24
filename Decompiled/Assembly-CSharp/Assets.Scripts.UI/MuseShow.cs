using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000825")]
public class MuseShow : MonoBehaviour
{
	[Token(Token = "0x4002A70")]
	[FieldOffset(Offset = "0x18")]
	private int m_Index;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002A71")]
	private GameObject m_MuseShow;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002A72")]
	private CharacterApply m_CharacterApply;

	[Token(Token = "0x4002A73")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private CharacterExpression m_Expression;

	[Token(Token = "0x4002A74")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Inited;

	[Token(Token = "0x4002A75")]
	[FieldOffset(Offset = "0x3C")]
	private int m_SkinIndex;

	[Token(Token = "0x1700083C")]
	public CharacterApply apply
	{
		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B19")]
	[Address(RVA = "0x6C24C0", Offset = "0x6C0CC0", Length = "0xB")]
	public void Init()
	{
	}

	[Token(Token = "0x6004B1A")]
	[Address(RVA = "0x6C24D0", Offset = "0x6C0CD0", Length = "0x5C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004B1B")]
	[Address(RVA = "0x6C2AA0", Offset = "0x6C12A0", Length = "0xE")]
	public MuseShow()
	{
	}
}
