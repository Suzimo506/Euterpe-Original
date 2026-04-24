//Type is in global namespace

public class PnlVictoryTypes
{
	public int index; //Field offset: 0x10
	[SerializeField]
	private string m_Description; //Field offset: 0x18
	public PnlVictoryControls[] controls; //Field offset: 0x20

	public PnlVictoryTypes() { }

	public PnlVictoryControls GetPnlVictoryControls(bool is43) { }

}

