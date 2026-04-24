//Type is in global namespace

public class VisDataContainer
{
	public float average; //Field offset: 0x10
	public float previousAverage; //Field offset: 0x14
	public float averageDifference; //Field offset: 0x18
	public float median; //Field offset: 0x1C
	public float previousMedian; //Field offset: 0x20
	public float medianDifference; //Field offset: 0x24
	public float sum; //Field offset: 0x28
	public float previousSum; //Field offset: 0x2C
	public float sumDifference; //Field offset: 0x30
	public float minimum; //Field offset: 0x34
	public float previousMinimum; //Field offset: 0x38
	public float minimumDifference; //Field offset: 0x3C
	public float maximum; //Field offset: 0x40
	public float previousMaximum; //Field offset: 0x44
	public float maximumDifference; //Field offset: 0x48

	public VisDataContainer() { }

	public void ApplyBoostAndCutoff(float boost, float cutoff) { }

	public float GetPreviousValue(VisDataValueType valueType) { }

	public float GetValue(VisDataValueType valueType) { }

	public float GetValueDifference(VisDataValueType valueType) { }

	public void ResetCurrentValues() { }

	public void UpdatePreviousValues() { }

	public void UpdateValueDifferences() { }

}

