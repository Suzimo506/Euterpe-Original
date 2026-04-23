using Cpp2ILInjected;
using DG.Tweening;
using FormulaBase;
using UnityEngine;

[Token(Token = "0x2000045")]
public class MultHitEnemyController : NormalEnemyController
{
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x400019F")]
	private bool m_IsFlyAway;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x234")]
	private int m_HitCount;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x238")]
	private float m_AtkTime;

	[Token(Token = "0x40001A2")]
	private static float m_OriginSize;

	[Token(Token = "0x40001A3")]
	private static Camera m_Camera;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x23C")]
	private int m_MulHitLowThreshold;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x240")]
	private int m_MulHitMidThreshold;

	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x40001A6")]
	private int m_MulHitHighThreshold;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x248")]
	private float m_HitTime;

	[Token(Token = "0x40001A8")]
	public static bool isMulHitEnding;

	[Token(Token = "0x40001A9")]
	public static bool isBanEmptyAction;

	[Token(Token = "0x40001AA")]
	public static int hitCount;

	[Token(Token = "0x40001AB")]
	private static Sequence m_HittingCameraSequence;

	[Token(Token = "0x40001AC")]
	public static bool isHitting;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x24C")]
	private bool m_IsPlayBossHitAnimatorState;

	[Token(Token = "0x1700003C")]
	public bool isDead
	{
		[Address(RVA = "0x8C5BF0", Offset = "0x8C43F0", Length = "0x8")]
		[Token(Token = "0x60001E2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public bool isOver
	{
		[Address(RVA = "0x8C5C00", Offset = "0x8C4400", Length = "0x10")]
		[Token(Token = "0x60001E3")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x8C49F0", Offset = "0x8C31F0", Length = "0x7E")]
	[Token(Token = "0x60001E4")]
	public static void Pause()
	{
	}

	[Address(RVA = "0x8C4A70", Offset = "0x8C3270", Length = "0x7E")]
	[Token(Token = "0x60001E5")]
	public new static void Resume()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x8C2C70", Offset = "0x8C1470", Length = "0x2DC")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x8C3E20", Offset = "0x8C2620", Length = "0x2D4")]
	public override void OnControllerStart()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x8C2B10", Offset = "0x8C1310", Length = "0x11C")]
	public override bool ControllerMissCheck(int i, decimal currentTick)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x8C3CC0", Offset = "0x8C24C0", Length = "0x151")]
	public override bool OnControllerMiss(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x8C3760", Offset = "0x8C1F60", Length = "0x55F")]
	[Token(Token = "0x60001EA")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Address(RVA = "0x8C4100", Offset = "0x8C2900", Length = "0x372")]
	[Token(Token = "0x60001EB")]
	public void OnControllerTick(TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x8C2C30", Offset = "0x8C1430", Length = "0x3D")]
	private void Fail()
	{
	}

	[Address(RVA = "0x8C5640", Offset = "0x8C3E40", Length = "0x5AA")]
	[Token(Token = "0x60001ED")]
	private void Succuess(bool isTotal = false, bool resulted = true)
	{
	}

	[Address(RVA = "0x8C2F50", Offset = "0x8C1750", Length = "0x504")]
	[Token(Token = "0x60001EE")]
	private void InvokeHitEnd()
	{
	}

	[Address(RVA = "0x8C4480", Offset = "0x8C2C80", Length = "0x4E")]
	[Token(Token = "0x60001EF")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x8C4AF0", Offset = "0x8C32F0", Length = "0x59A")]
	public static void ShakeBossCamera()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x8C5090", Offset = "0x8C3890", Length = "0x5A4")]
	public static void ShakeMulCamera()
	{
	}

	[Address(RVA = "0x8C28E0", Offset = "0x8C10E0", Length = "0x22D")]
	[Token(Token = "0x60001F2")]
	private void ChangeViewWhenNoteHitStart()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x8C2590", Offset = "0x8C0D90", Length = "0x34A")]
	private void ChangeViewWhenNoteHitEnd()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x8C3460", Offset = "0x8C1C60", Length = "0x158")]
	private void OnCharacterHitEnd()
	{
	}

	[Address(RVA = "0x8C35C0", Offset = "0x8C1DC0", Length = "0x197")]
	[Token(Token = "0x60001F5")]
	private void OnCharacterOneHit()
	{
	}

	[Address(RVA = "0x8C44D0", Offset = "0x8C2CD0", Length = "0x16A")]
	[Token(Token = "0x60001F6")]
	private void OnNoteAttackOneHit()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x8C4850", Offset = "0x8C3050", Length = "0x194")]
	private void OnNoteHitSuccessAction(bool isTotal)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x8C4640", Offset = "0x8C2E40", Length = "0x20F")]
	private void OnNoteHitFailAction()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x44E9B0", Offset = "0x44D1B0", Length = "0x7")]
	public MultHitEnemyController()
	{
	}
}
