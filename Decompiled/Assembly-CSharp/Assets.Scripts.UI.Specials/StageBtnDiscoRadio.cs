using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000879")]
public class StageBtnDiscoRadio : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C38")]
	[FieldOffset(Offset = "0x18")]
	private Button m_BtnDiscoRadio;

	[SerializeField]
	[Token(Token = "0x4002C39")]
	[FieldOffset(Offset = "0x20")]
	private Image m_ImgBase;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002C3A")]
	[SerializeField]
	private Image m_ImgLogo;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002C3B")]
	[SerializeField]
	private Text m_TxtRadio;

	[Token(Token = "0x4002C3C")]
	[FieldOffset(Offset = "0x38")]
	private MusicStageCell m_MusicStageCell;

	[Token(Token = "0x6004D45")]
	[Address(RVA = "0x61BF00", Offset = "0x61A700", Length = "0x1FD")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D46")]
	[Address(RVA = "0x61C100", Offset = "0x61A900", Length = "0x134")]
	private void Update()
	{
	}

	[Token(Token = "0x6004D47")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public StageBtnDiscoRadio()
	{
	}
}
