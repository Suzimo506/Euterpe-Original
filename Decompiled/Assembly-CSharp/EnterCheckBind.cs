using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000E4")]
public class EnterCheckBind : MonoBehaviour
{
	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x18")]
	public Button[] btns;

	[Token(Token = "0x40005B3")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private InputKeyBinding m_EnterKeyBinding;

	[Address(RVA = "0x448BB0", Offset = "0x4473B0", Length = "0x140")]
	[Token(Token = "0x60006A1")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x4489A0", Offset = "0x4471A0", Length = "0x180")]
	public void LoginDetection()
	{
	}

	[Address(RVA = "0x448B30", Offset = "0x447330", Length = "0x7A")]
	[Token(Token = "0x60006A3")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60006A4")]
	public EnterCheckBind()
	{
	}
}
