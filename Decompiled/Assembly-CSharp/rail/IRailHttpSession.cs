using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F9")]
public interface IRailHttpSession : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DDB")]
	RailResult SetRequestMethod(RailHttpSessionMethod method);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DDC")]
	RailResult SetParameters(List<RailKeyValue> parameters);

	[Token(Token = "0x6002DDD")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetPostBodyContent(string body_content);

	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetRequestTimeOut(uint timeout_secs);

	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetRequestHeaders(List<string> headers);

	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSendRequest(string url, string user_data);
}
