using System;
using System.Collections.Generic;
using System.Linq;

public class CPHInline
{	
    
    public bool Execute()
    {
    	CPH.TryGetArg("sceneName", out string sceneName);
    	CPH.TryGetArg("sourceName", out string sourceName);
    	 	
    	var allClips = CPH.GetAllClips();
		
		allClips.Sort((clip1, clip2) => clip2.ViewCount.CompareTo(clip1.ViewCount));
		
		foreach(var clip in allClips)
		{
			var currentScene = CPH.ObsGetCurrentScene();
			if (!currentScene.Contains("Pause"))
			{
				var url = "about:blank";
				CPH.ObsSetBrowserSource(sceneName, sourceName, url);
				CPH.LogInfo("Broke loop");
				break;
			}
			else {
					
				var url = $"https://justedave.tv/randomClip.html?clipId={clip.Id}";
				var clipDurationDouble = Convert.ToDouble(clip.Duration) * 1000;
				var clipDuration = Convert.ToInt32(clipDurationDouble);
				
				CPH.ObsSetBrowserSource(sceneName, sourceName, url);
				
				CPH.ObsSetSourceVisibility(sceneName, sourceName, true);
				
				CPH.Wait(clipDuration + 300);	
				
				CPH.ObsSetSourceVisibility(sceneName, sourceName, false);
				
				CPH.Wait(1000);	
			}		
		}		
        return true; 
	}
}
