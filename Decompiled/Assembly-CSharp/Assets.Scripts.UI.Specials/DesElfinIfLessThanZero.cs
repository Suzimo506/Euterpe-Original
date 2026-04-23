using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000870")]
public class DesElfinIfLessThanZero : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002C20")]
	public IVariable elfinIndex;

	[Token(Token = "0x6004D20")]
	[Address(RVA = "0x60E590", Offset = "0x60CD90", Length = "0xBB")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004D21")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public DesElfinIfLessThanZero()
	{
	}
}
