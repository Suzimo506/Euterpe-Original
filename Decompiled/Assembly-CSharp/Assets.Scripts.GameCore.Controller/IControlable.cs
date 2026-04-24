using System.Collections.Generic;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine.InputSystem.Controls;

namespace Assets.Scripts.GameCore.Controller;

[Token(Token = "0x2000773")]
public interface IControlable
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045CC")]
	void Init(string path);

	[Token(Token = "0x60045CD")]
	[Address(RVA = "0x0", Length = "0x0")]
	List<int> GetButtonDown(MDButtonType buttonType);

	[Token(Token = "0x60045CE")]
	[Address(RVA = "0x0", Length = "0x0")]
	List<int> GetButtonUp(MDButtonType buttonName);

	[Token(Token = "0x60045CF")]
	[Address(RVA = "0x0", Length = "0x0")]
	List<int> GetButton(MDButtonType buttonName);

	[Token(Token = "0x60045D0")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetTouchs(List<TouchControl> buffer);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045D1")]
	bool GetButtonDownFromUI(string keyName);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045D2")]
	bool GetButtonFromUI(string keyName);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045D3")]
	bool GetButtonUpFromUI(string keyName);

	[Token(Token = "0x60045D4")]
	[Address(RVA = "0x0", Length = "0x0")]
	float GetAxisFromUI(string axisName);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045D5")]
	void SwitchProposal(string proposalName);

	[Token(Token = "0x60045D6")]
	[Address(RVA = "0x0", Length = "0x0")]
	void CustomButton(string buttonName, string key);

	[Token(Token = "0x60045D7")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetVibration(VibrationVaule vaule, DeviceHandles handles, float time);

	[Token(Token = "0x60045D8")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnClickChangeButton(string buttonName, int currentCustomKeyIndex);

	[Token(Token = "0x60045D9")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnClickChangeButton(string buttonName);

	[Token(Token = "0x60045DA")]
	[Address(RVA = "0x0", Length = "0x0")]
	void UpdateRepeatList(List<string> list);

	[Token(Token = "0x60045DB")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnDisableController();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045DC")]
	void SaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration);

	[Token(Token = "0x60045DD")]
	[Address(RVA = "0x0", Length = "0x0")]
	void ChangeButton(string buttonName, string newKey, string uiName);

	[Token(Token = "0x60045DE")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SaveKeyDataAsJson();
}
