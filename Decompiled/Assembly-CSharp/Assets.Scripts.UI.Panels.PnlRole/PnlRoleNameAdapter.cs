using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000963")]
public class PnlRoleNameAdapter : SerializedMonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000DD7")]
	private struct LanguageFontSize
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40040EE")]
		public string languageName;

		[Token(Token = "0x40040EF")]
		[FieldOffset(Offset = "0x8")]
		public int fontSize;
	}

	[SerializeField]
	[Token(Token = "0x400335F")]
	[FieldOffset(Offset = "0x58")]
	private int m_DefaultFontSize;

	[Token(Token = "0x4003360")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, Dictionary<string, List<LanguageFontSize>>> m_RoleResoultion2LanguageFontSizesMapping;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4003361")]
	[SerializeField]
	private Text m_Text;

	[Token(Token = "0x6005596")]
	[Address(RVA = "0x63ACF0", Offset = "0x6394F0", Length = "0x1B7")]
	public void AdjustRoleNameSizeByRole(int roleIndex)
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6005597")]
	public PnlRoleNameAdapter()
	{
	}
}
