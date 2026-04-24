using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Controller;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using Rewired;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x200064D")]
public class InputManager : Singleton<InputManager>, IPause
{
	[Token(Token = "0x4002371")]
	[FieldOffset(Offset = "0x10")]
	private IControlable m_Controller;

	[Token(Token = "0x4002372")]
	[FieldOffset(Offset = "0x18")]
	public bool customIsChanged;

	[Token(Token = "0x4002373")]
	[FieldOffset(Offset = "0x20")]
	public string keyBoardProposal;

	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0x28")]
	public string handleProposal;

	[Token(Token = "0x4002375")]
	[FieldOffset(Offset = "0x30")]
	private string m_CurrentControllerName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002376")]
	public bool isPauseMap;

	[Token(Token = "0x4002377")]
	[FieldOffset(Offset = "0x39")]
	public bool isVibration;

	[Token(Token = "0x4002379")]
	[FieldOffset(Offset = "0x3B")]
	public bool isCustomMouse;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400237A")]
	private string m_CurrentLastActiveController;

	[Token(Token = "0x400237B")]
	[FieldOffset(Offset = "0x48")]
	private InputController m_ControllerType;

	[Token(Token = "0x400237C")]
	[FieldOffset(Offset = "0x50")]
	private EventSystem m_EventSystem;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400237D")]
	private Dictionary<string, bool> m_MapEnables;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400237E")]
	public bool isStopKeyAction;

