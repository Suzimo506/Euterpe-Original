using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x200082F")]
public class PnlStageBackgroundJumpToPurchase : BaseMessageBox
{
	[Token(Token = "0x4002AA0")]
	[FieldOffset(Offset = "0xF0")]
	private StageBackgroundData m_Data;

	[Token(Token = "0x4002AA1")]
	[FieldOffset(Offset = "0xF8")]
	private DBConfigAlbums m_ConfigAlbums;

	[Token(Token = "0x4002AA2")]
	[FieldOffset(Offset = "0x100")]
	private UISelectManage m_UISelectManage;

	[Address(RVA = "0x6154A0", Offset = "0x613CA0", Length = "0x4A")]
	[Token(Token = "0x6004B52")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004B53")]
	[Address(RVA = "0x615930", Offset = "0x614130", Length = "0x3B")]
	public void ShowTip(StageBackgroundData bgData)
	{
	}

	[Address(RVA = "0x6156E0", Offset = "0x613EE0", Length = "0x245")]
	[Token(Token = "0x6004B54")]
	private void RendDatasToUI()
	{
	}

	[Token(Token = "0x6004B55")]
	[Address(RVA = "0x6155C0", Offset = "0x613DC0", Length = "0x119")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x6154F0", Offset = "0x613CF0", Length = "0xCB")]
	[Token(Token = "0x6004B56")]
	private void OnClickJumpToPurchase()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x6004B57")]
	public PnlStageBackgroundJumpToPurchase()
	{
	}
}
