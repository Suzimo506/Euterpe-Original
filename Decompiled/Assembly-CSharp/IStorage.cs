using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000DA")]
public interface IStorage
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000652")]
	void ImageLoad(string url, Action<Texture2D> callback);

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x0", Length = "0x0")]
	void ClearCache();
}
