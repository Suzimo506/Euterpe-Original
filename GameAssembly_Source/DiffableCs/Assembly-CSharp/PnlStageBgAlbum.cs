//Type is in global namespace

public class PnlStageBgAlbum : MonoBehaviour
{
	internal enum TipText
	{
		None = 0,
		NotJustAsPlaned = 1,
		WeekFree = 2,
	}

	public GameObject needJustAsPlaned; //Field offset: 0x18
	public GameObject weekFree; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28

	public PnlStageBgAlbum() { }

	public void OnBgOutFinish() { }

	private void PlayAnimator(bool isIn) { }

	public void SetBgEnable(bool enable, TipText txt = 0) { }

}

