namespace Assets.Scripts.Structs;

public struct FsvCompsFromUi
{
	public Color enableBtnColor; //Field offset: 0x0
	public Color disableBtnColor; //Field offset: 0x10
	public Color enableBgColor; //Field offset: 0x20
	public Color disableBgColor; //Field offset: 0x30
	public FancyScrollView fsv; //Field offset: 0x40
	public Button prevBtn; //Field offset: 0x48
	public Button nextBtn; //Field offset: 0x50
	public Image fsvBackground; //Field offset: 0x58
	private bool m_Enable; //Field offset: 0x60

	public void ToggleColor(bool enable) { }

}

