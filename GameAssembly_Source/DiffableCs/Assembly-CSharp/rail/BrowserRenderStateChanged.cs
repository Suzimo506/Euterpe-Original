namespace rail;

public class BrowserRenderStateChanged : EventBase
{
	public bool can_go_back; //Field offset: 0x30
	public bool can_go_forward; //Field offset: 0x31

	public BrowserRenderStateChanged() { }

}

