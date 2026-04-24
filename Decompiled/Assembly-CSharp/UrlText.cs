using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20000A5")]
public class UrlText : Text, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x20009E1")]
	public delegate void VoidOnHrefClick(string hefName);

	[Token(Token = "0x20009E2")]
	private class HrefInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400355E")]
		public int startIndex;

		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x14")]
		public int endIndex;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003560")]
		public string name;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003561")]
		public readonly List<Rect> boxes;

		[Token(Token = "0x60057DE")]
		[Address(RVA = "0x4D6330", Offset = "0x4D4B30", Length = "0x69")]
		public HrefInfo()
		{
		}
	}

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0xF8")]
	public float lineW;

	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0xFC")]
	public float num;

	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x100")]
	private string m_OutputText;

	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x108")]
	private readonly UIVertex[] m_TempVerts;

	[Token(Token = "0x4000468")]
	public static readonly Regex s_HrefRegex;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000469")]
	private readonly List<HrefInfo> m_HrefInfos;

	[Token(Token = "0x400046A")]
	protected static readonly StringBuilder s_TextBuilder;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400046B")]
	public VoidOnHrefClick onHrefClick;

	[Address(RVA = "0x4EB0F0", Offset = "0x4E98F0", Length = "0x51")]
	[Token(Token = "0x6000508")]
	public override void SetVerticesDirty()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x4EA3A0", Offset = "0x4E8BA0", Length = "0xD4E")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x4E9A40", Offset = "0x4E8240", Length = "0x589")]
	protected virtual string GetOutputText(string outputText)
	{
		return null;
	}

	[Address(RVA = "0x4E9FD0", Offset = "0x4E87D0", Length = "0xF9")]
	[Token(Token = "0x600050B")]
	private void HrefInfosIndexAdjust(int imgIndex)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x4EA0D0", Offset = "0x4E88D0", Length = "0x2C0")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x4EB1F0", Offset = "0x4E99F0", Length = "0xB7")]
	public UrlText()
	{
	}
}
