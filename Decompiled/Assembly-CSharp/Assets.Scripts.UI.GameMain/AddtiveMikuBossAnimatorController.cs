using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200088B")]
public class AddtiveMikuBossAnimatorController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C7E")]
	[FieldOffset(Offset = "0x18")]
	private SceneSubControl m_SceneSubControl;

	[Token(Token = "0x6004DBC")]
	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	public void Init(SceneSubControl sceneSubControl)
	{
	}

	[Address(RVA = "0x5A5FF0", Offset = "0x5A47F0", Length = "0xA2")]
	[Token(Token = "0x6004DBD")]
	private void Start()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004DBE")]
	public AddtiveMikuBossAnimatorController()
	{
	}
}
