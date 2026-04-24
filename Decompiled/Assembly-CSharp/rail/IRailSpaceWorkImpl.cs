using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000252")]
public class IRailSpaceWorkImpl : RailObject, IRailSpaceWork, IRailComponent
{
	[Token(Token = "0x6002912")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailSpaceWorkImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002913")]
	~IRailSpaceWorkImpl()
	{
	}

	[Address(RVA = "0x36EC80", Offset = "0x36D480", Length = "0xB5")]
	[Token(Token = "0x6002914")]
	public virtual void Close()
	{
	}

	[Address(RVA = "0x370870", Offset = "0x36F070", Length = "0xEB")]
	[Token(Token = "0x6002915")]
	public virtual SpaceWorkID GetSpaceWorkID()
	{
		return null;
	}

	[Address(RVA = "0x36ED40", Offset = "0x36D540", Length = "0xBA")]
	[Token(Token = "0x6002916")]
	public virtual bool Editable()
	{
		return default(bool);
	}

	[Token(Token = "0x6002917")]
	[Address(RVA = "0x372E40", Offset = "0x371640", Length = "0xDD")]
	public virtual RailResult StartSync(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002918")]
	[Address(RVA = "0x370BC0", Offset = "0x36F3C0", Length = "0x247")]
	public virtual RailResult GetSyncProgress(RailSpaceWorkSyncProgress progress)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36EBC0", Offset = "0x36D3C0", Length = "0xB5")]
	[Token(Token = "0x6002919")]
	public virtual RailResult CancelSync()
	{
		return default(RailResult);
	}

	[Address(RVA = "0x371820", Offset = "0x370020", Length = "0x1E9")]
	[Token(Token = "0x600291A")]
	public virtual RailResult GetWorkLocalFolder(out string path)
	{
		path = null;
		return default(RailResult);
	}

	[Address(RVA = "0x36EAE0", Offset = "0x36D2E0", Length = "0xDD")]
	[Token(Token = "0x600291B")]
	public virtual RailResult AsyncUpdateMetadata(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36FF20", Offset = "0x36E720", Length = "0x1EA")]
	[Token(Token = "0x600291C")]
	public virtual RailResult GetName(out string name)
	{
		name = null;
		return default(RailResult);
	}

	[Token(Token = "0x600291D")]
	[Address(RVA = "0x36F560", Offset = "0x36DD60", Length = "0x1E9")]
	public virtual RailResult GetDescription(out string description)
	{
		description = null;
		return default(RailResult);
	}

	[Token(Token = "0x600291E")]
	[Address(RVA = "0x371130", Offset = "0x36F930", Length = "0x1E9")]
	public virtual RailResult GetUrl(out string url)
	{
		url = null;
		return default(RailResult);
	}

	[Address(RVA = "0x36F4A0", Offset = "0x36DCA0", Length = "0xB5")]
	[Token(Token = "0x600291F")]
	public virtual uint GetCreateTime()
	{
		return default(uint);
	}

	[Address(RVA = "0x36F9A0", Offset = "0x36E1A0", Length = "0xB5")]
	[Token(Token = "0x6002920")]
	public virtual uint GetLastUpdateTime()
	{
		return default(uint);
	}

	[Address(RVA = "0x371760", Offset = "0x36FF60", Length = "0xB5")]
	[Token(Token = "0x6002921")]
	public virtual ulong GetWorkFileSize()
	{
		return default(ulong);
	}

	[Address(RVA = "0x370E10", Offset = "0x36F610", Length = "0x18B")]
	[Token(Token = "0x6002922")]
	public virtual RailResult GetTags(List<string> tags)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x370110", Offset = "0x36E910", Length = "0x1E9")]
	[Token(Token = "0x6002923")]
	public virtual RailResult GetPreviewImage(out string path)
	{
		path = null;
		return default(RailResult);
	}

	[Token(Token = "0x6002924")]
	[Address(RVA = "0x371320", Offset = "0x36FB20", Length = "0x1E9")]
	public virtual RailResult GetVersion(out string version)
	{
		version = null;
		return default(RailResult);
	}

	[Address(RVA = "0x36F750", Offset = "0x36DF50", Length = "0xB5")]
	[Token(Token = "0x6002925")]
	public virtual ulong GetDownloadCount()
	{
		return default(ulong);
	}

	[Token(Token = "0x6002926")]
	[Address(RVA = "0x370B00", Offset = "0x36F300", Length = "0xB5")]
	public virtual ulong GetSubscribedCount()
	{
		return default(ulong);
	}

	[Address(RVA = "0x3707B0", Offset = "0x36EFB0", Length = "0xB5")]
	[Token(Token = "0x6002927")]
	public virtual EnumRailSpaceWorkShareLevel GetShareLevel()
	{
		return default(EnumRailSpaceWorkShareLevel);
	}

	[Token(Token = "0x6002928")]
	[Address(RVA = "0x3706F0", Offset = "0x36EEF0", Length = "0xB5")]
	public virtual ulong GetScore()
	{
		return default(ulong);
	}

	[Address(RVA = "0x36FC50", Offset = "0x36E450", Length = "0x206")]
	[Token(Token = "0x6002929")]
	public virtual RailResult GetMetadata(string key, out string value)
	{
		value = null;
		return default(RailResult);
	}

	[Address(RVA = "0x36FE60", Offset = "0x36E660", Length = "0xB5")]
	[Token(Token = "0x600292A")]
	public virtual EnumRailSpaceWorkRateValue GetMyVote()
	{
		return default(EnumRailSpaceWorkRateValue);
	}

	[Address(RVA = "0x371A10", Offset = "0x370210", Length = "0xBA")]
	[Token(Token = "0x600292B")]
	public virtual bool IsFavorite()
	{
		return default(bool);
	}

	[Address(RVA = "0x371AD0", Offset = "0x3702D0", Length = "0xBA")]
	[Token(Token = "0x600292C")]
	public virtual bool IsSubscribed()
	{
		return default(bool);
	}

	[Token(Token = "0x600292D")]
	[Address(RVA = "0x372650", Offset = "0x370E50", Length = "0xDD")]
	public virtual RailResult SetName(string name)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3722F0", Offset = "0x370AF0", Length = "0xDD")]
	[Token(Token = "0x600292E")]
	public virtual RailResult SetDescription(string description)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600292F")]
	[Address(RVA = "0x3729A0", Offset = "0x3711A0", Length = "0x17E")]
	public virtual RailResult SetTags(List<string> tags)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002930")]
	[Address(RVA = "0x372730", Offset = "0x370F30", Length = "0xDD")]
	public virtual RailResult SetPreviewImage(string path_filename)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x372D60", Offset = "0x371560", Length = "0xDD")]
	[Token(Token = "0x6002931")]
	public virtual RailResult SetVersion(string version)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3728D0", Offset = "0x3710D0", Length = "0xC2")]
	[Token(Token = "0x6002932")]
	public virtual RailResult SetShareLevel(EnumRailSpaceWorkShareLevel level)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x372810", Offset = "0x371010", Length = "0xB5")]
	public virtual RailResult SetShareLevel()
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x372550", Offset = "0x370D50", Length = "0x100")]
	public virtual RailResult SetMetadata(string key, string value)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x372210", Offset = "0x370A10", Length = "0xDD")]
	[Token(Token = "0x6002935")]
	public virtual RailResult SetContentFromFolder(string path)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x36EF90", Offset = "0x36D790", Length = "0x18B")]
	public virtual RailResult GetAllMetadata(List<RailKeyValue> metadata)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x36EE00", Offset = "0x36D600", Length = "0x18B")]
	public virtual RailResult GetAdditionalPreviewUrls(List<string> preview_urls)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x36F2B0", Offset = "0x36DAB0", Length = "0x18B")]
	public virtual RailResult GetAssociatedSpaceWorks(List<SpaceWorkID> ids)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x36F810", Offset = "0x36E010", Length = "0x18B")]
	public virtual RailResult GetLanguages(List<string> languages)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x371D70", Offset = "0x370570", Length = "0xDD")]
	public virtual RailResult RemoveMetadata(string key)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x371F10", Offset = "0x370710", Length = "0x17E")]
	public virtual RailResult SetAdditionalPreviews(List<string> local_paths)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x372090", Offset = "0x370890", Length = "0x17E")]
	[Token(Token = "0x600293C")]
	public virtual RailResult SetAssociatedSpaceWorks(List<SpaceWorkID> ids)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3723D0", Offset = "0x370BD0", Length = "0x17E")]
	[Token(Token = "0x600293D")]
	public virtual RailResult SetLanguages(List<string> languages)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x370300", Offset = "0x36EB00", Length = "0x1F2")]
	public virtual RailResult GetPreviewUrl(out string url, uint scaling)
	{
		url = null;
		return default(RailResult);
	}

	[Address(RVA = "0x370500", Offset = "0x36ED00", Length = "0x1E9")]
	[Token(Token = "0x600293F")]
	public virtual RailResult GetPreviewUrl(out string url)
	{
		url = null;
		return default(RailResult);
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x371510", Offset = "0x36FD10", Length = "0x247")]
	public virtual RailResult GetVoteDetail(List<RailSpaceWorkVoteDetail> vote_details)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x370FA0", Offset = "0x36F7A0", Length = "0x18B")]
	[Token(Token = "0x6002941")]
	public virtual RailResult GetUploaderIDs(List<RailID> uploader_ids)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002942")]
	[Address(RVA = "0x372B20", Offset = "0x371320", Length = "0x23D")]
	public virtual RailResult SetUpdateOptions(RailSpaceWorkUpdateOptions options)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x370A20", Offset = "0x36F220", Length = "0xD2")]
	[Token(Token = "0x6002943")]
	public virtual RailResult GetStatistic(EnumRailSpaceWorkStatistic stat_type, out ulong value)
	{
		System.Runtime.CompilerServices.Unsafe.As<ulong, @null>(ref value) = null;
		return default(RailResult);
	}

	[Token(Token = "0x6002944")]
	[Address(RVA = "0x371E50", Offset = "0x370650", Length = "0xB5")]
	public virtual RailResult RemovePreviewImage()
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002945")]
	[Address(RVA = "0x370960", Offset = "0x36F160", Length = "0xB5")]
	public virtual uint GetState()
	{
		return default(uint);
	}

	[Token(Token = "0x6002946")]
	[Address(RVA = "0x36E960", Offset = "0x36D160", Length = "0x17E")]
	public virtual RailResult AddAssociatedGameIDs(List<RailGameID> game_ids)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x371BF0", Offset = "0x3703F0", Length = "0x17E")]
	[Token(Token = "0x6002947")]
	public virtual RailResult RemoveAssociatedGameIDs(List<RailGameID> game_ids)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36F120", Offset = "0x36D920", Length = "0x18B")]
	[Token(Token = "0x6002948")]
	public virtual RailResult GetAssociatedGameIDs(List<RailGameID> game_ids)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36FA60", Offset = "0x36E260", Length = "0x1E9")]
	[Token(Token = "0x6002949")]
	public virtual RailResult GetLocalVersion(out string version)
	{
		version = null;
		return default(RailResult);
	}

	[Token(Token = "0x600294A")]
	[Address(RVA = "0x36F440", Offset = "0x36DC40", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x600294B")]
	[Address(RVA = "0x371B90", Offset = "0x370390", Length = "0x55")]
	public virtual void Release()
	{
	}
}
