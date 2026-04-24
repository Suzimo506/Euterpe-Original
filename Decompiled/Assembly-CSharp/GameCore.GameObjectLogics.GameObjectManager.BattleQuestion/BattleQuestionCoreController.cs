using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Token(Token = "0x200047D")]
public class BattleQuestionCoreController : MonoBehaviour
{
	[Token(Token = "0x400183E")]
	private static BattleQuestionContext s_Context;

	[Token(Token = "0x400183F")]
	private static BattleQuestionCoreController s_Instance;

	[SerializeField]
	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x20")]
	private Canvas m_UiShowCanvas;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001842")]
	private Camera m_BattleQuestionCamera;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001843")]
	private BaseBattleQuestionView m_View;

	[Token(Token = "0x170004A4")]
	public static BattleQuestionCoreController Instance
	{
		[Token(Token = "0x6003385")]
		[Address(RVA = "0x838A30", Offset = "0x837230", Length = "0x36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A5")]
	public static BattleQuestionContext Context
	{
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x8389F0", Offset = "0x8371F0", Length = "0x35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A6")]
	public Canvas UIRoot
	{
		[Token(Token = "0x6003387")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A7")]
	public Camera BattleQuestionCamera
	{
		[Token(Token = "0x6003388")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A8")]
	public Vector2 ReferenceResolution
	{
		[Address(RVA = "0x838A70", Offset = "0x837270", Length = "0x13")]
		[Token(Token = "0x600338A")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003389")]
		[Address(RVA = "0x4434C0", Offset = "0x441CC0", Length = "0x5")]
		private set
		{
		}
	}

	[Address(RVA = "0x837DC0", Offset = "0x8365C0", Length = "0x519")]
	[Token(Token = "0x600338B")]
	private void Awake()
	{
	}

	[Address(RVA = "0x838540", Offset = "0x836D40", Length = "0x29")]
	[Token(Token = "0x600338C")]
	private void OnGameFailed()
	{
	}

	[Address(RVA = "0x8382E0", Offset = "0x836AE0", Length = "0x32")]
	[Token(Token = "0x600338D")]
	private void OnAutoPlayStateChanged(bool isAutoPlay)
	{
	}

	[Token(Token = "0x600338E")]
	[Address(RVA = "0x838800", Offset = "0x837000", Length = "0x1EC")]
	private void OnQuestionShow(MusicData md)
	{
	}

	[Token(Token = "0x600338F")]
	[Address(RVA = "0x838570", Offset = "0x836D70", Length = "0x286")]
	private void OnQuestionAnswered(MusicData md)
	{
	}

	[Token(Token = "0x6003390")]
	[Address(RVA = "0x838320", Offset = "0x836B20", Length = "0x21B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003391")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BattleQuestionCoreController()
	{
	}
}
