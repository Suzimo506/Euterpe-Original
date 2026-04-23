using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.GameCore.Controller;

[Token(Token = "0x2000774")]
public class ControllerConfig : SingletonScriptableObject<SerializedScriptableObject>
{
	[Token(Token = "0x60045DF")]
	[Address(RVA = "0x49C590", Offset = "0x49AD90", Length = "0x38")]
	public ControllerConfig()
	{
		((SingletonScriptableObject<>)(object)this)._002Ector();
	}
}
