using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using Spine.Unity;

namespace Assets.Scripts.Review;

[Token(Token = "0x20006E8")]
public static class ReviewHandlers
{
	[Token(Token = "0x6004154")]
	[Address(RVA = "0x65A5C0", Offset = "0x658DC0", Length = "0x208")]
	public static void RoleHurtReview(List<string> voice, int roleIdx)
	{
	}

	[Address(RVA = "0x65A310", Offset = "0x658B10", Length = "0x74")]
	[Token(Token = "0x6004155")]
	public static void NavigationReview(int roleIndex, ref string navigationImgName)
	{
	}

	[Token(Token = "0x6004156")]
	[Address(RVA = "0x659FD0", Offset = "0x6587D0", Length = "0x65")]
	public static void ElfinFullModeImgReview(ref string elfinFullModeImgName)
	{
	}

	[Token(Token = "0x6004157")]
	[Address(RVA = "0x65A920", Offset = "0x659120", Length = "0xEF")]
	public static void WhichCountryReview()
	{
	}

	[Token(Token = "0x6004158")]
	[Address(RVA = "0x65A200", Offset = "0x658A00", Length = "0x100")]
	public static void LocalizationChooseReview(bool isReview)
	{
	}

	[Address(RVA = "0x65A7F0", Offset = "0x658FF0", Length = "0x12A")]
	[Token(Token = "0x6004159")]
	public static string WelcomeReview(WelcomeInfo welcomeInfo)
	{
		return null;
	}

	[Token(Token = "0x600415A")]
	[Address(RVA = "0x65A040", Offset = "0x658840", Length = "0x1B4")]
	public static string ElfinImgReview(LocalElfinInfo localElfin, string displayRegexPattern)
	{
		return null;
	}

	[Address(RVA = "0x65A3C0", Offset = "0x658BC0", Length = "0xFA")]
	[Token(Token = "0x600415B")]
	public static void NoteReview(SkeletonAnimation sk)
	{
	}

	[Token(Token = "0x600415C")]
	[Address(RVA = "0x65A4C0", Offset = "0x658CC0", Length = "0xFA")]
	public static void RoleBattleReview(SkeletonAnimation sk)
	{
	}
}
