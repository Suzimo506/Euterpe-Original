namespace FormulaBase;

public class TnoDefaultComparable : IComparer<TimeNodeOrder>
{
	public bool easySort; //Field offset: 0x10

	public TnoDefaultComparable() { }

	public override int Compare(TimeNodeOrder l, TimeNodeOrder r) { }

	private int CompareByTick(TimeNodeOrder l, TimeNodeOrder r) { }

}

