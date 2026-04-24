namespace Assets.Scripts.UI;

public class MuseShowLocalization : MonoBehaviour, IPreWarm
{
	public MuseShow Res16_9; //Field offset: 0x18
	public MuseShow Res4_3; //Field offset: 0x20

	public MuseShowLocalization() { }

	public override void PreWarm(int slice) { }

}

