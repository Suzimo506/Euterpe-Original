using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200014B")]
public class PnlElfinSelect : UISelectManage
{
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x118")]
	public ElfinGridView elfinGridView;

	[Address(RVA = "0x4FF200", Offset = "0x4FDA00", Length = "0x7A")]
	[Token(Token = "0x600094B")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x4FF180", Offset = "0x4FD980", Length = "0x7A")]
	[Token(Token = "0x600094C")]
	public void EnablePanelAndSelectFirst()
	{
	}

	[Address(RVA = "0x4FF100", Offset = "0x4FD900", Length = "0x76")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x28EC0", Offset = "0x282C0")]
	[Token(Token = "0x600094D")]
	private IEnumerator DelayOneFrameRefreshSelectedObj(bool selectedFirst = false)
	{
		return null;
	}

	[Address(RVA = "0x4FF330", Offset = "0x4FDB30", Length = "0x3A6")]
	[Token(Token = "0x600094E")]
	private void RefreshSelectedObj(List<GameObject> objs, bool selectedFirst = false)
	{
	}

	[Address(RVA = "0x4FF280", Offset = "0x4FDA80", Length = "0xAD")]
	[Token(Token = "0x600094F")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlElfinSelect()
	{
	}
}
