using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Cpp2ILInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GameCore.GameObjectLogics.GameObjectManager;
using GameLogic;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000740")]
public class WisadelFeverManager : AbstractFeverManager
{
	[Token(Token = "0x400263B")]
	public const string sdx_w_sound_bomb = "maou_se_battle_explosion03";

	[Token(Token = "0x400263D")]
	[FieldOffset(Offset = "0x70")]
	private WisadelGirlManager m_GirlManager;

	[Token(Token = "0x400263E")]
	[FieldOffset(Offset = "0x78")]
	private TweenerCore<int, int, NoOptions> m_AddFeverTweener;

	[Token(Token = "0x17000654")]
	public bool IsWisaOnFeverState
	{
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000655")]
	public WisadelBombEffectController BombEffectCtrl
	{
		[CompilerGenerated]
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x5C14A0", Offset = "0x5BFCA0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x17000656")]
	private WisadelGirlManager GirlManager
	{
		[Address(RVA = "0x7E26C0", Offset = "0x7E0EC0", Length = "0x109")]
		[Token(Token = "0x6004379")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600437A")]
	[Address(RVA = "0x7E1F40", Offset = "0x7E0740", Length = "0x109")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x7E2120", Offset = "0x7E0920", Length = "0x26F")]
	[Token(Token = "0x600437B")]
	public override bool InvokeFever()
	{
		return default(bool);
	}

	[Address(RVA = "0x7E2390", Offset = "0x7E0B90", Length = "0x1FA")]
	[Token(Token = "0x600437C")]
	public void OnFeverValidateTip()
	{
	}

	[Token(Token = "0x600437D")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void AddFever(ref MusicData md, int result)
	{
	}

	[Token(Token = "0x600437E")]
	[Address(RVA = "0x7E2050", Offset = "0x7E0850", Length = "0xCD")]
	protected override void FeverEnd()
	{
	}

	[Token(Token = "0x600437F")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public WisadelFeverManager()
	{
	}
}
