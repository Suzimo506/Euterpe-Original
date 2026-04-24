//Type is in global namespace

public class ImgSaveSelect : BaseMessageBox
{
	public Text path; //Field offset: 0xD8
	public InputKeyBinding iiusCheckExitBtnCancel; //Field offset: 0xE0

	public ImgSaveSelect() { }

	public virtual void Close(bool disablePrevPopup = false) { }

	public virtual void Show() { }

}

