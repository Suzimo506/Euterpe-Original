using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005CA")]
public class VariableBehaviour : SerializedMonoBehaviour, IVariable, IValue
{
	[Token(Token = "0x4002194")]
	[FieldOffset(Offset = "0x58")]
	public IVariable variable;

	[Token(Token = "0x1700054A")]
	public object result
	{
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x9880C0", Offset = "0x9868C0", Length = "0x45")]
		get
		{
			return null;
		}
		[Address(RVA = "0x988110", Offset = "0x986910", Length = "0x57")]
		[Token(Token = "0x60039B6")]
		set
		{
		}
	}

	[Token(Token = "0x60039B7")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public VariableBehaviour()
	{
	}
}
