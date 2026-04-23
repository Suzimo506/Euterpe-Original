using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore;

[Token(Token = "0x20006F7")]
public class DataUpgrader : Singleton<DataUpgrader>
{
	[Token(Token = "0x60041AD")]
	[Address(RVA = "0x49C5D0", Offset = "0x49ADD0", Length = "0x38")]
	public DataUpgrader()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
