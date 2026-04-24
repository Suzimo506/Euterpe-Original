using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200080A")]
public interface ILevelConfigUI
{
	[Token(Token = "0x1700074A")]
	LevelConfigUIState currentUIState
	{
		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60048B3")]
	void ChangeLevelConfigUIState(LevelConfigUIState newState);
}
