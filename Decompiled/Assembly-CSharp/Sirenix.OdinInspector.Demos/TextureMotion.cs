using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Sirenix.OdinInspector.Demos;

[Token(Token = "0x200045E")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x37690", Offset = "0x36A90")]
public class TextureMotion : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000B26")]
	public class MyTabObject
	{
		[Token(Token = "0x2000ECA")]
		public enum SomeEnum
		{
			[Token(Token = "0x4004168")]
			Normal,
			[Token(Token = "0x4004169")]
			Multiply,
			[Token(Token = "0x400416A")]
			Overlay,
			[Token(Token = "0x400416B")]
			Lighten
		}

		[Token(Token = "0x2000ECB")]
		public enum SomeEnum1
		{
			[Token(Token = "0x400416D")]
			Move,
			[Token(Token = "0x400416E")]
			Rotation
		}

		[Token(Token = "0x4003962")]
		[FieldOffset(Offset = "0x10")]
		public bool on;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003963")]
		public Sprite texture;

		[Token(Token = "0x4003964")]
		[FieldOffset(Offset = "0x20")]
		public SomeEnum superimposition;

		[Token(Token = "0x4003965")]
		[FieldOffset(Offset = "0x24")]
		public bool showMaskGraphic;

		[Space]
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x28")]
		public SomeEnum1 MontionType;

		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 pivot;

		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x34")]
		public float roataeSpeed;

		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003969")]
		public Vector2 offsetSpeed;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005D32")]
		public MyTabObject()
		{
		}
	}

	[FieldOffset(Offset = "0x18")]
	[Space]
	[Token(Token = "0x40017C4")]
	public Sprite tartget;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017C5")]
	public MyTabObject TabA;

	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x28")]
	public MyTabObject TabB;

	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x30")]
	public MyTabObject TabC;

	[Token(Token = "0x6003296")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public TextureMotion()
	{
	}
}
