using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels.PnlHotfix;

[Token(Token = "0x20001CC")]
public class PnlDownloadSizeCheck : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B6B")]
	public Popup m_Popup;

	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x20")]
	public Text txtDownloadSizeInfo;

	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x28")]
	public Text txtDownloadSizeTips;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B6E")]
	public Action<bool> downloadConfirm;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B6F")]
	public Button btnDownload;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B70")]
	public Button btnCancel;

	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x48")]
	private List<string> m_localInfo;

	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x50B3F0", Offset = "0x509BF0", Length = "0x69")]
	public PnlDownloadSizeCheck()
	{
	}
}
