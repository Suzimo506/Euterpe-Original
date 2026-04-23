using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000207")]
public class ThemedElement : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000AA6")]
	public class ElementInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003806")]
		[SerializeField]
		private string _themeClass;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003807")]
		[SerializeField]
		private Component _component;

		[Token(Token = "0x17000A31")]
		public string themeClass
		{
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			[Token(Token = "0x6005B82")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A32")]
		public Component component
		{
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			[Token(Token = "0x6005B83")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005B84")]
		public ElementInfo()
		{
		}
	}

	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ElementInfo[] _elements;

	[Token(Token = "0x6001347")]
	[Address(RVA = "0xDCB410", Offset = "0xDC9C10", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x6001348")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ThemedElement()
	{
	}
}
