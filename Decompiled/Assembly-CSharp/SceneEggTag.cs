using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine;

[Token(Token = "0x20000BB")]
public class SceneEggTag : MonoBehaviour
{
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SceneTag m_SceneTag;

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
	public SceneTag GetSceneEggTag()
	{
		return default(SceneTag);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000575")]
	public SceneEggTag()
	{
	}
}
