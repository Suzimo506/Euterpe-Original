namespace Assets.Scripts.UI.Controls;

public class RankCell : MonoBehaviour
{
	public Text txtNumber; //Field offset: 0x18
	public Text txtPlayerName; //Field offset: 0x20
	public Text txtScore; //Field offset: 0x28
	public Text txtAcc; //Field offset: 0x30

	public RankCell() { }

	public void SetValue(int number, string nickName, int score, float acc) { }

}

