using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;

namespace Assets.Scripts.Native;

[Token(Token = "0x20006AC")]
internal static class PeroNative
{
	[Token(Token = "0x400240B")]
	private const string dllName = "PeroPlugin";

	[Token(Token = "0x400240C")]
	private static bool s_Inited;

	[Token(Token = "0x400240D")]
	private const int PATH_MAX = 260;

	[PreserveSig]
	[Address(RVA = "0x92F310", Offset = "0x92DB10", Length = "0x9F")]
	[Token(Token = "0x6003EAA")]
	private static extern bool InitNativePlugin(string className, string windowTitle);

	[PreserveSig]
	[Address(RVA = "0x92FAD0", Offset = "0x92E2D0", Length = "0x95")]
	[Token(Token = "0x6003EAB")]
	private static extern bool SetWindowSize(int width, int height, bool border);

	[PreserveSig]
	[Address(RVA = "0x92FB70", Offset = "0x92E370", Length = "0x87")]
	[Token(Token = "0x6003EAC")]
	private static extern bool SetWindowTitle(string windowTitle);

	[PreserveSig]
	[Token(Token = "0x6003EAD")]
	[Address(RVA = "0x92F3B0", Offset = "0x92DBB0", Length = "0x104")]
	private static extern bool OpenFileDialog(string title, string startPath, string filter, bool modal, StringBuilder result, int resultSize);

	[PreserveSig]
	[Address(RVA = "0x92F7D0", Offset = "0x92DFD0", Length = "0xED")]
	[Token(Token = "0x6003EAE")]
	private static extern bool OpenFolderDialog(string title, string startPath, bool modal, StringBuilder result, int resultSize);

	[PreserveSig]
	[Address(RVA = "0x92F280", Offset = "0x92DA80", Length = "0x8C")]
	[Token(Token = "0x6003EAF")]
	private static extern bool CheckSteamAPIDll(string path);

	[Address(RVA = "0x92F4C0", Offset = "0x92DCC0", Length = "0x19F")]
	[Token(Token = "0x6003EB0")]
	internal static string OpenFileDialog(string title, string startPath, string filter, bool modal)
	{
		return null;
	}

	[Token(Token = "0x6003EB1")]
	[Address(RVA = "0x92F660", Offset = "0x92DE60", Length = "0x168")]
	internal static string OpenFolderDialog(string title, string startPath, bool modal)
	{
		return null;
	}

	[Token(Token = "0x6003EB2")]
	[Address(RVA = "0x92F8C0", Offset = "0x92E0C0", Length = "0x128")]
	internal static bool PeroNativeInit()
	{
		return default(bool);
	}

	[Token(Token = "0x6003EB3")]
	[Address(RVA = "0x92FC00", Offset = "0x92E400", Length = "0xED")]
	internal static void SetWindow(int width, int height, bool border)
	{
	}

	[Address(RVA = "0x92F9F0", Offset = "0x92E1F0", Length = "0xE0")]
	[Token(Token = "0x6003EB4")]
	internal static void SetTitle(string name)
	{
	}

	[Address(RVA = "0x92F280", Offset = "0x92DA80", Length = "0x8C")]
	[Token(Token = "0x6003EB5")]
	internal static bool CheckSteamDll(string path)
	{
		return default(bool);
	}
}
