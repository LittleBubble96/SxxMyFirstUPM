using UnityEditor;
using UnityEngine;

namespace SxxMyFirstUPM {
    public class MyEditorMenu {
        [MenuItem("Tools/MyPackage/Hello")]
        static void Hello() {
            Debug.Log("Hello from MyPackage!");
        }
    }
}