using System.Collections.Generic;
using Cpp2ILInjected;
using PeroTools2.Commons;

namespace ArcadeController.UI;

[Token(Token = "0x200053C")]
public class PageMainManager : SingletonMonoBehaviour<PageMainManager>
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001F74")]
	private Dictionary<string, PageAbstractHandler> m_UISystemPages;

	[Token(Token = "0x6003762")]
	[Address(RVA = "0x599CD0", Offset = "0x5984D0", Length = "0x38")]
	public PageMainManager()
	{
		((SingletonMonoBehaviour<T>)(object)this)._002Ector();
	}
}
