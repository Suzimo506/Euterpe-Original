using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Actions;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000814")]
public class DBUi : BaseDatabase
{
	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0x10")]
	public readonly Stack<PlayPopuper> popups;

	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<DG.Tweening.Sequence> m_Seqs;

	[Token(Token = "0x4002A19")]
	[FieldOffset(Offset = "0x20")]
	public int troveCount;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002A1A")]
	public int unlockDiffByAbility;

	[Token(Token = "0x4002A1B")]
	[FieldOffset(Offset = "0x28")]
	public float ability;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002A1C")]
	public bool thisFrameBtnInvoke;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002A1D")]
	public WeekFreeToDlcArgs weekFreeToDlcArgs;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002A1E")]
	public bool showTerminal;

	[Token(Token = "0x17000775")]
	public string curLanguage
	{
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x1030380", Offset = "0x102EB80", Length = "0x4B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000776")]
	public int curLanguageIndex
	{
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x1030320", Offset = "0x102EB20", Length = "0x55")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600493E")]
	[Address(RVA = "0x1030250", Offset = "0x102EA50", Length = "0x9")]
	public bool ThisFrameInvokeButton()
	{
		return default(bool);
	}

	[Address(RVA = "0x102FE50", Offset = "0x102E650", Length = "0x7")]
	[Token(Token = "0x600493F")]
	public void ResetAbility()
	{
	}

	[Token(Token = "0x6004940")]
	[Address(RVA = "0x1030090", Offset = "0x102E890", Length = "0x1BA")]
	public void SetSkin(int roleIndex, int skinIndex)
	{
	}

	[Token(Token = "0x6004941")]
	[Address(RVA = "0x102FD40", Offset = "0x102E540", Length = "0x10B")]
	public int GetSkinIndex(int roleIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6004942")]
	[Address(RVA = "0x102FE60", Offset = "0x102E660", Length = "0x173")]
	public void ResetAllSkin()
	{
	}

	[Token(Token = "0x6004943")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004944")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Release()
	{
	}

	[Address(RVA = "0x102FFE0", Offset = "0x102E7E0", Length = "0xA6")]
	[Token(Token = "0x6004945")]
	public override void SceneChangedRelease(Scene preScene, Scene curScene)
	{
	}

	[Token(Token = "0x6004946")]
	[Address(RVA = "0x1030260", Offset = "0x102EA60", Length = "0xB4")]
	public DBUi()
	{
	}
}
