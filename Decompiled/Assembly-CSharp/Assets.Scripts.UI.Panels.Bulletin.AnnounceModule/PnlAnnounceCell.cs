using System.Runtime.CompilerServices;
using Assets.Scripts.UI.Redot;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000953")]
public class PnlAnnounceCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40032D5")]
	public Button btn;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40032D6")]
	private PnlStageBulletinDataModel m_Data;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40032D7")]
	private ImageLoader m_ImgLoader;

	[SerializeField]
	[Token(Token = "0x40032D8")]
	[FieldOffset(Offset = "0x38")]
	private Image m_Img;

	[SerializeField]
	[Token(Token = "0x40032D9")]
	[FieldOffset(Offset = "0x40")]
	private Outline m_SelectedOutline;

	[SerializeField]
	[Token(Token = "0x40032DA")]
	[FieldOffset(Offset = "0x48")]
	private AnnounceRedot m_UnreadDot;

	[Token(Token = "0x170008E2")]
	public int CellIndex
	{
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		[Token(Token = "0x60054A9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		[Token(Token = "0x60054AA")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008E3")]
	public PnlStageBulletinDataModel AnnounceData
	{
		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6C7F40", Offset = "0x6C6740", Length = "0x1A6")]
		[Token(Token = "0x60054AC")]
		set
		{
		}
	}

	[Token(Token = "0x60054AD")]
	[Address(RVA = "0x6C7A30", Offset = "0x6C6230", Length = "0x78")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054AE")]
	[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
	public void SetIndex(int index)
	{
	}

	[Token(Token = "0x60054AF")]
	[Address(RVA = "0x6C7C50", Offset = "0x6C6450", Length = "0x36")]
	public void SetFocusOn(bool isFocus)
	{
	}

	[Token(Token = "0x60054B0")]
	[Address(RVA = "0x6C7D50", Offset = "0x6C6550", Length = "0xCE")]
	public void SetSelectOn(bool isSelect)
	{
	}

	[Token(Token = "0x60054B1")]
	[Address(RVA = "0x6C7C90", Offset = "0x6C6490", Length = "0xB5")]
	private void SetReadState(bool isRead)
	{
	}

	[Address(RVA = "0x6C7AB0", Offset = "0x6C62B0", Length = "0x19E")]
	[Token(Token = "0x60054B2")]
	private void SetContent()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60054B3")]
	public PnlAnnounceCell()
	{
	}
}
