using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B5")]
public class Task : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002D7E")]
	public Text text;

	[Address(RVA = "0x5B8350", Offset = "0x5B6B50", Length = "0x626")]
	[Token(Token = "0x6004EC1")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x5B8300", Offset = "0x5B6B00", Length = "0x49")]
	[Token(Token = "0x6004EC2")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004EC3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public Task()
	{
	}
}
