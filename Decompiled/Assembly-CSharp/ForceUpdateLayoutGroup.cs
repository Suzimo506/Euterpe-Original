using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000180")]
public class ForceUpdateLayoutGroup : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000979")]
	private LayoutGroup m_LayoutGroup;

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x44F4C0", Offset = "0x44DCC0", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x44F510", Offset = "0x44DD10", Length = "0x97")]
	private void Update()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000AFE")]
	public ForceUpdateLayoutGroup()
	{
	}
}
