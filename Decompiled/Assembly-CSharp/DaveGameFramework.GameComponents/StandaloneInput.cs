using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004CC")]
public class StandaloneInput : BaseInputComponent
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A23")]
	private InputManager m_InputManager;

	[Token(Token = "0x60035C1")]
	[Address(RVA = "0x9A40F0", Offset = "0x9A28F0", Length = "0x1CD")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60035C2")]
	[Address(RVA = "0x9A4680", Offset = "0x9A2E80", Length = "0x104")]
	public override void Reset()
	{
	}

	[Address(RVA = "0x9A42C0", Offset = "0x9A2AC0", Length = "0x3B5")]
	[Token(Token = "0x60035C3")]
	public override void OnUpdate()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60035C4")]
	public StandaloneInput()
	{
	}
}
