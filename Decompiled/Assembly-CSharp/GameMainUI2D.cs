using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000B2")]
public class GameMainUI2D : MonoBehaviour, IPause
{
	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator m_ZombieSkill;

	[SerializeField]
	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x20")]
	private PnlFail m_PnlFail;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A2")]
	[SerializeField]
	private CanvasScaler m_CanvasScaler;

	[Token(Token = "0x1700007B")]
	public bool IsGlobal
	{
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x5BE0B0", Offset = "0x5BC8B0", Length = "0x1B6")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5BE2B0", Offset = "0x5BCAB0", Length = "0x9D")]
	[Token(Token = "0x6000547")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x5B0A40", Offset = "0x5AF240", Length = "0x20")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x5B0A70", Offset = "0x5AF270", Length = "0x20")]
	public void Resume()
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x5BE270", Offset = "0x5BCA70", Length = "0x3F")]
	private void OnBattleFail()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600054C")]
	public GameMainUI2D()
	{
	}
}
