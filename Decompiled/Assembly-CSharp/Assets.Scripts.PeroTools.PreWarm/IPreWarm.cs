using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.PreWarm;

[Token(Token = "0x20005BA")]
public interface IPreWarm
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003974")]
	void PreWarm(int slice);
}
