using System.Collections;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E3")]
public class SelectableFancyPanel : SerializedMonoBehaviour, IPreWarm
{
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002F39")]
	private BtnApply m_ApplyButton;

	[SerializeField]
	[Token(Token = "0x4002F3A")]
	[FieldOffset(Offset = "0x60")]
	private ApplyShow m_ApplyShow;

	[SerializeField]
	[Token(Token = "0x4002F3B")]
	[FieldOffset(Offset = "0x68")]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_FancyScrollView;

	[Token(Token = "0x4002F3C")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private MenuType m_MenuType;

	[Token(Token = "0x4002F3D")]
	[SerializeField]
	[FieldOffset(Offset = "0x78")]
	private AudioClip m_ClickSfx;

	[Token(Token = "0x170008A0")]
	public MenuType menuType
	{
		[Token(Token = "0x600509B")]
		[Address(RVA = "0x4D0B40", Offset = "0x4CF340", Length = "0x4")]
		get
		{
			return default(MenuType);
		}
	}

	[Token(Token = "0x170008A1")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv
	{
		[Token(Token = "0x600509C")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A2")]
	public BtnApply applyButton
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x600509D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600509E")]
	[Address(RVA = "0x4D0A30", Offset = "0x4CF230", Length = "0x102")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x600509F")]
	[Address(RVA = "0x91E690", Offset = "0x91CE90", Length = "0xCA")]
	public T GetCellComponent<T>(int index = -1) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60050A0")]
	[Address(RVA = "0x4D0800", Offset = "0x4CF000", Length = "0x8F")]
	private void OnApplyClicked()
	{
	}

	[Address(RVA = "0x4D0930", Offset = "0x4CF130", Length = "0x6F")]
	[Token(Token = "0x60050A1")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x4D0890", Offset = "0x4CF090", Length = "0x95")]
	[Token(Token = "0x60050A2")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4D09C0", Offset = "0x4CF1C0", Length = "0x65")]
	[Token(Token = "0x60050A3")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x5D880", Offset = "0x5CC80")]
	private IEnumerator PlayScrollToAndUnLockAnims()
	{
		return null;
	}

	[Address(RVA = "0x4D09A0", Offset = "0x4CF1A0", Length = "0x1E")]
	[Token(Token = "0x60050A4")]
	public void PlayApply(bool play)
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x60050A5")]
	public SelectableFancyPanel()
	{
	}
}
