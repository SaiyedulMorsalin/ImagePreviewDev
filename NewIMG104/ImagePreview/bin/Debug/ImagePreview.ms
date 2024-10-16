


try(dotnet.loadassembly  (getFilenamePath  (getThisScriptFilename())+@"\ImagePreview.dll") )catch() 	
----------------------------------
	
rollout imageloader "small browser" width:240 height:270
(	
	dotNetControl small_dialog "ImagePreview.UserControl1"  pos:[0,0] width:480 height:480
		

	
	
	
	
	on imageloader open do
   (

	  
	   
   )
   
   edittext extentions "Extentions:" text:".jpg|.png|"
       button b01 "Refresh"
   on b01 pressed do 
   (
	   showMethods small_dialog
	   print "Reload"
	 
   )
   
   
   button b02 "Select directory"
   on b02 pressed do
   (
	   
	   mypath = thePath = getSavepath()
	  print mypath
		small_dialog.Populate mypath #()
		print "Select Directory...!"
	  
		
   )
	      
)



imagedialog = newRolloutFloater "small browser" 500 650
addRollout  imageloader imagedialog


