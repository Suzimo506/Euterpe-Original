using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200062A")]
public class Random : Group
{
	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0x28")]
	private IPlayable m_Playable;

	[Token(Token = "0x1700058F")]
	public override float duration
	{
		[Address(RVA = "0x749780", Offset = "0x747F80", Length = "0x83")]
		[Token(Token = "0x6003BB3")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0x7496D0", Offset = "0x747ED0", Length = "0xAE")]
	[Token(Token = "0x6003BB4")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x745670", Offset = "0x743E70", Length = "0x7")]
	[Token(Token = "0x6003BB5")]
	public Random()
	{
	}
}
