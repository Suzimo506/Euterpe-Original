namespace PeroPeroGames.GlobalDefines;

[Flags]
public enum DirtyType
{
	None = 0,
	AllData = 1,
	Language = 2,
	LevelUp = 4,
	AnchorChange = 8,
	BuyAlbum = 16,
	UserChanged = 32,
	UserDirtyTypeStart = 2147483648,
	All = 18446744073709551615,
}

