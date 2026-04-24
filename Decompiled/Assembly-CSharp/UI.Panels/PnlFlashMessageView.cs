using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels;

[Token(Token = "0x20001C2")]
public class PnlFlashMessageView : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B15")]
	[SerializeField]
	private Text m_TxtPopMsg;

	[Token(Token = "0x4000B16")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private Animator m_PopAnimator;

	[Token(Token = "0x170000EE")]
	public Text TxtPopMsg
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6000CAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EF")]
	public Animator PopAnimator
	{
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x50B460", Offset = "0x509C60", Length = "0x65")]
	public void Init()
	{
	}

	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlFlashMessageView()
	{
	}
}
