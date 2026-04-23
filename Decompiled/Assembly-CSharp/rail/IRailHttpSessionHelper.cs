using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002FA")]
public interface IRailHttpSessionHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DE1")]
	IRailHttpSession CreateHttpSession();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DE2")]
	IRailHttpResponse CreateHttpResponse(string http_response_data);
}
