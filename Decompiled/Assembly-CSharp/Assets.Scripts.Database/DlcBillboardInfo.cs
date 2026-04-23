using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007BC")]
public class DlcBillboardInfo : BaseDataObject
{
	[Token(Token = "0x40028BF")]
	public const int bgm_restart = 0;

	[Token(Token = "0x40028C0")]
	public const int bgm_loop = 1;

	[Token(Token = "0x40028C1")]
	public const int bgm_decorate = 2;

	[Token(Token = "0x40028C2")]
	public const int bgm_non_interactive = 3;

	[Token(Token = "0x40028C3")]
	[JsonProperty]
	[FieldOffset(Offset = "0x20")]
	private int jsonIndex;

	[JsonProperty]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40028C4")]
	public SingelCarouseInfo singelCarouseInfo;

	[JsonProperty]
	[Token(Token = "0x40028C5")]
	[FieldOffset(Offset = "0x30")]
	public SingelCarouseInfo singelCarouseInfo2;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40028C6")]
	[JsonProperty]
	private List<CarouselInfo> carouselInfos;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40028C7")]
	[JsonProperty]
	public bool isShowDemoBgm;

	[FieldOffset(Offset = "0x48")]
	[JsonProperty]
	[Token(Token = "0x40028C8")]
	private string showCharPrefab;

	[JsonProperty]
	[Token(Token = "0x40028C9")]
	[FieldOffset(Offset = "0x50")]
	public List<Expression> expressions;

	[Token(Token = "0x40028CA")]
	[FieldOffset(Offset = "0x58")]
	[JsonProperty]
	private string baseCharTalkImg;

	[JsonIgnore]
	[Token(Token = "0x170006DD")]
	public int getJsonIndex
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x600475B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006DE")]
	[JsonIgnore]
	public string getShowCharPrefab
	{
		[Token(Token = "0x6004760")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DF")]
	[JsonIgnore]
	public string getBaseCharTalkImg
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x6004761")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E0")]
	[JsonIgnore]
	public List<Expression> getShowCharExpression
	{
		[Address(RVA = "0x103CDC0", Offset = "0x103B5C0", Length = "0x17D")]
		[Token(Token = "0x6004762")]
		get
		{
			return null;
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006E1")]
	public int showCount
	{
		[Address(RVA = "0x103D190", Offset = "0x103B990", Length = "0xB2")]
		[Token(Token = "0x6004764")]
		get
		{
			return default(int);
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006E2")]
	public string localDescription
	{
		[Address(RVA = "0x103D0D0", Offset = "0x103B8D0", Length = "0xBF")]
		[Token(Token = "0x6004765")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E3")]
	[JsonIgnore]
	public string localDescription2
	{
		[Address(RVA = "0x103CF40", Offset = "0x103B740", Length = "0x18B")]
		[Token(Token = "0x6004766")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600475C")]
	[Address(RVA = "0x103CC90", Offset = "0x103B490", Length = "0x4C")]
	public override void Init(int index)
	{
	}

	[Token(Token = "0x600475D")]
	[Address(RVA = "0x103CA90", Offset = "0x103B290", Length = "0x1F3")]
	public void GetCarouselInfos(ref List<CarouselInfo> listCarouselInfos)
	{
	}

	[Address(RVA = "0x103C8F0", Offset = "0x103B0F0", Length = "0xF2")]
	[Token(Token = "0x600475E")]
	private string CorrectImgName(string imgName)
	{
		return null;
	}

	[Address(RVA = "0x103C9F0", Offset = "0x103B1F0", Length = "0x97")]
	[Token(Token = "0x600475F")]
	private void CorrectImgNames(List<string> imgs)
	{
	}

	[Token(Token = "0x6004763")]
	[Address(RVA = "0x103CCE0", Offset = "0x103B4E0", Length = "0xD1")]
	private void SetExpression(List<Expression> expr, List<List<string>> localExpr)
	{
	}

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x6004767")]
	public DlcBillboardInfo()
	{
	}
}
