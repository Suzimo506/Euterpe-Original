using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20000E1")]
[Attribute(Name = "RequireComponent", RVA = "0x99D0", Offset = "0x8DD0")]
public class DpiItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400059A")]
	[SerializeField]
	private Image m_ImgBg;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400059B")]
	private Image m_ImgCheckMark;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text m_Text;

	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x48")]
	private Tweener m_SelectTweener;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400059F")]
	[SerializeField]
	private Color m_NormalColor;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005A0")]
	[SerializeField]
	private Color m_SelectColor;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB20", Offset = "0xAF20")]
	[Token(Token = "0x40005A1")]
	private Color m_TextUnSelectColor;

	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x80")]
	private bool m_LastToggleIsOn;

	[Token(Token = "0x1700008D")]
	public Vector2Int resolution
	{
		[CompilerGenerated]
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000673")]
		[CompilerGenerated]
		[Address(RVA = "0x4434C0", Offset = "0x441CC0", Length = "0x5")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008E")]
	public int siblingIndex
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x6000674")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008F")]
	public Toggle toggle
	{
		[CompilerGenerated]
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
		[Token(Token = "0x6000677")]
		private set
		{
		}
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x442CA0", Offset = "0x4414A0", Length = "0xF9")]
	public void Init()
	{
	}

	[Address(RVA = "0x443270", Offset = "0x441A70", Length = "0x148")]
	[Token(Token = "0x6000679")]
	public void SetData(Vector2Int resolution, int index)
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x4433C0", Offset = "0x441BC0", Length = "0xB2")]
	public void SetPreAndNextNavgationItem(Toggle prev, Toggle next)
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x443480", Offset = "0x441C80", Length = "0x20")]
	public void SetSelect()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x442DD0", Offset = "0x4415D0", Length = "0x228")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x443140", Offset = "0x441940", Length = "0xF0")]
	public void RefreshCheckMark()
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x443240", Offset = "0x441A40", Length = "0x2F")]
	public void SetCheckMarkFalse()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x443000", Offset = "0x441800", Length = "0x134")]
	private void OnSelect(bool isSelect)
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x442DA0", Offset = "0x4415A0", Length = "0x20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DpiItem()
	{
	}
}
