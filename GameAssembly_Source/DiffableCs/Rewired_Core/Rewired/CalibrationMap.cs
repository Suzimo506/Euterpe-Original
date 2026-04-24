namespace Rewired;

[CustomClassObfuscation]
public sealed class CalibrationMap
{
	private AxisCalibration[] zEpEITeaPBUpoVlrlWXwKvrwrmIC; //Field offset: 0x10
	private IList<AxisCalibration> XbHXNjubHamoSzobITMofjCITDIx; //Field offset: 0x18
	private readonly int VetpcoloufDUIHFBDUgRuDriUEsF; //Field offset: 0x20

	public IList<AxisCalibration> Axes
	{
		 get { } //Length: 5
	}

	public int axisCount
	{
		 get { } //Length: 14
	}

	private CalibrationMap() { }

	internal CalibrationMap(AxisCalibrationData[] unnamed_param_0) { }

	public CalibrationMap(AxisCalibration[] unnamed_param_0) { }

	private SerializedObject AqisXDDvDCPKwOpTfFxwWvniiRXz() { }

	private void bBPMtmGuSfSJmZxBxGjnMufsajeR(SerializedObject unnamed_param_0) { }

	internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone) { }

	public IList<AxisCalibration> get_Axes() { }

	public int get_axisCount() { }

	public AxisCalibration GetAxis(int index) { }

	public AxisCalibrationData GetAxisData(int index) { }

	internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) { }

	public float GetCalibratedValue(int axisIndex, float value) { }

	public bool ImportJsonString(string jsonString) { }

	public bool ImportXmlString(string xmlString) { }

	public void Reset() { }

	public bool SetAxisData(int index, AxisCalibrationData data) { }

	public string ToJsonString() { }

	public string ToXmlString() { }

}

