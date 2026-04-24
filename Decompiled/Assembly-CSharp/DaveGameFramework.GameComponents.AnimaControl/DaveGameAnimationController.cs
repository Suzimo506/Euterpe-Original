using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using MEC;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace DaveGameFramework.GameComponents.AnimaControl;

[Token(Token = "0x20004D3")]
public class DaveGameAnimationController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A49")]
	[SerializeField]
	private SkeletonAnimation m_Bg;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A4A")]
	[SerializeField]
	private SkeletonAnimation m_Buro;

	[Token(Token = "0x4001A4B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SkeletonAnimation m_BuroDish;

	[Token(Token = "0x4001A4C")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private SkeletonAnimation m_Banjo;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A4D")]
	[SerializeField]
	private SkeletonAnimation m_BanjoDish;

	[Token(Token = "0x4001A4E")]
	[FieldOffset(Offset = "0x40")]
	private CoroutineHandle m_BanjoHandle;

	[Token(Token = "0x4001A4F")]
	[FieldOffset(Offset = "0x44")]
	private CoroutineHandle m_BuroHandle;

	[Token(Token = "0x170004F9")]
	public bool IsBuroActing
	{
		[CompilerGenerated]
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x5B0970", Offset = "0x5AF170", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x566160", Offset = "0x564960", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x60035EB")]
	[Address(RVA = "0x9956B0", Offset = "0x993EB0", Length = "0x5E")]
	public void PlayBgAnimation()
	{
	}

	[Address(RVA = "0x9955C0", Offset = "0x993DC0", Length = "0xEF")]
	[Token(Token = "0x60035EC")]
	public void Pause()
	{
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x997140", Offset = "0x995940", Length = "0x105")]
	public void Resume()
	{
	}

	[Address(RVA = "0x996F60", Offset = "0x995760", Length = "0x1D4")]
	[Token(Token = "0x60035EE")]
	public void Reset()
	{
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0x995910", Offset = "0x994110", Length = "0x195")]
	public void PlayDefaultAnimation(DaveGameCharacter character, bool forceDefault = false)
	{
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x996CF0", Offset = "0x9954F0", Length = "0xE5")]
	public TrackEntry PlayHitPreparingAnimation(DaveGameCharacter character)
	{
		return null;
	}

	[Address(RVA = "0x996B20", Offset = "0x995320", Length = "0x1CE")]
	[Token(Token = "0x60035F3")]
	public void PlayHeavyHitReadyAnimation(DaveGameCharacter character, float canActDelayTime = 0f)
	{
	}

	[Token(Token = "0x60035F4")]
	[Address(RVA = "0x996A00", Offset = "0x995200", Length = "0x11C")]
	public void PlayHeavyHitAnimation(DaveGameCharacter character, bool isEmptyHit = false)
	{
	}

	[Token(Token = "0x60035F5")]
	[Address(RVA = "0x995E20", Offset = "0x994620", Length = "0x183")]
	public void PlayEmptyHitAnimation(DaveGameCharacter character)
	{
	}

	[Token(Token = "0x60035F6")]
	[Address(RVA = "0x996DE0", Offset = "0x9955E0", Length = "0x175")]
	public void PlayLightHitAnimation(DaveGameCharacter character, Action<DaveGameCharacter, int> onHit = null, bool isEmptyHit = false)
	{
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0x995710", Offset = "0x993F10", Length = "0x176")]
	public void PlayCharacterFinishAnimation(DaveGameCharacter character, string resultPrefix, string actPrefix = "")
	{
	}

	[Address(RVA = "0x995890", Offset = "0x994090", Length = "0x7D")]
	[Token(Token = "0x60035F8")]
	public void PlayCustomerRankAnimation(string resultPrefix)
	{
	}

	[Address(RVA = "0x995FB0", Offset = "0x9947B0", Length = "0x524")]
	[Token(Token = "0x60035F9")]
	public void PlayFishAnimation(DaveGameCharacter character, FishType fishType, DishType dishType, string actionPrefix)
	{
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0x995AB0", Offset = "0x9942B0", Length = "0x36E")]
	public void PlayDishFinishAnimation(DaveGameCharacter character, DishType dishType)
	{
	}

	[Address(RVA = "0x9964E0", Offset = "0x994CE0", Length = "0x51D")]
	[Token(Token = "0x60035FB")]
	public void PlayFishFinishAnimation(DaveGameCharacter character, FishType fishType, DishType dishType, string result)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60035FC")]
	public DaveGameAnimationController()
	{
	}
}
