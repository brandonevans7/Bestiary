using UnityEngine;
using UnityEditor;

public class SaveEditor : EditorWindow
{
	public KeyDataGroup[] groups = new KeyDataGroup[]
	{
		new KeyDataGroup( "Shop Purchases",
			new KeyData[]
			{
				new KeyData( "gold", ValueType.Int ),
				new KeyData( "foodType", ValueType.String ),
				new KeyData( "foodExpiration", ValueType.String )


			} )
	};

	[System.Serializable]
	public struct KeyDataGroup
	{
		public string name;
		public KeyData[] keys;

		public KeyDataGroup( string n, KeyData[] k )
		{
			name = n;
			keys = k;
		}
	}

	[System.Serializable]
	public struct KeyData
	{
		public string key;
		public ValueType type;

		public KeyData( string k, ValueType t )
		{
			key = k;
			type = t;
		}
	}

	[System.Serializable]
	public enum ValueType
	{
		Int = 0,
		Float,
		String
	}

	private Vector2 scrollPos;

	[MenuItem ("Bestiary/Save Editor")]
	public static void ShowWindow()
	{
		EditorWindow.GetWindow(typeof(SaveEditor));
	}

	public void OnGUI()
	{
		scrollPos = GUILayout.BeginScrollView( scrollPos );

		for ( int groupIndex = 0; groupIndex < groups.Length; groupIndex++ )
		{
			GUILayout.Label( groups[ groupIndex ].name, EditorStyles.boldLabel );

			KeyData[] keys = groups[ groupIndex ].keys;
			for ( int keyIndex = 0; keyIndex < keys.Length; keyIndex++ )
			{
				GUILayout.BeginHorizontal();

				string key = keys[ keyIndex ].key;
				ValueType type = keys[ keyIndex ].type;
				GUILayout.Label( key + " (" + type + ")" );

				if ( type == ValueType.String )
				{
					string val = PlayerPrefs.GetString( keys[ keyIndex ].key, "" );
					string newVal = GUILayout.TextField( val );

					if ( newVal != val )
					{
						PlayerPrefs.SetString( key, newVal );
					}
				}
				else if ( type == ValueType.Int )
				{
					int val = PlayerPrefs.GetInt( keys[ keyIndex ].key, 0 );
					int newVal = val;
					try { newVal = int.Parse( GUILayout.TextField( "" + val ) ); } catch( System.Exception err ) { Debug.Log( "Fail: " + err ); }

					if ( newVal != val )
					{
						PlayerPrefs.SetInt( key, newVal );
					}
				}
				else if ( type == ValueType.Float )
				{
					float val = PlayerPrefs.GetFloat( keys[ keyIndex ].key, 0 );
					float newVal = val;
					try { newVal = float.Parse( GUILayout.TextField( "" + val ) ); } catch( System.Exception err ) { Debug.Log( "Fail: " + err ); }

					if ( newVal != val )
					{
						PlayerPrefs.SetFloat( key, newVal );
					}
				}

				GUILayout.EndHorizontal();
			}
		}

		GUILayout.EndScrollView();
	}
}