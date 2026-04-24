using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using GameLogic;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x2000041")]
public class GirlActionController : BaseSpineObjectController
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000195")]
	private bool m_HasGhostObj;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0xA0")]
	private Tweener[] m_GhostDisapparTwn;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000198")]
	private Sequence m_GhostDisapparSeq;

	[Token(Token = "0x17000031")]
	public SpineActionController spineActionCtrl
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x51B9E0", Offset = "0x51A1E0", Length = "0xC")]
		[Token(Token = "0x60001A7")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Material[] ghostMtrl
	{
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		[Token(Token = "0x60001AA")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x5A6760", Offset = "0x5A4F60", Length = "0xC")]
		[Token(Token = "0x60001A9")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public Animation ghostAnimation
	{
		[CompilerGenerated]
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x5C14A0", Offset = "0x5BFCA0", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x60001AB")]
		private set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public ParticleSystem ghostParticles
	{
		[CompilerGenerated]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x422030", Offset = "0x420830", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public Animator ghostAnimator
	{
		[Token(Token = "0x60001AF")]
		[CompilerGenerated]
		[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x5C14B0", Offset = "0x5BFCB0", Length = "0xC")]
		[Token(Token = "0x60001B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public SkeletonAnimation ghostSk
	{
		[Token(Token = "0x60001B1")]
		[CompilerGenerated]
		[Address(RVA = "0x4865C0", Offset = "0x484DC0", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x5C14C0", Offset = "0x5BFCC0", Length = "0xC")]
		[Token(Token = "0x60001B2")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public GameObject go
	{
		[CompilerGenerated]
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x5C1450", Offset = "0x5BFC50", Length = "0x8")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5C14D0", Offset = "0x5BFCD0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public Animator animator
	{
		[CompilerGenerated]
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B5")]
		[CompilerGenerated]
		[Address(RVA = "0x49A8F0", Offset = "0x4990F0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public static GirlActionController instance
	{
		[CompilerGenerated]
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x5C1460", Offset = "0x5BFC60", Length = "0x35")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B8")]
		[CompilerGenerated]
		[Address(RVA = "0x5C14E0", Offset = "0x5BFCE0", Length = "0x42")]
		private set
		{
		}
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x5C1080", Offset = "0x5BF880", Length = "0x265")]
	public static void ReleaseReferences()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x5C0F60", Offset = "0x5BF760", Length = "0x46")]
	private void OnFail()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x5C0E00", Offset = "0x5BF600", Length = "0x156")]
	public override void OnControllerStart()
	{
	}

	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	[Token(Token = "0x60001BC")]
	public override bool ControllerMissCheck(int idx, decimal currentTick)
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60001BD")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x5C04B0", Offset = "0x5BECB0", Length = "0x361")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
	public override void SetIdx(int idx)
	{
	}

	[Address(RVA = "0x5BF630", Offset = "0x5BDE30", Length = "0x62")]
	[Token(Token = "0x60001C1")]
	public void Attack(string actKey, uint result)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x5BF6A0", Offset = "0x5BDEA0", Length = "0x736")]
	private void GhostAttack(uint result, int id)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x5C0820", Offset = "0x5BF020", Length = "0x16C")]
	public void InvokeGhostAttack(bool hitStart, bool ghostAir, uint result, MusicData md)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x5BFDE0", Offset = "0x5BE5E0", Length = "0x431")]
	public void GhostDisappear(float dt = 0.3f)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x5C0FB0", Offset = "0x5BF7B0", Length = "0xCD")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x5C12F0", Offset = "0x5BFAF0", Length = "0xCD")]
	[Token(Token = "0x60001C6")]
	public override void Resume()
	{
	}

	[Address(RVA = "0x5C0220", Offset = "0x5BEA20", Length = "0x28D")]
	[Token(Token = "0x60001C7")]
	private void GhostSetPause(bool pause)
	{
	}

	[Address(RVA = "0x5BEE50", Offset = "0x5BD650", Length = "0x7D1")]
	[Token(Token = "0x60001C8")]
	public void AttackQuick(string actKey, uint result, int id = -1)
	{
	}

	[Address(RVA = "0x5C0990", Offset = "0x5BF190", Length = "0x46C")]
	[Token(Token = "0x60001C9")]
	private string JumpAttack(string atkName, uint result, int id = -1)
	{
		return null;
	}

	[Address(RVA = "0x5C1400", Offset = "0x5BFC00", Length = "0x25")]
	[Token(Token = "0x60001CA")]
	private void __Attack(string actKey, uint result)
	{
	}

	[Address(RVA = "0x5C1430", Offset = "0x5BFC30", Length = "0x7")]
	[Token(Token = "0x60001CB")]
	public GirlActionController()
	{
	}
}
