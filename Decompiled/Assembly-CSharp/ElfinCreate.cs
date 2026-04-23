using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x20000AC")]
public class ElfinCreate : MonoBehaviour, IPreWarm, IPause
{
	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_ElfinObject;

	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x20")]
	private Renderer m_Renderer;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x28")]
	private SkeletonMecanim m_SkeletonMecanim;

	[Token(Token = "0x1700007A")]
	public bool IsGlobal
	{
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x446C10", Offset = "0x445410", Length = "0xA8")]
	[Token(Token = "0x6000521")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x446640", Offset = "0x444E40", Length = "0x4C0")]
	[Token(Token = "0x6000522")]
	private void OnBattleStart(object sender, object rev, params object[] pars)
	{
	}

	[Address(RVA = "0x446CC0", Offset = "0x4454C0", Length = "0x8F")]
	[Token(Token = "0x6000523")]
	private void RefreshSkeletonMecanim()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x446B10", Offset = "0x445310", Length = "0xF1")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x446D50", Offset = "0x445550", Length = "0x7B")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ElfinCreate()
	{
	}
}
