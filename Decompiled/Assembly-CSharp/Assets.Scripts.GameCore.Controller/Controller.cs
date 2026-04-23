using System.Collections.Generic;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine.InputSystem.Controls;

namespace Assets.Scripts.GameCore.Controller;

[Token(Token = "0x2000775")]
public abstract class Controller<T> : IControlable where T : ControllerConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4002773")]
	public T configs;

	[Token(Token = "0x60045E0")]
	[Address(RVA = "0x135C0A0", Offset = "0x135A8A0", Length = "0x3C")]
	public void Init(string path)
	{
	}

	[Token(Token = "0x60045E1")]
	[Address(RVA = "0x135C0E0", Offset = "0x135A8E0", Length = "0x9B")]
	public virtual void LoadAssets(string fileName)
	{
	}

	[Token(Token = "0x60045E2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnInit()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60045E3")]
	public virtual void OnDisableController()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60045E4")]
	public abstract List<int> GetButtonDown(MDButtonType buttonName);

	[Token(Token = "0x60045E5")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract List<int> GetButtonUp(MDButtonType buttonName);

	[Token(Token = "0x60045E6")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract List<int> GetButton(MDButtonType buttonName);

	[Token(Token = "0x60045E7")]
	[Address(RVA = "0x135BF60", Offset = "0x135A760", Length = "0x13D")]
	public virtual bool GetTouchs(List<TouchControl> buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x60045E8")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public virtual bool GetButtonDownFromUI(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x60045E9")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public virtual bool GetButtonFromUI(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x60045EA")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public virtual bool GetButtonUpFromUI(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x60045EB")]
	[Address(RVA = "0x73A090", Offset = "0x738890", Length = "0x4")]
	public virtual float GetAxisFromUI(string axisName)
	{
		return default(float);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60045EC")]
	public virtual void SwitchProposal(string proposalName)
	{
	}

	[Token(Token = "0x60045ED")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void CustomButton(string buttonName, string key)
	{
	}

	[Token(Token = "0x60045EE")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void SetVibration(VibrationVaule vaule, DeviceHandles handles, float time)
	{
	}

	[Token(Token = "0x60045EF")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnClickChangeButton(string buttonName, int currentCustomKeyIndex)
	{
	}

	[Token(Token = "0x60045F0")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnClickChangeButton(string buttonName)
	{
	}

	[Token(Token = "0x60045F1")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void UpdateRepeatList(List<string> list)
	{
	}

	[Token(Token = "0x60045F2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void SaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration)
	{
	}

	[Token(Token = "0x60045F3")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void ChangeButton(string buttonName, string newKey, string uiName)
	{
	}

	[Token(Token = "0x60045F4")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void SaveKeyDataAsJson()
	{
	}

	[Token(Token = "0x60045F5")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract bool GetButtonProposal(MDButtonType buttonName);

	[Token(Token = "0x60045F6")]
	[Address(RVA = "0xC25360", Offset = "0xC23B60", Length = "0x19")]
	protected Controller()
	{
	}
}
