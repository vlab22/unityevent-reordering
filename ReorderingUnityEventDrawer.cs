using UnityEditor;
using UnityEditorInternal;
using UnityEngine.Events;

namespace Editor
{
    [CustomPropertyDrawer(typeof(UnityEventBase), true)]
    public class ReorderingUnityEventDrawer : UnityEventDrawer
    {
        protected override void SetupReorderableList(ReorderableList list)
        {
            base.SetupReorderableList(list);

            list.draggable = true;
        }
    }
}
