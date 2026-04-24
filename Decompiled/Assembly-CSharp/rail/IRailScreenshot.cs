using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000367")]
public interface IRailScreenshot : IRailComponent
{
	[Token(Token = "0x6002E99")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetLocation(string location);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E9A")]
	bool SetUsers(List<RailID> users);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E9B")]
	bool AssociatePublishedFiles(List<SpaceWorkID> work_files);

	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncPublishScreenshot(string work_name, string user_data);
}
