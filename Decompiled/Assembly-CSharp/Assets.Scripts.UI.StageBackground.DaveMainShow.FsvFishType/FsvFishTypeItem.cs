using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow.FsvFishType;

[Token(Token = "0x2000846")]
public class FsvFishTypeItem : FancyCell<FishTypeItemData, FsvFishTypeContext>
{
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002B34")]
	private Text m_fishTypeName;

	[Token(Token = "0x4002B35")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_Animator;

	[Token(Token = "0x4002B36")]
	[FieldOffset(Offset = "0x38")]
	private float m_CurPosition;

	[Address(RVA = "0x60F7F0", Offset = "0x60DFF0", Length = "0x47")]
	[Token(Token = "0x6004C0C")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6004C0D")]
	[Address(RVA = "0x60F860", Offset = "0x60E060", Length = "0x43")]
	public override void UpdateContent(FishTypeItemData itemData)
	{
	}

	[Token(Token = "0x6004C0E")]
	[Address(RVA = "0x60F8B0", Offset = "0x60E0B0", Length = "0xCC")]
	public override void UpdatePosition(float position)
	{
	}

	[Token(Token = "0x6004C0F")]
	[Address(RVA = "0x60F840", Offset = "0x60E040", Length = "0x16")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004C10")]
	[Address(RVA = "0x60F980", Offset = "0x60E180", Length = "0x38")]
	public FsvFishTypeItem()
	{
		((FancyCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
