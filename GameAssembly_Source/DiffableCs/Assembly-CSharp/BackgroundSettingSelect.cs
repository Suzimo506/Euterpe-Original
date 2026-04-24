//Type is in global namespace

public class BackgroundSettingSelect : UISelectManage
{
	public FancyScrollView imgFsv; //Field offset: 0x110
	public Slider darkSlider; //Field offset: 0x118
	public GameObject darkBtnNext; //Field offset: 0x120
	public GameObject darkBtnPrevious; //Field offset: 0x128
	public Color highLight; //Field offset: 0x130
	public Color normal; //Field offset: 0x140
	public List<Image> sceneBgList; //Field offset: 0x150
	private int m_ImgFsvIndex; //Field offset: 0x158
	private PointsBar m_Bar; //Field offset: 0x160
	[SerializeField]
	private UISetColor[] m_UiSetColors; //Field offset: 0x168

	public BackgroundSettingSelect() { }

	[CompilerGenerated]
	private void <OnInit>b__10_0() { }

	[CompilerGenerated]
	private void <OnInit>b__10_1() { }

	public virtual GameObject DefaultSelectObj() { }

	private void OnImgFsvChange(int i) { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

