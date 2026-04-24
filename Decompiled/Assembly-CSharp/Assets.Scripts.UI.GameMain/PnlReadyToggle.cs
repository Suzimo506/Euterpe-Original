using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x2000899")]
public class PnlReadyToggle : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x4002CB8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] touhouTitle;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CB9")]
	public PnlReadyComps[] pnlReadyComps;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002CBA")]
	private PnlReadyComps m_CurReadyComp;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002CBB")]
	private AudioClip m_ReadyClip;

	[SerializeField]
	[Token(Token = "0x4002CBC")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_TouhouTransform;

	[Token(Token = "0x4002CBD")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_TouhouTitleGo;

	[Token(Token = "0x6004DE6")]
	[Address(RVA = "0x5B1C70", Offset = "0x5B0470", Length = "0xA8")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6004DE7")]
	[Address(RVA = "0x5B15E0", Offset = "0x5AFDE0", Length = "0x371")]
	private void OnStageStart(object sender, object rev, params object[] pars)
	{
	}

	[Token(Token = "0x6004DE8")]
	[Address(RVA = "0x5B14B0", Offset = "0x5AFCB0", Length = "0x123")]
	private bool CheckNeedToPlayReadyGo()
	{
		return default(bool);
	}

	[Token(Token = "0x6004DE9")]
	[Address(RVA = "0x5B1AF0", Offset = "0x5B02F0", Length = "0x170")]
	private void PlayReadyGo()
	{
	}

	[Token(Token = "0x6004DEA")]
	[Address(RVA = "0x5B1D20", Offset = "0x5B0520", Length = "0x656")]
	private void SetCurReadyComp()
	{
	}

	[Token(Token = "0x6004DEB")]
	[Address(RVA = "0x5B1960", Offset = "0x5B0160", Length = "0xB8")]
	private void PlayReadyCompAnimation()
	{
	}

	[Token(Token = "0x6004DEC")]
	[Address(RVA = "0x5B1A20", Offset = "0x5B0220", Length = "0xC2")]
	private void PlayReadyCompAuidoClip()
	{
	}

	[Token(Token = "0x6004DED")]
	[Address(RVA = "0x5B2380", Offset = "0x5B0B80", Length = "0x147")]
	private void TouhouTitleLogic(string musicUid)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004DEE")]
	public PnlReadyToggle()
	{
	}
}
