using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000AB")]
public class PnlDaveFishInfo : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000487")]
	public Text txtFishName;

	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x20")]
	public Text txtFishExp;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000489")]
	public Image imgFishQualityIcon;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x30")]
	public Image imgFishIcon;

	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject imgNewIcon;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400048C")]
	private bool m_IsSetInfo;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400048D")]
	private DaveFishData m_DaveFishData;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x50")]
	private DaveFishDataModel m_FishDataModel;

	[Token(Token = "0x17000079")]
	public bool isSetInfo
	{
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x4FE200", Offset = "0x4FCA00", Length = "0x546")]
	[Token(Token = "0x600051D")]
	public void Init(DaveFishData daveFishData)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x4FE750", Offset = "0x4FCF50", Length = "0x13B")]
	public void SetDaveFishShowAndSave()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x4E5720", Offset = "0x4E3F20", Length = "0x93")]
	private Vector2 GetFishIconPos(Vector2 fishIconSize)
	{
		return default(Vector2);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000520")]
	public PnlDaveFishInfo()
	{
	}
}
