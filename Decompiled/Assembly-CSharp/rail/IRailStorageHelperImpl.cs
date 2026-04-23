using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000254")]
public class IRailStorageHelperImpl : RailObject, IRailStorageHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002951")]
	internal IRailStorageHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002952")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailStorageHelperImpl()
	{
	}

	[Address(RVA = "0x3747E0", Offset = "0x372FE0", Length = "0x12B")]
	[Token(Token = "0x6002953")]
	public virtual IRailFile OpenFile(string filename, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x6002954")]
	[Address(RVA = "0x3746B0", Offset = "0x372EB0", Length = "0x129")]
	public virtual IRailFile OpenFile(string filename)
	{
		return null;
	}

	[Address(RVA = "0x373AE0", Offset = "0x3722E0", Length = "0x12B")]
	[Token(Token = "0x6002955")]
	public virtual IRailFile CreateFile(string filename, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Address(RVA = "0x373C10", Offset = "0x372410", Length = "0x129")]
	[Token(Token = "0x6002956")]
	public virtual IRailFile CreateFile(string filename)
	{
		return null;
	}

	[Address(RVA = "0x374350", Offset = "0x372B50", Length = "0xE0")]
	[Token(Token = "0x6002957")]
	public virtual bool IsFileExist(string filename)
	{
		return default(bool);
	}

	[Address(RVA = "0x374510", Offset = "0x372D10", Length = "0x195")]
	[Token(Token = "0x6002958")]
	public virtual bool ListFiles(List<string> filelist)
	{
		return default(bool);
	}

	[Address(RVA = "0x374CE0", Offset = "0x3734E0", Length = "0xDD")]
	[Token(Token = "0x6002959")]
	public virtual RailResult RemoveFile(string filename)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x374430", Offset = "0x372C30", Length = "0xE0")]
	[Token(Token = "0x600295A")]
	public virtual bool IsFileSyncedToCloud(string filename)
	{
		return default(bool);
	}

	[Address(RVA = "0x374000", Offset = "0x372800", Length = "0xED")]
	[Token(Token = "0x600295B")]
	public virtual RailResult GetFileTimestamp(string filename, out ulong time_stamp)
	{
		System.Runtime.CompilerServices.Unsafe.As<ulong, @null>(ref time_stamp) = null;
		return default(RailResult);
	}

	[Address(RVA = "0x373D40", Offset = "0x372540", Length = "0xB5")]
	[Token(Token = "0x600295C")]
	public virtual uint GetFileCount()
	{
		return default(uint);
	}

	[Address(RVA = "0x373E00", Offset = "0x372600", Length = "0x1F1")]
	[Token(Token = "0x600295D")]
	public virtual RailResult GetFileNameAndSize(uint file_index, out string filename, out ulong file_size)
	{
		filename = null;
		System.Runtime.CompilerServices.Unsafe.As<ulong, @null>(ref file_size) = null;
		return default(RailResult);
	}

	[Address(RVA = "0x3738F0", Offset = "0x3720F0", Length = "0xB5")]
	[Token(Token = "0x600295E")]
	public virtual RailResult AsyncQueryQuota()
	{
		return default(RailResult);
	}

	[Token(Token = "0x600295F")]
	[Address(RVA = "0x374EB0", Offset = "0x3736B0", Length = "0x25D")]
	public virtual RailResult SetSyncFileOption(string filename, RailSyncFileOption option)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002960")]
	[Address(RVA = "0x3741D0", Offset = "0x3729D0", Length = "0xBA")]
	public virtual bool IsCloudStorageEnabledForApp()
	{
		return default(bool);
	}

	[Token(Token = "0x6002961")]
	[Address(RVA = "0x374290", Offset = "0x372A90", Length = "0xBA")]
	public virtual bool IsCloudStorageEnabledForPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6002962")]
	[Address(RVA = "0x373690", Offset = "0x371E90", Length = "0x25D")]
	public virtual RailResult AsyncPublishFileToUserSpace(RailPublishFileToUserSpaceOption option, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002963")]
	[Address(RVA = "0x374AF0", Offset = "0x3732F0", Length = "0x1EE")]
	public virtual IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x6002964")]
	[Address(RVA = "0x374910", Offset = "0x373110", Length = "0x1DA")]
	public virtual IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option)
	{
		return null;
	}

	[Address(RVA = "0x373410", Offset = "0x371C10", Length = "0x273")]
	[Token(Token = "0x6002965")]
	public virtual RailResult AsyncListStreamFiles(string contents, RailListStreamFileOption option, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002966")]
	[Address(RVA = "0x3739B0", Offset = "0x3721B0", Length = "0x123")]
	public virtual RailResult AsyncRenameStreamFile(string old_filename, string new_filename, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002967")]
	[Address(RVA = "0x373310", Offset = "0x371B10", Length = "0x100")]
	public virtual RailResult AsyncDeleteStreamFile(string filename, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3740F0", Offset = "0x3728F0", Length = "0xDD")]
	[Token(Token = "0x6002968")]
	public virtual uint GetRailFileEnabledOS(string filename)
	{
		return default(uint);
	}

	[Address(RVA = "0x374DC0", Offset = "0x3735C0", Length = "0xED")]
	[Token(Token = "0x6002969")]
	public virtual RailResult SetRailFileEnabledOS(string filename, EnumRailStorageFileEnabledOS sync_os)
	{
		return default(RailResult);
	}
}
