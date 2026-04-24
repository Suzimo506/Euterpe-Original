using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A5")]
public interface IRailDlcHelper
{
	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryIsOwnedDlcsOnServer(List<RailDlcID> dlc_ids, string user_data);

	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncCheckAllDlcsStateReady(string user_data);

	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsDlcInstalled(RailDlcID dlc_id, out string installed_path);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D06")]
	bool IsDlcInstalled(RailDlcID dlc_id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D07")]
	bool IsOwnedDlc(RailDlcID dlc_id);

	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetDlcCount();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D09")]
	bool GetDlcInfo(uint index, RailDlcInfo dlc_info);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D0A")]
	bool AsyncInstallDlc(RailDlcID dlc_id, string user_data);

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool AsyncRemoveDlc(RailDlcID dlc_id, string user_data);
}
