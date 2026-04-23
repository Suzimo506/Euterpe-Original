using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Common.SceneEgg;

[Token(Token = "0x200098C")]
public class CryptonEggControl : SceneEggAbstractController
{
	[Address(RVA = "0x6F2E90", Offset = "0x6F1690", Length = "0x148")]
	[Token(Token = "0x60056D9")]
	private void SceneEggRefreshInit()
	{
	}

	[Address(RVA = "0x6F2D30", Offset = "0x6F1530", Length = "0x153")]
	[Token(Token = "0x60056DA")]
	protected override void SceneEggHandle(List<int> sceneEggIdsBuffer)
	{
	}

	[Token(Token = "0x60056DB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CryptonEggControl()
	{
	}
}
