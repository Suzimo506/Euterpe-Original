namespace UI.Panels;

public class PnlRankScrollRect : ReuseScorllRect
{
	private JToken m_Token; //Field offset: 0x70
	public float axisSpeed; //Field offset: 0x78
	public string axisName; //Field offset: 0x80

	public PnlRankScrollRect() { }

	public virtual void OnUpdate() { }

	public virtual void SetCell(GameObject obj, int index) { }

	public void SetToken(JToken t) { }

}

