using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007EB")]
public class StageAchievementInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002972")]
	public string uid;

	[Token(Token = "0x4002973")]
	[FieldOffset(Offset = "0x28")]
	public StageAchievement[] easy;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002974")]
	public StageAchievement[] normal;

	[Token(Token = "0x4002975")]
	[FieldOffset(Offset = "0x38")]
	public StageAchievement[] hard;

	[Token(Token = "0x4002976")]
	[FieldOffset(Offset = "0x40")]
	public StageAchievement[] special;

	[Token(Token = "0x4002977")]
	[FieldOffset(Offset = "0x48")]
	protected StageAchievementExInfo m_ExInfo;

	[Token(Token = "0x17000722")]
	public StageAchievementExInfo exInfo
	{
		[Token(Token = "0x600482A")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return default(StageAchievementExInfo);
		}
	}

	[Token(Token = "0x17000723")]
	public int count
	{
		[Token(Token = "0x600482C")]
		[Address(RVA = "0x4A4F20", Offset = "0x4A3720", Length = "0x33")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004828")]
	[Address(RVA = "0x4A4F00", Offset = "0x4A3700", Length = "0x20")]
	public override void Init(int index)
	{
	}

	[Token(Token = "0x6004829")]
	[Address(RVA = "0x4A4DA0", Offset = "0x4A35A0", Length = "0x156")]
	private void InitExInfo()
	{
	}

	[Token(Token = "0x600482B")]
	[Address(RVA = "0x4A4B60", Offset = "0x4A3360", Length = "0x3A")]
	public bool ContainsAchv(int diff)
	{
		return default(bool);
	}

	[Token(Token = "0x600482D")]
	[Address(RVA = "0x4A4BA0", Offset = "0x4A33A0", Length = "0x1F4")]
	internal bool DoAchievement(AchievementArgs args, Dictionary<StageAchievement, AchiInfo> buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x600482E")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public StageAchievementInfo()
	{
	}
}
