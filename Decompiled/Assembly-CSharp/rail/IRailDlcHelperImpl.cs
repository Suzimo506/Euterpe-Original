using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000233")]
public class IRailDlcHelperImpl : RailObject, IRailDlcHelper
{
	[Token(Token = "0x600277F")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailDlcHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002780")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailDlcHelperImpl()
	{
	}

	[Address(RVA = "0xD239B0", Offset = "0xD221B0", Length = "0x128")]
	[Token(Token = "0x6002781")]
	public virtual RailResult AsyncQueryIsOwnedDlcsOnServer(List<RailDlcID> dlc_ids, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002782")]
	[Address(RVA = "0xD237B0", Offset = "0xD21FB0", Length = "0x65")]
	public virtual RailResult AsyncCheckAllDlcsStateReady(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD23E10", Offset = "0xD22610", Length = "0x1F3")]
	[Token(Token = "0x6002783")]
	public virtual bool IsDlcInstalled(RailDlcID dlc_id, out string installed_path)
	{
		installed_path = null;
		return default(bool);
	}

	[Token(Token = "0x6002784")]
	[Address(RVA = "0xD24010", Offset = "0xD22810", Length = "0x17C")]
	public virtual bool IsDlcInstalled(RailDlcID dlc_id)
	{
		return default(bool);
	}

	[Address(RVA = "0xD24190", Offset = "0xD22990", Length = "0x17C")]
	[Token(Token = "0x6002785")]
	public virtual bool IsOwnedDlc(RailDlcID dlc_id)
	{
		return default(bool);
	}

	[Address(RVA = "0xD23C70", Offset = "0xD22470", Length = "0x55")]
	[Token(Token = "0x6002786")]
	public virtual uint GetDlcCount()
	{
		return default(uint);
	}

	[Address(RVA = "0xD23CD0", Offset = "0xD224D0", Length = "0x136")]
	[Token(Token = "0x6002787")]
	public virtual bool GetDlcInfo(uint index, RailDlcInfo dlc_info)
	{
		return default(bool);
	}

	[Address(RVA = "0xD23820", Offset = "0xD22020", Length = "0x180")]
	[Token(Token = "0x6002788")]
	public virtual bool AsyncInstallDlc(RailDlcID dlc_id, string user_data)
	{
		return default(bool);
	}

	[Token(Token = "0x6002789")]
	[Address(RVA = "0xD23AE0", Offset = "0xD222E0", Length = "0x180")]
	public virtual bool AsyncRemoveDlc(RailDlcID dlc_id, string user_data)
	{
		return default(bool);
	}
}
