using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005E0")]
public class AudioClip : IValue
{
	[Token(Token = "0x40021A7")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private UnityEngine.AudioClip m_Result;

	[Token(Token = "0x17000561")]
	public object result
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60039FF")]
		get
		{
			return null;
		}
		[Address(RVA = "0x9736C0", Offset = "0x971EC0", Length = "0x66")]
		[Token(Token = "0x6003A00")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003A01")]
	public AudioClip()
	{
	}
}
