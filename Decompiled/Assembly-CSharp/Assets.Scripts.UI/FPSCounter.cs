using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x200081C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x14C00", Offset = "0x14000")]
public class FPSCounter : MonoBehaviour, IInitialization
{
	[Token(Token = "0x4002A5E")]
	[FieldOffset(Offset = "0x18")]
	public float updateInterval;

	[Token(Token = "0x4002A5F")]
	[FieldOffset(Offset = "0x20")]
	private Text m_Text;

	[Token(Token = "0x4002A60")]
	[FieldOffset(Offset = "0x28")]
	private int m_PassFrame;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002A61")]
	private float m_PassTime;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002A62")]
	private IVariable m_ShowFpsVariable;

	[Token(Token = "0x4002A63")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsDisplaying;

	[Token(Token = "0x6004AE2")]
	[Address(RVA = "0x5AFD40", Offset = "0x5AE540", Length = "0x134")]
	public void OnAwake()
	{
	}

	[Token(Token = "0x6004AE3")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnStart()
	{
	}

	[Token(Token = "0x6004AE4")]
	[Address(RVA = "0x5AFAA0", Offset = "0x5AE2A0", Length = "0xB3")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6004AE5")]
	[Address(RVA = "0x5AFF90", Offset = "0x5AE790", Length = "0x115")]
	private void SwitchFPSDisplay(bool enable)
	{
	}

	[Token(Token = "0x6004AE6")]
	[Address(RVA = "0x5AFE80", Offset = "0x5AE680", Length = "0x105")]
	private void Show()
	{
	}

	[Address(RVA = "0x5AFB60", Offset = "0x5AE360", Length = "0xA9")]
	[Token(Token = "0x6004AE7")]
	private void Hide()
	{
	}

	[Token(Token = "0x6004AE8")]
	[Address(RVA = "0x5AFC10", Offset = "0x5AE410", Length = "0x129")]
	private void Loop(float t)
	{
	}

	[Token(Token = "0x6004AE9")]
	[Address(RVA = "0x5B00B0", Offset = "0x5AE8B0", Length = "0xE")]
	public FPSCounter()
	{
	}
}
