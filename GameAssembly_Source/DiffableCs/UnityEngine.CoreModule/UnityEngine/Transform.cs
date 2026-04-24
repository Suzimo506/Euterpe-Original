namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer; //Field offset: 0x10
		private int currentIndex; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 76
		}

		internal Enumerator(Transform outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	public int childCount
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 129
		 set { } //Length: 168
	}

	public Vector3 forward
	{
		 get { } //Length: 261
		 set { } //Length: 168
	}

	[NativeProperty]
	public bool hasChanged
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int hierarchyCapacity
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int hierarchyCount
	{
		 get { } //Length: 51
	}

	public Vector3 localEulerAngles
	{
		 get { } //Length: 129
		 set { } //Length: 168
	}

	public Vector3 localPosition
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion localRotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public Vector3 localScale
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 87
	}

	public Vector3 lossyScale
	{
		[NativeMethod]
		 get { } //Length: 77
	}

	public Transform parent
	{
		 get { } //Length: 51
		 set { } //Length: 171
	}

	internal Transform parentInternal
	{
		internal get { } //Length: 51
		internal set { } //Length: 69
	}

	public Vector3 position
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Vector3 right
	{
		 get { } //Length: 261
		 set { } //Length: 254
	}

	public Transform root
	{
		 get { } //Length: 51
	}

	public Quaternion rotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal RotationOrder rotationOrder
	{
		internal get { } //Length: 51
		internal set { } //Length: 64
	}

	public Vector3 up
	{
		 get { } //Length: 261
		 set { } //Length: 254
	}

	public Matrix4x4 worldToLocalMatrix
	{
		 get { } //Length: 87
	}

	protected Transform() { }

	[FreeFunction]
	public void DetachChildren() { }

	public Transform Find(string n) { }

	[Obsolete]
	public Transform FindChild(string n) { }

	[FreeFunction]
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	[NativeMethod]
	public int get_childCount() { }

	public Vector3 get_eulerAngles() { }

	public Vector3 get_forward() { }

	public bool get_hasChanged() { }

	public int get_hierarchyCapacity() { }

	public int get_hierarchyCount() { }

	public Vector3 get_localEulerAngles() { }

	public Vector3 get_localPosition() { }

	private void get_localPosition_Injected(out Vector3 ret) { }

	public Quaternion get_localRotation() { }

	private void get_localRotation_Injected(out Quaternion ret) { }

	public Vector3 get_localScale() { }

	private void get_localScale_Injected(out Vector3 ret) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	[NativeMethod]
	public Vector3 get_lossyScale() { }

	private void get_lossyScale_Injected(out Vector3 ret) { }

	public Transform get_parent() { }

	internal Transform get_parentInternal() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Vector3 get_right() { }

	public Transform get_root() { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	internal RotationOrder get_rotationOrder() { }

	public Vector3 get_up() { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction]
	[NativeThrows]
	public Transform GetChild(int index) { }

	[NativeMethod]
	[Obsolete]
	public int GetChildCount() { }

	public override IEnumerator GetEnumerator() { }

	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	private void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret) { }

	private Transform GetParent() { }

	private Transform GetRoot() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeMethod]
	internal int GetRotationOrderInternal() { }

	public int GetSiblingIndex() { }

	[FreeFunction]
	private int internal_getHierarchyCapacity() { }

	[FreeFunction]
	private int internal_getHierarchyCount() { }

	[FreeFunction]
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	[FreeFunction]
	private void internal_setHierarchyCapacity(int value) { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	public Vector3 InverseTransformPoint(Vector3 position) { }

	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	public Vector3 InverseTransformVector(float x, float y, float z) { }

	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	[FreeFunction]
	public bool IsChildOf(Transform parent) { }

	[FreeFunction]
	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal bool IsNonUniformScaleTransform() { }

	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public void LookAt(Transform target, Vector3 worldUp) { }

	public void LookAt(Vector3 worldPosition) { }

	public void LookAt(Transform target) { }

	public void Rotate(Vector3 eulers) { }

	public void Rotate(Vector3 eulers, Space relativeTo) { }

	public void Rotate(Vector3 axis, float angle) { }

	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	[Obsolete]
	public void RotateAround(Vector3 axis, float angle) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	private void RotateAround_Injected(ref Vector3 axis, float angle) { }

	[NativeMethod]
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	[Obsolete]
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	private void RotateAroundLocal_Injected(ref Vector3 axis, float angle) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void SendTransformChangedScale() { }

	public void set_eulerAngles(Vector3 value) { }

	public void set_forward(Vector3 value) { }

	public void set_hasChanged(bool value) { }

	public void set_hierarchyCapacity(int value) { }

	public void set_localEulerAngles(Vector3 value) { }

	public void set_localPosition(Vector3 value) { }

	private void set_localPosition_Injected(ref Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	private void set_localRotation_Injected(ref Quaternion value) { }

	public void set_localScale(Vector3 value) { }

	private void set_localScale_Injected(ref Vector3 value) { }

	public void set_parent(Transform value) { }

	internal void set_parentInternal(Transform value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_right(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	internal void set_rotationOrder(RotationOrder value) { }

	public void set_up(Vector3 value) { }

	public void SetAsFirstSibling() { }

	public void SetAsLastSibling() { }

	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	private void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void SetLocalEulerHint(Vector3 euler) { }

	private void SetLocalEulerHint_Injected(ref Vector3 euler) { }

	public void SetParent(Transform p) { }

	[FreeFunction]
	public void SetParent(Transform parent, bool worldPositionStays) { }

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeMethod]
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	public void SetSiblingIndex(int index) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 TransformDirection(float x, float y, float z) { }

	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	public Vector3 TransformPoint(Vector3 position) { }

	public Vector3 TransformPoint(float x, float y, float z) { }

	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 TransformVector(float x, float y, float z) { }

	public Vector3 TransformVector(Vector3 vector) { }

	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	public void Translate(Vector3 translation, Space relativeTo) { }

	public void Translate(Vector3 translation) { }

	public void Translate(float x, float y, float z, Space relativeTo) { }

	public void Translate(float x, float y, float z) { }

	public void Translate(Vector3 translation, Transform relativeTo) { }

	public void Translate(float x, float y, float z, Transform relativeTo) { }

}

