using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008C9")]
public abstract class AbstractTabContainer : UISelectManage
{
	[SerializeField]
	[Token(Token = "0x4002DCA")]
	[FieldOffset(Offset = "0x118")]
	protected AbstractTabItem[] m_Items;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002DCB")]
	protected int m_CurTabIndex;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002DCC")]
	[SerializeField]
	protected float[] m_AnimFinalPosition;

	[SerializeField]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002DCD")]
	protected float m_AnimTime;

	[Token(Token = "0x4002DCE")]
	[FieldOffset(Offset = "0x138")]
	protected List<GameObject> m_SelectObjs;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4002DCF")]
	protected ulong m_DirtyType;

	[Token(Token = "0x4002DD0")]
	[FieldOffset(Offset = "0x148")]
	private Dictionary<int, GameObject> m_DicDefaultSelectObj;

	[Token(Token = "0x1700088F")]
	public AbstractTabItem[] TabItems
	{
		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x427D10", Offset = "0x426510", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000890")]
	public int currentTabIndex
	{
		[Token(Token = "0x6004F1D")]
		[Address(RVA = "0x6BE970", Offset = "0x6BD170", Length = "0x7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000891")]
	public int tabCount
	{
		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x6BE980", Offset = "0x6BD180", Length = "0x1D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000892")]
	public GameObject lastSelected
	{
		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x4E8C50", Offset = "0x4E7450", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6BE730", Offset = "0x6BCF30", Length = "0x9F")]
	[Token(Token = "0x6004F1F")]
	public void SetSelectedGameObject(GameObject go)
	{
	}

	[Token(Token = "0x6004F21")]
	[Address(RVA = "0x6BE1F0", Offset = "0x6BC9F0", Length = "0x11")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6004F22")]
	[Address(RVA = "0x6BDE80", Offset = "0x6BC680", Length = "0x121")]
	protected virtual void Destroy()
	{
	}

	[Token(Token = "0x6004F23")]
	[Address(RVA = "0x6BE7D0", Offset = "0x6BCFD0", Length = "0x128")]
	public virtual bool SetTabIndex(int tabIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F24")]
	[Address(RVA = "0x6BE720", Offset = "0x6BCF20", Length = "0x8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x6004F25")]
	[Address(RVA = "0x6BDFC0", Offset = "0x6BC7C0", Length = "0x161")]
	protected virtual void InitTabContainer()
	{
	}

	[Token(Token = "0x6004F26")]
	[Address(RVA = "0x6BE350", Offset = "0x6BCB50", Length = "0x55")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x6BE2F0", Offset = "0x6BCAF0", Length = "0x55")]
	[Token(Token = "0x6004F27")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x6004F28")]
	[Address(RVA = "0x6BE670", Offset = "0x6BCE70", Length = "0xA0")]
	public virtual void SetDirty(int tabIndex = -1, ulong dirtyIndex = 0uL)
	{
	}

	[Address(RVA = "0x6BDFB0", Offset = "0x6BC7B0", Length = "0xC")]
	[Token(Token = "0x6004F29")]
	protected virtual void DirtyHandler()
	{
	}

	[Address(RVA = "0x6BE2D0", Offset = "0x6BCAD0", Length = "0x11")]
	[Token(Token = "0x6004F2A")]
	protected void OnDestroy()
	{
	}

	[Address(RVA = "0x6BE190", Offset = "0x6BC990", Length = "0x50")]
	[Token(Token = "0x6004F2B")]
	protected virtual bool InvokeItemUpdate()
	{
		return default(bool);
	}

	[Address(RVA = "0x6BE210", Offset = "0x6BCA10", Length = "0xB8")]
	[Token(Token = "0x6004F2C")]
	protected override void OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject)
	{
	}

	[Address(RVA = "0x6BE130", Offset = "0x6BC930", Length = "0x51")]
	[Token(Token = "0x6004F2D")]
	public virtual bool InvokeEvent(int eventIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F2E")]
	[Address(RVA = "0x6BE600", Offset = "0x6BCE00", Length = "0x63")]
	public void SetDefaultSelectObj(int index, GameObject defaultSelectObj)
	{
	}

	[Token(Token = "0x6004F2F")]
	[Address(RVA = "0x6BDE00", Offset = "0x6BC600", Length = "0x70")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Token(Token = "0x6004F30")]
	[Address(RVA = "0x6BE430", Offset = "0x6BCC30", Length = "0x1C7")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6004F31")]
	[Address(RVA = "0x6BE3B0", Offset = "0x6BCBB0", Length = "0x7F")]
	protected override void OnSelectEmpty(GameObject lastSelObj)
	{
	}

	[Token(Token = "0x6004F32")]
	[Address(RVA = "0x6BE900", Offset = "0x6BD100", Length = "0x6C")]
	protected AbstractTabContainer()
	{
	}
}
