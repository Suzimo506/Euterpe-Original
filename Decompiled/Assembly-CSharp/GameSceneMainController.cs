using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000040")]
public class GameSceneMainController : SingletonMonoBehaviour<GameSceneMainController>, IPause
{
	[Token(Token = "0x4000187")]
	public static int curResolutionWidth;

	[Token(Token = "0x4000188")]
	public static int curResolutionHeight;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400018B")]
	public PnlBattle pnlBattle;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400018C")]
	private AudioClip m_CurrentMusicClip;

	[Token(Token = "0x1700002E")]
	public Camera SceneCamera
	{
		[Token(Token = "0x6000198")]
		[CompilerGenerated]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[Token(Token = "0x6000199")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public ScreenEffectCollection screenEffect
	{
		[Token(Token = "0x600019A")]
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x60001A5")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x5BE5C0", Offset = "0x5BCDC0", Length = "0x2D3")]
	[Token(Token = "0x600019C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x5BEC20", Offset = "0x5BD420", Length = "0x7B")]
	private void OnShowVictory(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x5BEBA0", Offset = "0x5BD3A0", Length = "0x7B")]
	private void OnFail()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A930", Offset = "0x59D30")]
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x5BEDA0", Offset = "0x5BD5A0", Length = "0x65")]
	private IEnumerator Start()
	{
		return null;
	}

	[Address(RVA = "0x5BE8A0", Offset = "0x5BD0A0", Length = "0x15A")]
	[Token(Token = "0x60001A0")]
	public void GameInit()
	{
	}

	[Address(RVA = "0x5BEB50", Offset = "0x5BD350", Length = "0x4B")]
	[Token(Token = "0x60001A1")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x5BEA00", Offset = "0x5BD200", Length = "0x145")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x5BECA0", Offset = "0x5BD4A0", Length = "0x78")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x5BED20", Offset = "0x5BD520", Length = "0x78")]
	[Token(Token = "0x60001A4")]
	public void Resume()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x5BEE10", Offset = "0x5BD610", Length = "0x38")]
	public GameSceneMainController()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
