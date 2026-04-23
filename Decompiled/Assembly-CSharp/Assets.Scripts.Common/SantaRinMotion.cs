using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000982")]
public class SantaRinMotion : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4003410")]
	private float m_StayTime;

	[Token(Token = "0x4003411")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_HasSet;

	[Address(RVA = "0x702750", Offset = "0x700F50", Length = "0x266")]
	[Token(Token = "0x600568C")]
	private void Update()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x600568D")]
	public SantaRinMotion()
	{
	}
}
