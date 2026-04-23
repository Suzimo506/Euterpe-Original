using Assets.Scripts.GameCore.Controller;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002B")]
public static class ControllerFactory
{
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x4698E0", Offset = "0x4680E0", Length = "0x17E")]
	public static IControlable GetController(out string config, RuntimePlatform platform)
	{
		config = null;
		return null;
	}
}
