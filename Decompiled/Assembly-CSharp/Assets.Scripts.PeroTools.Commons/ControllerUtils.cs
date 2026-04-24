using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using Rewired;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000696")]
public static class ControllerUtils
{
	[Token(Token = "0x6003DED")]
	[Address(RVA = "0x923E90", Offset = "0x922690", Length = "0x254")]
	public static InputController GetInputController()
	{
		return default(InputController);
	}

	[Token(Token = "0x6003DEE")]
	[Address(RVA = "0x923DC0", Offset = "0x9225C0", Length = "0xCE")]
	private static Joystick GetFirstJoystick()
	{
		return null;
	}

	[Token(Token = "0x6003DEF")]
	[Address(RVA = "0x923CE0", Offset = "0x9224E0", Length = "0xDD")]
	public static string CurrentInputController()
	{
		return null;
	}
}
