using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008BA")]
public class AwardItem : DirtyNode
{
	[Token(Token = "0x4002D8A")]
	[FieldOffset(Offset = "0x20")]
	public Text chipTxt;

	[Token(Token = "0x4002D8B")]
	[FieldOffset(Offset = "0x28")]
	public Transform character;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002D8C")]
	public Transform elfin;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002D8D")]
	public Transform trove;

	[Token(Token = "0x4002D8E")]
	[FieldOffset(Offset = "0x40")]
	public Transform parent;

	[Token(Token = "0x4002D8F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject image;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002D90")]
	private LongSongNameController m_LongSongNameController;

	[Token(Token = "0x4002D91")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem.Particle m_Particle;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002D92")]
	private GameObject m_GameObject;

	[Token(Token = "0x4002D93")]
	private static int m_DoneCount;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002D94")]
	private Animation m_Animation;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002D95")]
	private AwardInfo m_AwardInfo;

	[Token(Token = "0x17000885")]
	public string awardType
	{
		[Address(RVA = "0x5A75C0", Offset = "0x5A5DC0", Length = "0x51")]
		[Token(Token = "0x6004ED5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004ED6")]
	[Address(RVA = "0x5A6EA0", Offset = "0x5A56A0", Length = "0x4A")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5A74E0", Offset = "0x5A5CE0", Length = "0xC0")]
	[Token(Token = "0x6004ED7")]
	public override void Show(params object[] param)
	{
	}

	[Address(RVA = "0x5A73C0", Offset = "0x5A5BC0", Length = "0x119")]
	[Token(Token = "0x6004ED8")]
	protected override void OnReset()
	{
	}

	[Address(RVA = "0x5A6EF0", Offset = "0x5A56F0", Length = "0x4CC")]
	[Token(Token = "0x6004ED9")]
	public void DoFlyParticleAni(particleHoming assignParticle, Transform targetTrans = null, Action callback = null)
	{
	}

	[Address(RVA = "0x5A75B0", Offset = "0x5A5DB0", Length = "0x7")]
	[Token(Token = "0x6004EDA")]
	public AwardItem()
	{
	}
}
