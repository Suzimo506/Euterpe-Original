using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000878")]
public class StageBtnDiscoActivity : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4002C34")]
	private Button m_BtnDiscoActivity;

	[SerializeField]
	[Token(Token = "0x4002C35")]
	[FieldOffset(Offset = "0x20")]
	private Image m_ImgLogo;

	[SerializeField]
	[Token(Token = "0x4002C36")]
	[FieldOffset(Offset = "0x28")]
	private string m_MessageBoxName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002C37")]
	private MusicStageCell m_MusicStageCell;

	[Address(RVA = "0x61BC70", Offset = "0x61A470", Length = "0x186")]
	[Token(Token = "0x6004D41")]
	private void Start()
	{
	}

	[Address(RVA = "0x61BE50", Offset = "0x61A650", Length = "0xA8")]
	[Token(Token = "0x6004D42")]
	private void Update()
	{
	}

	[Token(Token = "0x6004D43")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public StageBtnDiscoActivity()
	{
	}
}
