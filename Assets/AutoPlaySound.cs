using UnityEngine;

public class AutoPlaySoundOnLoad : MonoBehaviour
{
    public SoundManager soundManager; // 在Inspector中拖放SoundManager对象
    public float delayBeforeSound = 2f; // 切换后延迟播放的时间

    private void Start()
    {
        // 在场景加载时调用方法
        if (soundManager != null)
        {
            soundManager.PlaySoundAfterDelay(delayBeforeSound);
        }
    }
}