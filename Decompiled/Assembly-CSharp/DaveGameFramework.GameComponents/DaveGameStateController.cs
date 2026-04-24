using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DaveGameFramework.GameComponents.AnimaControl;
using DaveGameFramework.GameInstanceData;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C6")]
public class DaveGameStateController
{
	[Token(Token = "0x170004E9")]
	public bool IsAutoPlay
	{
		[CompilerGenerated]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6003582")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		[Token(Token = "0x6003583")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004EA")]
	public DaveGameCharacter CharacterTurn
	{
		[CompilerGenerated]
		[Token(Token = "0x6003584")]
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		get
		{
			return default(DaveGameCharacter);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003585")]
		[Address(RVA = "0x494A20", Offset = "0x493220", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170004EB")]
	public DaveGameFlowState GameState
	{
		[CompilerGenerated]
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		get
		{
			return default(DaveGameFlowState);
		}
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		[Token(Token = "0x6003587")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004EC")]
	public DaveGameConfigData ConfigData
	{
		[Address(RVA = "0x7322C0", Offset = "0x730AC0", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6003588")]
		get
		{
			return default(DaveGameConfigData);
		}
		[Address(RVA = "0x99A850", Offset = "0x999050", Length = "0x11")]
		[Token(Token = "0x6003589")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004ED")]
	public DaveGameFishHandleState BuroFishHandleState
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x600358A")]
		[CompilerGenerated]
		get
		{
			return default(DaveGameFishHandleState);
		}
		[Address(RVA = "0x99A840", Offset = "0x999040", Length = "0x5")]
		[Token(Token = "0x600358B")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004EE")]
	public DaveGameFishHandleState BanjoFishHandleState
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x600358C")]
		[CompilerGenerated]
		get
		{
			return default(DaveGameFishHandleState);
		}
		[Address(RVA = "0x882210", Offset = "0x880A10", Length = "0x5")]
		[Token(Token = "0x600358D")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004EF")]
	public Dictionary<string, List<DaveGameNoteData>> BanjoFishHandleResults
	{
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F0")]
	public Dictionary<string, List<DaveGameNoteData>> BuroFishHandleResults
	{
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		[Token(Token = "0x600358F")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F1")]
	public Dictionary<string, float> FishHandleComparedResults
	{
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		[Token(Token = "0x6003590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F2")]
	public DaveGameResultData GameResultData
	{
		[CompilerGenerated]
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x51B9E0", Offset = "0x51A1E0", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Address(RVA = "0x99A670", Offset = "0x998E70", Length = "0xB8")]
	[Token(Token = "0x6003593")]
	public void ResetGameState()
	{
	}

	[Token(Token = "0x6003594")]
	[Address(RVA = "0x99A120", Offset = "0x998920", Length = "0x15D")]
	public void AddBanjoFishHandleResult(FishType fishType, DishType dishType, DaveGameNoteData noteData)
	{
	}

	[Token(Token = "0x6003595")]
	[Address(RVA = "0x99A280", Offset = "0x998A80", Length = "0x15D")]
	public void AddBuroFishHandleResult(FishType fishType, DishType dishType, DaveGameNoteData noteData)
	{
	}

	[Token(Token = "0x6003596")]
	[Address(RVA = "0x99A3E0", Offset = "0x998BE0", Length = "0x28B")]
	public float GetFishHandleComparedResult(string fishKey)
	{
		return default(float);
	}

	[Address(RVA = "0x99A730", Offset = "0x998F30", Length = "0x101")]
	[Token(Token = "0x6003597")]
	public DaveGameStateController()
	{
	}
}
