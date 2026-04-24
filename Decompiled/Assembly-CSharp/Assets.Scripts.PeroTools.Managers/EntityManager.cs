using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
[Token(Token = "0x2000646")]
public class EntityManager : Singleton<EntityManager>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400234D")]
	public readonly Dictionary<string, object> entities;

	[Token(Token = "0x170005A3")]
	public object Item
	{
		[Address(RVA = "0x75B480", Offset = "0x759C80", Length = "0x7B")]
		[Token(Token = "0x6003C82")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C83")]
	[Address(RVA = "0x75B400", Offset = "0x759C00", Length = "0x76")]
	public EntityManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
