using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Common;

[Token(Token = "0x200097B")]
[Attribute(Name = "RequireComponent", RVA = "0x1C8C0", Offset = "0x1BCC0")]
public class CopyTextHandle : MonoBehaviour
{
	[Attribute(Name = "HeaderAttribute", RVA = "0x1C9D0", Offset = "0x1BDD0")]
	[Token(Token = "0x40033FC")]
	[FieldOffset(Offset = "0x18")]
	public List<Text> targets;

	[Attribute(Name = "HeaderAttribute", RVA = "0x1CA50", Offset = "0x1BE50")]
	[Token(Token = "0x40033FD")]
	[FieldOffset(Offset = "0x20")]
	public string concatenator;

	[Token(Token = "0x40033FE")]
	[FieldOffset(Offset = "0x28")]
	private Button m_Btn;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40033FF")]
	private Image m_Img;

	[Address(RVA = "0x597AE0", Offset = "0x5962E0", Length = "0x148")]
	[Token(Token = "0x6005666")]
	private void Start()
	{
	}

	[Address(RVA = "0x5979F0", Offset = "0x5961F0", Length = "0xA9")]
	[Token(Token = "0x6005667")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005668")]
	[Address(RVA = "0x597840", Offset = "0x596040", Length = "0x39")]
	private void ChangeShowState(bool isRandom)
	{
	}

	[Token(Token = "0x6005669")]
	[Address(RVA = "0x597880", Offset = "0x596080", Length = "0x160")]
	public void CopyToClipboard()
	{
	}

	[Address(RVA = "0x597AA0", Offset = "0x5962A0", Length = "0x3E")]
	[Token(Token = "0x600566A")]
	private void ShowWarningTxt()
	{
	}

	[Token(Token = "0x600566B")]
	[Address(RVA = "0x597C30", Offset = "0x596430", Length = "0x69")]
	public CopyTextHandle()
	{
	}
}
