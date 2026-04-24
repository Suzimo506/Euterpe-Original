namespace DG.Tweening.Plugins.Core.PathCore;

public class Path
{
	private static CatmullRomDecoder _catmullRomDecoder; //Field offset: 0x0
	private static LinearDecoder _linearDecoder; //Field offset: 0x8
	private static CubicBezierDecoder _cubicBezierDecoder; //Field offset: 0x10
	public Single[] wpLengths; //Field offset: 0x10
	[SerializeField]
	internal PathType type; //Field offset: 0x18
	[SerializeField]
	internal int subdivisionsXSegment; //Field offset: 0x1C
	[SerializeField]
	internal int subdivisions; //Field offset: 0x20
	[SerializeField]
	internal Vector3[] wps; //Field offset: 0x28
	[SerializeField]
	internal ControlPoint[] controlPoints; //Field offset: 0x30
	[SerializeField]
	internal float length; //Field offset: 0x38
	[SerializeField]
	internal bool isFinalized; //Field offset: 0x3C
	[SerializeField]
	internal Single[] timesTable; //Field offset: 0x40
	[SerializeField]
	internal Single[] lengthsTable; //Field offset: 0x48
	internal int linearWPIndex; //Field offset: 0x50
	internal bool addedExtraStartWp; //Field offset: 0x54
	internal bool addedExtraEndWp; //Field offset: 0x55
	private Path _incrementalClone; //Field offset: 0x58
	private int _incrementalIndex; //Field offset: 0x60
	private ABSPathDecoder _decoder; //Field offset: 0x68
	private bool _changed; //Field offset: 0x70
	internal Vector3[] nonLinearDrawWps; //Field offset: 0x78
	internal Vector3 targetPosition; //Field offset: 0x80
	internal Nullable<Vector3> lookAtPosition; //Field offset: 0x8C
	internal Color gizmoColor; //Field offset: 0x9C

	public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor = null) { }

	internal Path() { }

	internal void AssignDecoder(PathType pathType) { }

	internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false) { }

	internal Path CloneIncremental(int loopIncrement) { }

	internal float ConvertToConstantPathPerc(float perc) { }

	internal void Destroy() { }

	internal void Draw() { }

	private static void Draw(Path p) { }

	internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) { }

	internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) { }

	internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false) { }

	internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) { }

	internal static void RefreshNonLinearDrawWps(Path p) { }

}

