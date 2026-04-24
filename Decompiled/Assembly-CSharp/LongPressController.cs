using System.Collections.Generic;
using Cpp2ILInjected;
using FormulaBase;
using GameLogic;

[Token(Token = "0x2000044")]
public class LongPressController : BaseEnemyObjectController
{
	[Token(Token = "0x4000199")]
	public static int psidx;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x218")]
	private bool m_IsActive;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x219")]
	private bool m_IsHurt;

	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x400019C")]
	private int m_FingerId;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x220")]
	private MusicData m_PMusicData;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x380")]
	private List<LongPressController> m_LongChild;

	[Token(Token = "0x1700003A")]
	public MusicData PMusicData
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x8BF420", Offset = "0x8BDC20", Length = "0xA3")]
		get
		{
			return default(MusicData);
		}
	}

	[Token(Token = "0x1700003B")]
	public SpineActionController PSpineActionController
	{
		[Address(RVA = "0x8BF4D0", Offset = "0x8BDCD0", Length = "0x75")]
		[Token(Token = "0x60001D0")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x8BD8F0", Offset = "0x8BC0F0", Length = "0x17B")]
	[Token(Token = "0x60001D1")]
	public static int GetPMusicIndex(int pressIdx)
	{
		return default(int);
	}

	[Address(RVA = "0x8BDA70", Offset = "0x8BC270", Length = "0x489")]
	[Token(Token = "0x60001D2")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x8BD850", Offset = "0x8BC050", Length = "0x9E")]
	private void AddChild(LongPressController LongPressCtrl)
	{
	}

	[Address(RVA = "0x8BE920", Offset = "0x8BD120", Length = "0xC0")]
	[Token(Token = "0x60001D4")]
	public void SetChildActive(bool active)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x8BEAC0", Offset = "0x8BD2C0", Length = "0xC0")]
	private void SetChildHurt(bool hurt)
	{
	}

	[Address(RVA = "0x8BE9F0", Offset = "0x8BD1F0", Length = "0xC0")]
	[Token(Token = "0x60001D6")]
	public void SetChildFingerId(int fingerId)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	public override bool ControllerMissCheck(int i, decimal currentTick)
	{
		return default(bool);
	}

	[Address(RVA = "0x8BE420", Offset = "0x8BCC20", Length = "0x4FC")]
	[Token(Token = "0x60001D8")]
	public void OnControllerHit(TimeNodeOrder tno, TimeNodeOrder[] tnos, int count)
	{
	}

	[Address(RVA = "0x8BDF00", Offset = "0x8BC700", Length = "0x3D")]
	[Token(Token = "0x60001D9")]
	private void LongPressEnd()
	{
	}

	[Address(RVA = "0x8BEC00", Offset = "0x8BD400", Length = "0x260")]
	[Token(Token = "0x60001DA")]
	public void TouchEndResult(TimeNodeOrder tno, bool forceJudge = false)
	{
	}

	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	[Token(Token = "0x60001DB")]
	public override bool OnControllerMiss(int i)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x8BDF40", Offset = "0x8BC740", Length = "0x4D8")]
	public void LongPressHurt()
	{
	}

	[Address(RVA = "0x8BEB90", Offset = "0x8BD390", Length = "0x63")]
	[Token(Token = "0x60001DD")]
	public override void SetVisible(bool enable)
	{
	}

	[Address(RVA = "0x8BF3C0", Offset = "0x8BDBC0", Length = "0x58")]
	[Token(Token = "0x60001DE")]
	public LongPressController()
	{
	}
}
