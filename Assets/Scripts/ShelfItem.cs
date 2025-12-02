using UnityEngine;

public class ShelfItem : MonoBehaviour
{
    [Header("Properties")]
    public bool isFilled = false;
    public void MarkFilled()
    {
        isFilled = true;
    }
    public void MarkEmpty()
    {
        isFilled = false;
    }
}
