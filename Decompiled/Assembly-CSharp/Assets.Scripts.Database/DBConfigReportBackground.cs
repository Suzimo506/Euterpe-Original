using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E5")]
public class DBConfigReportBackground : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002965")]
	private List<ReportBackgroundInfo> m_Items;

	[Token(Token = "0x1700071F")]
	protected List<ReportBackgroundInfo> list
	{
		[Token(Token = "0x6004811")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004812")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x6004813")]
	[Address(RVA = "0x6FE470", Offset = "0x6FCC70", Length = "0x7A")]
	public DBConfigReportBackground()
	{
	}

	[Address(RVA = "0x6FE400", Offset = "0x6FCC00", Length = "0x6B")]
	[Token(Token = "0x6004814")]
	public ReportBackgroundInfo GetReportBackgroundInfoInfoByIndex(int targetIndex)
	{
		return null;
	}

	[Address(RVA = "0x6FE2E0", Offset = "0x6FCAE0", Length = "0x118")]
	[Token(Token = "0x6004815")]
	public void GetAllUnlockDatas(List<ReportBackgroundInfo> reportBackgroundInfos)
	{
	}

	[Address(RVA = "0x6FE1D0", Offset = "0x6FC9D0", Length = "0x100")]
	[Token(Token = "0x6004816")]
	public override void Deserialize(string str)
	{
	}
}
