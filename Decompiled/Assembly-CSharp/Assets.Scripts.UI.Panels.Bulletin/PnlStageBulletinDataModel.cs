using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Token(Token = "0x2000950")]
public class PnlStageBulletinDataModel
{
	[Token(Token = "0x40032C1")]
	[FieldOffset(Offset = "0x10")]
	public string uid;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40032C2")]
	public string title;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40032C3")]
	public string content;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40032C4")]
	public string imageUrl;

	[Token(Token = "0x40032C5")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x40032C6")]
	[FieldOffset(Offset = "0x38")]
	public bool force;

	[Token(Token = "0x40032C7")]
	[FieldOffset(Offset = "0x39")]
	public bool isNewData;

	[Token(Token = "0x170008E1")]
	public bool isNew
	{
		[Address(RVA = "0x6CFE10", Offset = "0x6CE610", Length = "0x92")]
		[Token(Token = "0x600549F")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x6CFEB0", Offset = "0x6CE6B0", Length = "0x114")]
		[Token(Token = "0x60054A0")]
		set
		{
		}
	}

	[Token(Token = "0x60054A1")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public PnlStageBulletinDataModel()
	{
	}
}
