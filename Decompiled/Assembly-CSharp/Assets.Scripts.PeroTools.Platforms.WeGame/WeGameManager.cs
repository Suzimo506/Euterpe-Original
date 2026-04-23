using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Platforms.WeGame;

[DisallowMultipleComponent]
[Token(Token = "0x20005BD")]
public class WeGameManager : SingletonMonoBehaviour<WeGameManager>
{
	[Address(RVA = "0x989970", Offset = "0x988170", Length = "0x38")]
	[Token(Token = "0x600397C")]
	public WeGameManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
