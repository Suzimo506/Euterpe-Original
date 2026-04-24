//Type is in global namespace

public class PnlArtistWebsiteAsk : BaseMessageBox
{
	public Text messageInfo; //Field offset: 0xD8
	public String[] localization; //Field offset: 0xE0
	private bool m_ClickArtist2; //Field offset: 0xE8
	private string m_Url; //Field offset: 0xF0

	public bool clickArtist2
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public PnlArtistWebsiteAsk() { }

	public bool get_clickArtist2() { }

	private void OnEnable() { }

	protected virtual void OnYesClicked() { }

	public void set_clickArtist2(bool value) { }

}

