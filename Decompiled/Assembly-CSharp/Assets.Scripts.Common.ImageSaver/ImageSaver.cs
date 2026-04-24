using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common.ImageSaver;

[Token(Token = "0x200098F")]
internal abstract class ImageSaver
{
	[Token(Token = "0x4003446")]
	[FieldOffset(Offset = "0x10")]
	protected string path;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003447")]
	protected string saveImageTips;

	[Token(Token = "0x4003448")]
	private const string pattern = "[\\s/:]";

	[Address(RVA = "0x701860", Offset = "0x700060", Length = "0xC0")]
	[Token(Token = "0x60056E1")]
	public virtual void SaveImage(Texture2D texture)
	{
	}

	[Token(Token = "0x60056E2")]
	[Address(RVA = "0x701670", Offset = "0x6FFE70", Length = "0x1EF")]
	protected Texture2D DeCompress(Texture2D source)
	{
		return null;
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x299F0", Offset = "0x28DF0")]
	[Token(Token = "0x60056E3")]
	[Address(RVA = "0x701920", Offset = "0x700120", Length = "0x81")]
	protected IEnumerator<float> SaveImgaeCoroutine(Texture2D texture)
	{
		return null;
	}

	[Address(RVA = "0x7019B0", Offset = "0x7001B0", Length = "0x11D")]
	[Token(Token = "0x60056E4")]
	protected virtual void SavePngAndUpdate(string fileName)
	{
	}

	[Address(RVA = "0x701AD0", Offset = "0x7002D0", Length = "0x2E")]
	[Token(Token = "0x60056E5")]
	protected ImageSaver()
	{
	}
}
