using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain.Scene.Theme;

[Token(Token = "0x200089D")]
public class CryptonSceneHandler : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CD6")]
	[SerializeField]
	private GameObject m_SceneMiku;

	[Token(Token = "0x4002CD7")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_SceneRinLen;

	[Address(RVA = "0x5AC5D0", Offset = "0x5AADD0", Length = "0x1B0")]
	[Token(Token = "0x6004E1A")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5AC790", Offset = "0x5AAF90", Length = "0x105")]
	[Token(Token = "0x6004E1B")]
	private void InstantiateSceneObject(GameObject sceneObj)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004E1C")]
	public CryptonSceneHandler()
	{
	}
}
