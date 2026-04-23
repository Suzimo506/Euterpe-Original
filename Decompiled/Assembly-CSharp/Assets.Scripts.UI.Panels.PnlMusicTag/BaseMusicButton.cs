using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlMusicTag;

[Token(Token = "0x20008F9")]
public class BaseMusicButton : MonoBehaviour
{
	[Token(Token = "0x4003009")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Button m_CellBtn;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400300A")]
	protected MusicInfo m_MusicInfo;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005176")]
	public BaseMusicButton()
	{
	}
}
