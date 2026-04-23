using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200008F")]
public interface ITimeLimitedFreeHandler
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600040F")]
	void AddTimeLimitedFreeRecord(int uid, List<string> contentList, DateTime startTime, DateTime endTime);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000410")]
	void ForceApplyTimeLimitedFree(int uid, List<string> contentList);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000411")]
	void ClearTimeLimitedFreeRecord();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000412")]
	bool CheckTimeLimitedFreeInTime(int uid, int index);

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnRefreshHandleEnd();
}
