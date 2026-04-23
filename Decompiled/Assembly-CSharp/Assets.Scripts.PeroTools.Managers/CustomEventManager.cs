using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000643")]
public class CustomEventManager : SingletonScriptableObject<CustomEventManager>
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400233F")]
	public List<string> customEvents;

	[Address(RVA = "0x7583B0", Offset = "0x756BB0", Length = "0x38")]
	[Token(Token = "0x6003C61")]
	public CustomEventManager()
	{
		((SingletonScriptableObject<>)(object)this)._002Ector();
	}
}
