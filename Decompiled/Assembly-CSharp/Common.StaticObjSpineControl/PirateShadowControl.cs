using Cpp2ILInjected;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace Common.StaticObjSpineControl;

[Token(Token = "0x20004E5")]
public class PirateShadowControl : StaticSynhroObject
{
	[Attribute(Name = "RangeAttribute", RVA = "0x2170", Offset = "0x1570")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A6A")]
	private float scaleK;

	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x6F30", Offset = "0x6330")]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001A6B")]
	private float scaleB;

	[Token(Token = "0x4001A6C")]
	[FieldOffset(Offset = "0x28")]
	private BoneFollower m_FollowerComp;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A6D")]
	private SpineActionController m_Sac;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A6E")]
	private GameObject m_StaticObjIns;

	[Token(Token = "0x4001A6F")]
	[FieldOffset(Offset = "0x40")]
	private Bone m_FollowedBone;

	[Token(Token = "0x170004FD")]
	public GameObject ShadowObj
	{
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x472290", Offset = "0x470A90", Length = "0x213")]
	[Token(Token = "0x6003638")]
	public override void Init()
	{
	}

	[Token(Token = "0x6003639")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Release()
	{
	}

	[Address(RVA = "0x471FE0", Offset = "0x4707E0", Length = "0x2AA")]
	[Token(Token = "0x600363A")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600363B")]
	[Address(RVA = "0x4724B0", Offset = "0x470CB0", Length = "0x15")]
	public PirateShadowControl()
	{
	}
}
