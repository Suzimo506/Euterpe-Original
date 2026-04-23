using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200017E")]
public class FoolishAdvertiseMusicController : FoolishAdvertiseController
{
	[SerializeField]
	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x40")]
	private Button m_BtnFirst;

	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x44F3C0", Offset = "0x44DBC0", Length = "0x89")]
	private void Start()
	{
	}

	[Address(RVA = "0x44F350", Offset = "0x44DB50", Length = "0x63")]
	[Token(Token = "0x6000AF2")]
	private void ShowCloseBtn()
	{
	}

	[Address(RVA = "0x44F300", Offset = "0x44DB00", Length = "0x4B")]
	[Token(Token = "0x6000AF3")]
	protected override void OnBtnJumpClicked()
	{
	}

	[Address(RVA = "0x442320", Offset = "0x440B20", Length = "0x2F")]
	[Token(Token = "0x6000AF4")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000AF5")]
	public FoolishAdvertiseMusicController()
	{
	}
}
