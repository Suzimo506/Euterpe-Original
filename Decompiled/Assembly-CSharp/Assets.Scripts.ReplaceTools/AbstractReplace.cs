using System;
using Cpp2ILInjected;

namespace Assets.Scripts.ReplaceTools;

[Serializable]
[Token(Token = "0x2000599")]
public abstract class AbstractReplace
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60038D4")]
	public abstract void Replace(int index);

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60038D5")]
	protected AbstractReplace()
	{
	}
}
