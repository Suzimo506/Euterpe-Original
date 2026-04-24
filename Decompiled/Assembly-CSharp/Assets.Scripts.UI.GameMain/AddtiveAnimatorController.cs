using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200088A")]
public class AddtiveAnimatorController : MonoBehaviour
{
	[Token(Token = "0x4002C7D")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private SceneSubControl m_SceneSubControl;

	[Token(Token = "0x6004DB9")]
	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	public void Init(SceneSubControl sceneSubControl)
	{
	}

	[Token(Token = "0x6004DBA")]
	[Address(RVA = "0x5A5F40", Offset = "0x5A4740", Length = "0xA2")]
	private void Start()
	{
	}

	[Token(Token = "0x6004DBB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AddtiveAnimatorController()
	{
	}
}
