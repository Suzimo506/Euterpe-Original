using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Controller.Configs;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using PeroPeroGames.GlobalDefines;
using Rewired;
using UnityEngine;

namespace Assets.Scripts.GameCore.Controller;

[Token(Token = "0x2000779")]
public class StandloneController : Controller<StandloneCtrlConfig>
{
	[Token(Token = "0x400277F")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, List<KeyCode>> m_Dict;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002780")]
	private List<KeyCode> m_List;

	[Token(Token = "0x4002781")]
	[FieldOffset(Offset = "0x28")]
	private List<string> proposalList;

	[Token(Token = "0x4002782")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_DownList;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002783")]
	private List<int> m_MoveList;

	[Token(Token = "0x4002784")]
	[FieldOffset(Offset = "0x40")]
	private List<int> m_UpList;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002785")]
	private string m_CurrentClickKeyButtonName;

	[Token(Token = "0x4002786")]
	[FieldOffset(Offset = "0x50")]
	private InputMapper m_ListenCurKey;

	[Token(Token = "0x4002787")]
	[FieldOffset(Offset = "0x58")]
	private InputMapper m_ListenCurMouse;

	[Token(Token = "0x4002788")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_CheckRepeatKeyList;

	[Token(Token = "0x4002789")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsKey;

	[Token(Token = "0x400278A")]
	[FieldOffset(Offset = "0x6C")]
	private int m_currentCustomKeyIndex;

	[Token(Token = "0x400278B")]
	[FieldOffset(Offset = "0x70")]
	private int m_RepeatIndex;

	[Token(Token = "0x400278C")]
	[FieldOffset(Offset = "0x78")]
	private JObject m_KeyList_JObj;

	[Token(Token = "0x400278D")]
	public static Dictionary<string, float> values;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400278E")]
	private List<int> m_HandleGroundActionNameList;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400278F")]
	private List<int> m_HandleAirActionNameList;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002790")]
	private List<int> m_HandleFeverActionNameList;

	[Token(Token = "0x17000691")]
	private static Player PLAYER
	{
		[Token(Token = "0x600460B")]
		[Address(RVA = "0x4A9F10", Offset = "0x4A8710", Length = "0x5F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004608")]
	[Address(RVA = "0x4A7860", Offset = "0x4A6060", Length = "0x7B")]
	private List<int> GetButtonList(BUTTON_STATE buttonState)
	{
		return null;
	}

	[Token(Token = "0x6004609")]
	[Address(RVA = "0x4A8DD0", Offset = "0x4A75D0", Length = "0x2D8")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x4A8D90", Offset = "0x4A7590", Length = "0x33")]
	[Token(Token = "0x600460A")]
	public override void OnDisableController()
	{
	}

	[Address(RVA = "0x4A5AE0", Offset = "0x4A42E0", Length = "0x532")]
	[Token(Token = "0x600460C")]
	public override float GetAxisFromUI(string axisName)
	{
		return default(float);
	}

	[Token(Token = "0x600460D")]
	[Address(RVA = "0x4A6020", Offset = "0x4A4820", Length = "0xB59")]
	public override bool GetButtonDownFromUI(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x600460E")]
	[Address(RVA = "0x4A6FA0", Offset = "0x4A57A0", Length = "0x8B7")]
	public override bool GetButtonFromUI(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x600460F")]
	[Address(RVA = "0x4A7990", Offset = "0x4A6190", Length = "0x8B7")]
	public override bool GetButtonUpFromUI(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x6004610")]
	[Address(RVA = "0x4A6B80", Offset = "0x4A5380", Length = "0x41F")]
	public override List<int> GetButtonDown(MDButtonType buttonName)
	{
		return null;
	}

	[Token(Token = "0x6004611")]
	[Address(RVA = "0x4A8620", Offset = "0x4A6E20", Length = "0x3C2")]
	public override List<int> GetButton(MDButtonType buttonName)
	{
		return null;
	}

	[Address(RVA = "0x4A8250", Offset = "0x4A6A50", Length = "0x3C2")]
	[Token(Token = "0x6004612")]
	public override List<int> GetButtonUp(MDButtonType buttonName)
	{
		return null;
	}

	[Token(Token = "0x6004613")]
	[Address(RVA = "0x4A78E0", Offset = "0x4A60E0", Length = "0xA7")]
	protected override bool GetButtonProposal(MDButtonType buttonName)
	{
		return default(bool);
	}

	[Token(Token = "0x6004614")]
	[Address(RVA = "0x4A97B0", Offset = "0x4A7FB0", Length = "0x128")]
	public override void SwitchProposal(string proposalName)
	{
	}

	[Token(Token = "0x6004615")]
	[Address(RVA = "0x4A8A60", Offset = "0x4A7260", Length = "0x15")]
	public override void OnClickChangeButton(string name, int currentCustomKeyIndex)
	{
	}

	[Token(Token = "0x6004616")]
	[Address(RVA = "0x4A8A80", Offset = "0x4A7280", Length = "0x30F")]
	public override void OnClickChangeButton(string buttonName)
	{
	}

	[Token(Token = "0x6004617")]
	[Address(RVA = "0x4A50A0", Offset = "0x4A38A0", Length = "0x5AA")]
	public override void ChangeButton(string buttonName, string newKey, string uiName)
	{
	}

	[Token(Token = "0x6004618")]
	[Address(RVA = "0x4A89F0", Offset = "0x4A71F0", Length = "0x6D")]
	public void GetDefaultKeyList()
	{
	}

	[Token(Token = "0x6004619")]
	[Address(RVA = "0x4A90B0", Offset = "0x4A78B0", Length = "0x392")]
	private void OnInputMapper(InputMapper.InputMappedEventData data)
	{
	}

	[Token(Token = "0x600461A")]
	[Address(RVA = "0x4A5A10", Offset = "0x4A4210", Length = "0xC0")]
	private bool CheckInputKeyRepeat(string key, out int repeatKeyIndex)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref repeatKeyIndex) = null;
		return default(bool);
	}

	[Token(Token = "0x600461B")]
	[Address(RVA = "0x4A98E0", Offset = "0x4A80E0", Length = "0xA9")]
	public override void UpdateRepeatList(List<string> list)
	{
	}

	[Token(Token = "0x600461C")]
	[Address(RVA = "0x4A9590", Offset = "0x4A7D90", Length = "0xA1")]
	public override void SaveKeyDataAsJson()
	{
	}

	[Token(Token = "0x600461D")]
	[Address(RVA = "0x4A5720", Offset = "0x4A3F20", Length = "0xD6")]
	private void ChangeJsonOther(string key, string value)
	{
	}

	[Token(Token = "0x600461E")]
	[Address(RVA = "0x4A5650", Offset = "0x4A3E50", Length = "0xCD")]
	private void ChangeJsonFever(string key)
	{
	}

	[Address(RVA = "0x4A9450", Offset = "0x4A7C50", Length = "0x130")]
	[Token(Token = "0x600461F")]
	public override void SaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration)
	{
	}

	[Address(RVA = "0x4A9640", Offset = "0x4A7E40", Length = "0x160")]
	[Token(Token = "0x6004620")]
	public override void SetVibration(VibrationVaule vaule, DeviceHandles handles, float duration)
	{
	}

	[Token(Token = "0x6004621")]
	[Address(RVA = "0x4A5800", Offset = "0x4A4000", Length = "0x209")]
	private bool CheckDisableKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6004622")]
	[Address(RVA = "0x4A9A80", Offset = "0x4A8280", Length = "0x48E")]
	public StandloneController()
	{
		((Controller<>)(object)this)._002Ector();
	}
}
