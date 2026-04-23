using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E6")]
public class SceneEggInfo : BaseDataObject
{
	[Token(Token = "0x4002966")]
	[FieldOffset(Offset = "0x20")]
	public string[] musicIds;

	[Token(Token = "0x4002967")]
	[FieldOffset(Offset = "0x28")]
	public int[] albumIds;

	[Token(Token = "0x4002968")]
	[FieldOffset(Offset = "0x30")]
	public int[] roleIds;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002969")]
	public int eggId;

	[Token(Token = "0x6004817")]
	[Address(RVA = "0x4A49F0", Offset = "0x4A31F0", Length = "0x160")]
	public void CheckingSceneEgg(string musicId, int albumId, int roleId, List<int> musicBuffer, List<int> albumBuffer, List<int> roleBuffer)
	{
	}

	[Token(Token = "0x6004818")]
	[Address(RVA = "0x4A4980", Offset = "0x4A3180", Length = "0x69")]
	private bool CheckMusicContainsId(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6004819")]
	[Address(RVA = "0x4A4930", Offset = "0x4A3130", Length = "0x46")]
	private bool CheckContainsId(int[] ids, int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600481A")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public SceneEggInfo()
	{
	}
}
