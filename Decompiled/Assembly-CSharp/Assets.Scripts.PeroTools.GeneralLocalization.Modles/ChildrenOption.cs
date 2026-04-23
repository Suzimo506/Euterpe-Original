using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000665")]
public class ChildrenOption : OptionGeneric<ChildrenSource, Transform>
{
	[Address(RVA = "0x754EA0", Offset = "0x7536A0", Length = "0x266")]
	[Token(Token = "0x6003D57")]
	protected override void OnApply(ChildrenSource source, Localization localization)
	{
	}

	[Address(RVA = "0x755110", Offset = "0x753910", Length = "0x38")]
	[Token(Token = "0x6003D58")]
	public ChildrenOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
