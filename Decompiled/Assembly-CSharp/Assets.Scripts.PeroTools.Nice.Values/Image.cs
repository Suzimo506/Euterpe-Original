using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005E2")]
public class Image : IValue
{
	[SerializeField]
	[Token(Token = "0x40021A9")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.UI.Image m_Result;

	[Token(Token = "0x17000563")]
	public object result
	{
		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x97C620", Offset = "0x97AE20", Length = "0x90")]
		set
		{
		}
	}

	[Token(Token = "0x6003A07")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Image()
	{
	}
}
