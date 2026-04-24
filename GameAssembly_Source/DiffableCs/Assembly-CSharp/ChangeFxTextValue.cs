//Type is in global namespace

public class ChangeFxTextValue : MonoBehaviour
{
	internal enum FxType
	{
		Hp = 0,
		Hurt = 1,
		Score = 2,
	}

	public FxType fxType; //Field offset: 0x18

	public ChangeFxTextValue() { }

	private void OnEnable() { }

}

