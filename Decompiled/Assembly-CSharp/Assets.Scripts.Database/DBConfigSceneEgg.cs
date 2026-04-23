using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E7")]
public class DBConfigSceneEgg : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400296A")]
	private List<SceneEggInfo> m_Items;

	[Token(Token = "0x17000720")]
	protected List<SceneEggInfo> list
	{
		[Token(Token = "0x600481B")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600481C")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x600481D")]
	[Address(RVA = "0x6FE800", Offset = "0x6FD000", Length = "0x7A")]
	public DBConfigSceneEgg()
	{
	}

	[Address(RVA = "0x6FE6F0", Offset = "0x6FCEF0", Length = "0x100")]
	[Token(Token = "0x600481E")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x600481F")]
	[Address(RVA = "0x6FE4F0", Offset = "0x6FCCF0", Length = "0x1FF")]
	public void CheckSceneEgg(string musicId, int albumId, int roleId, List<int> buffer)
	{
	}
}
