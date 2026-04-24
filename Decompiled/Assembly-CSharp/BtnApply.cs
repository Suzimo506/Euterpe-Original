using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.UI;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D8")]
public class BtnApply : SerializedMonoBehaviour
{
	[Token(Token = "0x20009FA")]
	public enum ButtonState
	{
		[Token(Token = "0x4003599")]
		Apply,
		[Token(Token = "0x400359A")]
		InUse,
		[Token(Token = "0x400359B")]
		CharacterFreeLocked,
		[Token(Token = "0x400359C")]
		CharacterPurchasedLocked,
		[Token(Token = "0x400359D")]
		Dress,
		[Token(Token = "0x400359E")]
		InDress,
		[Token(Token = "0x400359F")]
		SkinLocked
	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000560")]
	public GameObject imgInUse;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000561")]
	public GameObject imgApply;

	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6960", Offset = "0x5D60")]
	public GameObject lockedObj;

	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x70")]
	public GameObject imgLocked;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000564")]
	public GameObject parUnlockObj;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000565")]
	public Image m_FreeLockImgIcon;

	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x88")]
	public Image m_PurchaseLockImgIcon;

	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x90")]
	public Text m_lockTxt;

	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x98")]
	public GameObject freeLockObj;

	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject PurchaseLockObj;

	[Token(Token = "0x400056A")]
	[SerializeField]
	[FieldOffset(Offset = "0xA8")]
	private Button m_LockBtnApply;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400056B")]
	private int m_MaxItemCount;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400056C")]
	private string m_ChipImage;

	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_Free;

	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0xC4")]
	private int m_Order;

	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Button m_BtnApply;

	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Animator m_Animator;

	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0xD8")]
	private SelectableFancyPanel m_Parent;

	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0xEC")]
	private ButtonState m_State;

	[SerializeField]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000576")]
	private Dictionary<ButtonState, GameObject> m_ButtonStateObjMapping;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000577")]
	[SerializeField]
	private Dictionary<ButtonState, GameObject> m_ButtonStateImgLockedMapping;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000578")]
	private GameObject m_ActiveObj;

	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x108")]
	private GameObject m_ActiveImgLocked;

	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x110")]
	private Func<ButtonState> m_SetUseStateCallback;

	[Token(Token = "0x17000086")]
	public Button btnApply
	{
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000087")]
	[Obsolete]
	public Button lockBtnApply
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x460250", Offset = "0x45EA50", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000088")]
	public int lastCellIndex
	{
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x460230", Offset = "0x45EA30", Length = "0x7")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x460290", Offset = "0x45EA90", Length = "0x7")]
		[Token(Token = "0x6000631")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000089")]
	public int lastItemIndex
	{
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x460240", Offset = "0x45EA40", Length = "0x7")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x4602A0", Offset = "0x45EAA0", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public MenuType menuType
	{
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x460260", Offset = "0x45EA60", Length = "0x1D")]
		get
		{
			return default(MenuType);
		}
	}

	[Token(Token = "0x1700008B")]
	public bool unlock
	{
		[CompilerGenerated]
		[Address(RVA = "0x460280", Offset = "0x45EA80", Length = "0x8")]
		[Token(Token = "0x6000636")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x4602B0", Offset = "0x45EAB0", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x45F4E0", Offset = "0x45DCE0", Length = "0x88")]
	public void Init(SelectableFancyPanel parent)
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x4601A0", Offset = "0x45E9A0", Length = "0xF")]
	public void SetUseCallback(Func<ButtonState> callback)
	{
	}

	[Address(RVA = "0x45F3C0", Offset = "0x45DBC0", Length = "0x11A")]
	[Token(Token = "0x6000639")]
	private IData GetItem(int itemIndex)
	{
		return null;
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x4601B0", Offset = "0x45E9B0", Length = "0x66")]
	private void SetUseState()
	{
	}

	[Address(RVA = "0x45EF20", Offset = "0x45D720", Length = "0xD8")]
	[Token(Token = "0x600063B")]
	private void ChangeActiveObj(ref GameObject curObj, ref Dictionary<ButtonState, GameObject> mapping)
	{
	}

	[Address(RVA = "0x45FFC0", Offset = "0x45E7C0", Length = "0x1D3")]
	[Token(Token = "0x600063C")]
	private void SetUnlockAnimator(IData item)
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x45FA30", Offset = "0x45E230", Length = "0x226")]
	private void SetLockImg(IData item)
	{
	}

	[Address(RVA = "0x45FC60", Offset = "0x45E460", Length = "0x23D")]
	[Token(Token = "0x600063E")]
	private void SetLockedImgForFree(int itemCount)
	{
	}

	[Address(RVA = "0x45FEA0", Offset = "0x45E6A0", Length = "0x113")]
	[Token(Token = "0x600063F")]
	private void SetLockedImgForPurchase()
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x45F570", Offset = "0x45DD70", Length = "0x274")]
	public void OnFsvIndexChanged(int index)
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x45F990", Offset = "0x45E190", Length = "0x99")]
	public void RefreshItemLockImgAndAnima()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x45F1D0", Offset = "0x45D9D0", Length = "0x9D")]
	public void ForceRefreshItemLockImgAndAnima(int itemIndex)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x45F000", Offset = "0x45D800", Length = "0x1C7")]
	public void ForceChangeCurItemData(int index)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x45F7F0", Offset = "0x45DFF0", Length = "0x19F")]
	public void RefreshButtonByStateAndIndex(ButtonState state, int index)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x45F270", Offset = "0x45DA70", Length = "0x14D")]
	private void GetItemInfoByIndex(int index)
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6000646")]
	public BtnApply()
	{
	}
}
