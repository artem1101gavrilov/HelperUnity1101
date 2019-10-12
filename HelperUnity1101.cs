using UnityEngine;

namespace HelperUnity1101
{
    public static class GameObject1101
    {
        public static void SwitchActivity(this GameObject gameObject)
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
