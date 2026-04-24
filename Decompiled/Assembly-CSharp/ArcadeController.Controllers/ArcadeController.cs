using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace ArcadeController.Controllers;

[Token(Token = "0x200055E")]
public class ArcadeController : SingletonMonoBehaviour<ArcadeController>
{
	[Token(Token = "0x6003783")]
	[Address(RVA = "0x596EF0", Offset = "0x5956F0", Length = "0x38")]
	public ArcadeController()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
