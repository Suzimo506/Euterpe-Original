using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000027")]
public struct ReportCardColorScheme
{
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x567F0", Offset = "0x55BF0")]
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x0")]
	public int listIndex;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000AC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x569F0", Offset = "0x55DF0")]
	public Color colorA;

	[Token(Token = "0x40000AD")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x56CA0", Offset = "0x560A0")]
	[FieldOffset(Offset = "0x14")]
	public Color colorB;

	[Token(Token = "0x40000AE")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x56DE0", Offset = "0x561E0")]
	[FieldOffset(Offset = "0x24")]
	public Color colorC;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x56F70", Offset = "0x56370")]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000AF")]
	public Color colorD;

	[Token(Token = "0x40000B0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x570D0", Offset = "0x564D0")]
	[FieldOffset(Offset = "0x44")]
	public Color ColorE;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x57320", Offset = "0x56720")]
	public Color ColorF;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x57530", Offset = "0x56930")]
	public Color ColorG;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x57E20", Offset = "0x57220")]
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x78")]
	public string imgFcName;

	[Address(RVA = "0x56C2F0", Offset = "0x56AAF0", Length = "0x195")]
	[Token(Token = "0x6000101")]
	public bool IsEmpty()
	{
		return default(bool);
	}
}
