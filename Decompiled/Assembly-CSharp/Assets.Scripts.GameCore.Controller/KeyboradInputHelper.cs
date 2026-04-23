using System.Collections.Generic;
using Assets.Scripts.GameCore.Controller.Configs;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.GameCore.Controller;

[Token(Token = "0x2000776")]
public class KeyboradInputHelper
{
	[Token(Token = "0x4002774")]
	public static readonly int keyCustomCount;

	[Token(Token = "0x4002775")]
	public static readonly int keyFeverCustomCount;

	[Token(Token = "0x4002776")]
	public static readonly Dictionary<string, string> simplifyKeyDict;

	[Token(Token = "0x4002777")]
	private const string default_key_list = "{\"Keylist\":{ \"Custom\":[{\"Key\":\"None\",\"Type\":\"BattleAir\"},{\"Key\":\"None\",\"Type\":\"BattleAir\"},{\"Key\":\"None\",\"Type\":\"BattleAir\"},{\"Key\":\"None\",\"Type\":\"BattleAir\"},{\"Key\":\"None\",\"Type\":\"BattleGround\"},{\"Key\":\"None\",\"Type\":\"BattleGround\"},{\"Key\":\"None\",\"Type\":\"BattleGround\"},{\"Key\":\"None\",\"Type\":\"BattleGround\"},]},\"IsChanged\":\"false\",\"KeyBoardProposal\":\"Default\",\"HandleProposal\":\"Default\",\"IsVibration\":\"true\",\"FeverKey\":\"Space\"}";

	[Token(Token = "0x60045F7")]
	[Address(RVA = "0x49F250", Offset = "0x49DA50", Length = "0x6D7")]
	static KeyboradInputHelper()
	{
	}

	[Token(Token = "0x60045F8")]
	[Address(RVA = "0x49EAB0", Offset = "0x49D2B0", Length = "0xEE")]
	public static JObject GetCustomKeyConfigFromJson()
	{
		return null;
	}

	[Address(RVA = "0x49EBA0", Offset = "0x49D3A0", Length = "0x1E7")]
	[Token(Token = "0x60045F9")]
	public static void GetKeyList(ref StandloneCtrlConfig configs, ref List<string> checkRepeatList)
	{
	}

	[Address(RVA = "0x49EE80", Offset = "0x49D680", Length = "0x2FB")]
	[Token(Token = "0x60045FA")]
	public static void SaveKeyList(StandloneCtrlConfig config, JObject jsonData)
	{
	}

	[Token(Token = "0x60045FB")]
	[Address(RVA = "0x49ED90", Offset = "0x49D590", Length = "0xEE")]
	public void ResetCustoms(StandloneCtrlConfig config = null)
	{
	}

	[Token(Token = "0x60045FC")]
	[Address(RVA = "0x49F180", Offset = "0x49D980", Length = "0xC7")]
	public static string SimplifyKey(string keyName)
	{
		return null;
	}

	[Token(Token = "0x60045FD")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public KeyboradInputHelper()
	{
	}
}
