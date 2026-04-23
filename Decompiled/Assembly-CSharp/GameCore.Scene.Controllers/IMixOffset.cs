using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.Scene.Controllers;

[Token(Token = "0x2000464")]
public interface IMixOffset
{
	[Token(Token = "0x60032E9")]
	[Address(RVA = "0x0", Length = "0x0")]
	Vector3 GetOffsetUpdate();
}
