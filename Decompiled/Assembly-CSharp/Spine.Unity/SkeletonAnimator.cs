using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Spine.Unity;

[AttributeAttribute(Name = "RequireComponent", RVA = "0x63170", Offset = "0x62570")]
[Token(Token = "0x20001DB")]
public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
{
	[Serializable]
	[Token(Token = "0x2000A6A")]
	public class MecanimTranslator
	{
		[Token(Token = "0x2000DF7")]
		public enum MixMode
		{
			[Token(Token = "0x4004130")]
			AlwaysMix,
			[Token(Token = "0x4004131")]
			MixNext,
			[Token(Token = "0x4004132")]
			SpineStyle
		}

		[Token(Token = "0x2000DF8")]
		private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
		{
			[Token(Token = "0x4004133")]
			internal static readonly IEqualityComparer<AnimationClip> Instance;

			[Address(RVA = "0x509270", Offset = "0x507A70", Length = "0x45")]
			[Token(Token = "0x60066AA")]
			public bool Equals(AnimationClip x, AnimationClip y)
			{
				return default(bool);
			}

			[Token(Token = "0x60066AB")]
			[Address(RVA = "0x5092C0", Offset = "0x507AC0", Length = "0x1F")]
			public int GetHashCode(AnimationClip o)
			{
				return default(int);
			}

			[Token(Token = "0x60066AC")]
			[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
			public AnimationClipEqualityComparer()
			{
			}
		}

		[Token(Token = "0x2000DF9")]
		private class IntEqualityComparer : IEqualityComparer<int>
		{
			[Token(Token = "0x4004134")]
			internal static readonly IEqualityComparer<int> Instance;

			[Token(Token = "0x60066AE")]
			[Address(RVA = "0x50A720", Offset = "0x508F20", Length = "0x7")]
			public bool Equals(int x, int y)
			{
				return default(bool);
			}

			[Token(Token = "0x60066AF")]
			[Address(RVA = "0x43FFC0", Offset = "0x43E7C0", Length = "0x3")]
			public int GetHashCode(int o)
			{
				return default(int);
			}

			[Token(Token = "0x60066B0")]
			[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
			public IntEqualityComparer()
			{
			}
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40036F3")]
		public bool autoReset;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40036F4")]
		public MixMode[] layerMixModes;

		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, Animation> animationTable;

		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable;

		[Token(Token = "0x40036F7")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Animation> previousAnimations;

		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<AnimatorClipInfo> clipInfoCache;

		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<AnimatorClipInfo> nextClipInfoCache;

		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x17000986")]
		public Animator Animator
		{
			[Token(Token = "0x60059B3")]
			[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x623DC0", Offset = "0x6225C0", Length = "0x18E")]
		public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset)
		{
		}

		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x622D00", Offset = "0x621500", Length = "0xF63")]
		public void Apply(Skeleton skeleton)
		{
		}

		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x622CB0", Offset = "0x6214B0", Length = "0x4F")]
		private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed)
		{
			return default(float);
		}

		[Address(RVA = "0x622C80", Offset = "0x621480", Length = "0x2C")]
		[Token(Token = "0x60059B7")]
		private static float AnimationTime(float normalizedTime, float clipLength, bool reversed)
		{
			return default(float);
		}

		[Address(RVA = "0x623C70", Offset = "0x622470", Length = "0x145")]
		[Token(Token = "0x60059B8")]
		private void GetAnimatorClipInfos(int layer, out int clipInfoCount, out int nextClipInfoCount, out IList<AnimatorClipInfo> clipInfo, out IList<AnimatorClipInfo> nextClipInfo)
		{
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref clipInfoCount) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref nextClipInfoCount) = null;
			clipInfo = null;
			nextClipInfo = null;
		}

		[Address(RVA = "0x623F50", Offset = "0x622750", Length = "0xAF")]
		[Token(Token = "0x60059B9")]
		private int NameHashCode(AnimationClip clip)
		{
			return default(int);
		}

		[Address(RVA = "0x624000", Offset = "0x622800", Length = "0x1B2")]
		[Token(Token = "0x60059BA")]
		public MecanimTranslator()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0xE0")]
	protected MecanimTranslator translator;

	[Token(Token = "0x170000FC")]
	public MecanimTranslator Translator
	{
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x48E510", Offset = "0x48CD10", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400000F")]
	protected event UpdateBonesDelegate _UpdateLocal
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x62EAC0", Offset = "0x62D2C0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x62ECA0", Offset = "0x62D4A0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	protected event UpdateBonesDelegate _UpdateWorld
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x62EB60", Offset = "0x62D360", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x62ED40", Offset = "0x62D540", Length = "0x9E")]
		[Token(Token = "0x6000D75")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	protected event UpdateBonesDelegate _UpdateComplete
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x62EA20", Offset = "0x62D220", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x62EC00", Offset = "0x62D400", Length = "0x9E")]
		[Token(Token = "0x6000D77")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event UpdateBonesDelegate UpdateLocal
	{
		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x62EAC0", Offset = "0x62D2C0", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x62ECA0", Offset = "0x62D4A0", Length = "0x9E")]
		[Token(Token = "0x6000D79")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public event UpdateBonesDelegate UpdateWorld
	{
		[Address(RVA = "0x62EB60", Offset = "0x62D360", Length = "0x9E")]
		[Token(Token = "0x6000D7A")]
		add
		{
		}
		[Address(RVA = "0x62ED40", Offset = "0x62D540", Length = "0x9E")]
		[Token(Token = "0x6000D7B")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public event UpdateBonesDelegate UpdateComplete
	{
		[Address(RVA = "0x62EA20", Offset = "0x62D220", Length = "0x9E")]
		[Token(Token = "0x6000D7C")]
		add
		{
		}
		[Address(RVA = "0x62EC00", Offset = "0x62D400", Length = "0x9E")]
		[Token(Token = "0x6000D7D")]
		remove
		{
		}
	}

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x62E680", Offset = "0x62CE80", Length = "0x276")]
	public override void Initialize(bool overwrite)
	{
	}

	[Address(RVA = "0x62E900", Offset = "0x62D100", Length = "0xB0")]
	[Token(Token = "0x6000D7F")]
	public void Update()
	{
	}

	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x62E9C0", Offset = "0x62D1C0", Length = "0x51")]
	public SkeletonAnimator()
	{
	}
}
