using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[Attribute(Name = "AddComponentMenu", RVA = "0x6C890", Offset = "0x6BC90")]
[Token(Token = "0x20001F2")]
public class RewiredEventSystem : EventSystem
{
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x6C9F0", Offset = "0x6BDF0")]
	[SerializeField]
	private bool _alwaysUpdate;

	[Token(Token = "0x1700031D")]
	public bool alwaysUpdate
	{
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x50B3E0", Offset = "0x509BE0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x642820", Offset = "0x641020", Length = "0x4")]
		set
		{
		}
	}

	[Address(RVA = "0xF9EC90", Offset = "0xF9D490", Length = "0x19A")]
	[Token(Token = "0x6001052")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6001053")]
	[Address(RVA = "0xF9EE30", Offset = "0xF9D630", Length = "0x51")]
	public RewiredEventSystem()
	{
	}
}
