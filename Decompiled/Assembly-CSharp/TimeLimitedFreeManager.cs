using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.Structs.Network;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000092")]
public class TimeLimitedFreeManager : Singleton<TimeLimitedFreeManager>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039E")]
	private Dictionary<int, ITimeLimitedFreeHandler> m_TimeLimitedFreeHandlerMap;

	[Token(Token = "0x400039F")]
	public static readonly int StageBackgroundType;

	[Token(Token = "0x40003A0")]
	public static readonly int SkinType;

	[Token(Token = "0x40003A1")]
	public static readonly int CharacterType;

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x51E070", Offset = "0x51C870", Length = "0x1AF")]
	private void Init()
	{
	}

	[Address(RVA = "0x51EE40", Offset = "0x51D640", Length = "0x18C")]
	[Token(Token = "0x6000421")]
	public void RefreshTimeLimitFreeCheck()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x51E380", Offset = "0x51CB80", Length = "0xABB")]
	private void OnTimeLimitedFreeCheckCallBack(JObject jObj)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x51E220", Offset = "0x51CA20", Length = "0x151")]
	private void OnFailCallBack(NetworkRequest r)
	{
	}

	[Address(RVA = "0x51DC50", Offset = "0x51C450", Length = "0x25A")]
	[Token(Token = "0x6000424")]
	private void ApplyForceSelect(string missionId, int type, int uid, List<string> contentList, DateTime startTime, DateTime endTime)
	{
	}

	[Address(RVA = "0x51DEB0", Offset = "0x51C6B0", Length = "0xBB")]
	[Token(Token = "0x6000425")]
	private bool CheckIsApplyed(string missionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x51DF70", Offset = "0x51C770", Length = "0xF5")]
	public bool CheckTimeLimitedFreeInTime(int type, int uid, int index = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x51F040", Offset = "0x51D840", Length = "0x38")]
	public TimeLimitedFreeManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
