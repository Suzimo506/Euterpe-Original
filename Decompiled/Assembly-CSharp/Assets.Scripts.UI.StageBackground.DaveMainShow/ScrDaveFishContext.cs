using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x2000841")]
public class ScrDaveFishContext : BaseScrollViewContext<ScrDaveFishData>
{
	[Token(Token = "0x4002B27")]
	[FieldOffset(Offset = "0x60")]
	public Func<string, Sprite> GetFishImg;

	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x68")]
	public List<FishAlignmentType> FishAlignmentTypeList;

	[Token(Token = "0x1700084D")]
	public DaveFishDataModel DaveFishDataModel
	{
		[CompilerGenerated]
		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004BED")]
		[Address(RVA = "0x51B9F0", Offset = "0x51A1F0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700084E")]
	public PnlDaveFishView DaveFishView
	{
		[CompilerGenerated]
		[Token(Token = "0x6004BEE")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0x51B9E0", Offset = "0x51A1E0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6004BF0")]
	[Address(RVA = "0x61A820", Offset = "0x619020", Length = "0x71")]
	public ScrDaveFishContext()
	{
		((BaseScrollViewContext<>)(object)this)._002Ector();
	}
}
