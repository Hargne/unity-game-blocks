using UnityEngine;
using UnityEditor;

namespace GameBlocks.References
{
	public abstract class ReferenceDrawer : PropertyDrawer
	{
		/// <summary>
		/// Options to display in the popup to select constant or variable.
		/// </summary>
		private readonly string[] popupOptions = 
			{ "Use Constant", "Use Variable" };

		/// <summary> Cached style to use to draw the popup button. </summary>
		private GUIStyle popupStyle;

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (popupStyle == null)
			{
				popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
				popupStyle.imagePosition = ImagePosition.ImageOnly;
			}

			label = EditorGUI.BeginProperty(position, label, property);
			position = EditorGUI.PrefixLabel(position, label);
			
			EditorGUI.BeginChangeCheck();

			// Get properties
			SerializedProperty useConstant = property.FindPropertyRelative("UseConstant");
			SerializedProperty constantValue = property.FindPropertyRelative("ConstantValue");
			SerializedProperty variable = property.FindPropertyRelative("Variable");

			// Calculate rect for configuration button
			Rect buttonRect = new Rect(position);
			buttonRect.yMin += popupStyle.margin.top;
			buttonRect.width = popupStyle.fixedWidth + popupStyle.margin.right;
			position.xMin = buttonRect.xMax;

			// Store old indent level and set it to 0, the PrefixLabel takes care of it
			int indent = EditorGUI.indentLevel;
			EditorGUI.indentLevel = 0;

			int result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, popupOptions, popupStyle);

			useConstant.boolValue = result == 0;

			EditorGUI.PropertyField(position, 
				useConstant.boolValue ? constantValue : variable, 
				GUIContent.none);

			if (EditorGUI.EndChangeCheck())
				property.serializedObject.ApplyModifiedProperties();

			EditorGUI.indentLevel = indent;
			EditorGUI.EndProperty();
		}
	}

	[CustomPropertyDrawer(typeof(FloatReference))]
	public class FloatReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(BoolReference))]
	public class BoolReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(ColorReference))]
	public class ColorReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(IntReference))]
	public class IntReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(GameObjectReference))]
	public class GameObjectReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(KeyCodeReference))]
	public class KeyCodeReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(LayerMaskReference))]
	public class LayerMaskReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(StringReference))]
	public class StringReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(Vector2Reference))]
	public class Vector2ReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(Vector2IntReference))]
	public class Vector2IntReferenceDrawer : ReferenceDrawer { }
	[CustomPropertyDrawer(typeof(Vector3Reference))]
	public class Vector3ReferenceDrawer : ReferenceDrawer { }
}