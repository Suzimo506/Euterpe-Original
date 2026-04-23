using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D1")]
public class RailGameSettingMetadataChanged : EventBase
{
	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x30")]
	public List<RailKeyValue> key_values;

	[Token(Token = "0x40015B0")]
	[FieldOffset(Offset = "0x38")]
	public RailGameSettingMetadataChangedSource source;

	[Address(RVA = "0x27206C0", Offset = "0x271EEC0", Length = "0x69")]
	[Token(Token = "0x6002F8A")]
	public RailGameSettingMetadataChanged()
	{
	}
}
