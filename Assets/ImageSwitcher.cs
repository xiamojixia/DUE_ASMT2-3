using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageSwitcher : MonoBehaviour
{
    public Image targetImage; // 在Inspector中拖放Image组件
    public Sprite newSprite; // 在Inspector中拖放要切换的图片
    public float delay = 3f; // 设置切换的延迟时间

    private void Start()
    {
        StartCoroutine(SwitchImageAfterDelay());
    }

    private IEnumerator SwitchImageAfterDelay()
    {
        yield return new WaitForSeconds(delay); // 等待特定时间
        if (targetImage != null && newSprite != null)
        {
            targetImage.sprite = newSprite; // 切换图片
        }
    }
}
