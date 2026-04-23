using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Interface;

[Token(Token = "0x200072A")]
public interface IUpdate
{
	[Token(Token = "0x17000637")]
	UnityGameManager.LoopType LoopType
	{
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x6004243")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnUpdate();
}
