using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using GameLogic;
using Spine.Unity;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl;

[AttributeAttribute(Name = "RequireComponent", RVA = "0x454A0", Offset = "0x448A0")]
[Token(Token = "0x200048B")]
public class SubSpineController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000B3D")]
	private class SkeletionActionInfos
	{
		[Token(Token = "0x40039B6")]
		[FieldOffset(Offset = "0x10")]
		public SerializedSkeletionActionData actionData;

		[Address(RVA = "0x849D50", Offset = "0x848550", Length = "0xF5")]
		[Token(Token = "0x6005D96")]
		private string GetStateStr()
		{
			return null;
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005D97")]
		public SkeletionActionInfos()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000B3E")]
	private class SerializedSkeletionActionData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40039B7")]
		public string name;

		[Token(Token = "0x40039B8")]
		[FieldOffset(Offset = "0x18")]
		public bool isEndLoop;

		[FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45790", Offset = "0x44B90")]
		[Token(Token = "0x40039B9")]
		public bool isAllowListenMainEvents;

		[Token(Token = "0x40039BA")]
		[FieldOffset(Offset = "0x1A")]
		public bool dontChangeActionWhenOnAir;

		[FieldOffset(Offset = "0x1B")]
		[Token(Token = "0x40039BB")]
		public bool playAnimatorState;

		[Token(Token = "0x40039BC")]
		[FieldOffset(Offset = "0x1C")]
		public bool playEndActionAnimatorState;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40039BD")]
		public int animatorControllerLevel;

		[Token(Token = "0x40039BE")]
		[FieldOffset(Offset = "0x28")]
		public string[] actionIdx;

		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46B80", Offset = "0x45F80")]
		[Token(Token = "0x40039BF")]
		[FieldOffset(Offset = "0x30")]
		public string[] mainActionIdxsInSub;

		[Token(Token = "0x40039C0")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D50", Offset = "0x46150")]
		public string[] actionEventStr;

		[Token(Token = "0x40039C1")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public SkeletonAnimation skeletonAnimation;

		[Token(Token = "0x17000A67")]
		private string[] ActionStateDes
		{
			[Address(RVA = "0x849C90", Offset = "0x848490", Length = "0x57")]
			[Token(Token = "0x6005D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A68")]
		private string[] SpineEndEventDes
		{
			[Address(RVA = "0x849CF0", Offset = "0x8484F0", Length = "0x57")]
			[Token(Token = "0x6005D99")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D9A")]
		[Address(RVA = "0x8498A0", Offset = "0x8480A0", Length = "0x134")]
		public int[] ConvertEventStrToIntArray()
		{
			return null;
		}

		[Token(Token = "0x6005D9B")]
		[Address(RVA = "0x849B10", Offset = "0x848310", Length = "0x173")]
		public void Release()
		{
		}

		[Address(RVA = "0x8499E0", Offset = "0x8481E0", Length = "0x125")]
		[Token(Token = "0x6005D9C")]
		private List<string> GetAnimationStrList()
		{
			return null;
		}

		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public SerializedSkeletionActionData()
		{
		}
	}

	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SkeletionActionInfos[] m_SerializedActionDatas;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400188F")]
	private SpineActionController m_SpineController;

	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, DoNothing> m_ActionAfterSkAnimation;

	[Token(Token = "0x60033F2")]
	[Address(RVA = "0x84A160", Offset = "0x848960", Length = "0x47")]
	private void Awake()
	{
	}

	[Address(RVA = "0x84A1B0", Offset = "0x8489B0", Length = "0x26")]
	[Token(Token = "0x60033F3")]
	public void Init()
	{
	}

	[Address(RVA = "0x84A2F0", Offset = "0x848AF0", Length = "0x1FF")]
	[Token(Token = "0x60033F4")]
	public void PlaySubAction(int subCtrlIndex)
	{
	}

	[Address(RVA = "0x84A1E0", Offset = "0x8489E0", Length = "0x100")]
	[Token(Token = "0x60033F5")]
	public void PlaySubActionSelf(string actionState, Action actComplete = null, bool isAllowAnimator = true)
	{
	}

	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x84A4F0", Offset = "0x848CF0", Length = "0x369")]
	private void PlaySubAnimation(SpineActionController mainRoleSpineCtrl, SkeletionActionInfos actionInfo)
	{
	}

	[Token(Token = "0x60033F7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SubSpineController()
	{
	}
}
