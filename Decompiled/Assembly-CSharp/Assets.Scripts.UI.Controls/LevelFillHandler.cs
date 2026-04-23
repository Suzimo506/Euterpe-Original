using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008AC")]
public class LevelFillHandler : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002D5B")]
	[SerializeField]
	private Image m_ImgLevelFill;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002D5C")]
	[SerializeField]
	private Text m_TxtLevelFill;

	[Address(RVA = "0x5B0EC0", Offset = "0x5AF6C0", Length = "0xA9")]
	[Token(Token = "0x6004E91")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5B1020", Offset = "0x5AF820", Length = "0x176")]
	[Token(Token = "0x6004E92")]
	private void SetLevelFill(float value)
	{
	}

	[Token(Token = "0x6004E93")]
	[Address(RVA = "0x5B0F70", Offset = "0x5AF770", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004E94")]
	public LevelFillHandler()
	{
	}
}
