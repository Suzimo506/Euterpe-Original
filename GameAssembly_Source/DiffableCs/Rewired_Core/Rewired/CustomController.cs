namespace Rewired;

public sealed class CustomController : ControllerWithAxes
{
	private int pFxBJplYRVEEamkTDQZQkSuFEMbL; //Field offset: 0x158
	private Func<Int32, Single> IhjfbJrhyFjIyOzywwNQBnajPIKG; //Field offset: 0x160
	private Func<Int32, Boolean> sVBAuAWHEGaiPKmchOdugfqmfeRZ; //Field offset: 0x168
	private bool bisgSaPvoYbFxjlNuMXxGTjalLinb; //Field offset: 0x170
	private Guid zMQrjJHLSKAdKULhaCeyZgdoURgn; //Field offset: 0x174

	public virtual Guid deviceInstanceGuid
	{
		 get { } //Length: 219
	}

	public int sourceControllerId
	{
		 get { } //Length: 7
	}

	internal CustomController(QjMsBodnmZKgxByCmLKQMdgfRKQX unnamed_param_0) { }

	private CustomController(int unnamed_param_0, int unnamed_param_1, Guid unnamed_param_2, InputSource unnamed_param_3, string unnamed_param_4, string unnamed_param_5, string unnamed_param_6, int unnamed_param_7, int unnamed_param_8, HardwareControllerMap_Game unnamed_param_9, Extension unnamed_param_10, ControllerDataUpdater unnamed_param_11) { }

	public void ClearAxisValue(string elementName) { }

	public void ClearAxisValue(int index) { }

	public void ClearAxisValueById(int elementId) { }

	public void ClearButtonValue(int index) { }

	public void ClearButtonValue(string elementName) { }

	public void ClearButtonValueById(int elementId) { }

	public virtual Guid get_deviceInstanceGuid() { }

	public int get_sourceControllerId() { }

	internal void qyReUHBbUvMiifJDrBGYAckYVMJDb() { }

	public void SetAxisUpdateCallback(Func<Int32, Single> callback) { }

	public void SetAxisValue(string elementName, float value) { }

	public void SetAxisValue(int index, float value) { }

	public void SetAxisValueById(int elementId, float value) { }

	public void SetButtonUpdateCallback(Func<Int32, Boolean> callback) { }

	public void SetButtonValue(int index, bool value) { }

	public void SetButtonValue(string elementName, bool value) { }

	public void SetButtonValueById(int elementId, bool value) { }

}

