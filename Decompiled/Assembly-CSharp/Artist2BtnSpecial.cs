using Assets.Scripts.PeroTools.Nice.Variables;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200016E")]
public class Artist2BtnSpecial : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000908")]
	public VariableBehaviour m_Result;

	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x20")]
	public GameObject btn1TipsImg;

	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_Parent;

	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x596F30", Offset = "0x595730", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x596F80", Offset = "0x595780", Length = "0x6D")]
	public void OnRefresh()
	{
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public Artist2BtnSpecial()
	{
	}
}
