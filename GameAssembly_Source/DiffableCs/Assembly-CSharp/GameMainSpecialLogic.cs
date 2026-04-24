//Type is in global namespace

public class GameMainSpecialLogic : MonoBehaviour, IPreWarm
{
	public ReplaceTools[] badAppleReplaces; //Field offset: 0x18

	public GameMainSpecialLogic() { }

	private void BadAppleLogic() { }

	public override void PreWarm(int slice) { }

}

