using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.PnlOptions;

[Token(Token = "0x2000859")]
public class PlaySettingModel : DataModel
{
	[Token(Token = "0x4002B69")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, IData> m_BgBrightnessSettingDic;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002B6A")]
	private List<string> m_SceneDefines;

	[Token(Token = "0x17000862")]
	public IVariable AdvancedJudge
	{
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x4C3470", Offset = "0x4C1C70", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000863")]
	public IVariable ShowAp
	{
		[Address(RVA = "0x4C3540", Offset = "0x4C1D40", Length = "0x62")]
		[Token(Token = "0x6004C6A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000864")]
	public Dictionary<string, IData> BgBrightnessSettingDic
	{
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x4C34E0", Offset = "0x4C1CE0", Length = "0x56")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C6C")]
	[Address(RVA = "0x4C3110", Offset = "0x4C1910", Length = "0x96")]
	public override void Init()
	{
	}

	[Token(Token = "0x6004C6D")]
	[Address(RVA = "0x4C3340", Offset = "0x4C1B40", Length = "0x58")]
	public void SavePlaySettingData()
	{
	}

	[Token(Token = "0x6004C6E")]
	[Address(RVA = "0x4C33A0", Offset = "0x4C1BA0", Length = "0xC2")]
	public void SetSceneBgBrightness(string sceneInfo, float brightnessValue)
	{
	}

	[Token(Token = "0x6004C6F")]
	[Address(RVA = "0x4C31B0", Offset = "0x4C19B0", Length = "0x183")]
	private void SaveBrightnessSetting()
	{
	}

	[Address(RVA = "0x4C2CD0", Offset = "0x4C14D0", Length = "0x433")]
	[Token(Token = "0x6004C70")]
	private void GetBgBrightnessCacheSetting()
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6004C71")]
	public PlaySettingModel()
	{
	}
}
