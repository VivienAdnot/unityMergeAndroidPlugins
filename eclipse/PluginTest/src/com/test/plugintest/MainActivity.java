package com.test.plugintest;

import com.unity3d.player.UnityPlayerNativeActivity;
import android.os.Bundle;

public class MainActivity extends UnityPlayerNativeActivity {
	private static int number = 0;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
	}
	
	public static int GetNumber() {
		number++;
		return number;
	}
}
