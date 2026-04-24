using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl;

[Token(Token = "0x200048A")]
public class SubGirlActionController : BaseSpineObjectController
{
	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x58")]
	private SpineActionController m_SpineController;

	[Token(Token = "0x400188D")]
	[FieldOffset(Offset = "0x60")]
	private Animator m_Animator;

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60033E9")]
	public override void SetIdx(int idx)
	{
	}

	[Address(RVA = "0x849E50", Offset = "0x848650", Length = "0xF0")]
	[Token(Token = "0x60033EA")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x60033EB")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public override bool ControllerMissCheck(int idx, decimal currentTick)
	{
		return default(bool);
	}

	[Token(Token = "0x60033EC")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void OnControllerStart()
	{
	}

	[Token(Token = "0x60033ED")]
	[Address(RVA = "0x849F50", Offset = "0x848750", Length = "0x6B")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60033EE")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Address(RVA = "0x849FC0", Offset = "0x8487C0", Length = "0xC1")]
	[Token(Token = "0x60033EF")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x60033F0")]
	[Address(RVA = "0x84A090", Offset = "0x848890", Length = "0xC1")]
	public override void Resume()
	{
	}

	[Address(RVA = "0x5C1430", Offset = "0x5BFC30", Length = "0x7")]
	[Token(Token = "0x60033F1")]
	public SubGirlActionController()
	{
	}
}
