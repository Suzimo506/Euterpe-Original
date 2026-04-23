using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003A")]
public abstract class BaseSpineObjectController : MonoBehaviour, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017C")]
	public int idx;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400017D")]
	protected int m_SceneIdx;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x20")]
	protected Renderer m_Renderer;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017F")]
	protected SpriteRenderer m_CatchAir;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000180")]
	protected SpriteRenderer m_CatchGround;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000181")]
	protected SpineActionController m_Sac;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000182")]
	protected bool m_IsVisible;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000184")]
	protected GameObject m_Blood;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000185")]
	protected List<GameObject> m_HideObjs;

	[Token(Token = "0x1700002A")]
	public Renderer ObjRenderer
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x6000177")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public bool isVisible
	{
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		[Token(Token = "0x6000178")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002C")]
	public bool isIn
	{
		[CompilerGenerated]
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5F9A70", Offset = "0x5F8270", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x5F9A80", Offset = "0x5F8280", Length = "0x4")]
		[Token(Token = "0x6000179")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6000186")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600017B")]
	public abstract void SetIdx(int idx);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600017C")]
	public abstract void Init(int scene);

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract bool ControllerMissCheck(int idx, decimal currentTick);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600017E")]
	public abstract void OnControllerStart();

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract bool OnControllerMiss(int idx);

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void OnControllerAttacked(int result, bool isDeaded);

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnControllerAttackedButHurt(int result, bool isDeaded, int objIdx = -1)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
	public int GetIdx()
	{
		return default(int);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x5F98F0", Offset = "0x5F80F0", Length = "0x17E")]
	public virtual void SetVisible(bool enable)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x5F9860", Offset = "0x5F8060", Length = "0x87")]
	protected virtual void SetOrder(int order)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SyncAnimatorTick(float tick)
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000187")]
	public abstract void Pause(bool pauseCorountine);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000188")]
	public abstract void Resume();

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x5F9700", Offset = "0x5F7F00", Length = "0x52")]
	public void AddHideObj(GameObject hideObj)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x5F9760", Offset = "0x5F7F60", Length = "0xF3")]
	public void SetHideObjsVisible(bool isShow = true)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x5F94D0", Offset = "0x5F7CD0", Length = "0x70")]
	protected BaseSpineObjectController()
	{
	}
}
