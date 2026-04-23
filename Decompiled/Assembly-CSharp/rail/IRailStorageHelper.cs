using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200037A")]
public interface IRailStorageHelper
{
	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailFile OpenFile(string filename, out RailResult result);

	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailFile OpenFile(string filename);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002ECC")]
	IRailFile CreateFile(string filename, out RailResult result);

	[Token(Token = "0x6002ECD")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailFile CreateFile(string filename);

	[Token(Token = "0x6002ECE")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsFileExist(string filename);

	[Token(Token = "0x6002ECF")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool ListFiles(List<string> filelist);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002ED0")]
	RailResult RemoveFile(string filename);

	[Token(Token = "0x6002ED1")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsFileSyncedToCloud(string filename);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002ED2")]
	RailResult GetFileTimestamp(string filename, out ulong time_stamp);

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetFileCount();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002ED4")]
	RailResult GetFileNameAndSize(uint file_index, out string filename, out ulong file_size);

	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryQuota();

	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetSyncFileOption(string filename, RailSyncFileOption option);

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsCloudStorageEnabledForApp();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002ED8")]
	bool IsCloudStorageEnabledForPlayer();

	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncPublishFileToUserSpace(RailPublishFileToUserSpaceOption option, string user_data);

	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option, out RailResult result);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EDB")]
	IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option);

	[Token(Token = "0x6002EDC")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncListStreamFiles(string contents, RailListStreamFileOption option, string user_data);

	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRenameStreamFile(string old_filename, string new_filename, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EDE")]
	RailResult AsyncDeleteStreamFile(string filename, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EDF")]
	uint GetRailFileEnabledOS(string filename);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EE0")]
	RailResult SetRailFileEnabledOS(string filename, EnumRailStorageFileEnabledOS sync_os);
}
