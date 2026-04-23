using Cpp2ILInjected;
using Spine;
using UnityEngine;

namespace GameLogic;

[Token(Token = "0x200049B")]
public class DoNothing
{
	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x10")]
	protected int idx;

	[Token(Token = "0x4001904")]
	[FieldOffset(Offset = "0x18")]
	protected GameObject gameObject;

	[Token(Token = "0x4001905")]
	[FieldOffset(Offset = "0x20")]
	protected SpineActionController spineCtrl;

	[Token(Token = "0x170004C9")]
	public GameObject NothingTarget
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x60034BE")]
		get
		{
			return null;
		}
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[Token(Token = "0x60034BF")]
		set
		{
		}
	}

	[Token(Token = "0x170004CA")]
	public int NothingObjIdx
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[Token(Token = "0x60034C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170004CB")]
	public SpineActionController SpineCtrl
	{
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[Token(Token = "0x60034C3")]
		set
		{
		}
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60034BA")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60034BB")]
	[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
	public void SetIdx(int idx)
	{
	}

	[Token(Token = "0x60034BC")]
	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	public void SetGameObject(GameObject obj)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60034BD")]
	public virtual void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60034C4")]
	public DoNothing()
	{
	}
}
