using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F8")]
public interface IRailHttpResponse : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DD1")]
	int GetHttpResponseCode();

	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetResponseHeaderKeys(List<string> header_keys);

	[Token(Token = "0x6002DD3")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetResponseHeaderValue(string header_key);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DD4")]
	string GetResponseBodyData();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DD5")]
	uint GetContentLength();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DD6")]
	string GetContentType();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DD7")]
	string GetContentRange();

	[Token(Token = "0x6002DD8")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetContentLanguage();

	[Token(Token = "0x6002DD9")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetContentEncoding();

	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetLastModified();
}
