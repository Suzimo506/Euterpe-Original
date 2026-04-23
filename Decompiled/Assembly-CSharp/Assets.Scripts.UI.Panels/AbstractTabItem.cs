using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008CA")]
public abstract class AbstractTabItem : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002DD1")]
	public Color enableBgColor;

	[Token(Token = "0x4002DD2")]
	[FieldOffset(Offset = "0x28")]
	public Color disableBgColor;

	[Token(Token = "0x4002DD3")]
	[FieldOffset(Offset = "0x38")]
	public Color enableTextBgColor;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002DD4")]
	public Color disableTextBgColor;

	[SerializeField]
	[Token(Token = "0x4002DD5")]
	[FieldOffset(Offset = "0x58")]
	protected Button m_TabButton;

	[SerializeField]
	[Token(Token = "0x4002DD6")]
	[FieldOffset(Offset = "0x60")]
	protected Text m_Text;

	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4002DD7")]
	protected Image m_Image;

	[Token(Token = "0x4002DD8")]
	[FieldOffset(Offset = "0x70")]
	protected AbstractTabContainer m_Parent;

	[Token(Token = "0x4002DD9")]
	[FieldOffset(Offset = "0x78")]
	protected int m_Index;

	[Token(Token = "0x4002DDA")]
	[FieldOffset(Offset = "0x80")]
	protected ulong m_DirtyIndex;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002DDB")]
	private List<GameObject> m_SelectGameObjects;

	[Token(Token = "0x17000893")]
	public int tabIndex
	{
		[Address(RVA = "0x486430", Offset = "0x484C30", Length = "0x4")]
		[Token(Token = "0x6004F33")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000894")]
	protected List<GameObject> selectGameObjects
	{
		[Address(RVA = "0x5C1450", Offset = "0x5BFC50", Length = "0x8")]
		[Token(Token = "0x6004F34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000895")]
	public virtual GameObject defaultSelectedObject
	{
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6BEA10", Offset = "0x6BD210", Length = "0xCF")]
	[Token(Token = "0x6004F36")]
	public virtual void InitItem(AbstractTabContainer parent, List<GameObject> selectedObjects, int index)
	{
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6004F37")]
	public virtual bool OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject)
	{
		return default(bool);
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004F38")]
	public abstract void InitBaseUiAndData(int curIndex);

	[Token(Token = "0x6004F39")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x6004F3A")]
	[Address(RVA = "0x6BEC20", Offset = "0x6BD420", Length = "0x2D")]
	protected virtual void OnTabBtnClicked()
	{
	}

	[Address(RVA = "0x6BE9B0", Offset = "0x6BD1B0", Length = "0x17")]
	[Token(Token = "0x6004F3B")]
	public virtual void Enable(int curTabIndex)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004F3C")]
	public virtual void Disable(int curTabIndex)
	{
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6004F3D")]
	public virtual bool ItemUpdate()
	{
		return default(bool);
	}

	[Address(RVA = "0x6BEC50", Offset = "0x6BD450", Length = "0x36")]
	[Token(Token = "0x6004F3E")]
	public virtual bool SetDirty(int curTabIndex, ulong dirtyIndex = 0uL)
	{
		return default(bool);
	}

	[Address(RVA = "0x6BE9A0", Offset = "0x6BD1A0", Length = "0xC")]
	[Token(Token = "0x6004F3F")]
	protected virtual void DirtyHandler()
	{
	}

	[Token(Token = "0x6004F40")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract bool InvokeEvent(int eventType);

	[Token(Token = "0x6004F41")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public virtual bool GetSelectGameObject(List<GameObject> buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F42")]
	[Address(RVA = "0x6BE9D0", Offset = "0x6BD1D0", Length = "0x35")]
	public virtual string GetAreaTitle(int treeIndex)
	{
		return null;
	}

	[Token(Token = "0x6004F43")]
	[Address(RVA = "0x6BEAE0", Offset = "0x6BD2E0", Length = "0x133")]
	public virtual void OnItemChanged(int prevIndex, int curIndex, bool init = false)
	{
	}

	[Token(Token = "0x6004F44")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public virtual bool OnSelect(GameObject currentObj)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F45")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public virtual bool OnSelectEmpty(GameObject lastSelObj)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F46")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected AbstractTabItem()
	{
	}
}
