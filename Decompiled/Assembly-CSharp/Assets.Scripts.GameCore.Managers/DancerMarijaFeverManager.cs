using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GameLogic;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200073C")]
public class DancerMarijaFeverManager : AbstractFeverManager
{
	[Token(Token = "0x4002635")]
	private static readonly Dictionary<List<int>, double> m_FeverAddValuePerSec;

	[Token(Token = "0x4002636")]
	[FieldOffset(Offset = "0x68")]
	private TweenerCore<int, int, NoOptions> m_AddFeverTweener;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002637")]
	private bool m_StopAddFever;

	[Token(Token = "0x4002638")]
	[FieldOffset(Offset = "0x71")]
	private bool m_FallbackToNormalAddFever;

	[Token(Token = "0x6004353")]
	[Address(RVA = "0x78D4E0", Offset = "0x78BCE0", Length = "0x10D")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004354")]
	[Address(RVA = "0x78DDF0", Offset = "0x78C5F0", Length = "0x4D")]
	public override void StartInit()
	{
	}

	[Address(RVA = "0x78DC10", Offset = "0x78C410", Length = "0x1DC")]
	[Token(Token = "0x6004355")]
	public void StartAutoAddFever()
	{
	}

	[Token(Token = "0x6004356")]
	[Address(RVA = "0x78D5F0", Offset = "0x78BDF0", Length = "0x1CD")]
	protected override void FeverEnd()
	{
	}

	[Token(Token = "0x6004357")]
	[Address(RVA = "0x78D7C0", Offset = "0x78BFC0", Length = "0x2C1")]
	private int GetAddDurationWithLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6004358")]
	[Address(RVA = "0x78D410", Offset = "0x78BC10", Length = "0xC4")]
	public override void AddFever(ref MusicData md, int result)
	{
	}

	[Token(Token = "0x6004359")]
	[Address(RVA = "0x78DA90", Offset = "0x78C290", Length = "0x61")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x600435A")]
	[Address(RVA = "0x78DBA0", Offset = "0x78C3A0", Length = "0x61")]
	public override void Resume()
	{
	}

	[Token(Token = "0x600435B")]
	[Address(RVA = "0x78DB00", Offset = "0x78C300", Length = "0x9B")]
	public override void Release()
	{
	}

	[Token(Token = "0x600435C")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DancerMarijaFeverManager()
	{
	}
}
