//Type is in global namespace

public sealed class VisSubDataGroup : VisDataContainer
{
	public int frequencyRangeStartIndex; //Field offset: 0x50
	public int frequencyRangeEndIndex; //Field offset: 0x54

	public VisSubDataGroup(int startIndex, int endIndex) { }

	public void Update(Single[] spectrum) { }

}

