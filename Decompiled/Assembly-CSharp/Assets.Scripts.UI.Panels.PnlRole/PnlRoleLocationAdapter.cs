using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000961")]
public class PnlRoleLocationAdapter : SerializedMonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003357")]
	[FieldOffset(Offset = "0x58")]
	private PnlRole m_PnlRole;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4003358")]
	[SerializeField]
	private SelectableFancyPanel m_FancyPanel;

	[Token(Token = "0x4003359")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Dictionary<int, Vector3> m_IndexToLocationMapping;

	[Address(RVA = "0x639C10", Offset = "0x638410", Length = "0x177")]
	[Token(Token = "0x6005586")]
	private void Awake()
	{
	}

	[Address(RVA = "0x639D90", Offset = "0x638590", Length = "0xC6")]
	[Token(Token = "0x6005587")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x639E60", Offset = "0x638660", Length = "0xB6")]
	[Token(Token = "0x6005588")]
	private void onRoleChange()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6005589")]
	public PnlRoleLocationAdapter()
	{
	}
}
