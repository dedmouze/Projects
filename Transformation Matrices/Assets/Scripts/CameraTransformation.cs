using UnityEngine;

public class CameraTransformation : Transformation
{
    [SerializeField] private float _focalLength;
    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(_focalLength, 0f, 0f, 0f));
            matrix.SetRow(1, new Vector4(0f, _focalLength, 0f, 0f));
            matrix.SetRow(2, new Vector4(0f, 0f, 0f, 0f));
            matrix.SetRow(3, new Vector4(0f, 0f, 1f, 0f));
            return matrix;
        }
    }
}
