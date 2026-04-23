using System.Collections.Generic;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics.Utils;

[Token(Token = "0x20004F8")]
public interface IDataPush
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003706")]
	void PushDataByTrack(string dataStatisticsName);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003707")]
	void PushDataByTrack(string dataStatisticsName, Dictionary<string, object> data);
}