	[Token(Token = "0x170005A4")]
	public string currentControllerName
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x6003C89")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A5")]
	public bool sendUiEvent
	{
		[Address(RVA = "0x49B590", Offset = "0x499D90", Length = "0x5")]
		[Token(Token = "0x6003C8A")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x75F310", Offset = "0x75DB10", Length = "0x4")]
		[Token(Token = "0x6003C8B")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A6")]
	public InputController controllerType
	{
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		get
		{
			return default(InputController);
		}
	}

	[Token(Token = "0x170005A7")]
	public static Player PLAYER
	{
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x75F2B0", Offset = "0x75DAB0", Length = "0x5F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A8")]
	public bool IsGlobal
	{
		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x75EB60", Offset = "0x75D360", Length = "0x64")]
	[Token(Token = "0x6003C8E")]
	public void SetControllerMapEnable(string categoryName, bool enable)
	{
	}

	[Token(Token = "0x6003C8F")]
	[Address(RVA = "0x75CC20", Offset = "0x75B420", Length = "0x62")]
	public bool GetControllerMapEnable(string categoryName)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C90")]
	[Address(RVA = "0x75EBD0", Offset = "0x75D3D0", Length = "0x264")]
	public void SetController(InputController controller)
	{
	}

	[Token(Token = "0x6003C91")]
	[Address(RVA = "0x75E000", Offset = "0x75C800", Length = "0x113")]
	public void RefreshControllerEnable()
	{
	}

	[Address(RVA = "0x75CD40", Offset = "0x75B540", Length = "0xB4")]
	[Token(Token = "0x6003C92")]
	private void Init()
	{
	}

	[Address(RVA = "0x75DEA0", Offset = "0x75C6A0", Length = "0x154")]
	[Token(Token = "0x6003C93")]
	private void Private_SetUIMapEnable(bool enable, Player.ControllerHelper.MapHelper maps)
	{
	}

	[Address(RVA = "0x75DC20", Offset = "0x75C420", Length = "0x272")]
	[Token(Token = "0x6003C94")]
	private void Private_SetJoystickMapEnable(bool enable, Player.ControllerHelper.MapHelper maps)
	{
	}

	[Address(RVA = "0x75DA10", Offset = "0x75C210", Length = "0x203")]
	[Token(Token = "0x6003C95")]
	private void Private_SetControllerMapEnable(string categoryName, bool enable)
	{
	}

	[Address(RVA = "0x75EF90", Offset = "0x75D790", Length = "0x289")]
	[Token(Token = "0x6003C96")]
	public void UpdateLastActiveInputController()
	{
	}

	[Address(RVA = "0x75D690", Offset = "0x75BE90", Length = "0x12D")]
	[Token(Token = "0x6003C97")]
	public void OnHandleConnet(string battleSceneName, bool isSucceed, bool isDead, bool isPause, bool isTutorial)
	{
	}

	[Address(RVA = "0x75C130", Offset = "0x75A930", Length = "0x179")]
	[Token(Token = "0x6003C98")]
	public void DisableAllControllerAction()
	{
	}

	[Token(Token = "0x6003C99")]
	[Address(RVA = "0x75C400", Offset = "0x75AC00", Length = "0x179")]
	public void EnableAllControllerAction()
	{
	}

	[Token(Token = "0x6003C9A")]
	[Address(RVA = "0x75CC90", Offset = "0x75B490", Length = "0xAA")]
	public bool GetTouchs(List<TouchControl> buffer)
	{
		return default(bool);
	}

	[Address(RVA = "0x75E880", Offset = "0x75D080", Length = "0x15A")]
	[Token(Token = "0x6003C9B")]
	private void SendSubmit()
	{
	}

	[Address(RVA = "0x75C990", Offset = "0x75B190", Length = "0x1C7")]
	[Token(Token = "0x6003C9C")]
	public bool GetButtonUpFromUI(string key)
	{
		return default(bool);
	}

	[Address(RVA = "0x75C6D0", Offset = "0x75AED0", Length = "0x84")]
	[Token(Token = "0x6003C9D")]
	public bool GetButtonDownFromUI(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C9E")]
	[Address(RVA = "0x75C7C0", Offset = "0x75AFC0", Length = "0x1C7")]
	public bool GetButtonFromUI(string key)
	{
		return default(bool);
	}

	[Address(RVA = "0x75C600", Offset = "0x75AE00", Length = "0xC6")]
	[Token(Token = "0x6003C9F")]
	public float GetAxisFromUI(string key)
	{
		return default(float);
	}

	[Token(Token = "0x6003CA0")]
	[Address(RVA = "0x75C760", Offset = "0x75AF60", Length = "0x56")]
	public List<int> GetButtonDown(MDButtonType buttonName)
	{
		return null;
	}

	[Token(Token = "0x6003CA1")]
	[Address(RVA = "0x75CB60", Offset = "0x75B360", Length = "0x56")]
	public List<int> GetButtonUp(MDButtonType buttonName)
	{
		return null;
	}

	[Address(RVA = "0x75CBC0", Offset = "0x75B3C0", Length = "0x56")]
	[Token(Token = "0x6003CA2")]
	public List<int> GetButton(MDButtonType buttonName)
	{
		return null;
	}

	[Address(RVA = "0x75EF30", Offset = "0x75D730", Length = "0x57")]
	[Token(Token = "0x6003CA3")]
	public void SwitchButtonProposal(string name)
	{
	}

	[Token(Token = "0x6003CA4")]
	[Address(RVA = "0x75EE50", Offset = "0x75D650", Length = "0xDA")]
	public void SetNsVibration(VibrationVaule vaule, DeviceHandles handles = DeviceHandles.Both, float time = 0.05f)
	{
	}

	[Address(RVA = "0x75E9E0", Offset = "0x75D1E0", Length = "0x170")]
	[Token(Token = "0x6003CA5")]
	public void SetControllerHandler(IControlable controller, string inputCtrlConfigName, bool updateControl = true)
	{
	}

	[Address(RVA = "0x75D210", Offset = "0x75BA10", Length = "0x2D6")]
	[Token(Token = "0x6003CA6")]
	private void Loop(float time)
	{
	}

	[Token(Token = "0x6003CA7")]
	[Address(RVA = "0x75C3B0", Offset = "0x75ABB0", Length = "0x48")]
	public void Disable()
	{
	}

	[Token(Token = "0x6003CA8")]
	[Address(RVA = "0x75D5D0", Offset = "0x75BDD0", Length = "0xBE")]
	public void OnClickChangeButton(string buttonName, int currentCustomKeyIndex)
	{
	}

	[Token(Token = "0x6003CA9")]
	[Address(RVA = "0x75D4F0", Offset = "0x75BCF0", Length = "0xDB")]
	public void OnChangeSpecialButton(string buttonName, string newKey, string uiName)
	{
	}

	[Token(Token = "0x6003CAA")]
	[Address(RVA = "0x75D8A0", Offset = "0x75C0A0", Length = "0xAA")]
	public void OnSetCustomRepeatList(List<string> list)
	{
	}

	[Token(Token = "0x6003CAB")]
	[Address(RVA = "0x75D7C0", Offset = "0x75BFC0", Length = "0xDC")]
	public void OnSaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration)
	{
	}

	[Address(RVA = "0x75E830", Offset = "0x75D030", Length = "0x48")]
	[Token(Token = "0x6003CAC")]
	public void SaveKeySetAsJson()
	{
	}

	[Token(Token = "0x6003CAD")]
	[Address(RVA = "0x75E1E0", Offset = "0x75C9E0", Length = "0x13B")]
	public bool RewiredGetAnyButton()
	{
		return default(bool);
	}

	[Address(RVA = "0x75E410", Offset = "0x75CC10", Length = "0x156")]
	[Token(Token = "0x6003CAE")]
	public bool RewiredGetButtonDown(string actionName)
	{
		return default(bool);
	}

	[Token(Token = "0x6003CAF")]
	[Address(RVA = "0x75E6D0", Offset = "0x75CED0", Length = "0x156")]
	public bool RewiredGetButton(string actionName)
	{
		return default(bool);
	}

	[Address(RVA = "0x75E570", Offset = "0x75CD70", Length = "0x156")]
	[Token(Token = "0x6003CB0")]
	public bool RewiredGetButtonUp(string actionName)
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB1")]
	[Address(RVA = "0x75E320", Offset = "0x75CB20", Length = "0xEC")]
	public float RewiredGetAxisRaw(string actionName)
	{
		return default(float);
	}

	[Token(Token = "0x6003CB2")]
	[Address(RVA = "0x75CE00", Offset = "0x75B600", Length = "0x1AC")]
	public bool IsConnetShouTai()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB3")]
	[Address(RVA = "0x75CFB0", Offset = "0x75B7B0", Length = "0x250")]
	public bool IsConnetShouTai(out Controller shouTaiController)
	{
		shouTaiController = null;
		return default(bool);
	}

	[Address(RVA = "0x75C070", Offset = "0x75A870", Length = "0xBE")]
	[Token(Token = "0x6003CB4")]
	public bool CheckMouseClickUI()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB5")]
	[Address(RVA = "0x75D950", Offset = "0x75C150", Length = "0xBF")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6003CB6")]
	[Address(RVA = "0x75E120", Offset = "0x75C920", Length = "0xBF")]
	public void Resume()
	{
	}

	[Token(Token = "0x6003CB7")]
	[Address(RVA = "0x75C580", Offset = "0x75AD80", Length = "0x7E")]
	public void EnableInput()
	{
	}

	[Address(RVA = "0x75C2B0", Offset = "0x75AAB0", Length = "0xF8")]
	[Token(Token = "0x6003CB8")]
	public void DisableInput()
	{
	}

	[Address(RVA = "0x75F220", Offset = "0x75DA20", Length = "0x8C")]
	[Token(Token = "0x6003CBA")]
	public InputManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
