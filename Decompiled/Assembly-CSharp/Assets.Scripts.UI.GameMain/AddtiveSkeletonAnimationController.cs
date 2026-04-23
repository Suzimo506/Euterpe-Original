using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200088D")]
public class AddtiveSkeletonAnimationController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C80")]
	[FieldOffset(Offset = "0x18")]
	private SceneSubControl m_SceneSubControl;

	[Token(Token = "0x6004DC2")]
	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	public void Init(SceneSubControl sceneSubControl)
	{
	}

	[Address(RVA = "0x5A6150", Offset = "0x5A4950", Length = "0xA2")]
	[Token(Token = "0x6004DC3")]
	private void Start()
	{
	}

	[Token(Token = "0x6004DC4")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AddtiveSkeletonAnimationController()
	{
	}
}
