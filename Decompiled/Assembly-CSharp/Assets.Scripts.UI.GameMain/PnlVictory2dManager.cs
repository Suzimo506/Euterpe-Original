using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200089B")]
public class PnlVictory2dManager : MonoBehaviour
{
	[Token(Token = "0x4002CC3")]
	[FieldOffset(Offset = "0x18")]
	public VictoryComps[] victoryComps;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CC4")]
	private VictoryComps m_CurVictoryComp;

	[Token(Token = "0x6004DF1")]
	[Address(RVA = "0x5B2DC0", Offset = "0x5B15C0", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6004DF2")]
	[Address(RVA = "0x5B2570", Offset = "0x5B0D70", Length = "0x320")]
	public void Init()
	{
	}

	[Token(Token = "0x6004DF3")]
	[Address(RVA = "0x5B28A0", Offset = "0x5B10A0", Length = "0xA2")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004DF4")]
	[Address(RVA = "0x5B2BC0", Offset = "0x5B13C0", Length = "0xD5")]
	private void ShowFullCombo()
	{
	}

	[Address(RVA = "0x5B2CA0", Offset = "0x5B14A0", Length = "0x119")]
	[Token(Token = "0x6004DF5")]
	private void ShowVictory()
	{
	}

	[Address(RVA = "0x5B2950", Offset = "0x5B1150", Length = "0x263")]
	[Token(Token = "0x6004DF6")]
	private void OnShowVictory(object sender, object rev, params object[] pars)
	{
	}

	[Token(Token = "0x6004DF7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlVictory2dManager()
	{
	}
}
