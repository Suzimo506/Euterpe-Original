using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200088C")]
public class AddtiveParticleSystemController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C7F")]
	[FieldOffset(Offset = "0x18")]
	private SceneSubControl m_SceneSubControl;

	[Token(Token = "0x6004DBF")]
	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	public void Init(SceneSubControl sceneSubControl)
	{
	}

	[Token(Token = "0x6004DC0")]
	[Address(RVA = "0x5A60A0", Offset = "0x5A48A0", Length = "0xA2")]
	private void Start()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004DC1")]
	public AddtiveParticleSystemController()
	{
	}
}
