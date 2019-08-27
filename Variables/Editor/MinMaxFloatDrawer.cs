using GameBlocks.Variables;
using UnityEngine;
using UnityEditor;

namespace Terrain
{
	[CustomPropertyDrawer(typeof(MinMaxFloat))]
	public class MinMaxFloatDrawer : PropertyDrawer {

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    	{
			EditorGUI.BeginProperty(position, label, property);

			// Draw label
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

			// Don't make child fields be indented
			var indent = EditorGUI.indentLevel;
			EditorGUI.indentLevel = 0;

			// Calculate rects
			var minRect = new Rect(position.x, position.y, 50, 20);
			var maxRect = new Rect(position.x, position.y + 50, 50, 20);
			var valueRect = new Rect(position.x, position.y + 100, 50, 20);

			GUI.backgroundColor = Color.cyan;

			// Draw fields - passs GUIContent.none to each so they are drawn without labels
			EditorGUI.PropertyField(minRect, property.FindPropertyRelative("min"), GUIContent.none);
			EditorGUI.PropertyField(maxRect, property.FindPropertyRelative("max"), GUIContent.none);
			EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("value"), GUIContent.none);

			// Set indent back to what it was
			EditorGUI.indentLevel = indent;

			EditorGUI.EndProperty();
		}
	}
}