using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Interface;

[Token(Token = "0x2000726")]
public interface IInputKeyBinding
{
	[Token(Token = "0x17000634")]
	UISelectManage GetPanelOrder
	{
		[Token(Token = "0x600423A")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000635")]
	bool IsOnCurrentPanel
	{
		[Token(Token = "0x600423B")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x6004239")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetPanelOrder(UISelectManage uiManage);
}
