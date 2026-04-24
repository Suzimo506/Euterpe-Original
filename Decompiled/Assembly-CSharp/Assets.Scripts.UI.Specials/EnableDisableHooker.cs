using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000875")]
public class EnableDisableHooker : MonoBehaviour
{
	[Token(Token = "0x1400008A")]
	public event UnityAction<GameObject, bool> onEnable
	{
		[CompilerGenerated]
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x60F610", Offset = "0x60DE10", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x60F750", Offset = "0x60DF50", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400008B")]
	public event UnityAction<GameObject, bool> onDisable
	{
		[CompilerGenerated]
		[Address(RVA = "0x60F570", Offset = "0x60DD70", Length = "0x9E")]
		[Token(Token = "0x6004D34")]
		add
		{
		}
		[Token(Token = "0x6004D35")]
		[CompilerGenerated]
		[Address(RVA = "0x60F6B0", Offset = "0x60DEB0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x6004D36")]
	[Address(RVA = "0x60F510", Offset = "0x60DD10", Length = "0x5B")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004D37")]
	[Address(RVA = "0x60F4B0", Offset = "0x60DCB0", Length = "0x5B")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004D38")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public EnableDisableHooker()
	{
	}
}
