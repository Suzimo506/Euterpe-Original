using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Spine;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x200001A")]
[Attribute(Name = "RequireComponent", RVA = "0x54D00", Offset = "0x54100")]
public class BloodheirShadowControl : StaticSynhroObject
{
	[Token(Token = "0x400007F")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x2170", Offset = "0x1570")]
	[FieldOffset(Offset = "0x24")]
	private float scaleK;

	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x6F30", Offset = "0x6330")]
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	private float scaleB;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000081")]
	private BoneFollower m_FollowerComp;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000082")]
	private SpineActionController m_Sac;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000083")]
	private GameObject m_StaticObjIns;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x48")]
	private Bone m_FollowedBone;

	[Token(Token = "0x17000014")]
	public bool IsInited
	{
		[Token(Token = "0x60000A7")]
		[CompilerGenerated]
		[Address(RVA = "0x45D430", Offset = "0x45BC30", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x45D440", Offset = "0x45BC40", Length = "0x4")]
		[Token(Token = "0x60000A8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public GameObject ShadowObj
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x45D1E0", Offset = "0x45B9E0", Length = "0x217")]
	public override void Init()
	{
	}

	[Address(RVA = "0x45D400", Offset = "0x45BC00", Length = "0x5")]
	[Token(Token = "0x60000AB")]
	public override void Release()
	{
	}

	[Address(RVA = "0x45CF30", Offset = "0x45B730", Length = "0x2AA")]
	[Token(Token = "0x60000AC")]
	private void FixedUpdate()
	{
	}

	[Address(RVA = "0x45D410", Offset = "0x45BC10", Length = "0x15")]
	[Token(Token = "0x60000AD")]
	public BloodheirShadowControl()
	{
	}
}
