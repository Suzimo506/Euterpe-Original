using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Events;
using Assets.Scripts.PeroTools.Nice.Variables;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200095B")]
public class PnlRoleSubControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003302")]
	public VariableBehaviour m_VarIndex;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003303")]
	public OnFancyScrollViewCellUpdate m_CellUpdate;

	[SerializeField]
	[Token(Token = "0x4003304")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_CreateTf;

	[SerializeField]
	[Token(Token = "0x4003305")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_SwitchAnimator;

	[Token(Token = "0x4003306")]
	[FieldOffset(Offset = "0x38")]
	private int m_CellIndex;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4003307")]
	private int m_RoleIndex;

	[Token(Token = "0x4003308")]
	[FieldOffset(Offset = "0x40")]
	private float m_ToggleTimeMid;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003309")]
	private Dictionary<int, CharacterApply> m_CharacterApplys;

	[Token(Token = "0x400330A")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_SkinIndexs;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400330B")]
	private int m_CurSkinIndex;

	[Token(Token = "0x400330C")]
	[FieldOffset(Offset = "0x60")]
	private List<RoleSkin> m_Skin;

	[Token(Token = "0x400330D")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Init;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400330E")]
	private Coroutine m_Coroutine;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400330F")]
	private bool m_HasCreateSkin;

	[Token(Token = "0x170008EC")]
	public int cellIndex
	{
		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008ED")]
	public int roleIndex
	{
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008EE")]
	public int skinIndex
	{
		[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
		[Token(Token = "0x60054FE")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008EF")]
	public int nextSkinIndex
	{
		[Token(Token = "0x6005501")]
		[Address(RVA = "0x643BF0", Offset = "0x6423F0", Length = "0x6B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008F0")]
	public bool canToggleSkin
	{
		[Address(RVA = "0x643AB0", Offset = "0x6422B0", Length = "0x49")]
		[Token(Token = "0x6005502")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008F1")]
	public CharacterApply characterApply
	{
		[Address(RVA = "0x643B00", Offset = "0x642300", Length = "0xEB")]
		[Token(Token = "0x6005512")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60054FF")]
	[Address(RVA = "0x642D80", Offset = "0x641580", Length = "0x60")]
	public bool GetSkin(int index, out RoleSkin skin)
	{
		skin = null;
		return default(bool);
	}

	[Token(Token = "0x6005500")]
	[Address(RVA = "0x642DE0", Offset = "0x6415E0", Length = "0x55")]
	public bool GetSkin(out RoleSkin skin)
	{
		skin = null;
		return default(bool);
	}

	[Address(RVA = "0x6439F0", Offset = "0x6421F0", Length = "0x7")]
	[Token(Token = "0x6005503")]
	private void Start()
	{
	}

	[Address(RVA = "0x643390", Offset = "0x641B90", Length = "0x80")]
	[Token(Token = "0x6005504")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x642840", Offset = "0x641040", Length = "0x172")]
	[Token(Token = "0x6005505")]
	private void Clean()
	{
	}

	[Token(Token = "0x6005506")]
	[Address(RVA = "0x643130", Offset = "0x641930", Length = "0x25B")]
	private void OnDataIndexChanged(int i)
	{
	}

	[Address(RVA = "0x643000", Offset = "0x641800", Length = "0x12B")]
	[Token(Token = "0x6005507")]
	private void Init()
	{
	}

	[Token(Token = "0x6005508")]
	[Address(RVA = "0x643390", Offset = "0x641B90", Length = "0x80")]
	private void Release()
	{
	}

	[Token(Token = "0x6005509")]
	[Address(RVA = "0x642E40", Offset = "0x641640", Length = "0x1BE")]
	private void InitCharacterMainShow()
	{
	}

	[Token(Token = "0x600550A")]
	[Address(RVA = "0x6429C0", Offset = "0x6411C0", Length = "0x321")]
	private CharacterApply CreateObject(int skinIndex, string prefabName)
	{
		return null;
	}

	[Token(Token = "0x600550B")]
	[Address(RVA = "0x642CF0", Offset = "0x6414F0", Length = "0x8C")]
	private void DisableSkeletonRenderSeparator(GameObject createRoleObj)
	{
	}

	[Token(Token = "0x600550C")]
	[Address(RVA = "0x643980", Offset = "0x642180", Length = "0x60")]
	private void SetUISortingOrder(MeshRenderer[] rd)
	{
	}

	[Address(RVA = "0x6434A0", Offset = "0x641CA0", Length = "0x53")]
	[Token(Token = "0x600550D")]
	private void PlaySwitchAnimtor()
	{
	}

	[Token(Token = "0x600550E")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7910", Offset = "0x6D10")]
	[Address(RVA = "0x643A00", Offset = "0x642200", Length = "0xA4")]
	private IEnumerator SwitchSkin(int curIndex, int switchIndex, Action<PnlRoleSubControl> switchedCallback)
	{
		return null;
	}

	[Token(Token = "0x600550F")]
	[Address(RVA = "0x643630", Offset = "0x641E30", Length = "0x349")]
	public void SetSkin(int skinIdx = -1, bool playAnimator = true, Action<PnlRoleSubControl> switchedCallback = null, bool test = false)
	{
	}

	[Token(Token = "0x6005510")]
	[Address(RVA = "0x643420", Offset = "0x641C20", Length = "0x7C")]
	public void PlayApplyAnim()
	{
	}

	[Address(RVA = "0x6435F0", Offset = "0x641DF0", Length = "0x35")]
	[Token(Token = "0x6005511")]
	public void SetCreateLocation(Vector3 location)
	{
	}

	[Token(Token = "0x6005513")]
	[Address(RVA = "0x643500", Offset = "0x641D00", Length = "0xED")]
	public void SaveToAccount()
	{
	}

	[Token(Token = "0x6005514")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlRoleSubControl()
	{
	}
}
